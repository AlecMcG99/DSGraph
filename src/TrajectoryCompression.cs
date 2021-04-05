using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class TrajectoryCompression
    {
        public string trajectoryString { get; set; }
        public string compressedString { get; set; }

        public TrajectoryCompression(int[] xarr, int[] yarr, int precision)
        {
            this.trajectoryString = "";

            this.trajectoryString += "(" + xarr[0] + "," + yarr[0] + ")";

            for (int i = 1; i < xarr.Length; i++)
            {
                string xstr = xarr[i].ToString();
                string ystr = yarr[i].ToString();

                this.trajectoryString += ",(" + xarr[i] + "," + yarr[i] + ")";
            }
        }
        ///Need a create a compress method

    }
}
