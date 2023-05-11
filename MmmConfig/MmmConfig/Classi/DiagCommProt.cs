using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinCAT.Ads;

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
        #endregion

        #region Read methods
        public bool readData(int dataSelector, CPU_Connection connection, string strCmdReqPath, string strStsAckPath, string strStsErrPath) {
            connection.writeBool(strCmdReqPath, true);
            uiAckHandle = connection.AddNotification(connection.tcClient, strStsAckPath);
            uiErrHandle = connection.AddNotification(connection.tcClient, strStsErrPath);
            connection.tcClient.AdsNotification += new EventHandler<AdsNotificationEventArgs>(StatusNotification);
            return true;
        }

        private void StatusNotification(object sender, AdsNotificationEventArgs e) {
            if (e.Handle == uiAckHandle)
            {//mettere qui il codice per gestire il acknowledge; }
            }

            if (e.Handle == uiErrHandle)
            {//mettere qui il codice per gestire il errore

            }


            Pippopiapppaopopodsa

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
        #region Error Manager
        private void ErrorManagement(Exception e)
        {
            Forms.MainSelector.appLogger.addLine("CPU Connection is not valid: " + e.ToString(), AppLogger.eLogLevel.fatal);
            MessageBox.Show("CPU Connection is not valid: " + e.ToString(), "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
        #endregion
    }
}
