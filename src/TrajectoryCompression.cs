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
        public double[] xArray { get; set; }
        public double[] yArray { get; set; }
        ///public int precision { get; set; }
        public string compressedString { get; set; }

        public TrajectoryCompression(int[] xarr, int[] yarr)
        {
            ///Need to initialize this.arrays here
        }
        ///Need a create traj string method and a compress method

    }
}
