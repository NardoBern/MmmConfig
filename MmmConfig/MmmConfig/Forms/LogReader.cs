using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MmmConfig.Forms
{
    public partial class LogReader : Form
    {
        #region Variable declarations
        const string c_strMotionEventLogPath = "GVL_Hmi.stMotionEventLogger";
        string[,] astrString = new string[1000,7];
        public Thread trd;
        private int _i;
        #endregion

        #region Form related functions
        public LogReader()
        {
            InitializeComponent();
        }

        private void LogReader_Load(object sender, EventArgs e)
        {
            populateDataGridView();
            colorateDataGridView();
            
            Cursor.Current = Cursors.Default;
        }
        private void dgvLogReader_CellContentClick(object sender, DataGridViewCellEventArgs e) { populateEventDetail(Form1.motionEventLogger.events[Convert.ToInt16(dgvLogReader.Rows[e.RowIndex].Cells[0].Value)]); }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int iNumOfEventToRead = Form1.CpuConnection.readInt(c_strMotionEventLogPath + ".iLastWritePos", Form1.CpuConnection.tcClient);
            prgBarGetInfo.Maximum = iNumOfEventToRead;
            Form1.motionEventLogger.iLastWritePos = iNumOfEventToRead;
            btnRefresh.Enabled = false;
            btnStopRefresh.Enabled = true;
            try
            {
                trd = new Thread(new ThreadStart(readEvent));
                trd.IsBackground = true;
                checkThread.Enabled = true;
                trd.Start();
            }
            catch (Exception _e) { MessageBox.Show("Error during starting of refresh Thread: " + _e.ToString(),"ERROR!!",MessageBoxButtons.OK,MessageBoxIcon.Error); }
        }
        private void btnStopRefresh_Click(object sender, EventArgs e)
        {
            try { 
                if (trd.IsAlive)
                {
                    trd.Abort();
                    checkThread.Enabled = false;
                    btnStopRefresh.Enabled = false;
                    btnRefresh.Enabled = true;
                }
            }
            catch (Exception _e) { MessageBox.Show("Error during stop of refresh Thread: " + _e.ToString(), "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void checkThread_Tick(object sender, EventArgs e)
        {
            try {
                bool trdState = trd.IsAlive;
                if (trdState) { prgBarGetInfo.Value = _i; }
                else
                {
                    checkThread.Enabled = false;
                    cleanDataGridView();
                    populateDataGridView();
                    colorateDataGridView();
                }
            }
            catch (Exception _e) { MessageBox.Show("Error during updating of logger: " + _e.ToString(), "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        #region Operative functions
        public void populateDataGridView()
        {
            for (int _i = 0; _i < Form1.motionEventLogger.iLastWritePos; _i++)
            {
                astrString[_i, 0] = _i.ToString();
                astrString[_i, 1] = Form1.motionEventLogger.events[_i].uiEventId.ToString();
                astrString[_i, 2] = Form1.motionEventLogger.events[_i].strTimeStamp;
                switch (Form1.motionEventLogger.events[_i].eTypeOfEvent)
                {
                    case eTypeOfEvent.Info:
                        astrString[_i, 3] = "Information";
                        break;
                    case eTypeOfEvent.Message:
                        astrString[_i, 3] = "Message";
                        break;
                    case eTypeOfEvent.Warning:
                        astrString[_i, 3] = "Warning";
                        break;
                    case eTypeOfEvent.Error:
                        astrString[_i, 3] = "Error";
                        break;
                }
                astrString[_i, 4] = Form1.motionEventLogger.events[_i].strDeviceName;
                astrString[_i, 5] = Form1.motionEventLogger.events[_i].strMessage;
                astrString[_i, 6] = Form1.motionEventLogger.events[_i].strAlert;

                string[] strStringToAdd = { astrString[_i, 0], astrString[_i, 1], astrString[_i, 2], astrString[_i, 3], astrString[_i, 4], astrString[_i, 5], astrString[_i, 6] };

                dgvLogReader.Rows.Add(strStringToAdd);
            }
            for (int _i = 0; _i < 7; _i++) { dgvLogReader.AutoResizeColumn(_i); }        
        }
        
        public void colorateDataGridView()
        {
            foreach (DataGridViewRow row in dgvLogReader.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    switch (row.Cells[3].Value.ToString())
                    {
                        case "Information":
                            row.DefaultCellStyle.BackColor = Color.LightBlue;
                            break;
                        case "Message":
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case "Warning":
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            break;
                        case "Error":
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                            break;
                    }
                }
            }
        }
        private void cleanDataGridView() { dgvLogReader.Rows.Clear(); }
        private void populateEventDetail(Event @event)
        {
            const string c_strErrorDescr = "Error description: ";
            lblOpDescr.Text = @event.operationLog.strOperationDescr;
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
            lblError.Text = "Error global: " + @event.error.xErrorGlobal.ToString();
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
            if (@event.error.axErrBit[0])
            {
                lblErrBit0.BackColor = Color.LightPink;
                lblErrUdi0.BackColor = Color.LightPink;
                lblResetMasterEnc.BackColor = Color.LightPink;
            }
            else
            {
                lblErrBit0.BackColor = Color.LightGray;
                lblErrUdi0.BackColor = Color.LightGray;
                lblResetMasterEnc.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[1])
            {
                lblErrBit1.BackColor = Color.LightPink;
                lblErrUdi1.BackColor = Color.LightPink;
                lblZeroMasterEncoder.BackColor = Color.LightPink;
            }
            else
            {
                lblErrBit1.BackColor = Color.LightGray;
                lblErrUdi1.BackColor = Color.LightGray;
                lblZeroMasterEncoder.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[2])
            {
                lblErrBit2.BackColor = Color.LightPink;
                lblErrUdi2.BackColor = Color.LightPink;
                lblSlaveAxis.BackColor = Color.LightPink;
            }
            else
            {
                lblErrBit2.BackColor = Color.LightGray;
                lblErrUdi2.BackColor = Color.LightGray;
                lblSlaveAxis.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[3])
            {
                lblErrBit3.BackColor = Color.LightPink;
                lblErrUdi3.BackColor = Color.LightPink;
                lblResetSlaveAxis.BackColor = Color.LightPink;
            }
            else
            {
                lblErrBit3.BackColor = Color.LightGray;
                lblErrUdi3.BackColor = Color.LightGray;
                lblResetSlaveAxis.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[4])
            {
                lblErrBit4.BackColor = Color.LightPink;
                lblErrUdi4.BackColor = Color.LightPink;
                lblMoveModulo.BackColor = Color.LightPink;
            }
            else
            {
                lblErrBit4.BackColor = Color.LightGray;
                lblErrUdi4.BackColor = Color.LightGray;
                lblMoveModulo.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[5])
            {
                lblErrBit5.BackColor = Color.LightPink;
                lblErrUdi5.BackColor = Color.LightPink;
                lblGearIn.BackColor = Color.LightPink;
            }
            else
            {
                lblErrBit5.BackColor = Color.LightGray;
                lblErrUdi5.BackColor = Color.LightGray;
                lblGearIn.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[6])
            {
                lblErrBit6.BackColor = Color.LightPink;
                lblErrUdi6.BackColor = Color.LightPink;
                lblGearOut.BackColor = Color.LightPink;
            }
            else
            {
                lblErrBit6.BackColor = Color.LightGray;
                lblErrUdi6.BackColor = Color.LightGray;
                lblGearOut.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[7])
            {
                lblErrBit7.BackColor = Color.LightPink;
                lblErrUdi7.BackColor = Color.LightPink;
                lblPhasingRelative.BackColor = Color.LightPink;
            }
            else
            {
                lblErrBit7.BackColor = Color.LightGray;
                lblErrUdi7.BackColor = Color.LightGray;
                lblPhasingRelative.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[8])
            {
                lblErrBit8.BackColor = Color.LightPink;
                lblErrUdi8.BackColor = Color.LightPink;
                lblPower.BackColor = Color.LightPink;
            }
            else
            {
                lblErrBit8.BackColor = Color.LightGray;
                lblErrUdi8.BackColor = Color.LightGray;
                lblPower.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[9])
            {
                lblErrBit9.BackColor = Color.LightPink;
                lblErrUdi9.BackColor = Color.LightPink;
                lblJog.BackColor = Color.LightPink;
            }
            else
            {
                lblErrBit9.BackColor = Color.LightGray;
                lblErrUdi9.BackColor = Color.LightGray;
                lblJog.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[10])
            {
                lblErrBit10.BackColor = Color.LightPink;
                lblErrUdi10.BackColor = Color.LightPink;
                lblMoveVel.BackColor = Color.LightPink;
            }
            else
            {
                lblErrBit10.BackColor = Color.LightGray;
                lblErrUdi10.BackColor = Color.LightGray;
                lblMoveVel.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[11])
            {
                lblErrBit11.BackColor = Color.LightPink;
                lblErrUdi11.BackColor = Color.LightPink;
                lblSetPos.BackColor = Color.LightPink;
            }
            else
            {
                lblErrBit11.BackColor = Color.LightGray;
                lblErrUdi11.BackColor = Color.LightGray;
                lblSetPos.BackColor = Color.LightGray;
            }
            if (@event.error.axErrBit[12])
            {
                lblErrBit12.BackColor = Color.LightPink;
                lblErrUdi12.BackColor = Color.LightPink;
                lblStop.BackColor = Color.LightPink;
            }
            else
            {
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
        }

        private void readEvent()
        {
            int iNumOfEventToRead = Form1.CpuConnection.readInt(c_strMotionEventLogPath + ".iLastWritePos", Form1.CpuConnection.tcClient);
            for (_i = 0; _i < iNumOfEventToRead; _i++)
            {
                Form1.CpuConnection.readEvent(c_strMotionEventLogPath, Form1.CpuConnection.tcClient, _i, Form1.motionEventLogger.events[_i]);
            }
        }

        #endregion

        
    }
}
