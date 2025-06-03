using log4net;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SU.Classes.UR
{
    public class Association
    {
        public string Name { get; set; }
        public FileType Type { get; set; }
    }
    public class FileType
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string DefaultIcon { get; set; }
        public FileCommand ShellOpenCommand { get; set; }
        public FileCommand ShellRunAsCommand { get; set; }
        public FileCommand ShellRunAsUserCommand { get; set; }
    }
    public class FileCommand
    {
        public string Name { get; set; }
        public string DefaultCommand { get; set; }
        public string IsolatedCommand { get; set; }
        public string DelegateExecute { get; set; }
    }
    internal class Associations
    {
        private static ILog logger = LogManager.GetLogger(typeof(Associations));
        public static List<FileType> GetFileTypes()
        {
            List<FileType> FileTypes = new List<FileType>();

            foreach (string AKey in Registry.ClassesRoot.GetSubKeyNames().Where(a => !a.StartsWith(".")))
            {
                using (RegistryKey fileKey = Registry.ClassesRoot.OpenSubKey(AKey))
                {
                    if (fileKey == null) continue;

                    using (RegistryKey shell = fileKey.OpenSubKey("shell"))
                    {
                        if (shell == null) continue;

                        FileTypes.Add(CreateFileType(AKey, fileKey, shell));
                    }
                }
            }

            logger.Info($"FileTypes Count: {FileTypes.Count}");
            return FileTypes;
        }
        public static List<Association> GetAssocs()
        {
            List<Association> Assocs = new List<Association>();

            foreach (string AKey in Registry.ClassesRoot.GetSubKeyNames().Where(a => a.StartsWith(".")))
            {
                using (RegistryKey assocKey = Registry.ClassesRoot.OpenSubKey(AKey))
                {
                    if (assocKey == null) continue;

                    object defaultKey = assocKey.GetValue("");
                    if (defaultKey == null) continue;

                    using (RegistryKey fileKey = Registry.ClassesRoot.OpenSubKey(defaultKey.ToString()))
                    {
                        if (fileKey == null) continue;

                        using (RegistryKey shell = fileKey.OpenSubKey("shell"))
                        {
                            Assocs.Add(CreateAssociation(AKey, defaultKey.ToString(), fileKey, shell));
                        }
                    }
                }
            }

            logger.Info($"Associations Count: {Assocs.Count}");
            return Assocs;
        }

        private static Association CreateAssociation(string AKey, string defaultKeyName, RegistryKey fileKey, RegistryKey shell)
        {
            return new Association()
            {
                Name = AKey,
                Type = CreateFileType(defaultKeyName, fileKey, shell)
            };
        }

        public static Association CreateAssociation(string AKey, FileType fType, bool createInRegistry = false)
        {
            if (createInRegistry)
            {
                using (RegistryKey _aKey = Registry.ClassesRoot.CreateSubKey(AKey))
                {
                    _aKey.SetValue("", fType.Name);
                }
            }

            return new Association()
            {
                Name = AKey,
                Type = fType
            };
        }

        public static void UpdateAssocFileType(Association assoc, FileType fileType)
        {
            using (RegistryKey aKey = Registry.ClassesRoot.OpenSubKey(assoc.Name, true))
            {
                aKey.SetValue("", fileType.Name);
            }
        }

        public static FileType CreateFileType(string fileTypeName, RegistryKey fileKey, RegistryKey shell)
        {
            return new FileType()
            {
                Name = fileTypeName,
                Description = fileKey?.GetValue("")?.ToString(),
                DefaultIcon = fileKey.OpenSubKey("DefaultIcon")?.GetValue("")?.ToString(),
                ShellOpenCommand = CreateFileCommand(shell, "open"),
                ShellRunAsCommand = CreateFileCommand(shell, "runas"),
                ShellRunAsUserCommand = CreateFileCommand(shell, "runasuser")
            };
        }

        public static FileType CreateFileType(string fileTypeName, string description, string defaultIcon, FileCommand open, FileCommand runas, FileCommand runasuser)
        {
            using (RegistryKey ft = Registry.ClassesRoot.CreateSubKey(fileTypeName))
            {
                ft.SetValue("", description);
                ft.CreateSubKey("DefaultIcon").SetValue("", defaultIcon);

                using (RegistryKey shell = ft.CreateSubKey("shell"))
                {
                    FileCommand[] fC = new FileCommand[] { open, runas, runasuser };

                    foreach (FileCommand _fC in fC)
                    {
                        if (_fC == null || _fC.DefaultCommand != null && _fC.IsolatedCommand != null && _fC.DelegateExecute != null) continue;
                        
                        using (RegistryKey fCKey = shell.CreateSubKey(_fC.Name).CreateSubKey("command"))
                        {
                            if (_fC.DefaultCommand != null) fCKey.SetValue("", _fC.DefaultCommand);
                            if (_fC.IsolatedCommand != null) fCKey.SetValue("IsolatedCommand", _fC.IsolatedCommand);
                            if (_fC.DelegateExecute != null) fCKey.SetValue("DelegateExecute", _fC.DelegateExecute);
                        }
                    }
                }
            }

            return new FileType()
            {
                Name = fileTypeName,
                Description = description,
                DefaultIcon = defaultIcon,
                ShellOpenCommand = open,
                ShellRunAsCommand = runas,
                ShellRunAsUserCommand = runasuser
            };
        }

        private static FileCommand CreateFileCommand(RegistryKey shell, string commandName)
        {
            if (shell == null) return null;

            RegistryKey commandKey = shell.OpenSubKey(commandName);
            if (commandKey == null) return null;

            return new FileCommand()
            {
                DefaultCommand = commandKey.OpenSubKey("command")?.GetValue("")?.ToString(),
                IsolatedCommand = commandKey.OpenSubKey("command")?.GetValue("IsolatedCommand")?.ToString(),
                DelegateExecute = commandKey.OpenSubKey("command")?.GetValue("DelegateExecute")?.ToString()
            };
        }

        public static FileCommand CreateFileCommand(string name, string defaultCommand, string isolateCommand, string delegateCommand)
        {
            if (String.IsNullOrWhiteSpace(defaultCommand) && 
                String.IsNullOrWhiteSpace(isolateCommand) && 
                String.IsNullOrWhiteSpace(delegateCommand)) return null;

            return new FileCommand()
            {
                Name = name,
                DefaultCommand = !String.IsNullOrWhiteSpace(defaultCommand) ? defaultCommand : null,
                IsolatedCommand = !String.IsNullOrWhiteSpace(isolateCommand) ? isolateCommand : null,
                DelegateExecute = !String.IsNullOrWhiteSpace(delegateCommand) ? delegateCommand : null
            };
        }

        public static FileType UpdateFileType(FileType fileType, string defaultIcon, string description, FileCommand open, FileCommand runas, FileCommand runasuser)
        {
            FileType _fT = fileType;
            using (RegistryKey ft = Registry.ClassesRoot.OpenSubKey(fileType.Name, true))
            {
                ft.CreateSubKey("DefaultIcon").SetValue("", defaultIcon);
                ft.SetValue("", description);

                using (RegistryKey shell = ft.CreateSubKey("shell"))
                {
                    FileCommand[] fC = new FileCommand[] { open, runas, runasuser };

                    foreach (FileCommand _fC in fC)
                    {
                        if (_fC == null || _fC.DefaultCommand == null && _fC.IsolatedCommand == null && _fC.DelegateExecute == null)
                        {
                            try
                            {
                                shell.DeleteSubKeyTree(_fC.Name, false);
                            } 
                            catch (Exception ex) 
                            {
                                logger.Warn($"{ex.Message} - FileType: {fileType.Name}");
                            }
                            continue;
                        }
                        using (RegistryKey fCKey = shell.CreateSubKey(_fC.Name).CreateSubKey("command"))
                        {
                            fCKey.SetValue("", _fC.DefaultCommand ?? "");
                            fCKey.SetValue("IsolatedCommand", _fC.IsolatedCommand ?? "");
                            fCKey.SetValue("DelegateExecute", _fC.DelegateExecute ?? "");
                        }
                    }
                }
            }
            _fT.DefaultIcon = defaultIcon;
            _fT.Description = description;
            _fT.ShellOpenCommand = open;
            _fT.ShellRunAsCommand = runas;
            _fT.ShellRunAsUserCommand = runasuser;

            return _fT;
        }

        public static void RemoveFileType(FileType fileType)
        {
            try
            {
                Registry.ClassesRoot.DeleteSubKeyTree(fileType.Name);
            }
            catch (Exception ex)
            {
                logger.Error($"{ex.Message} - FileType: {fileType.Name}");
            }
        }

        public static void RemoveAssociation(Association assoc)
        {
            Console.WriteLine(assoc.Name);
            Registry.ClassesRoot.DeleteSubKeyTree(assoc.Name, false);
            try
            {
                using (RegistryKey aLink = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ApplicationAssociationToasts", true))
                {
                    aLink.DeleteValue($@"{assoc.Type.Name}_{assoc.Name}", false);
                }
                using (RegistryKey aLink = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FileExts", true))
                {
                    aLink.DeleteSubKeyTree(assoc.Name, false);
                }
            }
            catch (Exception ex)
            {
                logger.Warn($"{ex.Message} - Association: {assoc.Name}");
            }
        }
    }
}
