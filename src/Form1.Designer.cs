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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Func1 = new System.Windows.Forms.TextBox();
            this.IncLable = new System.Windows.Forms.Label();
            this.IncValue = new System.Windows.Forms.NumericUpDown();
            this.formsPlot1 = new ScottPlot.FormsPlot();
            this.Func2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.TrajIterPanel = new System.Windows.Forms.Panel();
            this.DrawFunc = new System.Windows.Forms.CheckBox();
            this.TrajIters = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.FractalPanel = new System.Windows.Forms.Panel();
            this.InitialPanel = new System.Windows.Forms.Panel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.coor = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DrawDrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.InitialDrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FractalDrop = new System.Windows.Forms.ToolStripDropDownButton();
            ((System.ComponentModel.ISupportInitialize)(this.IncValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start)).BeginInit();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.TrajIterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrajIters)).BeginInit();
            this.FractalPanel.SuspendLayout();
            this.InitialPanel.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            //Markov Chain Things
            this.DrawMarkovChain = new System.Windows.Forms.CheckBox();
            this.MarkovChainRandomState = new System.Windows.Forms.CheckBox();
            this.MarkovPanel = new System.Windows.Forms.Panel();
            this.MarkovDrop = new System.Windows.Forms.ToolStripDropDownButton();
            this.MarkovPanel.SuspendLayout();
            this.MarkovStartingStateLabel = new System.Windows.Forms.Label();
            this.MarkovStartingState = new System.Windows.Forms.NumericUpDown();
            this.MarkovProbLabelMain = new System.Windows.Forms.Label();
            this.MarkovProbLabel1 = new System.Windows.Forms.Label();
            this.MarkovProbLabel2 = new System.Windows.Forms.Label();
            this.MarkovProbLabel3 = new System.Windows.Forms.Label();
            this.MarkovProbLabel4 = new System.Windows.Forms.Label();
            this.MarkovProbLabel5 = new System.Windows.Forms.Label();
            this.MarkovLabel1a = new System.Windows.Forms.Label();
            this.MarkovFunc1a = new System.Windows.Forms.TextBox();
            this.MarkovLabel1b = new System.Windows.Forms.Label();
            this.MarkovFunc1b = new System.Windows.Forms.TextBox();
            this.MarkovLabel1c = new System.Windows.Forms.Label();
            this.MarkovProb1to1 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb1to2 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb1to3 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb1to4 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb1to5 = new System.Windows.Forms.NumericUpDown();
            this.MarkovLabel2a = new System.Windows.Forms.Label();
            this.MarkovFunc2a = new System.Windows.Forms.TextBox();
            this.MarkovLabel2b = new System.Windows.Forms.Label();
            this.MarkovFunc2b = new System.Windows.Forms.TextBox();
            this.MarkovLabel2c = new System.Windows.Forms.Label();
            this.MarkovProb2to1 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb2to2 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb2to3 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb2to4 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb2to5 = new System.Windows.Forms.NumericUpDown();
            this.MarkovLabel3a = new System.Windows.Forms.Label();
            this.MarkovFunc3a = new System.Windows.Forms.TextBox();
            this.MarkovLabel3b = new System.Windows.Forms.Label();
            this.MarkovFunc3b = new System.Windows.Forms.TextBox();
            this.MarkovLabel3c = new System.Windows.Forms.Label();
            this.MarkovProb3to1 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb3to2 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb3to3 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb3to4 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb3to5 = new System.Windows.Forms.NumericUpDown();
            this.MarkovLabel4a = new System.Windows.Forms.Label();
            this.MarkovFunc4a = new System.Windows.Forms.TextBox();
            this.MarkovLabel4b = new System.Windows.Forms.Label();
            this.MarkovFunc4b = new System.Windows.Forms.TextBox();
            this.MarkovLabel4c = new System.Windows.Forms.Label();
            this.MarkovProb4to1 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb4to2 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb4to3 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb4to4 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb4to5 = new System.Windows.Forms.NumericUpDown();
            this.MarkovLabel5a = new System.Windows.Forms.Label();
            this.MarkovFunc5a = new System.Windows.Forms.TextBox();
            this.MarkovLabel5b = new System.Windows.Forms.Label();
            this.MarkovFunc5b = new System.Windows.Forms.TextBox();
            this.MarkovLabel5c = new System.Windows.Forms.Label();
            this.MarkovProb5to1 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb5to2 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb5to3 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb5to4 = new System.Windows.Forms.NumericUpDown();
            this.MarkovProb5to5 = new System.Windows.Forms.NumericUpDown();

            //

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
            this.formsPlot1.Size = new System.Drawing.Size(1557, 790);
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
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1557, 790);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1557, 976);
            this.toolStripContainer1.TabIndex = 25;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
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
            this.toolStrip3.Size = new System.Drawing.Size(211, 62);
            this.toolStrip3.TabIndex = 0;
            // 
            // DrawButton
            // 
            this.DrawButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DrawButton.Image = ((System.Drawing.Image)(resources.GetObject("DrawButton.Image")));
            this.DrawButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(90, 55);
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
            this.TrajIterPanel.Controls.Add(this.DrawMarkovChain);
            this.TrajIterPanel.Controls.Add(this.MarkovChainRandomState);
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
            this.FractalDrop,
            this.toolStripSeparator3,
            this.MarkovDrop});
            this.toolStrip1.Location = new System.Drawing.Point(8, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(534, 62);
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 52);
            //
            // MarkovPanel
            //
            this.MarkovPanel.AutoSize = true;
            this.MarkovPanel.Controls.Add(this.MarkovStartingStateLabel);
            this.MarkovPanel.Controls.Add(this.MarkovStartingState);
            this.MarkovPanel.Controls.Add(this.MarkovProbLabelMain);
            this.MarkovPanel.Controls.Add(this.MarkovProbLabel1);
            this.MarkovPanel.Controls.Add(this.MarkovProbLabel2);
            this.MarkovPanel.Controls.Add(this.MarkovProbLabel3);
            this.MarkovPanel.Controls.Add(this.MarkovProbLabel4);
            this.MarkovPanel.Controls.Add(this.MarkovProbLabel5);
            this.MarkovPanel.Controls.Add(this.MarkovLabel1a);
            this.MarkovPanel.Controls.Add(this.MarkovFunc1a);
            this.MarkovPanel.Controls.Add(this.MarkovLabel1b);
            this.MarkovPanel.Controls.Add(this.MarkovFunc1b);
            this.MarkovPanel.Controls.Add(this.MarkovLabel1c);
            this.MarkovPanel.Controls.Add(this.MarkovProb1to1);
            this.MarkovPanel.Controls.Add(this.MarkovProb1to2);
            this.MarkovPanel.Controls.Add(this.MarkovProb1to3);
            this.MarkovPanel.Controls.Add(this.MarkovProb1to4);
            this.MarkovPanel.Controls.Add(this.MarkovProb1to5);
            this.MarkovPanel.Controls.Add(this.MarkovLabel2a);
            this.MarkovPanel.Controls.Add(this.MarkovFunc2a);
            this.MarkovPanel.Controls.Add(this.MarkovLabel2b);
            this.MarkovPanel.Controls.Add(this.MarkovFunc2b);
            this.MarkovPanel.Controls.Add(this.MarkovLabel2c);
            this.MarkovPanel.Controls.Add(this.MarkovProb2to1);
            this.MarkovPanel.Controls.Add(this.MarkovProb2to2);
            this.MarkovPanel.Controls.Add(this.MarkovProb2to3);
            this.MarkovPanel.Controls.Add(this.MarkovProb2to4);
            this.MarkovPanel.Controls.Add(this.MarkovProb2to5);
            this.MarkovPanel.Controls.Add(this.MarkovLabel3a);
            this.MarkovPanel.Controls.Add(this.MarkovFunc3a);
            this.MarkovPanel.Controls.Add(this.MarkovLabel3b);
            this.MarkovPanel.Controls.Add(this.MarkovFunc3b);
            this.MarkovPanel.Controls.Add(this.MarkovLabel3c);
            this.MarkovPanel.Controls.Add(this.MarkovProb3to1);
            this.MarkovPanel.Controls.Add(this.MarkovProb3to2);
            this.MarkovPanel.Controls.Add(this.MarkovProb3to3);
            this.MarkovPanel.Controls.Add(this.MarkovProb3to4);
            this.MarkovPanel.Controls.Add(this.MarkovProb3to5);
            this.MarkovPanel.Controls.Add(this.MarkovLabel4a);
            this.MarkovPanel.Controls.Add(this.MarkovFunc4a);
            this.MarkovPanel.Controls.Add(this.MarkovLabel4b);
            this.MarkovPanel.Controls.Add(this.MarkovFunc4b);
            this.MarkovPanel.Controls.Add(this.MarkovLabel4c);
            this.MarkovPanel.Controls.Add(this.MarkovProb4to1);
            this.MarkovPanel.Controls.Add(this.MarkovProb4to2);
            this.MarkovPanel.Controls.Add(this.MarkovProb4to3);
            this.MarkovPanel.Controls.Add(this.MarkovProb4to4);
            this.MarkovPanel.Controls.Add(this.MarkovProb4to5);
            this.MarkovPanel.Controls.Add(this.MarkovLabel5a);
            this.MarkovPanel.Controls.Add(this.MarkovFunc5a);
            this.MarkovPanel.Controls.Add(this.MarkovLabel5b);
            this.MarkovPanel.Controls.Add(this.MarkovFunc5b);
            this.MarkovPanel.Controls.Add(this.MarkovLabel5c);
            this.MarkovPanel.Controls.Add(this.MarkovProb5to1);
            this.MarkovPanel.Controls.Add(this.MarkovProb5to2);
            this.MarkovPanel.Controls.Add(this.MarkovProb5to3);
            this.MarkovPanel.Controls.Add(this.MarkovProb5to4);
            this.MarkovPanel.Controls.Add(this.MarkovProb5to5);
            this.MarkovPanel.Location = new System.Drawing.Point(730, 227);
            this.MarkovPanel.Name = "MarkovPanel";
            this.MarkovPanel.Size = new System.Drawing.Size(511, 242);
            this.MarkovPanel.TabIndex = 25;
            // 
            // DrawMarkovChain
            // 
            this.DrawMarkovChain.AutoSize = true;
            this.DrawMarkovChain.Checked = true;
            this.DrawMarkovChain.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.DrawMarkovChain.Location = new System.Drawing.Point(9, 301);
            this.DrawMarkovChain.Name = "DrawMarkovChain";
            this.DrawMarkovChain.Size = new System.Drawing.Size(235, 36);
            this.DrawMarkovChain.TabIndex = 27;
            this.DrawMarkovChain.Text = "Use Markov Chain";
            this.DrawMarkovChain.UseVisualStyleBackColor = true;
            //
            // MarkovChainRandomState
            //
            this.MarkovChainRandomState.AutoSize = true;
            this.MarkovChainRandomState.Checked = true;
            this.MarkovChainRandomState.CheckState = System.Windows.Forms.CheckState.Unchecked;
            this.MarkovChainRandomState.Location = new System.Drawing.Point(9, 351);
            this.MarkovChainRandomState.Name = "MarkovChainRandomState";
            this.MarkovChainRandomState.Size = new System.Drawing.Size(235, 36);
            this.MarkovChainRandomState.TabIndex = 27;
            this.MarkovChainRandomState.Text = "Use random starting state for Markov Chain";
            this.MarkovChainRandomState.UseVisualStyleBackColor = true;
            //
            // MarkovDrop
            //
            this.MarkovDrop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MarkovDrop.Image = ((System.Drawing.Image)(resources.GetObject("MarkovDrop.Image")));
            this.MarkovDrop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MarkovDrop.Name = "MarkovDrop";
            this.MarkovDrop.Size = new System.Drawing.Size(254, 45);
            this.MarkovDrop.Text = "Markov Chain";
            //
            // MarkovStartingStateLabel
            // 
            this.MarkovStartingStateLabel.AutoSize = true;
            this.MarkovStartingStateLabel.Location = new System.Drawing.Point(3, 17);
            this.MarkovStartingStateLabel.Name = "MarkovStartingStateLabel";
            this.MarkovStartingStateLabel.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovStartingStateLabel.Size = new System.Drawing.Size(131, 38);
            this.MarkovStartingStateLabel.TabIndex = 0;
            this.MarkovStartingStateLabel.Text = "Markov Chain Starting State:";
            //
            //MarkovStartingState
            //
            this.MarkovStartingState.AutoSize = true;
            this.MarkovStartingState.Value = 1;
            this.MarkovStartingState.Minimum = 1;
            this.MarkovStartingState.Maximum = 5;
            this.MarkovStartingState.Location = new System.Drawing.Point(453, 17);
            this.MarkovStartingState.Name = "MarkovStartingState";
            //
            // MarkovProbLabelMain
            // 
            this.MarkovProbLabelMain.AutoSize = true;
            this.MarkovProbLabelMain.Location = new System.Drawing.Point(998, 17);
            this.MarkovProbLabelMain.Name = "MarkovProbLabelMain";
            this.MarkovProbLabelMain.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovProbLabelMain.Size = new System.Drawing.Size(131, 38);
            this.MarkovProbLabelMain.TabIndex = 0;
            this.MarkovProbLabelMain.Text = "Probability of Going to State";
            //
            // MarkovProbLabel1
            // 
            this.MarkovProbLabel1.AutoSize = true;
            this.MarkovProbLabel1.Location = new System.Drawing.Point(898, 50);
            this.MarkovProbLabel1.Name = "MarkovProbLabel1";
            this.MarkovProbLabel1.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovProbLabel1.Size = new System.Drawing.Size(131, 38);
            this.MarkovProbLabel1.TabIndex = 0;
            this.MarkovProbLabel1.Text = "1";
            //
            // MarkovProbLabel2
            // 
            this.MarkovProbLabel2.AutoSize = true;
            this.MarkovProbLabel2.Location = new System.Drawing.Point(1048, 50);
            this.MarkovProbLabel2.Name = "MarkovProbLabel2";
            this.MarkovProbLabel2.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovProbLabel2.Size = new System.Drawing.Size(131, 38);
            this.MarkovProbLabel2.TabIndex = 0;
            this.MarkovProbLabel2.Text = "2";
            //
            // MarkovProbLabel3
            // 
            this.MarkovProbLabel3.AutoSize = true;
            this.MarkovProbLabel3.Location = new System.Drawing.Point(1198, 50);
            this.MarkovProbLabel3.Name = "MarkovProbLabel3";
            this.MarkovProbLabel3.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovProbLabel3.Size = new System.Drawing.Size(131, 38);
            this.MarkovProbLabel3.TabIndex = 0;
            this.MarkovProbLabel3.Text = "3";
            //
            // MarkovProbLabel4
            // 
            this.MarkovProbLabel4.AutoSize = true;
            this.MarkovProbLabel4.Location = new System.Drawing.Point(1348, 50);
            this.MarkovProbLabel4.Name = "MarkovProbLabel4";
            this.MarkovProbLabel4.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovProbLabel4.Size = new System.Drawing.Size(131, 38);
            this.MarkovProbLabel4.TabIndex = 0;
            this.MarkovProbLabel4.Text = "4";
            //
            // MarkovProbLabel5
            // 
            this.MarkovProbLabel5.AutoSize = true;
            this.MarkovProbLabel5.Location = new System.Drawing.Point(1498, 50);
            this.MarkovProbLabel5.Name = "MarkovProbLabel5";
            this.MarkovProbLabel5.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovProbLabel5.Size = new System.Drawing.Size(131, 38);
            this.MarkovProbLabel5.TabIndex = 0;
            this.MarkovProbLabel5.Text = "5";
            //
            // MarkovLabel1a
            // 
            this.MarkovLabel1a.AutoSize = true;
            this.MarkovLabel1a.Location = new System.Drawing.Point(3, 92);
            this.MarkovLabel1a.Name = "MarkovLabel1a";
            this.MarkovLabel1a.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel1a.Size = new System.Drawing.Size(131, 38);
            this.MarkovLabel1a.TabIndex = 0;
            this.MarkovLabel1a.Text = "State 1: F(x,y) = (";
            //
            // MarkovFunc1a
            //
            this.MarkovFunc1a.Location = new System.Drawing.Point(263, 92);
            this.MarkovFunc1a.Name = "MarkovFunc1a";
            this.MarkovFunc1a.Size = new System.Drawing.Size(195, 38);
            this.MarkovFunc1a.TabIndex = 9;
            //
            // MarkovLabel1b
            // 
            this.MarkovLabel1b.AutoSize = true;
            this.MarkovLabel1b.Location = new System.Drawing.Point(488, 92);
            this.MarkovLabel1b.Name = "MarkovLabel1b";
            this.MarkovLabel1b.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel1b.Size = new System.Drawing.Size(29, 38);
            this.MarkovLabel1b.TabIndex = 10;
            this.MarkovLabel1b.Text = ",";
            //
            // MarkovFunc1b
            //
            this.MarkovFunc1b.Location = new System.Drawing.Point(538, 92);
            this.MarkovFunc1b.Name = "MarkovFunc1b";
            this.MarkovFunc1b.Size = new System.Drawing.Size(195, 38);
            this.MarkovFunc1b.TabIndex = 9;
            // 
            // MarkovLabel1c
            // 
            this.MarkovLabel1c.AutoSize = true;
            this.MarkovLabel1c.Location = new System.Drawing.Point(748, 92);
            this.MarkovLabel1c.Name = "MarkovLabel1c";
            this.MarkovLabel1c.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel1c.Size = new System.Drawing.Size(30, 38);
            this.MarkovLabel1c.TabIndex = 11;
            this.MarkovLabel1c.Text = ")";
            //
            //MarkovProb1to1
            //
            this.MarkovProb1to1.AutoSize = true;
            this.MarkovProb1to1.Value = 0;
            this.MarkovProb1to1.Minimum = 0;
            this.MarkovProb1to1.Maximum = 1;
            this.MarkovProb1to1.DecimalPlaces = 3;
            this.MarkovProb1to1.Increment = 0.1M;
            this.MarkovProb1to1.Location = new System.Drawing.Point(848, 92);
            this.MarkovProb1to1.Name = "MarkovProb1to1";
            //
            //MarkovProb1to2
            //
            this.MarkovProb1to2.AutoSize = true;
            this.MarkovProb1to2.Value = 0;
            this.MarkovProb1to2.Minimum = 0;
            this.MarkovProb1to2.Maximum = 1;
            this.MarkovProb1to2.DecimalPlaces = 3;
            this.MarkovProb1to2.Increment = 0.1M;
            this.MarkovProb1to2.Location = new System.Drawing.Point(998, 92);
            this.MarkovProb1to2.Name = "MarkovProb1to2";
            //
            //MarkovProb1to3
            //
            this.MarkovProb1to3.AutoSize = true;
            this.MarkovProb1to3.Value = 0;
            this.MarkovProb1to3.Minimum = 0;
            this.MarkovProb1to3.Maximum = 1;
            this.MarkovProb1to3.DecimalPlaces = 3;
            this.MarkovProb1to3.Increment = 0.1M;
            this.MarkovProb1to3.Location = new System.Drawing.Point(1148, 92);
            this.MarkovProb1to3.Name = "MarkovProb1to3";
            //
            //MarkovProb1to4
            //
            this.MarkovProb1to4.AutoSize = true;
            this.MarkovProb1to4.Value = 0;
            this.MarkovProb1to4.Minimum = 0;
            this.MarkovProb1to4.Maximum = 1;
            this.MarkovProb1to4.DecimalPlaces = 3;
            this.MarkovProb1to4.Increment = 0.1M;
            this.MarkovProb1to4.Location = new System.Drawing.Point(1298, 92);
            this.MarkovProb1to4.Name = "MarkovProb1to4";
            //
            //MarkovProb1to5
            //
            this.MarkovProb1to5.AutoSize = true;
            this.MarkovProb1to5.Value = 0;
            this.MarkovProb1to5.Minimum = 0;
            this.MarkovProb1to5.Maximum = 1;
            this.MarkovProb1to5.DecimalPlaces = 3;
            this.MarkovProb1to5.Increment = 0.1M;
            this.MarkovProb1to5.Location = new System.Drawing.Point(1448, 92);
            this.MarkovProb1to5.Name = "MarkovProb1to5";
            //
            // MarkovLabel2a
            // 
            this.MarkovLabel2a.AutoSize = true;
            this.MarkovLabel2a.Location = new System.Drawing.Point(3, 192);
            this.MarkovLabel2a.Name = "MarkovLabel1a";
            this.MarkovLabel2a.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel2a.Size = new System.Drawing.Size(131, 38);
            this.MarkovLabel2a.TabIndex = 0;
            this.MarkovLabel2a.Text = "State 2: F(x,y) = (";
            //
            // MarkovFunc2a
            //
            this.MarkovFunc2a.Location = new System.Drawing.Point(263, 192);
            this.MarkovFunc2a.Name = "MarkovFunc2a";
            this.MarkovFunc2a.Size = new System.Drawing.Size(195, 38);
            this.MarkovFunc2a.TabIndex = 9;
            //
            // MarkovLabel2b
            // 
            this.MarkovLabel2b.AutoSize = true;
            this.MarkovLabel2b.Location = new System.Drawing.Point(488, 192);
            this.MarkovLabel2b.Name = "MarkovLabel2b";
            this.MarkovLabel2b.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel2b.Size = new System.Drawing.Size(29, 38);
            this.MarkovLabel2b.TabIndex = 10;
            this.MarkovLabel2b.Text = ",";
            //
            // MarkovFunc2b
            //
            this.MarkovFunc2b.Location = new System.Drawing.Point(538, 192);
            this.MarkovFunc2b.Name = "MarkovFunc2b";
            this.MarkovFunc2b.Size = new System.Drawing.Size(195, 38);
            this.MarkovFunc2b.TabIndex = 9;
            // 
            // MarkovLabel2c
            // 
            this.MarkovLabel2c.AutoSize = true;
            this.MarkovLabel2c.Location = new System.Drawing.Point(748, 192);
            this.MarkovLabel2c.Name = "MarkovLabel2c";
            this.MarkovLabel2c.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel2c.Size = new System.Drawing.Size(30, 38);
            this.MarkovLabel2c.TabIndex = 11;
            this.MarkovLabel2c.Text = ")";
            //
            //MarkovProb2to1
            //
            this.MarkovProb2to1.AutoSize = true;
            this.MarkovProb2to1.Value = 0;
            this.MarkovProb2to1.Minimum = 0;
            this.MarkovProb2to1.Maximum = 1;
            this.MarkovProb2to1.DecimalPlaces = 3;
            this.MarkovProb2to1.Increment = 0.1M;
            this.MarkovProb2to1.Location = new System.Drawing.Point(848, 192);
            this.MarkovProb2to1.Name = "MarkovProb2to1";
            //
            //MarkovProb2to2
            //
            this.MarkovProb2to2.AutoSize = true;
            this.MarkovProb2to2.Value = 0;
            this.MarkovProb2to2.Minimum = 0;
            this.MarkovProb2to2.Maximum = 1;
            this.MarkovProb2to2.DecimalPlaces = 3;
            this.MarkovProb2to2.Increment = 0.1M;
            this.MarkovProb2to2.Location = new System.Drawing.Point(998, 192);
            this.MarkovProb2to2.Name = "MarkovProb2to2";
            //
            //MarkovProb2to3
            //
            this.MarkovProb2to3.AutoSize = true;
            this.MarkovProb2to3.Value = 0;
            this.MarkovProb2to3.Minimum = 0;
            this.MarkovProb2to3.Maximum = 1;
            this.MarkovProb2to3.DecimalPlaces = 3;
            this.MarkovProb2to3.Increment = 0.1M;
            this.MarkovProb2to3.Location = new System.Drawing.Point(1148, 192);
            this.MarkovProb2to3.Name = "MarkovProb2to3";
            //
            //MarkovProb2to4
            //
            this.MarkovProb2to4.AutoSize = true;
            this.MarkovProb2to4.Value = 0;
            this.MarkovProb2to4.Minimum = 0;
            this.MarkovProb2to4.Maximum = 1;
            this.MarkovProb2to4.DecimalPlaces = 3;
            this.MarkovProb2to4.Increment = 0.1M;
            this.MarkovProb2to4.Location = new System.Drawing.Point(1298, 192);
            this.MarkovProb2to4.Name = "MarkovProb2to4";
            //
            //MarkovProb2to5
            //
            this.MarkovProb2to5.AutoSize = true;
            this.MarkovProb2to5.Value = 0;
            this.MarkovProb2to5.Minimum = 0;
            this.MarkovProb2to5.Maximum = 1;
            this.MarkovProb2to5.DecimalPlaces = 3;
            this.MarkovProb2to5.Increment = 0.1M;
            this.MarkovProb2to5.Location = new System.Drawing.Point(1448, 192);
            this.MarkovProb2to5.Name = "MarkovProb2to5";
            //
            // MarkovLabel3a
            // 
            this.MarkovLabel3a.AutoSize = true;
            this.MarkovLabel3a.Location = new System.Drawing.Point(3, 292);
            this.MarkovLabel3a.Name = "MarkovLabel3a";
            this.MarkovLabel3a.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel3a.Size = new System.Drawing.Size(131, 38);
            this.MarkovLabel3a.TabIndex = 0;
            this.MarkovLabel3a.Text = "State 3: F(x,y) = (";
            //
            // MarkovFunc3a
            //
            this.MarkovFunc3a.Location = new System.Drawing.Point(263, 292);
            this.MarkovFunc3a.Name = "MarkovFunc3a";
            this.MarkovFunc3a.Size = new System.Drawing.Size(195, 38);
            this.MarkovFunc3a.TabIndex = 9;
            //
            // MarkovLabel3b
            // 
            this.MarkovLabel3b.AutoSize = true;
            this.MarkovLabel3b.Location = new System.Drawing.Point(488, 292);
            this.MarkovLabel3b.Name = "MarkovLabel3b";
            this.MarkovLabel3b.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel3b.Size = new System.Drawing.Size(29, 38);
            this.MarkovLabel3b.TabIndex = 10;
            this.MarkovLabel3b.Text = ",";
            //
            // MarkovFunc3b
            //
            this.MarkovFunc3b.Location = new System.Drawing.Point(538, 292);
            this.MarkovFunc3b.Name = "MarkovFunc3b";
            this.MarkovFunc3b.Size = new System.Drawing.Size(195, 38);
            this.MarkovFunc3b.TabIndex = 9;
            // 
            // MarkovLabel3c
            // 
            this.MarkovLabel3c.AutoSize = true;
            this.MarkovLabel3c.Location = new System.Drawing.Point(748, 292);
            this.MarkovLabel3c.Name = "MarkovLabel3c";
            this.MarkovLabel3c.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel3c.Size = new System.Drawing.Size(30, 38);
            this.MarkovLabel3c.TabIndex = 11;
            this.MarkovLabel3c.Text = ")";
            //
            //MarkovProb3to1
            //
            this.MarkovProb3to1.AutoSize = true;
            this.MarkovProb3to1.Value = 0;
            this.MarkovProb3to1.Minimum = 0;
            this.MarkovProb3to1.Maximum = 1;
            this.MarkovProb3to1.DecimalPlaces = 3;
            this.MarkovProb3to1.Increment = 0.1M;
            this.MarkovProb3to1.Location = new System.Drawing.Point(848, 292);
            this.MarkovProb3to1.Name = "MarkovProb3to1";
            //
            //MarkovProb3to2
            //
            this.MarkovProb3to2.AutoSize = true;
            this.MarkovProb3to2.Value = 0;
            this.MarkovProb3to2.Minimum = 0;
            this.MarkovProb3to2.Maximum = 1;
            this.MarkovProb3to2.DecimalPlaces = 3;
            this.MarkovProb3to2.Increment = 0.1M;
            this.MarkovProb3to2.Location = new System.Drawing.Point(998, 292);
            this.MarkovProb3to2.Name = "MarkovProb3to2";
            //
            //MarkovProb3to3
            //
            this.MarkovProb3to3.AutoSize = true;
            this.MarkovProb3to3.Value = 0;
            this.MarkovProb3to3.Minimum = 0;
            this.MarkovProb3to3.Maximum = 1;
            this.MarkovProb3to3.DecimalPlaces = 3;
            this.MarkovProb3to3.Increment = 0.1M;
            this.MarkovProb3to3.Location = new System.Drawing.Point(1148, 292);
            this.MarkovProb3to3.Name = "MarkovProb3to3";
            //
            //MarkovProb3to4
            //
            this.MarkovProb3to4.AutoSize = true;
            this.MarkovProb3to4.Value = 0;
            this.MarkovProb3to4.Minimum = 0;
            this.MarkovProb3to4.Maximum = 1;
            this.MarkovProb3to4.DecimalPlaces = 3;
            this.MarkovProb3to4.Increment = 0.1M;
            this.MarkovProb3to4.Location = new System.Drawing.Point(1298, 292);
            this.MarkovProb3to4.Name = "MarkovProb3to4";
            //
            //MarkovProb3to5
            //
            this.MarkovProb3to5.AutoSize = true;
            this.MarkovProb3to5.Value = 0;
            this.MarkovProb3to5.Minimum = 0;
            this.MarkovProb3to5.Maximum = 1;
            this.MarkovProb3to5.DecimalPlaces = 3;
            this.MarkovProb3to5.Increment = 0.1M;
            this.MarkovProb3to5.Location = new System.Drawing.Point(1448, 292);
            this.MarkovProb3to5.Name = "MarkovProb3to5";
            //
            // MarkovLabel4a
            // 
            this.MarkovLabel4a.AutoSize = true;
            this.MarkovLabel4a.Location = new System.Drawing.Point(3, 392);
            this.MarkovLabel4a.Name = "MarkovLabel4a";
            this.MarkovLabel4a.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel4a.Size = new System.Drawing.Size(131, 38);
            this.MarkovLabel4a.TabIndex = 0;
            this.MarkovLabel4a.Text = "State 4: F(x,y) = (";
            //
            // MarkovFunc4a
            //
            this.MarkovFunc4a.Location = new System.Drawing.Point(263, 392);
            this.MarkovFunc4a.Name = "MarkovFunc4a";
            this.MarkovFunc4a.Size = new System.Drawing.Size(195, 38);
            this.MarkovFunc4a.TabIndex = 9;
            //
            // MarkovLabel4b
            // 
            this.MarkovLabel4b.AutoSize = true;
            this.MarkovLabel4b.Location = new System.Drawing.Point(488, 392);
            this.MarkovLabel4b.Name = "MarkovLabel4b";
            this.MarkovLabel4b.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel4b.Size = new System.Drawing.Size(29, 38);
            this.MarkovLabel4b.TabIndex = 10;
            this.MarkovLabel4b.Text = ",";
            //
            // MarkovFunc4b
            //
            this.MarkovFunc4b.Location = new System.Drawing.Point(538, 392);
            this.MarkovFunc4b.Name = "MarkovFunc4b";
            this.MarkovFunc4b.Size = new System.Drawing.Size(195, 38);
            this.MarkovFunc4b.TabIndex = 9;
            // 
            // MarkovLabel4c
            // 
            this.MarkovLabel4c.AutoSize = true;
            this.MarkovLabel4c.Location = new System.Drawing.Point(748, 392);
            this.MarkovLabel4c.Name = "MarkovLabel4c";
            this.MarkovLabel4c.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel4c.Size = new System.Drawing.Size(30, 38);
            this.MarkovLabel4c.TabIndex = 11;
            this.MarkovLabel4c.Text = ")";
            //
            //MarkovProb4to1
            //
            this.MarkovProb4to1.AutoSize = true;
            this.MarkovProb4to1.Value = 0;
            this.MarkovProb4to1.Minimum = 0;
            this.MarkovProb4to1.Maximum = 1;
            this.MarkovProb4to1.DecimalPlaces = 3;
            this.MarkovProb4to1.Increment = 0.1M;
            this.MarkovProb4to1.Location = new System.Drawing.Point(848, 392);
            this.MarkovProb4to1.Name = "MarkovProb4to1";
            //
            //MarkovProb4to2
            //
            this.MarkovProb4to2.AutoSize = true;
            this.MarkovProb4to2.Value = 0;
            this.MarkovProb4to2.Minimum = 0;
            this.MarkovProb4to2.Maximum = 1;
            this.MarkovProb4to2.DecimalPlaces = 3;
            this.MarkovProb4to2.Increment = 0.1M;
            this.MarkovProb4to2.Location = new System.Drawing.Point(998, 392);
            this.MarkovProb4to2.Name = "MarkovProb4to2";
            //
            //MarkovProb4to3
            //
            this.MarkovProb4to3.AutoSize = true;
            this.MarkovProb4to3.Value = 0;
            this.MarkovProb4to3.Minimum = 0;
            this.MarkovProb4to3.Maximum = 1;
            this.MarkovProb4to3.DecimalPlaces = 3;
            this.MarkovProb4to3.Increment = 0.1M;
            this.MarkovProb4to3.Location = new System.Drawing.Point(1148, 392);
            this.MarkovProb4to3.Name = "MarkovProb4to3";
            //
            //MarkovProb4to4
            //
            this.MarkovProb4to4.AutoSize = true;
            this.MarkovProb4to4.Value = 0;
            this.MarkovProb4to4.Minimum = 0;
            this.MarkovProb4to4.Maximum = 1;
            this.MarkovProb4to4.DecimalPlaces = 3;
            this.MarkovProb4to4.Increment = 0.1M;
            this.MarkovProb4to4.Location = new System.Drawing.Point(1298, 392);
            this.MarkovProb4to4.Name = "MarkovProb4to4";
            //
            //MarkovProb4to5
            //
            this.MarkovProb4to5.AutoSize = true;
            this.MarkovProb4to5.Value = 0;
            this.MarkovProb4to5.Minimum = 0;
            this.MarkovProb4to5.Maximum = 1;
            this.MarkovProb4to5.DecimalPlaces = 3;
            this.MarkovProb4to5.Increment = 0.1M;
            this.MarkovProb4to5.Location = new System.Drawing.Point(1448, 392);
            this.MarkovProb4to5.Name = "MarkovProb4to5";
            //
            // MarkovLabel5a
            // 
            this.MarkovLabel5a.AutoSize = true;
            this.MarkovLabel5a.Location = new System.Drawing.Point(3, 492);
            this.MarkovLabel5a.Name = "MarkovLabel5a";
            this.MarkovLabel5a.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel5a.Size = new System.Drawing.Size(131, 38);
            this.MarkovLabel5a.TabIndex = 0;
            this.MarkovLabel5a.Text = "State 5: F(x,y) = (";
            //
            // MarkovFunc5a
            //
            this.MarkovFunc5a.Location = new System.Drawing.Point(263, 492);
            this.MarkovFunc5a.Name = "MarkovFunc5a";
            this.MarkovFunc5a.Size = new System.Drawing.Size(195, 38);
            this.MarkovFunc5a.TabIndex = 9;
            //
            // MarkovLabel5b
            // 
            this.MarkovLabel5b.AutoSize = true;
            this.MarkovLabel5b.Location = new System.Drawing.Point(488, 492);
            this.MarkovLabel5b.Name = "MarkovLabel5b";
            this.MarkovLabel5b.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel5b.Size = new System.Drawing.Size(29, 38);
            this.MarkovLabel5b.TabIndex = 10;
            this.MarkovLabel5b.Text = ",";
            //
            // MarkovFunc5b
            //
            this.MarkovFunc5b.Location = new System.Drawing.Point(538, 492);
            this.MarkovFunc5b.Name = "MarkovFunc5b";
            this.MarkovFunc5b.Size = new System.Drawing.Size(195, 38);
            this.MarkovFunc5b.TabIndex = 9;
            // 
            // MarkovLabel5c
            // 
            this.MarkovLabel5c.AutoSize = true;
            this.MarkovLabel5c.Location = new System.Drawing.Point(748, 492);
            this.MarkovLabel5c.Name = "MarkovLabel5c";
            this.MarkovLabel5c.Padding = new System.Windows.Forms.Padding(3);
            this.MarkovLabel5c.Size = new System.Drawing.Size(30, 38);
            this.MarkovLabel5c.TabIndex = 11;
            this.MarkovLabel5c.Text = ")";
            //
            //MarkovProb5to1
            //
            this.MarkovProb5to1.AutoSize = true;
            this.MarkovProb5to1.Value = 0;
            this.MarkovProb5to1.Minimum = 0;
            this.MarkovProb5to1.Maximum = 1;
            this.MarkovProb5to1.DecimalPlaces = 3;
            this.MarkovProb5to1.Increment = 0.1M;
            this.MarkovProb5to1.Location = new System.Drawing.Point(848, 492);
            this.MarkovProb5to1.Name = "MarkovProb5to1";
            //
            //MarkovProb5to2
            //
            this.MarkovProb5to2.AutoSize = true;
            this.MarkovProb5to2.Value = 0;
            this.MarkovProb5to2.Minimum = 0;
            this.MarkovProb5to2.Maximum = 1;
            this.MarkovProb5to2.DecimalPlaces = 3;
            this.MarkovProb5to2.Increment = 0.1M;
            this.MarkovProb5to2.Location = new System.Drawing.Point(998, 492);
            this.MarkovProb5to2.Name = "MarkovProb5to2";
            //
            //MarkovProb5to3
            //
            this.MarkovProb5to3.AutoSize = true;
            this.MarkovProb5to3.Value = 0;
            this.MarkovProb5to3.Minimum = 0;
            this.MarkovProb5to3.Maximum = 1;
            this.MarkovProb5to3.DecimalPlaces = 3;
            this.MarkovProb5to3.Increment = 0.1M;
            this.MarkovProb5to3.Location = new System.Drawing.Point(1148, 492);
            this.MarkovProb5to3.Name = "MarkovProb5to3";
            //
            //MarkovProb5to4
            //
            this.MarkovProb5to4.AutoSize = true;
            this.MarkovProb5to4.Value = 0;
            this.MarkovProb5to4.Minimum = 0;
            this.MarkovProb5to4.Maximum = 1;
            this.MarkovProb5to4.DecimalPlaces = 3;
            this.MarkovProb5to4.Increment = 0.1M;
            this.MarkovProb5to4.Location = new System.Drawing.Point(1298, 492);
            this.MarkovProb5to4.Name = "MarkovProb5to4";
            //
            //MarkovProb5to5
            //
            this.MarkovProb5to5.AutoSize = true;
            this.MarkovProb5to5.Value = 0;
            this.MarkovProb5to5.Minimum = 0;
            this.MarkovProb5to5.Maximum = 1;
            this.MarkovProb5to5.DecimalPlaces = 3;
            this.MarkovProb5to5.Increment = 0.1M;
            this.MarkovProb5to5.Location = new System.Drawing.Point(1448, 492);
            this.MarkovProb5to5.Name = "MarkovProb5to5";

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
            this.Controls.Add(this.MarkovPanel);
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
            this.TrajIterPanel.ResumeLayout(false);
            this.TrajIterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrajIters)).EndInit();
            this.FractalPanel.ResumeLayout(false);
            this.FractalPanel.PerformLayout();
            this.InitialPanel.ResumeLayout(false);
            this.InitialPanel.PerformLayout();
            this.MarkovPanel.ResumeLayout(false);
            this.MarkovPanel.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //Funcitons
        public System.Windows.Forms.TextBox Func1;
        public System.Windows.Forms.TextBox Func2;
        public System.Windows.Forms.TextBox Initial;
        //Toggles
        public System.Windows.Forms.CheckBox DrawInit;
        public System.Windows.Forms.CheckBox traj;
        public System.Windows.Forms.CheckBox DrawFunc;
        //Values
        public System.Windows.Forms.NumericUpDown IncValue;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton FractalDrop;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton DrawButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton ClearButton;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripTextBox coor;
        // Markov Chain things
        public System.Windows.Forms.CheckBox DrawMarkovChain;
        public System.Windows.Forms.CheckBox MarkovChainRandomState;
        private System.Windows.Forms.Panel MarkovPanel;
        private System.Windows.Forms.ToolStripDropDownButton MarkovDrop;
        private System.Windows.Forms.Label MarkovStartingStateLabel;
        public System.Windows.Forms.NumericUpDown MarkovStartingState;
        private System.Windows.Forms.Label MarkovProbLabelMain;
        private System.Windows.Forms.Label MarkovProbLabel1;
        private System.Windows.Forms.Label MarkovProbLabel2;
        private System.Windows.Forms.Label MarkovProbLabel3;
        private System.Windows.Forms.Label MarkovProbLabel4;
        private System.Windows.Forms.Label MarkovProbLabel5;
        private System.Windows.Forms.Label MarkovLabel1a;
        public System.Windows.Forms.TextBox MarkovFunc1a;
        private System.Windows.Forms.Label MarkovLabel1b;
        public System.Windows.Forms.TextBox MarkovFunc1b;
        private System.Windows.Forms.Label MarkovLabel1c;
        public System.Windows.Forms.NumericUpDown MarkovProb1to1;
        public System.Windows.Forms.NumericUpDown MarkovProb1to2;
        public System.Windows.Forms.NumericUpDown MarkovProb1to3;
        public System.Windows.Forms.NumericUpDown MarkovProb1to4;
        public System.Windows.Forms.NumericUpDown MarkovProb1to5;
        private System.Windows.Forms.Label MarkovLabel2a;
        public System.Windows.Forms.TextBox MarkovFunc2a;
        private System.Windows.Forms.Label MarkovLabel2b;
        public System.Windows.Forms.TextBox MarkovFunc2b;
        private System.Windows.Forms.Label MarkovLabel2c;
        public System.Windows.Forms.NumericUpDown MarkovProb2to1;
        public System.Windows.Forms.NumericUpDown MarkovProb2to2;
        public System.Windows.Forms.NumericUpDown MarkovProb2to3;
        public System.Windows.Forms.NumericUpDown MarkovProb2to4;
        public System.Windows.Forms.NumericUpDown MarkovProb2to5;
        private System.Windows.Forms.Label MarkovLabel3a;
        public System.Windows.Forms.TextBox MarkovFunc3a;
        private System.Windows.Forms.Label MarkovLabel3b;
        public System.Windows.Forms.TextBox MarkovFunc3b;
        private System.Windows.Forms.Label MarkovLabel3c;
        public System.Windows.Forms.NumericUpDown MarkovProb3to1;
        public System.Windows.Forms.NumericUpDown MarkovProb3to2;
        public System.Windows.Forms.NumericUpDown MarkovProb3to3;
        public System.Windows.Forms.NumericUpDown MarkovProb3to4;
        public System.Windows.Forms.NumericUpDown MarkovProb3to5;
        private System.Windows.Forms.Label MarkovLabel4a;
        public System.Windows.Forms.TextBox MarkovFunc4a;
        private System.Windows.Forms.Label MarkovLabel4b;
        public System.Windows.Forms.TextBox MarkovFunc4b;
        private System.Windows.Forms.Label MarkovLabel4c;
        public System.Windows.Forms.NumericUpDown MarkovProb4to1;
        public System.Windows.Forms.NumericUpDown MarkovProb4to2;
        public System.Windows.Forms.NumericUpDown MarkovProb4to3;
        public System.Windows.Forms.NumericUpDown MarkovProb4to4;
        public System.Windows.Forms.NumericUpDown MarkovProb4to5;
        private System.Windows.Forms.Label MarkovLabel5a;
        public System.Windows.Forms.TextBox MarkovFunc5a;
        private System.Windows.Forms.Label MarkovLabel5b;
        public System.Windows.Forms.TextBox MarkovFunc5b;
        private System.Windows.Forms.Label MarkovLabel5c;
        public System.Windows.Forms.NumericUpDown MarkovProb5to1;
        public System.Windows.Forms.NumericUpDown MarkovProb5to2;
        public System.Windows.Forms.NumericUpDown MarkovProb5to3;
        public System.Windows.Forms.NumericUpDown MarkovProb5to4;
        public System.Windows.Forms.NumericUpDown MarkovProb5to5;
    }
}

