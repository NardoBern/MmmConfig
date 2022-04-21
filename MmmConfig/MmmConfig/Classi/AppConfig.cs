using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmConfig
{
    public class AppConfig
    {
        #region Variable declaration
        public bool xConfigLoaded;
        public string strDefaultNetId;
        public int iDefaultPort;
        public string strMotionEventLogPath;
        public string strEventLogSize;
        public string strReadWatchDog;
        public string strWriteWatchDog;
        public string strMotCfgWrite;
        public string strMotCfgRead;
        public string strMotStatus;
        public string strMotCommands;
        #endregion

        #region Class constructor
        public AppConfig()
        {
            string strDefaultNetId = "192.168.193.200.1.1";
            int iDefaultPort = 851;
            string strMotionEventLogPath;
            string strEventLogSize;
            string strReadWatchDog;
            string strWriteWatchDog;
            string strMotCfgWrite;
            string strMotCfgRead;
            string strMotStatus;
            string strMotCommands;
        }
        #endregion
    }
}
