using log4net;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace SU.Classes.UR
{
    /// <summary>
    /// Класс ограничения
    /// </summary>
    [DataContract]
    internal class Restriction
    {
        /// <summary>
        /// Ветки реестра где может быть расположено ограничение
        /// </summary>
        [DataMember]
        public RegistryHive[] RestrictionHive { get; set; }
        /// <summary>
        /// Путь до ограничения
        /// </summary>
        [DataMember]
        public string RestrictionKey { get; set; }
        /// <summary>
        /// Название ограничения
        /// </summary>
        [DataMember]
        public string RestrictionName { get; set; }
        /// <summary>
        /// Описание ограничения
        /// </summary>
        [DataMember]
        public string RestrictionDescription { get; set; }
        /// <summary>
        /// Значение деактивации данного ограничения
        /// </summary>
        [DataMember]
        public object DisableValue { get; set; }

        /// <summary>
        /// Разблокировка ограничения
        /// </summary>
        /// <param name="Delete">Удалить значение вместо изменение параметра</param>
        public void Unlock(bool Delete = false)
        {
            Parallel.ForEach(RestrictionHive, hive =>
            {
                using (RegistryKey Res = RegistryKey.OpenBaseKey(hive, RegistryView.Default))
                {
                    using (RegistryKey SKey = Res.OpenSubKey(RestrictionKey, true))
                    {
                        if (SKey == null || SKey.GetValue(RestrictionName) == null) return;

                        if (Delete) SKey.DeleteValue(RestrictionName);
                        else SKey.SetValue(RestrictionName, DisableValue ?? 0);
                    }
                }
            });
        }
    }


    internal class ScanRestrictionResult
    {
        public RegistryKey rKey;
        public Restriction restriction;
    }


    /// <summary>
    /// Класс со списком ограничений
    /// </summary>
    internal class RestrictionList
    {
        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        /// <summary>
        /// Список базовых ограничений
        /// </summary>
        public static List<Restriction> BasicRestrictions = new List<Restriction>()
        {
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser, RegistryHive.LocalMachine},
                RestrictionKey = @"Software\Microsoft\Windows\CurrentVersion\Policies\System",
                RestrictionName = "DisableTaskMgr",
                RestrictionDescription = "Блокировка диспетчера задач",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser, RegistryHive.LocalMachine},
                RestrictionKey = @"Software\Microsoft\Windows\CurrentVersion\Policies\System",
                RestrictionName = "DisableRegistryTools",
                RestrictionDescription = "Блокировка Редактора реестра",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser, RegistryHive.LocalMachine},
                RestrictionKey = @"Software\Policies\Microsoft\Windows\System",
                RestrictionName = "DisableCMD",
                RestrictionDescription = "Блокировка Командной строки",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"Software\Policies\Microsoft\MMC",
                RestrictionName = "RestrictToPermittedSnapins",
                RestrictionDescription = "Блокировка MMC",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoControlPanel",
                RestrictionDescription = "Блокировка панели управления и параметров Windows",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoRun",
                RestrictionDescription = "Блокировка окна выполнить",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser, RegistryHive.LocalMachine},
                RestrictionKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoViewOnDrive",
                RestrictionDescription = "Блокировка доступа к диску из проводника",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser, RegistryHive.LocalMachine},
                RestrictionKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoDrives",
                RestrictionDescription = "Скрытие диска из проводника",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoFind",
                RestrictionDescription = "Блокировка поиска в пуске",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoViewContextMenu",
                RestrictionDescription = "Блокировка контекстного меню",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoFolderOptions",
                RestrictionDescription = "Блокировка настройки папок",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoSecurityTab",
                RestrictionDescription = "Блокировка вкладки безопасность",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoFileMenu",
                RestrictionDescription = "Скрытие файла меню",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoClose",
                RestrictionDescription = "Блокировка возможности выключить компьютер через пуск",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoCommonGroups",
                RestrictionDescription = "Скрытие разделов из пуска",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "StartMenuLogOff",
                RestrictionDescription = "Скрытие выхода из системы в меню пуск",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"Software\Microsoft\Windows\CurrentVersion\Policies\ActiveDesktop",
                RestrictionName = "NoChangingWallPaper",
                RestrictionDescription = "Запрет на смену обоев",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoWinKeys",
                RestrictionDescription = "Отключение горячих клавиш",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoSetTaskbar",
                RestrictionDescription = "Запрет на внесение изменений в настройки панели задач и меню \"Пуск\"",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"Software\Microsoft\Windows\CurrentVersion\Policies\System",
                RestrictionName = "DisableLockWorkstation",
                RestrictionDescription = "Предотвращение блокировки системы пользователем",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"Software\Microsoft\Windows\CurrentVersion\Policies\System",
                RestrictionName = "DisableChangePassword",
                RestrictionDescription = "Запрет на смену пароля",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoTrayContextMenu",
                RestrictionDescription = "Запрет меню, которые появляются при щелчке правой кнопкой мыши на панели задач",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.LocalMachine},
                RestrictionKey = @"Software\Policies\Microsoft\Windows\System",
                RestrictionName = "DenyUsersFromMachGP",
                RestrictionDescription = "Пользователи не смогут вызывать обновление политики компьютера.",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.LocalMachine},
                RestrictionKey = @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "HidePowerOptions",
                RestrictionDescription = "Команды выключения, перезагрузки, сна и т. д. будут удалены из меню \"Пуск\". Кнопка питания также удалена с экрана безопасности Windows.",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.LocalMachine, RegistryHive.CurrentUser},
                RestrictionKey = @"Software\Policies\Microsoft\Windows\Explorer",
                RestrictionName = "DisableContextMenusInStart",
                RestrictionDescription = "Запрет пользователям открывать контекстные меню в меню \"Пуск\"",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.LocalMachine},
                RestrictionKey = @"Software\Policies\Microsoft\Windows NT\SystemRestore",
                RestrictionName = "DisableSR",
                RestrictionDescription = "Восстановление системы отключится, и мастер восстановления системы будет недоступен.",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.LocalMachine},
                RestrictionKey = @"Software\Policies\Microsoft\Windows NT\SystemRestore",
                RestrictionName = "DisableConfig",
                RestrictionDescription = "Возможность настройки восстановления системы с помощью защиты системы будет отключена.",
                DisableValue = 0
            },
            new Restriction()
            {
                RestrictionHive = new RegistryHive[] {RegistryHive.CurrentUser},
                RestrictionKey = @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer",
                RestrictionName = "NoLogoff",
                RestrictionDescription = "Блокировка возможности выйти из системы",
                DisableValue = 0
            }
        };

        /// <summary>
        /// Получение списка заблокированных приложений через DisallowRun
        /// </summary>
        /// <returns>Список ограничений</returns>
        public static async Task GetDisallowApps(IProgress<ScanRestrictionResult> progress)
        {
            await Task.Run(() =>
            {
                using (RegistryKey Res = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default))
                {
                    using (RegistryKey DisallowRun = Res.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun"))
                    {
                        if (DisallowRun == null) return;

                        foreach (string value in DisallowRun.GetValueNames())
                        {
                            progress.Report(new ScanRestrictionResult()
                            {
                                rKey = Res,
                                restriction = new Restriction()
                                {
                                    RestrictionHive = new RegistryHive[] { RegistryHive.CurrentUser },
                                    RestrictionKey = @"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer\DisallowRun",
                                    RestrictionDescription = $"Блокировка приложения \"{DisallowRun.GetValue(value)}\" [DisallowRun]",
                                    RestrictionName = value
                                }
                            });
                        }
                    }
                }
            });
        }

        //Подумать над системой обнаружения дебаггера в ключах и подключах
        /// <summary>
        /// Получение списка заблокированных приложений через Debugger
        /// </summary>
        /// <returns>Список ограничений</returns>
        public static async Task GetDebuggerApps(IProgress<ScanRestrictionResult> progress)
        {
            await Task.Run(() =>
            {
                using (RegistryKey Res = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Default))
                {
                    using (RegistryKey Debugger = Res.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options"))
                    {
                        if (Debugger == null) return;

                        foreach (string SubKey in Debugger.GetSubKeyNames())
                        {
                            try
                            {
                                using (RegistryKey DebguggerSKey = Debugger.OpenSubKey(SubKey))
                                {
                                    logger.Debug($"Getting {SubKey} Debugger");
                                    object Value = DebguggerSKey.GetValue("Debugger");
                                    if (Value != null)
                                    {

                                        progress.Report(new ScanRestrictionResult()
                                        {
                                            rKey = Res,
                                            restriction = new Restriction()
                                            {
                                                RestrictionHive = new RegistryHive[] { RegistryHive.LocalMachine },
                                                RestrictionKey = $@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Image File Execution Options\{SubKey}",
                                                RestrictionDescription = $"Обнаружен дебаггер приложения \"{SubKey}\" ({Value}) [Debugger]",
                                                RestrictionName = "Debugger"
                                            }
                                        });
                                    }
                                }
                            }
                            catch (Exception ex)
                            {
                                logger.Error($"Не удалось получить список дебаггеров ({ex.Message})");
                            }
                        }
                    }
                }
            });
        }

        public static async Task GetBasicRestictions(IProgress<ScanRestrictionResult> progress)
        {
            await Task.Run(() =>
            {
                foreach (Restriction Basic in BasicRestrictions)
                {
                    Parallel.ForEach(Basic.RestrictionHive, hive =>
                    {
                        using (RegistryKey Res = RegistryKey.OpenBaseKey(hive, RegistryView.Default))
                        {
                            using (RegistryKey SKey = Res.OpenSubKey(Basic.RestrictionKey))
                            {
                                if (SKey == null) return;

                                object val = SKey.GetValue(Basic.RestrictionName);
                                if (val != null && ((int)val != (int)Basic.DisableValue || (int)val == 1))
                                {
                                    progress.Report(new ScanRestrictionResult() { 
                                        rKey = Res,
                                        restriction = Basic
                                    });
                                }
                            }
                        }
                    });
                }
            });
        }

        public static async Task GetCustomRestrictions(IProgress<ScanRestrictionResult> progress)
        {
            await Task.Run(() =>
            {
                foreach (string file in Directory.EnumerateFiles("restrictions", "*.rsu"))
                {
                    try
                    {
                        Restriction r = JSONHelper.Deserialize<Restriction>(File.ReadAllText(file));

                        Parallel.ForEach(r.RestrictionHive, hive =>
                        {
                            using (RegistryKey Res = RegistryKey.OpenBaseKey(hive, RegistryView.Default))
                            {
                                using (RegistryKey SKey = Res.OpenSubKey(r.RestrictionKey))
                                {
                                    if (SKey.GetValue(r.RestrictionName) != null && (r.DisableValue == null || (int)SKey.GetValue(r.RestrictionName) != (int)r.DisableValue))
                                    {
                                        r.RestrictionHive = new RegistryHive[] { hive };
                                        r.RestrictionDescription = $"{r.RestrictionDescription} [Кастомное ограничение]";
                                        progress.Report(new ScanRestrictionResult()
                                        {
                                            rKey = Res,
                                            restriction = r
                                        });
                                    }
                                }
                            }
                        });
                    }
                    catch { };
                }
            });
        }
    }
}
