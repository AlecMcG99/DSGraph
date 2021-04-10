using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using org.mariuszgromada.math.mxparser;
using ScottPlot;

namespace WindowsFormsApp1
{
	public class DynamicalSystem
	{
		public readonly Form1 form;
		public PlottableScatter initialCondition { get; set; }
		public PlottableScatter trajectory { get; set; }
		public string ID { get; set; }
		public Function F { get; set; }
		public Function G { get; set; }
		public double Probability { get; set; }
		public Function F_b { get; set; }
		public Function G_b { get; set; }
		public double Probability_b { get; set; }
		public Function F_c { get; set; }
		public Function G_c { get; set; }
		public double Probability_c { get; set; }
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
			this.Probability = (double)form.Probability.Value;
			this.F_b = new Function("A", formatFunc(form.Func1b.Text), "x", "y");
			this.G_b = new Function("B", formatFunc(form.Func2b.Text), "x", "y");
			this.Probability_b = (double)form.Probability_b.Value;
			this.F_c = new Function("A", formatFunc(form.Func1c.Text), "x", "y");
			this.G_c = new Function("B", formatFunc(form.Func2c.Text), "x", "y");
			this.Probability_c = (double)form.Probability_c.Value;
			this.I = new Function("I", form.Initial.Text, "x");

			this.drawTrajectory = form.traj.Checked;
			this.drawIC = form.DrawInit.Checked;
			this.increment = (double)form.IncValue.Value;
			this.iterations = (int)form.iters.Value;
			this.trajectoryIterations = (int)form.TrajIters.Value;
			this.initialCondition = getIC();
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

		public PlottableScatter[] getDynamicalSystem()
		{

			int i = 0;
			List<PlottableScatter> scatters = new List<PlottableScatter>();
			while (i < ICCount)
			{
				List<double> outX = new List<double>();
				List<double> outY = new List<double>();
				int j = 1;
				outX.Add(ICx[i]);
				outY.Add(ICy[i]);
				Random r = new Random(DateTime.Now.Millisecond);

				while (j < iterations)
				{
					int rInt = r.Next(0, 1000);

					if (rInt < Probability * 1000)
					{
						double nextX = F.calculate(outX[j - 1], outY[j - 1]);
						double nextY = G.calculate(outX[j - 1], outY[j - 1]);

						outX.Add(Math.Round(nextX, 5));
						outY.Add(Math.Round(nextY, 5));
					}

					else if (rInt < (Probability * 1000 + Probability_b * 1000))
                    {
						double nextX = F_b.calculate(outX[j - 1], outY[j - 1]);
						double nextY = G_b.calculate(outX[j - 1], outY[j - 1]);

						outX.Add(Math.Round(nextX, 5));
						outY.Add(Math.Round(nextY, 5));
					}

					else
                    {
						double nextX = F_c.calculate(outX[j - 1], outY[j - 1]);
						double nextY = G_c.calculate(outX[j - 1], outY[j - 1]);

						outX.Add(Math.Round(nextX, 5));
						outY.Add(Math.Round(nextY, 5));
					}

					j++;
				}
				Random rnd = new Random();
				Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

				scatters.Add(new PlottableScatter(outX.ToArray(), outY.ToArray())
				{
					lineWidth = 0,
					markerSize = 3,
					color = randomColor
				});
				System.Threading.Thread.Sleep(0005);
				i++;
			}

			return scatters.ToArray();
		}

		public (double[], double[]) getTrajectory(double xCoor, double yCoor)
		{
			double[] xs = new double[trajectoryIterations + 1];
			double[] ys = new double[trajectoryIterations + 1];
			xs[0] = xCoor;
			ys[0] = yCoor;

			int i = 1;
			while (i <= trajectoryIterations)
			{
				xs[i] = F.calculate(xs[i - 1], ys[i - 1]);
				ys[i] = G.calculate(xs[i - 1], ys[i - 1]);					
				i++;
			}

			return (xs, ys);
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
