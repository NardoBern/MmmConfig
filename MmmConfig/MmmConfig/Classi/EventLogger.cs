using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmConfig
{
    public class EventLogger
    {
        #region Variable declaration
        public int iFreePos;
        public int iLastWritePos;
        public Event[] events;
        public const int iEventSize = 1000;
        public bool xEventEnabled;
        public uint uiVarHandle;
        #endregion

        public EventLogger() {events = new Event[iEventSize];}
    }
}
