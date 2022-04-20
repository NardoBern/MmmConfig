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
        public static AppLogger appLogger = new AppLogger();
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
                appLogger.addLine("Configurator app has been launched", AppLogger.eLogLevel.info);
                configuratorForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error while opening configurator app: " + ex.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error); this.Dispose();
                appLogger.addLine("Error while opening configurator app: " + ex.ToString(), AppLogger.eLogLevel.error);
            }
        }

        private void btnDiagnostic_Click(object sender, EventArgs e)
        {
            try { 
                this.Hide();
                Forms.LogReader logReader = new Forms.LogReader();
                appLogger.addLine("Diagnostic app has been launched", AppLogger.eLogLevel.info);
                logReader.ShowDialog();
                this.Close();
            }
            catch (Exception ex) 
            { 
                MessageBox.Show("Error while opening diagnostic app: " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); this.Dispose();
                appLogger.addLine("Error while opening diagnostic app: " + ex.ToString(), AppLogger.eLogLevel.error);
            }
        }

        #endregion
        private void MainSelector_Load(object sender, EventArgs e)
        {
            appLogger.addLine("Main selector app has been started", AppLogger.eLogLevel.info);
            XmlExtractor xmlExtractor = new XmlExtractor();
            string strCurrentDir;
            string strCfgFilePath;
            try
            {
                strCurrentDir = Directory.GetCurrentDirectory();
                strCfgFilePath = strCurrentDir + "\\config.xml";
                xmlExtractor.readConfiguration(strCfgFilePath, appConfig);
            }
            catch (UnauthorizedAccessException ue) 
            { 
                MessageBox.Show("Access to folder is not authorized: " + ue.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appLogger.addLine("Access to folder of config file is not authorized: " + ue.ToString(), AppLogger.eLogLevel.error);
            }
            catch (FileNotFoundException ue) 
            { 
                MessageBox.Show("File not found: " + ue.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appLogger.addLine("App configuration file hasn't been found: " + ue.ToString(), AppLogger.eLogLevel.error);
            }
        }
        #endregion
    }
}
