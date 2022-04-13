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
    public partial class MainSelector : Form
    {
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
    }
}
