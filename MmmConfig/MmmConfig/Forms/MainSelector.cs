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
        public static AppConfig appConfig = new AppConfig();
        public MainSelector()
        {
            InitializeComponent();
        }

        private void btnConfigurator_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 configuratorForm = new Form1();
            configuratorForm.ShowDialog();
            this.Close();     
        }

        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            this.Hide();
            Forms.LogReader logReader = new Forms.LogReader();
            logReader.ShowDialog();
            this.Close();
        }

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
    }
}
