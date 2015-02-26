namespace DataViewer2 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea28 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea29 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea30 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button2 = new System.Windows.Forms.Button();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown5 = new System.Windows.Forms.NumericUpDown();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown1.ForeColor = System.Drawing.Color.Goldenrod;
            this.numericUpDown1.Location = new System.Drawing.Point(13, 13);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 16);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.NumUpDownChanged);
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Gray;
            this.chart1.BorderlineColor = System.Drawing.Color.Gray;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.DimGray;
            chartArea28.AxisX.IsMarginVisible = false;
            chartArea28.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea28.AxisX.MajorGrid.Enabled = false;
            chartArea28.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea28.AxisX2.IsMarginVisible = false;
            chartArea28.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea28.AxisX2.MajorGrid.Enabled = false;
            chartArea28.AxisX2.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea28.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea28.AxisY.MajorGrid.Enabled = false;
            chartArea28.AxisY.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea28.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea28.AxisY2.MajorGrid.Enabled = false;
            chartArea28.AxisY2.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea28.BorderColor = System.Drawing.Color.DimGray;
            chartArea28.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea28);
            this.chart1.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart1.Location = new System.Drawing.Point(140, 13);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series28.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series28.BorderColor = System.Drawing.Color.White;
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series28.Color = System.Drawing.Color.Goldenrod;
            series28.LabelForeColor = System.Drawing.Color.Transparent;
            series28.Name = "Data1";
            series28.ShadowColor = System.Drawing.Color.White;
            series28.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series28.YValuesPerPoint = 4;
            this.chart1.Series.Add(series28);
            this.chart1.Size = new System.Drawing.Size(620, 220);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Goldenrod;
            this.button1.Location = new System.Drawing.Point(13, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Refresh Graph";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Goldenrod;
            this.button2.Location = new System.Drawing.Point(14, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Pause Graph";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown2.DecimalPlaces = 2;
            this.numericUpDown2.ForeColor = System.Drawing.Color.Goldenrod;
            this.numericUpDown2.Location = new System.Drawing.Point(13, 141);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(45, 16);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown3.DecimalPlaces = 2;
            this.numericUpDown3.ForeColor = System.Drawing.Color.Goldenrod;
            this.numericUpDown3.Location = new System.Drawing.Point(13, 163);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(45, 16);
            this.numericUpDown3.TabIndex = 5;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.ForeColor = System.Drawing.Color.Goldenrod;
            this.numericUpDown4.Location = new System.Drawing.Point(13, 185);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(45, 16);
            this.numericUpDown4.TabIndex = 6;
            this.numericUpDown4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amplitude";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Octave";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Frequency";
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.BackColor = System.Drawing.Color.Gray;
            this.chart2.BorderlineColor = System.Drawing.Color.Gray;
            this.chart2.BorderSkin.BorderColor = System.Drawing.Color.DimGray;
            chartArea29.AxisX.IsMarginVisible = false;
            chartArea29.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea29.AxisX.MajorGrid.Enabled = false;
            chartArea29.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea29.AxisX2.IsMarginVisible = false;
            chartArea29.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea29.AxisX2.MajorGrid.Enabled = false;
            chartArea29.AxisX2.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea29.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea29.AxisY.MajorGrid.Enabled = false;
            chartArea29.AxisY.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea29.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea29.AxisY2.MajorGrid.Enabled = false;
            chartArea29.AxisY2.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea29.BorderColor = System.Drawing.Color.DimGray;
            chartArea29.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea29);
            this.chart2.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart2.Location = new System.Drawing.Point(140, 242);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series29.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series29.BorderColor = System.Drawing.Color.White;
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series29.Color = System.Drawing.Color.Goldenrod;
            series29.LabelForeColor = System.Drawing.Color.Transparent;
            series29.Name = "Data1";
            series29.ShadowColor = System.Drawing.Color.White;
            series29.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series29.YValuesPerPoint = 4;
            this.chart2.Series.Add(series29);
            this.chart2.Size = new System.Drawing.Size(620, 220);
            this.chart2.TabIndex = 10;
            this.chart2.Text = "chart2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(767, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 220);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.BackgroundImageChanged += new System.EventHandler(this.pictureBox1_BackgroundImageChanged);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Goldenrod;
            this.button3.Location = new System.Drawing.Point(14, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Refresh Image";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chart3
            // 
            this.chart3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart3.BackColor = System.Drawing.Color.Gray;
            this.chart3.BorderlineColor = System.Drawing.Color.Gray;
            this.chart3.BorderSkin.BorderColor = System.Drawing.Color.DimGray;
            chartArea30.AxisX.IsMarksNextToAxis = false;
            chartArea30.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea30.AxisX.MajorTickMark.Enabled = false;
            chartArea30.AxisX.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea30.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea30.AxisX2.MajorGrid.Enabled = false;
            chartArea30.AxisX2.MajorTickMark.Enabled = false;
            chartArea30.AxisX2.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea30.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea30.AxisY.MajorGrid.Enabled = false;
            chartArea30.AxisY.MajorTickMark.Enabled = false;
            chartArea30.AxisY.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea30.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea30.AxisY2.MajorGrid.Enabled = false;
            chartArea30.AxisY2.MajorTickMark.Enabled = false;
            chartArea30.AxisY2.TitleForeColor = System.Drawing.Color.DimGray;
            chartArea30.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea30.BorderColor = System.Drawing.Color.DimGray;
            chartArea30.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea30);
            this.chart3.Cursor = System.Windows.Forms.Cursors.Default;
            this.chart3.Location = new System.Drawing.Point(767, 242);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series30.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series30.BorderColor = System.Drawing.Color.White;
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Radar;
            series30.Color = System.Drawing.Color.Goldenrod;
            series30.IsXValueIndexed = true;
            series30.LabelForeColor = System.Drawing.Color.Transparent;
            series30.Name = "Data1";
            series30.ShadowColor = System.Drawing.Color.White;
            series30.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series30.YValuesPerPoint = 4;
            this.chart3.Series.Add(series30);
            this.chart3.Size = new System.Drawing.Size(201, 220);
            this.chart3.TabIndex = 13;
            this.chart3.Text = "chart3";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 242);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 17);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Toggle 2D";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Increment";
            // 
            // numericUpDown5
            // 
            this.numericUpDown5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown5.DecimalPlaces = 2;
            this.numericUpDown5.ForeColor = System.Drawing.Color.Goldenrod;
            this.numericUpDown5.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown5.Location = new System.Drawing.Point(14, 207);
            this.numericUpDown5.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown5.Name = "numericUpDown5";
            this.numericUpDown5.Size = new System.Drawing.Size(45, 16);
            this.numericUpDown5.TabIndex = 15;
            this.numericUpDown5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(14, 265);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(86, 17);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Toggle Type";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Walker Speed\r\n";
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.numericUpDown6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDown6.ForeColor = System.Drawing.Color.Goldenrod;
            this.numericUpDown6.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDown6.Location = new System.Drawing.Point(14, 288);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(45, 16);
            this.numericUpDown6.TabIndex = 18;
            this.numericUpDown6.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown6.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(980, 474);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown6);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown4);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.numericUpDown1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
    }
}

