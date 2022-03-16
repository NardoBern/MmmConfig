using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TwinCAT.Ads;
using TwinCAT.Ams;
using TwinCAT.Ads.TcpRouter;
using System.Net;

namespace MmmConfig
{
    public class CPU_Connection
    {
        public AdsClient tcClient;
        public bool connected = false;
        public int iWatchDog = 0;
        public int iWatchDogOld = 0;
        public int iTimeOut = 0;
        public Motor Motors;
        public MemoryStream datastream;
        
        /*public CPU_Connection() {
            
        }*/
        
        
        /* Connection function */ 
        public AdsClient connect(string strNetId, int iport)
        {
            AdsClientSettings tcClientSettings = new AdsClientSettings(5000);
            AdsClient tcClient = new AdsClient();
                    
            var tcpRouter = new TwinCAT.Ads.TcpRouter.AmsTcpIpRouter(AmsNetId.Parse("192.168.193.70.1.1"));
            tcpRouter.AddRoute(new Route("CX-50CAF6", new AmsNetId("192.168.193.200.1.1"), new IPAddress[] { IPAddress.Parse("192.168.193.200") }));

            var routerTask = tcpRouter.StartAsync(System.Threading.CancellationToken.None);

            tcClient.Timeout = 5000;

            try
            {
                tcClient.Connect(strNetId, 851);
            }
            catch (TwinCAT.Ads.AdsErrorException e) {
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) { iTimeOut = iTimeOut + 1; }
                Console.WriteLine("Eccezione: " + e.ToString());
            }
            
            if (tcClient.IsConnected)
            {
               //connected = true;
                return tcClient;
            }
            else
            {
                //connected = false;
                return null;
            }
        }
        
        /* Disconnection function */
        public bool disconnect(AdsClient adsClient)
        {
            adsClient.Disconnect();
            adsClient.Dispose();
            if (adsClient.IsConnected)
            {
                //connected = true;
                return false;
            }
            else
            {
                //connected = false;
                return true;
            }
        }
        
        /* Check watch-dog value */
        public bool checkWdValue(int iWdValue)
        {
            if (iWdValue != iWatchDogOld) { connected = true; }
            else { connected = false; }
            iWatchDogOld = iWdValue;
            return connected;
        }

        /* Read integer value */
        public int readInt(string strVarName, AdsClient adsClient)
        {
            try
            {
                uint uiHandle = adsClient.CreateVariableHandle(strVarName);
                int readValue;
                readValue = (int)adsClient.ReadAny(uiHandle, typeof(int));
                adsClient.DeleteVariableHandle(uiHandle);           
                return readValue;
            }
            catch (TwinCAT.Ads.AdsErrorException e)
            {
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) { iTimeOut = iTimeOut + 1; }
                Console.WriteLine("Eccezione durante la lettura di un valore intero " + e.ToString());
                
                return 99;
            }
        }

        /* Write integer value */
        public bool writeInt(string strVarName, int iValue)
        {
            try
            {
                tcClient.WriteSymbolAsync(strVarName, iValue, System.Threading.CancellationToken.None);   
                return true;
            }
            catch (TwinCAT.Ads.AdsErrorException e)
            {
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) { iTimeOut = iTimeOut + 1; }
                Console.WriteLine("Eccezione durante la scrittura di un valore intero " + e.ToString());
                return false;
            }
        }

             
        /* Read boolean value */
        public bool readBool(string strVarName)
        {
            try
            {
                uint iHandle = tcClient.CreateVariableHandle(strVarName);
                MemoryStream datastream = new MemoryStream(1);
                BinaryReader binReader = new BinaryReader(datastream);
                tcClient.Read(iHandle, datastream.GetBuffer().AsMemory());
                return binReader.ReadBoolean();
            }
            catch (TwinCAT.Ads.AdsErrorException e)
            {
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) { iTimeOut = iTimeOut + 1; }
                Console.WriteLine("Eccezione durante la lettura di un valore boolean " + e.ToString());
                return false;
            }
        }

        /* Write boolena value */
        public bool writeBool(string strVarName, bool bValue)
        {
            try {
                tcClient.WriteSymbolAsync(strVarName, bValue, System.Threading.CancellationToken.None);
                return true;
            }
            catch (TwinCAT.Ads.AdsErrorException e)
            {
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) { iTimeOut = iTimeOut + 1; }
                Console.WriteLine("Eccezione durante la scrittura di un valore boolean " + e.ToString());
                return false;
            }
        }


        /* Add notification */
        public uint AddNotification(AdsClient adsClient, string strVariableName)
        {
            uint hTest;

            hTest = adsClient.AddDeviceNotification(strVariableName, 2,
                    new NotificationSettings(AdsTransMode.OnChange, 100, 0), null);

            return hTest;
        }





        /* Read motor Status */
        /*
        public Motor.stMotorsts readMotSts(int iMotIndex)
        {
            uint[] iHandle = new uint[7];
            try
            {
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
                tcClient.DeleteVariableHandle(iHandle[0]);
                stMotor.xError = binReader.ReadBoolean();
                tcClient.Read(iHandle[1], dataStream);
                tcClient.DeleteVariableHandle(iHandle[1]);
                stMotor.xMoving = binReader.ReadBoolean();
                tcClient.Read(iHandle[2], dataStream);
                tcClient.DeleteVariableHandle(iHandle[2]);
                stMotor.xSync = binReader.ReadBoolean();
                tcClient.Read(iHandle[3], dataStream);
                tcClient.DeleteVariableHandle(iHandle[3]);
                stMotor.xSetPosOk = binReader.ReadBoolean();
                tcClient.Read(iHandle[4], dataStream);
                tcClient.DeleteVariableHandle(iHandle[4]);
                stMotor.iSpeedRpm = binReader.ReadInt16();
                tcClient.Read(iHandle[5], dataStream);
                tcClient.DeleteVariableHandle(iHandle[5]);
                stMotor.iPosition = binReader.ReadInt16();
                tcClient.Read(iHandle[6], dataStream);
                tcClient.DeleteVariableHandle(iHandle[6]);
                stMotor.iCurrLoad = binReader.ReadInt16();
          
                return stMotor;
            }
            catch (TwinCAT.Ads.AdsErrorException e)
            {
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) { iTimeOut = iTimeOut + 1; }
                Console.WriteLine("Eccezione durante la lettura degli stati motore: " + e.ToString());
                Motor.stMotorsts stMotor = new Motor.stMotorsts();
                return stMotor;
            }
        }*/
    }
}
