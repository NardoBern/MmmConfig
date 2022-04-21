using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmConfig
{
    public class AppLogger
    {
        public enum eLogLevel
        {
            info,
            debug,
            warning,
            error,
            fatal
        }
        
        private readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AppLogger() { log.Info("log4net has been istantiated"); }

        public void testLogger() { log.Info("This is a test of log4net library"); }

        public void addLine(string textToAppend, eLogLevel eLogLevel)
        {
            switch (eLogLevel)
            {
                case eLogLevel.info:
                    log.Info(textToAppend);
                    break;
                case eLogLevel.debug:
                    log.Debug(textToAppend);
                    break;
                case eLogLevel.warning:
                    log.Warn(textToAppend);
                    break;
                case eLogLevel.error:
                    log.Error(textToAppend);
                    break;
                case eLogLevel.fatal:
                    log.Fatal(textToAppend);
                    break;
            }
        }
    }
}
