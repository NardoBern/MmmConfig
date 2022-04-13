
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
            this.grpLoadFromCpu = new System.Windows.Forms.GroupBox();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.prgConnWd = new System.Windows.Forms.ProgressBar();
            this.lblNetId = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblPort = new System.Windows.Forms.Label();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.txtNetId = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFromToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tWdTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogReader)).BeginInit();
            this.grpOpDescr.SuspendLayout();
            this.grpError.SuspendLayout();
            this.grpLoadFromCpu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.dgvLogReader.Location = new System.Drawing.Point(12, 194);
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
            this.grpOpDescr.Location = new System.Drawing.Point(806, 195);
            this.grpOpDescr.Name = "grpOpDescr";
            this.grpOpDescr.Size = new System.Drawing.Size(414, 196);
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
            this.grpError.Location = new System.Drawing.Point(806, 393);
            this.grpError.Name = "grpError";
            this.grpError.Size = new System.Drawing.Size(418, 461);
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
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Location = new System.Drawing.Point(100, 48);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 50;
            this.btnRefresh.Text = "Load";
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
            this.prgBarGetInfo.Location = new System.Drawing.Point(100, 97);
            this.prgBarGetInfo.Name = "prgBarGetInfo";
            this.prgBarGetInfo.Size = new System.Drawing.Size(75, 15);
            this.prgBarGetInfo.TabIndex = 51;
            // 
            // btnStopRefresh
            // 
            this.btnStopRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopRefresh.Location = new System.Drawing.Point(100, 120);
            this.btnStopRefresh.Name = "btnStopRefresh";
            this.btnStopRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnStopRefresh.TabIndex = 52;
            this.btnStopRefresh.Text = "Cancel";
            this.btnStopRefresh.UseVisualStyleBackColor = true;
            this.btnStopRefresh.Click += new System.EventHandler(this.btnStopRefresh_Click);
            // 
            // grpLoadFromCpu
            // 
            this.grpLoadFromCpu.Controls.Add(this.lblInProgress);
            this.grpLoadFromCpu.Controls.Add(this.btnStopRefresh);
            this.grpLoadFromCpu.Controls.Add(this.prgConnWd);
            this.grpLoadFromCpu.Controls.Add(this.lblNetId);
            this.grpLoadFromCpu.Controls.Add(this.txtPort);
            this.grpLoadFromCpu.Controls.Add(this.prgBarGetInfo);
            this.grpLoadFromCpu.Controls.Add(this.btnConnect);
            this.grpLoadFromCpu.Controls.Add(this.btnRefresh);
            this.grpLoadFromCpu.Controls.Add(this.lblPort);
            this.grpLoadFromCpu.Controls.Add(this.lblConnStatus);
            this.grpLoadFromCpu.Controls.Add(this.txtNetId);
            this.grpLoadFromCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoadFromCpu.Location = new System.Drawing.Point(12, 33);
            this.grpLoadFromCpu.Name = "grpLoadFromCpu";
            this.grpLoadFromCpu.Size = new System.Drawing.Size(201, 153);
            this.grpLoadFromCpu.TabIndex = 54;
            this.grpLoadFromCpu.TabStop = false;
            this.grpLoadFromCpu.Text = "Load from CPU";
            // 
            // lblInProgress
            // 
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProgress.Location = new System.Drawing.Point(103, 81);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(68, 13);
            this.lblInProgress.TabIndex = 57;
            this.lblInProgress.Text = "In progress...";
            this.lblInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // prgConnWd
            // 
            this.prgConnWd.Location = new System.Drawing.Point(9, 124);
            this.prgConnWd.Name = "prgConnWd";
            this.prgConnWd.Size = new System.Drawing.Size(73, 15);
            this.prgConnWd.Step = 1;
            this.prgConnWd.TabIndex = 61;
            // 
            // lblNetId
            // 
            this.lblNetId.AutoSize = true;
            this.lblNetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetId.Location = new System.Drawing.Point(6, 30);
            this.lblNetId.Name = "lblNetId";
            this.lblNetId.Size = new System.Drawing.Size(35, 13);
            this.lblNetId.TabIndex = 58;
            this.lblNetId.Text = "NetID";
            // 
            // txtPort
            // 
            this.txtPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.Location = new System.Drawing.Point(48, 49);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(34, 20);
            this.txtPort.TabIndex = 60;
            this.txtPort.Text = "851";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(9, 73);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 55;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPort.Location = new System.Drawing.Point(6, 52);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 59;
            this.lblPort.Text = "Port";
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnStatus.Location = new System.Drawing.Point(7, 103);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(78, 13);
            this.lblConnStatus.TabIndex = 56;
            this.lblConnStatus.Text = "Not connected";
            // 
            // txtNetId
            // 
            this.txtNetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetId.Location = new System.Drawing.Point(45, 26);
            this.txtNetId.Name = "txtNetId";
            this.txtNetId.Size = new System.Drawing.Size(117, 20);
            this.txtNetId.TabIndex = 57;
            this.txtNetId.Text = "192.168.193.200.1.1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1234, 25);
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
            this.saveToToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToToolStripMenuItem.Text = "Save To...";
            this.saveToToolStripMenuItem.Click += new System.EventHandler(this.saveToToolStripMenuItem_Click);
            // 
            // openFromToolStripMenuItem
            // 
            this.openFromToolStripMenuItem.Name = "openFromToolStripMenuItem";
            this.openFromToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openFromToolStripMenuItem.Text = "Open From...";
            this.openFromToolStripMenuItem.Click += new System.EventHandler(this.openFromToolStripMenuItem_Click);
            // 
            // tWdTimer
            // 
            this.tWdTimer.Interval = 500;
            this.tWdTimer.Tick += new System.EventHandler(this.tWdTimer_Tick);
            // 
            // LogReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1234, 862);
            this.Controls.Add(this.grpLoadFromCpu);
            this.Controls.Add(this.grpError);
            this.Controls.Add(this.grpOpDescr);
            this.Controls.Add(this.dgvLogReader);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "LogReader";
            this.Text = "LogReader";
            this.Load += new System.EventHandler(this.LogReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogReader)).EndInit();
            this.grpOpDescr.ResumeLayout(false);
            this.grpError.ResumeLayout(false);
            this.grpLoadFromCpu.ResumeLayout(false);
            this.grpLoadFromCpu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpLoadFromCpu;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.ProgressBar prgConnWd;
        private System.Windows.Forms.Label lblNetId;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.Label lblConnStatus;
        private System.Windows.Forms.TextBox txtNetId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFromToolStripMenuItem;
        private System.Windows.Forms.Timer tWdTimer;
    }
}