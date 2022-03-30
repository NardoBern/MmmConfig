using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TwinCAT.Ads;
using System.Windows.Forms;

namespace MmmConfig
{
    public class Motor
    {
                /* Motor status structure */
        
        public MotorStatus motorStatus = new MotorStatus();
        /*public Motor() {
            motorStatus.xEventEnabled = false;
            for (int i = 0; i<8; i++)
            {
                motorStatus.uiVarHandle[i] = 0;
            }
        }*/

        public bool WriteMotorCmd(int iMotorIndex, int iMotorCmd, CPU_Connection _Connection)
        {
            bool value = false;
            switch (iMotorCmd)
            {
                case 0:
                    value = _Connection.readBool("LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xEnable", _Connection.tcClient);
                    _Connection.writeBool("LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xEnable", !(value));
                    return !(value);
                    
                case 1:
                    value = _Connection.readBool("LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xMoveFw", _Connection.tcClient);
                    _Connection.writeBool("LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xMoveFw", !(value));
                    return !(value);
                case 2:
                    value = _Connection.readBool("LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xMoveBw", _Connection.tcClient);
                    _Connection.writeBool("LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xMoveBw", !(value));
                    return !(value);
                case 3:
                    value = _Connection.readBool("LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xSyncOn", _Connection.tcClient);
                    _Connection.writeBool("LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xSyncOn", !(value));
                    return !(value);
                case 4:
                    value = _Connection.readBool("LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xSetPos", _Connection.tcClient);
                    _Connection.writeBool("LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xSetPos", !(value));
                    return !(value);
            }
            return true;
        }
    }
}
