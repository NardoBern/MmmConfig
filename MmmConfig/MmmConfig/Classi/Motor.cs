using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MmmConfig
{
    public class Motor
    {
                /* Motor status structure */
        
        public MotorStatus motorStatus = new MotorStatus();
        public Motor() {
            motorStatus.xEventEnabled = false;
        }

        public bool WriteMotorCmd(int iMotorIndex, int iMotorCmd, CPU_Connection _Connection)
        {
            switch (iMotorCmd)
            {
                case 0:
                    bool value = _Connection.readBool("LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xEnable");
                    _Connection.writeBool("LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xEnable", !(value));
                    return !(value);
                    
                case 1:
                    return true;
                    
                    
            }
            return true;
        }
    }
}
