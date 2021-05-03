using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
		public Function I { get; set; }
		public bool drawTrajectory { get; set; }
		public bool drawIC { get; set; }
		public double increment { get; set; }
		public int iterations { get; set; }
		public int trajectoryIterations { get; set; }
		private double[] ICx;
		private double[] ICy;
		private int ICCount;
		// Markov Chain Values
		public bool DrawMarkovChain { get; set; }
		public bool MarkovChainRandomState { get; set; }
		public int MarkovStartingState { get; set; }
		public Function Markov1a { get; set; }
		public Function Markov1b { get; set; }
		public double MarkovProb1to1 { get; set; }
		public double MarkovProb1to2 { get; set; }
		public double MarkovProb1to3 { get; set; }
		public double MarkovProb1to4 { get; set; }
		public double MarkovProb1to5 { get; set; }
		public Function Markov2a { get; set; }
		public Function Markov2b { get; set; }
		public double MarkovProb2to1 { get; set; }
		public double MarkovProb2to2 { get; set; }
		public double MarkovProb2to3 { get; set; }
		public double MarkovProb2to4 { get; set; }
		public double MarkovProb2to5 { get; set; }
		public Function Markov3a { get; set; }
		public Function Markov3b { get; set; }
		public double MarkovProb3to1 { get; set; }
		public double MarkovProb3to2 { get; set; }
		public double MarkovProb3to3 { get; set; }
		public double MarkovProb3to4 { get; set; }
		public double MarkovProb3to5 { get; set; }
		public Function Markov4a { get; set; }
		public Function Markov4b { get; set; }
		public double MarkovProb4to1 { get; set; }
		public double MarkovProb4to2 { get; set; }
		public double MarkovProb4to3 { get; set; }
		public double MarkovProb4to4 { get; set; }
		public double MarkovProb4to5 { get; set; }
		public Function Markov5a { get; set; }
		public Function Markov5b { get; set; }
		public double MarkovProb5to1 { get; set; }
		public double MarkovProb5to2 { get; set; }
		public double MarkovProb5to3 { get; set; }
		public double MarkovProb5to4 { get; set; }
		public double MarkovProb5to5 { get; set; }


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
			this.initialCondition = getIC();

			//Markov Chain Stuff
			this.DrawMarkovChain = form.DrawMarkovChain.Checked;
			this.MarkovChainRandomState = form.MarkovChainRandomState.Checked;
			this.MarkovStartingState = (int)form.MarkovStartingState.Value;
			this.Markov1a = new Function("Markov1a", formatFunc(form.MarkovFunc1a.Text), "x", "y");
			this.Markov1b = new Function("Markov1b", formatFunc(form.MarkovFunc1b.Text), "x", "y");
			this.MarkovProb1to1 = (double)form.MarkovProb1to1.Value;
			this.MarkovProb1to2 = (double)form.MarkovProb1to2.Value;
			this.MarkovProb1to3 = (double)form.MarkovProb1to3.Value;
			this.MarkovProb1to4 = (double)form.MarkovProb1to4.Value;
			this.MarkovProb1to5 = (double)form.MarkovProb1to5.Value;
			this.Markov2a = new Function("Markov2a", formatFunc(form.MarkovFunc2a.Text), "x", "y");
			this.Markov2b = new Function("Markov2b", formatFunc(form.MarkovFunc2b.Text), "x", "y");
			this.MarkovProb2to1 = (double)form.MarkovProb2to1.Value;
			this.MarkovProb2to2 = (double)form.MarkovProb2to2.Value;
			this.MarkovProb2to3 = (double)form.MarkovProb2to3.Value;
			this.MarkovProb2to4 = (double)form.MarkovProb2to4.Value;
			this.MarkovProb2to5 = (double)form.MarkovProb2to5.Value;
			this.Markov3a = new Function("Markov3a", formatFunc(form.MarkovFunc3a.Text), "x", "y");
			this.Markov3b = new Function("Markov3b", formatFunc(form.MarkovFunc3b.Text), "x", "y");
			this.MarkovProb3to1 = (double)form.MarkovProb3to1.Value;
			this.MarkovProb3to2 = (double)form.MarkovProb3to2.Value;
			this.MarkovProb3to3 = (double)form.MarkovProb3to3.Value;
			this.MarkovProb3to4 = (double)form.MarkovProb3to4.Value;
			this.MarkovProb3to5 = (double)form.MarkovProb3to5.Value;
			this.Markov4a = new Function("Markov4a", formatFunc(form.MarkovFunc4a.Text), "x", "y");
			this.Markov4b = new Function("Markov4b", formatFunc(form.MarkovFunc4b.Text), "x", "y");
			this.MarkovProb4to1 = (double)form.MarkovProb4to1.Value;
			this.MarkovProb4to2 = (double)form.MarkovProb4to2.Value;
			this.MarkovProb4to3 = (double)form.MarkovProb4to3.Value;
			this.MarkovProb4to4 = (double)form.MarkovProb4to4.Value;
			this.MarkovProb4to5 = (double)form.MarkovProb4to5.Value;
			this.Markov5a = new Function("Markov5a", formatFunc(form.MarkovFunc5a.Text), "x", "y");
			this.Markov5b = new Function("Markov5b", formatFunc(form.MarkovFunc5b.Text), "x", "y");
			this.MarkovProb5to1 = (double)form.MarkovProb5to1.Value;
			this.MarkovProb5to2 = (double)form.MarkovProb5to2.Value;
			this.MarkovProb5to3 = (double)form.MarkovProb5to3.Value;
			this.MarkovProb5to4 = (double)form.MarkovProb5to4.Value;
			this.MarkovProb5to5 = (double)form.MarkovProb5to5.Value;
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
				double nextX;
				double nextY;
				List<double> outX = new List<double>();
				List<double> outY = new List<double>();
				int j = 1;
				outX.Add(ICx[i]);
				outY.Add(ICy[i]);
				Random r = new Random(DateTime.Now.Millisecond);
				int rInt;

				if (DrawMarkovChain)
				{
					if (MarkovChainRandomState)
					{
						rInt = r.Next(1, 5);
						MarkovStartingState = rInt;
					}

					int state = MarkovStartingState;
					int temp_state = MarkovStartingState;

					while (j < iterations)
					{
						if (state == 1)
						{
							nextX = Markov1a.calculate(outX[j - 1], outY[j - 1]);
							nextY = Markov1b.calculate(outX[j - 1], outY[j - 1]);

							outX.Add(Math.Round(nextX, 5));
							outY.Add(Math.Round(nextY, 5));

							rInt = r.Next(0, 1000);
							if (rInt < MarkovProb1to1 * 1000)
							{
								temp_state = 1;
							}
							else if (rInt < (MarkovProb1to1 + MarkovProb1to2) * 1000)
							{
								temp_state = 2;
							}
							else if (rInt < (MarkovProb1to1 + MarkovProb1to2 + MarkovProb1to3) * 1000)
							{
								temp_state = 3;
							}
							else if (rInt < (MarkovProb1to1 + MarkovProb1to2 + MarkovProb1to3 + MarkovProb1to4) * 1000)
							{
								temp_state = 4;
							}
							else
							{
								temp_state = 5;
							}
						}
						else if(state == 2)
						{
							nextX = Markov2a.calculate(outX[j - 1], outY[j - 1]);
							nextY = Markov2b.calculate(outX[j - 1], outY[j - 1]);

							outX.Add(Math.Round(nextX, 5));
							outY.Add(Math.Round(nextY, 5));

							rInt = r.Next(0, 1000);
							if (rInt < MarkovProb2to1 * 1000)
							{
								temp_state = 1;
							}
							else if (rInt < (MarkovProb2to1 + MarkovProb2to2) * 1000)
							{
								temp_state = 2;
							}
							else if (rInt < (MarkovProb2to1 + MarkovProb2to2 + MarkovProb2to3) * 1000)
							{
								temp_state = 3;
							}
							else if (rInt < (MarkovProb2to1 + MarkovProb2to2 + MarkovProb2to3 + MarkovProb2to4) * 1000)
							{
								temp_state = 4;
							}
							else
							{
								temp_state = 5;
							}
						}
						else if (state == 3)
						{
							nextX = Markov3a.calculate(outX[j - 1], outY[j - 1]);
							nextY = Markov3b.calculate(outX[j - 1], outY[j - 1]);

							outX.Add(Math.Round(nextX, 5));
							outY.Add(Math.Round(nextY, 5));

							rInt = r.Next(0, 1000);
							if (rInt < MarkovProb3to1 * 1000)
							{
								temp_state = 1;
							}
							else if (rInt < (MarkovProb3to1 + MarkovProb3to2) * 1000)
							{
								temp_state = 2;
							}
							else if (rInt < (MarkovProb3to1 + MarkovProb3to2 + MarkovProb3to3) * 1000)
							{
								temp_state = 3;
							}
							else if (rInt < (MarkovProb3to1 + MarkovProb3to2 + MarkovProb3to3 + MarkovProb3to4) * 1000)
							{
								temp_state = 4;
							}
							else
							{
								temp_state = 5;
							}
						}
						else if (state == 4)
						{
							nextX = Markov4a.calculate(outX[j - 1], outY[j - 1]);
							nextY = Markov4b.calculate(outX[j - 1], outY[j - 1]);

							outX.Add(Math.Round(nextX, 5));
							outY.Add(Math.Round(nextY, 5));

							rInt = r.Next(0, 1000);
							if (rInt < MarkovProb4to1 * 1000)
							{
								temp_state = 1;
							}
							else if (rInt < (MarkovProb4to1 + MarkovProb4to2) * 1000)
							{
								temp_state = 2;
							}
							else if (rInt < (MarkovProb4to1 + MarkovProb4to2 + MarkovProb4to3) * 1000)
							{
								temp_state = 3;
							}
							else if (rInt < (MarkovProb4to1 + MarkovProb4to2 + MarkovProb4to3 + MarkovProb4to4) * 1000)
							{
								temp_state = 4;
							}
							else
							{
								temp_state = 5;
							}
						}
						else
						{
							nextX = Markov5a.calculate(outX[j - 1], outY[j - 1]);
							nextY = Markov5b.calculate(outX[j - 1], outY[j - 1]);

							outX.Add(Math.Round(nextX, 5));
							outY.Add(Math.Round(nextY, 5));

							rInt = r.Next(0, 1000);
							if (rInt < MarkovProb5to1 * 1000)
							{
								temp_state = 1;
							}
							else if (rInt < (MarkovProb5to1 + MarkovProb5to2) * 1000)
							{
								temp_state = 2;
							}
							else if (rInt < (MarkovProb5to1 + MarkovProb5to2 + MarkovProb5to3) * 1000)
							{
								temp_state = 3;
							}
							else if (rInt < (MarkovProb5to1 + MarkovProb5to2 + MarkovProb5to3 + MarkovProb5to4) * 1000)
							{
								temp_state = 4;
							}
							else
							{
								temp_state = 5;
							}
						}

						state = temp_state;
						j++;
					}
				}

				else
				{
					while (j < iterations)
					{
						nextX = F.calculate(outX[j - 1], outY[j - 1]);
						nextY = G.calculate(outX[j - 1], outY[j - 1]);

						outX.Add(Math.Round(nextX, 5));
						outY.Add(Math.Round(nextY, 5));

						j++;
					}
                }

                Random rnd = new Random();
				Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

				scatters.Add(new PlottableScatter(outX.ToArray(), outY.ToArray())
				{
					lineWidth = 0,
					markerSize = 2,
					color = randomColor
				});

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
