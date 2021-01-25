// *******************************************************************
//1. Program Name:	NetCheck
//2. Module Name:	Class
//3. Unit Name:		Logger
//4. Programmer:	thep497
//5. Create date:	20210125
//6. Description:	Log4net implementation class
//     setup method from:  https://stackoverflow.com/questions/16336917/can-you-configure-log4net-in-code-instead-of-using-a-config-file
// *******************************************************************
// Revision : 0
// Edit history
// Rev 0: //th20210120 Initial this unit.
// *******************************************************************
using log4net;
using log4net.Repository.Hierarchy;
using log4net.Core;
using log4net.Appender;
using log4net.Layout;

namespace NNSClass
{
    public class Logger
    {
        private readonly ILog _log;
        private bool _active = false;
        private string _logFileName;

        public bool Active { get => _active; set => _active = value; }
        /// <summary>
        /// Name of the log file<br />
        /// Default is (appname).log
        /// </summary>
        public string LogFileName { get => _logFileName; }
        public enum LogLevel { Info, Warn, Error };

        public Logger(System.Type type, string logFilePath)
        {
            _active = false;
            _logFileName = string.Format(@"{0}\applog.log", 
                logFilePath);
                //System.IO.Path.GetFileNameWithoutExtension(System.Windows.Forms.Application.ExecutablePath)); //@"Log.log";

            _log = LogManager.GetLogger(type);

            //setup();
        }
        private void setup()
        {
            Hierarchy hierarchy = (Hierarchy)LogManager.GetRepository();

            PatternLayout patternLayout = new PatternLayout();
            patternLayout.ConversionPattern = "%date [%thread] %-5level %logger - %message%newline";
            patternLayout.ActivateOptions();

            RollingFileAppender roller = new RollingFileAppender();
            roller.AppendToFile = true;
            roller.LockingModel = new FileAppender.InterProcessLock(); ;
            roller.File = this._logFileName;
            roller.Layout = patternLayout;
            roller.MaxSizeRollBackups = 5;
            roller.MaximumFileSize = "1MB";
            roller.RollingStyle = RollingFileAppender.RollingMode.Size;
            roller.StaticLogFileName = true;
            roller.ActivateOptions();
            hierarchy.Root.AddAppender(roller);

            //MemoryAppender memory = new MemoryAppender();
            //memory.ActivateOptions();
            //hierarchy.Root.AddAppender(memory);

            hierarchy.Root.Level = Level.Info;
            hierarchy.Configured = true;
        }

        /// <summary>
        /// Collect string to the log with 3 different levels.<para />
        /// Log Level: Info, Warn, Error<br />
        /// (Also check for Active)
        /// </summary>
        /// <param name="logString">The string to collected.</param>
        /// <param name="level">Log Level.</param>
        public void Log(string logString, LogLevel level = LogLevel.Info)
        {
            if (_active)
            {
                //เพื่อให้สร้าง log file ตอนที่สั่ง log เท่านั้น
                if (!log4net.LogManager.GetRepository().Configured)
                    setup();

                logString = logString.Replace('\n', ' ');
                switch (level)
                {
                    case LogLevel.Warn:
                        _log.Warn(logString);
                        break;
                    case LogLevel.Error:
                        _log.Error(logString);
                        break;
                    default:
                        _log.Info(logString);
                        break;
                }
            }
        }
    }
}
