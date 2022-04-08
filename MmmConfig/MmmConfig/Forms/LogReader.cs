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
    public partial class LogReader : Form
    {
        #region Variable declarations
        const string c_strMotionEventLogPath = "GVL_Hmi.stMotionEventLogger";
        string[,] astrString = new string[1000,7];
        #endregion

        #region Form related functions
        public LogReader()
        {
            InitializeComponent();
        }

        private void LogReader_Load(object sender, EventArgs e)
        {
            populateDataGridView();
            colorateDataGridView();
            
            Cursor.Current = Cursors.Default;
        }
        #endregion

        #region Operative functions
        public void populateDataGridView()
        {
            for (int _i = 0; _i < Form1.motionEventLogger.iLastWritePos; _i++)
            {
                astrString[_i, 0] = _i.ToString();
                astrString[_i, 1] = Form1.motionEventLogger.events[_i].uiEventId.ToString();
                astrString[_i, 2] = Form1.motionEventLogger.events[_i].strTimeStamp;
                switch (Form1.motionEventLogger.events[_i].eTypeOfEvent)
                {
                    case eTypeOfEvent.Info:
                        astrString[_i, 3] = "Information";
                        break;
                    case eTypeOfEvent.Message:
                        astrString[_i, 3] = "Message";
                        break;
                    case eTypeOfEvent.Warning:
                        astrString[_i, 3] = "Warning";
                        break;
                    case eTypeOfEvent.Error:
                        astrString[_i, 3] = "Error";
                        break;
                }
                astrString[_i, 4] = Form1.motionEventLogger.events[_i].strDeviceName;
                astrString[_i, 5] = Form1.motionEventLogger.events[_i].strMessage;
                astrString[_i, 6] = Form1.motionEventLogger.events[_i].strAlert;

                string[] strStringToAdd = { astrString[_i, 0], astrString[_i, 1], astrString[_i, 2], astrString[_i, 3], astrString[_i, 4], astrString[_i, 5], astrString[_i, 6] };

                dgvLogReader.Rows.Add(strStringToAdd);
            }
            for (int _i = 0; _i < 7; _i++) { dgvLogReader.AutoResizeColumn(_i); }
            
        }
        
        public void colorateDataGridView()
        {
            foreach (DataGridViewRow row in dgvLogReader.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    switch (row.Cells[3].Value.ToString())
                    {
                        case "Information":
                            row.DefaultCellStyle.BackColor = Color.LightBlue;
                            break;
                        case "Message":
                            row.DefaultCellStyle.BackColor = Color.LightGreen;
                            break;
                        case "Warning":
                            row.DefaultCellStyle.BackColor = Color.LightYellow;
                            break;
                        case "Error":
                            row.DefaultCellStyle.BackColor = Color.LightPink;
                            break;
                    }
                }
            }
        }

        #endregion
    }
}
