using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MmmConfig.Forms
{
    public partial class MainSelector : Form
    {
        #region Variable declarations
        public static AppConfig appConfig = new AppConfig();
        #endregion

        #region Form related functions
        public MainSelector()
        {
            InitializeComponent();
        }

        #region Button related functions
        private void btnConfigurator_Click(object sender, EventArgs e)
        {
            try { 
                this.Hide();
                Form1 configuratorForm = new Form1();
                configuratorForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error while opening configurator app: " + ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); this.Dispose(); }
        }

        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            try { 
                this.Hide();
                Forms.LogReader logReader = new Forms.LogReader();
                logReader.ShowDialog();
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show("Error while opening diagnostic app: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Dispose();  }
        }

        #endregion
        private void MainSelector_Load(object sender, EventArgs e)
        {
            XmlExtractor xmlExtractor = new XmlExtractor();
            string strCurrentDir;
            string strCfgFilePath;
            try
            {
                strCurrentDir = Directory.GetCurrentDirectory();
                strCfgFilePath = strCurrentDir + "\\config.xml";
                xmlExtractor.readConfiguration(strCfgFilePath, appConfig);
            }
            catch (UnauthorizedAccessException ue) { MessageBox.Show("Access to folder is not authorized: " + ue.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            catch (FileNotFoundException ue) { MessageBox.Show("File not found: " + ue.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion
    }
}
