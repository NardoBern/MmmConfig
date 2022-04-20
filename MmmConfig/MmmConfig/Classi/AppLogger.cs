using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmConfig
{
    public class AppLogger
    {
        private readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public AppLogger() { log.Info("log4net è stato istanziato"); }

        public void testLogger() { log.Info("This is a test of log4net library"); }
    }
}
