﻿using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Func1 = new System.Windows.Forms.TextBox();
            this.IncLable = new System.Windows.Forms.Label();
            this.IncValue = new System.Windows.Forms.NumericUpDown();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.Func2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Problabel = new System.Windows.Forms.Label();
            this.Probability = new System.Windows.Forms.NumericUpDown();
            this.label1b = new System.Windows.Forms.Label();
            this.Func1b = new System.Windows.Forms.TextBox();
            this.formsPlot1b = new ScottPlot.FormsPlot();
            this.Func2b = new System.Windows.Forms.TextBox();
            this.label3b = new System.Windows.Forms.Label();
            this.label4b = new System.Windows.Forms.Label();
            this.Problabel_b = new System.Windows.Forms.Label();
            this.Probability_b = new System.Windows.Forms.NumericUpDown();
            this.label1c = new System.Windows.Forms.Label();
            this.Func1c = new System.Windows.Forms.TextBox();
            this.formsPlot1c = new ScottPlot.FormsPlot();
            this.Func2c = new System.Windows.Forms.TextBox();
            this.label3c = new System.Windows.Forms.Label();
            this.label4c = new System.Windows.Forms.Label();
            this.Problabel_c = new System.Windows.Forms.Label();
            this.Probability_c = new System.Windows.Forms.NumericUpDown();
            this.iters = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.InitialCondition = new System.Windows.Forms.Label();
            this.Initial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.finish = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.NumericUpDown();
            this.DrawInit = new System.Windows.Forms.CheckBox();
            this.traj = new System.Windows.Forms.CheckBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.DrawButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ClearButton = new System.Windows.Forms.ToolStripButton();
            this.InitialPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DrawDrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.coor = new System.Windows.Forms.ToolStripTextBox();
            this.InitialDrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FractalDrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.TrajIterPanel = new System.Windows.Forms.Panel();
            this.DrawFunc = new System.Windows.Forms.CheckBox();
            this.TrajIters = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.FractalPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.IncValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.InitialPanel.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.TrajIterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrajIters)).BeginInit();
            this.FractalPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(3);
            this.label1.Size = new System.Drawing.Size(131, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "F(x,y) = (";
            // 
            // Func1
            // 
            this.Func1.Location = new System.Drawing.Point(154, 20);
            this.Func1.Name = "Func1";
            this.Func1.Size = new System.Drawing.Size(195, 38);
            this.Func1.TabIndex = 1;
            // 
            // IncLable
            // 
            this.IncLable.AutoSize = true;
            this.IncLable.Location = new System.Drawing.Point(11, 68);
            this.IncLable.Name = "IncLable";
            this.IncLable.Size = new System.Drawing.Size(148, 32);
            this.IncLable.TabIndex = 3;
            this.IncLable.Text = "Increment:";
            // 
            // IncValue
            // 
            this.IncValue.AutoSize = true;
            this.IncValue.DecimalPlaces = 3;
            this.IncValue.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.IncValue.Location = new System.Drawing.Point(203, 66);
            this.IncValue.Name = "IncValue";
            this.IncValue.Size = new System.Drawing.Size(159, 38);
            this.IncValue.TabIndex = 7;
            this.IncValue.Tag = "double";
            this.IncValue.Value = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            // 
            // formsPlot1
            // 
            this.formsPlot1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1.Location = new System.Drawing.Point(0, 0);
            this.formsPlot1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formsPlot1.Name = "formsPlot1";
            this.formsPlot1.Size = new System.Drawing.Size(1557, 872);
            this.formsPlot1.TabIndex = 8;
            this.formsPlot1.MouseMoved += new System.Windows.Forms.MouseEventHandler(this.formsPlot1_MouseMoved);
            // 
            // Func2
            // 
            this.Func2.Location = new System.Drawing.Point(429, 20);
            this.Func2.Name = "Func2";
            this.Func2.Size = new System.Drawing.Size(195, 38);
            this.Func2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 17);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(3);
            this.label3.Size = new System.Drawing.Size(29, 38);
            this.label3.TabIndex = 10;
            this.label3.Text = ",";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 17);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3);
            this.label4.Size = new System.Drawing.Size(30, 38);
            this.label4.TabIndex = 11;
            this.label4.Text = ")";
            //
            //Problabel
            //
            this.Problabel.AutoSize = true;
            this.Problabel.Location = new System.Drawing.Point(689, 17);
            this.Problabel.Name = "Problabel";
            this.Problabel.Padding = new System.Windows.Forms.Padding(3);
            this.Problabel.Size = new System.Drawing.Size(30, 38);
            this.Problabel.TabIndex = 12;
            this.Problabel.Text = "Probability: ";
            //
            //Probability
            //
            this.Probability.AutoSize = true;
            this.Probability.DecimalPlaces = 3;
            this.Probability.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Probability.Location = new System.Drawing.Point(900, 17);
            this.Probability.Name = "Probability";
            this.Probability.Size = new System.Drawing.Size(159, 38);
            this.Probability.TabIndex = 7;
            this.Probability.Tag = "double";
            this.Probability.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // label1b
            // 
            this.label1b.AutoSize = true;
            this.label1b.Location = new System.Drawing.Point(3, 117);
            this.label1b.Name = "label1b";
            this.label1b.Padding = new System.Windows.Forms.Padding(3);
            this.label1b.Size = new System.Drawing.Size(131, 38);
            this.label1b.TabIndex = 0;
            this.label1b.Text = "G(x,y) = (";
            //
            // Func1b
            //
            this.Func1b.Location = new System.Drawing.Point(154, 120);
            this.Func1b.Name = "Func1b";
            this.Func1b.Size = new System.Drawing.Size(195, 38);
            this.Func1b.TabIndex = 9;
            // 
            // formsPlot1b
            // 
            this.formsPlot1b.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1b.Location = new System.Drawing.Point(0, 0);
            this.formsPlot1b.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formsPlot1b.Name = "formsPlot1b";
            this.formsPlot1b.Size = new System.Drawing.Size(1557, 790);
            this.formsPlot1b.TabIndex = 8;
            this.formsPlot1b.MouseMoved += new System.Windows.Forms.MouseEventHandler(this.formsPlot1_MouseMoved);
            //
            // Func2b
            //
            this.Func2b.Location = new System.Drawing.Point(429, 120);
            this.Func2b.Name = "Func2b";
            this.Func2b.Size = new System.Drawing.Size(195, 38);
            this.Func2b.TabIndex = 9;
            // 
            // label3b
            // 
            this.label3b.AutoSize = true;
            this.label3b.Location = new System.Drawing.Point(373, 117);
            this.label3b.Name = "label3b";
            this.label3b.Padding = new System.Windows.Forms.Padding(3);
            this.label3b.Size = new System.Drawing.Size(29, 38);
            this.label3b.TabIndex = 10;
            this.label3b.Text = ",";
            // 
            // label4b
            // 
            this.label4b.AutoSize = true;
            this.label4b.Location = new System.Drawing.Point(639, 117);
            this.label4b.Name = "label4b";
            this.label4b.Padding = new System.Windows.Forms.Padding(3);
            this.label4b.Size = new System.Drawing.Size(30, 38);
            this.label4b.TabIndex = 11;
            this.label4b.Text = ")";
            //
            //Problabel_b
            //
            this.Problabel_b.AutoSize = true;
            this.Problabel_b.Location = new System.Drawing.Point(689, 117);
            this.Problabel_b.Name = "Problabel_b";
            this.Problabel_b.Padding = new System.Windows.Forms.Padding(3);
            this.Problabel_b.Size = new System.Drawing.Size(30, 38);
            this.Problabel_b.TabIndex = 12;
            this.Problabel_b.Text = "Probability: ";
            //
            //Probability_b
            //
            this.Probability_b.AutoSize = true;
            this.Probability_b.DecimalPlaces = 3;
            this.Probability_b.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Probability_b.Location = new System.Drawing.Point(900, 117);
            this.Probability_b.Name = "Probability_b";
            this.Probability_b.Size = new System.Drawing.Size(159, 38);
            this.Probability_b.TabIndex = 7;
            this.Probability_b.Tag = "double";
            this.Probability_b.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // label1c
            // 
            this.label1c.AutoSize = true;
            this.label1c.Location = new System.Drawing.Point(3, 217);
            this.label1c.Name = "label1c";
            this.label1c.Padding = new System.Windows.Forms.Padding(3);
            this.label1c.Size = new System.Drawing.Size(131, 38);
            this.label1c.TabIndex = 0;
            this.label1c.Text = "H(x,y) = (";
            //
            // Func1c
            //
            this.Func1c.Location = new System.Drawing.Point(154, 220);
            this.Func1c.Name = "Func1c";
            this.Func1c.Size = new System.Drawing.Size(195, 38);
            this.Func1c.TabIndex = 9;
            // 
            // formsPlot1c
            // 
            this.formsPlot1c.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formsPlot1c.Location = new System.Drawing.Point(0, 0);
            this.formsPlot1c.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formsPlot1c.Name = "formsPlot1c";
            this.formsPlot1c.Size = new System.Drawing.Size(1557, 790);
            this.formsPlot1c.TabIndex = 8;
            this.formsPlot1c.MouseMoved += new System.Windows.Forms.MouseEventHandler(this.formsPlot1_MouseMoved);
            //
            // Func2c
            //
            this.Func2c.Location = new System.Drawing.Point(429, 220);
            this.Func2c.Name = "Func2c";
            this.Func2c.Size = new System.Drawing.Size(195, 38);
            this.Func2c.TabIndex = 9;
            // 
            // label3c
            // 
            this.label3c.AutoSize = true;
            this.label3c.Location = new System.Drawing.Point(373, 217);
            this.label3c.Name = "label3c";
            this.label3c.Padding = new System.Windows.Forms.Padding(3);
            this.label3c.Size = new System.Drawing.Size(29, 38);
            this.label3c.TabIndex = 10;
            this.label3c.Text = ",";
            // 
            // label4c
            // 
            this.label4c.AutoSize = true;
            this.label4c.Location = new System.Drawing.Point(639, 217);
            this.label4c.Name = "label4c";
            this.label4c.Padding = new System.Windows.Forms.Padding(3);
            this.label4c.Size = new System.Drawing.Size(30, 38);
            this.label4c.TabIndex = 11;
            this.label4c.Text = ")";
            //
            //Problabel_c
            //
            this.Problabel_c.AutoSize = true;
            this.Problabel_c.Location = new System.Drawing.Point(689, 217);
            this.Problabel_c.Name = "Problabel_c";
            this.Problabel_c.Padding = new System.Windows.Forms.Padding(3);
            this.Problabel_c.Size = new System.Drawing.Size(30, 38);
            this.Problabel_c.TabIndex = 12;
            this.Problabel_c.Text = "Probability: ";
            //
            //Probability_c
            //
            this.Probability_c.AutoSize = true;
            this.Probability_c.DecimalPlaces = 3;
            this.Probability_c.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.Probability_c.Location = new System.Drawing.Point(900, 217);
            this.Probability_c.Name = "Probability_c";
            this.Probability_c.Size = new System.Drawing.Size(159, 38);
            this.Probability_c.TabIndex = 7;
            this.Probability_c.Tag = "double";
            this.Probability_c.Value = new decimal(new int[] {
            50,
            0,
            0,
            131072});
            // 
            // iters
            // 
            this.iters.AutoSize = true;
            this.iters.Location = new System.Drawing.Point(160, 62);
            this.iters.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.iters.Name = "iters";
            this.iters.Size = new System.Drawing.Size(151, 38);
            this.iters.TabIndex = 12;
            this.iters.Tag = "";
            this.iters.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Iterations:";
            // 
            // InitialCondition
            // 
            this.InitialCondition.AutoSize = true;
            this.InitialCondition.Location = new System.Drawing.Point(8, 9);
            this.InitialCondition.Name = "InitialCondition";
            this.InitialCondition.Size = new System.Drawing.Size(84, 32);
            this.InitialCondition.TabIndex = 15;
            this.InitialCondition.Text = "I(x) = ";
            // 
            // Initial
            // 
            this.Initial.Location = new System.Drawing.Point(89, 6);
            this.Initial.Name = "Initial";
            this.Initial.Size = new System.Drawing.Size(105, 38);
            this.Initial.TabIndex = 16;
            this.Initial.Text = "x";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lower: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 129);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(3);
            this.label7.Size = new System.Drawing.Size(106, 38);
            this.label7.TabIndex = 18;
            this.label7.Text = "Upper:";
            // 
            // finish
            // 
            this.finish.Location = new System.Drawing.Point(119, 127);
            this.finish.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.finish.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.finish.Name = "finish";
            this.finish.Size = new System.Drawing.Size(75, 38);
            this.finish.TabIndex = 19;
            this.finish.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(117, 183);
            this.start.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.start.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(88, 38);
            this.start.TabIndex = 20;
            this.start.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            // 
            // DrawInit
            // 
            this.DrawInit.AutoSize = true;
            this.DrawInit.Location = new System.Drawing.Point(9, 119);
            this.DrawInit.Name = "DrawInit";
            this.DrawInit.Size = new System.Drawing.Size(275, 36);
            this.DrawInit.TabIndex = 21;
            this.DrawInit.Text = "Draw Initial Curve";
            this.DrawInit.UseVisualStyleBackColor = true;
            // 
            // traj
            // 
            this.traj.AutoSize = true;
            this.traj.Location = new System.Drawing.Point(9, 161);
            this.traj.Name = "traj";
            this.traj.Size = new System.Drawing.Size(257, 36);
            this.traj.TabIndex = 22;
            this.traj.Text = "Show Trajectory";
            this.traj.UseVisualStyleBackColor = true;
            this.traj.CheckedChanged += new System.EventHandler(this.traj_CheckedChanged);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.toolStrip3);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.formsPlot1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.InitialPanel);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1557, 872);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1557, 976);
            this.toolStripContainer1.TabIndex = 25;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawButton,
            this.toolStripSeparator3,
            this.ClearButton});
            this.toolStrip3.Location = new System.Drawing.Point(8, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(211, 52);
            this.toolStrip3.TabIndex = 0;
            // 
            // DrawButton
            // 
            this.DrawButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DrawButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawButton.Image")));
            this.DrawButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(90, 45);
            this.DrawButton.Text = "Draw";
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 52);
            // 
            // ClearButton
            // 
            this.ClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ClearButton.Image")));
            this.ClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(89, 45);
            this.ClearButton.Text = "Clear";
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // InitialPanel
            // 
            this.InitialPanel.AutoSize = true;
            this.InitialPanel.Controls.Add(this.start);
            this.InitialPanel.Controls.Add(this.label6);
            this.InitialPanel.Controls.Add(this.finish);
            this.InitialPanel.Controls.Add(this.label7);
            this.InitialPanel.Controls.Add(this.IncLable);
            this.InitialPanel.Controls.Add(this.Initial);
            this.InitialPanel.Controls.Add(this.IncValue);
            this.InitialPanel.Controls.Add(this.InitialCondition);
            this.InitialPanel.Location = new System.Drawing.Point(630, 227);
            this.InitialPanel.Name = "InitialPanel";
            this.InitialPanel.Size = new System.Drawing.Size(511, 242);
            this.InitialPanel.TabIndex = 25;
            // 
            // toolStrip2
            // 
            this.toolStrip2.AllowMerge = false;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coor});
            this.toolStrip2.Location = new System.Drawing.Point(8, 62);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(358, 62);
            this.toolStrip2.TabIndex = 1;
            // 
            // coor
            // 
            this.coor.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.coor.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.coor.Name = "coor";
            this.coor.ReadOnly = true;
            this.coor.Size = new System.Drawing.Size(250, 47);
            this.coor.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowMerge = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DrawDrop,
            this.toolStripSeparator1,
            this.InitialDrop,
            this.toolStripSeparator2,
            this.FractalDrop});
            this.toolStrip1.Location = new System.Drawing.Point(8, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(612, 52);
            this.toolStrip1.TabIndex = 0;
            // 
            // DrawDrop
            // 
            this.DrawDrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DrawDrop.Image = ((System.Drawing.Image)(resources.GetObject("DrawDrop.Image")));
            this.DrawDrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawDrop.Name = "DrawDrop";
            this.DrawDrop.Size = new System.Drawing.Size(112, 45);
            this.DrawDrop.Text = "Draw";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 52);
            // 
            // InitialDrop
            // 
            this.InitialDrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.InitialDrop.Image = ((System.Drawing.Image)(resources.GetObject("InitialDrop.Image")));
            this.InitialDrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.InitialDrop.Name = "InitialDrop";
            this.InitialDrop.Size = new System.Drawing.Size(254, 45);
            this.InitialDrop.Text = "Initial Condition";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            // 
            // FractalDrop
            // 
            this.FractalDrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FractalDrop.Image = ((System.Drawing.Image)(resources.GetObject("FractalDrop.Image")));
            this.FractalDrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FractalDrop.Name = "FractalDrop";
            this.FractalDrop.Size = new System.Drawing.Size(130, 45);
            this.FractalDrop.Text = "Fractal";
            // 
            // TrajIterPanel
            // 
            this.TrajIterPanel.AutoSize = true;
            this.TrajIterPanel.Controls.Add(this.label5);
            this.TrajIterPanel.Controls.Add(this.iters);
            this.TrajIterPanel.Controls.Add(this.DrawFunc);
            this.TrajIterPanel.Controls.Add(this.DrawInit);
            this.TrajIterPanel.Controls.Add(this.traj);
            this.TrajIterPanel.Controls.Add(this.TrajIters);
            this.TrajIterPanel.Controls.Add(this.label8);
            this.TrajIterPanel.Location = new System.Drawing.Point(875, 270);
            this.TrajIterPanel.Name = "TrajIterPanel";
            this.TrajIterPanel.Size = new System.Drawing.Size(476, 277);
            this.TrajIterPanel.TabIndex = 15;
            // 
            // DrawFunc
            // 
            this.DrawFunc.AutoSize = true;
            this.DrawFunc.Checked = true;
            this.DrawFunc.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DrawFunc.Location = new System.Drawing.Point(9, 21);
            this.DrawFunc.Name = "DrawFunc";
            this.DrawFunc.Size = new System.Drawing.Size(235, 36);
            this.DrawFunc.TabIndex = 27;
            this.DrawFunc.Text = "Draw Function";
            this.DrawFunc.UseVisualStyleBackColor = true;
            // 
            // TrajIters
            // 
            this.TrajIters.Location = new System.Drawing.Point(297, 216);
            this.TrajIters.Name = "TrajIters";
            this.TrajIters.Size = new System.Drawing.Size(120, 38);
            this.TrajIters.TabIndex = 1;
            this.TrajIters.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(273, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trajectory Iterations:";
            // 
            // FractalPanel
            // 
            this.FractalPanel.AutoSize = true;
            this.FractalPanel.Controls.Add(this.label4);
            this.FractalPanel.Controls.Add(this.label1);
            this.FractalPanel.Controls.Add(this.label3);
            this.FractalPanel.Controls.Add(this.Func1);
            this.FractalPanel.Controls.Add(this.Func2);
            this.FractalPanel.Location = new System.Drawing.Point(682, 123);
            this.FractalPanel.Name = "FractalPanel";
            this.FractalPanel.Size = new System.Drawing.Size(710, 76);
            this.FractalPanel.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1557, 976);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.TrajIterPanel);
            this.Controls.Add(this.FractalPanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DSGraph";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.IncValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).EndInit();
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.InitialPanel.ResumeLayout(false);
            this.InitialPanel.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.TrajIterPanel.ResumeLayout(false);
            this.TrajIterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrajIters)).EndInit();
            this.FractalPanel.ResumeLayout(false);
            this.FractalPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //Funcitons
        public System.Windows.Forms.TextBox Func1;
        public System.Windows.Forms.TextBox Func2;
        public System.Windows.Forms.TextBox Func1b;
        public System.Windows.Forms.TextBox Func2b;
        public System.Windows.Forms.TextBox Func1c;
        public System.Windows.Forms.TextBox Func2c;
        public System.Windows.Forms.TextBox Initial;
        //Toggles
        public System.Windows.Forms.CheckBox DrawInit;
        public System.Windows.Forms.CheckBox traj;
        public System.Windows.Forms.CheckBox DrawFunc;
        //Values
        public System.Windows.Forms.NumericUpDown IncValue;
        public System.Windows.Forms.NumericUpDown Probability;
        public System.Windows.Forms.NumericUpDown Probability_b;
        public System.Windows.Forms.NumericUpDown Probability_c;
        public System.Windows.Forms.NumericUpDown iters;
        public System.Windows.Forms.NumericUpDown start;
        public System.Windows.Forms.NumericUpDown finish;
        public System.Windows.Forms.NumericUpDown TrajIters;
        //Formatting
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label IncLable;
        public ScottPlot.FormsPlot formsPlot1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Problabel;
        private System.Windows.Forms.Label Problabel_b;
        private System.Windows.Forms.Label label1b;
        public ScottPlot.FormsPlot formsPlot1b;
        private System.Windows.Forms.Label label3b;
        private System.Windows.Forms.Label label4b;
        private System.Windows.Forms.Label Problabel_c;
        private System.Windows.Forms.Label label1c;
        public ScottPlot.FormsPlot formsPlot1c;
        private System.Windows.Forms.Label label3c;
        private System.Windows.Forms.Label label4c;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label InitialCondition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton DrawDrop;
        private System.Windows.Forms.Panel InitialPanel;
        private System.Windows.Forms.ToolStripDropDownButton InitialDrop;
        private System.Windows.Forms.Panel TrajIterPanel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel FractalPanel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton FractalDrop;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton DrawButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ClearButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripTextBox coor;
    }
}

