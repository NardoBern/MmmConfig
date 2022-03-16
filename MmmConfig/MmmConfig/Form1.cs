/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using TwinCAT.Ads;*/
using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.IO;
using TwinCAT.Ads;
using System.Threading;
using TwinCAT.TypeSystem;
using System.Text;
using System.Buffers.Binary;
using System.Threading.Tasks;
using TwinCAT.Ads.TypeSystem;
using TwinCAT;
using System.Collections.Generic;
using TwinCAT.Ads.AdsRouterService;
namespace MmmConfig
{
    public partial class Form1 : Form
    {
        public CPU_Connection CpuConnection;
        public Motor[] motor;
        //private Motor.stMotorsts[] MotorSts;
        private int iWdCheck = 0;
        
        
        
        public Form1()
        {
            InitializeComponent();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            CpuConnection = new CPU_Connection();
            motor = new Motor[4];
            motor[0] = new Motor();
            motor[1] = new Motor();
            motor[2] = new Motor();
            motor[3] = new Motor();

            if (CpuConnection.connected)
            {
                vUpdateConnectedStatus();

            }
            else
            {
                vUpdateDisconnectedStatus();
            }
            
            
        }
  

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (CpuConnection.connected)
            {
                CpuConnection.disconnect(CpuConnection.tcClient);
                vUpdateDisconnectedStatus();
            }
            else
            {
                               
                CpuConnection.tcClient = CpuConnection.connect(txtNetId.Text, int.Parse(txtPort.Text));
                //addNotification();
                tWdTimer.Enabled = true;
            }
            
        }

        private void addNotification()
        {
            uint hTest;

            hTest = CpuConnection.tcClient.AddDeviceNotification("LOC_AdsIO.stOutput._Reserve[7]", 2,
                    new NotificationSettings(AdsTransMode.OnChange, 100, 0), null);

            CpuConnection.tcClient.AdsNotification += new EventHandler<AdsNotificationEventArgs>(OnNotification);
        }

        public void OnNotification(object sender, AdsNotificationEventArgs e)
        {
            Console.WriteLine("Figa!!");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tWdTimer_Tick(object sender, EventArgs e)
        {
            int iWatchDog = CpuConnection.readInt("LOC_AdsIO.stOutput._Reserve[7]", CpuConnection.tcClient);
            lblTest.Text = iWatchDog.ToString();
            CpuConnection.writeInt("LOC_AdsIO.stInput._Reserve[3]", iWatchDog);
            CpuConnection.iWatchDog = iWatchDog;
            iWdCheck = iWdCheck + 1;
            if (iWdCheck >= 6)
            {
                if (CpuConnection.checkWdValue(iWatchDog))
                {
                    vUpdateConnectedStatus();
                }
                else
                {
                    vUpdateDisconnectedStatus();
                }
                iWdCheck = 0;
            }
        }

        private void tUpdateData_Tick(object sender, EventArgs e)
        {
            /* Read motor status 
            for (int _i = 0; _i < 4; _i++)
            {
                MotorSts[_i] = CpuConnection.readMotSts(_i + 1);
                Console.WriteLine("Errore motore #" + _i + " : " + MotorSts[_i].xError.ToString());
            }*/
            
            
        }

        private void vUpdateConnectedStatus()
        {
            lblConnStatus.Text = "Connected";
            btnConnect.Text = "Disconnect";
            tWdTimer.Enabled = true;
            tUpdateData.Enabled = true;
            if (!motor[0].motorStatus.xEventEnabled)
            {
                motor[0].motorStatus.uiVarHandle[0] = CpuConnection.AddNotification(CpuConnection.tcClient, "LOC_AdsIO.stOutput.MotorSts[1].xError");
                CpuConnection.tcClient.AdsNotification += new EventHandler<AdsNotificationEventArgs>(OnNotification);
                motor[0].motorStatus.xEventEnabled = true;
            }
        }
        private void vUpdateDisconnectedStatus()
        {
            CpuConnection.connected = false;
            lblConnStatus.Text = "No connection";
            btnConnect.Text = "Connect";
            tWdTimer.Enabled = false;
            tUpdateData.Enabled = false;
        }

        private void btnEnableMot1_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(1, 0, CpuConnection);
            if (xTemp) { btnEnableMot1.BackColor = Color.LightGreen;}
            else { btnEnableMot1.BackColor = Color.AliceBlue; }
        }

        private void btnEnableMot2_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(2, 0, CpuConnection);
            if (xTemp) { btnEnableMot2.BackColor = Color.LightGreen; }
            else { btnEnableMot2.BackColor = Color.AliceBlue; }
        }

        private void btnEnableMot3_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(3, 0, CpuConnection);
            if (xTemp) { btnEnableMot3.BackColor = Color.LightGreen; }
            else { btnEnableMot3.BackColor = Color.AliceBlue; }
        }

        private void btnEnableMot4_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(4, 0, CpuConnection);
            if (xTemp) { btnEnableMot4.BackColor = Color.LightGreen; }
            else { btnEnableMot4.BackColor = Color.AliceBlue; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint uiTestHandle = CpuConnection.AddNotification(CpuConnection.tcClient, "LOC_AdsIO.stOutput.WdCount");
            CpuConnection.tcClient.AdsNotification += new EventHandler<AdsNotificationEventArgs>(OnNotification);
        }


        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (CpuConnection.tcClient != null)
                {
                    // Removing Notifications
                    CpuConnection.tcClient.AdsNotification -= new EventHandler<AdsNotificationEventArgs>(OnNotification);
                    // Disposing the Client.
                    CpuConnection.tcClient.Dispose();
                    CpuConnection.tcClient = null;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
