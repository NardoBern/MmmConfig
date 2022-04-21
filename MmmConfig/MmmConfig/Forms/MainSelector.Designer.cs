
namespace MmmConfig.Forms
{
    partial class MainSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSelector));
            this.btnConfigurator = new System.Windows.Forms.Button();
            this.btnDiagnostic = new System.Windows.Forms.Button();
            this.lblConfigurator = new System.Windows.Forms.Label();
            this.lblDiagnostic = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConfigurator
            // 
            this.btnConfigurator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConfigurator.BackgroundImage")));
            this.btnConfigurator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfigurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurator.Location = new System.Drawing.Point(34, 33);
            this.btnConfigurator.Name = "btnConfigurator";
            this.btnConfigurator.Size = new System.Drawing.Size(110, 100);
            this.btnConfigurator.TabIndex = 0;
            this.btnConfigurator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConfigurator.UseVisualStyleBackColor = true;
            this.btnConfigurator.Click += new System.EventHandler(this.btnConfigurator_Click);
            // 
            // btnDiagnostic
            // 
            this.btnDiagnostic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDiagnostic.BackgroundImage")));
            this.btnDiagnostic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDiagnostic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiagnostic.Location = new System.Drawing.Point(170, 33);
            this.btnDiagnostic.Name = "btnDiagnostic";
            this.btnDiagnostic.Size = new System.Drawing.Size(110, 100);
            this.btnDiagnostic.TabIndex = 1;
            this.btnDiagnostic.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDiagnostic.UseVisualStyleBackColor = true;
            this.btnDiagnostic.Click += new System.EventHandler(this.btnDiagnostic_Click);
            // 
            // lblConfigurator
            // 
            this.lblConfigurator.AutoSize = true;
            this.lblConfigurator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfigurator.Location = new System.Drawing.Point(35, 14);
            this.lblConfigurator.Name = "lblConfigurator";
            this.lblConfigurator.Size = new System.Drawing.Size(109, 20);
            this.lblConfigurator.TabIndex = 2;
            this.lblConfigurator.Text = "Configurator";
            // 
            // lblDiagnostic
            // 
            this.lblDiagnostic.AutoSize = true;
            this.lblDiagnostic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnostic.Location = new System.Drawing.Point(178, 14);
            this.lblDiagnostic.Name = "lblDiagnostic";
            this.lblDiagnostic.Size = new System.Drawing.Size(94, 20);
            this.lblDiagnostic.TabIndex = 3;
            this.lblDiagnostic.Text = "Diagnostic";
            // 
            // MainSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 164);
            this.Controls.Add(this.lblDiagnostic);
            this.Controls.Add(this.lblConfigurator);
            this.Controls.Add(this.btnDiagnostic);
            this.Controls.Add(this.btnConfigurator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainSelector";
            this.Load += new System.EventHandler(this.MainSelector_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConfigurator;
        private System.Windows.Forms.Button btnDiagnostic;
        private System.Windows.Forms.Label lblConfigurator;
        private System.Windows.Forms.Label lblDiagnostic;
    }
}