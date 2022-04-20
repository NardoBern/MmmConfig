using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmConfig
{
    public class OperationLog
    {
        #region Variable declaration
        public string strOperationDescr;
        public int[] aiOpValue;
        public double[] arOpValue;
        public string[] astrOpValue;
        #endregion

        public OperationLog()
        {
            int[] aiOpValue = new int[5];
            double[] arOpValue = new double[5];
            string[] astrOpValue = new string[5];
        }

    }
}
