using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MmmConfig.Forms
{
    public partial class ConnectionSettings : Form
    {
        public string strNetId;
        public string strPort;
        public ConnectionSettings()
        {
            InitializeComponent();
        }

        private void ConnectionSettings_Load(object sender, EventArgs e)
        {
            txtNetId.Text = strNetId;
            txtPort.Text = strPort;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            strNetId = txtNetId.Text;
            strPort = txtPort.Text;
            DialogResult = DialogResult.OK;
            MainSelector.appLogger.addLine("Connection settings maybe changed. New NetId: " + strNetId + " New Port: " + strPort, AppLogger.eLogLevel.debug);
            Close();
        }
    }
}
