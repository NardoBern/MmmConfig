
namespace MmmConfig.Forms
{
    partial class LogReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogReader));
            this.dgvLogReader = new System.Windows.Forms.DataGridView();
            this.EventNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventAlert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpOpDescr = new System.Windows.Forms.GroupBox();
            this.lblReal4 = new System.Windows.Forms.Label();
            this.lblReal3 = new System.Windows.Forms.Label();
            this.lblReal2 = new System.Windows.Forms.Label();
            this.lblReal1 = new System.Windows.Forms.Label();
            this.lblIntVal4 = new System.Windows.Forms.Label();
            this.lblIntVal3 = new System.Windows.Forms.Label();
            this.lblIntVal2 = new System.Windows.Forms.Label();
            this.lblIntVal1 = new System.Windows.Forms.Label();
            this.lblOpStr4 = new System.Windows.Forms.Label();
            this.lblOpStr3 = new System.Windows.Forms.Label();
            this.lblOpStr2 = new System.Windows.Forms.Label();
            this.lblOpStr1 = new System.Windows.Forms.Label();
            this.lblOpDescr = new System.Windows.Forms.Label();
            this.grpError = new System.Windows.Forms.GroupBox();
            this.lblFree3 = new System.Windows.Forms.Label();
            this.lblFree2 = new System.Windows.Forms.Label();
            this.lblFree1 = new System.Windows.Forms.Label();
            this.lblStop = new System.Windows.Forms.Label();
            this.lblSetPos = new System.Windows.Forms.Label();
            this.lblMoveVel = new System.Windows.Forms.Label();
            this.lblJog = new System.Windows.Forms.Label();
            this.lblPower = new System.Windows.Forms.Label();
            this.lblPhasingRelative = new System.Windows.Forms.Label();
            this.lblGearOut = new System.Windows.Forms.Label();
            this.lblGearIn = new System.Windows.Forms.Label();
            this.lblMoveModulo = new System.Windows.Forms.Label();
            this.lblResetSlaveAxis = new System.Windows.Forms.Label();
            this.lblSlaveAxis = new System.Windows.Forms.Label();
            this.lblZeroMasterEncoder = new System.Windows.Forms.Label();
            this.lblResetMasterEnc = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblErrorDescr = new System.Windows.Forms.Label();
            this.lblErrUdi15 = new System.Windows.Forms.Label();
            this.lblErrBit0 = new System.Windows.Forms.Label();
            this.lblErrUdi14 = new System.Windows.Forms.Label();
            this.lblErrBit1 = new System.Windows.Forms.Label();
            this.lblErrUdi13 = new System.Windows.Forms.Label();
            this.lblErrBit2 = new System.Windows.Forms.Label();
            this.lblErrUdi12 = new System.Windows.Forms.Label();
            this.lblErrBit3 = new System.Windows.Forms.Label();
            this.lblErrUdi11 = new System.Windows.Forms.Label();
            this.lblErrBit4 = new System.Windows.Forms.Label();
            this.lblErrUdi10 = new System.Windows.Forms.Label();
            this.lblErrBit5 = new System.Windows.Forms.Label();
            this.lblErrUdi9 = new System.Windows.Forms.Label();
            this.lblErrBit6 = new System.Windows.Forms.Label();
            this.lblErrBit15 = new System.Windows.Forms.Label();
            this.lblErrUdi8 = new System.Windows.Forms.Label();
            this.lblErrBit14 = new System.Windows.Forms.Label();
            this.lblErrBit7 = new System.Windows.Forms.Label();
            this.lblErrBit13 = new System.Windows.Forms.Label();
            this.lblErrUdi7 = new System.Windows.Forms.Label();
            this.lblErrBit12 = new System.Windows.Forms.Label();
            this.lblErrBit8 = new System.Windows.Forms.Label();
            this.lblErrBit11 = new System.Windows.Forms.Label();
            this.lblErrUdi6 = new System.Windows.Forms.Label();
            this.lblErrBit10 = new System.Windows.Forms.Label();
            this.lblErrUdi0 = new System.Windows.Forms.Label();
            this.lblErrBit9 = new System.Windows.Forms.Label();
            this.lblErrUdi5 = new System.Windows.Forms.Label();
            this.lblErrUdi1 = new System.Windows.Forms.Label();
            this.lblErrUdi4 = new System.Windows.Forms.Label();
            this.lblErrUdi2 = new System.Windows.Forms.Label();
            this.lblErrUdi3 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.checkThread = new System.Windows.Forms.Timer(this.components);
            this.prgBarGetInfo = new System.Windows.Forms.ProgressBar();
            this.btnStopRefresh = new System.Windows.Forms.Button();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.prgConnWd = new System.Windows.Forms.ProgressBar();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tWdTimer = new System.Windows.Forms.Timer(this.components);
            this.lblMainMenu = new System.Windows.Forms.Label();
            this.btnMain = new System.Windows.Forms.Button();
            this.lblConnect = new System.Windows.Forms.Label();
            this.lblUpload = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.lblSaveToFile = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblOpenFile = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCpuData = new System.Windows.Forms.TabPage();
            this.grpUserManagement = new System.Windows.Forms.GroupBox();
            this.lblCPUValue56 = new System.Windows.Forms.Label();
            this.lblCPUParameter56 = new System.Windows.Forms.Label();
            this.grpUPS = new System.Windows.Forms.GroupBox();
            this.lblCPUValue55 = new System.Windows.Forms.Label();
            this.lblCPUValue54 = new System.Windows.Forms.Label();
            this.lblCPUValue53 = new System.Windows.Forms.Label();
            this.lblCPUValue52 = new System.Windows.Forms.Label();
            this.lbCPUlValue51 = new System.Windows.Forms.Label();
            this.lblCPUValue50 = new System.Windows.Forms.Label();
            this.lblCPUValue49 = new System.Windows.Forms.Label();
            this.lblCPUValue48 = new System.Windows.Forms.Label();
            this.lblCPUValue47 = new System.Windows.Forms.Label();
            this.lblCPUValue46 = new System.Windows.Forms.Label();
            this.lblCPUParameter55 = new System.Windows.Forms.Label();
            this.lblCPUParameter54 = new System.Windows.Forms.Label();
            this.lblCPUParameter53 = new System.Windows.Forms.Label();
            this.lblCPUParameter52 = new System.Windows.Forms.Label();
            this.lblCPUParameter51 = new System.Windows.Forms.Label();
            this.lblCPUParameter50 = new System.Windows.Forms.Label();
            this.lblCPUParameter49 = new System.Windows.Forms.Label();
            this.lblCPUParameter48 = new System.Windows.Forms.Label();
            this.lblCPUParameter47 = new System.Windows.Forms.Label();
            this.lblCPUParameter46 = new System.Windows.Forms.Label();
            this.grpTwinCAT = new System.Windows.Forms.GroupBox();
            this.lblCPUValue45 = new System.Windows.Forms.Label();
            this.lblCPUValue44 = new System.Windows.Forms.Label();
            this.lblCPUValue43 = new System.Windows.Forms.Label();
            this.lblCPUValue42 = new System.Windows.Forms.Label();
            this.lblCPUValue41 = new System.Windows.Forms.Label();
            this.lblCPUValue40 = new System.Windows.Forms.Label();
            this.lblCPUValue39 = new System.Windows.Forms.Label();
            this.lblCPUParameter45 = new System.Windows.Forms.Label();
            this.lblCPUParameter44 = new System.Windows.Forms.Label();
            this.lblCPUParameter43 = new System.Windows.Forms.Label();
            this.lblCPUParameter42 = new System.Windows.Forms.Label();
            this.lblCPUParameter41 = new System.Windows.Forms.Label();
            this.lblCPUParameter40 = new System.Windows.Forms.Label();
            this.lblCPUParameter39 = new System.Windows.Forms.Label();
            this.grpOperatingSystem = new System.Windows.Forms.GroupBox();
            this.lblCPUValue38 = new System.Windows.Forms.Label();
            this.lblCPUValue37 = new System.Windows.Forms.Label();
            this.lblCPUValue36 = new System.Windows.Forms.Label();
            this.lblCPUParameter38 = new System.Windows.Forms.Label();
            this.lblCPUParameter37 = new System.Windows.Forms.Label();
            this.lblCPUParameter36 = new System.Windows.Forms.Label();
            this.grpNetworkinterface2 = new System.Windows.Forms.GroupBox();
            this.lblCPUValue35 = new System.Windows.Forms.Label();
            this.lblCPUValue34 = new System.Windows.Forms.Label();
            this.lblCPUValue32 = new System.Windows.Forms.Label();
            this.lblCPUValue33 = new System.Windows.Forms.Label();
            this.lblCPUParameter35 = new System.Windows.Forms.Label();
            this.lblCPUParameter34 = new System.Windows.Forms.Label();
            this.lblCPUParameter33 = new System.Windows.Forms.Label();
            this.lblCPUParameter32 = new System.Windows.Forms.Label();
            this.grpNetworkinterface1 = new System.Windows.Forms.GroupBox();
            this.lblCPUValue31 = new System.Windows.Forms.Label();
            this.lbCPUlValue30 = new System.Windows.Forms.Label();
            this.lblCPUValue29 = new System.Windows.Forms.Label();
            this.lblCPUValue28 = new System.Windows.Forms.Label();
            this.lblCPUParameter31 = new System.Windows.Forms.Label();
            this.lblCPUParameter30 = new System.Windows.Forms.Label();
            this.lblCPUParameter29 = new System.Windows.Forms.Label();
            this.lblCPUParameter28 = new System.Windows.Forms.Label();
            this.grpDiskMnagement = new System.Windows.Forms.GroupBox();
            this.lblCPUValue23 = new System.Windows.Forms.Label();
            this.lblCPUValue22 = new System.Windows.Forms.Label();
            this.lblCPUValue21 = new System.Windows.Forms.Label();
            this.lblCPUValue20 = new System.Windows.Forms.Label();
            this.lblCPUValue19 = new System.Windows.Forms.Label();
            this.lblCPUValue18 = new System.Windows.Forms.Label();
            this.lblCPUParameter23 = new System.Windows.Forms.Label();
            this.lblCPUParameter22 = new System.Windows.Forms.Label();
            this.lblCPUParameter21 = new System.Windows.Forms.Label();
            this.lblCPUParameter20 = new System.Windows.Forms.Label();
            this.lblCPUParameter19 = new System.Windows.Forms.Label();
            this.lblCPUParameter18 = new System.Windows.Forms.Label();
            this.grpMemory = new System.Windows.Forms.GroupBox();
            this.lblCPUValue27 = new System.Windows.Forms.Label();
            this.lblCPUValue26 = new System.Windows.Forms.Label();
            this.lblCPUValue25 = new System.Windows.Forms.Label();
            this.lblCPUValue24 = new System.Windows.Forms.Label();
            this.lblCPUParameter26 = new System.Windows.Forms.Label();
            this.lblCPUParameter27 = new System.Windows.Forms.Label();
            this.lblCPUParameter25 = new System.Windows.Forms.Label();
            this.lblCPUParameter24 = new System.Windows.Forms.Label();
            this.grpHardwareData = new System.Windows.Forms.GroupBox();
            this.lblCPUValue17 = new System.Windows.Forms.Label();
            this.lblCPUValue16 = new System.Windows.Forms.Label();
            this.lblCPUValue15 = new System.Windows.Forms.Label();
            this.lblCPUValue14 = new System.Windows.Forms.Label();
            this.lblCPUValue13 = new System.Windows.Forms.Label();
            this.lblCPUValue12 = new System.Windows.Forms.Label();
            this.lblCPUValue11 = new System.Windows.Forms.Label();
            this.lblCPUValue10 = new System.Windows.Forms.Label();
            this.lblCPUValue9 = new System.Windows.Forms.Label();
            this.lblCPUValue8 = new System.Windows.Forms.Label();
            this.lblCPUParameter17 = new System.Windows.Forms.Label();
            this.lblCPUParameter16 = new System.Windows.Forms.Label();
            this.lblCPUParameter15 = new System.Windows.Forms.Label();
            this.lblCPUParameter14 = new System.Windows.Forms.Label();
            this.lblCPUParameter13 = new System.Windows.Forms.Label();
            this.lblCPUParameter12 = new System.Windows.Forms.Label();
            this.lblCPUParameter11 = new System.Windows.Forms.Label();
            this.lblCPUParameter10 = new System.Windows.Forms.Label();
            this.lblCPUParameter9 = new System.Windows.Forms.Label();
            this.lblCPUParameter8 = new System.Windows.Forms.Label();
            this.grpOperationData = new System.Windows.Forms.GroupBox();
            this.lblCPUValue7 = new System.Windows.Forms.Label();
            this.lblCPUValue6 = new System.Windows.Forms.Label();
            this.lblCPUParameter7 = new System.Windows.Forms.Label();
            this.lblCPUParameter6 = new System.Windows.Forms.Label();
            this.grpIdentityCard = new System.Windows.Forms.GroupBox();
            this.lblCPUValue5 = new System.Windows.Forms.Label();
            this.lblCPUValue4 = new System.Windows.Forms.Label();
            this.lblCPUValue3 = new System.Windows.Forms.Label();
            this.lblCPUValue2 = new System.Windows.Forms.Label();
            this.lblCPUValue1 = new System.Windows.Forms.Label();
            this.lblCPUParameter5 = new System.Windows.Forms.Label();
            this.lblCPUParameter4 = new System.Windows.Forms.Label();
            this.lblCPUParameter3 = new System.Windows.Forms.Label();
            this.lblCPUParameter2 = new System.Windows.Forms.Label();
            this.lblCPUValue0 = new System.Windows.Forms.Label();
            this.lblCPUParameter1 = new System.Windows.Forms.Label();
            this.lblCPUParameter0 = new System.Windows.Forms.Label();
            this.tabEncoderData = new System.Windows.Forms.TabPage();
            this.grpParameter = new System.Windows.Forms.GroupBox();
            this.lblEncVal24 = new System.Windows.Forms.Label();
            this.lblEncVal23 = new System.Windows.Forms.Label();
            this.lblEncPar24 = new System.Windows.Forms.Label();
            this.lblEncPar23 = new System.Windows.Forms.Label();
            this.lblEncVal22 = new System.Windows.Forms.Label();
            this.lblEncVal21 = new System.Windows.Forms.Label();
            this.lblEncVal20 = new System.Windows.Forms.Label();
            this.lblEncVal19 = new System.Windows.Forms.Label();
            this.lblEncVal18 = new System.Windows.Forms.Label();
            this.lblEncVal17 = new System.Windows.Forms.Label();
            this.lblEncVal16 = new System.Windows.Forms.Label();
            this.lblEncVal15 = new System.Windows.Forms.Label();
            this.lblEncVal14 = new System.Windows.Forms.Label();
            this.lblEncVal13 = new System.Windows.Forms.Label();
            this.lblEncPar22 = new System.Windows.Forms.Label();
            this.lblEncPar21 = new System.Windows.Forms.Label();
            this.lblEncPar20 = new System.Windows.Forms.Label();
            this.lblEncPar19 = new System.Windows.Forms.Label();
            this.lblEncPar18 = new System.Windows.Forms.Label();
            this.lblEncPar17 = new System.Windows.Forms.Label();
            this.lblEncPar16 = new System.Windows.Forms.Label();
            this.lblEncPar15 = new System.Windows.Forms.Label();
            this.lblEncPar14 = new System.Windows.Forms.Label();
            this.lblEncPar13 = new System.Windows.Forms.Label();
            this.grpValue = new System.Windows.Forms.GroupBox();
            this.lblEncVal12 = new System.Windows.Forms.Label();
            this.lblEncVal11 = new System.Windows.Forms.Label();
            this.lblEncVal10 = new System.Windows.Forms.Label();
            this.lblEncVal9 = new System.Windows.Forms.Label();
            this.lblEncVal8 = new System.Windows.Forms.Label();
            this.lblEncVal7 = new System.Windows.Forms.Label();
            this.lblEncVal6 = new System.Windows.Forms.Label();
            this.lblEncVal5 = new System.Windows.Forms.Label();
            this.lblEncVal4 = new System.Windows.Forms.Label();
            this.lblEncPar12 = new System.Windows.Forms.Label();
            this.lblEncPar11 = new System.Windows.Forms.Label();
            this.lblEncPar10 = new System.Windows.Forms.Label();
            this.lblEncPar9 = new System.Windows.Forms.Label();
            this.lblEncPar8 = new System.Windows.Forms.Label();
            this.lblEncPar7 = new System.Windows.Forms.Label();
            this.lblEncPar6 = new System.Windows.Forms.Label();
            this.lblEncPar5 = new System.Windows.Forms.Label();
            this.lblEncPar4 = new System.Windows.Forms.Label();
            this.grpConnection = new System.Windows.Forms.GroupBox();
            this.lblEncVal3 = new System.Windows.Forms.Label();
            this.lblEncVal2 = new System.Windows.Forms.Label();
            this.lblEncVal1 = new System.Windows.Forms.Label();
            this.lblEncPar3 = new System.Windows.Forms.Label();
            this.lblEncPar2 = new System.Windows.Forms.Label();
            this.lblEncVal0 = new System.Windows.Forms.Label();
            this.lblEncPar1 = new System.Windows.Forms.Label();
            this.lblEncPar0 = new System.Windows.Forms.Label();
            this.tabLogger = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogReader)).BeginInit();
            this.grpOpDescr.SuspendLayout();
            this.grpError.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabCpuData.SuspendLayout();
            this.grpUserManagement.SuspendLayout();
            this.grpUPS.SuspendLayout();
            this.grpTwinCAT.SuspendLayout();
            this.grpOperatingSystem.SuspendLayout();
            this.grpNetworkinterface2.SuspendLayout();
            this.grpNetworkinterface1.SuspendLayout();
            this.grpDiskMnagement.SuspendLayout();
            this.grpMemory.SuspendLayout();
            this.grpHardwareData.SuspendLayout();
            this.grpOperationData.SuspendLayout();
            this.grpIdentityCard.SuspendLayout();
            this.tabEncoderData.SuspendLayout();
            this.grpParameter.SuspendLayout();
            this.grpValue.SuspendLayout();
            this.grpConnection.SuspendLayout();
            this.tabLogger.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvLogReader
            // 
            this.dgvLogReader.AllowUserToOrderColumns = true;
            this.dgvLogReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLogReader.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EventNumber,
            this.EventId,
            this.EventTimeStamp,
            this.EventType,
            this.EventDevice,
            this.EventMessage,
            this.EventAlert});
            this.dgvLogReader.Location = new System.Drawing.Point(6, 155);
            this.dgvLogReader.Name = "dgvLogReader";
            this.dgvLogReader.Size = new System.Drawing.Size(788, 664);
            this.dgvLogReader.TabIndex = 0;
            this.dgvLogReader.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLogReader_CellContentClick);
            // 
            // EventNumber
            // 
            this.EventNumber.DividerWidth = 1;
            this.EventNumber.HeaderText = "N°";
            this.EventNumber.Name = "EventNumber";
            // 
            // EventId
            // 
            this.EventId.DividerWidth = 1;
            this.EventId.HeaderText = "ID";
            this.EventId.Name = "EventId";
            // 
            // EventTimeStamp
            // 
            this.EventTimeStamp.DividerWidth = 1;
            this.EventTimeStamp.HeaderText = "TimeStamp";
            this.EventTimeStamp.Name = "EventTimeStamp";
            // 
            // EventType
            // 
            this.EventType.DividerWidth = 1;
            this.EventType.HeaderText = "Type";
            this.EventType.Name = "EventType";
            // 
            // EventDevice
            // 
            this.EventDevice.DividerWidth = 1;
            this.EventDevice.HeaderText = "Device";
            this.EventDevice.Name = "EventDevice";
            // 
            // EventMessage
            // 
            this.EventMessage.DividerWidth = 1;
            this.EventMessage.HeaderText = "Message";
            this.EventMessage.Name = "EventMessage";
            // 
            // EventAlert
            // 
            this.EventAlert.DividerWidth = 1;
            this.EventAlert.HeaderText = "Alert";
            this.EventAlert.Name = "EventAlert";
            // 
            // grpOpDescr
            // 
            this.grpOpDescr.BackColor = System.Drawing.SystemColors.Control;
            this.grpOpDescr.Controls.Add(this.lblReal4);
            this.grpOpDescr.Controls.Add(this.lblReal3);
            this.grpOpDescr.Controls.Add(this.lblReal2);
            this.grpOpDescr.Controls.Add(this.lblReal1);
            this.grpOpDescr.Controls.Add(this.lblIntVal4);
            this.grpOpDescr.Controls.Add(this.lblIntVal3);
            this.grpOpDescr.Controls.Add(this.lblIntVal2);
            this.grpOpDescr.Controls.Add(this.lblIntVal1);
            this.grpOpDescr.Controls.Add(this.lblOpStr4);
            this.grpOpDescr.Controls.Add(this.lblOpStr3);
            this.grpOpDescr.Controls.Add(this.lblOpStr2);
            this.grpOpDescr.Controls.Add(this.lblOpStr1);
            this.grpOpDescr.Controls.Add(this.lblOpDescr);
            this.grpOpDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOpDescr.Location = new System.Drawing.Point(800, 157);
            this.grpOpDescr.Name = "grpOpDescr";
            this.grpOpDescr.Size = new System.Drawing.Size(418, 196);
            this.grpOpDescr.TabIndex = 48;
            this.grpOpDescr.TabStop = false;
            this.grpOpDescr.Text = "Operation description";
            // 
            // lblReal4
            // 
            this.lblReal4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblReal4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal4.Location = new System.Drawing.Point(286, 162);
            this.lblReal4.Name = "lblReal4";
            this.lblReal4.Size = new System.Drawing.Size(60, 23);
            this.lblReal4.TabIndex = 56;
            this.lblReal4.Text = "00000";
            this.lblReal4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReal3
            // 
            this.lblReal3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblReal3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal3.Location = new System.Drawing.Point(286, 131);
            this.lblReal3.Name = "lblReal3";
            this.lblReal3.Size = new System.Drawing.Size(60, 23);
            this.lblReal3.TabIndex = 55;
            this.lblReal3.Text = "00000";
            this.lblReal3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReal2
            // 
            this.lblReal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblReal2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal2.Location = new System.Drawing.Point(286, 100);
            this.lblReal2.Name = "lblReal2";
            this.lblReal2.Size = new System.Drawing.Size(60, 23);
            this.lblReal2.TabIndex = 54;
            this.lblReal2.Text = "00000";
            this.lblReal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReal1
            // 
            this.lblReal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblReal1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal1.Location = new System.Drawing.Point(286, 69);
            this.lblReal1.Name = "lblReal1";
            this.lblReal1.Size = new System.Drawing.Size(60, 23);
            this.lblReal1.TabIndex = 53;
            this.lblReal1.Text = "00000";
            this.lblReal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntVal4
            // 
            this.lblIntVal4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIntVal4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIntVal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntVal4.Location = new System.Drawing.Point(220, 162);
            this.lblIntVal4.Name = "lblIntVal4";
            this.lblIntVal4.Size = new System.Drawing.Size(60, 23);
            this.lblIntVal4.TabIndex = 52;
            this.lblIntVal4.Text = "00000";
            this.lblIntVal4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntVal3
            // 
            this.lblIntVal3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIntVal3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIntVal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntVal3.Location = new System.Drawing.Point(220, 131);
            this.lblIntVal3.Name = "lblIntVal3";
            this.lblIntVal3.Size = new System.Drawing.Size(60, 23);
            this.lblIntVal3.TabIndex = 51;
            this.lblIntVal3.Text = "00000";
            this.lblIntVal3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntVal2
            // 
            this.lblIntVal2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIntVal2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIntVal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntVal2.Location = new System.Drawing.Point(220, 100);
            this.lblIntVal2.Name = "lblIntVal2";
            this.lblIntVal2.Size = new System.Drawing.Size(60, 23);
            this.lblIntVal2.TabIndex = 50;
            this.lblIntVal2.Text = "00000";
            this.lblIntVal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIntVal1
            // 
            this.lblIntVal1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblIntVal1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIntVal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIntVal1.Location = new System.Drawing.Point(220, 69);
            this.lblIntVal1.Name = "lblIntVal1";
            this.lblIntVal1.Size = new System.Drawing.Size(60, 23);
            this.lblIntVal1.TabIndex = 45;
            this.lblIntVal1.Text = "00000";
            this.lblIntVal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOpStr4
            // 
            this.lblOpStr4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOpStr4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOpStr4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpStr4.Location = new System.Drawing.Point(4, 162);
            this.lblOpStr4.Name = "lblOpStr4";
            this.lblOpStr4.Size = new System.Drawing.Size(210, 23);
            this.lblOpStr4.TabIndex = 49;
            this.lblOpStr4.Text = "Value: -----------------------";
            // 
            // lblOpStr3
            // 
            this.lblOpStr3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOpStr3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOpStr3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpStr3.Location = new System.Drawing.Point(4, 131);
            this.lblOpStr3.Name = "lblOpStr3";
            this.lblOpStr3.Size = new System.Drawing.Size(210, 23);
            this.lblOpStr3.TabIndex = 48;
            this.lblOpStr3.Text = "Value: -----------------------";
            // 
            // lblOpStr2
            // 
            this.lblOpStr2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOpStr2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOpStr2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpStr2.Location = new System.Drawing.Point(4, 100);
            this.lblOpStr2.Name = "lblOpStr2";
            this.lblOpStr2.Size = new System.Drawing.Size(210, 23);
            this.lblOpStr2.TabIndex = 47;
            this.lblOpStr2.Text = "Value: -----------------------";
            // 
            // lblOpStr1
            // 
            this.lblOpStr1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOpStr1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOpStr1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpStr1.Location = new System.Drawing.Point(4, 69);
            this.lblOpStr1.Name = "lblOpStr1";
            this.lblOpStr1.Size = new System.Drawing.Size(210, 23);
            this.lblOpStr1.TabIndex = 46;
            this.lblOpStr1.Text = "Value: -----------------------";
            // 
            // lblOpDescr
            // 
            this.lblOpDescr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblOpDescr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOpDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpDescr.Location = new System.Drawing.Point(4, 27);
            this.lblOpDescr.Name = "lblOpDescr";
            this.lblOpDescr.Size = new System.Drawing.Size(400, 23);
            this.lblOpDescr.TabIndex = 45;
            this.lblOpDescr.Text = "Operation decription: ----------------------------------------------";
            // 
            // grpError
            // 
            this.grpError.BackColor = System.Drawing.SystemColors.Control;
            this.grpError.Controls.Add(this.lblFree3);
            this.grpError.Controls.Add(this.lblFree2);
            this.grpError.Controls.Add(this.lblFree1);
            this.grpError.Controls.Add(this.lblStop);
            this.grpError.Controls.Add(this.lblSetPos);
            this.grpError.Controls.Add(this.lblMoveVel);
            this.grpError.Controls.Add(this.lblJog);
            this.grpError.Controls.Add(this.lblPower);
            this.grpError.Controls.Add(this.lblPhasingRelative);
            this.grpError.Controls.Add(this.lblGearOut);
            this.grpError.Controls.Add(this.lblGearIn);
            this.grpError.Controls.Add(this.lblMoveModulo);
            this.grpError.Controls.Add(this.lblResetSlaveAxis);
            this.grpError.Controls.Add(this.lblSlaveAxis);
            this.grpError.Controls.Add(this.lblZeroMasterEncoder);
            this.grpError.Controls.Add(this.lblResetMasterEnc);
            this.grpError.Controls.Add(this.lblError);
            this.grpError.Controls.Add(this.lblErrorDescr);
            this.grpError.Controls.Add(this.lblErrUdi15);
            this.grpError.Controls.Add(this.lblErrBit0);
            this.grpError.Controls.Add(this.lblErrUdi14);
            this.grpError.Controls.Add(this.lblErrBit1);
            this.grpError.Controls.Add(this.lblErrUdi13);
            this.grpError.Controls.Add(this.lblErrBit2);
            this.grpError.Controls.Add(this.lblErrUdi12);
            this.grpError.Controls.Add(this.lblErrBit3);
            this.grpError.Controls.Add(this.lblErrUdi11);
            this.grpError.Controls.Add(this.lblErrBit4);
            this.grpError.Controls.Add(this.lblErrUdi10);
            this.grpError.Controls.Add(this.lblErrBit5);
            this.grpError.Controls.Add(this.lblErrUdi9);
            this.grpError.Controls.Add(this.lblErrBit6);
            this.grpError.Controls.Add(this.lblErrBit15);
            this.grpError.Controls.Add(this.lblErrUdi8);
            this.grpError.Controls.Add(this.lblErrBit14);
            this.grpError.Controls.Add(this.lblErrBit7);
            this.grpError.Controls.Add(this.lblErrBit13);
            this.grpError.Controls.Add(this.lblErrUdi7);
            this.grpError.Controls.Add(this.lblErrBit12);
            this.grpError.Controls.Add(this.lblErrBit8);
            this.grpError.Controls.Add(this.lblErrBit11);
            this.grpError.Controls.Add(this.lblErrUdi6);
            this.grpError.Controls.Add(this.lblErrBit10);
            this.grpError.Controls.Add(this.lblErrUdi0);
            this.grpError.Controls.Add(this.lblErrBit9);
            this.grpError.Controls.Add(this.lblErrUdi5);
            this.grpError.Controls.Add(this.lblErrUdi1);
            this.grpError.Controls.Add(this.lblErrUdi4);
            this.grpError.Controls.Add(this.lblErrUdi2);
            this.grpError.Controls.Add(this.lblErrUdi3);
            this.grpError.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.grpError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpError.ForeColor = System.Drawing.SystemColors.ControlText;
            this.grpError.Location = new System.Drawing.Point(800, 359);
            this.grpError.Name = "grpError";
            this.grpError.Size = new System.Drawing.Size(418, 459);
            this.grpError.TabIndex = 49;
            this.grpError.TabStop = false;
            this.grpError.Text = "Error";
            // 
            // lblFree3
            // 
            this.lblFree3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFree3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFree3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFree3.Location = new System.Drawing.Point(96, 431);
            this.lblFree3.Name = "lblFree3";
            this.lblFree3.Size = new System.Drawing.Size(250, 23);
            this.lblFree3.TabIndex = 59;
            this.lblFree3.Text = "Free of use";
            // 
            // lblFree2
            // 
            this.lblFree2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFree2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFree2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFree2.Location = new System.Drawing.Point(96, 408);
            this.lblFree2.Name = "lblFree2";
            this.lblFree2.Size = new System.Drawing.Size(250, 23);
            this.lblFree2.TabIndex = 58;
            this.lblFree2.Text = "Free of use";
            // 
            // lblFree1
            // 
            this.lblFree1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFree1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFree1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFree1.Location = new System.Drawing.Point(96, 385);
            this.lblFree1.Name = "lblFree1";
            this.lblFree1.Size = new System.Drawing.Size(250, 23);
            this.lblFree1.TabIndex = 57;
            this.lblFree1.Text = "Free of use";
            // 
            // lblStop
            // 
            this.lblStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblStop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStop.Location = new System.Drawing.Point(96, 362);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(250, 23);
            this.lblStop.TabIndex = 56;
            this.lblStop.Text = "Stop function block";
            // 
            // lblSetPos
            // 
            this.lblSetPos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSetPos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPos.Location = new System.Drawing.Point(96, 339);
            this.lblSetPos.Name = "lblSetPos";
            this.lblSetPos.Size = new System.Drawing.Size(250, 23);
            this.lblSetPos.TabIndex = 55;
            this.lblSetPos.Text = "Set Position function block";
            // 
            // lblMoveVel
            // 
            this.lblMoveVel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMoveVel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoveVel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveVel.Location = new System.Drawing.Point(96, 316);
            this.lblMoveVel.Name = "lblMoveVel";
            this.lblMoveVel.Size = new System.Drawing.Size(250, 23);
            this.lblMoveVel.TabIndex = 54;
            this.lblMoveVel.Text = "Move velocity function block";
            // 
            // lblJog
            // 
            this.lblJog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblJog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblJog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJog.Location = new System.Drawing.Point(96, 293);
            this.lblJog.Name = "lblJog";
            this.lblJog.Size = new System.Drawing.Size(250, 23);
            this.lblJog.TabIndex = 53;
            this.lblJog.Text = "Jog function block";
            // 
            // lblPower
            // 
            this.lblPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPower.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPower.Location = new System.Drawing.Point(96, 270);
            this.lblPower.Name = "lblPower";
            this.lblPower.Size = new System.Drawing.Size(250, 23);
            this.lblPower.TabIndex = 52;
            this.lblPower.Text = "Power function block";
            // 
            // lblPhasingRelative
            // 
            this.lblPhasingRelative.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblPhasingRelative.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPhasingRelative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhasingRelative.Location = new System.Drawing.Point(96, 247);
            this.lblPhasingRelative.Name = "lblPhasingRelative";
            this.lblPhasingRelative.Size = new System.Drawing.Size(250, 23);
            this.lblPhasingRelative.TabIndex = 51;
            this.lblPhasingRelative.Text = "Phasing relative function block";
            // 
            // lblGearOut
            // 
            this.lblGearOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblGearOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGearOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGearOut.Location = new System.Drawing.Point(96, 224);
            this.lblGearOut.Name = "lblGearOut";
            this.lblGearOut.Size = new System.Drawing.Size(250, 23);
            this.lblGearOut.TabIndex = 50;
            this.lblGearOut.Text = "Gear out function block";
            // 
            // lblGearIn
            // 
            this.lblGearIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblGearIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGearIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGearIn.Location = new System.Drawing.Point(96, 201);
            this.lblGearIn.Name = "lblGearIn";
            this.lblGearIn.Size = new System.Drawing.Size(250, 23);
            this.lblGearIn.TabIndex = 49;
            this.lblGearIn.Text = "Gear in function block";
            // 
            // lblMoveModulo
            // 
            this.lblMoveModulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblMoveModulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMoveModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveModulo.Location = new System.Drawing.Point(96, 178);
            this.lblMoveModulo.Name = "lblMoveModulo";
            this.lblMoveModulo.Size = new System.Drawing.Size(250, 23);
            this.lblMoveModulo.TabIndex = 48;
            this.lblMoveModulo.Text = "Move modulo function block";
            // 
            // lblResetSlaveAxis
            // 
            this.lblResetSlaveAxis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblResetSlaveAxis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResetSlaveAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetSlaveAxis.Location = new System.Drawing.Point(96, 155);
            this.lblResetSlaveAxis.Name = "lblResetSlaveAxis";
            this.lblResetSlaveAxis.Size = new System.Drawing.Size(250, 23);
            this.lblResetSlaveAxis.TabIndex = 47;
            this.lblResetSlaveAxis.Text = "Reset slave axis";
            // 
            // lblSlaveAxis
            // 
            this.lblSlaveAxis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSlaveAxis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSlaveAxis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlaveAxis.Location = new System.Drawing.Point(96, 132);
            this.lblSlaveAxis.Name = "lblSlaveAxis";
            this.lblSlaveAxis.Size = new System.Drawing.Size(250, 23);
            this.lblSlaveAxis.TabIndex = 46;
            this.lblSlaveAxis.Text = "Slave axis";
            // 
            // lblZeroMasterEncoder
            // 
            this.lblZeroMasterEncoder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblZeroMasterEncoder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblZeroMasterEncoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeroMasterEncoder.Location = new System.Drawing.Point(96, 109);
            this.lblZeroMasterEncoder.Name = "lblZeroMasterEncoder";
            this.lblZeroMasterEncoder.Size = new System.Drawing.Size(250, 23);
            this.lblZeroMasterEncoder.TabIndex = 45;
            this.lblZeroMasterEncoder.Text = "Zero master encoder";
            // 
            // lblResetMasterEnc
            // 
            this.lblResetMasterEnc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblResetMasterEnc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResetMasterEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResetMasterEnc.Location = new System.Drawing.Point(96, 86);
            this.lblResetMasterEnc.Name = "lblResetMasterEnc";
            this.lblResetMasterEnc.Size = new System.Drawing.Size(250, 23);
            this.lblResetMasterEnc.TabIndex = 11;
            this.lblResetMasterEnc.Text = "Reset master encoder";
            // 
            // lblError
            // 
            this.lblError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(6, 26);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(140, 23);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Error global: -----";
            // 
            // lblErrorDescr
            // 
            this.lblErrorDescr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrorDescr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrorDescr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorDescr.Location = new System.Drawing.Point(6, 56);
            this.lblErrorDescr.Name = "lblErrorDescr";
            this.lblErrorDescr.Size = new System.Drawing.Size(400, 23);
            this.lblErrorDescr.TabIndex = 12;
            this.lblErrorDescr.Text = "Error description: -----------------------------------------------------";
            // 
            // lblErrUdi15
            // 
            this.lblErrUdi15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi15.Location = new System.Drawing.Point(40, 431);
            this.lblErrUdi15.Name = "lblErrUdi15";
            this.lblErrUdi15.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi15.TabIndex = 44;
            this.lblErrUdi15.Text = "15000";
            this.lblErrUdi15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit0
            // 
            this.lblErrBit0.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit0.Location = new System.Drawing.Point(6, 86);
            this.lblErrBit0.Name = "lblErrBit0";
            this.lblErrBit0.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit0.TabIndex = 13;
            this.lblErrBit0.Text = "0";
            this.lblErrBit0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi14
            // 
            this.lblErrUdi14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi14.Location = new System.Drawing.Point(40, 408);
            this.lblErrUdi14.Name = "lblErrUdi14";
            this.lblErrUdi14.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi14.TabIndex = 43;
            this.lblErrUdi14.Text = "14000";
            this.lblErrUdi14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit1
            // 
            this.lblErrBit1.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit1.Location = new System.Drawing.Point(6, 109);
            this.lblErrBit1.Name = "lblErrBit1";
            this.lblErrBit1.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit1.TabIndex = 14;
            this.lblErrBit1.Text = "1";
            this.lblErrBit1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi13
            // 
            this.lblErrUdi13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi13.Location = new System.Drawing.Point(40, 385);
            this.lblErrUdi13.Name = "lblErrUdi13";
            this.lblErrUdi13.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi13.TabIndex = 42;
            this.lblErrUdi13.Text = "13000";
            this.lblErrUdi13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit2
            // 
            this.lblErrBit2.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit2.Location = new System.Drawing.Point(6, 132);
            this.lblErrBit2.Name = "lblErrBit2";
            this.lblErrBit2.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit2.TabIndex = 15;
            this.lblErrBit2.Text = "2";
            this.lblErrBit2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi12
            // 
            this.lblErrUdi12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi12.Location = new System.Drawing.Point(40, 362);
            this.lblErrUdi12.Name = "lblErrUdi12";
            this.lblErrUdi12.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi12.TabIndex = 41;
            this.lblErrUdi12.Text = "12000";
            this.lblErrUdi12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit3
            // 
            this.lblErrBit3.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit3.Location = new System.Drawing.Point(6, 155);
            this.lblErrBit3.Name = "lblErrBit3";
            this.lblErrBit3.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit3.TabIndex = 16;
            this.lblErrBit3.Text = "3";
            this.lblErrBit3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi11
            // 
            this.lblErrUdi11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi11.Location = new System.Drawing.Point(40, 339);
            this.lblErrUdi11.Name = "lblErrUdi11";
            this.lblErrUdi11.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi11.TabIndex = 40;
            this.lblErrUdi11.Text = "11000";
            this.lblErrUdi11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit4
            // 
            this.lblErrBit4.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit4.Location = new System.Drawing.Point(6, 178);
            this.lblErrBit4.Name = "lblErrBit4";
            this.lblErrBit4.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit4.TabIndex = 17;
            this.lblErrBit4.Text = "4";
            this.lblErrBit4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi10
            // 
            this.lblErrUdi10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi10.Location = new System.Drawing.Point(40, 316);
            this.lblErrUdi10.Name = "lblErrUdi10";
            this.lblErrUdi10.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi10.TabIndex = 39;
            this.lblErrUdi10.Text = "10000";
            this.lblErrUdi10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit5
            // 
            this.lblErrBit5.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit5.Location = new System.Drawing.Point(6, 201);
            this.lblErrBit5.Name = "lblErrBit5";
            this.lblErrBit5.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit5.TabIndex = 18;
            this.lblErrBit5.Text = "5";
            this.lblErrBit5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi9
            // 
            this.lblErrUdi9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi9.Location = new System.Drawing.Point(40, 293);
            this.lblErrUdi9.Name = "lblErrUdi9";
            this.lblErrUdi9.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi9.TabIndex = 38;
            this.lblErrUdi9.Text = "99999";
            this.lblErrUdi9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit6
            // 
            this.lblErrBit6.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit6.Location = new System.Drawing.Point(6, 224);
            this.lblErrBit6.Name = "lblErrBit6";
            this.lblErrBit6.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit6.TabIndex = 19;
            this.lblErrBit6.Text = "6";
            this.lblErrBit6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit15
            // 
            this.lblErrBit15.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit15.Location = new System.Drawing.Point(6, 431);
            this.lblErrBit15.Name = "lblErrBit15";
            this.lblErrBit15.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit15.TabIndex = 28;
            this.lblErrBit15.Text = "15";
            this.lblErrBit15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi8
            // 
            this.lblErrUdi8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi8.Location = new System.Drawing.Point(40, 270);
            this.lblErrUdi8.Name = "lblErrUdi8";
            this.lblErrUdi8.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi8.TabIndex = 37;
            this.lblErrUdi8.Text = "88888";
            this.lblErrUdi8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit14
            // 
            this.lblErrBit14.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit14.Location = new System.Drawing.Point(6, 408);
            this.lblErrBit14.Name = "lblErrBit14";
            this.lblErrBit14.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit14.TabIndex = 27;
            this.lblErrBit14.Text = "14";
            this.lblErrBit14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit7
            // 
            this.lblErrBit7.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit7.Location = new System.Drawing.Point(6, 247);
            this.lblErrBit7.Name = "lblErrBit7";
            this.lblErrBit7.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit7.TabIndex = 20;
            this.lblErrBit7.Text = "7";
            this.lblErrBit7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit13
            // 
            this.lblErrBit13.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit13.Location = new System.Drawing.Point(6, 385);
            this.lblErrBit13.Name = "lblErrBit13";
            this.lblErrBit13.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit13.TabIndex = 26;
            this.lblErrBit13.Text = "13";
            this.lblErrBit13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi7
            // 
            this.lblErrUdi7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi7.Location = new System.Drawing.Point(40, 247);
            this.lblErrUdi7.Name = "lblErrUdi7";
            this.lblErrUdi7.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi7.TabIndex = 36;
            this.lblErrUdi7.Text = "77777";
            this.lblErrUdi7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit12
            // 
            this.lblErrBit12.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit12.Location = new System.Drawing.Point(6, 362);
            this.lblErrBit12.Name = "lblErrBit12";
            this.lblErrBit12.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit12.TabIndex = 25;
            this.lblErrBit12.Text = "12";
            this.lblErrBit12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit8
            // 
            this.lblErrBit8.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit8.Location = new System.Drawing.Point(6, 270);
            this.lblErrBit8.Name = "lblErrBit8";
            this.lblErrBit8.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit8.TabIndex = 21;
            this.lblErrBit8.Text = "8";
            this.lblErrBit8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit11
            // 
            this.lblErrBit11.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit11.Location = new System.Drawing.Point(6, 339);
            this.lblErrBit11.Name = "lblErrBit11";
            this.lblErrBit11.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit11.TabIndex = 24;
            this.lblErrBit11.Text = "11";
            this.lblErrBit11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi6
            // 
            this.lblErrUdi6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi6.Location = new System.Drawing.Point(40, 224);
            this.lblErrUdi6.Name = "lblErrUdi6";
            this.lblErrUdi6.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi6.TabIndex = 35;
            this.lblErrUdi6.Text = "66666";
            this.lblErrUdi6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit10
            // 
            this.lblErrBit10.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit10.Location = new System.Drawing.Point(6, 316);
            this.lblErrBit10.Name = "lblErrBit10";
            this.lblErrBit10.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit10.TabIndex = 23;
            this.lblErrBit10.Text = "10";
            this.lblErrBit10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi0
            // 
            this.lblErrUdi0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi0.Location = new System.Drawing.Point(40, 86);
            this.lblErrUdi0.Name = "lblErrUdi0";
            this.lblErrUdi0.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi0.TabIndex = 29;
            this.lblErrUdi0.Text = "00000";
            this.lblErrUdi0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrBit9
            // 
            this.lblErrBit9.BackColor = System.Drawing.Color.LightGray;
            this.lblErrBit9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrBit9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrBit9.Location = new System.Drawing.Point(6, 293);
            this.lblErrBit9.Name = "lblErrBit9";
            this.lblErrBit9.Size = new System.Drawing.Size(30, 23);
            this.lblErrBit9.TabIndex = 22;
            this.lblErrBit9.Text = "9";
            this.lblErrBit9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi5
            // 
            this.lblErrUdi5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi5.Location = new System.Drawing.Point(40, 201);
            this.lblErrUdi5.Name = "lblErrUdi5";
            this.lblErrUdi5.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi5.TabIndex = 34;
            this.lblErrUdi5.Text = "55555";
            this.lblErrUdi5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi1
            // 
            this.lblErrUdi1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi1.Location = new System.Drawing.Point(40, 109);
            this.lblErrUdi1.Name = "lblErrUdi1";
            this.lblErrUdi1.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi1.TabIndex = 30;
            this.lblErrUdi1.Text = "11111";
            this.lblErrUdi1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi4
            // 
            this.lblErrUdi4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi4.Location = new System.Drawing.Point(40, 178);
            this.lblErrUdi4.Name = "lblErrUdi4";
            this.lblErrUdi4.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi4.TabIndex = 33;
            this.lblErrUdi4.Text = "44444";
            this.lblErrUdi4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi2
            // 
            this.lblErrUdi2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi2.Location = new System.Drawing.Point(40, 132);
            this.lblErrUdi2.Name = "lblErrUdi2";
            this.lblErrUdi2.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi2.TabIndex = 31;
            this.lblErrUdi2.Text = "22222";
            this.lblErrUdi2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrUdi3
            // 
            this.lblErrUdi3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblErrUdi3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrUdi3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrUdi3.Location = new System.Drawing.Point(40, 155);
            this.lblErrUdi3.Name = "lblErrUdi3";
            this.lblErrUdi3.Size = new System.Drawing.Size(50, 23);
            this.lblErrUdi3.TabIndex = 32;
            this.lblErrUdi3.Text = "33333";
            this.lblErrUdi3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.BackgroundImage")));
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(9, 28);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 67);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // checkThread
            // 
            this.checkThread.Interval = 250;
            this.checkThread.Tick += new System.EventHandler(this.checkThread_Tick);
            // 
            // prgBarGetInfo
            // 
            this.prgBarGetInfo.Location = new System.Drawing.Point(9, 122);
            this.prgBarGetInfo.Name = "prgBarGetInfo";
            this.prgBarGetInfo.Size = new System.Drawing.Size(158, 24);
            this.prgBarGetInfo.TabIndex = 51;
            // 
            // btnStopRefresh
            // 
            this.btnStopRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStopRefresh.BackgroundImage")));
            this.btnStopRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStopRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopRefresh.Location = new System.Drawing.Point(92, 28);
            this.btnStopRefresh.Name = "btnStopRefresh";
            this.btnStopRefresh.Size = new System.Drawing.Size(75, 67);
            this.btnStopRefresh.TabIndex = 52;
            this.btnStopRefresh.UseVisualStyleBackColor = true;
            this.btnStopRefresh.Click += new System.EventHandler(this.btnStopRefresh_Click);
            // 
            // lblInProgress
            // 
            this.lblInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProgress.Location = new System.Drawing.Point(9, 99);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(158, 21);
            this.lblInProgress.TabIndex = 57;
            this.lblInProgress.Text = "Ready to start";
            this.lblInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgConnWd
            // 
            this.prgConnWd.Location = new System.Drawing.Point(35, 135);
            this.prgConnWd.Name = "prgConnWd";
            this.prgConnWd.Size = new System.Drawing.Size(73, 18);
            this.prgConnWd.Step = 1;
            this.prgConnWd.TabIndex = 61;
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(34, 47);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 67);
            this.btnConnect.TabIndex = 55;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnStatus.Location = new System.Drawing.Point(21, 116);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(100, 13);
            this.lblConnStatus.TabIndex = 56;
            this.lblConnStatus.Text = "Not connected";
            this.lblConnStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1244, 25);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToToolStripMenuItem,
            this.openFromToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(39, 21);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToToolStripMenuItem
            // 
            this.saveToToolStripMenuItem.Name = "saveToToolStripMenuItem";
            this.saveToToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.saveToToolStripMenuItem.Text = "Save To...";
            this.saveToToolStripMenuItem.Click += new System.EventHandler(this.saveToToolStripMenuItem_Click);
            // 
            // openFromToolStripMenuItem
            // 
            this.openFromToolStripMenuItem.Name = "openFromToolStripMenuItem";
            this.openFromToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.openFromToolStripMenuItem.Text = "Open From...";
            this.openFromToolStripMenuItem.Click += new System.EventHandler(this.openFromToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(26, 21);
            this.toolStripMenuItem1.Text = "?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tWdTimer
            // 
            this.tWdTimer.Interval = 500;
            this.tWdTimer.Tick += new System.EventHandler(this.tWdTimer_Tick);
            // 
            // lblMainMenu
            // 
            this.lblMainMenu.AutoSize = true;
            this.lblMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainMenu.Location = new System.Drawing.Point(1162, 38);
            this.lblMainMenu.Name = "lblMainMenu";
            this.lblMainMenu.Size = new System.Drawing.Size(41, 16);
            this.lblMainMenu.TabIndex = 58;
            this.lblMainMenu.Text = "Main";
            // 
            // btnMain
            // 
            this.btnMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMain.BackgroundImage")));
            this.btnMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMain.Location = new System.Drawing.Point(1145, 57);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(75, 67);
            this.btnMain.TabIndex = 57;
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // lblConnect
            // 
            this.lblConnect.AutoSize = true;
            this.lblConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnect.Location = new System.Drawing.Point(39, 28);
            this.lblConnect.Name = "lblConnect";
            this.lblConnect.Size = new System.Drawing.Size(64, 16);
            this.lblConnect.TabIndex = 62;
            this.lblConnect.Text = "Connect";
            // 
            // lblUpload
            // 
            this.lblUpload.AutoSize = true;
            this.lblUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpload.Location = new System.Drawing.Point(15, 9);
            this.lblUpload.Name = "lblUpload";
            this.lblUpload.Size = new System.Drawing.Size(63, 16);
            this.lblUpload.TabIndex = 63;
            this.lblUpload.Text = "UpLoad";
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.Location = new System.Drawing.Point(101, 9);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(56, 16);
            this.lblCancel.TabIndex = 64;
            this.lblCancel.Text = "Cancel";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSaveToFile.BackgroundImage")));
            this.btnSaveToFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveToFile.Location = new System.Drawing.Point(217, 28);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(75, 67);
            this.btnSaveToFile.TabIndex = 65;
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.btnSaveToFile_Click);
            // 
            // lblSaveToFile
            // 
            this.lblSaveToFile.AutoSize = true;
            this.lblSaveToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaveToFile.Location = new System.Drawing.Point(215, 9);
            this.lblSaveToFile.Name = "lblSaveToFile";
            this.lblSaveToFile.Size = new System.Drawing.Size(79, 16);
            this.lblSaveToFile.TabIndex = 66;
            this.lblSaveToFile.Text = "Save To...";
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.BackgroundImage")));
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpenFile.Location = new System.Drawing.Point(302, 28);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 67);
            this.btnOpenFile.TabIndex = 67;
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblOpenFile
            // 
            this.lblOpenFile.AutoSize = true;
            this.lblOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOpenFile.Location = new System.Drawing.Point(300, 9);
            this.lblOpenFile.Name = "lblOpenFile";
            this.lblOpenFile.Size = new System.Drawing.Size(70, 16);
            this.lblOpenFile.TabIndex = 68;
            this.lblOpenFile.Text = "Open file";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCpuData);
            this.tabControl1.Controls.Add(this.tabEncoderData);
            this.tabControl1.Controls.Add(this.tabLogger);
            this.tabControl1.Location = new System.Drawing.Point(4, 158);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1237, 883);
            this.tabControl1.TabIndex = 69;
            // 
            // tabCpuData
            // 
            this.tabCpuData.BackColor = System.Drawing.Color.Gainsboro;
            this.tabCpuData.Controls.Add(this.grpUserManagement);
            this.tabCpuData.Controls.Add(this.grpUPS);
            this.tabCpuData.Controls.Add(this.grpTwinCAT);
            this.tabCpuData.Controls.Add(this.grpOperatingSystem);
            this.tabCpuData.Controls.Add(this.grpNetworkinterface2);
            this.tabCpuData.Controls.Add(this.grpNetworkinterface1);
            this.tabCpuData.Controls.Add(this.grpDiskMnagement);
            this.tabCpuData.Controls.Add(this.grpMemory);
            this.tabCpuData.Controls.Add(this.grpHardwareData);
            this.tabCpuData.Controls.Add(this.grpOperationData);
            this.tabCpuData.Controls.Add(this.grpIdentityCard);
            this.tabCpuData.Location = new System.Drawing.Point(4, 22);
            this.tabCpuData.Name = "tabCpuData";
            this.tabCpuData.Padding = new System.Windows.Forms.Padding(3);
            this.tabCpuData.Size = new System.Drawing.Size(1229, 857);
            this.tabCpuData.TabIndex = 0;
            this.tabCpuData.Text = "CpuData";
            this.tabCpuData.Click += new System.EventHandler(this.tabCpuData_Click);
            // 
            // grpUserManagement
            // 
            this.grpUserManagement.BackColor = System.Drawing.Color.DarkGray;
            this.grpUserManagement.Controls.Add(this.lblCPUValue56);
            this.grpUserManagement.Controls.Add(this.lblCPUParameter56);
            this.grpUserManagement.Location = new System.Drawing.Point(608, 387);
            this.grpUserManagement.Name = "grpUserManagement";
            this.grpUserManagement.Size = new System.Drawing.Size(274, 61);
            this.grpUserManagement.TabIndex = 21;
            this.grpUserManagement.TabStop = false;
            this.grpUserManagement.Text = "UserManagement";
            // 
            // lblCPUValue56
            // 
            this.lblCPUValue56.AutoSize = true;
            this.lblCPUValue56.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue56.Location = new System.Drawing.Point(138, 30);
            this.lblCPUValue56.Name = "lblCPUValue56";
            this.lblCPUValue56.Size = new System.Drawing.Size(67, 13);
            this.lblCPUValue56.TabIndex = 1;
            this.lblCPUValue56.Text = "Administrator";
            // 
            // lblCPUParameter56
            // 
            this.lblCPUParameter56.AutoSize = true;
            this.lblCPUParameter56.Location = new System.Drawing.Point(73, 30);
            this.lblCPUParameter56.Name = "lblCPUParameter56";
            this.lblCPUParameter56.Size = new System.Drawing.Size(61, 13);
            this.lblCPUParameter56.TabIndex = 0;
            this.lblCPUParameter56.Text = "User name:";
            // 
            // grpUPS
            // 
            this.grpUPS.BackColor = System.Drawing.Color.DarkGray;
            this.grpUPS.Controls.Add(this.lblCPUValue55);
            this.grpUPS.Controls.Add(this.lblCPUValue54);
            this.grpUPS.Controls.Add(this.lblCPUValue53);
            this.grpUPS.Controls.Add(this.lblCPUValue52);
            this.grpUPS.Controls.Add(this.lbCPUlValue51);
            this.grpUPS.Controls.Add(this.lblCPUValue50);
            this.grpUPS.Controls.Add(this.lblCPUValue49);
            this.grpUPS.Controls.Add(this.lblCPUValue48);
            this.grpUPS.Controls.Add(this.lblCPUValue47);
            this.grpUPS.Controls.Add(this.lblCPUValue46);
            this.grpUPS.Controls.Add(this.lblCPUParameter55);
            this.grpUPS.Controls.Add(this.lblCPUParameter54);
            this.grpUPS.Controls.Add(this.lblCPUParameter53);
            this.grpUPS.Controls.Add(this.lblCPUParameter52);
            this.grpUPS.Controls.Add(this.lblCPUParameter51);
            this.grpUPS.Controls.Add(this.lblCPUParameter50);
            this.grpUPS.Controls.Add(this.lblCPUParameter49);
            this.grpUPS.Controls.Add(this.lblCPUParameter48);
            this.grpUPS.Controls.Add(this.lblCPUParameter47);
            this.grpUPS.Controls.Add(this.lblCPUParameter46);
            this.grpUPS.Location = new System.Drawing.Point(898, 170);
            this.grpUPS.Name = "grpUPS";
            this.grpUPS.Size = new System.Drawing.Size(274, 255);
            this.grpUPS.TabIndex = 20;
            this.grpUPS.TabStop = false;
            this.grpUPS.Text = "UPS";
            // 
            // lblCPUValue55
            // 
            this.lblCPUValue55.AutoSize = true;
            this.lblCPUValue55.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue55.Location = new System.Drawing.Point(166, 236);
            this.lblCPUValue55.Name = "lblCPUValue55";
            this.lblCPUValue55.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue55.TabIndex = 19;
            this.lblCPUValue55.Text = "6";
            // 
            // lblCPUValue54
            // 
            this.lblCPUValue54.AutoSize = true;
            this.lblCPUValue54.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue54.Location = new System.Drawing.Point(166, 212);
            this.lblCPUValue54.Name = "lblCPUValue54";
            this.lblCPUValue54.Size = new System.Drawing.Size(37, 13);
            this.lblCPUValue54.TabIndex = 18;
            this.lblCPUValue54.Text = "TRUE";
            // 
            // lblCPUValue53
            // 
            this.lblCPUValue53.AutoSize = true;
            this.lblCPUValue53.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue53.Location = new System.Drawing.Point(166, 188);
            this.lblCPUValue53.Name = "lblCPUValue53";
            this.lblCPUValue53.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue53.TabIndex = 17;
            this.lblCPUValue53.Text = "0";
            // 
            // lblCPUValue52
            // 
            this.lblCPUValue52.AutoSize = true;
            this.lblCPUValue52.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue52.Location = new System.Drawing.Point(166, 164);
            this.lblCPUValue52.Name = "lblCPUValue52";
            this.lblCPUValue52.Size = new System.Drawing.Size(25, 13);
            this.lblCPUValue52.TabIndex = 16;
            this.lblCPUValue52.Text = "100";
            // 
            // lbCPUlValue51
            // 
            this.lbCPUlValue51.AutoSize = true;
            this.lbCPUlValue51.BackColor = System.Drawing.Color.Gainsboro;
            this.lbCPUlValue51.Location = new System.Drawing.Point(166, 140);
            this.lbCPUlValue51.Name = "lbCPUlValue51";
            this.lbCPUlValue51.Size = new System.Drawing.Size(13, 13);
            this.lbCPUlValue51.TabIndex = 15;
            this.lbCPUlValue51.Text = "1";
            // 
            // lblCPUValue50
            // 
            this.lblCPUValue50.AutoSize = true;
            this.lblCPUValue50.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue50.Location = new System.Drawing.Point(166, 116);
            this.lblCPUValue50.Name = "lblCPUValue50";
            this.lblCPUValue50.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue50.TabIndex = 14;
            this.lblCPUValue50.Text = "0";
            // 
            // lblCPUValue49
            // 
            this.lblCPUValue49.AutoSize = true;
            this.lblCPUValue49.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue49.Location = new System.Drawing.Point(166, 92);
            this.lblCPUValue49.Name = "lblCPUValue49";
            this.lblCPUValue49.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue49.TabIndex = 13;
            this.lblCPUValue49.Text = "9";
            // 
            // lblCPUValue48
            // 
            this.lblCPUValue48.AutoSize = true;
            this.lblCPUValue48.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue48.Location = new System.Drawing.Point(166, 68);
            this.lblCPUValue48.Name = "lblCPUValue48";
            this.lblCPUValue48.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue48.TabIndex = 12;
            this.lblCPUValue48.Text = "1";
            // 
            // lblCPUValue47
            // 
            this.lblCPUValue47.AutoSize = true;
            this.lblCPUValue47.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue47.Location = new System.Drawing.Point(166, 44);
            this.lblCPUValue47.Name = "lblCPUValue47";
            this.lblCPUValue47.Size = new System.Drawing.Size(50, 13);
            this.lblCPUValue47.TabIndex = 11;
            this.lblCPUValue47.Text = "Beckhoff";
            // 
            // lblCPUValue46
            // 
            this.lblCPUValue46.AutoSize = true;
            this.lblCPUValue46.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue46.Location = new System.Drawing.Point(166, 20);
            this.lblCPUValue46.Name = "lblCPUValue46";
            this.lblCPUValue46.Size = new System.Drawing.Size(39, 13);
            this.lblCPUValue46.TabIndex = 10;
            this.lblCPUValue46.Text = "S-UPS";
            // 
            // lblCPUParameter55
            // 
            this.lblCPUParameter55.AutoSize = true;
            this.lblCPUParameter55.Location = new System.Drawing.Point(60, 236);
            this.lblCPUParameter55.Name = "lblCPUParameter55";
            this.lblCPUParameter55.Size = new System.Drawing.Size(86, 13);
            this.lblCPUParameter55.TabIndex = 9;
            this.lblCPUParameter55.Text = "Power fail count:";
            // 
            // lblCPUParameter54
            // 
            this.lblCPUParameter54.AutoSize = true;
            this.lblCPUParameter54.Location = new System.Drawing.Point(3, 212);
            this.lblCPUParameter54.Name = "lblCPUParameter54";
            this.lblCPUParameter54.Size = new System.Drawing.Size(143, 13);
            this.lblCPUParameter54.TabIndex = 8;
            this.lblCPUParameter54.Text = "Persistant power fail counter:";
            // 
            // lblCPUParameter53
            // 
            this.lblCPUParameter53.AutoSize = true;
            this.lblCPUParameter53.Location = new System.Drawing.Point(66, 188);
            this.lblCPUParameter53.Name = "lblCPUParameter53";
            this.lblCPUParameter53.Size = new System.Drawing.Size(80, 13);
            this.lblCPUParameter53.TabIndex = 7;
            this.lblCPUParameter53.Text = "Battery runtime:";
            // 
            // lblCPUParameter52
            // 
            this.lblCPUParameter52.AutoSize = true;
            this.lblCPUParameter52.Location = new System.Drawing.Point(60, 164);
            this.lblCPUParameter52.Name = "lblCPUParameter52";
            this.lblCPUParameter52.Size = new System.Drawing.Size(86, 13);
            this.lblCPUParameter52.TabIndex = 6;
            this.lblCPUParameter52.Text = "Battery capacity:";
            // 
            // lblCPUParameter51
            // 
            this.lblCPUParameter51.AutoSize = true;
            this.lblCPUParameter51.Location = new System.Drawing.Point(75, 140);
            this.lblCPUParameter51.Name = "lblCPUParameter51";
            this.lblCPUParameter51.Size = new System.Drawing.Size(71, 13);
            this.lblCPUParameter51.TabIndex = 5;
            this.lblCPUParameter51.Text = "Power status:";
            // 
            // lblCPUParameter50
            // 
            this.lblCPUParameter50.AutoSize = true;
            this.lblCPUParameter50.Location = new System.Drawing.Point(113, 116);
            this.lblCPUParameter50.Name = "lblCPUParameter50";
            this.lblCPUParameter50.Size = new System.Drawing.Size(33, 13);
            this.lblCPUParameter50.TabIndex = 4;
            this.lblCPUParameter50.Text = "Build:";
            // 
            // lblCPUParameter49
            // 
            this.lblCPUParameter49.AutoSize = true;
            this.lblCPUParameter49.Location = new System.Drawing.Point(95, 92);
            this.lblCPUParameter49.Name = "lblCPUParameter49";
            this.lblCPUParameter49.Size = new System.Drawing.Size(51, 13);
            this.lblCPUParameter49.TabIndex = 3;
            this.lblCPUParameter49.Text = "Revision:";
            // 
            // lblCPUParameter48
            // 
            this.lblCPUParameter48.AutoSize = true;
            this.lblCPUParameter48.Location = new System.Drawing.Point(101, 68);
            this.lblCPUParameter48.Name = "lblCPUParameter48";
            this.lblCPUParameter48.Size = new System.Drawing.Size(45, 13);
            this.lblCPUParameter48.TabIndex = 2;
            this.lblCPUParameter48.Text = "Version:";
            // 
            // lblCPUParameter47
            // 
            this.lblCPUParameter47.AutoSize = true;
            this.lblCPUParameter47.Location = new System.Drawing.Point(73, 44);
            this.lblCPUParameter47.Name = "lblCPUParameter47";
            this.lblCPUParameter47.Size = new System.Drawing.Size(73, 13);
            this.lblCPUParameter47.TabIndex = 1;
            this.lblCPUParameter47.Text = "Vendor name:";
            // 
            // lblCPUParameter46
            // 
            this.lblCPUParameter46.AutoSize = true;
            this.lblCPUParameter46.Location = new System.Drawing.Point(107, 20);
            this.lblCPUParameter46.Name = "lblCPUParameter46";
            this.lblCPUParameter46.Size = new System.Drawing.Size(39, 13);
            this.lblCPUParameter46.TabIndex = 0;
            this.lblCPUParameter46.Text = "Model:";
            // 
            // grpTwinCAT
            // 
            this.grpTwinCAT.BackColor = System.Drawing.Color.DarkGray;
            this.grpTwinCAT.Controls.Add(this.lblCPUValue45);
            this.grpTwinCAT.Controls.Add(this.lblCPUValue44);
            this.grpTwinCAT.Controls.Add(this.lblCPUValue43);
            this.grpTwinCAT.Controls.Add(this.lblCPUValue42);
            this.grpTwinCAT.Controls.Add(this.lblCPUValue41);
            this.grpTwinCAT.Controls.Add(this.lblCPUValue40);
            this.grpTwinCAT.Controls.Add(this.lblCPUValue39);
            this.grpTwinCAT.Controls.Add(this.lblCPUParameter45);
            this.grpTwinCAT.Controls.Add(this.lblCPUParameter44);
            this.grpTwinCAT.Controls.Add(this.lblCPUParameter43);
            this.grpTwinCAT.Controls.Add(this.lblCPUParameter42);
            this.grpTwinCAT.Controls.Add(this.lblCPUParameter41);
            this.grpTwinCAT.Controls.Add(this.lblCPUParameter40);
            this.grpTwinCAT.Controls.Add(this.lblCPUParameter39);
            this.grpTwinCAT.Location = new System.Drawing.Point(8, 478);
            this.grpTwinCAT.Name = "grpTwinCAT";
            this.grpTwinCAT.Size = new System.Drawing.Size(362, 223);
            this.grpTwinCAT.TabIndex = 19;
            this.grpTwinCAT.TabStop = false;
            this.grpTwinCAT.Text = "TwinCAT";
            // 
            // lblCPUValue45
            // 
            this.lblCPUValue45.AutoSize = true;
            this.lblCPUValue45.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue45.Location = new System.Drawing.Point(138, 201);
            this.lblCPUValue45.Name = "lblCPUValue45";
            this.lblCPUValue45.Size = new System.Drawing.Size(88, 13);
            this.lblCPUValue45.TabIndex = 13;
            this.lblCPUValue45.Text = "5.121.160.60.1.1";
            // 
            // lblCPUValue44
            // 
            this.lblCPUValue44.AutoSize = true;
            this.lblCPUValue44.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue44.Location = new System.Drawing.Point(138, 175);
            this.lblCPUValue44.Name = "lblCPUValue44";
            this.lblCPUValue44.Size = new System.Drawing.Size(216, 13);
            this.lblCPUValue44.TabIndex = 12;
            this.lblCPUValue44.Text = "A4CA5C2Ca-ea9f-47cc-a19c-38a77598bfa4";
            // 
            // lblCPUValue43
            // 
            this.lblCPUValue43.AutoSize = true;
            this.lblCPUValue43.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue43.Location = new System.Drawing.Point(138, 145);
            this.lblCPUValue43.Name = "lblCPUValue43";
            this.lblCPUValue43.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue43.TabIndex = 11;
            this.lblCPUValue43.Text = "5";
            // 
            // lblCPUValue42
            // 
            this.lblCPUValue42.AutoSize = true;
            this.lblCPUValue42.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue42.Location = new System.Drawing.Point(138, 115);
            this.lblCPUValue42.Name = "lblCPUValue42";
            this.lblCPUValue42.Size = new System.Drawing.Size(19, 13);
            this.lblCPUValue42.TabIndex = 10;
            this.lblCPUValue42.Text = "35";
            // 
            // lblCPUValue41
            // 
            this.lblCPUValue41.AutoSize = true;
            this.lblCPUValue41.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue41.Location = new System.Drawing.Point(138, 85);
            this.lblCPUValue41.Name = "lblCPUValue41";
            this.lblCPUValue41.Size = new System.Drawing.Size(31, 13);
            this.lblCPUValue41.TabIndex = 9;
            this.lblCPUValue41.Text = "4024";
            // 
            // lblCPUValue40
            // 
            this.lblCPUValue40.AutoSize = true;
            this.lblCPUValue40.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue40.Location = new System.Drawing.Point(138, 55);
            this.lblCPUValue40.Name = "lblCPUValue40";
            this.lblCPUValue40.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue40.TabIndex = 8;
            this.lblCPUValue40.Text = "1";
            // 
            // lblCPUValue39
            // 
            this.lblCPUValue39.AutoSize = true;
            this.lblCPUValue39.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue39.Location = new System.Drawing.Point(138, 25);
            this.lblCPUValue39.Name = "lblCPUValue39";
            this.lblCPUValue39.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue39.TabIndex = 7;
            this.lblCPUValue39.Text = "3";
            // 
            // lblCPUParameter45
            // 
            this.lblCPUParameter45.AutoSize = true;
            this.lblCPUParameter45.Location = new System.Drawing.Point(64, 201);
            this.lblCPUParameter45.Name = "lblCPUParameter45";
            this.lblCPUParameter45.Size = new System.Drawing.Size(56, 13);
            this.lblCPUParameter45.TabIndex = 6;
            this.lblCPUParameter45.Text = "AmsNetId:";
            // 
            // lblCPUParameter44
            // 
            this.lblCPUParameter44.AutoSize = true;
            this.lblCPUParameter44.Location = new System.Drawing.Point(62, 175);
            this.lblCPUParameter44.Name = "lblCPUParameter44";
            this.lblCPUParameter44.Size = new System.Drawing.Size(58, 13);
            this.lblCPUParameter44.TabIndex = 5;
            this.lblCPUParameter44.Text = "System ID:";
            // 
            // lblCPUParameter43
            // 
            this.lblCPUParameter43.AutoSize = true;
            this.lblCPUParameter43.Location = new System.Drawing.Point(50, 145);
            this.lblCPUParameter43.Name = "lblCPUParameter43";
            this.lblCPUParameter43.Size = new System.Drawing.Size(70, 13);
            this.lblCPUParameter43.TabIndex = 4;
            this.lblCPUParameter43.Text = "System state:";
            // 
            // lblCPUParameter42
            // 
            this.lblCPUParameter42.AutoSize = true;
            this.lblCPUParameter42.Location = new System.Drawing.Point(69, 115);
            this.lblCPUParameter42.Name = "lblCPUParameter42";
            this.lblCPUParameter42.Size = new System.Drawing.Size(51, 13);
            this.lblCPUParameter42.TabIndex = 3;
            this.lblCPUParameter42.Text = "Revision:";
            // 
            // lblCPUParameter41
            // 
            this.lblCPUParameter41.AutoSize = true;
            this.lblCPUParameter41.Location = new System.Drawing.Point(87, 85);
            this.lblCPUParameter41.Name = "lblCPUParameter41";
            this.lblCPUParameter41.Size = new System.Drawing.Size(33, 13);
            this.lblCPUParameter41.TabIndex = 2;
            this.lblCPUParameter41.Text = "Build:";
            // 
            // lblCPUParameter40
            // 
            this.lblCPUParameter40.AutoSize = true;
            this.lblCPUParameter40.Location = new System.Drawing.Point(47, 55);
            this.lblCPUParameter40.Name = "lblCPUParameter40";
            this.lblCPUParameter40.Size = new System.Drawing.Size(73, 13);
            this.lblCPUParameter40.TabIndex = 1;
            this.lblCPUParameter40.Text = "Minor version:";
            // 
            // lblCPUParameter39
            // 
            this.lblCPUParameter39.AutoSize = true;
            this.lblCPUParameter39.Location = new System.Drawing.Point(47, 25);
            this.lblCPUParameter39.Name = "lblCPUParameter39";
            this.lblCPUParameter39.Size = new System.Drawing.Size(73, 13);
            this.lblCPUParameter39.TabIndex = 0;
            this.lblCPUParameter39.Text = "Major version:";
            // 
            // grpOperatingSystem
            // 
            this.grpOperatingSystem.BackColor = System.Drawing.Color.DarkGray;
            this.grpOperatingSystem.Controls.Add(this.lblCPUValue38);
            this.grpOperatingSystem.Controls.Add(this.lblCPUValue37);
            this.grpOperatingSystem.Controls.Add(this.lblCPUValue36);
            this.grpOperatingSystem.Controls.Add(this.lblCPUParameter38);
            this.grpOperatingSystem.Controls.Add(this.lblCPUParameter37);
            this.grpOperatingSystem.Controls.Add(this.lblCPUParameter36);
            this.grpOperatingSystem.Location = new System.Drawing.Point(898, 56);
            this.grpOperatingSystem.Name = "grpOperatingSystem";
            this.grpOperatingSystem.Size = new System.Drawing.Size(274, 96);
            this.grpOperatingSystem.TabIndex = 18;
            this.grpOperatingSystem.TabStop = false;
            this.grpOperatingSystem.Text = "Operating system";
            // 
            // lblCPUValue38
            // 
            this.lblCPUValue38.AutoSize = true;
            this.lblCPUValue38.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue38.Location = new System.Drawing.Point(166, 68);
            this.lblCPUValue38.Name = "lblCPUValue38";
            this.lblCPUValue38.Size = new System.Drawing.Size(31, 13);
            this.lblCPUValue38.TabIndex = 6;
            this.lblCPUValue38.Text = "2882";
            // 
            // lblCPUValue37
            // 
            this.lblCPUValue37.AutoSize = true;
            this.lblCPUValue37.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue37.Location = new System.Drawing.Point(166, 44);
            this.lblCPUValue37.Name = "lblCPUValue37";
            this.lblCPUValue37.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue37.TabIndex = 5;
            this.lblCPUValue37.Text = "0";
            // 
            // lblCPUValue36
            // 
            this.lblCPUValue36.AutoSize = true;
            this.lblCPUValue36.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue36.Location = new System.Drawing.Point(166, 20);
            this.lblCPUValue36.Name = "lblCPUValue36";
            this.lblCPUValue36.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue36.TabIndex = 4;
            this.lblCPUValue36.Text = "7";
            // 
            // lblCPUParameter38
            // 
            this.lblCPUParameter38.AutoSize = true;
            this.lblCPUParameter38.Location = new System.Drawing.Point(113, 68);
            this.lblCPUParameter38.Name = "lblCPUParameter38";
            this.lblCPUParameter38.Size = new System.Drawing.Size(33, 13);
            this.lblCPUParameter38.TabIndex = 2;
            this.lblCPUParameter38.Text = "Build:";
            // 
            // lblCPUParameter37
            // 
            this.lblCPUParameter37.AutoSize = true;
            this.lblCPUParameter37.Location = new System.Drawing.Point(73, 44);
            this.lblCPUParameter37.Name = "lblCPUParameter37";
            this.lblCPUParameter37.Size = new System.Drawing.Size(73, 13);
            this.lblCPUParameter37.TabIndex = 1;
            this.lblCPUParameter37.Text = "Minor version:";
            // 
            // lblCPUParameter36
            // 
            this.lblCPUParameter36.AutoSize = true;
            this.lblCPUParameter36.Location = new System.Drawing.Point(73, 20);
            this.lblCPUParameter36.Name = "lblCPUParameter36";
            this.lblCPUParameter36.Size = new System.Drawing.Size(73, 13);
            this.lblCPUParameter36.TabIndex = 0;
            this.lblCPUParameter36.Text = "Major version:";
            // 
            // grpNetworkinterface2
            // 
            this.grpNetworkinterface2.BackColor = System.Drawing.Color.DarkGray;
            this.grpNetworkinterface2.Controls.Add(this.lblCPUValue35);
            this.grpNetworkinterface2.Controls.Add(this.lblCPUValue34);
            this.grpNetworkinterface2.Controls.Add(this.lblCPUValue32);
            this.grpNetworkinterface2.Controls.Add(this.lblCPUValue33);
            this.grpNetworkinterface2.Controls.Add(this.lblCPUParameter35);
            this.grpNetworkinterface2.Controls.Add(this.lblCPUParameter34);
            this.grpNetworkinterface2.Controls.Add(this.lblCPUParameter33);
            this.grpNetworkinterface2.Controls.Add(this.lblCPUParameter32);
            this.grpNetworkinterface2.Location = new System.Drawing.Point(313, 327);
            this.grpNetworkinterface2.Name = "grpNetworkinterface2";
            this.grpNetworkinterface2.Size = new System.Drawing.Size(274, 138);
            this.grpNetworkinterface2.TabIndex = 17;
            this.grpNetworkinterface2.TabStop = false;
            this.grpNetworkinterface2.Text = "Network interface 2";
            // 
            // lblCPUValue35
            // 
            this.lblCPUValue35.AutoSize = true;
            this.lblCPUValue35.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue35.Location = new System.Drawing.Point(166, 116);
            this.lblCPUValue35.Name = "lblCPUValue35";
            this.lblCPUValue35.Size = new System.Drawing.Size(94, 13);
            this.lblCPUValue35.TabIndex = 7;
            this.lblCPUValue35.Text = "00 01 05 79 a0 3e";
            // 
            // lblCPUValue34
            // 
            this.lblCPUValue34.AutoSize = true;
            this.lblCPUValue34.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue34.Location = new System.Drawing.Point(166, 86);
            this.lblCPUValue34.Name = "lblCPUValue34";
            this.lblCPUValue34.Size = new System.Drawing.Size(40, 13);
            this.lblCPUValue34.TabIndex = 6;
            this.lblCPUValue34.Text = "0.0.0.0";
            // 
            // lblCPUValue32
            // 
            this.lblCPUValue32.AutoSize = true;
            this.lblCPUValue32.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue32.Location = new System.Drawing.Point(166, 29);
            this.lblCPUValue32.Name = "lblCPUValue32";
            this.lblCPUValue32.Size = new System.Drawing.Size(40, 13);
            this.lblCPUValue32.TabIndex = 5;
            this.lblCPUValue32.Text = "0.0.0.0";
            // 
            // lblCPUValue33
            // 
            this.lblCPUValue33.AutoSize = true;
            this.lblCPUValue33.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue33.Location = new System.Drawing.Point(166, 60);
            this.lblCPUValue33.Name = "lblCPUValue33";
            this.lblCPUValue33.Size = new System.Drawing.Size(40, 13);
            this.lblCPUValue33.TabIndex = 4;
            this.lblCPUValue33.Text = "0.0.0.0";
            // 
            // lblCPUParameter35
            // 
            this.lblCPUParameter35.AutoSize = true;
            this.lblCPUParameter35.Location = new System.Drawing.Point(105, 116);
            this.lblCPUParameter35.Name = "lblCPUParameter35";
            this.lblCPUParameter35.Size = new System.Drawing.Size(45, 13);
            this.lblCPUParameter35.TabIndex = 3;
            this.lblCPUParameter35.Text = "MAC Id:";
            // 
            // lblCPUParameter34
            // 
            this.lblCPUParameter34.AutoSize = true;
            this.lblCPUParameter34.Location = new System.Drawing.Point(60, 86);
            this.lblCPUParameter34.Name = "lblCPUParameter34";
            this.lblCPUParameter34.Size = new System.Drawing.Size(87, 13);
            this.lblCPUParameter34.TabIndex = 2;
            this.lblCPUParameter34.Text = "Default gateway:";
            // 
            // lblCPUParameter33
            // 
            this.lblCPUParameter33.AutoSize = true;
            this.lblCPUParameter33.Location = new System.Drawing.Point(99, 60);
            this.lblCPUParameter33.Name = "lblCPUParameter33";
            this.lblCPUParameter33.Size = new System.Drawing.Size(48, 13);
            this.lblCPUParameter33.TabIndex = 1;
            this.lblCPUParameter33.Text = "IP mask:";
            // 
            // lblCPUParameter32
            // 
            this.lblCPUParameter32.AutoSize = true;
            this.lblCPUParameter32.Location = new System.Drawing.Point(87, 29);
            this.lblCPUParameter32.Name = "lblCPUParameter32";
            this.lblCPUParameter32.Size = new System.Drawing.Size(60, 13);
            this.lblCPUParameter32.TabIndex = 0;
            this.lblCPUParameter32.Text = "IP address:";
            // 
            // grpNetworkinterface1
            // 
            this.grpNetworkinterface1.BackColor = System.Drawing.Color.DarkGray;
            this.grpNetworkinterface1.Controls.Add(this.lblCPUValue31);
            this.grpNetworkinterface1.Controls.Add(this.lbCPUlValue30);
            this.grpNetworkinterface1.Controls.Add(this.lblCPUValue29);
            this.grpNetworkinterface1.Controls.Add(this.lblCPUValue28);
            this.grpNetworkinterface1.Controls.Add(this.lblCPUParameter31);
            this.grpNetworkinterface1.Controls.Add(this.lblCPUParameter30);
            this.grpNetworkinterface1.Controls.Add(this.lblCPUParameter29);
            this.grpNetworkinterface1.Controls.Add(this.lblCPUParameter28);
            this.grpNetworkinterface1.Location = new System.Drawing.Point(8, 328);
            this.grpNetworkinterface1.Name = "grpNetworkinterface1";
            this.grpNetworkinterface1.Size = new System.Drawing.Size(274, 138);
            this.grpNetworkinterface1.TabIndex = 16;
            this.grpNetworkinterface1.TabStop = false;
            this.grpNetworkinterface1.Text = "Network interface 1";
            // 
            // lblCPUValue31
            // 
            this.lblCPUValue31.AutoSize = true;
            this.lblCPUValue31.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue31.Location = new System.Drawing.Point(138, 116);
            this.lblCPUValue31.Name = "lblCPUValue31";
            this.lblCPUValue31.Size = new System.Drawing.Size(94, 13);
            this.lblCPUValue31.TabIndex = 7;
            this.lblCPUValue31.Text = "00 01 05 79 a0 3d";
            // 
            // lbCPUlValue30
            // 
            this.lbCPUlValue30.AutoSize = true;
            this.lbCPUlValue30.BackColor = System.Drawing.Color.Gainsboro;
            this.lbCPUlValue30.Location = new System.Drawing.Point(138, 86);
            this.lbCPUlValue30.Name = "lbCPUlValue30";
            this.lbCPUlValue30.Size = new System.Drawing.Size(76, 13);
            this.lbCPUlValue30.TabIndex = 6;
            this.lbCPUlValue30.Text = "192.168.193.1";
            // 
            // lblCPUValue29
            // 
            this.lblCPUValue29.AutoSize = true;
            this.lblCPUValue29.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue29.Location = new System.Drawing.Point(138, 60);
            this.lblCPUValue29.Name = "lblCPUValue29";
            this.lblCPUValue29.Size = new System.Drawing.Size(76, 13);
            this.lblCPUValue29.TabIndex = 5;
            this.lblCPUValue29.Text = "255.255.255.0";
            // 
            // lblCPUValue28
            // 
            this.lblCPUValue28.AutoSize = true;
            this.lblCPUValue28.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue28.Location = new System.Drawing.Point(138, 29);
            this.lblCPUValue28.Name = "lblCPUValue28";
            this.lblCPUValue28.Size = new System.Drawing.Size(88, 13);
            this.lblCPUValue28.TabIndex = 4;
            this.lblCPUValue28.Text = "192.168.193.200";
            // 
            // lblCPUParameter31
            // 
            this.lblCPUParameter31.AutoSize = true;
            this.lblCPUParameter31.Location = new System.Drawing.Point(75, 116);
            this.lblCPUParameter31.Name = "lblCPUParameter31";
            this.lblCPUParameter31.Size = new System.Drawing.Size(45, 13);
            this.lblCPUParameter31.TabIndex = 3;
            this.lblCPUParameter31.Text = "MAC Id:";
            // 
            // lblCPUParameter30
            // 
            this.lblCPUParameter30.AutoSize = true;
            this.lblCPUParameter30.Location = new System.Drawing.Point(33, 86);
            this.lblCPUParameter30.Name = "lblCPUParameter30";
            this.lblCPUParameter30.Size = new System.Drawing.Size(87, 13);
            this.lblCPUParameter30.TabIndex = 2;
            this.lblCPUParameter30.Text = "Default gateway:";
            // 
            // lblCPUParameter29
            // 
            this.lblCPUParameter29.AutoSize = true;
            this.lblCPUParameter29.Location = new System.Drawing.Point(72, 60);
            this.lblCPUParameter29.Name = "lblCPUParameter29";
            this.lblCPUParameter29.Size = new System.Drawing.Size(48, 13);
            this.lblCPUParameter29.TabIndex = 1;
            this.lblCPUParameter29.Text = "IP mask:";
            // 
            // lblCPUParameter28
            // 
            this.lblCPUParameter28.AutoSize = true;
            this.lblCPUParameter28.Location = new System.Drawing.Point(60, 29);
            this.lblCPUParameter28.Name = "lblCPUParameter28";
            this.lblCPUParameter28.Size = new System.Drawing.Size(60, 13);
            this.lblCPUParameter28.TabIndex = 0;
            this.lblCPUParameter28.Text = "IP address:";
            // 
            // grpDiskMnagement
            // 
            this.grpDiskMnagement.BackColor = System.Drawing.Color.DarkGray;
            this.grpDiskMnagement.Controls.Add(this.lblCPUValue23);
            this.grpDiskMnagement.Controls.Add(this.lblCPUValue22);
            this.grpDiskMnagement.Controls.Add(this.lblCPUValue21);
            this.grpDiskMnagement.Controls.Add(this.lblCPUValue20);
            this.grpDiskMnagement.Controls.Add(this.lblCPUValue19);
            this.grpDiskMnagement.Controls.Add(this.lblCPUValue18);
            this.grpDiskMnagement.Controls.Add(this.lblCPUParameter23);
            this.grpDiskMnagement.Controls.Add(this.lblCPUParameter22);
            this.grpDiskMnagement.Controls.Add(this.lblCPUParameter21);
            this.grpDiskMnagement.Controls.Add(this.lblCPUParameter20);
            this.grpDiskMnagement.Controls.Add(this.lblCPUParameter19);
            this.grpDiskMnagement.Controls.Add(this.lblCPUParameter18);
            this.grpDiskMnagement.Location = new System.Drawing.Point(608, 56);
            this.grpDiskMnagement.Name = "grpDiskMnagement";
            this.grpDiskMnagement.Size = new System.Drawing.Size(274, 175);
            this.grpDiskMnagement.TabIndex = 15;
            this.grpDiskMnagement.TabStop = false;
            this.grpDiskMnagement.Text = "Disk management";
            // 
            // lblCPUValue23
            // 
            this.lblCPUValue23.AutoSize = true;
            this.lblCPUValue23.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue23.Location = new System.Drawing.Point(138, 140);
            this.lblCPUValue23.Name = "lblCPUValue23";
            this.lblCPUValue23.Size = new System.Drawing.Size(73, 13);
            this.lblCPUValue23.TabIndex = 11;
            this.lblCPUValue23.Text = "19889225728";
            // 
            // lblCPUValue22
            // 
            this.lblCPUValue22.AutoSize = true;
            this.lblCPUValue22.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue22.Location = new System.Drawing.Point(138, 116);
            this.lblCPUValue22.Name = "lblCPUValue22";
            this.lblCPUValue22.Size = new System.Drawing.Size(73, 13);
            this.lblCPUValue22.TabIndex = 10;
            this.lblCPUValue22.Text = "19971178496";
            // 
            // lblCPUValue21
            // 
            this.lblCPUValue21.AutoSize = true;
            this.lblCPUValue21.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue21.Location = new System.Drawing.Point(138, 92);
            this.lblCPUValue21.Name = "lblCPUValue21";
            this.lblCPUValue21.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue21.TabIndex = 9;
            this.lblCPUValue21.Text = "1";
            // 
            // lblCPUValue20
            // 
            this.lblCPUValue20.AutoSize = true;
            this.lblCPUValue20.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue20.Location = new System.Drawing.Point(138, 68);
            this.lblCPUValue20.Name = "lblCPUValue20";
            this.lblCPUValue20.Size = new System.Drawing.Size(39, 13);
            this.lblCPUValue20.TabIndex = 8;
            this.lblCPUValue20.Text = "FAT32";
            // 
            // lblCPUValue19
            // 
            this.lblCPUValue19.AutoSize = true;
            this.lblCPUValue19.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue19.Location = new System.Drawing.Point(138, 44);
            this.lblCPUValue19.Name = "lblCPUValue19";
            this.lblCPUValue19.Size = new System.Drawing.Size(54, 13);
            this.lblCPUValue19.TabIndex = 7;
            this.lblCPUValue19.Text = "Hard Disk";
            // 
            // lblCPUValue18
            // 
            this.lblCPUValue18.AutoSize = true;
            this.lblCPUValue18.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue18.Location = new System.Drawing.Point(138, 20);
            this.lblCPUValue18.Name = "lblCPUValue18";
            this.lblCPUValue18.Size = new System.Drawing.Size(54, 13);
            this.lblCPUValue18.TabIndex = 6;
            this.lblCPUValue18.Text = "Hard Disk";
            // 
            // lblCPUParameter23
            // 
            this.lblCPUParameter23.AutoSize = true;
            this.lblCPUParameter23.Location = new System.Drawing.Point(75, 140);
            this.lblCPUParameter23.Name = "lblCPUParameter23";
            this.lblCPUParameter23.Size = new System.Drawing.Size(59, 13);
            this.lblCPUParameter23.TabIndex = 5;
            this.lblCPUParameter23.Text = "Free bytes:";
            // 
            // lblCPUParameter22
            // 
            this.lblCPUParameter22.AutoSize = true;
            this.lblCPUParameter22.Location = new System.Drawing.Point(72, 116);
            this.lblCPUParameter22.Name = "lblCPUParameter22";
            this.lblCPUParameter22.Size = new System.Drawing.Size(62, 13);
            this.lblCPUParameter22.TabIndex = 4;
            this.lblCPUParameter22.Text = "Total bytes:";
            // 
            // lblCPUParameter21
            // 
            this.lblCPUParameter21.AutoSize = true;
            this.lblCPUParameter21.Location = new System.Drawing.Point(72, 92);
            this.lblCPUParameter21.Name = "lblCPUParameter21";
            this.lblCPUParameter21.Size = new System.Drawing.Size(62, 13);
            this.lblCPUParameter21.TabIndex = 3;
            this.lblCPUParameter21.Text = "Drive Type:";
            // 
            // lblCPUParameter20
            // 
            this.lblCPUParameter20.AutoSize = true;
            this.lblCPUParameter20.Location = new System.Drawing.Point(47, 68);
            this.lblCPUParameter20.Name = "lblCPUParameter20";
            this.lblCPUParameter20.Size = new System.Drawing.Size(87, 13);
            this.lblCPUParameter20.TabIndex = 2;
            this.lblCPUParameter20.Text = "Filesystem name:";
            // 
            // lblCPUParameter19
            // 
            this.lblCPUParameter19.AutoSize = true;
            this.lblCPUParameter19.Location = new System.Drawing.Point(64, 44);
            this.lblCPUParameter19.Name = "lblCPUParameter19";
            this.lblCPUParameter19.Size = new System.Drawing.Size(70, 13);
            this.lblCPUParameter19.TabIndex = 1;
            this.lblCPUParameter19.Text = "Volume label:";
            // 
            // lblCPUParameter18
            // 
            this.lblCPUParameter18.AutoSize = true;
            this.lblCPUParameter18.Location = new System.Drawing.Point(73, 20);
            this.lblCPUParameter18.Name = "lblCPUParameter18";
            this.lblCPUParameter18.Size = new System.Drawing.Size(61, 13);
            this.lblCPUParameter18.TabIndex = 0;
            this.lblCPUParameter18.Text = "Drive letter:";
            // 
            // grpMemory
            // 
            this.grpMemory.BackColor = System.Drawing.Color.DarkGray;
            this.grpMemory.Controls.Add(this.lblCPUValue27);
            this.grpMemory.Controls.Add(this.lblCPUValue26);
            this.grpMemory.Controls.Add(this.lblCPUValue25);
            this.grpMemory.Controls.Add(this.lblCPUValue24);
            this.grpMemory.Controls.Add(this.lblCPUParameter26);
            this.grpMemory.Controls.Add(this.lblCPUParameter27);
            this.grpMemory.Controls.Add(this.lblCPUParameter25);
            this.grpMemory.Controls.Add(this.lblCPUParameter24);
            this.grpMemory.Location = new System.Drawing.Point(608, 244);
            this.grpMemory.Name = "grpMemory";
            this.grpMemory.Size = new System.Drawing.Size(274, 130);
            this.grpMemory.TabIndex = 14;
            this.grpMemory.TabStop = false;
            this.grpMemory.Text = "Memory";
            // 
            // lblCPUValue27
            // 
            this.lblCPUValue27.AutoSize = true;
            this.lblCPUValue27.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue27.Location = new System.Drawing.Point(138, 106);
            this.lblCPUValue27.Name = "lblCPUValue27";
            this.lblCPUValue27.Size = new System.Drawing.Size(61, 13);
            this.lblCPUValue27.TabIndex = 7;
            this.lblCPUValue27.Text = "133857280";
            // 
            // lblCPUValue26
            // 
            this.lblCPUValue26.AutoSize = true;
            this.lblCPUValue26.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue26.Location = new System.Drawing.Point(138, 84);
            this.lblCPUValue26.Name = "lblCPUValue26";
            this.lblCPUValue26.Size = new System.Drawing.Size(61, 13);
            this.lblCPUValue26.TabIndex = 6;
            this.lblCPUValue26.Text = "133971968";
            // 
            // lblCPUValue25
            // 
            this.lblCPUValue25.AutoSize = true;
            this.lblCPUValue25.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue25.Location = new System.Drawing.Point(138, 57);
            this.lblCPUValue25.Name = "lblCPUValue25";
            this.lblCPUValue25.Size = new System.Drawing.Size(67, 13);
            this.lblCPUValue25.TabIndex = 5;
            this.lblCPUValue25.Text = "1777745920";
            // 
            // lblCPUValue24
            // 
            this.lblCPUValue24.AutoSize = true;
            this.lblCPUValue24.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue24.Location = new System.Drawing.Point(138, 30);
            this.lblCPUValue24.Name = "lblCPUValue24";
            this.lblCPUValue24.Size = new System.Drawing.Size(67, 13);
            this.lblCPUValue24.TabIndex = 4;
            this.lblCPUValue24.Text = "1842061312";
            // 
            // lblCPUParameter26
            // 
            this.lblCPUParameter26.AutoSize = true;
            this.lblCPUParameter26.Location = new System.Drawing.Point(23, 84);
            this.lblCPUParameter26.Name = "lblCPUParameter26";
            this.lblCPUParameter26.Size = new System.Drawing.Size(111, 13);
            this.lblCPUParameter26.TabIndex = 3;
            this.lblCPUParameter26.Text = "Total storage memory:";
            // 
            // lblCPUParameter27
            // 
            this.lblCPUParameter27.AutoSize = true;
            this.lblCPUParameter27.Location = new System.Drawing.Point(4, 106);
            this.lblCPUParameter27.Name = "lblCPUParameter27";
            this.lblCPUParameter27.Size = new System.Drawing.Size(130, 13);
            this.lblCPUParameter27.TabIndex = 2;
            this.lblCPUParameter27.Text = "Available storage memory:";
            // 
            // lblCPUParameter25
            // 
            this.lblCPUParameter25.AutoSize = true;
            this.lblCPUParameter25.Location = new System.Drawing.Point(1, 57);
            this.lblCPUParameter25.Name = "lblCPUParameter25";
            this.lblCPUParameter25.Size = new System.Drawing.Size(133, 13);
            this.lblCPUParameter25.TabIndex = 1;
            this.lblCPUParameter25.Text = "Available physical memory:";
            // 
            // lblCPUParameter24
            // 
            this.lblCPUParameter24.AutoSize = true;
            this.lblCPUParameter24.Location = new System.Drawing.Point(20, 30);
            this.lblCPUParameter24.Name = "lblCPUParameter24";
            this.lblCPUParameter24.Size = new System.Drawing.Size(114, 13);
            this.lblCPUParameter24.TabIndex = 0;
            this.lblCPUParameter24.Text = "Total physical memory:";
            // 
            // grpHardwareData
            // 
            this.grpHardwareData.BackColor = System.Drawing.Color.DarkGray;
            this.grpHardwareData.Controls.Add(this.lblCPUValue17);
            this.grpHardwareData.Controls.Add(this.lblCPUValue16);
            this.grpHardwareData.Controls.Add(this.lblCPUValue15);
            this.grpHardwareData.Controls.Add(this.lblCPUValue14);
            this.grpHardwareData.Controls.Add(this.lblCPUValue13);
            this.grpHardwareData.Controls.Add(this.lblCPUValue12);
            this.grpHardwareData.Controls.Add(this.lblCPUValue11);
            this.grpHardwareData.Controls.Add(this.lblCPUValue10);
            this.grpHardwareData.Controls.Add(this.lblCPUValue9);
            this.grpHardwareData.Controls.Add(this.lblCPUValue8);
            this.grpHardwareData.Controls.Add(this.lblCPUParameter17);
            this.grpHardwareData.Controls.Add(this.lblCPUParameter16);
            this.grpHardwareData.Controls.Add(this.lblCPUParameter15);
            this.grpHardwareData.Controls.Add(this.lblCPUParameter14);
            this.grpHardwareData.Controls.Add(this.lblCPUParameter13);
            this.grpHardwareData.Controls.Add(this.lblCPUParameter12);
            this.grpHardwareData.Controls.Add(this.lblCPUParameter11);
            this.grpHardwareData.Controls.Add(this.lblCPUParameter10);
            this.grpHardwareData.Controls.Add(this.lblCPUParameter9);
            this.grpHardwareData.Controls.Add(this.lblCPUParameter8);
            this.grpHardwareData.Location = new System.Drawing.Point(313, 56);
            this.grpHardwareData.Name = "grpHardwareData";
            this.grpHardwareData.Size = new System.Drawing.Size(274, 255);
            this.grpHardwareData.TabIndex = 13;
            this.grpHardwareData.TabStop = false;
            this.grpHardwareData.Text = "Hardware data";
            // 
            // lblCPUValue17
            // 
            this.lblCPUValue17.AutoSize = true;
            this.lblCPUValue17.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue17.Location = new System.Drawing.Point(166, 236);
            this.lblCPUValue17.Name = "lblCPUValue17";
            this.lblCPUValue17.Size = new System.Drawing.Size(19, 13);
            this.lblCPUValue17.TabIndex = 19;
            this.lblCPUValue17.Text = "49";
            // 
            // lblCPUValue16
            // 
            this.lblCPUValue16.AutoSize = true;
            this.lblCPUValue16.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue16.Location = new System.Drawing.Point(166, 212);
            this.lblCPUValue16.Name = "lblCPUValue16";
            this.lblCPUValue16.Size = new System.Drawing.Size(19, 13);
            this.lblCPUValue16.TabIndex = 18;
            this.lblCPUValue16.Text = "24";
            // 
            // lblCPUValue15
            // 
            this.lblCPUValue15.AutoSize = true;
            this.lblCPUValue15.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue15.Location = new System.Drawing.Point(166, 188);
            this.lblCPUValue15.Name = "lblCPUValue15";
            this.lblCPUValue15.Size = new System.Drawing.Size(31, 13);
            this.lblCPUValue15.TabIndex = 17;
            this.lblCPUValue15.Text = "1468";
            // 
            // lblCPUValue14
            // 
            this.lblCPUValue14.AutoSize = true;
            this.lblCPUValue14.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue14.Location = new System.Drawing.Point(166, 164);
            this.lblCPUValue14.Name = "lblCPUValue14";
            this.lblCPUValue14.Size = new System.Drawing.Size(43, 13);
            this.lblCPUValue14.TabIndex = 16;
            this.lblCPUValue14.Text = "730896";
            // 
            // lblCPUValue13
            // 
            this.lblCPUValue13.AutoSize = true;
            this.lblCPUValue13.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue13.Location = new System.Drawing.Point(166, 140);
            this.lblCPUValue13.Name = "lblCPUValue13";
            this.lblCPUValue13.Size = new System.Drawing.Size(43, 13);
            this.lblCPUValue13.TabIndex = 15;
            this.lblCPUValue13.Text = "720905";
            // 
            // lblCPUValue12
            // 
            this.lblCPUValue12.AutoSize = true;
            this.lblCPUValue12.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue12.Location = new System.Drawing.Point(166, 116);
            this.lblCPUValue12.Name = "lblCPUValue12";
            this.lblCPUValue12.Size = new System.Drawing.Size(35, 13);
            this.lblCPUValue12.TabIndex = 14;
            this.lblCPUValue12.Text = "CPU0";
            // 
            // lblCPUValue11
            // 
            this.lblCPUValue11.AutoSize = true;
            this.lblCPUValue11.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue11.Location = new System.Drawing.Point(166, 92);
            this.lblCPUValue11.Name = "lblCPUValue11";
            this.lblCPUValue11.Size = new System.Drawing.Size(31, 13);
            this.lblCPUValue11.TabIndex = 13;
            this.lblCPUValue11.Text = "5200";
            // 
            // lblCPUValue10
            // 
            this.lblCPUValue10.AutoSize = true;
            this.lblCPUValue10.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue10.Location = new System.Drawing.Point(166, 68);
            this.lblCPUValue10.Name = "lblCPUValue10";
            this.lblCPUValue10.Size = new System.Drawing.Size(31, 13);
            this.lblCPUValue10.TabIndex = 12;
            this.lblCPUValue10.Text = "5000";
            // 
            // lblCPUValue9
            // 
            this.lblCPUValue9.AutoSize = true;
            this.lblCPUValue9.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue9.Location = new System.Drawing.Point(166, 44);
            this.lblCPUValue9.Name = "lblCPUValue9";
            this.lblCPUValue9.Size = new System.Drawing.Size(19, 13);
            this.lblCPUValue9.TabIndex = 11;
            this.lblCPUValue9.Text = "48";
            // 
            // lblCPUValue8
            // 
            this.lblCPUValue8.AutoSize = true;
            this.lblCPUValue8.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue8.Location = new System.Drawing.Point(166, 20);
            this.lblCPUValue8.Name = "lblCPUValue8";
            this.lblCPUValue8.Size = new System.Drawing.Size(19, 13);
            this.lblCPUValue8.TabIndex = 10;
            this.lblCPUValue8.Text = "48";
            // 
            // lblCPUParameter17
            // 
            this.lblCPUParameter17.AutoSize = true;
            this.lblCPUParameter17.Location = new System.Drawing.Point(56, 236);
            this.lblCPUParameter17.Name = "lblCPUParameter17";
            this.lblCPUParameter17.Size = new System.Drawing.Size(91, 13);
            this.lblCPUParameter17.TabIndex = 9;
            this.lblCPUParameter17.Text = "CPU temperature:";
            // 
            // lblCPUParameter16
            // 
            this.lblCPUParameter16.AutoSize = true;
            this.lblCPUParameter16.Location = new System.Drawing.Point(83, 212);
            this.lblCPUParameter16.Name = "lblCPUParameter16";
            this.lblCPUParameter16.Size = new System.Drawing.Size(64, 13);
            this.lblCPUParameter16.TabIndex = 8;
            this.lblCPUParameter16.Text = "CPU usage:";
            // 
            // lblCPUParameter15
            // 
            this.lblCPUParameter15.AutoSize = true;
            this.lblCPUParameter15.Location = new System.Drawing.Point(34, 188);
            this.lblCPUParameter15.Name = "lblCPUParameter15";
            this.lblCPUParameter15.Size = new System.Drawing.Size(113, 13);
            this.lblCPUParameter15.TabIndex = 7;
            this.lblCPUParameter15.Text = "CPU frequency (MHz):";
            // 
            // lblCPUParameter14
            // 
            this.lblCPUParameter14.AutoSize = true;
            this.lblCPUParameter14.Location = new System.Drawing.Point(80, 164);
            this.lblCPUParameter14.Name = "lblCPUParameter14";
            this.lblCPUParameter14.Size = new System.Drawing.Size(67, 13);
            this.lblCPUParameter14.TabIndex = 6;
            this.lblCPUParameter14.Text = "Device type:";
            // 
            // lblCPUParameter13
            // 
            this.lblCPUParameter13.AutoSize = true;
            this.lblCPUParameter13.Location = new System.Drawing.Point(62, 140);
            this.lblCPUParameter13.Name = "lblCPUParameter13";
            this.lblCPUParameter13.Size = new System.Drawing.Size(85, 13);
            this.lblCPUParameter13.TabIndex = 5;
            this.lblCPUParameter13.Text = "Module address:";
            // 
            // lblCPUParameter12
            // 
            this.lblCPUParameter12.AutoSize = true;
            this.lblCPUParameter12.Location = new System.Drawing.Point(73, 116);
            this.lblCPUParameter12.Name = "lblCPUParameter12";
            this.lblCPUParameter12.Size = new System.Drawing.Size(74, 13);
            this.lblCPUParameter12.TabIndex = 4;
            this.lblCPUParameter12.Text = "Module name:";
            // 
            // lblCPUParameter11
            // 
            this.lblCPUParameter11.AutoSize = true;
            this.lblCPUParameter11.Location = new System.Drawing.Point(27, 92);
            this.lblCPUParameter11.Name = "lblCPUParameter11";
            this.lblCPUParameter11.Size = new System.Drawing.Size(120, 13);
            this.lblCPUParameter11.TabIndex = 3;
            this.lblCPUParameter11.Text = "Max mainboard voltage:";
            // 
            // lblCPUParameter10
            // 
            this.lblCPUParameter10.AutoSize = true;
            this.lblCPUParameter10.Location = new System.Drawing.Point(30, 68);
            this.lblCPUParameter10.Name = "lblCPUParameter10";
            this.lblCPUParameter10.Size = new System.Drawing.Size(117, 13);
            this.lblCPUParameter10.TabIndex = 2;
            this.lblCPUParameter10.Text = "Min mainboard voltage:";
            // 
            // lblCPUParameter9
            // 
            this.lblCPUParameter9.AutoSize = true;
            this.lblCPUParameter9.Location = new System.Drawing.Point(6, 44);
            this.lblCPUParameter9.Name = "lblCPUParameter9";
            this.lblCPUParameter9.Size = new System.Drawing.Size(141, 13);
            this.lblCPUParameter9.TabIndex = 1;
            this.lblCPUParameter9.Text = "Max mainboard temperature:";
            // 
            // lblCPUParameter8
            // 
            this.lblCPUParameter8.AutoSize = true;
            this.lblCPUParameter8.Location = new System.Drawing.Point(28, 20);
            this.lblCPUParameter8.Name = "lblCPUParameter8";
            this.lblCPUParameter8.Size = new System.Drawing.Size(119, 13);
            this.lblCPUParameter8.TabIndex = 0;
            this.lblCPUParameter8.Text = "Mainboard temperature:";
            // 
            // grpOperationData
            // 
            this.grpOperationData.BackColor = System.Drawing.Color.DarkGray;
            this.grpOperationData.Controls.Add(this.lblCPUValue7);
            this.grpOperationData.Controls.Add(this.lblCPUValue6);
            this.grpOperationData.Controls.Add(this.lblCPUParameter7);
            this.grpOperationData.Controls.Add(this.lblCPUParameter6);
            this.grpOperationData.Location = new System.Drawing.Point(8, 241);
            this.grpOperationData.Name = "grpOperationData";
            this.grpOperationData.Size = new System.Drawing.Size(274, 71);
            this.grpOperationData.TabIndex = 12;
            this.grpOperationData.TabStop = false;
            this.grpOperationData.Text = "Operation data";
            // 
            // lblCPUValue7
            // 
            this.lblCPUValue7.AutoSize = true;
            this.lblCPUValue7.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue7.Location = new System.Drawing.Point(138, 46);
            this.lblCPUValue7.Name = "lblCPUValue7";
            this.lblCPUValue7.Size = new System.Drawing.Size(25, 13);
            this.lblCPUValue7.TabIndex = 3;
            this.lblCPUValue7.Text = "113";
            // 
            // lblCPUValue6
            // 
            this.lblCPUValue6.AutoSize = true;
            this.lblCPUValue6.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue6.Location = new System.Drawing.Point(138, 19);
            this.lblCPUValue6.Name = "lblCPUValue6";
            this.lblCPUValue6.Size = new System.Drawing.Size(19, 13);
            this.lblCPUValue6.TabIndex = 2;
            this.lblCPUValue6.Text = "10";
            // 
            // lblCPUParameter7
            // 
            this.lblCPUParameter7.AutoSize = true;
            this.lblCPUParameter7.Location = new System.Drawing.Point(2, 47);
            this.lblCPUParameter7.Name = "lblCPUParameter7";
            this.lblCPUParameter7.Size = new System.Drawing.Size(118, 13);
            this.lblCPUParameter7.TabIndex = 1;
            this.lblCPUParameter7.Text = "Operating time (minute):";
            // 
            // lblCPUParameter6
            // 
            this.lblCPUParameter6.AutoSize = true;
            this.lblCPUParameter6.Location = new System.Drawing.Point(58, 20);
            this.lblCPUParameter6.Name = "lblCPUParameter6";
            this.lblCPUParameter6.Size = new System.Drawing.Size(62, 13);
            this.lblCPUParameter6.TabIndex = 0;
            this.lblCPUParameter6.Text = "Boot count:";
            // 
            // grpIdentityCard
            // 
            this.grpIdentityCard.BackColor = System.Drawing.Color.DarkGray;
            this.grpIdentityCard.Controls.Add(this.lblCPUValue5);
            this.grpIdentityCard.Controls.Add(this.lblCPUValue4);
            this.grpIdentityCard.Controls.Add(this.lblCPUValue3);
            this.grpIdentityCard.Controls.Add(this.lblCPUValue2);
            this.grpIdentityCard.Controls.Add(this.lblCPUValue1);
            this.grpIdentityCard.Controls.Add(this.lblCPUParameter5);
            this.grpIdentityCard.Controls.Add(this.lblCPUParameter4);
            this.grpIdentityCard.Controls.Add(this.lblCPUParameter3);
            this.grpIdentityCard.Controls.Add(this.lblCPUParameter2);
            this.grpIdentityCard.Controls.Add(this.lblCPUValue0);
            this.grpIdentityCard.Controls.Add(this.lblCPUParameter1);
            this.grpIdentityCard.Controls.Add(this.lblCPUParameter0);
            this.grpIdentityCard.Location = new System.Drawing.Point(8, 56);
            this.grpIdentityCard.Name = "grpIdentityCard";
            this.grpIdentityCard.Size = new System.Drawing.Size(274, 176);
            this.grpIdentityCard.TabIndex = 11;
            this.grpIdentityCard.TabStop = false;
            this.grpIdentityCard.Text = "Identity card";
            // 
            // lblCPUValue5
            // 
            this.lblCPUValue5.AutoSize = true;
            this.lblCPUValue5.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue5.Location = new System.Drawing.Point(138, 145);
            this.lblCPUValue5.Name = "lblCPUValue5";
            this.lblCPUValue5.Size = new System.Drawing.Size(76, 13);
            this.lblCPUValue5.TabIndex = 11;
            this.lblCPUValue5.Text = "2022-00-00-48";
            // 
            // lblCPUValue4
            // 
            this.lblCPUValue4.AutoSize = true;
            this.lblCPUValue4.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue4.Location = new System.Drawing.Point(138, 120);
            this.lblCPUValue4.Name = "lblCPUValue4";
            this.lblCPUValue4.Size = new System.Drawing.Size(97, 13);
            this.lblCPUValue4.TabIndex = 10;
            this.lblCPUValue4.Text = "123343455656546";
            // 
            // lblCPUValue3
            // 
            this.lblCPUValue3.AutoSize = true;
            this.lblCPUValue3.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue3.Location = new System.Drawing.Point(138, 95);
            this.lblCPUValue3.Name = "lblCPUValue3";
            this.lblCPUValue3.Size = new System.Drawing.Size(19, 13);
            this.lblCPUValue3.TabIndex = 9;
            this.lblCPUValue3.Text = "85";
            // 
            // lblCPUValue2
            // 
            this.lblCPUValue2.AutoSize = true;
            this.lblCPUValue2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue2.Location = new System.Drawing.Point(138, 70);
            this.lblCPUValue2.Name = "lblCPUValue2";
            this.lblCPUValue2.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue2.TabIndex = 8;
            this.lblCPUValue2.Text = "0";
            // 
            // lblCPUValue1
            // 
            this.lblCPUValue1.AutoSize = true;
            this.lblCPUValue1.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue1.Location = new System.Drawing.Point(138, 45);
            this.lblCPUValue1.Name = "lblCPUValue1";
            this.lblCPUValue1.Size = new System.Drawing.Size(13, 13);
            this.lblCPUValue1.TabIndex = 7;
            this.lblCPUValue1.Text = "2";
            // 
            // lblCPUParameter5
            // 
            this.lblCPUParameter5.AutoSize = true;
            this.lblCPUParameter5.Location = new System.Drawing.Point(35, 145);
            this.lblCPUParameter5.Name = "lblCPUParameter5";
            this.lblCPUParameter5.Size = new System.Drawing.Size(85, 13);
            this.lblCPUParameter5.TabIndex = 6;
            this.lblCPUParameter5.Text = "Production date:";
            // 
            // lblCPUParameter4
            // 
            this.lblCPUParameter4.AutoSize = true;
            this.lblCPUParameter4.Location = new System.Drawing.Point(46, 120);
            this.lblCPUParameter4.Name = "lblCPUParameter4";
            this.lblCPUParameter4.Size = new System.Drawing.Size(74, 13);
            this.lblCPUParameter4.TabIndex = 5;
            this.lblCPUParameter4.Text = "Serial number:";
            // 
            // lblCPUParameter3
            // 
            this.lblCPUParameter3.AutoSize = true;
            this.lblCPUParameter3.Location = new System.Drawing.Point(19, 95);
            this.lblCPUParameter3.Name = "lblCPUParameter3";
            this.lblCPUParameter3.Size = new System.Drawing.Size(101, 13);
            this.lblCPUParameter3.TabIndex = 4;
            this.lblCPUParameter3.Text = "BIOS Minor version:";
            // 
            // lblCPUParameter2
            // 
            this.lblCPUParameter2.AutoSize = true;
            this.lblCPUParameter2.Location = new System.Drawing.Point(19, 70);
            this.lblCPUParameter2.Name = "lblCPUParameter2";
            this.lblCPUParameter2.Size = new System.Drawing.Size(101, 13);
            this.lblCPUParameter2.TabIndex = 3;
            this.lblCPUParameter2.Text = "BIOS Major version:";
            // 
            // lblCPUValue0
            // 
            this.lblCPUValue0.AutoSize = true;
            this.lblCPUValue0.BackColor = System.Drawing.Color.Gainsboro;
            this.lblCPUValue0.Location = new System.Drawing.Point(138, 20);
            this.lblCPUValue0.Name = "lblCPUValue0";
            this.lblCPUValue0.Size = new System.Drawing.Size(44, 13);
            this.lblCPUValue0.TabIndex = 2;
            this.lblCPUValue0.Text = "CX51x0";
            // 
            // lblCPUParameter1
            // 
            this.lblCPUParameter1.AutoSize = true;
            this.lblCPUParameter1.Location = new System.Drawing.Point(69, 45);
            this.lblCPUParameter1.Name = "lblCPUParameter1";
            this.lblCPUParameter1.Size = new System.Drawing.Size(51, 13);
            this.lblCPUParameter1.TabIndex = 1;
            this.lblCPUParameter1.Text = "Revision:";
            // 
            // lblCPUParameter0
            // 
            this.lblCPUParameter0.AutoSize = true;
            this.lblCPUParameter0.Location = new System.Drawing.Point(86, 20);
            this.lblCPUParameter0.Name = "lblCPUParameter0";
            this.lblCPUParameter0.Size = new System.Drawing.Size(34, 13);
            this.lblCPUParameter0.TabIndex = 0;
            this.lblCPUParameter0.Text = "Type:";
            // 
            // tabEncoderData
            // 
            this.tabEncoderData.BackColor = System.Drawing.Color.Gainsboro;
            this.tabEncoderData.Controls.Add(this.grpParameter);
            this.tabEncoderData.Controls.Add(this.grpValue);
            this.tabEncoderData.Controls.Add(this.grpConnection);
            this.tabEncoderData.Location = new System.Drawing.Point(4, 22);
            this.tabEncoderData.Name = "tabEncoderData";
            this.tabEncoderData.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncoderData.Size = new System.Drawing.Size(1229, 857);
            this.tabEncoderData.TabIndex = 1;
            this.tabEncoderData.Text = "EncoderData";
            // 
            // grpParameter
            // 
            this.grpParameter.BackColor = System.Drawing.Color.DarkGray;
            this.grpParameter.Controls.Add(this.lblEncVal24);
            this.grpParameter.Controls.Add(this.lblEncVal23);
            this.grpParameter.Controls.Add(this.lblEncPar24);
            this.grpParameter.Controls.Add(this.lblEncPar23);
            this.grpParameter.Controls.Add(this.lblEncVal22);
            this.grpParameter.Controls.Add(this.lblEncVal21);
            this.grpParameter.Controls.Add(this.lblEncVal20);
            this.grpParameter.Controls.Add(this.lblEncVal19);
            this.grpParameter.Controls.Add(this.lblEncVal18);
            this.grpParameter.Controls.Add(this.lblEncVal17);
            this.grpParameter.Controls.Add(this.lblEncVal16);
            this.grpParameter.Controls.Add(this.lblEncVal15);
            this.grpParameter.Controls.Add(this.lblEncVal14);
            this.grpParameter.Controls.Add(this.lblEncVal13);
            this.grpParameter.Controls.Add(this.lblEncPar22);
            this.grpParameter.Controls.Add(this.lblEncPar21);
            this.grpParameter.Controls.Add(this.lblEncPar20);
            this.grpParameter.Controls.Add(this.lblEncPar19);
            this.grpParameter.Controls.Add(this.lblEncPar18);
            this.grpParameter.Controls.Add(this.lblEncPar17);
            this.grpParameter.Controls.Add(this.lblEncPar16);
            this.grpParameter.Controls.Add(this.lblEncPar15);
            this.grpParameter.Controls.Add(this.lblEncPar14);
            this.grpParameter.Controls.Add(this.lblEncPar13);
            this.grpParameter.Location = new System.Drawing.Point(654, 16);
            this.grpParameter.Name = "grpParameter";
            this.grpParameter.Size = new System.Drawing.Size(345, 310);
            this.grpParameter.TabIndex = 15;
            this.grpParameter.TabStop = false;
            this.grpParameter.Text = "Parameter";
            // 
            // lblEncVal24
            // 
            this.lblEncVal24.AutoSize = true;
            this.lblEncVal24.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal24.Location = new System.Drawing.Point(197, 286);
            this.lblEncVal24.Name = "lblEncVal24";
            this.lblEncVal24.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal24.TabIndex = 23;
            this.lblEncVal24.Text = "-";
            // 
            // lblEncVal23
            // 
            this.lblEncVal23.AutoSize = true;
            this.lblEncVal23.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal23.Location = new System.Drawing.Point(197, 262);
            this.lblEncVal23.Name = "lblEncVal23";
            this.lblEncVal23.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal23.TabIndex = 22;
            this.lblEncVal23.Text = "-";
            // 
            // lblEncPar24
            // 
            this.lblEncPar24.AutoSize = true;
            this.lblEncPar24.Location = new System.Drawing.Point(81, 286);
            this.lblEncPar24.Name = "lblEncPar24";
            this.lblEncPar24.Size = new System.Drawing.Size(97, 13);
            this.lblEncPar24.TabIndex = 21;
            this.lblEncPar24.Text = "Encoder Submask:";
            // 
            // lblEncPar23
            // 
            this.lblEncPar23.AutoSize = true;
            this.lblEncPar23.Location = new System.Drawing.Point(99, 262);
            this.lblEncPar23.Name = "lblEncPar23";
            this.lblEncPar23.Size = new System.Drawing.Size(79, 13);
            this.lblEncPar23.TabIndex = 20;
            this.lblEncPar23.Text = "Encoder Mask:";
            // 
            // lblEncVal22
            // 
            this.lblEncVal22.AutoSize = true;
            this.lblEncVal22.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal22.Location = new System.Drawing.Point(197, 236);
            this.lblEncVal22.Name = "lblEncVal22";
            this.lblEncVal22.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal22.TabIndex = 19;
            this.lblEncVal22.Text = "-";
            // 
            // lblEncVal21
            // 
            this.lblEncVal21.AutoSize = true;
            this.lblEncVal21.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal21.Location = new System.Drawing.Point(197, 212);
            this.lblEncVal21.Name = "lblEncVal21";
            this.lblEncVal21.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal21.TabIndex = 18;
            this.lblEncVal21.Text = "-";
            // 
            // lblEncVal20
            // 
            this.lblEncVal20.AutoSize = true;
            this.lblEncVal20.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal20.Location = new System.Drawing.Point(197, 188);
            this.lblEncVal20.Name = "lblEncVal20";
            this.lblEncVal20.Size = new System.Drawing.Size(81, 13);
            this.lblEncVal20.TabIndex = 17;
            this.lblEncVal20.Text = "TRUE / FALSE";
            // 
            // lblEncVal19
            // 
            this.lblEncVal19.AutoSize = true;
            this.lblEncVal19.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal19.Location = new System.Drawing.Point(197, 164);
            this.lblEncVal19.Name = "lblEncVal19";
            this.lblEncVal19.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal19.TabIndex = 16;
            this.lblEncVal19.Text = "-";
            // 
            // lblEncVal18
            // 
            this.lblEncVal18.AutoSize = true;
            this.lblEncVal18.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal18.Location = new System.Drawing.Point(197, 140);
            this.lblEncVal18.Name = "lblEncVal18";
            this.lblEncVal18.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal18.TabIndex = 15;
            this.lblEncVal18.Text = "-";
            // 
            // lblEncVal17
            // 
            this.lblEncVal17.AutoSize = true;
            this.lblEncVal17.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal17.Location = new System.Drawing.Point(197, 116);
            this.lblEncVal17.Name = "lblEncVal17";
            this.lblEncVal17.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal17.TabIndex = 14;
            this.lblEncVal17.Text = "-";
            // 
            // lblEncVal16
            // 
            this.lblEncVal16.AutoSize = true;
            this.lblEncVal16.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal16.Location = new System.Drawing.Point(197, 92);
            this.lblEncVal16.Name = "lblEncVal16";
            this.lblEncVal16.Size = new System.Drawing.Size(46, 13);
            this.lblEncVal16.TabIndex = 13;
            this.lblEncVal16.Text = "ON-OFF";
            // 
            // lblEncVal15
            // 
            this.lblEncVal15.AutoSize = true;
            this.lblEncVal15.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal15.Location = new System.Drawing.Point(197, 68);
            this.lblEncVal15.Name = "lblEncVal15";
            this.lblEncVal15.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal15.TabIndex = 12;
            this.lblEncVal15.Text = "-";
            // 
            // lblEncVal14
            // 
            this.lblEncVal14.AutoSize = true;
            this.lblEncVal14.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal14.Location = new System.Drawing.Point(197, 44);
            this.lblEncVal14.Name = "lblEncVal14";
            this.lblEncVal14.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal14.TabIndex = 11;
            this.lblEncVal14.Text = "-";
            // 
            // lblEncVal13
            // 
            this.lblEncVal13.AutoSize = true;
            this.lblEncVal13.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal13.Location = new System.Drawing.Point(197, 20);
            this.lblEncVal13.Name = "lblEncVal13";
            this.lblEncVal13.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal13.TabIndex = 10;
            this.lblEncVal13.Text = "-";
            // 
            // lblEncPar22
            // 
            this.lblEncPar22.AutoSize = true;
            this.lblEncPar22.Location = new System.Drawing.Point(103, 236);
            this.lblEncPar22.Name = "lblEncPar22";
            this.lblEncPar22.Size = new System.Drawing.Size(75, 13);
            this.lblEncPar22.TabIndex = 9;
            this.lblEncPar22.Text = "Modulo factor:";
            // 
            // lblEncPar21
            // 
            this.lblEncPar21.AutoSize = true;
            this.lblEncPar21.Location = new System.Drawing.Point(108, 212);
            this.lblEncPar21.Name = "lblEncPar21";
            this.lblEncPar21.Size = new System.Drawing.Size(70, 13);
            this.lblEncPar21.TabIndex = 8;
            this.lblEncPar21.Text = "Position Bias:";
            // 
            // lblEncPar20
            // 
            this.lblEncPar20.AutoSize = true;
            this.lblEncPar20.Location = new System.Drawing.Point(12, 188);
            this.lblEncPar20.Name = "lblEncPar20";
            this.lblEncPar20.Size = new System.Drawing.Size(166, 13);
            this.lblEncPar20.TabIndex = 7;
            this.lblEncPar20.Text = "Invert encoder counting direction:";
            // 
            // lblEncPar19
            // 
            this.lblEncPar19.AutoSize = true;
            this.lblEncPar19.Location = new System.Drawing.Point(42, 164);
            this.lblEncPar19.Name = "lblEncPar19";
            this.lblEncPar19.Size = new System.Drawing.Size(136, 13);
            this.lblEncPar19.TabIndex = 6;
            this.lblEncPar19.Text = "Scaling factor denominator:";
            // 
            // lblEncPar18
            // 
            this.lblEncPar18.AutoSize = true;
            this.lblEncPar18.Location = new System.Drawing.Point(53, 140);
            this.lblEncPar18.Name = "lblEncPar18";
            this.lblEncPar18.Size = new System.Drawing.Size(125, 13);
            this.lblEncPar18.TabIndex = 5;
            this.lblEncPar18.Text = "Scaling factor numerator:";
            // 
            // lblEncPar17
            // 
            this.lblEncPar17.AutoSize = true;
            this.lblEncPar17.Location = new System.Drawing.Point(6, 116);
            this.lblEncPar17.Name = "lblEncPar17";
            this.lblEncPar17.Size = new System.Drawing.Size(172, 13);
            this.lblEncPar17.TabIndex = 4;
            this.lblEncPar17.Text = "Time compensation encoder delay:";
            // 
            // lblEncPar16
            // 
            this.lblEncPar16.AutoSize = true;
            this.lblEncPar16.Location = new System.Drawing.Point(76, 92);
            this.lblEncPar16.Name = "lblEncPar16";
            this.lblEncPar16.Size = new System.Drawing.Size(102, 13);
            this.lblEncPar16.TabIndex = 3;
            this.lblEncPar16.Text = "Time compensation:";
            // 
            // lblEncPar15
            // 
            this.lblEncPar15.AutoSize = true;
            this.lblEncPar15.Location = new System.Drawing.Point(16, 68);
            this.lblEncPar15.Name = "lblEncPar15";
            this.lblEncPar15.Size = new System.Drawing.Size(162, 13);
            this.lblEncPar15.TabIndex = 2;
            this.lblEncPar15.Text = "Filter time for actual acceleration:";
            // 
            // lblEncPar14
            // 
            this.lblEncPar14.AutoSize = true;
            this.lblEncPar14.Location = new System.Drawing.Point(38, 44);
            this.lblEncPar14.Name = "lblEncPar14";
            this.lblEncPar14.Size = new System.Drawing.Size(140, 13);
            this.lblEncPar14.TabIndex = 1;
            this.lblEncPar14.Text = "Filter time for actual velocity:";
            // 
            // lblEncPar13
            // 
            this.lblEncPar13.AutoSize = true;
            this.lblEncPar13.Location = new System.Drawing.Point(38, 20);
            this.lblEncPar13.Name = "lblEncPar13";
            this.lblEncPar13.Size = new System.Drawing.Size(140, 13);
            this.lblEncPar13.TabIndex = 0;
            this.lblEncPar13.Text = "Filter time for actual position:";
            // 
            // grpValue
            // 
            this.grpValue.BackColor = System.Drawing.Color.DarkGray;
            this.grpValue.Controls.Add(this.lblEncVal12);
            this.grpValue.Controls.Add(this.lblEncVal11);
            this.grpValue.Controls.Add(this.lblEncVal10);
            this.grpValue.Controls.Add(this.lblEncVal9);
            this.grpValue.Controls.Add(this.lblEncVal8);
            this.grpValue.Controls.Add(this.lblEncVal7);
            this.grpValue.Controls.Add(this.lblEncVal6);
            this.grpValue.Controls.Add(this.lblEncVal5);
            this.grpValue.Controls.Add(this.lblEncVal4);
            this.grpValue.Controls.Add(this.lblEncPar12);
            this.grpValue.Controls.Add(this.lblEncPar11);
            this.grpValue.Controls.Add(this.lblEncPar10);
            this.grpValue.Controls.Add(this.lblEncPar9);
            this.grpValue.Controls.Add(this.lblEncPar8);
            this.grpValue.Controls.Add(this.lblEncPar7);
            this.grpValue.Controls.Add(this.lblEncPar6);
            this.grpValue.Controls.Add(this.lblEncPar5);
            this.grpValue.Controls.Add(this.lblEncPar4);
            this.grpValue.Location = new System.Drawing.Point(332, 16);
            this.grpValue.Name = "grpValue";
            this.grpValue.Size = new System.Drawing.Size(274, 238);
            this.grpValue.TabIndex = 14;
            this.grpValue.TabStop = false;
            this.grpValue.Text = "Value";
            // 
            // lblEncVal12
            // 
            this.lblEncVal12.AutoSize = true;
            this.lblEncVal12.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal12.Location = new System.Drawing.Point(166, 212);
            this.lblEncVal12.Name = "lblEncVal12";
            this.lblEncVal12.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal12.TabIndex = 18;
            this.lblEncVal12.Text = "-";
            // 
            // lblEncVal11
            // 
            this.lblEncVal11.AutoSize = true;
            this.lblEncVal11.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal11.Location = new System.Drawing.Point(166, 188);
            this.lblEncVal11.Name = "lblEncVal11";
            this.lblEncVal11.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal11.TabIndex = 17;
            this.lblEncVal11.Text = "-";
            // 
            // lblEncVal10
            // 
            this.lblEncVal10.AutoSize = true;
            this.lblEncVal10.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal10.Location = new System.Drawing.Point(166, 164);
            this.lblEncVal10.Name = "lblEncVal10";
            this.lblEncVal10.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal10.TabIndex = 16;
            this.lblEncVal10.Text = "-";
            // 
            // lblEncVal9
            // 
            this.lblEncVal9.AutoSize = true;
            this.lblEncVal9.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal9.Location = new System.Drawing.Point(166, 140);
            this.lblEncVal9.Name = "lblEncVal9";
            this.lblEncVal9.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal9.TabIndex = 15;
            this.lblEncVal9.Text = "-";
            // 
            // lblEncVal8
            // 
            this.lblEncVal8.AutoSize = true;
            this.lblEncVal8.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal8.Location = new System.Drawing.Point(166, 116);
            this.lblEncVal8.Name = "lblEncVal8";
            this.lblEncVal8.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal8.TabIndex = 14;
            this.lblEncVal8.Text = "-";
            // 
            // lblEncVal7
            // 
            this.lblEncVal7.AutoSize = true;
            this.lblEncVal7.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal7.Location = new System.Drawing.Point(166, 92);
            this.lblEncVal7.Name = "lblEncVal7";
            this.lblEncVal7.Size = new System.Drawing.Size(10, 13);
            this.lblEncVal7.TabIndex = 13;
            this.lblEncVal7.Text = "-";
            // 
            // lblEncVal6
            // 
            this.lblEncVal6.AutoSize = true;
            this.lblEncVal6.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal6.Location = new System.Drawing.Point(166, 68);
            this.lblEncVal6.Name = "lblEncVal6";
            this.lblEncVal6.Size = new System.Drawing.Size(19, 13);
            this.lblEncVal6.TabIndex = 12;
            this.lblEncVal6.Text = "48";
            // 
            // lblEncVal5
            // 
            this.lblEncVal5.AutoSize = true;
            this.lblEncVal5.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal5.Location = new System.Drawing.Point(166, 44);
            this.lblEncVal5.Name = "lblEncVal5";
            this.lblEncVal5.Size = new System.Drawing.Size(52, 13);
            this.lblEncVal5.TabIndex = 11;
            this.lblEncVal5.Text = "0 to 3600";
            // 
            // lblEncVal4
            // 
            this.lblEncVal4.AutoSize = true;
            this.lblEncVal4.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal4.Location = new System.Drawing.Point(166, 20);
            this.lblEncVal4.Name = "lblEncVal4";
            this.lblEncVal4.Size = new System.Drawing.Size(89, 13);
            this.lblEncVal4.TabIndex = 10;
            this.lblEncVal4.Text = "13 or 16 bit value";
            // 
            // lblEncPar12
            // 
            this.lblEncPar12.AutoSize = true;
            this.lblEncPar12.Location = new System.Drawing.Point(49, 212);
            this.lblEncPar12.Name = "lblEncPar12";
            this.lblEncPar12.Size = new System.Drawing.Size(98, 13);
            this.lblEncPar12.TabIndex = 8;
            this.lblEncPar12.Text = "Difference position:";
            // 
            // lblEncPar11
            // 
            this.lblEncPar11.AutoSize = true;
            this.lblEncPar11.Location = new System.Drawing.Point(14, 188);
            this.lblEncPar11.Name = "lblEncPar11";
            this.lblEncPar11.Size = new System.Drawing.Size(133, 13);
            this.lblEncPar11.TabIndex = 7;
            this.lblEncPar11.Text = "Average acquired position:";
            // 
            // lblEncPar10
            // 
            this.lblEncPar10.AutoSize = true;
            this.lblEncPar10.Location = new System.Drawing.Point(41, 164);
            this.lblEncPar10.Name = "lblEncPar10";
            this.lblEncPar10.Size = new System.Drawing.Size(106, 13);
            this.lblEncPar10.TabIndex = 6;
            this.lblEncPar10.Text = "Last acquired speed:";
            // 
            // lblEncPar9
            // 
            this.lblEncPar9.AutoSize = true;
            this.lblEncPar9.Location = new System.Drawing.Point(34, 140);
            this.lblEncPar9.Name = "lblEncPar9";
            this.lblEncPar9.Size = new System.Drawing.Size(113, 13);
            this.lblEncPar9.TabIndex = 5;
            this.lblEncPar9.Text = "Last acquired position:";
            // 
            // lblEncPar8
            // 
            this.lblEncPar8.AutoSize = true;
            this.lblEncPar8.Location = new System.Drawing.Point(70, 116);
            this.lblEncPar8.Name = "lblEncPar8";
            this.lblEncPar8.Size = new System.Drawing.Size(77, 13);
            this.lblEncPar8.TabIndex = 4;
            this.lblEncPar8.Text = "Warning code:";
            // 
            // lblEncPar7
            // 
            this.lblEncPar7.AutoSize = true;
            this.lblEncPar7.Location = new System.Drawing.Point(84, 92);
            this.lblEncPar7.Name = "lblEncPar7";
            this.lblEncPar7.Size = new System.Drawing.Size(63, 13);
            this.lblEncPar7.TabIndex = 3;
            this.lblEncPar7.Text = "Alarm code:";
            // 
            // lblEncPar6
            // 
            this.lblEncPar6.AutoSize = true;
            this.lblEncPar6.Location = new System.Drawing.Point(38, 68);
            this.lblEncPar6.Name = "lblEncPar6";
            this.lblEncPar6.Size = new System.Drawing.Size(109, 13);
            this.lblEncPar6.TabIndex = 2;
            this.lblEncPar6.Text = "Encoder temperature:";
            // 
            // lblEncPar5
            // 
            this.lblEncPar5.AutoSize = true;
            this.lblEncPar5.Location = new System.Drawing.Point(63, 44);
            this.lblEncPar5.Name = "lblEncPar5";
            this.lblEncPar5.Size = new System.Drawing.Size(84, 13);
            this.lblEncPar5.TabIndex = 1;
            this.lblEncPar5.Text = "Modulo position:";
            // 
            // lblEncPar4
            // 
            this.lblEncPar4.AutoSize = true;
            this.lblEncPar4.Location = new System.Drawing.Point(76, 20);
            this.lblEncPar4.Name = "lblEncPar4";
            this.lblEncPar4.Size = new System.Drawing.Size(71, 13);
            this.lblEncPar4.TabIndex = 0;
            this.lblEncPar4.Text = "Raw position:";
            // 
            // grpConnection
            // 
            this.grpConnection.BackColor = System.Drawing.Color.DarkGray;
            this.grpConnection.Controls.Add(this.lblEncVal3);
            this.grpConnection.Controls.Add(this.lblEncVal2);
            this.grpConnection.Controls.Add(this.lblEncVal1);
            this.grpConnection.Controls.Add(this.lblEncPar3);
            this.grpConnection.Controls.Add(this.lblEncPar2);
            this.grpConnection.Controls.Add(this.lblEncVal0);
            this.grpConnection.Controls.Add(this.lblEncPar1);
            this.grpConnection.Controls.Add(this.lblEncPar0);
            this.grpConnection.Location = new System.Drawing.Point(6, 16);
            this.grpConnection.Name = "grpConnection";
            this.grpConnection.Size = new System.Drawing.Size(274, 128);
            this.grpConnection.TabIndex = 12;
            this.grpConnection.TabStop = false;
            this.grpConnection.Text = "Connection";
            // 
            // lblEncVal3
            // 
            this.lblEncVal3.AutoSize = true;
            this.lblEncVal3.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal3.Location = new System.Drawing.Point(138, 95);
            this.lblEncVal3.Name = "lblEncVal3";
            this.lblEncVal3.Size = new System.Drawing.Size(82, 13);
            this.lblEncVal3.TabIndex = 9;
            this.lblEncVal3.Text = "5.135.24.23.1.1";
            // 
            // lblEncVal2
            // 
            this.lblEncVal2.AutoSize = true;
            this.lblEncVal2.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal2.Location = new System.Drawing.Point(138, 70);
            this.lblEncVal2.Name = "lblEncVal2";
            this.lblEncVal2.Size = new System.Drawing.Size(48, 13);
            this.lblEncVal2.TabIndex = 8;
            this.lblEncVal2.Text = "STRING";
            // 
            // lblEncVal1
            // 
            this.lblEncVal1.AutoSize = true;
            this.lblEncVal1.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal1.Location = new System.Drawing.Point(138, 45);
            this.lblEncVal1.Name = "lblEncVal1";
            this.lblEncVal1.Size = new System.Drawing.Size(58, 13);
            this.lblEncVal1.TabIndex = 7;
            this.lblEncVal1.Text = "HEX value";
            // 
            // lblEncPar3
            // 
            this.lblEncPar3.AutoSize = true;
            this.lblEncPar3.Location = new System.Drawing.Point(60, 95);
            this.lblEncPar3.Name = "lblEncPar3";
            this.lblEncPar3.Size = new System.Drawing.Size(61, 13);
            this.lblEncPar3.TabIndex = 4;
            this.lblEncPar3.Text = "AMS Netld:";
            // 
            // lblEncPar2
            // 
            this.lblEncPar2.AutoSize = true;
            this.lblEncPar2.Location = new System.Drawing.Point(58, 70);
            this.lblEncPar2.Name = "lblEncPar2";
            this.lblEncPar2.Size = new System.Drawing.Size(63, 13);
            this.lblEncPar2.TabIndex = 3;
            this.lblEncPar2.Text = "Detail state:";
            // 
            // lblEncVal0
            // 
            this.lblEncVal0.AutoSize = true;
            this.lblEncVal0.BackColor = System.Drawing.Color.Gainsboro;
            this.lblEncVal0.Location = new System.Drawing.Point(138, 20);
            this.lblEncVal0.Name = "lblEncVal0";
            this.lblEncVal0.Size = new System.Drawing.Size(75, 13);
            this.lblEncVal0.TabIndex = 2;
            this.lblEncVal0.Text = "TRUE/FALSE";
            // 
            // lblEncPar1
            // 
            this.lblEncPar1.AutoSize = true;
            this.lblEncPar1.Location = new System.Drawing.Point(58, 45);
            this.lblEncPar1.Name = "lblEncPar1";
            this.lblEncPar1.Size = new System.Drawing.Size(63, 13);
            this.lblEncPar1.TabIndex = 1;
            this.lblEncPar1.Text = "Detail state:";
            // 
            // lblEncPar0
            // 
            this.lblEncPar0.AutoSize = true;
            this.lblEncPar0.Location = new System.Drawing.Point(86, 20);
            this.lblEncPar0.Name = "lblEncPar0";
            this.lblEncPar0.Size = new System.Drawing.Size(35, 13);
            this.lblEncPar0.TabIndex = 0;
            this.lblEncPar0.Text = "State:";
            // 
            // tabLogger
            // 
            this.tabLogger.BackColor = System.Drawing.Color.Gainsboro;
            this.tabLogger.Controls.Add(this.dgvLogReader);
            this.tabLogger.Controls.Add(this.lblOpenFile);
            this.tabLogger.Controls.Add(this.btnOpenFile);
            this.tabLogger.Controls.Add(this.grpOpDescr);
            this.tabLogger.Controls.Add(this.lblSaveToFile);
            this.tabLogger.Controls.Add(this.grpError);
            this.tabLogger.Controls.Add(this.btnSaveToFile);
            this.tabLogger.Controls.Add(this.lblUpload);
            this.tabLogger.Controls.Add(this.btnRefresh);
            this.tabLogger.Controls.Add(this.lblCancel);
            this.tabLogger.Controls.Add(this.prgBarGetInfo);
            this.tabLogger.Controls.Add(this.btnStopRefresh);
            this.tabLogger.Controls.Add(this.lblInProgress);
            this.tabLogger.Location = new System.Drawing.Point(4, 22);
            this.tabLogger.Name = "tabLogger";
            this.tabLogger.Size = new System.Drawing.Size(1229, 857);
            this.tabLogger.TabIndex = 2;
            this.tabLogger.Text = "Logger";
            // 
            // LogReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1244, 1076);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblConnect);
            this.Controls.Add(this.lblMainMenu);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.prgConnWd);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblConnStatus);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LogReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogReader";
            this.Load += new System.EventHandler(this.LogReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogReader)).EndInit();
            this.grpOpDescr.ResumeLayout(false);
            this.grpError.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabCpuData.ResumeLayout(false);
            this.grpUserManagement.ResumeLayout(false);
            this.grpUserManagement.PerformLayout();
            this.grpUPS.ResumeLayout(false);
            this.grpUPS.PerformLayout();
            this.grpTwinCAT.ResumeLayout(false);
            this.grpTwinCAT.PerformLayout();
            this.grpOperatingSystem.ResumeLayout(false);
            this.grpOperatingSystem.PerformLayout();
            this.grpNetworkinterface2.ResumeLayout(false);
            this.grpNetworkinterface2.PerformLayout();
            this.grpNetworkinterface1.ResumeLayout(false);
            this.grpNetworkinterface1.PerformLayout();
            this.grpDiskMnagement.ResumeLayout(false);
            this.grpDiskMnagement.PerformLayout();
            this.grpMemory.ResumeLayout(false);
            this.grpMemory.PerformLayout();
            this.grpHardwareData.ResumeLayout(false);
            this.grpHardwareData.PerformLayout();
            this.grpOperationData.ResumeLayout(false);
            this.grpOperationData.PerformLayout();
            this.grpIdentityCard.ResumeLayout(false);
            this.grpIdentityCard.PerformLayout();
            this.tabEncoderData.ResumeLayout(false);
            this.grpParameter.ResumeLayout(false);
            this.grpParameter.PerformLayout();
            this.grpValue.ResumeLayout(false);
            this.grpValue.PerformLayout();
            this.grpConnection.ResumeLayout(false);
            this.grpConnection.PerformLayout();
            this.tabLogger.ResumeLayout(false);
            this.tabLogger.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLogReader;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventTimeStamp;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn EventAlert;
        private System.Windows.Forms.GroupBox grpOpDescr;
        private System.Windows.Forms.Label lblReal4;
        private System.Windows.Forms.Label lblReal3;
        private System.Windows.Forms.Label lblReal2;
        private System.Windows.Forms.Label lblReal1;
        private System.Windows.Forms.Label lblIntVal4;
        private System.Windows.Forms.Label lblIntVal3;
        private System.Windows.Forms.Label lblIntVal2;
        private System.Windows.Forms.Label lblIntVal1;
        private System.Windows.Forms.Label lblOpStr4;
        private System.Windows.Forms.Label lblOpStr3;
        private System.Windows.Forms.Label lblOpStr2;
        private System.Windows.Forms.Label lblOpStr1;
        private System.Windows.Forms.Label lblOpDescr;
        private System.Windows.Forms.GroupBox grpError;
        private System.Windows.Forms.Label lblFree3;
        private System.Windows.Forms.Label lblFree2;
        private System.Windows.Forms.Label lblFree1;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label lblSetPos;
        private System.Windows.Forms.Label lblMoveVel;
        private System.Windows.Forms.Label lblJog;
        private System.Windows.Forms.Label lblPower;
        private System.Windows.Forms.Label lblPhasingRelative;
        private System.Windows.Forms.Label lblGearOut;
        private System.Windows.Forms.Label lblGearIn;
        private System.Windows.Forms.Label lblMoveModulo;
        private System.Windows.Forms.Label lblResetSlaveAxis;
        private System.Windows.Forms.Label lblSlaveAxis;
        private System.Windows.Forms.Label lblZeroMasterEncoder;
        private System.Windows.Forms.Label lblResetMasterEnc;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblErrorDescr;
        private System.Windows.Forms.Label lblErrUdi15;
        private System.Windows.Forms.Label lblErrBit0;
        private System.Windows.Forms.Label lblErrUdi14;
        private System.Windows.Forms.Label lblErrBit1;
        private System.Windows.Forms.Label lblErrUdi13;
        private System.Windows.Forms.Label lblErrBit2;
        private System.Windows.Forms.Label lblErrUdi12;
        private System.Windows.Forms.Label lblErrBit3;
        private System.Windows.Forms.Label lblErrUdi11;
        private System.Windows.Forms.Label lblErrBit4;
        private System.Windows.Forms.Label lblErrUdi10;
        private System.Windows.Forms.Label lblErrBit5;
        private System.Windows.Forms.Label lblErrUdi9;
        private System.Windows.Forms.Label lblErrBit6;
        private System.Windows.Forms.Label lblErrBit15;
        private System.Windows.Forms.Label lblErrUdi8;
        private System.Windows.Forms.Label lblErrBit14;
        private System.Windows.Forms.Label lblErrBit7;
        private System.Windows.Forms.Label lblErrBit13;
        private System.Windows.Forms.Label lblErrUdi7;
        private System.Windows.Forms.Label lblErrBit12;
        private System.Windows.Forms.Label lblErrBit8;
        private System.Windows.Forms.Label lblErrBit11;
        private System.Windows.Forms.Label lblErrUdi6;
        private System.Windows.Forms.Label lblErrBit10;
        private System.Windows.Forms.Label lblErrUdi0;
        private System.Windows.Forms.Label lblErrBit9;
        private System.Windows.Forms.Label lblErrUdi5;
        private System.Windows.Forms.Label lblErrUdi1;
        private System.Windows.Forms.Label lblErrUdi4;
        private System.Windows.Forms.Label lblErrUdi2;
        private System.Windows.Forms.Label lblErrUdi3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Timer checkThread;
        private System.Windows.Forms.ProgressBar prgBarGetInfo;
        private System.Windows.Forms.Button btnStopRefresh;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.ProgressBar prgConnWd;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFromToolStripMenuItem;
        private System.Windows.Forms.Timer tWdTimer;
        private System.Windows.Forms.Label lblMainMenu;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.Label lblConnect;
        private System.Windows.Forms.Label lblUpload;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Button btnSaveToFile;
        private System.Windows.Forms.Label lblSaveToFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblOpenFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCpuData;
        private System.Windows.Forms.GroupBox grpUserManagement;
        private System.Windows.Forms.Label lblCPUValue56;
        private System.Windows.Forms.Label lblCPUParameter56;
        private System.Windows.Forms.GroupBox grpUPS;
        private System.Windows.Forms.Label lblCPUValue55;
        private System.Windows.Forms.Label lblCPUValue54;
        private System.Windows.Forms.Label lblCPUValue53;
        private System.Windows.Forms.Label lblCPUValue52;
        private System.Windows.Forms.Label lbCPUlValue51;
        private System.Windows.Forms.Label lblCPUValue50;
        private System.Windows.Forms.Label lblCPUValue49;
        private System.Windows.Forms.Label lblCPUValue48;
        private System.Windows.Forms.Label lblCPUValue47;
        private System.Windows.Forms.Label lblCPUValue46;
        private System.Windows.Forms.Label lblCPUParameter55;
        private System.Windows.Forms.Label lblCPUParameter54;
        private System.Windows.Forms.Label lblCPUParameter53;
        private System.Windows.Forms.Label lblCPUParameter52;
        private System.Windows.Forms.Label lblCPUParameter51;
        private System.Windows.Forms.Label lblCPUParameter50;
        private System.Windows.Forms.Label lblCPUParameter49;
        private System.Windows.Forms.Label lblCPUParameter48;
        private System.Windows.Forms.Label lblCPUParameter47;
        private System.Windows.Forms.Label lblCPUParameter46;
        private System.Windows.Forms.GroupBox grpTwinCAT;
        private System.Windows.Forms.Label lblCPUValue45;
        private System.Windows.Forms.Label lblCPUValue44;
        private System.Windows.Forms.Label lblCPUValue43;
        private System.Windows.Forms.Label lblCPUValue42;
        private System.Windows.Forms.Label lblCPUValue41;
        private System.Windows.Forms.Label lblCPUValue40;
        private System.Windows.Forms.Label lblCPUValue39;
        private System.Windows.Forms.Label lblCPUParameter45;
        private System.Windows.Forms.Label lblCPUParameter44;
        private System.Windows.Forms.Label lblCPUParameter43;
        private System.Windows.Forms.Label lblCPUParameter42;
        private System.Windows.Forms.Label lblCPUParameter41;
        private System.Windows.Forms.Label lblCPUParameter40;
        private System.Windows.Forms.Label lblCPUParameter39;
        private System.Windows.Forms.GroupBox grpOperatingSystem;
        private System.Windows.Forms.Label lblCPUValue38;
        private System.Windows.Forms.Label lblCPUValue37;
        private System.Windows.Forms.Label lblCPUValue36;
        private System.Windows.Forms.Label lblCPUParameter38;
        private System.Windows.Forms.Label lblCPUParameter37;
        public System.Windows.Forms.Label lblCPUParameter36;
        private System.Windows.Forms.GroupBox grpNetworkinterface2;
        private System.Windows.Forms.Label lblCPUValue35;
        private System.Windows.Forms.Label lblCPUValue34;
        private System.Windows.Forms.Label lblCPUValue32;
        private System.Windows.Forms.Label lblCPUValue33;
        private System.Windows.Forms.Label lblCPUParameter35;
        private System.Windows.Forms.Label lblCPUParameter34;
        private System.Windows.Forms.Label lblCPUParameter33;
        private System.Windows.Forms.Label lblCPUParameter32;
        private System.Windows.Forms.GroupBox grpNetworkinterface1;
        private System.Windows.Forms.Label lblCPUValue31;
        private System.Windows.Forms.Label lbCPUlValue30;
        private System.Windows.Forms.Label lblCPUValue29;
        private System.Windows.Forms.Label lblCPUValue28;
        private System.Windows.Forms.Label lblCPUParameter31;
        private System.Windows.Forms.Label lblCPUParameter30;
        private System.Windows.Forms.Label lblCPUParameter29;
        public System.Windows.Forms.Label lblCPUParameter28;
        private System.Windows.Forms.GroupBox grpDiskMnagement;
        private System.Windows.Forms.Label lblCPUValue23;
        private System.Windows.Forms.Label lblCPUValue22;
        private System.Windows.Forms.Label lblCPUValue21;
        private System.Windows.Forms.Label lblCPUValue20;
        private System.Windows.Forms.Label lblCPUValue19;
        private System.Windows.Forms.Label lblCPUValue18;
        private System.Windows.Forms.Label lblCPUParameter23;
        private System.Windows.Forms.Label lblCPUParameter22;
        private System.Windows.Forms.Label lblCPUParameter21;
        private System.Windows.Forms.Label lblCPUParameter20;
        private System.Windows.Forms.Label lblCPUParameter19;
        private System.Windows.Forms.Label lblCPUParameter18;
        private System.Windows.Forms.GroupBox grpMemory;
        private System.Windows.Forms.Label lblCPUValue27;
        private System.Windows.Forms.Label lblCPUValue26;
        private System.Windows.Forms.Label lblCPUValue25;
        private System.Windows.Forms.Label lblCPUValue24;
        private System.Windows.Forms.Label lblCPUParameter26;
        private System.Windows.Forms.Label lblCPUParameter27;
        private System.Windows.Forms.Label lblCPUParameter25;
        private System.Windows.Forms.Label lblCPUParameter24;
        private System.Windows.Forms.GroupBox grpHardwareData;
        private System.Windows.Forms.Label lblCPUValue17;
        private System.Windows.Forms.Label lblCPUValue16;
        private System.Windows.Forms.Label lblCPUValue15;
        private System.Windows.Forms.Label lblCPUValue14;
        private System.Windows.Forms.Label lblCPUValue13;
        private System.Windows.Forms.Label lblCPUValue12;
        private System.Windows.Forms.Label lblCPUValue11;
        private System.Windows.Forms.Label lblCPUValue10;
        private System.Windows.Forms.Label lblCPUValue9;
        private System.Windows.Forms.Label lblCPUValue8;
        private System.Windows.Forms.Label lblCPUParameter17;
        private System.Windows.Forms.Label lblCPUParameter16;
        private System.Windows.Forms.Label lblCPUParameter15;
        private System.Windows.Forms.Label lblCPUParameter14;
        private System.Windows.Forms.Label lblCPUParameter13;
        private System.Windows.Forms.Label lblCPUParameter12;
        private System.Windows.Forms.Label lblCPUParameter11;
        private System.Windows.Forms.Label lblCPUParameter10;
        private System.Windows.Forms.Label lblCPUParameter9;
        private System.Windows.Forms.Label lblCPUParameter8;
        private System.Windows.Forms.GroupBox grpOperationData;
        private System.Windows.Forms.Label lblCPUValue7;
        private System.Windows.Forms.Label lblCPUValue6;
        private System.Windows.Forms.Label lblCPUParameter7;
        private System.Windows.Forms.Label lblCPUParameter6;
        private System.Windows.Forms.GroupBox grpIdentityCard;
        private System.Windows.Forms.Label lblCPUValue5;
        private System.Windows.Forms.Label lblCPUValue4;
        private System.Windows.Forms.Label lblCPUValue3;
        private System.Windows.Forms.Label lblCPUValue2;
        private System.Windows.Forms.Label lblCPUValue1;
        private System.Windows.Forms.Label lblCPUParameter5;
        private System.Windows.Forms.Label lblCPUParameter4;
        private System.Windows.Forms.Label lblCPUParameter3;
        private System.Windows.Forms.Label lblCPUParameter2;
        private System.Windows.Forms.Label lblCPUValue0;
        private System.Windows.Forms.Label lblCPUParameter1;
        private System.Windows.Forms.Label lblCPUParameter0;
        private System.Windows.Forms.TabPage tabEncoderData;
        private System.Windows.Forms.GroupBox grpParameter;
        private System.Windows.Forms.Label lblEncVal24;
        private System.Windows.Forms.Label lblEncVal23;
        private System.Windows.Forms.Label lblEncPar24;
        private System.Windows.Forms.Label lblEncPar23;
        private System.Windows.Forms.Label lblEncVal22;
        private System.Windows.Forms.Label lblEncVal21;
        private System.Windows.Forms.Label lblEncVal20;
        private System.Windows.Forms.Label lblEncVal19;
        private System.Windows.Forms.Label lblEncVal18;
        private System.Windows.Forms.Label lblEncVal17;
        private System.Windows.Forms.Label lblEncVal16;
        private System.Windows.Forms.Label lblEncVal15;
        private System.Windows.Forms.Label lblEncVal14;
        private System.Windows.Forms.Label lblEncVal13;
        private System.Windows.Forms.Label lblEncPar22;
        private System.Windows.Forms.Label lblEncPar21;
        private System.Windows.Forms.Label lblEncPar20;
        private System.Windows.Forms.Label lblEncPar19;
        private System.Windows.Forms.Label lblEncPar18;
        private System.Windows.Forms.Label lblEncPar17;
        private System.Windows.Forms.Label lblEncPar16;
        private System.Windows.Forms.Label lblEncPar15;
        private System.Windows.Forms.Label lblEncPar14;
        private System.Windows.Forms.Label lblEncPar13;
        private System.Windows.Forms.GroupBox grpValue;
        private System.Windows.Forms.Label lblEncVal12;
        private System.Windows.Forms.Label lblEncVal11;
        private System.Windows.Forms.Label lblEncVal10;
        private System.Windows.Forms.Label lblEncVal9;
        private System.Windows.Forms.Label lblEncVal8;
        private System.Windows.Forms.Label lblEncVal7;
        private System.Windows.Forms.Label lblEncVal6;
        private System.Windows.Forms.Label lblEncVal5;
        private System.Windows.Forms.Label lblEncVal4;
        private System.Windows.Forms.Label lblEncPar12;
        private System.Windows.Forms.Label lblEncPar11;
        private System.Windows.Forms.Label lblEncPar10;
        private System.Windows.Forms.Label lblEncPar9;
        private System.Windows.Forms.Label lblEncPar8;
        private System.Windows.Forms.Label lblEncPar7;
        private System.Windows.Forms.Label lblEncPar6;
        private System.Windows.Forms.Label lblEncPar5;
        private System.Windows.Forms.Label lblEncPar4;
        private System.Windows.Forms.GroupBox grpConnection;
        private System.Windows.Forms.Label lblEncVal3;
        private System.Windows.Forms.Label lblEncVal2;
        private System.Windows.Forms.Label lblEncVal1;
        private System.Windows.Forms.Label lblEncPar3;
        private System.Windows.Forms.Label lblEncPar2;
        private System.Windows.Forms.Label lblEncVal0;
        private System.Windows.Forms.Label lblEncPar1;
        private System.Windows.Forms.Label lblEncPar0;
        private System.Windows.Forms.TabPage tabLogger;
    }
}