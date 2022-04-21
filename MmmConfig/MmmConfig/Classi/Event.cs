using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmConfig
{
    public enum eTypeOfEvent
    {
        Info,
        Message,
        Warning,
        Error
    }
    public class Event
    {
        #region Variable declaration
        public uint uiEventId;
        public string strDeviceName;
        public eTypeOfEvent eTypeOfEvent;
        public string strTimeStamp;
        public bool xWrite;
        public Error error;
        public string strMessage;
        public string strAlert;
        public OperationLog operationLog;
        #endregion
    }
}
