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
using System.Runtime.InteropServices;
using ScottPlot;
using ScottPlot.UserControls;
using System.Runtime.CompilerServices;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        private List<DynamicalSystem> systems = new List<DynamicalSystem>();
        double[] trajectoryXs;
        double[] trajectoryYs;


        public Form1()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            formatToolStrips();
            InitToolBar();
            formsPlot1.Configure(lowQualityWhileDragging: true);
            trajectoryXs = new double[(int) TrajIters.Value];
            trajectoryYs = new double[(int) TrajIters.Value];
            
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
            InitialDrop.DropDown.SetBounds(InitialDrop.Bounds.X, InitialDrop.Bounds.Bottom, InitialPanel.Width, InitialPanel.Height);


            FractalDrop.DropDownItems.Add(FractalHost);
            FractalDrop.DropDown.Width = FractalPanel.Width;
        }


        private void DrawButton_Click(object sender, EventArgs e)
        {
            formsPlot1.plt.Clear();
            systems.Clear();
            systems.Add(new DynamicalSystem("1", this));

            if (DrawInit.Checked) formsPlot1.plt.Add(systems[0].getIC());
            foreach (PlottableScatter s in systems[0].getDynamicalSystem())
            {
                formsPlot1.plt.Add(s);
            }
            formsPlot1.Render(lowQuality: true);
            (trajectoryXs, trajectoryYs) = systems[0].getTrajectory(0.0, 0.0);
            formsPlot1.plt.Add(new PlottableScatter(trajectoryXs, trajectoryYs));
            if (!traj.Checked) formsPlot1.plt.GetPlottables()[formsPlot1.plt.GetPlottables().Count - 1].visible = false;

        }


        private void ClearButton_Click(object sender, EventArgs e)
        {
            formsPlot1.plt.Clear();
            formsPlot1.Render();

        }

        private void UpdateCoordinates()
        {
            (double x, double y) = formsPlot1.GetMouseCoordinates();
            coor.Text = "Mouse Coordinates: (" + $"{x:N2}, {y:N2}" + ")";
        }

        private void formsPlot1_MouseMoved(object sender, EventArgs e)
        {
            UpdateCoordinates();
            (double mouseX, double mouseY) = formsPlot1.GetMouseCoordinates();
            if (formsPlot1.plt.GetPlottables().Count() > 0 && traj.Checked)
            {
                (trajectoryXs, trajectoryYs) = systems[0].getTrajectory(mouseX, mouseY);
                formsPlot1.plt.GetPlottables()[formsPlot1.plt.GetPlottables().Count - 1] = new PlottableScatter(trajectoryXs, trajectoryYs);
                formsPlot1.Render(skipIfCurrentlyRendering: true, lowQuality: true, processEvents: true);
            }

        }

        FormWindowState LastWindowState = FormWindowState.Normal;
        private void Form1_Resize(object sender, EventArgs e)
        {
            formatToolStrips();
            if (WindowState != LastWindowState)
            {
                LastWindowState = WindowState;
                formatToolStrips();
            }
        }

        private void traj_CheckedChanged(object sender, EventArgs e)
        {
            if (formsPlot1.plt.GetPlottables().Count >= 1)
            {
                formsPlot1.plt.GetPlottables()[formsPlot1.plt.GetPlottables().Count - 1].visible = traj.Checked;
            }
        }
    }
}

