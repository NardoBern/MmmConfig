using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TwinCAT.Ads;

namespace MmmConfig
{
    class CPU_Connection
    {
        public TcAdsClient tcClient;
        public bool connected = false;
        public Motor Motors;
        
        public CPU_Connection() { }
        
        
        /* Connection function */ 
        public bool connect(string strNetId, int iport)
        {
            tcClient = new TcAdsClient();
            tcClient.Timeout = 20;
            tcClient.Connect(strNetId, iport);
            if (tcClient.IsConnected)
            {
                connected = true;
                return true;
            }
            else
            {
                connected = false;
                return false;
            }
        }
        
        /* Disconnection function */
        public bool disconnect()
        {
            tcClient.Disconnect();
            tcClient.Dispose();
            if (tcClient.IsConnected)
            {
                connected = true;
                return false;
            }
            else
            {
                connected = false;
                return true;
            }
        }
        
        /* Read integer value */
        public int readInt(string strVarName)
        {
            int iHandle = tcClient.CreateVariableHandle(strVarName);
            AdsStream dataStream = new AdsStream(2);
            BinaryReader binReader = new BinaryReader(dataStream);
            tcClient.Read(iHandle, dataStream);
            return binReader.ReadInt16();
        }

        /* Write integer value */
        public bool writeInt(string strVarName, int iValue)
        {
            tcClient.WriteSymbol(strVarName, iValue, false);
            return true;
        }

        /* Read motor Status */
        public Motor.stMotorsts readMotSts(int iMotIndex)
        {
            int[] iHandle = new int[7];
            iHandle[0] = tcClient.CreateVariableHandle("Loc_AdsIO.stOutput.MotorSts[" + iMotIndex + "].xError");
            iHandle[1] = tcClient.CreateVariableHandle("Loc_AdsIO.stOutput.MotorSts[" + iMotIndex + "].xMoving");
            iHandle[2] = tcClient.CreateVariableHandle("Loc_AdsIO.stOutput.MotorSts[" + iMotIndex + "].xInSync");
            iHandle[3] = tcClient.CreateVariableHandle("Loc_AdsIO.stOutput.MotorSts[" + iMotIndex + "].xSetPosOk");
            iHandle[4] = tcClient.CreateVariableHandle("Loc_AdsIO.stOutput.MotorSts[" + iMotIndex + "].iSpeedRpm");
            iHandle[5] = tcClient.CreateVariableHandle("Loc_AdsIO.stOutput.MotorSts[" + iMotIndex + "].iPosition");
            iHandle[6] = tcClient.CreateVariableHandle("Loc_AdsIO.stOutput.MotorSts[" + iMotIndex + "].iCurrLoad");
            AdsStream dataStream = new AdsStream(10);
            BinaryReader binReader = new BinaryReader(dataStream);
            Motor.stMotorsts stMotor = new Motor.stMotorsts();
            tcClient.Read(iHandle[0], dataStream);
            stMotor.xError = binReader.ReadBoolean();
            tcClient.Read(iHandle[1], dataStream);
            stMotor.xMoving = binReader.ReadBoolean();
            tcClient.Read(iHandle[2], dataStream);
            stMotor.xSync = binReader.ReadBoolean();
            tcClient.Read(iHandle[3], dataStream);
            stMotor.xSetPosOk = binReader.ReadBoolean();
            tcClient.Read(iHandle[4], dataStream);
            stMotor.iSpeedRpm = binReader.ReadInt16();
            tcClient.Read(iHandle[5], dataStream);
            stMotor.iPosition = binReader.ReadInt16();
            tcClient.Read(iHandle[6], dataStream);
            stMotor.iCurrLoad = binReader.ReadInt16();
            return stMotor;
        }
    }
}
