using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
using System.Collections;

namespace WindowsFormsApp1
{
    //I am making this comment to test Pull request requirements
    //This is a change
    public partial class Form1 : Form
    {
        private Function F;
        private Function G;
        private Function I;
        private double increment = .05;
        private int iter;
        private int trajIter;
        private int ICCount;
        private double[] Ix;
        private double[] Iy;
        private double[] trajX;
        private double[] trajY;




        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            formatToolStrips();
            InitToolBar();
            formsPlot1.Configure(lowQualityWhileDragging: true);
        }

        private void formatToolStrips()
        {
            toolStrip3.Left = (toolStripContainer1.BottomToolStripPanel.Width - toolStrip3.Width) / 2;
            toolStrip2.Left = toolStripContainer1.TopToolStripPanel.Width - toolStrip2.Width;
            toolStrip1.Left = 0;
            toolStrip2.Top = 0;
            toolStrip1.Top = 0;
            toolStrip2.Height = toolStrip1.Height;
            toolStripContainer1.TopToolStripPanel.Height = toolStrip1.Height; 
        }

        private void InitToolBar()
        {


            var InitialHost = new ToolStripControlHost(InitialPanel);
            var TrajIterHost = new ToolStripControlHost(TrajIterPanel);
            var FractalHost = new ToolStripControlHost(FractalPanel);
            
            DrawDrop.DropDownItems.Add(TrajIterHost);

            InitialDrop.DropDownItems.Add(InitialHost);
            InitialDrop.DropDown.SetBounds(InitialDrop.Bounds.X,InitialDrop.Bounds.Bottom, InitialPanel.Width, InitialPanel.Height);
            
            
            FractalDrop.DropDownItems.Add(FractalHost);
            FractalDrop.DropDown.Width = FractalPanel.Width;
        }


        private void DrawButton_Click(object sender, EventArgs e)
        {

            increment = (double)IncValue.Value;
            iter = (int)iters.Value;
            trajIter = (int)TrajIters.Value;
            String funcF = Func1.Text;
            String funcG = Func2.Text;

            funcF = formatFunc(funcF);
            funcG = formatFunc(funcG);

            F = new Function("F", funcF, "x", "y");
            G = new Function("G", funcG, "x", "y");

            drawInitial();
            InitArrays(trajIter);
            if(DrawFunc.Checked) DrawFractal();
            formsPlot1.plt.PlotScatter(trajX, trajY);
        }

        private void DrawFractal()
        {
            int i = 0;
            while (i < ICCount)
            {
                double[] outX = new double[iter + 1];
                double[] outY = new double[iter + 1];
                int j = 1;
                outX[0] = Ix[i];
                outY[0] = Iy[i];
                while (j <= iter)
                {
                    outX[j] = F.calculate(outX[j - 1], outY[j - 1]);
                    outY[j] = G.calculate(outX[j - 1], outY[j - 1]);

                    j++;
                }
                i++;

                formsPlot1.plt.PlotScatter(outX, outY, lineWidth: 0, markerSize: 1);
            }

            formsPlot1.Render(true);
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            formsPlot1.plt.Clear();
            formsPlot1.Render();

        }

        private void drawInitial()
        {
            I = new Function("I", Initial.Text, "x");
            double IStart = (double)start.Value;
            double IDone = (double)finish.Value;
            double size = (Math.Abs(IDone) + Math.Abs(IStart)) / increment;

            Ix = new double[(int)size + 1];
            Iy = new double[(int)size + 1];
            ICCount = 0;
            while (IStart <= IDone)
            {
                Ix[ICCount] = IStart;
                Iy[ICCount] = I.calculate(IStart);
                IStart += increment;
                ICCount++;
            }

            if (DrawInit.Checked)
            {
                formsPlot1.plt.PlotScatter(Ix, Iy, color: Color.Black, lineWidth: .5, markerSize: 0);
                formsPlot1.Render(true);
            }
        }

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
        private void UpdateCoor()
        {
            Point mouseLoc = new Point(Cursor.Position.X, Cursor.Position.Y);
            mouseLoc.X -= this.PointToScreen(formsPlot1.Location).X;
            mouseLoc.Y -= this.PointToScreen(formsPlot1.Location).Y;
            mouseLoc.Y -= (Cursor.Size.Height-Cursor.Size.Height/6);
            

            PointF mouse = formsPlot1.plt.CoordinateFromPixel(mouseLoc);
            coor.Text = string.Format(
                " Mouse Coordinates: ({0}, {1})",
                mouse.X,
                mouse.Y
                );


        }

        private void updateTraj(double[] trajX, double[] trajY)
        {

            var plottables = formsPlot1.plt.GetPlottables();
            if (plottables.Count >= 1)
            {
                var traject = (ScottPlot.PlottableScatter)plottables[plottables.Count - 1];
                int i = 1;

                Point mouseLoc = new Point(Cursor.Position.X, Cursor.Position.Y);
                mouseLoc.X -= this.PointToScreen(formsPlot1.Location).X;
                mouseLoc.Y -= this.PointToScreen(formsPlot1.Location).Y;
                mouseLoc.Y -= (Cursor.Size.Height - Cursor.Size.Height / 6);

                PointF mouse = formsPlot1.plt.CoordinateFromPixel(mouseLoc); ;
                trajX[0] = (double)(mouse.X);
                trajY[0] = (double)(mouse.Y);

                while (i <= trajIter)
                {
                    trajX[i] = F.calculate(trajX[i - 1], trajY[i - 1]);
                    trajY[i] = G.calculate(trajX[i - 1], trajY[i - 1]);
                    i++;
                }
                if (!traject.Equals(null))
                {
                    traject.xs = trajX;
                    traject.ys = trajY;
                    formsPlot1.Render();
                }

            }
        }

        private void InitArrays(int iters)
        {
            trajX = new double[iters + 1];
            trajY = new double[iters + 1];
        }
        private void formsPlot1_MouseMoved(object sender, EventArgs e)
        {

            if (traj.Checked)
            {
                trajX = new double[iter + 1];
                trajY = new double[iter + 1];
                updateTraj(trajX, trajY);
            }
            UpdateCoor();
        }

        FormWindowState LastWindowState = FormWindowState.Normal;
        private void Form1_Resize(object sender, EventArgs e)
        {
            formatToolStrips();
            if(WindowState != LastWindowState)
            {
                LastWindowState = WindowState;
                formatToolStrips();
            }
        }
    }
}
