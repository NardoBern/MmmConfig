﻿/*using System;
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

        private void updateLabelsPosRpmLoad()
        {
            lblPosMot1.Text = "Position: " + motor[0].motorStatus.iPosition.ToString() + "°";
            lblPosMot2.Text = "Position: " + motor[1].motorStatus.iPosition.ToString() + "°";
            lblPosMot3.Text = "Position: " + motor[2].motorStatus.iPosition.ToString() + "°";
            lblPosMot4.Text = "Position: " + motor[3].motorStatus.iPosition.ToString() + "°";
            lblRpmMot1.Text = "Speed: " + motor[0].motorStatus.iSpeedRpm.ToString() + " rpm";
            lblRpmMot2.Text = "Speed: " + motor[1].motorStatus.iSpeedRpm.ToString() + " rpm";
            lblRpmMot3.Text = "Speed: " + motor[2].motorStatus.iSpeedRpm.ToString() + " rpm";
            lblRpmMot4.Text = "Speed: " + motor[3].motorStatus.iSpeedRpm.ToString() + " rpm";
            lblLoadMot1.Text = "Load: " + motor[0].motorStatus.iCurrLoad.ToString() + " %";
            lblLoadMot2.Text = "Load: " + motor[1].motorStatus.iCurrLoad.ToString() + " %";
            lblLoadMot3.Text = "Load: " + motor[2].motorStatus.iCurrLoad.ToString() + " %";
            lblLoadMot4.Text = "Load: " + motor[3].motorStatus.iCurrLoad.ToString() + " %";
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
                
        private void btnClickEvent(Button button,int iMotorIndex, int iCmdNum, CPU_Connection _Connection)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorCmd(iMotorIndex, iCmdNum, _Connection);
            if (xTemp) { button.BackColor = Color.LightGreen; }
            else { button.BackColor = Color.AliceBlue; }
        }

        private void btnEnableMot1_Click(object sender, EventArgs e) { btnClickEvent(btnEnableMot1, 1, 0, CpuConnection); }
        private void btnEnableMot2_Click(object sender, EventArgs e) { btnClickEvent(btnEnableMot2, 2, 0, CpuConnection); }
        private void btnEnableMot3_Click(object sender, EventArgs e) { btnClickEvent(btnEnableMot3, 3, 0, CpuConnection); }
        private void btnEnableMot4_Click(object sender, EventArgs e) { btnClickEvent(btnEnableMot4, 4, 0, CpuConnection); }
        private void btnMoveFwMot1_Click(object sender, EventArgs e) { btnClickEvent(btnMoveFwMot1, 1, 1, CpuConnection); }
        private void btnMoveFwMot2_Click(object sender, EventArgs e) { btnClickEvent(btnMoveFwMot2, 2, 1, CpuConnection); }
        private void btnMoveFwMot3_Click(object sender, EventArgs e) { btnClickEvent(btnMoveFwMot3, 3, 1, CpuConnection); }
        private void btnMoveFwMot4_Click(object sender, EventArgs e) { btnClickEvent(btnMoveFwMot4, 4, 1, CpuConnection); }
        private void btnMoveBwMot1_Click(object sender, EventArgs e) { btnClickEvent(btnMoveBwMot1, 1, 2, CpuConnection); }
        private void btnMoveBwMot2_Click(object sender, EventArgs e) { btnClickEvent(btnMoveBwMot2, 2, 2, CpuConnection); }
        private void btnMoveBwMot3_Click(object sender, EventArgs e) { btnClickEvent(btnMoveBwMot3, 3, 2, CpuConnection); }
        private void btnMoveBwMot4_Click(object sender, EventArgs e) { btnClickEvent(btnMoveBwMot4, 4, 2, CpuConnection); }
        private void btnSyncOnMot1_Click(object sender, EventArgs e) { btnClickEvent(btnSyncOnMot1, 1, 3, CpuConnection); }
        private void btnSyncOnMot2_Click(object sender, EventArgs e) { btnClickEvent(btnSyncOnMot2, 2, 3, CpuConnection); }
        private void btnSyncOnMot3_Click(object sender, EventArgs e) { btnClickEvent(btnSyncOnMot3, 3, 3, CpuConnection); }
        private void btnSyncOnMot4_Click(object sender, EventArgs e) { btnClickEvent(btnSyncOnMot4, 4, 3, CpuConnection); }
        private void btnSetPosMot1_Click(object sender, EventArgs e) { btnClickEvent(btnSetPosMot1, 1, 4, CpuConnection); }
        private void btnSetPosMot2_Click(object sender, EventArgs e) { btnClickEvent(btnSetPosMot2, 2, 4, CpuConnection); }
        private void btnSetPosMot3_Click(object sender, EventArgs e) { btnClickEvent(btnSetPosMot3, 3, 4, CpuConnection); }
        private void btnSetPosMot4_Click(object sender, EventArgs e) { btnClickEvent(btnSetPosMot4, 4, 4, CpuConnection); }
       

        private void numSelChanged(NumericUpDown numericUpDown, int iMotorIndex, int iParNum, CPU_Connection _Connection, string strParamPath)
        {
            Motor Motor = new Motor();
            bool xTemp = new bool();
            xTemp = Motor.WriteMotorParam(iMotorIndex, iParNum, _Connection, strParamPath, Decimal.ToInt16(numericUpDown.Value));
            if (xTemp) { numericUpDown.BackColor = Color.LightGreen; }
            else { numericUpDown.BackColor = Color.LightPink; }
        }
        private void numSyncMasterMot1_ValueChanged(object sender, EventArgs e) { numSelChanged(numSyncMasterMot1, 1, 1, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void numSyncMasterMot2_ValueChanged(object sender, EventArgs e) { numSelChanged(numSyncMasterMot2, 2, 1, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void numSyncMasterMot3_ValueChanged(object sender, EventArgs e) { numSelChanged(numSyncMasterMot3, 3, 1, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void numSyncMasterMot4_ValueChanged(object sender, EventArgs e) { numSelChanged(numSyncMasterMot1, 4, 1, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtParameterChanged(TextBox textBox, int iMotorIndex, int iParNum, CPU_Connection _Connection, string strParamPath)
        {
            if (Int32.TryParse(textBox.Text, out int value))
            {
                Motor Motor = new Motor();
                bool xTemp = new bool();
                xTemp = Motor.WriteMotorParam(iMotorIndex, iParNum, _Connection, strParamPath, value);
                if (xTemp) { textBox.BackColor = Color.LightGreen; }
                else { textBox.BackColor = Color.LightPink; }
            }
            else
            {
                textBox.BackColor = Color.LightPink;
            }
        }

        private void txtGearInMot1_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtGearInMot1, 1, 2, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtGearInMot2_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtGearInMot2, 2, 2, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtGearInMot3_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtGearInMot3, 3, 2, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtGearInMot4_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtGearInMot4, 4, 2, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtGearOutMot1_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtGearOutMot1, 1, 3, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); } 
        private void txtGearOutMot2_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtGearOutMot2, 2, 3, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); } 
        private void txtGearOutMot3_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtGearOutMot3, 3, 3, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); } 
        private void txtGearOutMot4_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtGearOutMot4, 4, 3, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); } 
        private void txtNumOfPhasesMot1_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtNumOfPhasesMot1, 1, 4, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); } 
        private void txtNumOfPhasesMot2_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtNumOfPhasesMot2, 2, 4, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); } 
        private void txtNumOfPhasesMot3_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtNumOfPhasesMot3, 3, 4, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); } 
        private void txtNumOfPhasesMot4_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtNumOfPhasesMot3, 4, 4, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtFixedSpeedM1_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtFixedSpeedM1, 1, 5, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtFixedSpeedM2_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtFixedSpeedM2, 2, 5, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtFixedSpeedM3_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtFixedSpeedM3, 3, 5, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtFixedSpeedM4_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtFixedSpeedM4, 4, 5, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtMaxSpeedM1_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtMaxSpeedM1, 1, 6, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtMaxSpeedM2_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtMaxSpeedM2, 2, 6, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtMaxSpeedM3_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtMaxSpeedM3, 3, 6, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtMaxSpeedM4_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtMaxSpeedM4, 4, 6, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtStartRampM1_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtStartRampM1, 1, 7, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtStartRampM2_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtStartRampM2, 2, 7, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtStartRampM3_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtStartRampM3, 3, 7, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtStartRampM4_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtStartRampM4, 4, 7, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtStopRampM1_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtStopRampM1, 1, 8, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtStopRampM2_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtStopRampM2, 2, 8, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtStopRampM3_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtStopRampM3, 3, 8, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtStopRampM4_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtStopRampM4, 4, 8, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtEstopRampM1_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtEstopRampM1, 1, 9, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtEstopRampM2_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtEstopRampM2, 2, 9, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtEstopRampM3_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtEstopRampM3, 3, 9, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtEstopRampM4_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtEstopRampM4, 4, 9, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtCurrLimitM1_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtCurrLimitM1, 1, 10, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtCurrLimitM2_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtCurrLimitM2, 2, 10, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtCurrLimitM3_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtCurrLimitM3, 3, 10, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }
        private void txtCurrLimitM4_TextChanged(object sender, EventArgs e) { txtParameterChanged(txtCurrLimitM4, 4, 10, CpuConnection, "LOC_AdsIO.stInput.Config.astMotorCfg"); }




        public void MotStsNotification(object sender, AdsNotificationEventArgs e)
        {

            ReadOnlyMemory<byte> memory = e.Data;

            if (e.Handle == motor[0].motorStatus.uiVarHandle[0]) { motor[0].motorStatus.xError = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[0].motorStatus.uiVarHandle[1]) { motor[0].motorStatus.xMoving = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[0].motorStatus.uiVarHandle[2]) { motor[0].motorStatus.xSync = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[0].motorStatus.uiVarHandle[3]) { motor[0].motorStatus.xSetPosOk = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[0].motorStatus.uiVarHandle[4]) { motor[0].motorStatus.iSpeedRpm = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[0].motorStatus.uiVarHandle[5]) { motor[0].motorStatus.iPosition = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[0].motorStatus.uiVarHandle[6]) { motor[0].motorStatus.iCurrLoad = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }

            if (e.Handle == motor[1].motorStatus.uiVarHandle[0]) { motor[1].motorStatus.xError = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[1].motorStatus.uiVarHandle[1]) { motor[1].motorStatus.xMoving = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[1].motorStatus.uiVarHandle[2]) { motor[1].motorStatus.xSync = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[1].motorStatus.uiVarHandle[3]) { motor[1].motorStatus.xSetPosOk = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[1].motorStatus.uiVarHandle[4]) { motor[1].motorStatus.iSpeedRpm = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[1].motorStatus.uiVarHandle[5]) { motor[1].motorStatus.iPosition = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[1].motorStatus.uiVarHandle[6]) { motor[1].motorStatus.iCurrLoad = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }

            if (e.Handle == motor[2].motorStatus.uiVarHandle[0]) { motor[2].motorStatus.xError = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[2].motorStatus.uiVarHandle[1]) { motor[2].motorStatus.xMoving = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[2].motorStatus.uiVarHandle[2]) { motor[2].motorStatus.xSync = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[2].motorStatus.uiVarHandle[3]) { motor[2].motorStatus.xSetPosOk = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[2].motorStatus.uiVarHandle[4]) { motor[2].motorStatus.iSpeedRpm = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[2].motorStatus.uiVarHandle[5]) { motor[2].motorStatus.iPosition = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[2].motorStatus.uiVarHandle[6]) { motor[2].motorStatus.iCurrLoad = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }

            if (e.Handle == motor[3].motorStatus.uiVarHandle[0]) { motor[3].motorStatus.xError = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[3].motorStatus.uiVarHandle[1]) { motor[3].motorStatus.xMoving = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[3].motorStatus.uiVarHandle[2]) { motor[3].motorStatus.xSync = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[3].motorStatus.uiVarHandle[3]) { motor[3].motorStatus.xSetPosOk = BitConverter.ToBoolean(memory.ToArray(), 0); }
            if (e.Handle == motor[3].motorStatus.uiVarHandle[4]) { motor[3].motorStatus.iSpeedRpm = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[3].motorStatus.uiVarHandle[5]) { motor[3].motorStatus.iPosition = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }
            if (e.Handle == motor[3].motorStatus.uiVarHandle[6]) { motor[3].motorStatus.iCurrLoad = BinaryPrimitives.ReadInt16BigEndian(e.Data.Span); }

            updateLabelStatus();
            updateLabelsPosRpmLoad();
        }

        private void vUpdateConnectedStatus()
        {
            lblConnStatus.Text = "Connected";
            btnConnect.Text = "Disconnect";
            tWdTimer.Enabled = true;
            if (!(motor[0].motorStatus.xEventEnabled)) { ReadMotorSts(); }
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
            motor[0].motorStatus.xError = tempBool[0];
            motor[0].motorStatus.xMoving = tempBool[1];
            motor[0].motorStatus.xSync = tempBool[2];
            motor[0].motorStatus.xSetPosOk = tempBool[3];
            tempBool = motor[1].ReadMotorSts(2, CpuConnection, "LOC_AdsIO.stOutput.MotorSts");
            motor[1].motorStatus.xError = tempBool[0];
            motor[1].motorStatus.xMoving = tempBool[1];
            motor[1].motorStatus.xSync = tempBool[2];
            motor[1].motorStatus.xSetPosOk = tempBool[3];
            tempBool = motor[2].ReadMotorSts(3, CpuConnection, "LOC_AdsIO.stOutput.MotorSts");
            motor[2].motorStatus.xError = tempBool[0];
            motor[2].motorStatus.xMoving = tempBool[1];
            motor[2].motorStatus.xSync = tempBool[2];
            motor[2].motorStatus.xSetPosOk = tempBool[3];
            tempBool = motor[3].ReadMotorSts(4, CpuConnection, "LOC_AdsIO.stOutput.MotorSts");
            motor[3].motorStatus.xError = tempBool[0];
            motor[3].motorStatus.xMoving = tempBool[1];
            motor[3].motorStatus.xSync = tempBool[2];
            motor[3].motorStatus.xSetPosOk = tempBool[3];
            updateLabelStatus();

            int[] tempInt;
            tempInt = new int[3];
            tempInt = motor[0].ReadMotorValFdbk(1, CpuConnection, "LOC_AdsIO.stOutput.MotorSts");
            motor[0].motorStatus.iSpeedRpm = tempInt[0];
            motor[0].motorStatus.iPosition = tempInt[1];
            motor[0].motorStatus.iCurrLoad = tempInt[2];
            tempInt = motor[1].ReadMotorValFdbk(2, CpuConnection, "LOC_AdsIO.stOutput.MotorSts");
            motor[1].motorStatus.iSpeedRpm = tempInt[0];
            motor[1].motorStatus.iPosition = tempInt[1];
            motor[1].motorStatus.iCurrLoad = tempInt[2];
            tempInt = motor[2].ReadMotorValFdbk(3, CpuConnection, "LOC_AdsIO.stOutput.MotorSts");
            motor[2].motorStatus.iSpeedRpm = tempInt[0];
            motor[2].motorStatus.iPosition = tempInt[1];
            motor[2].motorStatus.iCurrLoad = tempInt[2];
            tempInt = motor[3].ReadMotorValFdbk(4, CpuConnection, "LOC_AdsIO.stOutput.MotorSts");
            motor[3].motorStatus.iSpeedRpm = tempInt[0];
            motor[3].motorStatus.iPosition = tempInt[1];
            motor[3].motorStatus.iCurrLoad = tempInt[2];
            updateLabelsPosRpmLoad();
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
    }
}
