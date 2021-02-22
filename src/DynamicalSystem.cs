using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using org.mariuszgromada.math.mxparser;
using ScottPlot;

namespace WindowsFormsApp1
{
    public class DynamicalSystem 
    {
        public readonly Form1 form;
        public string ID { get; set; }
        public Function F { get; set; }
        public Function G { get; set; }
        public Function I { get; set; }
        public bool drawTrajectory { get; set; }
        public bool drawIC { get; set; }
        public double increment { get; set; }
        public int iterations { get; set; }
        public int trajectoryIterations { get; set; }
        private double[] ICx;
        private double[] ICy;
        private int ICCount;

        public DynamicalSystem(String id, Form1 form) 
        {
            this.ID = id;
            this.form = form;

            this.F = new Function("F", formatFunc(form.Func1.Text), "x", "y");
            this.G = new Function("G", formatFunc(form.Func2.Text), "x", "y");
            this.I = new Function("I", form.Initial.Text, "x");

            this.drawTrajectory = form.traj.Checked;
            this.drawIC = form.DrawInit.Checked;
            this.increment = (double)form.IncValue.Value;
            this.iterations = (int)form.iters.Value;
            this.trajectoryIterations = (int)form.TrajIters.Value;
        }

        public PlottableScatter getIC()
        {
            double IStart = (double)form.start.Value;
            double IDone = (double)form.finish.Value;
            double size = (Math.Abs(IDone) + Math.Abs(IStart)) / increment;

            this.ICx = new double[(int)size + 1];
            this.ICy = new double[(int)size + 1];
            this.ICCount = 0;
            while (IStart <= IDone)
            {
                ICx[ICCount] = IStart;
                ICy[ICCount] = I.calculate(IStart);
                IStart += increment;
                ICCount++;
            }
            return new PlottableScatter(ICx, ICy);
        }

        public PlottableScatter getDynamicalSystem()
        {
            
            int i = 0;
            List<double> xs = new List<double>();
            List<double> ys = new List<double>();
            while (i < ICCount)
            {
                List<double> outX = new List<double>();
                List<double> outY = new List<double>();
                int j = 1;
                outX.Add(ICx[i]);
                outY.Add(ICy[i]);
                while (j <= iterations)
                {
                    outX.Add(F.calculate(outX[j - 1], outY[j - 1]));
                    outY.Add(G.calculate(outX[j - 1], outY[j - 1]));

                    j++;
                }
                i++;

                xs.AddRange(outX);
                ys.AddRange(outY);
            }
            
            return new PlottableScatter(xs.ToArray(), ys.ToArray());
        }

        public PlottableScatter getTrajectory()
        {
            PointF mouseLoc = new PointF(form.Cursor.Position.X, Cursor.Position.Y);
            mouseLoc.X -= this.PointToScreen(form.formsPlot1.Location).X;
            mouseLoc.Y -= this.PointToScreen(form.formsPlot1.Location).Y;
            mouseLoc.Y -= (Cursor.Size.Height - Cursor.Size.Height / 6);
            
            PointF mouse = new PointF();
            mouse.X = form.formsPlot1.plt.CoordinateFromPixelX(mouseLoc.X);
            mouse.Y = form.formsPlot1.plt.CoordinateFromPixelY(mouseLoc.Y);

            double[] xs = new double[trajectoryIterations+1];
            double[] ys = new double[trajectoryIterations+1];
            xs[0] = form.formsPlot1.plt.CoordinateFromPixelX(mouseLoc.X);
            ys[0] = form.formsPlot1.plt.CoordinateFromPixelY(mouseLoc.Y);
            int i = 1;
            while (i <= trajectoryIterations)
            {
                xs[i] = F.calculate(xs[i - 1], ys[i - 1]);
                ys[i] = G.calculate(xs[i - 1], ys[i - 1]);
                i++;
            }

            return new PlottableScatter(xs, ys);
        }


        /*
        ############################ Helper Functions #################################
        */

        private String formatFunc(String func)
        {

            if (func.Contains('x') && !func.Contains('y'))
            {
                func += " + 0*y";
            }
            else if (!func.Contains('x') && func.Contains('y'))
            {
                func += " + 0*x";
            }
            return func;
        }
    }
}
