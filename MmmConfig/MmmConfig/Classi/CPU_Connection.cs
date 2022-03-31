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
        #region Variable declarations
        public AdsClient tcClient;
        public bool connected = false;
        public int iWatchDog = 0;
        public int iWatchDogOld = 0;
        public int iTimeOut = 0;
        public Motor Motors;
        public MemoryStream datastream;
        #endregion

        #region Connection methods
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
        #endregion

        #region Check watchdog method
        /* Check watch-dog value */
        public bool checkWdValue(int iWdValue)
        {
            if (iWdValue != iWatchDogOld) { connected = true; }
            else { connected = false; }
            iWatchDogOld = iWdValue;
            return connected;
        }
        #endregion

        #region Read methods
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
        /* Read boolean value */
        public bool readBool(string strVarName, AdsClient adsClient)
        {
            try
            {
                uint uiHandle = adsClient.CreateVariableHandle(strVarName);
                bool readValue;
                readValue = (bool)adsClient.ReadAny(uiHandle, typeof(bool));
                adsClient.DeleteVariableHandle(uiHandle);
                return readValue;
            }
            catch (TwinCAT.Ads.AdsErrorException e)
            {
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) { iTimeOut = iTimeOut + 1; }
                Console.WriteLine("Eccezione durante la lettura di un valore boolean " + e.ToString());
                return false;
            }
        }
        #endregion

        #region Write methods
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

        /* Write boolena value */
        public bool writeBool(string strVarName, bool bValue)
        {
            try
            {
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
        #endregion

        #region Add notification method
        /* Add notification */
        public uint AddNotification(AdsClient adsClient, string strVariableName)
        {
            uint hTest;

            hTest = adsClient.AddDeviceNotification(strVariableName, 2,
                    new NotificationSettings(AdsTransMode.OnChange, 100, 0), null);

            return hTest;
        }
        #endregion

    }
}
