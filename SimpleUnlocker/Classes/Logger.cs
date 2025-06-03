using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;
using log4net.Appender;
using log4net.Core;
using log4net.Layout;
using log4net.Repository.Hierarchy;
using static log4net.Appender.ColoredConsoleAppender;

namespace SU.Classes
{
    internal class Logger
    {
        private const string LogPattern = "%timestamp [%thread] %-5level %logger - %message%newline";
        private static Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();
        private static ColoredConsoleAppender coloredConsoleAppender = new ColoredConsoleAppender();
        public static MemoryAppender MemoryAppender = new MemoryAppender();
        public static void Init()
        {
            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = LogPattern;//"%date| %level | %message%newline";
            patternLayout.ActivateOptions();

            LevelColors errorColors = new LevelColors()
            {
                ForeColor = Colors.Red | Colors.HighIntensity,
                Level = Level.Error
            };

            LevelColors infoColors = new LevelColors()
            {
                ForeColor = Colors.Cyan | Colors.HighIntensity,
                Level = Level.Info
            };

            LevelColors warnColors = new LevelColors()
            {
                ForeColor = Colors.Yellow,
                Level = Level.Warn
            };

            LevelColors debugColors = new LevelColors()
            {
                ForeColor = Colors.Blue | Colors.HighIntensity,
                Level = Level.Debug
            };

            coloredConsoleAppender.Layout = patternLayout;
            coloredConsoleAppender.AddMapping(errorColors);
            coloredConsoleAppender.AddMapping(infoColors);
            coloredConsoleAppender.AddMapping(warnColors);
            coloredConsoleAppender.AddMapping(debugColors);
            coloredConsoleAppender.ActivateOptions();
            hierarchy.Root.AddAppender(coloredConsoleAppender);

            MemoryAppender.Layout = patternLayout;
            MemoryAppender.ActivateOptions();
            hierarchy.Root.AddAppender(MemoryAppender);
            hierarchy.Configured = true;
        }
    }
}
