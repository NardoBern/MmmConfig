
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
            this.dgvLogReader = new System.Windows.Forms.DataGridView();
            this.EventNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventTimeStamp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EventAlert = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogReader)).BeginInit();
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
            this.dgvLogReader.Location = new System.Drawing.Point(12, 12);
            this.dgvLogReader.Name = "dgvLogReader";
            this.dgvLogReader.Size = new System.Drawing.Size(788, 559);
            this.dgvLogReader.TabIndex = 0;
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
            // LogReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 583);
            this.Controls.Add(this.dgvLogReader);
            this.Name = "LogReader";
            this.Text = "LogReader";
            this.Load += new System.EventHandler(this.LogReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLogReader)).EndInit();
            this.ResumeLayout(false);

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
    }
}