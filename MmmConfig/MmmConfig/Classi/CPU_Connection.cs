﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TwinCAT.Ads;
using TwinCAT.Ams;
using TwinCAT.Ads.TcpRouter;
using System.Net;
using System.Net.NetworkInformation;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using TwinCAT.TypeSystem;
using System.Threading;
using System.Threading.Tasks;

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
        public int iCommErr = 0;
        public Motor Motors;
        public MemoryStream datastream;
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
            if (iPAddress != null) { pcNetId = iPAddress.ToString() + ".1.1";}
            else { MessageBox.Show("Your have to set your PC ip-address equal to: " + strAdsRoute, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return null; }
            
            var tcpRouter = new TwinCAT.Ads.TcpRouter.AmsTcpIpRouter(AmsNetId.Parse(pcNetId));
            tcpRouter.AddRoute(new Route("CX-50CAF6", new AmsNetId(strNetId), new IPAddress[] { IPAddress.Parse(strNetId.Remove(strNetId.Length - 4))}));

            var routerTask = tcpRouter.StartAsync(System.Threading.CancellationToken.None);

            tcClient.Timeout = 5000;

            try { tcClient.Connect(strNetId, iport); }
            catch (TwinCAT.Ads.AdsErrorException e) {
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) { iTimeOut = iTimeOut + 1; }
                Console.WriteLine("Eccezione: " + e.ToString());
                MessageBox.Show("Connection error: " + e.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Forms.MainSelector.appLogger.addLine("Connection error: " + e.ToString(), AppLogger.eLogLevel.error);
            }
            
            if (tcClient.IsConnected) { return tcClient; } else { return null;}
        }
        
        /* Disconnection function */
        public bool disconnect(AdsClient adsClient)
        {
            if (adsClient != null)
            {
                adsClient.Disconnect();
                adsClient.Dispose();
                if (adsClient.IsConnected) { return false;} else { return true;}
            }
            else { return false;}
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
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) 
                { 
                    iTimeOut = iTimeOut + 1;
                    if (iTimeOut >= 3) { iTimeOut = 0; connected = false; Forms.MainSelector.appLogger.addLine("Error while reading integer value: " + strVarName + " Connection time-out", AppLogger.eLogLevel.warning); }
                }
                Console.WriteLine("Eccezione durante la lettura di un valore intero " + e.ToString());
                return 999999;
            }
            catch (System.ObjectDisposedException e) {
                ErrorManagement(e);
                return 999999;
            }
            catch (System.NullReferenceException e)
            {
                ErrorManagement(e);
                return 999999;
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
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) 
                { 
                    iTimeOut = iTimeOut + 1;
                    Forms.MainSelector.appLogger.addLine("Error while reading boolean value: " + strVarName + " Connection time-out", AppLogger.eLogLevel.warning);
                    if (iTimeOut >= 3) { iTimeOut = 0; connected = false; }
                }
                Console.WriteLine("Eccezione durante la lettura di un valore boolean " + e.ToString());
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

        public bool readEvent(string strEventLoggerPath, AdsClient adsClient, int iEventNum, Event @event)
        {
            try
            {
                uint[] uiHandle = new uint[19];
                uiHandle[0] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].uiEventID");
                uiHandle[1] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].strDeviceName");
                uiHandle[2] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].eTypeOfEvent");
                uiHandle[3] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].strTimeStamp");
                uiHandle[4] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].xWrite");
                uiHandle[5] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].strMessage");
                uiHandle[6] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].strAlert");
                uiHandle[7] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].stError.axErrBit");
                uiHandle[8] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].stError.xErrorGlobal");
                uiHandle[9] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].stError.enumErrDescr");
                uiHandle[10] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].stError.audiErrId");
                uiHandle[11] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].stOperationLog.strOperationDescr");
                uiHandle[12] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].stOperationLog.aiOpValue");
                uiHandle[13] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].stOperationLog.arOpValue");
                uiHandle[14] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].stOperationLog.astrOpValue[0]");
                uiHandle[15] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].stOperationLog.astrOpValue[1]");
                uiHandle[16] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].stOperationLog.astrOpValue[2]");
                uiHandle[17] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].stOperationLog.astrOpValue[3]");
                uiHandle[18] = adsClient.CreateVariableHandle(strEventLoggerPath + ".astEvent[" + iEventNum.ToString() + "].stOperationLog.astrOpValue[4]");

                if (adsClient != null && @event != null) 
                {                 
                    @event.uiEventId = (uint)adsClient.ReadAny(uiHandle[0], typeof(uint));
                    @event.strDeviceName = readString(uiHandle[1], adsClient);
                    @event.eTypeOfEvent = readTypeOfEvent(uiHandle[2], adsClient);
                    @event.strTimeStamp = readString(uiHandle[3], adsClient);
                    @event.xWrite = (bool)adsClient.ReadAny(uiHandle[4], typeof(bool));
                    @event.strMessage = readString(uiHandle[5], adsClient);
                    @event.strAlert = readString(uiHandle[6], adsClient);
                    @event.error.axErrBit = readErrorBit(uiHandle[7],adsClient);
                    @event.error.xErrorGlobal = (bool)adsClient.ReadAny(uiHandle[8], typeof(bool));
                    @event.error.enumErrorName = readErrorName(uiHandle[9], adsClient);
                    @event.error.audiErrId = readErrorId(uiHandle[10], adsClient);
                    @event.operationLog.strOperationDescr = readString(uiHandle[11], adsClient);
                    @event.operationLog.aiOpValue = readIntOpValues(uiHandle[12], adsClient);
                    @event.operationLog.arOpValue = readDoubleOpValues(uiHandle[13], adsClient);
                    uint[] strHandles = new uint[5] { uiHandle[14], uiHandle[15], uiHandle[16], uiHandle[17], uiHandle[18] }; 
                    @event.operationLog.astrOpValue = readStringOpValues(strHandles, adsClient);

                    for (int _i = 0; _i < uiHandle.Length; _i++) { adsClient.DeleteVariableHandle(uiHandle[_i]); }
                
                    return true;
                }
                else { return false; MessageBox.Show("AdsClient or @Event was null", "Debug", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            }
            catch (TwinCAT.Ads.AdsErrorException e)
            {
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) 
                { 
                    iTimeOut = iTimeOut + 1;
                    Forms.MainSelector.appLogger.addLine("Error while reading event: " + iEventNum.ToString() + " Connection time-out", AppLogger.eLogLevel.warning);
                    if (iTimeOut >= 3) { iTimeOut = 0; connected = false; }
                }
                Console.WriteLine("Eccezione durante la lettura di un evento " + e.ToString());
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

        private string[] readStringOpValues(uint[] uiVarHandle, AdsClient adsClient)
        {
            byte[] readBuffer = new byte[5 * 81];
            string[] opValues = new string[5];

            try { 
                for (int _i = 0; _i < uiVarHandle.Length; _i++)
                {
                    opValues[_i] = readString(uiVarHandle[_i], adsClient);
                }
                return opValues;
            }
            catch (Exception ex)
            {
                Forms.MainSelector.appLogger.addLine("Error while reading string operation values: " + ex.ToString(), AppLogger.eLogLevel.warning);
                return null;
            }
        }

        private double[] readDoubleOpValues(uint uiVarHandle, AdsClient adsClient)
        {
            byte[] readBuffer = new byte[5 * sizeof(double)];
            double[] opValues = new double[5];
            try
            {
                adsClient.Read(uiVarHandle, readBuffer.AsMemory());

                MemoryStream dataStream = new MemoryStream(readBuffer);
                BinaryReader binRead = new BinaryReader(dataStream);

                dataStream.Position = 0;
            
                for (int _i = 0; _i < opValues.Length; _i++) { opValues[_i] = binRead.ReadSingle();}
                return opValues;
            }
            catch (Exception ex)
            {
                Forms.MainSelector.appLogger.addLine("Error while reading double operation values: " + ex.ToString(), AppLogger.eLogLevel.warning);
                return null;
            }
        }

        private int[] readIntOpValues(uint uiVarHandle, AdsClient adsClient)
        {
            byte[] readBuffer = new byte[5 * 2];
            int[] opValues = new int[5];
            try
            {
                adsClient.Read(uiVarHandle, readBuffer.AsMemory());

                MemoryStream dataStream = new MemoryStream(readBuffer);
                BinaryReader binRead = new BinaryReader(dataStream);

                dataStream.Position = 0;
            
                for (int _i = 0; _i < opValues.Length; _i++) { opValues[_i] = binRead.ReadInt16(); }
                return opValues;
            }
            catch (Exception ex)
            {
                Forms.MainSelector.appLogger.addLine("Error while reading integer operation values: " + ex.ToString(), AppLogger.eLogLevel.warning);
                return null;
            }
        }

        private uint[] readErrorId(uint uiVarHandle,AdsClient adsClient)
        {
            byte[] readBuffer = new byte[16*4];
            uint[] errorId = new uint[16];

            try {
                adsClient.Read(uiVarHandle, readBuffer.AsMemory());

                MemoryStream dataStream = new MemoryStream(readBuffer);
                BinaryReader binRead = new BinaryReader(dataStream);

                dataStream.Position = 0;
                for (int _i = 0; _i < errorId.Length ; _i++) { errorId[_i] = binRead.ReadUInt32();}

                return errorId;
            }
            catch (Exception ex) {
                Forms.MainSelector.appLogger.addLine("Error while reading error ID: " + ex.ToString(), AppLogger.eLogLevel.warning);
                return null;
            }
        }
        private bool[] readErrorBit(uint uiVarHandle, AdsClient adsClient)
        {
            byte[] buffer = new byte[16];
            bool[] errorArray = new bool[16];
            try {
                adsClient.Read(uiVarHandle, buffer.AsMemory());
                for (int _i = 0; _i < buffer.Length; _i++)
                {
                    if ((byte)buffer.GetValue(_i) == 0) { errorArray[_i] = false; }
                    else { errorArray[_i] = true; }
                }
                return errorArray;
            }
            catch (Exception ex) {
                Forms.MainSelector.appLogger.addLine("Error while reading error bit array: " + ex.ToString(), AppLogger.eLogLevel.warning);
                return null;
            }
        }

        private enumErrorName readErrorName(uint uiVarHandle, AdsClient adsClient)
        {
            enumErrorName errorName;
            int tempInt;
            try
            {
                tempInt = (int)adsClient.ReadAny(uiVarHandle, typeof(int));
                switch (tempInt)
                {
                    case 0:
                        errorName = enumErrorName.eNoError;
                        return errorName;
                    case 1:
                        errorName = enumErrorName.eResetMasterEncoder;
                        return errorName;
                    case 2:
                        errorName = enumErrorName.eZeroMasterEncoder;
                        return errorName;
                    case 3:
                        errorName = enumErrorName.eFbAxisManager;
                        return errorName;
                    case 4:
                        errorName = enumErrorName.eResetAxis;
                        return errorName;
                    case 5:
                        errorName = enumErrorName.aAxisHoming;
                        return errorName;
                    case 6:
                        errorName = enumErrorName.eGearIn;
                        return errorName;
                    case 7:
                        errorName = enumErrorName.eGearOut;
                        return errorName;
                    case 8:
                        errorName = enumErrorName.ePhasing;
                        return errorName;
                    case 9:
                        errorName = enumErrorName.ePower;
                        return errorName;
                    case 10:
                        errorName = enumErrorName.eJog;
                        return errorName;
                    case 11:
                        errorName = enumErrorName.eMoveVel;
                        return errorName;
                    case 12:
                        errorName = enumErrorName.eSetPos;
                        return errorName;
                    default:
                        errorName = enumErrorName.eZeroMasterEncoder;
                        return errorName;
                }
            }
            catch (Exception ex)
            {
                Forms.MainSelector.appLogger.addLine("Error while reading error enumerator name: " + ex.ToString(), AppLogger.eLogLevel.warning);
                return enumErrorName.eNoError;
            }
        }

        private eTypeOfEvent readTypeOfEvent(uint uiVarHandle, AdsClient adsClient)
        {
            eTypeOfEvent typeOfEvent;
            int tempInt;
            try { 
                tempInt = (int)adsClient.ReadAny(uiVarHandle, typeof(int));
                switch (tempInt)
                {
                    case 0:
                        typeOfEvent = eTypeOfEvent.Info;
                        return typeOfEvent;
                    case 1:
                        typeOfEvent = eTypeOfEvent.Message;
                        return typeOfEvent;
                    case 2:
                        typeOfEvent = eTypeOfEvent.Warning;
                        return typeOfEvent;
                    case 3:
                        typeOfEvent = eTypeOfEvent.Error;
                        return typeOfEvent;
                    default:
                        return eTypeOfEvent.Error;
                }
            }
            catch (Exception ex)
            {
                Forms.MainSelector.appLogger.addLine("Error while reading type of event: " + ex.ToString(), AppLogger.eLogLevel.warning);
                return eTypeOfEvent.Error;
            }
        }

        public string readString(uint uiVarHandle, AdsClient adsClient)
        {
            byte[] buffer = new byte[81];
            string stringa;
            try { 
                adsClient.Read(uiVarHandle, buffer.AsMemory());
                stringa = (Encoding.ASCII.GetString(buffer, 0, buffer.Length)).Replace("\0", string.Empty);
                return stringa;
            }
            catch (TwinCAT.Ads.AdsErrorException e)
            {
                if (e.ErrorCode == AdsErrorCode.ClientSyncTimeOut) { iTimeOut = iTimeOut + 1; }
                Forms.MainSelector.appLogger.addLine("Error while reading a string: " + e.ToString(), AppLogger.eLogLevel.warning);
                return "Error";
            }
            catch (System.ObjectDisposedException e)
            {
                ErrorManagement(e);
                return "Error";
            }
            catch (System.NullReferenceException e)
            {
                ErrorManagement(e);
                return "Error";
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
                Forms.MainSelector.appLogger.addLine("Error while writing an integer value: " + strVarName + " " + e.ToString(), AppLogger.eLogLevel.warning);
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

        #region Add notification method
        /* Add notification */
        public uint AddNotification(AdsClient adsClient, string strVariableName)
        {
            uint hTest;
            try { 
                hTest = adsClient.AddDeviceNotification(strVariableName, 2,
                        new NotificationSettings(AdsTransMode.OnChange, 100, 0), null);
                return hTest;
            }
            catch (Exception ex) {
                Forms.MainSelector.appLogger.addLine("Error while adding notification to variable: " + strVariableName + " " + ex.ToString(), AppLogger.eLogLevel.warning);
                return 99999;
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
                    foreach(UnicastIPAddressInformation ip in nic.GetIPProperties().UnicastAddresses)
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
