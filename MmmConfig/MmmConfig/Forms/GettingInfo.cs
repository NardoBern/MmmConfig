using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MmmConfig.Forms
{
    public partial class GettingInfo : Form
    {
        const string c_strMotionEventLogPath = "GVL_Hmi.stMotionEventLogger";
        public Thread trd;
        public int _i;

        public GettingInfo()
        {
            InitializeComponent();
        }

        private void GettingInfo_Load(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            
        }

        

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            btnCancel.Enabled = true;
            int iNumOfEventToRead = Form1.CpuConnection.readInt(c_strMotionEventLogPath + ".iLastWritePos", Form1.CpuConnection.tcClient);
            prgBarGetInfo.Maximum = iNumOfEventToRead;
            Form1.motionEventLogger.iLastWritePos = iNumOfEventToRead;

            trd = new Thread(new ThreadStart(readEvent));
            trd.IsBackground = true;
            checkThread.Enabled = true;
            trd.Start();
            
        }
        private void readEvent()
        {
            int iNumOfEventToRead = Form1.CpuConnection.readInt(c_strMotionEventLogPath + ".iLastWritePos", Form1.CpuConnection.tcClient);
            for (_i = 0; _i < iNumOfEventToRead; _i++)
            {
                Form1.CpuConnection.readEvent(c_strMotionEventLogPath, Form1.CpuConnection.tcClient, _i, Form1.motionEventLogger.events[_i]);
            }
            
        }

        private void checkThread_Tick(object sender, EventArgs e)
        {
            bool trdState = trd.IsAlive;
            if (trdState) { prgBarGetInfo.Value = _i; }
            else
            {
                this.Close();
                
                Forms.LogReader LogReaderForm = new Forms.LogReader();
                LogReaderForm.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (trd.IsAlive) { 
                trd.Abort(); 
                checkThread.Enabled = false;
                btnCancel.Enabled = false;
            }
            
        }
    }
   
}
