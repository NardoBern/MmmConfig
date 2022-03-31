using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmConfig
{
    public class MotorConfig
    {
        /* Mechanic */
        public int      iMotorType;
        public int      iSyncMaster;
        public Int32    diGearIn;
        public Int32    diGearOut;
        public int      iNrOfPhases;

        /* References */
        public int      iFixedSpeed;
        public uint     uiMaxSpeed;
        public int      iStartRamp;
        public int      iStopRamp;
        public int      eStopRamp;
        public int      iCurrLimit;
        public int      _iReserve;
    }
}
