using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;
using System.Buffers.Binary;
using System.Net;
using System.Net.NetworkInformation;
using TwinCAT.Ads.TcpRouter;

namespace MmmConfig.Classi
{
    class DiagCommProt
    {
        #region Variable declarations
        public bool xCmdReq;
        public uint uiInfoReq;
        public bool xStsAck;
        public bool xStsErr;
        public int iSizeOf;
        public string[,] astrData = new string[199, 3];
        private uint uiAckHandle;
        private uint uiErrHandle;

        public AdsClient tcClient;
        public bool connected = false;
        public int iWatchDog = 0;
        public int iWatchDogOld = 0;
        public int iTimeOut = 0;
        public int iCommErr = 0;
        #endregion

        #region Connection methods
        /* Connection function */
        public AdsClient connect(string strNetId, int iport, string strAdsRoute)
        {
            AdsClientSettings tcClientSettings = new AdsClientSettings(5000);
            AdsClient tcClient = new AdsClient();
            string pcNetId = "";
            IPAddress iPAddress;

            iPAddress = getIpAddress(strAdsRoute);
            if (iPAddress != null) { pcNetId = iPAddress.ToString() + ".1.1"; }
            else { MessageBox.Show("Your have to set your PC ip-address equal to: " + strAdsRoute, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return null; }

            var tcpRouter = new TwinCAT.Ads.TcpRouter.AmsTcpIpRouter(AmsNetId.Parse(pcNetId));
            tcpRouter.AddRoute(new Route("CX-50CAF6", new AmsNetId(strNetId), new IPAddress[] { IPAddress.Parse(strNetId.Remove(strNetId.Length - 4)) }));

            var routerTask = tcpRouter.StartAsync(System.Threading.CancellationToken.None);

            tcClient.Timeout = 5000;

            try { tcClient.Connect(strNetId, iport); }
            catch (TwinCAT.Ads.AdsErrorException e)
            {
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) { iTimeOut = iTimeOut + 1; }
                Console.WriteLine("Eccezione: " + e.ToString());
                MessageBox.Show("Connection error: " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Forms.MainSelector.appLogger.addLine("Connection error: " + e.ToString(), AppLogger.eLogLevel.error);
            }

            if (tcClient.IsConnected) { return tcClient; } else { return null; }
        }

        /* Disconnection function */
        public bool disconnect(AdsClient adsClient)
        {
            if (adsClient != null)
            {
                adsClient.Disconnect();
                adsClient.Dispose();
                if (adsClient.IsConnected) { return false; } else { return true; }
            }
            else { return false; }
        }
        #endregion

        #region Check watchdog method
        /* Check watch-dog value */
        public bool checkWdValue(int iWdValue)
        {
            if (iWdValue != iWatchDogOld)
            {
                if (!(connected)) { Forms.MainSelector.appLogger.addLine("CPU with Net-id: " + tcClient.Address.NetId.ToString() + " has been connected at port: " + tcClient.Address.Port.ToString(), AppLogger.eLogLevel.debug); }
                connected = true;
            }
            else
            {
                if (connected) { Forms.MainSelector.appLogger.addLine("CPU with Net-id: " + tcClient.Address.NetId.ToString() + " has been disconnected.", AppLogger.eLogLevel.debug); }
                connected = false;
            }
            iWatchDogOld = iWdValue;
            return connected;
        }
        #endregion


        #region Read methods
        public bool readData(int dataSelector, CPU_Connection connection, string strCmdReqPath, string strStsAckPath, string strStsErrPath, string strInfoVarPath) {
            connection.writeInt(strInfoVarPath, dataSelector);
            connection.writeBool(strCmdReqPath, true);
            uiAckHandle = connection.AddNotification(connection.tcClient, strStsAckPath);
            uiErrHandle = connection.AddNotification(connection.tcClient, strStsErrPath);
            connection.tcClient.AdsNotification += new EventHandler<AdsNotificationEventArgs>(StatusNotification);
            return true;
        }

        private void StatusNotification(object sender, AdsNotificationEventArgs e) {
            if (e.Handle == uiAckHandle)
            {//mettere qui il codice per gestire il acknowledge; }
                ReadOnlyMemory<byte> memory = e.Data;
                iSizeOf = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span);
                astrData = readAstrData(tcClient, "GVL_Diag.ComProt.astrData");
                writeBool("GVL_Diag.ComProt.xCmdReq", false);
            }

            if (e.Handle == uiErrHandle)
            {//mettere qui il codice per gestire il errore
                writeBool("GVL_Diag.ComProt.xCmdReq", false);
            }
        }
        private string[,] readAstrData(AdsClient adsClient, string strDataPath)
        {
            uint[,] uiHandle = new uint[199,3];
            for (int _i = 0; _i <= iSizeOf; _i++){for (int _j = 0; _j <= 3; _j++) { uiHandle[_i,_j] = adsClient.CreateVariableHandle(strDataPath + ".astrData[" + _i.ToString() + "," + _j.ToString() + "]"); }}
            
            byte[] buffer = new byte[81];
            try
            {
                for (int _i = 0; _i <= iSizeOf; _i++) {
                    for (int _j = 0; _j <= 3; _j++)
                    {
                        adsClient.Read(uiHandle[_i, _j], buffer.AsMemory());
                        astrData[_i,_j] = (Encoding.ASCII.GetString(buffer, 0, buffer.Length)).Replace("\0", string.Empty);
                    }
                }
                return astrData;
            }
            catch (TwinCAT.Ads.AdsErrorException e)
            {
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) {;}
                Forms.MainSelector.appLogger.addLine("Error while reading a string: " + e.ToString(), AppLogger.eLogLevel.warning);
                return null;
            }
            catch (System.ObjectDisposedException e)
            {
                ErrorManagement(e);
                return null;
            }
            catch (System.NullReferenceException e)
            {
                ErrorManagement(e);
                return null;
            }

        }
        #endregion

        #region Write methods
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
                Forms.MainSelector.appLogger.addLine("Error while writing a boolean value: " + strVarName + " " + e.ToString(), AppLogger.eLogLevel.warning);
                return false;
            }
            catch (System.ObjectDisposedException e)
            {
                ErrorManagement(e);
                return false;
            }
            catch (System.NullReferenceException e)
            {
                ErrorManagement(e);
                return false;
            }
        }

        #endregion

        #region Error Manager
        private void ErrorManagement(Exception e)
        {
            Forms.MainSelector.appLogger.addLine("CPU Connection is not valid: " + e.ToString(), AppLogger.eLogLevel.fatal);
            MessageBox.Show("CPU Connection is not valid: " + e.ToString(), "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        #endregion

        #region Auxiliary functions
        public IPAddress getIpAddress(string strAdsRoute)
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    foreach (UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork && nic.OperationalStatus == OperationalStatus.Up)
                        {
                            if (verifyPcIpAddress(ip.Address, strAdsRoute)) { return ip.Address; }
                        }
                    }
                }
                else { return null; }
            }
            return null;
        }
        public bool checkIpAddress(IPAddress iPAddress, string strCpuNetId)
        {
            byte[] addressOctets = iPAddress.GetAddressBytes();
            IPAddress cpuIpAddress = IPAddress.Parse(strCpuNetId.Remove(strCpuNetId.Length - 4));
            byte[] CpuAdrOctets = cpuIpAddress.GetAddressBytes();

            return ((addressOctets[0] == CpuAdrOctets[0]) && (addressOctets[1] == CpuAdrOctets[1]) && (addressOctets[2] == CpuAdrOctets[2]));
        }

        public bool verifyPcIpAddress(IPAddress iPAddress, string strAdsRouteIpAdr)
        {
            byte[] addressOctets = iPAddress.GetAddressBytes();
            IPAddress pcIpAddress = IPAddress.Parse(strAdsRouteIpAdr);
            byte[] pcAdressOctets = pcIpAddress.GetAddressBytes();

            return ((addressOctets[0] == pcAdressOctets[0]) && (addressOctets[1] == pcAdressOctets[1]) && (addressOctets[2] == pcAdressOctets[2]) && (addressOctets[3] == pcAdressOctets[3]));
        }
        #endregion
    }
}
