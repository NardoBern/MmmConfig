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
        public static CPU_Connection CpuConnection;
        public Motor[] motor;
        private int iWdCheck = 0;
        
        public static EventLogger motionEventLogger;
        public string c_strMotionEventLogPath = MainSelector.appConfig.strMotionEventLogPath;
        string[,] astrString = new string[1000,7];
        public Thread trd;
        private int _i;
        public string strNetId = MainSelector.appConfig.strDefaultNetId;
        public string strPort = MainSelector.appConfig.iDefaultPort.ToString();
        #endregion

        #region Form related functions
        public LogReader()
        {
            InitializeComponent();
        }
        private void LogReader_Load(object sender, EventArgs e)
        {
            try {             
                CpuConnection = new CPU_Connection();
            
                motionEventLogger = new EventLogger();
                motionEventLogger.events = new Event[1000];
                for (int _i = 0; _i < 1000; _i++)
                {
                    motionEventLogger.events[_i] = new Event();
                    motionEventLogger.events[_i].error = new Error();
                    motionEventLogger.events[_i].operationLog = new OperationLog();
                }

                btnRefresh.Enabled = false;
                btnStopRefresh.Enabled = false;
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error while loading diagnostic app: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainSelector.appLogger.addLine("Error while loading diagnostic app: " + ex.ToString(), AppLogger.eLogLevel.fatal);
                this.Close();
            }

            if (CpuConnection.connected)
            {
                vUpdateConnectedStatus();

            }
            else
            {
                vUpdateDisconnectedStatus();
            }
            cleanDataGridView();
            Cursor.Current = Cursors.Default;
            MainSelector.appLogger.addLine("Log reader form has been corrected load", AppLogger.eLogLevel.debug);
        }
        private void dgvLogReader_CellContentClick(object sender, DataGridViewCellEventArgs e) 
        { 
            try { populateEventDetail(motionEventLogger.events[Convert.ToInt16(dgvLogReader.Rows[e.RowIndex].Cells[0].Value)]); }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error while retrieving event information: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainSelector.appLogger.addLine("Error while retrieving event information: " + ex.ToString(), AppLogger.eLogLevel.error); 
            }
            MainSelector.appLogger.addLine("The row n°: " + e.RowIndex.ToString() + " has been selected.", AppLogger.eLogLevel.debug);
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            int iNumOfEventToRead = CpuConnection.readInt(c_strMotionEventLogPath + ".iLastWritePos", CpuConnection.tcClient);
            prgBarGetInfo.Maximum = iNumOfEventToRead;
            motionEventLogger.iLastWritePos = iNumOfEventToRead;
            btnRefresh.Enabled = false;
            btnStopRefresh.Enabled = true;
            lblInProgress.Text = "In progress...";
            MainSelector.appLogger.addLine("Updating of the logger is started.", AppLogger.eLogLevel.debug);
            try
            {
                trd = new Thread(new ThreadStart(readEvent));
                trd.IsBackground = true;
                checkThread.Enabled = true;
                trd.Start();
            }
            catch (Exception _e) 
            { 
                MessageBox.Show("Error during starting of refresh Thread: " + _e.ToString(),"ERROR!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                MainSelector.appLogger.addLine("Error during refresh Thread: " + _e.ToString(), AppLogger.eLogLevel.error);
            }
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
                    lblInProgress.Text = "Stopped";
                    MainSelector.appLogger.addLine("Updating of the logger has been stopped.", AppLogger.eLogLevel.debug);
                }
            }
            catch (Exception _e) 
            { 
                MessageBox.Show("Error during stop of refresh Thread: " + _e.ToString(), "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainSelector.appLogger.addLine("Error during stop of refresh Thread: " + _e.ToString(), AppLogger.eLogLevel.error);
            }
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
                    revertEventsOrder();
                    populateDataGridView();
                    colorateDataGridView();
                    lblInProgress.Text = "Done!!";
                    btnStopRefresh.Enabled = false;
                    MainSelector.appLogger.addLine("Updating of the logger has been done.", AppLogger.eLogLevel.debug);
                }
            }
            catch (Exception _e) 
            { 
                MessageBox.Show("Error during updating of logger: " + _e.ToString(), "ERROR!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainSelector.appLogger.addLine("Error during updating of logger: " + _e.ToString(), AppLogger.eLogLevel.error);
            }
        }
        private void saveToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveToFile();
        }
        private void openFromToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile();
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (CpuConnection.connected)
            {
                CpuConnection.disconnect(CpuConnection.tcClient);
                vUpdateDisconnectedStatus();
            }
            else
            {
                CpuConnection.tcClient = CpuConnection.connect(strNetId, int.Parse(strPort));
                if (CpuConnection.tcClient != null) { tWdTimer.Enabled = true; }
                else { MessageBox.Show("Connection not started.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Close(); }
            }
        }
        private void tWdTimer_Tick(object sender, EventArgs e)
        {
            int iWatchDog = CpuConnection.readInt(MainSelector.appConfig.strReadWatchDog, CpuConnection.tcClient);
            prgConnWd.Value = iWatchDog;
            CpuConnection.writeInt(MainSelector.appConfig.strWriteWatchDog, iWatchDog);
            CpuConnection.iWatchDog = iWatchDog;
            iWdCheck = iWdCheck + 1;
            if (iWdCheck >= 6)
            {
                if (CpuConnection.checkWdValue(iWatchDog))
                {
                    vUpdateConnectedStatus();
                }
                else
                {
                    vUpdateDisconnectedStatus();
                    MessageBox.Show("Connection failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                iWdCheck = 0;
            }
        }
        private void btnMain_Click(object sender, EventArgs e)
        {
            CpuConnection.disconnect(CpuConnection.tcClient);
            vUpdateDisconnectedStatus();
            this.Hide();
            Forms.MainSelector mainSelector = new Forms.MainSelector();
            mainSelector.ShowDialog();
            this.Dispose();
            this.Close();
        }
        private void connectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.ConnectionSettings connectionSettings = new Forms.ConnectionSettings();
            connectionSettings.strNetId = strNetId;
            connectionSettings.strPort = strPort;
            var result = connectionSettings.ShowDialog();
            if (result == DialogResult.OK)
            {
                strNetId = connectionSettings.strNetId;
                strPort = connectionSettings.strPort;
            }
        }
        private void btnSaveToFile_Click(object sender, EventArgs e) {saveToFile();}
        private void btnOpenFile_Click(object sender, EventArgs e) {openFile();}

        #endregion

        #region Operative functions
        private void revertEventsOrder()
        {
            EventLogger eventLogger = new EventLogger();
            for (int _i = motionEventLogger.iLastWritePos - 1; _i >= 0; _i--) 
            {
                eventLogger.events[motionEventLogger.iLastWritePos - 1 - _i] = motionEventLogger.events[_i];
            }
            motionEventLogger.events = eventLogger.events;
        }

        private void populateDataGridView()
        {
            for (int _i = 0; _i < motionEventLogger.iLastWritePos; _i++)
            {
                astrString[_i, 0] = _i.ToString();
                astrString[_i, 1] = motionEventLogger.events[_i].uiEventId.ToString();
                astrString[_i, 2] = motionEventLogger.events[_i].strTimeStamp;
                switch (motionEventLogger.events[_i].eTypeOfEvent)
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
                astrString[_i, 4] = motionEventLogger.events[_i].strDeviceName;
                astrString[_i, 5] = motionEventLogger.events[_i].strMessage;
                astrString[_i, 6] = motionEventLogger.events[_i].strAlert;

                string[] strStringToAdd = { astrString[_i, 0], astrString[_i, 1], astrString[_i, 2], astrString[_i, 3], astrString[_i, 4], astrString[_i, 5], astrString[_i, 6] };

                dgvLogReader.Rows.Add(strStringToAdd);
            }
            for (int _i = 0; _i < 7; _i++) { dgvLogReader.AutoResizeColumn(_i); }        
        }
        private void colorateDataGridView()
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
                case enumErrorName.eNoError:
                    lblErrorDescr.Text = "No error";
                    break;
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
            int iNumOfEventToRead = CpuConnection.readInt(c_strMotionEventLogPath + ".iLastWritePos", CpuConnection.tcClient);
            for (_i = 0; _i < iNumOfEventToRead; _i++)
            {
                CpuConnection.readEvent(c_strMotionEventLogPath, CpuConnection.tcClient, _i, motionEventLogger.events[_i]);
            }
        }
        private void saveToFile()
        {
            XmlCreator xmlCreator = new XmlCreator();
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xml file|*.xml";
            saveFileDialog.Title = "Save diagnostic file";
            try 
            {
                string tempString = DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString();
                tempString = tempString.Replace(" ", "");
                tempString = tempString.Replace("/", "");
                tempString = tempString.Replace(":", "");
                saveFileDialog.FileName = "MmmDiagnostic_" + tempString;
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error while get date and time to save the file: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainSelector.appLogger.addLine("Error while get date and time to save the file: " + ex.ToString(), AppLogger.eLogLevel.error);
            }
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try 
                { 
                    if (saveFileDialog.FileName != "") 
                    {
                        revertEventsOrder();
                        xmlCreator.createXmlFile(motionEventLogger, saveFileDialog.FileName);
                        MainSelector.appLogger.addLine("File has been succesfully saved with filename: " + saveFileDialog.FileName, AppLogger.eLogLevel.debug);
                    } 
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Error while saving file: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainSelector.appLogger.addLine("Error while saving file: " + ex.ToString(), AppLogger.eLogLevel.error);
                }
            }
        }
        private void openFile()
        {
            XmlExtractor xmlReader = new XmlExtractor();
            EventLogger readLogger = new EventLogger();
            try { 
                for (int _i = 0; _i < EventLogger.iEventSize; _i++)
                {
                    readLogger.events[_i] = new Event();
                    readLogger.events[_i].operationLog = new OperationLog();
                    readLogger.events[_i].operationLog.aiOpValue = new int[5];
                    readLogger.events[_i].operationLog.arOpValue = new double[5];
                    readLogger.events[_i].operationLog.astrOpValue = new string[5];
                    readLogger.events[_i].error = new Error();
                    readLogger.events[_i].error.axErrBit = new bool[16];
                    readLogger.events[_i].error.audiErrId = new uint[16];
                }
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error while inizializing logger reader: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainSelector.appLogger.addLine("Error while inizializing logger reader: " + ex.ToString(), AppLogger.eLogLevel.error);
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "Select an xml file";
            openFileDialog.Filter = "Xml files (*.xml|*.xml";
            openFileDialog.Title = "Open xml file";
            openFileDialog.InitialDirectory = "C:\\";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try 
                { 
                    xmlReader.readXml(openFileDialog.FileName, readLogger);
                    motionEventLogger = readLogger;
                    cleanDataGridView();
                    revertEventsOrder();
                    populateDataGridView();
                    colorateDataGridView();
                    MainSelector.appLogger.addLine("File name: " + openFileDialog.FileName + " has been succesfully opened.", AppLogger.eLogLevel.debug);
                }
                catch (Exception ex) 
                { 
                    MessageBox.Show("Error while opening xml file: " + ex.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MainSelector.appLogger.addLine("Error while opening xml file: " + ex.ToString(), AppLogger.eLogLevel.error);
                }
            }
        }
        private void vUpdateConnectedStatus()
        {
            lblConnStatus.Text = "Connected";
            try { btnConnect.BackgroundImage = Image.FromFile(Environment.CurrentDirectory.ToString() + "\\Img\\connected.png"); }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error while loading image file: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainSelector.appLogger.addLine("Error while loading image file: " + ex.ToString(), AppLogger.eLogLevel.error);
            }
            tWdTimer.Enabled = true;
            btnRefresh.Enabled = true;
        }
        private void vUpdateDisconnectedStatus()
        {
            CpuConnection.connected = false;
            lblConnStatus.Text = "No connection";
            try { btnConnect.BackgroundImage = Image.FromFile(Environment.CurrentDirectory.ToString() + "\\Img\\connect.png"); }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error while loading image file: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MainSelector.appLogger.addLine("Error while loading image file: " + ex.ToString(), AppLogger.eLogLevel.error);
            }
            tWdTimer.Enabled = false;
            btnRefresh.Enabled = false;
            
        }
        #endregion
    }
}
