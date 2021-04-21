using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Noemax.Compression;

namespace WindowsFormsApp1
{
    public class TrajectoryCompression
    {
        public string trajectoryString { get; set; }
        public string compressedString { get; set; }

        public TrajectoryCompression(int[] xarr, int[] yarr, int precision)
        {
            NumberFormatInfo setPrecision = new NumberFormatInfo();
            setPrecision.NumberDecimalDigits = precision;

            this.trajectoryString = "";
            this.trajectoryString += "(" + xarr[0].ToString("N", setPrecision) + "," + yarr[0].ToString("N", setPrecision) + ")";

            for (int i = 1; i < xarr.Length; i++)
            {
                string xstr = xarr[i].ToString("N", setPrecision);
                string ystr = yarr[i].ToString("N", setPrecision);

                this.trajectoryString += ",(" + xstr + "," + ystr + ")";
            }
        }
        public int compressTrajectory()
        {
            this.compressedString = this.trajectoryString;
            return this.compressedString.Length;
        }

    }
}
