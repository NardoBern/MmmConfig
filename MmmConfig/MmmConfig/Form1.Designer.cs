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
            this.tUpdateData = new System.Windows.Forms.Timer(this.components);
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
            // tUpdateData
            // 
            this.tUpdateData.Interval = 250;
            this.tUpdateData.Tick += new System.EventHandler(this.tUpdateData_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.Timer tUpdateData;
    }
}

