using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmConfig
{
    public class EventLogger
    {
        public int iFreePos;
        public int iLastWritePos;
        public Event[] events;
        const int iEventSize = 999;
        public bool xEventEnabled;
        public uint uiVarHandle;

        public EventLogger()
        {
            //int _i;
            events = new Event[iEventSize];
            /*for (_i = 0; _i <= iEventSize; _i++)
            {
                events[_i] = new Event();
            }*/
        
        }
    }
}
