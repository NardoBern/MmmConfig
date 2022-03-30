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

                tWdTimer.Enabled = true;
            }

        }

        public void MotStsNotification(object sender, AdsNotificationEventArgs e)
        {
            
            ReadOnlyMemory<byte> memory = e.Data;

            if (e.Handle == motor[0].motorStatus.uiVarHandle[0]) {motor[0].motorStatus.xError       = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[0].motorStatus.uiVarHandle[1]) {motor[0].motorStatus.xMoving      = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[0].motorStatus.uiVarHandle[2]) {motor[0].motorStatus.xSync        = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[0].motorStatus.uiVarHandle[3]) {motor[0].motorStatus.xSetPosOk    = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[0].motorStatus.uiVarHandle[4]) {motor[0].motorStatus.iSpeedRpm    = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[0].motorStatus.uiVarHandle[5]) {motor[0].motorStatus.iPosition    = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[0].motorStatus.uiVarHandle[6]) {motor[0].motorStatus.iCurrLoad    = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }

            if (e.Handle == motor[1].motorStatus.uiVarHandle[0]) {motor[1].motorStatus.xError       = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[1].motorStatus.uiVarHandle[1]) {motor[1].motorStatus.xMoving      = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[1].motorStatus.uiVarHandle[2]) {motor[1].motorStatus.xSync        = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[1].motorStatus.uiVarHandle[3]) {motor[1].motorStatus.xSetPosOk    = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[1].motorStatus.uiVarHandle[4]) {motor[1].motorStatus.iSpeedRpm    = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[1].motorStatus.uiVarHandle[5]) {motor[1].motorStatus.iPosition    = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[1].motorStatus.uiVarHandle[6]) {motor[1].motorStatus.iCurrLoad    = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }

            if (e.Handle == motor[2].motorStatus.uiVarHandle[0]) {motor[2].motorStatus.xError       = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[2].motorStatus.uiVarHandle[1]) {motor[2].motorStatus.xMoving      = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[2].motorStatus.uiVarHandle[2]) {motor[2].motorStatus.xSync        = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[2].motorStatus.uiVarHandle[3]) {motor[2].motorStatus.xSetPosOk    = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[2].motorStatus.uiVarHandle[4]) {motor[2].motorStatus.iSpeedRpm    = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[2].motorStatus.uiVarHandle[5]) {motor[2].motorStatus.iPosition    = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[2].motorStatus.uiVarHandle[6]) {motor[2].motorStatus.iCurrLoad    = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }

            if (e.Handle == motor[3].motorStatus.uiVarHandle[0]) {motor[3].motorStatus.xError       = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[3].motorStatus.uiVarHandle[1]) {motor[3].motorStatus.xMoving      = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[3].motorStatus.uiVarHandle[2]) {motor[3].motorStatus.xSync        = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[3].motorStatus.uiVarHandle[3]) {motor[3].motorStatus.xSetPosOk    = BitConverter.ToBoolean(memory.ToArray(), 0);}
            if (e.Handle == motor[3].motorStatus.uiVarHandle[4]) {motor[3].motorStatus.iSpeedRpm    = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[3].motorStatus.uiVarHandle[5]) {motor[3].motorStatus.iPosition    = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[3].motorStatus.uiVarHandle[6]) {motor[3].motorStatus.iCurrLoad    = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }

            updateLabelStatus();
        }

        private void updateLabelStatus()
        {
            if (motor[0].motorStatus.xError)    { lblErrorStsMot1.BackColor         = Color.Red; }          else { lblErrorStsMot1.BackColor    = Color.LightGray; }
            if (motor[0].motorStatus.xMoving)   { lblMovingStsMot1.BackColor        = Color.LightGreen; }   else { lblMovingStsMot1.BackColor   = Color.LightGray; }
            if (motor[0].motorStatus.xSync)     { lblInSyncStsMot1.BackColor        = Color.LightGreen; }   else { lblInSyncStsMot1.BackColor   = Color.LightGray; }
            if (motor[0].motorStatus.xSetPosOk) { lblSetPosOkStsMot1.BackColor      = Color.LightGreen; }   else { lblSetPosOkStsMot1.BackColor = Color.LightGray; }
            if (motor[1].motorStatus.xError)    { lblErrorStsMot2.BackColor         = Color.Red; }          else { lblErrorStsMot2.BackColor    = Color.LightGray; }
            if (motor[1].motorStatus.xMoving)   { lblMovingStsMot2.BackColor        = Color.LightGreen; }   else { lblMovingStsMot2.BackColor   = Color.LightGray; }
            if (motor[1].motorStatus.xSync)     { lblInSyncStsMot2.BackColor        = Color.LightGreen; }   else { lblInSyncStsMot2.BackColor   = Color.LightGray; }
            if (motor[1].motorStatus.xSetPosOk) { lblSetPosOkStsMot2.BackColor      = Color.LightGreen; }   else { lblSetPosOkStsMot2.BackColor = Color.LightGray; }
            if (motor[2].motorStatus.xError)    { lblErrorStsMot3.BackColor         = Color.Red; }          else { lblErrorStsMot3.BackColor    = Color.LightGray; }
            if (motor[2].motorStatus.xMoving)   { lblMovingStsMot3.BackColor        = Color.LightGreen; }   else { lblMovingStsMot3.BackColor   = Color.LightGray; }
            if (motor[2].motorStatus.xSync)     { lblInSyncStsMot3.BackColor        = Color.LightGreen; }   else { lblInSyncStsMot3.BackColor   = Color.LightGray; }
            if (motor[2].motorStatus.xSetPosOk) { lblSetPosOkStsMot3.BackColor      = Color.LightGreen; }   else { lblSetPosOkStsMot3.BackColor = Color.LightGray; }
            if (motor[3].motorStatus.xError)    { lblErrorStsMot4.BackColor         = Color.Red; }          else { lblErrorStsMot4.BackColor    = Color.LightGray; }
            if (motor[3].motorStatus.xMoving)   { lblMovingStsMot4.BackColor        = Color.LightGreen; }   else { lblMovingStsMot4.BackColor   = Color.LightGray; }
            if (motor[3].motorStatus.xSync)     { lblInSyncStsMot4.BackColor        = Color.LightGreen; }   else { lblInSyncStsMot4.BackColor   = Color.LightGray; }
            if (motor[3].motorStatus.xSetPosOk) { lblSetPosOkStsMot4.BackColor      = Color.LightGreen; }   else { lblSetPosOkStsMot4.BackColor = Color.LightGray; }
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
                
        private void vUpdateConnectedStatus()
        {
            lblConnStatus.Text = "Connected";
            btnConnect.Text = "Disconnect";
            tWdTimer.Enabled = true;
            if (!(motor[0].motorStatus.xEventEnabled)){ReadMotorSts();}
            vAddMotorStsNotification(motor[0], CpuConnection, 1, "LOC_AdsIO.stOutput.MotorSts");
            vAddMotorStsNotification(motor[1], CpuConnection, 2, "LOC_AdsIO.stOutput.MotorSts");
            vAddMotorStsNotification(motor[2], CpuConnection, 3, "LOC_AdsIO.stOutput.MotorSts");
            vAddMotorStsNotification(motor[3], CpuConnection, 4, "LOC_AdsIO.stOutput.MotorSts");
            CpuConnection.tcClient.AdsNotification += new EventHandler<AdsNotificationEventArgs>(MotStsNotification);
        }
        private void vUpdateDisconnectedStatus()
        {
            CpuConnection.connected = false;
            lblConnStatus.Text = "No connection";
            btnConnect.Text = "Connect";
            tWdTimer.Enabled = false;
            //tUpdateData.Enabled = false;
        }

        private void ReadMotorSts()
        {
            Console.WriteLine("Lettura stati motori");
            bool[] tempBool;
            tempBool = new bool[4];
            tempBool = motor[0].ReadMotorSts(1, CpuConnection, "LOC_AdsIO.stOutput.MotorSts");
            motor[0].motorStatus.xError     = tempBool[0];
            motor[0].motorStatus.xMoving    = tempBool[1];
            motor[0].motorStatus.xSync      = tempBool[2];
            motor[0].motorStatus.xSetPosOk  = tempBool[3];
            tempBool = motor[1].ReadMotorSts(2, CpuConnection, "LOC_AdsIO.stOutput.MotorSts");
            motor[1].motorStatus.xError     = tempBool[0];
            motor[1].motorStatus.xMoving    = tempBool[1];
            motor[1].motorStatus.xSync      = tempBool[2];
            motor[1].motorStatus.xSetPosOk  = tempBool[3];
            tempBool = motor[2].ReadMotorSts(3, CpuConnection, "LOC_AdsIO.stOutput.MotorSts");
            motor[2].motorStatus.xError     = tempBool[0];
            motor[2].motorStatus.xMoving    = tempBool[1];
            motor[2].motorStatus.xSync      = tempBool[2];
            motor[2].motorStatus.xSetPosOk  = tempBool[3];
            tempBool = motor[3].ReadMotorSts(4, CpuConnection, "LOC_AdsIO.stOutput.MotorSts");
            motor[3].motorStatus.xError     = tempBool[0];
            motor[3].motorStatus.xMoving    = tempBool[1];
            motor[3].motorStatus.xSync      = tempBool[2];
            motor[3].motorStatus.xSetPosOk  = tempBool[3];
            updateLabelStatus();
        }

        private void btnEnableMot1_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(1, 0, CpuConnection);
            if (xTemp) { btnEnableMot1.BackColor = Color.LightGreen; }
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

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                if (CpuConnection.tcClient != null)
                {
                    // Removing Notifications
                    CpuConnection.tcClient.AdsNotification -= new EventHandler<AdsNotificationEventArgs>(MotStsNotification);
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

        private void vAddMotorStsNotification(MmmConfig.Motor motor, MmmConfig.CPU_Connection cPU_Connection, int motorIndex, string partialVarPath)
        {
            if (!motor.motorStatus.xEventEnabled)
            {
                motor.motorStatus.uiVarHandle[0] = cPU_Connection.AddNotification(cPU_Connection.tcClient, partialVarPath + "[" + motorIndex.ToString() + "].xError");
                motor.motorStatus.uiVarHandle[1] = cPU_Connection.AddNotification(cPU_Connection.tcClient, partialVarPath + "[" + motorIndex.ToString() + "].xMoving");
                motor.motorStatus.uiVarHandle[2] = cPU_Connection.AddNotification(cPU_Connection.tcClient, partialVarPath + "[" + motorIndex.ToString() + "].xInSync");
                motor.motorStatus.uiVarHandle[3] = cPU_Connection.AddNotification(cPU_Connection.tcClient, partialVarPath + "[" + motorIndex.ToString() + "].xSetPosOk");
                motor.motorStatus.uiVarHandle[4] = cPU_Connection.AddNotification(cPU_Connection.tcClient, partialVarPath + "[" + motorIndex.ToString() + "].iSpeedRpm");
                motor.motorStatus.uiVarHandle[5] = cPU_Connection.AddNotification(cPU_Connection.tcClient, partialVarPath + "[" + motorIndex.ToString() + "].iPosition");
                motor.motorStatus.uiVarHandle[6] = cPU_Connection.AddNotification(cPU_Connection.tcClient, partialVarPath + "[" + motorIndex.ToString() + "].iCurrLoad");
                motor.motorStatus.xEventEnabled = true;
                Console.WriteLine("Added status notification to Motor #" + motorIndex.ToString());
            }
        }

        private void btnMoveFwMot1_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(1, 1, CpuConnection);
            if (xTemp) { btnMoveFwMot1.BackColor = Color.LightGreen; }
            else { btnMoveFwMot1.BackColor = Color.AliceBlue; }
        }

        private void btnMoveFwMot2_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(2, 1, CpuConnection);
            if (xTemp) { btnMoveFwMot2.BackColor = Color.LightGreen; }
            else { btnMoveFwMot2.BackColor = Color.AliceBlue; }
        }

        private void btnMoveFwMot3_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(3, 1, CpuConnection);
            if (xTemp) { btnMoveFwMot3.BackColor = Color.LightGreen; }
            else { btnMoveFwMot3.BackColor = Color.AliceBlue; }
        }

        private void btnMoveFwMot4_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(4, 1, CpuConnection);
            if (xTemp) { btnMoveFwMot4.BackColor = Color.LightGreen; }
            else { btnMoveFwMot4.BackColor = Color.AliceBlue; }
        }

        private void btnMoveBwMot1_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(1, 2, CpuConnection);
            if (xTemp) { btnMoveBwMot1.BackColor = Color.LightGreen; }
            else { btnMoveBwMot1.BackColor = Color.AliceBlue; }
        }

        private void btnMoveBwMot2_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(2, 2, CpuConnection);
            if (xTemp) { btnMoveBwMot2.BackColor = Color.LightGreen; }
            else { btnMoveBwMot2.BackColor = Color.AliceBlue; }
        }

        private void btnMoveBwMot3_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(3, 2, CpuConnection);
            if (xTemp) { btnMoveBwMot3.BackColor = Color.LightGreen; }
            else { btnMoveBwMot3.BackColor = Color.AliceBlue; }
        }

        private void btnMoveBwMot4_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(4, 2, CpuConnection);
            if (xTemp) { btnMoveBwMot4.BackColor = Color.LightGreen; }
            else { btnMoveBwMot4.BackColor = Color.AliceBlue; }
        }

        private void btnSyncOnMot1_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(1, 3, CpuConnection);
            if (xTemp) { btnSyncOnMot1.BackColor = Color.LightGreen; }
            else { btnSyncOnMot1.BackColor = Color.AliceBlue; }
        }

        private void btnSyncOnMot2_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(2, 3, CpuConnection);
            if (xTemp) { btnSyncOnMot2.BackColor = Color.LightGreen; }
            else { btnSyncOnMot2.BackColor = Color.AliceBlue; }
        }

        private void btnSyncOnMot3_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(3, 3, CpuConnection);
            if (xTemp) { btnSyncOnMot3.BackColor = Color.LightGreen; }
            else { btnSyncOnMot3.BackColor = Color.AliceBlue; }
        }

        private void btnSyncOnMot4_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(4, 3, CpuConnection);
            if (xTemp) { btnSyncOnMot4.BackColor = Color.LightGreen; }
            else { btnSyncOnMot4.BackColor = Color.AliceBlue; }
        }

        private void btnSetPosMot1_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(1, 4, CpuConnection);
            if (xTemp) { btnSetPosMot1.BackColor = Color.LightGreen; }
            else { btnSetPosMot1.BackColor = Color.AliceBlue; }
        }

        private void btnSetPosMot2_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(2, 4, CpuConnection);
            if (xTemp) { btnSetPosMot2.BackColor = Color.LightGreen; }
            else { btnSetPosMot2.BackColor = Color.AliceBlue; }
        }

        private void btnSetPosMot3_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(3, 4, CpuConnection);
            if (xTemp) { btnSetPosMot3.BackColor = Color.LightGreen; }
            else { btnSetPosMot3.BackColor = Color.AliceBlue; }
        }

        private void btnSetPosMot4_Click(object sender, EventArgs e)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(4, 4, CpuConnection);
            if (xTemp) { btnSetPosMot4.BackColor = Color.LightGreen; }
            else { btnSetPosMot4.BackColor = Color.AliceBlue; }
        }
    }
}
