using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using TwinCAT.Ads;
namespace MmmConfig
{
    public partial class Form1 : Form
    {
        private CPU_Connection CpuConnection;
        
        private Motor.stMotorsts[] MotorSts;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CpuConnection = new CPU_Connection();
            MotorSts = new Motor.stMotorsts[4];
            
            
            
            if (CpuConnection.connected)
            {
                lblConnStatus.Text = "Connected";
                btnConnect.Text = "Disconnect";
                tWdTimer.Enabled = true;
                tUpdateData.Enabled = true;

            }
            else
            {
                lblConnStatus.Text = "No connection";
                btnConnect.Text = "Connect";
                tWdTimer.Enabled = false;
                tUpdateData.Enabled = false;
            }
            
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (CpuConnection.connected)
            {
                if (CpuConnection.disconnect())
                {
                    lblConnStatus.Text = "Disconnected";
                    btnConnect.Text = "Connect";
                    tWdTimer.Enabled = false;
                    tUpdateData.Enabled = false;
                }
                else
                {
                    lblConnStatus.Text = "Connected";
                    btnConnect.Text = "Disconnect";
                    tWdTimer.Enabled = true;
                    tUpdateData.Enabled = true;
                }
            }
            else
            {
                if (CpuConnection.connect(txtNetId.Text,int.Parse(txtPort.Text)))
                {
                    lblConnStatus.Text = "Connected";
                    btnConnect.Text = "Disconnect";
                    tWdTimer.Enabled = true;
                    tUpdateData.Enabled = true;
                }
                else
                {
                    lblConnStatus.Text = "No connection";
                    btnConnect.Text = "Connect";
                    tWdTimer.Enabled = false;
                    tUpdateData.Enabled = false;
                }
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tWdTimer_Tick(object sender, EventArgs e)
        {
            
            int iWatchDog = CpuConnection.readInt("LOC_AdsIO.stOutput._Reserve[7]");
            lblTest.Text = iWatchDog.ToString();
            CpuConnection.writeInt("LOC_AdsIO.stInput._Reserve[3]", iWatchDog);
        }

        private void tUpdateData_Tick(object sender, EventArgs e)
        {
            /* Read motor status */
            for (int _i = 0; _i < 4; _i++)
            {
                MotorSts[_i] = CpuConnection.readMotSts(_i + 1);
                Console.WriteLine("Errore motore #" + _i + " : " + MotorSts[_i].xError.ToString());
            }
            
            
        }
    }
}
