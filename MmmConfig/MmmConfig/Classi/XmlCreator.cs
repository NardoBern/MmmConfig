using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace MmmConfig
{
    class XmlCreator
    {
        #region Variable declarations
        private XmlWriter xmlWriter;
        #endregion

        public void createXmlFile(EventLogger eventLogger, string strFilePath)
        {
            try { xmlWriter = XmlWriter.Create(strFilePath); }
            catch (XmlException ex) 
            {
                Forms.MainSelector.appLogger.addLine("Error while creating xml logger file: " + ex.ToString(), AppLogger.eLogLevel.error);
                MessageBox.Show("Error while creating xml logger file: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try { 
                xmlWriter.WriteStartDocument();
                xmlWriter.WriteComment("This is the Diagnostic file of the Beckhoff MultiMotorManager, generated on: "  + DateTime.Now.ToString());
                xmlWriter.WriteStartElement("diagnostic");
                xmlWriter.WriteStartElement("listOfEvents");
            }
            catch (XmlException ex) 
            {
                Forms.MainSelector.appLogger.addLine("Error while adding header to xml logger file: " + ex.ToString(), AppLogger.eLogLevel.error);
                MessageBox.Show("Error while adding header to xml logger file: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try { for (int _i = 0; _i < eventLogger.iLastWritePos; _i++) { addEventToXml(_i, eventLogger.events[_i]); } }
            catch (XmlException ex) 
            {
                Forms.MainSelector.appLogger.addLine("Error while adding event to xml logger file: " + ex.ToString(), AppLogger.eLogLevel.error);
                MessageBox.Show("Error while adding event to xml logger file: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

            try {
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndElement();
                xmlWriter.WriteEndDocument();
                xmlWriter.Close();
                MessageBox.Show("File Salvato");
            }
            catch (XmlException ex) 
            {
                Forms.MainSelector.appLogger.addLine("Error while adding end lines of xml logger file: " + ex.ToString(), AppLogger.eLogLevel.error);
                MessageBox.Show("Error while adding end lines of xml logger file: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private void addEventToXml(int index, Event @event)
        {
            xmlWriter.WriteStartElement("event");
            xmlWriter.WriteAttributeString("num", index.ToString());
            xmlWriter.WriteElementString("ID", @event.uiEventId.ToString());
            xmlWriter.WriteElementString("timestamp", @event.strTimeStamp);
            string strTypeOfEvent;
            switch (@event.eTypeOfEvent)
            {
                case eTypeOfEvent.Info:
                    strTypeOfEvent = "Information";
                    break;
                case eTypeOfEvent.Message:
                    strTypeOfEvent = "Message";
                    break;
                case eTypeOfEvent.Warning:
                    strTypeOfEvent = "Warning";
                    break;
                case eTypeOfEvent.Error:
                    strTypeOfEvent = "Error";
                    break;
                default:
                    strTypeOfEvent = "Not defined";
                    break;
            }
            xmlWriter.WriteElementString("type", strTypeOfEvent);
            xmlWriter.WriteElementString("device", @event.strDeviceName);
            xmlWriter.WriteElementString("message", @event.strMessage);
            xmlWriter.WriteElementString("alert", @event.strAlert);
            
            xmlWriter.WriteElementString("OperationDescription", @event.operationLog.strOperationDescr);
            xmlWriter.WriteElementString("valueString1", @event.operationLog.astrOpValue[0]);
            xmlWriter.WriteElementString("valueString2", @event.operationLog.astrOpValue[1]);
            xmlWriter.WriteElementString("valueString3", @event.operationLog.astrOpValue[2]);
            xmlWriter.WriteElementString("valueString4", @event.operationLog.astrOpValue[3]);
            xmlWriter.WriteElementString("valueIn1", @event.operationLog.aiOpValue[0].ToString());
            xmlWriter.WriteElementString("valueIn2", @event.operationLog.aiOpValue[1].ToString());
            xmlWriter.WriteElementString("valueIn3", @event.operationLog.aiOpValue[2].ToString());
            xmlWriter.WriteElementString("valueIn4", @event.operationLog.aiOpValue[3].ToString());
            xmlWriter.WriteElementString("valueReal1", @event.operationLog.arOpValue[0].ToString("F0"));
            xmlWriter.WriteElementString("valueReal2", @event.operationLog.arOpValue[1].ToString("F0"));
            xmlWriter.WriteElementString("valueReal3", @event.operationLog.arOpValue[2].ToString("F0"));
            xmlWriter.WriteElementString("valueReal4", @event.operationLog.arOpValue[3].ToString("F0"));
            
            xmlWriter.WriteElementString("errorGlobal", @event.error.xErrorGlobal.ToString());
            string strErrorDescription;
            switch (@event.error.enumErrorName)
            {
                case enumErrorName.eNoError:
                    strErrorDescription = "No error";
                    break;
                case enumErrorName.eResetMasterEncoder:
                    strErrorDescription = "Reset master encoder";
                    break;
                case enumErrorName.eZeroMasterEncoder:
                    strErrorDescription = "Zero master encoder";
                    break;
                case enumErrorName.eFbAxisManager:
                    strErrorDescription = "FB axis manager";
                    break;
                case enumErrorName.eResetAxis:
                    strErrorDescription = "Reset axis";
                    break;
                case enumErrorName.aAxisHoming:
                    strErrorDescription = "Homing axis";
                    break;
                case enumErrorName.eGearIn:
                    strErrorDescription = "Gear in";
                    break;
                case enumErrorName.eGearOut:
                    strErrorDescription = "Gear out";
                    break;
                case enumErrorName.ePhasing:
                    strErrorDescription = "Phasing";
                    break;
                case enumErrorName.ePower:
                    strErrorDescription = "Power";
                    break;
                case enumErrorName.eJog:
                    strErrorDescription = "Jog";
                    break;
                case enumErrorName.eMoveVel:
                    strErrorDescription = "Move velocity";
                    break;
                case enumErrorName.eSetPos:
                    strErrorDescription = "Set position";
                    break;
                default:
                    strErrorDescription = "Invalid error code";
                    break;
            }
            xmlWriter.WriteElementString("ErrorDescription", strErrorDescription);
            xmlWriter.WriteElementString("errorBit0", @event.error.axErrBit[0].ToString());
            xmlWriter.WriteElementString("errorBit1", @event.error.axErrBit[1].ToString());
            xmlWriter.WriteElementString("errorBit2", @event.error.axErrBit[2].ToString());
            xmlWriter.WriteElementString("errorBit3", @event.error.axErrBit[3].ToString());
            xmlWriter.WriteElementString("errorBit4", @event.error.axErrBit[4].ToString());
            xmlWriter.WriteElementString("errorBit5", @event.error.axErrBit[5].ToString());
            xmlWriter.WriteElementString("errorBit6", @event.error.axErrBit[6].ToString());
            xmlWriter.WriteElementString("errorBit7", @event.error.axErrBit[7].ToString());
            xmlWriter.WriteElementString("errorBit8", @event.error.axErrBit[8].ToString());
            xmlWriter.WriteElementString("errorBit9", @event.error.axErrBit[9].ToString());
            xmlWriter.WriteElementString("errorBit10", @event.error.axErrBit[10].ToString());
            xmlWriter.WriteElementString("errorBit11", @event.error.axErrBit[11].ToString());
            xmlWriter.WriteElementString("errorBit12", @event.error.axErrBit[12].ToString());
            xmlWriter.WriteElementString("errorBit13", @event.error.axErrBit[13].ToString());
            xmlWriter.WriteElementString("errorBit14", @event.error.axErrBit[14].ToString());
            xmlWriter.WriteElementString("errorBit15", @event.error.axErrBit[15].ToString());
            xmlWriter.WriteElementString("errorCode0", @event.error.audiErrId[0].ToString());
            xmlWriter.WriteElementString("errorCode1", @event.error.audiErrId[1].ToString());
            xmlWriter.WriteElementString("errorCode2", @event.error.audiErrId[2].ToString());
            xmlWriter.WriteElementString("errorCode3", @event.error.audiErrId[3].ToString());
            xmlWriter.WriteElementString("errorCode4", @event.error.audiErrId[4].ToString());
            xmlWriter.WriteElementString("errorCode5", @event.error.audiErrId[5].ToString());
            xmlWriter.WriteElementString("errorCode6", @event.error.audiErrId[6].ToString());
            xmlWriter.WriteElementString("errorCode7", @event.error.audiErrId[7].ToString());
            xmlWriter.WriteElementString("errorCode8", @event.error.audiErrId[8].ToString());
            xmlWriter.WriteElementString("errorCode9", @event.error.audiErrId[9].ToString());
            xmlWriter.WriteElementString("errorCode10", @event.error.audiErrId[10].ToString());
            xmlWriter.WriteElementString("errorCode11", @event.error.audiErrId[11].ToString());
            xmlWriter.WriteElementString("errorCode12", @event.error.audiErrId[12].ToString());
            xmlWriter.WriteElementString("errorCode13", @event.error.audiErrId[13].ToString());
            xmlWriter.WriteElementString("errorCode14", @event.error.audiErrId[14].ToString());
            xmlWriter.WriteElementString("errorCode15", @event.error.audiErrId[15].ToString());
            xmlWriter.WriteEndElement();
        }
    }
}
