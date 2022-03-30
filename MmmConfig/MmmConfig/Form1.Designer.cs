namespace MmmConfig
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblConnStatus = new System.Windows.Forms.Label();
            this.txtNetId = new System.Windows.Forms.TextBox();
            this.lblNetId = new System.Windows.Forms.Label();
            this.lblPort = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.tWdTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTest = new System.Windows.Forms.Label();
            this.btnEnableMot1 = new System.Windows.Forms.Button();
            this.grpBoxMot1 = new System.Windows.Forms.GroupBox();
            this.grpBoxMot2 = new System.Windows.Forms.GroupBox();
            this.btnEnableMot2 = new System.Windows.Forms.Button();
            this.grpBoxMot3 = new System.Windows.Forms.GroupBox();
            this.btnEnableMot3 = new System.Windows.Forms.Button();
            this.grpBoxMot4 = new System.Windows.Forms.GroupBox();
            this.btnEnableMot4 = new System.Windows.Forms.Button();
            this.btnMoveFwMot1 = new System.Windows.Forms.Button();
            this.btnMoveFwMot2 = new System.Windows.Forms.Button();
            this.btnMoveFwMot3 = new System.Windows.Forms.Button();
            this.btnMoveFwMot4 = new System.Windows.Forms.Button();
            this.btnMoveBwMot1 = new System.Windows.Forms.Button();
            this.btnMoveBwMot2 = new System.Windows.Forms.Button();
            this.btnMoveBwMot3 = new System.Windows.Forms.Button();
            this.btnMoveBwMot4 = new System.Windows.Forms.Button();
            this.btnSyncOnMot1 = new System.Windows.Forms.Button();
            this.btnSyncOnMot2 = new System.Windows.Forms.Button();
            this.btnSyncOnMot3 = new System.Windows.Forms.Button();
            this.btnSyncOnMot4 = new System.Windows.Forms.Button();
            this.btnSetPosMot1 = new System.Windows.Forms.Button();
            this.btnSetPosMot2 = new System.Windows.Forms.Button();
            this.btnSetPosMot3 = new System.Windows.Forms.Button();
            this.btnSetPosMot4 = new System.Windows.Forms.Button();
            this.lblErrorStsMot1 = new System.Windows.Forms.Label();
            this.lblMovingStsMot1 = new System.Windows.Forms.Label();
            this.lblInSyncStsMot1 = new System.Windows.Forms.Label();
            this.lblSetPosOkStsMot1 = new System.Windows.Forms.Label();
            this.lblSetPosOkStsMot2 = new System.Windows.Forms.Label();
            this.lblInSyncStsMot2 = new System.Windows.Forms.Label();
            this.lblMovingStsMot2 = new System.Windows.Forms.Label();
            this.lblErrorStsMot2 = new System.Windows.Forms.Label();
            this.lblSetPosOkStsMot3 = new System.Windows.Forms.Label();
            this.lblInSyncStsMot3 = new System.Windows.Forms.Label();
            this.lblMovingStsMot3 = new System.Windows.Forms.Label();
            this.lblErrorStsMot3 = new System.Windows.Forms.Label();
            this.lblSetPosOkStsMot4 = new System.Windows.Forms.Label();
            this.lblInSyncStsMot4 = new System.Windows.Forms.Label();
            this.lblMovingStsMot4 = new System.Windows.Forms.Label();
            this.lblErrorStsMot4 = new System.Windows.Forms.Label();
            this.grpBoxMot1.SuspendLayout();
            this.grpBoxMot2.SuspendLayout();
            this.grpBoxMot3.SuspendLayout();
            this.grpBoxMot4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(174, 19);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblConnStatus
            // 
            this.lblConnStatus.AutoSize = true;
            this.lblConnStatus.Location = new System.Drawing.Point(94, 46);
            this.lblConnStatus.Name = "lblConnStatus";
            this.lblConnStatus.Size = new System.Drawing.Size(78, 13);
            this.lblConnStatus.TabIndex = 1;
            this.lblConnStatus.Text = "Not connected";
            // 
            // txtNetId
            // 
            this.txtNetId.Location = new System.Drawing.Point(51, 20);
            this.txtNetId.Name = "txtNetId";
            this.txtNetId.Size = new System.Drawing.Size(117, 20);
            this.txtNetId.TabIndex = 2;
            this.txtNetId.Text = "192.168.193.200.1.1";
            // 
            // lblNetId
            // 
            this.lblNetId.AutoSize = true;
            this.lblNetId.Location = new System.Drawing.Point(12, 24);
            this.lblNetId.Name = "lblNetId";
            this.lblNetId.Size = new System.Drawing.Size(35, 13);
            this.lblNetId.TabIndex = 3;
            this.lblNetId.Text = "NetID";
            this.lblNetId.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(12, 46);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(26, 13);
            this.lblPort.TabIndex = 4;
            this.lblPort.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(54, 43);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(34, 20);
            this.txtPort.TabIndex = 5;
            this.txtPort.Text = "851";
            // 
            // tWdTimer
            // 
            this.tWdTimer.Interval = 500;
            this.tWdTimer.Tick += new System.EventHandler(this.tWdTimer_Tick);
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(420, 27);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(26, 13);
            this.lblTest.TabIndex = 6;
            this.lblTest.Text = "Port";
            // 
            // btnEnableMot1
            // 
            this.btnEnableMot1.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEnableMot1.Location = new System.Drawing.Point(6, 30);
            this.btnEnableMot1.Name = "btnEnableMot1";
            this.btnEnableMot1.Size = new System.Drawing.Size(67, 23);
            this.btnEnableMot1.TabIndex = 7;
            this.btnEnableMot1.Text = "Enable";
            this.btnEnableMot1.UseVisualStyleBackColor = false;
            this.btnEnableMot1.Click += new System.EventHandler(this.btnEnableMot1_Click);
            // 
            // grpBoxMot1
            // 
            this.grpBoxMot1.BackColor = System.Drawing.Color.AliceBlue;
            this.grpBoxMot1.Controls.Add(this.lblSetPosOkStsMot1);
            this.grpBoxMot1.Controls.Add(this.lblInSyncStsMot1);
            this.grpBoxMot1.Controls.Add(this.lblMovingStsMot1);
            this.grpBoxMot1.Controls.Add(this.lblErrorStsMot1);
            this.grpBoxMot1.Controls.Add(this.btnSetPosMot1);
            this.grpBoxMot1.Controls.Add(this.btnSyncOnMot1);
            this.grpBoxMot1.Controls.Add(this.btnMoveBwMot1);
            this.grpBoxMot1.Controls.Add(this.btnMoveFwMot1);
            this.grpBoxMot1.Controls.Add(this.btnEnableMot1);
            this.grpBoxMot1.ForeColor = System.Drawing.Color.Black;
            this.grpBoxMot1.Location = new System.Drawing.Point(15, 97);
            this.grpBoxMot1.Name = "grpBoxMot1";
            this.grpBoxMot1.Size = new System.Drawing.Size(310, 263);
            this.grpBoxMot1.TabIndex = 8;
            this.grpBoxMot1.TabStop = false;
            this.grpBoxMot1.Text = "Motor #1";
            // 
            // grpBoxMot2
            // 
            this.grpBoxMot2.BackColor = System.Drawing.Color.AliceBlue;
            this.grpBoxMot2.Controls.Add(this.lblSetPosOkStsMot2);
            this.grpBoxMot2.Controls.Add(this.lblInSyncStsMot2);
            this.grpBoxMot2.Controls.Add(this.lblMovingStsMot2);
            this.grpBoxMot2.Controls.Add(this.lblErrorStsMot2);
            this.grpBoxMot2.Controls.Add(this.btnSetPosMot2);
            this.grpBoxMot2.Controls.Add(this.btnSyncOnMot2);
            this.grpBoxMot2.Controls.Add(this.btnMoveBwMot2);
            this.grpBoxMot2.Controls.Add(this.btnMoveFwMot2);
            this.grpBoxMot2.Controls.Add(this.btnEnableMot2);
            this.grpBoxMot2.ForeColor = System.Drawing.Color.Black;
            this.grpBoxMot2.Location = new System.Drawing.Point(331, 97);
            this.grpBoxMot2.Name = "grpBoxMot2";
            this.grpBoxMot2.Size = new System.Drawing.Size(310, 263);
            this.grpBoxMot2.TabIndex = 9;
            this.grpBoxMot2.TabStop = false;
            this.grpBoxMot2.Text = "Motor #2";
            // 
            // btnEnableMot2
            // 
            this.btnEnableMot2.Location = new System.Drawing.Point(6, 30);
            this.btnEnableMot2.Name = "btnEnableMot2";
            this.btnEnableMot2.Size = new System.Drawing.Size(67, 23);
            this.btnEnableMot2.TabIndex = 7;
            this.btnEnableMot2.Text = "Enable";
            this.btnEnableMot2.UseVisualStyleBackColor = true;
            this.btnEnableMot2.Click += new System.EventHandler(this.btnEnableMot2_Click);
            // 
            // grpBoxMot3
            // 
            this.grpBoxMot3.BackColor = System.Drawing.Color.AliceBlue;
            this.grpBoxMot3.Controls.Add(this.lblSetPosOkStsMot3);
            this.grpBoxMot3.Controls.Add(this.lblInSyncStsMot3);
            this.grpBoxMot3.Controls.Add(this.lblMovingStsMot3);
            this.grpBoxMot3.Controls.Add(this.lblErrorStsMot3);
            this.grpBoxMot3.Controls.Add(this.btnSetPosMot3);
            this.grpBoxMot3.Controls.Add(this.btnSyncOnMot3);
            this.grpBoxMot3.Controls.Add(this.btnMoveBwMot3);
            this.grpBoxMot3.Controls.Add(this.btnMoveFwMot3);
            this.grpBoxMot3.Controls.Add(this.btnEnableMot3);
            this.grpBoxMot3.ForeColor = System.Drawing.Color.Black;
            this.grpBoxMot3.Location = new System.Drawing.Point(15, 366);
            this.grpBoxMot3.Name = "grpBoxMot3";
            this.grpBoxMot3.Size = new System.Drawing.Size(310, 263);
            this.grpBoxMot3.TabIndex = 10;
            this.grpBoxMot3.TabStop = false;
            this.grpBoxMot3.Text = "Motor #3";
            // 
            // btnEnableMot3
            // 
            this.btnEnableMot3.Location = new System.Drawing.Point(6, 30);
            this.btnEnableMot3.Name = "btnEnableMot3";
            this.btnEnableMot3.Size = new System.Drawing.Size(67, 23);
            this.btnEnableMot3.TabIndex = 7;
            this.btnEnableMot3.Text = "Enable";
            this.btnEnableMot3.UseVisualStyleBackColor = true;
            this.btnEnableMot3.Click += new System.EventHandler(this.btnEnableMot3_Click);
            // 
            // grpBoxMot4
            // 
            this.grpBoxMot4.BackColor = System.Drawing.Color.AliceBlue;
            this.grpBoxMot4.Controls.Add(this.lblSetPosOkStsMot4);
            this.grpBoxMot4.Controls.Add(this.lblInSyncStsMot4);
            this.grpBoxMot4.Controls.Add(this.lblMovingStsMot4);
            this.grpBoxMot4.Controls.Add(this.lblErrorStsMot4);
            this.grpBoxMot4.Controls.Add(this.btnSetPosMot4);
            this.grpBoxMot4.Controls.Add(this.btnSyncOnMot4);
            this.grpBoxMot4.Controls.Add(this.btnMoveBwMot4);
            this.grpBoxMot4.Controls.Add(this.btnMoveFwMot4);
            this.grpBoxMot4.Controls.Add(this.btnEnableMot4);
            this.grpBoxMot4.ForeColor = System.Drawing.Color.Black;
            this.grpBoxMot4.Location = new System.Drawing.Point(331, 366);
            this.grpBoxMot4.Name = "grpBoxMot4";
            this.grpBoxMot4.Size = new System.Drawing.Size(310, 263);
            this.grpBoxMot4.TabIndex = 9;
            this.grpBoxMot4.TabStop = false;
            this.grpBoxMot4.Text = "Motor #4";
            // 
            // btnEnableMot4
            // 
            this.btnEnableMot4.Location = new System.Drawing.Point(6, 30);
            this.btnEnableMot4.Name = "btnEnableMot4";
            this.btnEnableMot4.Size = new System.Drawing.Size(67, 23);
            this.btnEnableMot4.TabIndex = 7;
            this.btnEnableMot4.Text = "Enable";
            this.btnEnableMot4.UseVisualStyleBackColor = true;
            this.btnEnableMot4.Click += new System.EventHandler(this.btnEnableMot4_Click);
            // 
            // btnMoveFwMot1
            // 
            this.btnMoveFwMot1.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMoveFwMot1.Location = new System.Drawing.Point(6, 59);
            this.btnMoveFwMot1.Name = "btnMoveFwMot1";
            this.btnMoveFwMot1.Size = new System.Drawing.Size(67, 23);
            this.btnMoveFwMot1.TabIndex = 8;
            this.btnMoveFwMot1.Text = "Move FW";
            this.btnMoveFwMot1.UseVisualStyleBackColor = false;
            this.btnMoveFwMot1.Click += new System.EventHandler(this.btnMoveFwMot1_Click);
            // 
            // btnMoveFwMot2
            // 
            this.btnMoveFwMot2.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMoveFwMot2.Location = new System.Drawing.Point(6, 59);
            this.btnMoveFwMot2.Name = "btnMoveFwMot2";
            this.btnMoveFwMot2.Size = new System.Drawing.Size(67, 23);
            this.btnMoveFwMot2.TabIndex = 9;
            this.btnMoveFwMot2.Text = "Move FW";
            this.btnMoveFwMot2.UseVisualStyleBackColor = false;
            this.btnMoveFwMot2.Click += new System.EventHandler(this.btnMoveFwMot2_Click);
            // 
            // btnMoveFwMot3
            // 
            this.btnMoveFwMot3.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMoveFwMot3.Location = new System.Drawing.Point(6, 59);
            this.btnMoveFwMot3.Name = "btnMoveFwMot3";
            this.btnMoveFwMot3.Size = new System.Drawing.Size(67, 23);
            this.btnMoveFwMot3.TabIndex = 10;
            this.btnMoveFwMot3.Text = "Move FW";
            this.btnMoveFwMot3.UseVisualStyleBackColor = false;
            this.btnMoveFwMot3.Click += new System.EventHandler(this.btnMoveFwMot3_Click);
            // 
            // btnMoveFwMot4
            // 
            this.btnMoveFwMot4.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMoveFwMot4.Location = new System.Drawing.Point(6, 59);
            this.btnMoveFwMot4.Name = "btnMoveFwMot4";
            this.btnMoveFwMot4.Size = new System.Drawing.Size(67, 23);
            this.btnMoveFwMot4.TabIndex = 11;
            this.btnMoveFwMot4.Text = "Move FW";
            this.btnMoveFwMot4.UseVisualStyleBackColor = false;
            this.btnMoveFwMot4.Click += new System.EventHandler(this.btnMoveFwMot4_Click);
            // 
            // btnMoveBwMot1
            // 
            this.btnMoveBwMot1.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMoveBwMot1.Location = new System.Drawing.Point(6, 88);
            this.btnMoveBwMot1.Name = "btnMoveBwMot1";
            this.btnMoveBwMot1.Size = new System.Drawing.Size(67, 23);
            this.btnMoveBwMot1.TabIndex = 9;
            this.btnMoveBwMot1.Text = "Move BW";
            this.btnMoveBwMot1.UseVisualStyleBackColor = false;
            this.btnMoveBwMot1.Click += new System.EventHandler(this.btnMoveBwMot1_Click);
            // 
            // btnMoveBwMot2
            // 
            this.btnMoveBwMot2.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMoveBwMot2.Location = new System.Drawing.Point(6, 88);
            this.btnMoveBwMot2.Name = "btnMoveBwMot2";
            this.btnMoveBwMot2.Size = new System.Drawing.Size(67, 23);
            this.btnMoveBwMot2.TabIndex = 10;
            this.btnMoveBwMot2.Text = "Move BW";
            this.btnMoveBwMot2.UseVisualStyleBackColor = false;
            this.btnMoveBwMot2.Click += new System.EventHandler(this.btnMoveBwMot2_Click);
            // 
            // btnMoveBwMot3
            // 
            this.btnMoveBwMot3.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMoveBwMot3.Location = new System.Drawing.Point(6, 88);
            this.btnMoveBwMot3.Name = "btnMoveBwMot3";
            this.btnMoveBwMot3.Size = new System.Drawing.Size(67, 23);
            this.btnMoveBwMot3.TabIndex = 11;
            this.btnMoveBwMot3.Text = "Move BW";
            this.btnMoveBwMot3.UseVisualStyleBackColor = false;
            this.btnMoveBwMot3.Click += new System.EventHandler(this.btnMoveBwMot3_Click);
            // 
            // btnMoveBwMot4
            // 
            this.btnMoveBwMot4.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMoveBwMot4.Location = new System.Drawing.Point(6, 88);
            this.btnMoveBwMot4.Name = "btnMoveBwMot4";
            this.btnMoveBwMot4.Size = new System.Drawing.Size(67, 23);
            this.btnMoveBwMot4.TabIndex = 12;
            this.btnMoveBwMot4.Text = "Move BW";
            this.btnMoveBwMot4.UseVisualStyleBackColor = false;
            this.btnMoveBwMot4.Click += new System.EventHandler(this.btnMoveBwMot4_Click);
            // 
            // btnSyncOnMot1
            // 
            this.btnSyncOnMot1.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSyncOnMot1.Location = new System.Drawing.Point(6, 117);
            this.btnSyncOnMot1.Name = "btnSyncOnMot1";
            this.btnSyncOnMot1.Size = new System.Drawing.Size(67, 23);
            this.btnSyncOnMot1.TabIndex = 10;
            this.btnSyncOnMot1.Text = "Sync On";
            this.btnSyncOnMot1.UseVisualStyleBackColor = false;
            this.btnSyncOnMot1.Click += new System.EventHandler(this.btnSyncOnMot1_Click);
            // 
            // btnSyncOnMot2
            // 
            this.btnSyncOnMot2.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSyncOnMot2.Location = new System.Drawing.Point(6, 117);
            this.btnSyncOnMot2.Name = "btnSyncOnMot2";
            this.btnSyncOnMot2.Size = new System.Drawing.Size(67, 23);
            this.btnSyncOnMot2.TabIndex = 11;
            this.btnSyncOnMot2.Text = "Sync On";
            this.btnSyncOnMot2.UseVisualStyleBackColor = false;
            this.btnSyncOnMot2.Click += new System.EventHandler(this.btnSyncOnMot2_Click);
            // 
            // btnSyncOnMot3
            // 
            this.btnSyncOnMot3.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSyncOnMot3.Location = new System.Drawing.Point(6, 117);
            this.btnSyncOnMot3.Name = "btnSyncOnMot3";
            this.btnSyncOnMot3.Size = new System.Drawing.Size(67, 23);
            this.btnSyncOnMot3.TabIndex = 12;
            this.btnSyncOnMot3.Text = "Sync On";
            this.btnSyncOnMot3.UseVisualStyleBackColor = false;
            this.btnSyncOnMot3.Click += new System.EventHandler(this.btnSyncOnMot3_Click);
            // 
            // btnSyncOnMot4
            // 
            this.btnSyncOnMot4.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSyncOnMot4.Location = new System.Drawing.Point(6, 117);
            this.btnSyncOnMot4.Name = "btnSyncOnMot4";
            this.btnSyncOnMot4.Size = new System.Drawing.Size(67, 23);
            this.btnSyncOnMot4.TabIndex = 13;
            this.btnSyncOnMot4.Text = "Sync On";
            this.btnSyncOnMot4.UseVisualStyleBackColor = false;
            this.btnSyncOnMot4.Click += new System.EventHandler(this.btnSyncOnMot4_Click);
            // 
            // btnSetPosMot1
            // 
            this.btnSetPosMot1.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSetPosMot1.Location = new System.Drawing.Point(6, 146);
            this.btnSetPosMot1.Name = "btnSetPosMot1";
            this.btnSetPosMot1.Size = new System.Drawing.Size(67, 23);
            this.btnSetPosMot1.TabIndex = 11;
            this.btnSetPosMot1.Text = "Set Pos";
            this.btnSetPosMot1.UseVisualStyleBackColor = false;
            this.btnSetPosMot1.Click += new System.EventHandler(this.btnSetPosMot1_Click);
            // 
            // btnSetPosMot2
            // 
            this.btnSetPosMot2.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSetPosMot2.Location = new System.Drawing.Point(6, 146);
            this.btnSetPosMot2.Name = "btnSetPosMot2";
            this.btnSetPosMot2.Size = new System.Drawing.Size(67, 23);
            this.btnSetPosMot2.TabIndex = 12;
            this.btnSetPosMot2.Text = "Set Pos";
            this.btnSetPosMot2.UseVisualStyleBackColor = false;
            this.btnSetPosMot2.Click += new System.EventHandler(this.btnSetPosMot2_Click);
            // 
            // btnSetPosMot3
            // 
            this.btnSetPosMot3.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSetPosMot3.Location = new System.Drawing.Point(6, 146);
            this.btnSetPosMot3.Name = "btnSetPosMot3";
            this.btnSetPosMot3.Size = new System.Drawing.Size(67, 23);
            this.btnSetPosMot3.TabIndex = 13;
            this.btnSetPosMot3.Text = "Set Pos";
            this.btnSetPosMot3.UseVisualStyleBackColor = false;
            this.btnSetPosMot3.Click += new System.EventHandler(this.btnSetPosMot3_Click);
            // 
            // btnSetPosMot4
            // 
            this.btnSetPosMot4.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSetPosMot4.Location = new System.Drawing.Point(6, 146);
            this.btnSetPosMot4.Name = "btnSetPosMot4";
            this.btnSetPosMot4.Size = new System.Drawing.Size(67, 23);
            this.btnSetPosMot4.TabIndex = 14;
            this.btnSetPosMot4.Text = "Set Pos";
            this.btnSetPosMot4.UseVisualStyleBackColor = false;
            this.btnSetPosMot4.Click += new System.EventHandler(this.btnSetPosMot4_Click);
            // 
            // lblErrorStsMot1
            // 
            this.lblErrorStsMot1.BackColor = System.Drawing.Color.LightGray;
            this.lblErrorStsMot1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrorStsMot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStsMot1.Location = new System.Drawing.Point(237, 30);
            this.lblErrorStsMot1.Name = "lblErrorStsMot1";
            this.lblErrorStsMot1.Size = new System.Drawing.Size(67, 23);
            this.lblErrorStsMot1.TabIndex = 12;
            this.lblErrorStsMot1.Text = "Error";
            this.lblErrorStsMot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovingStsMot1
            // 
            this.lblMovingStsMot1.BackColor = System.Drawing.Color.LightGray;
            this.lblMovingStsMot1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMovingStsMot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovingStsMot1.Location = new System.Drawing.Point(237, 59);
            this.lblMovingStsMot1.Name = "lblMovingStsMot1";
            this.lblMovingStsMot1.Size = new System.Drawing.Size(67, 23);
            this.lblMovingStsMot1.TabIndex = 13;
            this.lblMovingStsMot1.Text = "Moving";
            this.lblMovingStsMot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInSyncStsMot1
            // 
            this.lblInSyncStsMot1.BackColor = System.Drawing.Color.LightGray;
            this.lblInSyncStsMot1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInSyncStsMot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInSyncStsMot1.Location = new System.Drawing.Point(237, 88);
            this.lblInSyncStsMot1.Name = "lblInSyncStsMot1";
            this.lblInSyncStsMot1.Size = new System.Drawing.Size(67, 23);
            this.lblInSyncStsMot1.TabIndex = 14;
            this.lblInSyncStsMot1.Text = "In Sync";
            this.lblInSyncStsMot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSetPosOkStsMot1
            // 
            this.lblSetPosOkStsMot1.BackColor = System.Drawing.Color.LightGray;
            this.lblSetPosOkStsMot1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetPosOkStsMot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPosOkStsMot1.Location = new System.Drawing.Point(237, 117);
            this.lblSetPosOkStsMot1.Name = "lblSetPosOkStsMot1";
            this.lblSetPosOkStsMot1.Size = new System.Drawing.Size(67, 23);
            this.lblSetPosOkStsMot1.TabIndex = 15;
            this.lblSetPosOkStsMot1.Text = "Set Pos Ok";
            this.lblSetPosOkStsMot1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSetPosOkStsMot2
            // 
            this.lblSetPosOkStsMot2.BackColor = System.Drawing.Color.LightGray;
            this.lblSetPosOkStsMot2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetPosOkStsMot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPosOkStsMot2.Location = new System.Drawing.Point(237, 117);
            this.lblSetPosOkStsMot2.Name = "lblSetPosOkStsMot2";
            this.lblSetPosOkStsMot2.Size = new System.Drawing.Size(67, 23);
            this.lblSetPosOkStsMot2.TabIndex = 19;
            this.lblSetPosOkStsMot2.Text = "Set Pos Ok";
            this.lblSetPosOkStsMot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInSyncStsMot2
            // 
            this.lblInSyncStsMot2.BackColor = System.Drawing.Color.LightGray;
            this.lblInSyncStsMot2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInSyncStsMot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInSyncStsMot2.Location = new System.Drawing.Point(237, 88);
            this.lblInSyncStsMot2.Name = "lblInSyncStsMot2";
            this.lblInSyncStsMot2.Size = new System.Drawing.Size(67, 23);
            this.lblInSyncStsMot2.TabIndex = 18;
            this.lblInSyncStsMot2.Text = "In Sync";
            this.lblInSyncStsMot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovingStsMot2
            // 
            this.lblMovingStsMot2.BackColor = System.Drawing.Color.LightGray;
            this.lblMovingStsMot2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMovingStsMot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovingStsMot2.Location = new System.Drawing.Point(237, 59);
            this.lblMovingStsMot2.Name = "lblMovingStsMot2";
            this.lblMovingStsMot2.Size = new System.Drawing.Size(67, 23);
            this.lblMovingStsMot2.TabIndex = 17;
            this.lblMovingStsMot2.Text = "Moving";
            this.lblMovingStsMot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorStsMot2
            // 
            this.lblErrorStsMot2.BackColor = System.Drawing.Color.LightGray;
            this.lblErrorStsMot2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrorStsMot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStsMot2.Location = new System.Drawing.Point(237, 30);
            this.lblErrorStsMot2.Name = "lblErrorStsMot2";
            this.lblErrorStsMot2.Size = new System.Drawing.Size(67, 23);
            this.lblErrorStsMot2.TabIndex = 16;
            this.lblErrorStsMot2.Text = "Error";
            this.lblErrorStsMot2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSetPosOkStsMot3
            // 
            this.lblSetPosOkStsMot3.BackColor = System.Drawing.Color.LightGray;
            this.lblSetPosOkStsMot3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetPosOkStsMot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPosOkStsMot3.Location = new System.Drawing.Point(237, 117);
            this.lblSetPosOkStsMot3.Name = "lblSetPosOkStsMot3";
            this.lblSetPosOkStsMot3.Size = new System.Drawing.Size(67, 23);
            this.lblSetPosOkStsMot3.TabIndex = 19;
            this.lblSetPosOkStsMot3.Text = "Set Pos Ok";
            this.lblSetPosOkStsMot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInSyncStsMot3
            // 
            this.lblInSyncStsMot3.BackColor = System.Drawing.Color.LightGray;
            this.lblInSyncStsMot3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInSyncStsMot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInSyncStsMot3.Location = new System.Drawing.Point(237, 88);
            this.lblInSyncStsMot3.Name = "lblInSyncStsMot3";
            this.lblInSyncStsMot3.Size = new System.Drawing.Size(67, 23);
            this.lblInSyncStsMot3.TabIndex = 18;
            this.lblInSyncStsMot3.Text = "In Sync";
            this.lblInSyncStsMot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovingStsMot3
            // 
            this.lblMovingStsMot3.BackColor = System.Drawing.Color.LightGray;
            this.lblMovingStsMot3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMovingStsMot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovingStsMot3.Location = new System.Drawing.Point(237, 59);
            this.lblMovingStsMot3.Name = "lblMovingStsMot3";
            this.lblMovingStsMot3.Size = new System.Drawing.Size(67, 23);
            this.lblMovingStsMot3.TabIndex = 17;
            this.lblMovingStsMot3.Text = "Moving";
            this.lblMovingStsMot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorStsMot3
            // 
            this.lblErrorStsMot3.BackColor = System.Drawing.Color.LightGray;
            this.lblErrorStsMot3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrorStsMot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStsMot3.Location = new System.Drawing.Point(237, 30);
            this.lblErrorStsMot3.Name = "lblErrorStsMot3";
            this.lblErrorStsMot3.Size = new System.Drawing.Size(67, 23);
            this.lblErrorStsMot3.TabIndex = 16;
            this.lblErrorStsMot3.Text = "Error";
            this.lblErrorStsMot3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSetPosOkStsMot4
            // 
            this.lblSetPosOkStsMot4.BackColor = System.Drawing.Color.LightGray;
            this.lblSetPosOkStsMot4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSetPosOkStsMot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetPosOkStsMot4.Location = new System.Drawing.Point(237, 117);
            this.lblSetPosOkStsMot4.Name = "lblSetPosOkStsMot4";
            this.lblSetPosOkStsMot4.Size = new System.Drawing.Size(67, 23);
            this.lblSetPosOkStsMot4.TabIndex = 19;
            this.lblSetPosOkStsMot4.Text = "Set Pos Ok";
            this.lblSetPosOkStsMot4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInSyncStsMot4
            // 
            this.lblInSyncStsMot4.BackColor = System.Drawing.Color.LightGray;
            this.lblInSyncStsMot4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInSyncStsMot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInSyncStsMot4.Location = new System.Drawing.Point(237, 88);
            this.lblInSyncStsMot4.Name = "lblInSyncStsMot4";
            this.lblInSyncStsMot4.Size = new System.Drawing.Size(67, 23);
            this.lblInSyncStsMot4.TabIndex = 18;
            this.lblInSyncStsMot4.Text = "In Sync";
            this.lblInSyncStsMot4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMovingStsMot4
            // 
            this.lblMovingStsMot4.BackColor = System.Drawing.Color.LightGray;
            this.lblMovingStsMot4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMovingStsMot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovingStsMot4.Location = new System.Drawing.Point(237, 59);
            this.lblMovingStsMot4.Name = "lblMovingStsMot4";
            this.lblMovingStsMot4.Size = new System.Drawing.Size(67, 23);
            this.lblMovingStsMot4.TabIndex = 17;
            this.lblMovingStsMot4.Text = "Moving";
            this.lblMovingStsMot4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblErrorStsMot4
            // 
            this.lblErrorStsMot4.BackColor = System.Drawing.Color.LightGray;
            this.lblErrorStsMot4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblErrorStsMot4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorStsMot4.Location = new System.Drawing.Point(237, 30);
            this.lblErrorStsMot4.Name = "lblErrorStsMot4";
            this.lblErrorStsMot4.Size = new System.Drawing.Size(67, 23);
            this.lblErrorStsMot4.TabIndex = 16;
            this.lblErrorStsMot4.Text = "Error";
            this.lblErrorStsMot4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 646);
            this.Controls.Add(this.grpBoxMot4);
            this.Controls.Add(this.grpBoxMot3);
            this.Controls.Add(this.grpBoxMot2);
            this.Controls.Add(this.grpBoxMot1);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.lblPort);
            this.Controls.Add(this.lblNetId);
            this.Controls.Add(this.txtNetId);
            this.Controls.Add(this.lblConnStatus);
            this.Controls.Add(this.btnConnect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpBoxMot1.ResumeLayout(false);
            this.grpBoxMot2.ResumeLayout(false);
            this.grpBoxMot3.ResumeLayout(false);
            this.grpBoxMot4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lblConnStatus;
        private System.Windows.Forms.TextBox txtNetId;
        private System.Windows.Forms.Label lblNetId;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.Timer tWdTimer;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Button btnEnableMot1;
        private System.Windows.Forms.GroupBox grpBoxMot1;
        private System.Windows.Forms.GroupBox grpBoxMot2;
        private System.Windows.Forms.Button btnEnableMot2;
        private System.Windows.Forms.GroupBox grpBoxMot3;
        private System.Windows.Forms.Button btnEnableMot3;
        private System.Windows.Forms.GroupBox grpBoxMot4;
        private System.Windows.Forms.Button btnEnableMot4;
        private System.Windows.Forms.Button btnMoveFwMot1;
        private System.Windows.Forms.Button btnMoveFwMot2;
        private System.Windows.Forms.Button btnMoveFwMot3;
        private System.Windows.Forms.Button btnMoveFwMot4;
        private System.Windows.Forms.Button btnMoveBwMot1;
        private System.Windows.Forms.Button btnMoveBwMot2;
        private System.Windows.Forms.Button btnMoveBwMot3;
        private System.Windows.Forms.Button btnMoveBwMot4;
        private System.Windows.Forms.Button btnSyncOnMot1;
        private System.Windows.Forms.Button btnSyncOnMot2;
        private System.Windows.Forms.Button btnSyncOnMot3;
        private System.Windows.Forms.Button btnSyncOnMot4;
        private System.Windows.Forms.Button btnSetPosMot1;
        private System.Windows.Forms.Button btnSetPosMot2;
        private System.Windows.Forms.Button btnSetPosMot3;
        private System.Windows.Forms.Button btnSetPosMot4;
        private System.Windows.Forms.Label lblSetPosOkStsMot1;
        private System.Windows.Forms.Label lblInSyncStsMot1;
        private System.Windows.Forms.Label lblMovingStsMot1;
        private System.Windows.Forms.Label lblErrorStsMot1;
        private System.Windows.Forms.Label lblSetPosOkStsMot2;
        private System.Windows.Forms.Label lblInSyncStsMot2;
        private System.Windows.Forms.Label lblMovingStsMot2;
        private System.Windows.Forms.Label lblErrorStsMot2;
        private System.Windows.Forms.Label lblSetPosOkStsMot3;
        private System.Windows.Forms.Label lblInSyncStsMot3;
        private System.Windows.Forms.Label lblMovingStsMot3;
        private System.Windows.Forms.Label lblErrorStsMot3;
        private System.Windows.Forms.Label lblSetPosOkStsMot4;
        private System.Windows.Forms.Label lblInSyncStsMot4;
        private System.Windows.Forms.Label lblMovingStsMot4;
        private System.Windows.Forms.Label lblErrorStsMot4;
    }
}

