using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmConfig
{
    public class MotorStatus
    {
        /* Status */
        public bool xError;
        public bool xMoving;
        public bool xSync;
        public bool xSetPosOk;
        public int iSpeedRpm;
        public int iPosition;
        public int iCurrLoad;

        /* Management variable */
        public bool xEventEnabled;
        public int iNumOfVar = 7;
        public uint[] uiVarHandle;
    }
}
