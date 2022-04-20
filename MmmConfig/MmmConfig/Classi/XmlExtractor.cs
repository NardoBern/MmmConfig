using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace MmmConfig
{
    class XmlExtractor
    {
        #region Variable declarations

        #endregion

        #region Read configuration from xml file
        public void readConfiguration(string strFilePath, AppConfig appConfig)
        {
            XmlDocument doc = new XmlDocument();
            try {doc.Load(strFilePath);}
            catch (XmlException ex) { MessageBox.Show("Error while loading xml configuration file: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            
            try { 
                foreach (XmlNode firstLevelNode in doc.DocumentElement.ChildNodes)
                {
                    switch (firstLevelNode.Name) 
                    {
                        case "connection":
                            foreach (XmlNode secondLevelNode in firstLevelNode.ChildNodes)
                            {
                                switch (secondLevelNode.Name)
                                {
                                    case "netId":
                                        appConfig.strDefaultNetId = secondLevelNode.InnerText;
                                        break;
                                    case "port":
                                        appConfig.iDefaultPort = Convert.ToInt32(secondLevelNode.InnerText);
                                        break;
                                }
                            }
                            break;
                        case "variablePath":
                            foreach (XmlNode secondLevelNode in firstLevelNode.ChildNodes) 
                            { 
                                switch (secondLevelNode.Name)
                                {
                                    case "eventLog":
                                        appConfig.strMotionEventLogPath = secondLevelNode.InnerText;
                                        break;
                                    case "eventLogSize":
                                        appConfig.strEventLogSize = secondLevelNode.InnerText;
                                        break;
                                    case "readWd":
                                        appConfig.strReadWatchDog = secondLevelNode.InnerText;
                                        break;
                                    case "writeWd":
                                        appConfig.strWriteWatchDog = secondLevelNode.InnerText;
                                        break;
                                    case "motorCfgWrite":
                                        appConfig.strMotCfgWrite = secondLevelNode.InnerText;
                                        break;
                                    case "motorCfgRead":
                                        appConfig.strMotCfgRead = secondLevelNode.InnerText;
                                        break;
                                    case "motorStatus":
                                        appConfig.strMotStatus = secondLevelNode.InnerText;
                                        break;
                                    case "motorCommands":
                                        appConfig.strMotCommands = secondLevelNode.InnerText;
                                        break;
                                }
                            }
                            break;
                    }
                }
            }
            catch (XmlException ex) { MessageBox.Show("Error while reading xml config file: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Read xml of events
        public void readXml(string strFilePath, EventLogger eventLogger)
        {
            XmlDocument doc = new XmlDocument();
            try { doc.Load(strFilePath); }
            catch (XmlException ex) { MessageBox.Show("Error while loading xml event file: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            int _i = -1;
            int iNumOfEvent = 0;
            try { 
                foreach (XmlNode firstLevelNode in doc.DocumentElement.ChildNodes)
                {
                    foreach (XmlNode secondLevelNode in firstLevelNode.ChildNodes)
                    {
                        if (secondLevelNode.Name == "event") { iNumOfEvent = Convert.ToInt32(secondLevelNode.Attributes["num"].Value); }
                        foreach (XmlNode thirdLevelNode in secondLevelNode.ChildNodes)
                        {
                            switch (thirdLevelNode.Name)
                            {
                                case "ID":
                                    _i = _i + 1;
                                    eventLogger.events[_i].uiEventId = Convert.ToUInt16(thirdLevelNode.InnerText);
                                    break;
                                case "timestamp":
                                    eventLogger.events[_i].strTimeStamp = thirdLevelNode.InnerText;
                                    break;
                                case "type":
                                    switch (thirdLevelNode.InnerText)
                                    {
                                        case "Information":
                                            eventLogger.events[_i].eTypeOfEvent = eTypeOfEvent.Info;
                                            break;
                                        case "Message":
                                            eventLogger.events[_i].eTypeOfEvent = eTypeOfEvent.Message;
                                            break;
                                        case "Warning":
                                            eventLogger.events[_i].eTypeOfEvent = eTypeOfEvent.Warning;
                                            break;
                                        case "Error":
                                            eventLogger.events[_i].eTypeOfEvent = eTypeOfEvent.Error;
                                            break;
                                        default:
                                            break;
                                    }
                                    break;
                                case "device":
                                    eventLogger.events[_i].strDeviceName = thirdLevelNode.InnerText;
                                    break;
                                case "message":
                                    eventLogger.events[_i].strMessage = thirdLevelNode.InnerText;
                                    break;
                                case "alert":
                                    eventLogger.events[_i].strAlert = thirdLevelNode.InnerText;
                                    break;
                                case "OperationDescription":
                                    eventLogger.events[_i].operationLog.strOperationDescr = thirdLevelNode.InnerText;
                                    break;
                                case "valueString1":
                                    eventLogger.events[_i].operationLog.astrOpValue[0] = thirdLevelNode.InnerText;
                                    break;
                                case "valueString2":
                                    eventLogger.events[_i].operationLog.astrOpValue[1] = thirdLevelNode.InnerText;
                                    break;
                                case "valueString3":
                                    eventLogger.events[_i].operationLog.astrOpValue[2] = thirdLevelNode.InnerText;
                                    break;
                                case "valueString4":
                                    eventLogger.events[_i].operationLog.astrOpValue[3] = thirdLevelNode.InnerText;
                                    break;
                                case "valueIn1":
                                    eventLogger.events[_i].operationLog.aiOpValue[0] = Convert.ToInt32(thirdLevelNode.InnerText);
                                    break;
                                case "valueIn2":
                                    eventLogger.events[_i].operationLog.aiOpValue[1] = Convert.ToInt32(thirdLevelNode.InnerText);
                                    break;
                                case "valueIn3":
                                    eventLogger.events[_i].operationLog.aiOpValue[2] = Convert.ToInt32(thirdLevelNode.InnerText);
                                    break;
                                case "valueIn4":
                                    eventLogger.events[_i].operationLog.aiOpValue[3] = Convert.ToInt32(thirdLevelNode.InnerText);
                                    break;
                                case "valueReal1":
                                    eventLogger.events[_i].operationLog.arOpValue[0] = Convert.ToDouble(thirdLevelNode.InnerText);
                                    break;
                                case "valueReal2":
                                    eventLogger.events[_i].operationLog.arOpValue[1] = Convert.ToDouble(thirdLevelNode.InnerText);
                                    break;
                                case "valueReal3":
                                    eventLogger.events[_i].operationLog.arOpValue[2] = Convert.ToDouble(thirdLevelNode.InnerText);
                                    break;
                                case "valueReal4":
                                    eventLogger.events[_i].operationLog.arOpValue[3] = Convert.ToDouble(thirdLevelNode.InnerText);
                                    break;
                                case "errorGlobal":
                                    eventLogger.events[_i].error.xErrorGlobal = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "ErrorDescription":
                                    switch (thirdLevelNode.InnerText)
                                    {
                                        case "No error":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.eNoError;
                                            break;
                                        case "Reset master encoder":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.eResetMasterEncoder;
                                            break;
                                        case "Zero master encoder":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.eZeroMasterEncoder;
                                            break;
                                        case "FB axis manager":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.eFbAxisManager;
                                            break;
                                        case "Reset axis":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.eResetAxis;
                                            break;
                                        case "Homing axis":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.aAxisHoming;
                                            break;
                                        case "Gear in":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.eGearIn;
                                            break;
                                        case "Gear out":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.eGearOut;
                                            break;
                                        case "Phasing":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.ePhasing;
                                            break;
                                        case "Power":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.ePower;
                                            break;
                                        case "Jog":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.eJog;
                                            break;
                                        case "Move velocity":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.eMoveVel;
                                            break;
                                        case "Set position":
                                            eventLogger.events[_i].error.enumErrorName = enumErrorName.eSetPos;
                                            break;
                                    }
                                    break;
                                case "errorBit0":
                                    eventLogger.events[_i].error.axErrBit[0] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit1":
                                    eventLogger.events[_i].error.axErrBit[1] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit2":
                                    eventLogger.events[_i].error.axErrBit[2] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit3":
                                    eventLogger.events[_i].error.axErrBit[3] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit4":
                                    eventLogger.events[_i].error.axErrBit[4] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit5":
                                    eventLogger.events[_i].error.axErrBit[5] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit6":
                                    eventLogger.events[_i].error.axErrBit[6] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit7":
                                    eventLogger.events[_i].error.axErrBit[7] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit8":
                                    eventLogger.events[_i].error.axErrBit[8] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit9":
                                    eventLogger.events[_i].error.axErrBit[9] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit10":
                                    eventLogger.events[_i].error.axErrBit[10] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit11":
                                    eventLogger.events[_i].error.axErrBit[11] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit12":
                                    eventLogger.events[_i].error.axErrBit[12] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit13":
                                    eventLogger.events[_i].error.axErrBit[13] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit14":
                                    eventLogger.events[_i].error.axErrBit[14] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorBit15":
                                    eventLogger.events[_i].error.axErrBit[15] = Convert.ToBoolean(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode0":
                                    eventLogger.events[_i].error.audiErrId[0] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode1":
                                    eventLogger.events[_i].error.audiErrId[1] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode2":
                                    eventLogger.events[_i].error.audiErrId[2] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode3":
                                    eventLogger.events[_i].error.audiErrId[3] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode4":
                                    eventLogger.events[_i].error.audiErrId[4] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode5":
                                    eventLogger.events[_i].error.audiErrId[5] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode6":
                                    eventLogger.events[_i].error.audiErrId[6] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode7":
                                    eventLogger.events[_i].error.audiErrId[7] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode8":
                                    eventLogger.events[_i].error.audiErrId[8] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode9":
                                    eventLogger.events[_i].error.audiErrId[9] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode10":
                                    eventLogger.events[_i].error.audiErrId[10] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode11":
                                    eventLogger.events[_i].error.audiErrId[11] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode12":
                                    eventLogger.events[_i].error.audiErrId[12] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode13":
                                    eventLogger.events[_i].error.audiErrId[13] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode14":
                                    eventLogger.events[_i].error.audiErrId[14] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;
                                case "errorCode15":
                                    eventLogger.events[_i].error.audiErrId[15] = Convert.ToUInt32(thirdLevelNode.InnerText);
                                    break;

                            }
                        
                        }
                    }
                }
                eventLogger.iLastWritePos = iNumOfEvent;
            }
            catch (XmlException ex) { MessageBox.Show("Error while reading xml event file: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion
    }
}
