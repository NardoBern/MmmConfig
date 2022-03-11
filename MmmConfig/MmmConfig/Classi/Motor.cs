using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MmmConfig
{
    public class Motor
    {
                /* Motor status structure */
        public struct stMotorsts
        {
            public bool xError;
            public bool xMoving;
            public bool xSync;
            public bool xSetPosOk;
            public int iSpeedRpm;
            public int iPosition;
            public int iCurrLoad;
        }
    }
}
