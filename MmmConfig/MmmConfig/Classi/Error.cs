using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmConfig
{
    public enum enumErrorName
    {
        eNoError,
        eResetMasterEncoder,
        eZeroMasterEncoder,
        eFbAxisManager,
        eResetAxis,
        aAxisHoming,
        eGearIn,
        eGearOut,
        ePhasing,
        ePower,
        eJog,
        eMoveVel,
        eSetPos
    }
    public class Error
    {
        public bool xErrorGlobal;
        public enumErrorName enumErrorName;
        public bool[] axErrBit;
        public uint[] audiErrId;
        public Error()
        {
            bool[] axErrBit = new bool[16];
            uint[] audiErrId = new uint[16];
        }
    }

    
}
