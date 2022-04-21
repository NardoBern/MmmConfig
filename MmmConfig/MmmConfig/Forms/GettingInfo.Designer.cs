
namespace MmmConfig.Forms
{
    partial class GettingInfo
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
            this.lblGetInfo = new System.Windows.Forms.Label();
            this.prgBarGetInfo = new System.Windows.Forms.ProgressBar();
            this.btnGetInfo = new System.Windows.Forms.Button();
            this.checkThread = new System.Windows.Forms.Timer(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGetInfo
            // 
            this.lblGetInfo.AutoSize = true;
            this.lblGetInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGetInfo.Location = new System.Drawing.Point(13, 13);
            this.lblGetInfo.Name = "lblGetInfo";
            this.lblGetInfo.Size = new System.Drawing.Size(243, 25);
            this.lblGetInfo.TabIndex = 0;
            this.lblGetInfo.Text = "Retrieving information";
            // 
            // prgBarGetInfo
            // 
            this.prgBarGetInfo.Location = new System.Drawing.Point(18, 48);
            this.prgBarGetInfo.Name = "prgBarGetInfo";
            this.prgBarGetInfo.Size = new System.Drawing.Size(238, 23);
            this.prgBarGetInfo.Step = 1;
            this.prgBarGetInfo.TabIndex = 1;
            // 
            // btnGetInfo
            // 
            this.btnGetInfo.Location = new System.Drawing.Point(18, 83);
            this.btnGetInfo.Name = "btnGetInfo";
            this.btnGetInfo.Size = new System.Drawing.Size(75, 23);
            this.btnGetInfo.TabIndex = 2;
            this.btnGetInfo.Text = "Get Info";
            this.btnGetInfo.UseVisualStyleBackColor = true;
            this.btnGetInfo.Click += new System.EventHandler(this.btnGetInfo_Click);
            // 
            // checkThread
            // 
            this.checkThread.Interval = 250;
            this.checkThread.Tick += new System.EventHandler(this.checkThread_Tick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(180, 83);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // GettingInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 118);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGetInfo);
            this.Controls.Add(this.prgBarGetInfo);
            this.Controls.Add(this.lblGetInfo);
            this.Name = "GettingInfo";
            this.Text = "Retrieving Information";
            this.Load += new System.EventHandler(this.GettingInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGetInfo;
        private System.Windows.Forms.ProgressBar prgBarGetInfo;
        private System.Windows.Forms.Button btnGetInfo;
        private System.Windows.Forms.Timer checkThread;
        private System.Windows.Forms.Button btnCancel;
    }
}