namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea37 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend37 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series64 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series65 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea38 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend38 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series66 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea39 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend39 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series67 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series68 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea40 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend40 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series69 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series70 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.XyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DelayTimeTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startAndStopButton = new System.Windows.Forms.Button();
            this.xMax = new System.Windows.Forms.Label();
            this.xMaxTextBox = new System.Windows.Forms.TextBox();
            this.yMax = new System.Windows.Forms.Label();
            this.yMaxTextBox = new System.Windows.Forms.TextBox();
            this.LrChartResetCountTextBox = new System.Windows.Forms.TextBox();
            this.count2Max = new System.Windows.Forms.Label();
            this.XyChartResetCountTextBox = new System.Windows.Forms.TextBox();
            this.count1Max = new System.Windows.Forms.Label();
            this.gChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LrChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pidChartResetTextBox = new System.Windows.Forms.TextBox();
            this.pidChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.xRatioTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.yRatioTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pValueTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dValueTextBox = new System.Windows.Forms.TextBox();
            this.iValueTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.XyChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LrChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pidChart)).BeginInit();
            this.SuspendLayout();
            // 
            // XyChart
            // 
            chartArea37.Name = "ChartArea1";
            this.XyChart.ChartAreas.Add(chartArea37);
            legend37.Name = "Legend1";
            this.XyChart.Legends.Add(legend37);
            this.XyChart.Location = new System.Drawing.Point(17, 161);
            this.XyChart.Name = "XyChart";
            series64.ChartArea = "ChartArea1";
            series64.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series64.Legend = "Legend1";
            series64.Name = "X";
            series65.ChartArea = "ChartArea1";
            series65.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series65.Legend = "Legend1";
            series65.Name = "Y";
            this.XyChart.Series.Add(series64);
            this.XyChart.Series.Add(series65);
            this.XyChart.Size = new System.Drawing.Size(385, 300);
            this.XyChart.TabIndex = 0;
            this.XyChart.Text = "chart1";
            // 
            // DelayTimeTextBox
            // 
            this.DelayTimeTextBox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DelayTimeTextBox.Location = new System.Drawing.Point(134, 24);
            this.DelayTimeTextBox.Name = "DelayTimeTextBox";
            this.DelayTimeTextBox.Size = new System.Drawing.Size(65, 27);
            this.DelayTimeTextBox.TabIndex = 1;
            this.DelayTimeTextBox.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "DelayTime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(205, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "ms";
            // 
            // startAndStopButton
            // 
            this.startAndStopButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startAndStopButton.Location = new System.Drawing.Point(849, 12);
            this.startAndStopButton.Name = "startAndStopButton";
            this.startAndStopButton.Size = new System.Drawing.Size(111, 37);
            this.startAndStopButton.TabIndex = 4;
            this.startAndStopButton.Text = "Start ";
            this.startAndStopButton.UseVisualStyleBackColor = true;
            this.startAndStopButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // xMax
            // 
            this.xMax.AutoSize = true;
            this.xMax.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xMax.Location = new System.Drawing.Point(12, 78);
            this.xMax.Name = "xMax";
            this.xMax.Size = new System.Drawing.Size(76, 27);
            this.xMax.TabIndex = 5;
            this.xMax.Text = "X-Max";
            // 
            // xMaxTextBox
            // 
            this.xMaxTextBox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xMaxTextBox.Location = new System.Drawing.Point(94, 78);
            this.xMaxTextBox.Name = "xMaxTextBox";
            this.xMaxTextBox.Size = new System.Drawing.Size(38, 27);
            this.xMaxTextBox.TabIndex = 6;
            this.xMaxTextBox.Text = "10";
            // 
            // yMax
            // 
            this.yMax.AutoSize = true;
            this.yMax.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yMax.Location = new System.Drawing.Point(183, 78);
            this.yMax.Name = "yMax";
            this.yMax.Size = new System.Drawing.Size(75, 27);
            this.yMax.TabIndex = 7;
            this.yMax.Text = "Y-Max";
            // 
            // yMaxTextBox
            // 
            this.yMaxTextBox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yMaxTextBox.Location = new System.Drawing.Point(264, 78);
            this.yMaxTextBox.Name = "yMaxTextBox";
            this.yMaxTextBox.Size = new System.Drawing.Size(38, 27);
            this.yMaxTextBox.TabIndex = 8;
            this.yMaxTextBox.Text = "10";
            // 
            // LrChartResetCountTextBox
            // 
            this.LrChartResetCountTextBox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.LrChartResetCountTextBox.Location = new System.Drawing.Point(957, 383);
            this.LrChartResetCountTextBox.Name = "LrChartResetCountTextBox";
            this.LrChartResetCountTextBox.Size = new System.Drawing.Size(38, 27);
            this.LrChartResetCountTextBox.TabIndex = 12;
            this.LrChartResetCountTextBox.Text = "50";
            // 
            // count2Max
            // 
            this.count2Max.AutoSize = true;
            this.count2Max.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.count2Max.Location = new System.Drawing.Point(809, 383);
            this.count2Max.Name = "count2Max";
            this.count2Max.Size = new System.Drawing.Size(128, 27);
            this.count2Max.TabIndex = 11;
            this.count2Max.Text = "ResetCount";
            // 
            // XyChartResetCountTextBox
            // 
            this.XyChartResetCountTextBox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.XyChartResetCountTextBox.Location = new System.Drawing.Point(241, 488);
            this.XyChartResetCountTextBox.Name = "XyChartResetCountTextBox";
            this.XyChartResetCountTextBox.Size = new System.Drawing.Size(38, 27);
            this.XyChartResetCountTextBox.TabIndex = 10;
            this.XyChartResetCountTextBox.Text = "10";
            // 
            // count1Max
            // 
            this.count1Max.AutoSize = true;
            this.count1Max.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.count1Max.Location = new System.Drawing.Point(89, 488);
            this.count1Max.Name = "count1Max";
            this.count1Max.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.count1Max.Size = new System.Drawing.Size(128, 27);
            this.count1Max.TabIndex = 9;
            this.count1Max.Text = "ResetCount";
            // 
            // gChart
            // 
            chartArea38.Name = "ChartArea1";
            this.gChart.ChartAreas.Add(chartArea38);
            legend38.Name = "Legend1";
            this.gChart.Legends.Add(legend38);
            this.gChart.Location = new System.Drawing.Point(39, 594);
            this.gChart.Name = "gChart";
            series66.ChartArea = "ChartArea1";
            series66.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series66.Legend = "Legend1";
            series66.MarkerColor = System.Drawing.Color.Red;
            series66.MarkerImageTransparentColor = System.Drawing.Color.Transparent;
            series66.MarkerSize = 10;
            series66.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series66.Name = "G";
            this.gChart.Series.Add(series66);
            this.gChart.Size = new System.Drawing.Size(345, 246);
            this.gChart.TabIndex = 13;
            this.gChart.Text = "chart2";
            // 
            // LrChart
            // 
            chartArea39.Name = "ChartArea1";
            this.LrChart.ChartAreas.Add(chartArea39);
            legend39.Name = "Legend1";
            this.LrChart.Legends.Add(legend39);
            this.LrChart.Location = new System.Drawing.Point(408, 161);
            this.LrChart.Name = "LrChart";
            series67.ChartArea = "ChartArea1";
            series67.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series67.Legend = "Legend1";
            series67.Name = "leftMotor";
            series68.ChartArea = "ChartArea1";
            series68.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series68.Legend = "Legend1";
            series68.Name = "rightMotor";
            this.LrChart.Series.Add(series67);
            this.LrChart.Series.Add(series68);
            this.LrChart.Size = new System.Drawing.Size(385, 300);
            this.LrChart.TabIndex = 14;
            this.LrChart.Text = "chart3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "X-Y meter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(418, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "L - R meter";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(418, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "L - R meter(with PID)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(35, 554);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "G meter";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(809, 844);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(128, 27);
            this.label7.TabIndex = 19;
            this.label7.Text = "ResetCount";
            // 
            // pidChartResetTextBox
            // 
            this.pidChartResetTextBox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pidChartResetTextBox.Location = new System.Drawing.Point(957, 847);
            this.pidChartResetTextBox.Name = "pidChartResetTextBox";
            this.pidChartResetTextBox.Size = new System.Drawing.Size(38, 27);
            this.pidChartResetTextBox.TabIndex = 20;
            this.pidChartResetTextBox.Text = "50";
            // 
            // pidChart
            // 
            this.pidChart.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            chartArea40.Name = "ChartArea1";
            this.pidChart.ChartAreas.Add(chartArea40);
            legend40.Name = "Legend1";
            this.pidChart.Legends.Add(legend40);
            this.pidChart.Location = new System.Drawing.Point(408, 578);
            this.pidChart.Name = "pidChart";
            series69.ChartArea = "ChartArea1";
            series69.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series69.Legend = "Legend1";
            series69.Name = "leftMotor";
            series70.ChartArea = "ChartArea1";
            series70.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series70.Legend = "Legend1";
            series70.Name = "rightMotor";
            this.pidChart.Series.Add(series69);
            this.pidChart.Series.Add(series70);
            this.pidChart.Size = new System.Drawing.Size(385, 300);
            this.pidChart.TabIndex = 21;
            this.pidChart.Text = "pidChart";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(835, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 27);
            this.label8.TabIndex = 22;
            this.label8.Text = "xRatio";
            // 
            // xRatioTextBox
            // 
            this.xRatioTextBox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.xRatioTextBox.Location = new System.Drawing.Point(914, 199);
            this.xRatioTextBox.Name = "xRatioTextBox";
            this.xRatioTextBox.Size = new System.Drawing.Size(38, 27);
            this.xRatioTextBox.TabIndex = 23;
            this.xRatioTextBox.Text = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(835, 247);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 27);
            this.label9.TabIndex = 24;
            this.label9.Text = "yRatio";
            // 
            // yRatioTextBox
            // 
            this.yRatioTextBox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yRatioTextBox.Location = new System.Drawing.Point(914, 247);
            this.yRatioTextBox.Name = "yRatioTextBox";
            this.yRatioTextBox.Size = new System.Drawing.Size(38, 27);
            this.yRatioTextBox.TabIndex = 25;
            this.yRatioTextBox.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(845, 594);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 27);
            this.label10.TabIndex = 28;
            this.label10.Text = "P";
            // 
            // pValueTextBox
            // 
            this.pValueTextBox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pValueTextBox.Location = new System.Drawing.Point(881, 594);
            this.pValueTextBox.Name = "pValueTextBox";
            this.pValueTextBox.Size = new System.Drawing.Size(38, 27);
            this.pValueTextBox.TabIndex = 29;
            this.pValueTextBox.Text = "0.3";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(845, 677);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 27);
            this.label11.TabIndex = 30;
            this.label11.Text = "I";
            // 
            // dValueTextBox
            // 
            this.dValueTextBox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dValueTextBox.Location = new System.Drawing.Point(881, 759);
            this.dValueTextBox.Name = "dValueTextBox";
            this.dValueTextBox.Size = new System.Drawing.Size(38, 27);
            this.dValueTextBox.TabIndex = 31;
            this.dValueTextBox.Text = "0.1";
            // 
            // iValueTextBox
            // 
            this.iValueTextBox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.iValueTextBox.Location = new System.Drawing.Point(881, 677);
            this.iValueTextBox.Name = "iValueTextBox";
            this.iValueTextBox.Size = new System.Drawing.Size(38, 27);
            this.iValueTextBox.TabIndex = 32;
            this.iValueTextBox.Text = "0.1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(845, 759);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(28, 27);
            this.label12.TabIndex = 33;
            this.label12.Text = "D";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(298, 544);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 12);
            this.label13.TabIndex = 34;
            this.label13.Text = "label13";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(1001, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(835, 688);
            this.listBox1.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(298, 562);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 12);
            this.label14.TabIndex = 34;
            this.label14.Text = "label14";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1848, 876);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.iValueTextBox);
            this.Controls.Add(this.dValueTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pValueTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.yRatioTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.xRatioTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pidChart);
            this.Controls.Add(this.pidChartResetTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LrChart);
            this.Controls.Add(this.gChart);
            this.Controls.Add(this.LrChartResetCountTextBox);
            this.Controls.Add(this.count2Max);
            this.Controls.Add(this.XyChartResetCountTextBox);
            this.Controls.Add(this.count1Max);
            this.Controls.Add(this.yMaxTextBox);
            this.Controls.Add(this.yMax);
            this.Controls.Add(this.xMaxTextBox);
            this.Controls.Add(this.xMax);
            this.Controls.Add(this.startAndStopButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelayTimeTextBox);
            this.Controls.Add(this.XyChart);
            this.Name = "Form1";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.XyChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LrChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pidChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart XyChart;
        private System.Windows.Forms.TextBox DelayTimeTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button startAndStopButton;
        private System.Windows.Forms.Label xMax;
        private System.Windows.Forms.TextBox xMaxTextBox;
        private System.Windows.Forms.Label yMax;
        private System.Windows.Forms.TextBox yMaxTextBox;
        private System.Windows.Forms.TextBox LrChartResetCountTextBox;
        private System.Windows.Forms.Label count2Max;
        private System.Windows.Forms.TextBox XyChartResetCountTextBox;
        private System.Windows.Forms.Label count1Max;
        private System.Windows.Forms.DataVisualization.Charting.Chart gChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart LrChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox pidChartResetTextBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart pidChart;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox xRatioTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox yRatioTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox pValueTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox dValueTextBox;
        private System.Windows.Forms.TextBox iValueTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label14;
    }
}

