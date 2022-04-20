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
        #region Variable declaration
        /* Motor status structure */
        public MotorStatus motorStatus = new MotorStatus();
        /* Motor config structure */
        public MotorConfig motorConfig = new MotorConfig();
        #endregion

        #region Write functions
        public bool WriteMotorCmd(int iMotorIndex, int iMotorCmd, CPU_Connection _Connection)
        {
            bool value = false;
            try {
                switch (iMotorCmd)
                {
                    case 0:
                        value = _Connection.readBool(Forms.MainSelector.appConfig.strMotCommands + iMotorIndex + "].xEnable", _Connection.tcClient);  //"LOC_AdsIO.stInput.MotorCmd[" + iMotorIndex + "].xEnable", _Connection.tcClient);
                        _Connection.writeBool(Forms.MainSelector.appConfig.strMotCommands + iMotorIndex + "].xEnable", !(value));
                        return !(value);

                    case 1:
                        value = _Connection.readBool(Forms.MainSelector.appConfig.strMotCommands + iMotorIndex + "].xMoveFw", _Connection.tcClient);
                        _Connection.writeBool(Forms.MainSelector.appConfig.strMotCommands + iMotorIndex + "].xMoveFw", !(value));
                        return !(value);
                    case 2:
                        value = _Connection.readBool(Forms.MainSelector.appConfig.strMotCommands + iMotorIndex + "].xMoveBw", _Connection.tcClient);
                        _Connection.writeBool(Forms.MainSelector.appConfig.strMotCommands + iMotorIndex + "].xMoveBw", !(value));
                        return !(value);
                    case 3:
                        value = _Connection.readBool(Forms.MainSelector.appConfig.strMotCommands + iMotorIndex + "].xSyncOn", _Connection.tcClient);
                        _Connection.writeBool(Forms.MainSelector.appConfig.strMotCommands + iMotorIndex + "].xSyncOn", !(value));
                        return !(value);
                    case 4:
                        value = _Connection.readBool(Forms.MainSelector.appConfig.strMotCommands + iMotorIndex + "].xSetPos", _Connection.tcClient);
                        _Connection.writeBool(Forms.MainSelector.appConfig.strMotCommands + iMotorIndex + "].xSetPos", !(value));
                        return !(value);
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while writing a motor command. Motor Index: " + iMotorIndex.ToString() + " Motor Command: " + iMotorCmd.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        public bool WriteMotorParam(int iMotorIndex, int iParNum, CPU_Connection _Connection, string partialStatusPath, int iParValue)
        {
            try { 
                switch (iParNum)
                {
                    case 1:
                        _Connection.writeInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iSyncMaster", iParValue);
                        return true;
                    case 2:
                        _Connection.writeInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].diGearIn", iParValue);
                        return true;
                    case 3:
                        _Connection.writeInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].diGearOut", iParValue);
                        return true;
                    case 4:
                        _Connection.writeInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iNrOfPhases", iParValue);
                        return true;
                    case 5:
                        _Connection.writeInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iFixedSpeed", iParValue);
                        return true;
                    case 6:
                        _Connection.writeInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].uiMaxSpeed", iParValue);
                        return true;
                    case 7:
                        _Connection.writeInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iStartRamp", iParValue);
                        return true;
                    case 8:
                        _Connection.writeInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iStopRamp", iParValue);
                        return true;
                    case 9:
                        _Connection.writeInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].eStopRamp", iParValue);
                        return true;
                    case 10:
                        _Connection.writeInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iCurrLimit", iParValue);
                        return true;
                    default:
                        return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while writing a motor parameter. Motor index: " + iMotorIndex.ToString() + " Motor parameter: " + iParNum.ToString() + " Partial parameter path: " + partialStatusPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
        #endregion

        #region Read functions
        public bool[] ReadMotorSts(int iMotorIndex, CPU_Connection _Connection, string partialStatusPath)
        {
            bool[] status;
            status = new bool[4];
            try {
                status[0] = _Connection.readBool(partialStatusPath + "[" + iMotorIndex.ToString() + "].xError", _Connection.tcClient);
                status[1] = _Connection.readBool(partialStatusPath + "[" + iMotorIndex.ToString() + "].xMoving", _Connection.tcClient);
                status[2] = _Connection.readBool(partialStatusPath + "[" + iMotorIndex.ToString() + "].xInSync", _Connection.tcClient);
                status[3] = _Connection.readBool(partialStatusPath + "[" + iMotorIndex.ToString() + "].xSetPosOk", _Connection.tcClient);
                return status;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading motor status. Motor index: " + iMotorIndex.ToString() + " Partial status path: " + partialStatusPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public int[] ReadMotorValFdbk(int iMotorIndex, CPU_Connection _Connection, string partialStatusPath)
        {
            int[] values;
            values = new int[3];
            try { 
                values[0] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iSpeedRpm", _Connection.tcClient);
                values[1] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iPosition", _Connection.tcClient);
                values[2] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iCurrLoad", _Connection.tcClient);
                return values;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading motor feedback. Motor index: " + iMotorIndex.ToString() + " Partial feedback path: " + partialStatusPath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
                return null;
            }
        }

        public int[] ReadMotorConfig(int iMotorIndex, CPU_Connection _Connection, string partialStatusPath)
        {
            int[] values;
            values = new int[10];
            values[0] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iSyncMaster", _Connection.tcClient);
            values[1] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].diGearIn", _Connection.tcClient);
            values[2] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].diGearOut", _Connection.tcClient);
            values[3] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iNrOfPhases", _Connection.tcClient);
            values[4] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iFixedSpeed", _Connection.tcClient);
            values[5] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].uiMaxSpeed", _Connection.tcClient);
            values[6] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iStartRamp", _Connection.tcClient);
            values[7] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iStopRamp", _Connection.tcClient);
            values[8] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].eStopRamp", _Connection.tcClient);
            values[9] = _Connection.readInt(partialStatusPath + "[" + iMotorIndex.ToString() + "].iCurrLimit", _Connection.tcClient);
            return values;
        }
        #endregion
    }
}
