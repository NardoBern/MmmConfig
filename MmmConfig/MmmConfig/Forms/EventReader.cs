using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MmmConfig.Forms
{
    public partial class EventReader : Form
    {

        #region Variable declarations
        public int iEventIndex;
        const string c_strMotionEventLogPath = "GVL_Hmi.stMotionEventLogger";
        #endregion

        #region Form related functions
        public EventReader()
        {
            InitializeComponent();
        }

        private void EventReader_Load(object sender, EventArgs e)
        {
            int iEventIndex = 1;
            updateLblEventNumber(iEventIndex);
            readEvent(iEventIndex);
            populateEventBoard(Form1.motionEventLogger.events[iEventIndex]);
        }

        private void btnToFirst_Click(object sender, EventArgs e)
        {
            Form1.motionEventLogger.iLastWritePos = Form1.CpuConnection.readInt(c_strMotionEventLogPath + ".iLastWritePos", Form1.CpuConnection.tcClient);
            iEventIndex = 1;
            checkIndexBound(iEventIndex);
            readEvent(iEventIndex);
            updateLblEventNumber(iEventIndex);
            populateEventBoard(Form1.motionEventLogger.events[iEventIndex]);
        }
        private void btnLast_Click(object sender, EventArgs e)
        {
            Form1.motionEventLogger.iLastWritePos = Form1.CpuConnection.readInt(c_strMotionEventLogPath + ".iLastWritePos", Form1.CpuConnection.tcClient);
            iEventIndex = Form1.CpuConnection.readInt("LoggerConst.c_iEventSize", Form1.CpuConnection.tcClient);
            checkIndexBound(iEventIndex);
            readEvent(iEventIndex);
            updateLblEventNumber(iEventIndex);
            populateEventBoard(Form1.motionEventLogger.events[iEventIndex]);
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            Form1.motionEventLogger.iLastWritePos = Form1.CpuConnection.readInt(c_strMotionEventLogPath + ".iLastWritePos", Form1.CpuConnection.tcClient);
            iEventIndex--;
            iEventIndex = checkIndexBound(iEventIndex);
            readEvent(iEventIndex);
            updateLblEventNumber(iEventIndex);
            populateEventBoard(Form1.motionEventLogger.events[iEventIndex]);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            Form1.motionEventLogger.iLastWritePos = Form1.CpuConnection.readInt(c_strMotionEventLogPath + ".iLastWritePos", Form1.CpuConnection.tcClient);
            iEventIndex++;
            iEventIndex = checkIndexBound(iEventIndex);
            readEvent(iEventIndex);
            updateLblEventNumber(iEventIndex);
            populateEventBoard(Form1.motionEventLogger.events[iEventIndex]);
        }
        private void updateLblEventNumber(int iEventIndex) { lblEventNumber.Text = "Event N°: " + iEventIndex.ToString() + " of " + Form1.CpuConnection.readInt("LoggerConst.c_iEventSize", Form1.CpuConnection.tcClient).ToString(); }
        #endregion

        #region Operative Function
        private int checkIndexBound(int index)
        {
            if (index < 1)
            {
                return Form1.CpuConnection.readInt("LoggerConst.c_iEventSize", Form1.CpuConnection.tcClient);
            }
            else
            {
                if (index > Form1.CpuConnection.readInt("LoggerConst.c_iEventSize", Form1.CpuConnection.tcClient))
                {
                    return 1;
                }
            }
            return index;
        }

        private void readEvent(int iEventIndex)
        {
            Cursor.Current = Cursors.WaitCursor;
            Form1.CpuConnection.readEvent(c_strMotionEventLogPath, Form1.CpuConnection.tcClient, iEventIndex, Form1.motionEventLogger.events[iEventIndex]);
            Cursor.Current = Cursors.Default;
        }

        private void populateEventBoard(Event @event)
        {
            const string c_strEventId       = "Event ID: ";
            const string c_strTimeStamp     = "Timestamp: ";
            const string c_strTypeOfEvent   = "Type of Event: ";
            const string c_strDeviceName    = "Device name: ";
            const string c_strMessage       = "Message: ";
            const string c_strAlert         = "Alert: ";
            const string c_strOpDescr       = "Operation description: ";
            const string c_strError         = "Error global: ";
            const string c_strErrorDescr    = "Error description: ";
            const string c_strValue         = "Value: ";

            lblId.Text = c_strEventId + @event.uiEventId.ToString();
            lblTimeStamp.Text = c_strTimeStamp + @event.strTimeStamp;
            
            switch (@event.eTypeOfEvent) {
                case eTypeOfEvent.Info:
                    lblTypeOfEvent.Text = c_strTypeOfEvent + "Information";
                    break;
                case eTypeOfEvent.Message:
                    lblTypeOfEvent.Text = c_strTypeOfEvent + "Message";
                    break;
                case eTypeOfEvent.Warning:
                    lblTypeOfEvent.Text = c_strTypeOfEvent + "Warning";
                    break;
                case eTypeOfEvent.Error:
                    lblTypeOfEvent.Text = c_strTypeOfEvent + "Error";
                    break;
            }

            lblDeviceName.Text = c_strDeviceName + @event.strDeviceName;
            lblMessage.Text = c_strMessage + @event.strMessage;
            lblAlert.Text = c_strAlert + @event.strAlert;
            lblOpDescr.Text = c_strOpDescr + @event.operationLog.strOperationDescr;
            lblError.Text = c_strError + @event.error.xErrorGlobal.ToString();
            
            switch (@event.error.enumErrorName)
            {
                case enumErrorName.eResetMasterEncoder:
                    lblErrorDescr.Text = c_strErrorDescr + "Reset master encoder";
                    break;
                case enumErrorName.eZeroMasterEncoder:
                    lblErrorDescr.Text = c_strErrorDescr + "Zero master encoder";
                    break;
                case enumErrorName.eFbAxisManager:
                    lblErrorDescr.Text = c_strErrorDescr + "FB axis manager";
                    break;
                case enumErrorName.eResetAxis:
                    lblErrorDescr.Text = c_strErrorDescr + "Reset axis";
                    break;
                case enumErrorName.aAxisHoming:
                    lblErrorDescr.Text = c_strErrorDescr + "Homing axis";
                    break;
                case enumErrorName.eGearIn:
                    lblErrorDescr.Text = c_strErrorDescr + "Gear in";
                    break;
                case enumErrorName.eGearOut:
                    lblErrorDescr.Text = c_strErrorDescr + "Gear out";
                    break;
                case enumErrorName.ePhasing:
                    lblErrorDescr.Text = c_strErrorDescr + "Phasing";
                    break;
                case enumErrorName.ePower:
                    lblErrorDescr.Text = c_strErrorDescr + "Power";
                    break;
                case enumErrorName.eJog:
                    lblErrorDescr.Text = c_strErrorDescr + "Jog";
                    break;
                case enumErrorName.eMoveVel:
                    lblErrorDescr.Text = c_strErrorDescr + "Move velocity";
                    break;
                case enumErrorName.eSetPos:
                    lblErrorDescr.Text = c_strErrorDescr + "Set position";
                    break;
            }

            lblOpStr1.Text = c_strValue;
            lblOpStr2.Text = c_strValue;
            lblOpStr3.Text = c_strValue;
            lblOpStr4.Text = c_strValue;
            lblOpStr1.Text = @event.operationLog.astrOpValue[0];
            lblOpStr2.Text = @event.operationLog.astrOpValue[1];
            lblOpStr3.Text = @event.operationLog.astrOpValue[2];
            lblOpStr4.Text = @event.operationLog.astrOpValue[3];
            lblIntVal1.Text = @event.operationLog.aiOpValue[0].ToString();
            lblIntVal2.Text = @event.operationLog.aiOpValue[1].ToString();
            lblIntVal3.Text = @event.operationLog.aiOpValue[2].ToString();
            lblIntVal4.Text = @event.operationLog.aiOpValue[3].ToString();
            lblReal1.Text = @event.operationLog.arOpValue[0].ToString("F0");
            lblReal2.Text = @event.operationLog.arOpValue[1].ToString("F0");
            lblReal3.Text = @event.operationLog.arOpValue[2].ToString("F0");
            lblReal4.Text = @event.operationLog.arOpValue[3].ToString("F0");

            if (@event.error.axErrBit[0]) { 
                lblErrBit0.BackColor = Color.LightPink; 
                lblErrUdi0.BackColor = Color.LightPink;
                lblResetMasterEnc.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit0.BackColor = Color.LightGray;
                lblErrUdi0.BackColor = Color.LightGray;
                lblResetMasterEnc.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[1]) { 
                lblErrBit1.BackColor = Color.LightPink;
                lblErrUdi1.BackColor = Color.LightPink;
                lblZeroMasterEncoder.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit1.BackColor = Color.LightGray;
                lblErrUdi1.BackColor = Color.LightGray;
                lblZeroMasterEncoder.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[2]) { 
                lblErrBit2.BackColor = Color.LightPink;
                lblErrUdi2.BackColor = Color.LightPink;
                lblSlaveAxis.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit2.BackColor = Color.LightGray;
                lblErrUdi2.BackColor = Color.LightGray;
                lblSlaveAxis.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[3]) { 
                lblErrBit3.BackColor = Color.LightPink;
                lblErrUdi3.BackColor = Color.LightPink;
                lblResetSlaveAxis.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit3.BackColor = Color.LightGray;
                lblErrUdi3.BackColor = Color.LightGray;
                lblResetSlaveAxis.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[4]) { 
                lblErrBit4.BackColor = Color.LightPink;
                lblErrUdi4.BackColor = Color.LightPink;
                lblMoveModulo.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit4.BackColor = Color.LightGray;
                lblErrUdi4.BackColor = Color.LightGray;
                lblMoveModulo.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[5]) { 
                lblErrBit5.BackColor = Color.LightPink;
                lblErrUdi5.BackColor = Color.LightPink;
                lblGearIn.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit5.BackColor = Color.LightGray;
                lblErrUdi5.BackColor = Color.LightGray;
                lblGearIn.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[6]) { 
                lblErrBit6.BackColor = Color.LightPink;
                lblErrUdi6.BackColor = Color.LightPink;
                lblGearOut.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit6.BackColor = Color.LightGray;
                lblErrUdi6.BackColor = Color.LightGray;
                lblGearOut.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[7]) { 
                lblErrBit7.BackColor = Color.LightPink;
                lblErrUdi7.BackColor = Color.LightPink;
                lblPhasingRelative.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit7.BackColor = Color.LightGray;
                lblErrUdi7.BackColor = Color.LightGray;
                lblPhasingRelative.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[8]) { 
                lblErrBit8.BackColor = Color.LightPink;
                lblErrUdi8.BackColor = Color.LightPink;
                lblPower.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit8.BackColor = Color.LightGray;
                lblErrUdi8.BackColor = Color.LightGray;
                lblPower.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[9]) { 
                lblErrBit9.BackColor = Color.LightPink;
                lblErrUdi9.BackColor = Color.LightPink;
                lblJog.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit9.BackColor = Color.LightGray;
                lblErrUdi9.BackColor = Color.LightGray;
                lblJog.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[10]) { 
                lblErrBit10.BackColor = Color.LightPink;
                lblErrUdi10.BackColor = Color.LightPink;
                lblMoveVel.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit10.BackColor = Color.LightGray;
                lblErrUdi10.BackColor = Color.LightGray;
                lblMoveVel.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[11]) { 
                lblErrBit11.BackColor = Color.LightPink;
                lblErrUdi11.BackColor = Color.LightPink;
                lblSetPos.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit11.BackColor = Color.LightGray;
                lblErrUdi11.BackColor = Color.LightGray;
                lblSetPos.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[12]) { 
                lblErrBit12.BackColor = Color.LightPink;
                lblErrUdi12.BackColor = Color.LightPink;
                lblStop.BackColor = Color.LightPink;
            } 
            else { 
                lblErrBit12.BackColor = Color.LightGray;
                lblErrUdi12.BackColor = Color.LightGray;
                lblStop.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[13]) { lblErrBit13.BackColor = Color.LightPink; } else { lblErrBit13.BackColor = Color.LightGray; }
            if (@event.error.axErrBit[14]) { lblErrBit14.BackColor = Color.LightPink; } else { lblErrBit14.BackColor = Color.LightGray; }
            if (@event.error.axErrBit[15]) { lblErrBit15.BackColor = Color.LightPink; } else { lblErrBit15.BackColor = Color.LightGray; }

            lblErrUdi0.Text = @event.error.audiErrId[0].ToString();
            lblErrUdi1.Text = @event.error.audiErrId[1].ToString();
            lblErrUdi2.Text = @event.error.audiErrId[2].ToString();
            lblErrUdi3.Text = @event.error.audiErrId[3].ToString();
            lblErrUdi4.Text = @event.error.audiErrId[4].ToString();
            lblErrUdi5.Text = @event.error.audiErrId[5].ToString();
            lblErrUdi6.Text = @event.error.audiErrId[6].ToString();
            lblErrUdi7.Text = @event.error.audiErrId[7].ToString();
            lblErrUdi8.Text = @event.error.audiErrId[8].ToString();
            lblErrUdi9.Text = @event.error.audiErrId[9].ToString();
            lblErrUdi10.Text = @event.error.audiErrId[10].ToString();
            lblErrUdi11.Text = @event.error.audiErrId[11].ToString();
            lblErrUdi12.Text = @event.error.audiErrId[12].ToString();
            lblErrUdi13.Text = @event.error.audiErrId[13].ToString();
            lblErrUdi14.Text = @event.error.audiErrId[14].ToString();
            lblErrUdi15.Text = @event.error.audiErrId[15].ToString();

            manageBackgroundColors(@event.eTypeOfEvent);

        }
        private void manageBackgroundColors(eTypeOfEvent typeOfEvent)
        {
            switch (typeOfEvent)
            {
                case eTypeOfEvent.Info:
                    lblId.BackColor             = Color.LightBlue;
                    lblTimeStamp.BackColor      = Color.LightBlue;
                    lblTypeOfEvent.BackColor    = Color.LightBlue;
                    lblDeviceName.BackColor     = Color.LightBlue;
                    lblMessage.BackColor        = Color.LightBlue;
                    lblAlert.BackColor          = Color.LightBlue;
                    break;
                case eTypeOfEvent.Message:
                    lblId.BackColor             = Color.LightGreen;
                    lblTimeStamp.BackColor      = Color.LightGreen;
                    lblTypeOfEvent.BackColor    = Color.LightGreen;
                    lblDeviceName.BackColor     = Color.LightGreen;
                    lblMessage.BackColor        = Color.LightGreen;
                    lblAlert.BackColor          = Color.LightGreen;
                    break;
                case eTypeOfEvent.Warning:
                    lblId.BackColor             = Color.LightYellow;
                    lblTimeStamp.BackColor      = Color.LightYellow;
                    lblTypeOfEvent.BackColor    = Color.LightYellow;
                    lblDeviceName.BackColor     = Color.LightYellow;
                    lblMessage.BackColor        = Color.LightYellow;
                    lblAlert.BackColor          = Color.LightYellow;
                    break;
                case eTypeOfEvent.Error:
                    lblId.BackColor             = Color.LightPink;
                    lblTimeStamp.BackColor      = Color.LightPink;
                    lblTypeOfEvent.BackColor    = Color.LightPink;
                    lblDeviceName.BackColor     = Color.LightPink;
                    lblMessage.BackColor        = Color.LightPink;
                    lblAlert.BackColor          = Color.LightPink;
                    break;
            }
        }

        #endregion

        
    }
}
