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

namespace WindowsFormsApp1
{
	
	public partial class Form1 : Form
	{

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
			formsPlot1.plt.Clear();
			DynamicalSystem dynamicalSystem = new DynamicalSystem("1", this);
			formsPlot1.plt.Add(dynamicalSystem.getIC());
			foreach (ScottPlot.PlottableScatter s in dynamicalSystem.getDynamicalSystem())
			{
				formsPlot1.plt.Add(s);
			}
			formsPlot1.Render(lowQuality: true);
			
		}

	   
		private void ClearButton_Click(object sender, EventArgs e)
		{
			formsPlot1.plt.Clear();
			formsPlot1.Render();

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

	   

		private void formsPlot1_MouseMoved(object sender, EventArgs e)
		{

			if (traj.Checked)
			{
				formsPlot1.plt.Add;
			}
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
