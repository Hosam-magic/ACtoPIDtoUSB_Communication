using AssettoCorsaSharedMemory;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp4.GolbalVaule;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        static AssettoCorsa ac = new AssettoCorsa();
        static System.Timers.Timer gobalTimer = new System.Timers.Timer(2000);
        static Arduino_USB USB = new Arduino_USB("COM3");
        Int64 ReceiveID = 0;
        Int64 TransmitID = 0;
        String temp = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gobalTimer.Start();
            gobalTimer.Elapsed += GobalTimerEvent;
            ac.PhysicsUpdated += Ac_PhysicsUpdate;

        }


        void GobalTimerEvent(object sender, ElapsedEventArgs e)
        {
            try
            {
                //設定一些動態的值
                ac.PhysicsInterval = Int32.Parse(DelayTimeTextBox.Text);
                GobalVariable.xMax = Double.Parse(xMaxTextBox.Text);
                GobalVariable.yMax = Double.Parse(yMaxTextBox.Text);

                GobalVariable.xyChartResetCount = Int32.Parse(XyChartResetCountTextBox.Text);
                GobalVariable.lrChartResetCount = Int32.Parse(LrChartResetCountTextBox.Text);
                GobalVariable.pidChartResetCount = Int32.Parse(pidChartResetTextBox.Text);

                GobalVariable.p = Double.Parse(pValueTextBox.Text);
                GobalVariable.i = Double.Parse(iValueTextBox.Text);
                GobalVariable.d = Double.Parse(dValueTextBox.Text);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!GobalVariable.isRunning)
                {
                    GobalVariable.isRunning = true;
                    startAndStopButton.Text = "STOP";
                    ac.Start();
                    USB.Open();
                    timer1.Enabled = true;
                    ReceiveID = 0;
                }
                else
                {
                    GobalVariable.isRunning = false;
                    startAndStopButton.Text = "START";
                    ac.Stop();                    
                    USB.Transmit("RESET");
                    Thread.Sleep(1000);
                    USB.Close();
                    timer1.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            
        }

        void Ac_PhysicsUpdate(object sender, PhysicsEventArgs e)
        {

            double xValue = e.Physics.AccG[0];
            double yValue = e.Physics.AccG[2];

            GobalVariable.SaveXyData(xValue, yValue);

            //G力表相關的更新
            gChart.Invoke((MethodInvoker)delegate
            {
                gChart.ChartAreas[0].AxisX.Maximum = 5;
                gChart.ChartAreas[0].AxisX.Minimum = -5;
                gChart.ChartAreas[0].AxisY.Maximum = 2;
                gChart.ChartAreas[0].AxisY.Minimum = -2;

                if (gChart.Series["G"].Points.Count > 0)
                {
                    gChart.Series["G"].Points.RemoveAt(0);
                }
                DataPoint g = new DataPoint(-GobalVariable.x, -GobalVariable.y);
                gChart.Series["G"].Points.Add(g);
            });

            // XY 軸相關的更新
            XyChart.Invoke((MethodInvoker)delegate
            {
                //如果超過最大計算次數，進行X軸的位移
                if (XyChart.Series["X"].Points.Count > GobalVariable.xyChartResetCount)
                {
                    XyChart.Series["X"].Points.RemoveAt(0);
                    XyChart.Series["Y"].Points.RemoveAt(0);
                    XyChart.ResetAutoValues();
                }
                DataPoint x = new DataPoint(GobalVariable.xCount, GobalVariable.x);
                DataPoint y = new DataPoint(GobalVariable.yCount, GobalVariable.y);
                XyChart.Series["X"].Points.Add(x);
                XyChart.Series["Y"].Points.Add(y);

                GobalVariable.xCount++;
                GobalVariable.yCount++;
            });

            double xRatio = Double.Parse(xRatioTextBox.Text);
            double yRatio = Double.Parse(yRatioTextBox.Text);


            // 左右馬達相關的更新
            GobalVariable.XyToMotor(xRatio, yRatio);

            LrChart.Invoke((MethodInvoker)delegate
            {
                if (LrChart.Series["leftMotor"].Points.Count > GobalVariable.lrChartResetCount)
                {
                    LrChart.Series["leftMotor"].Points.RemoveAt(0);
                    LrChart.Series["rightMotor"].Points.RemoveAt(0);
                    LrChart.ResetAutoValues();
                }

                DataPoint leftMotor = new DataPoint(GobalVariable.leftCount, GobalVariable.leftMotor);
                DataPoint rightMotor = new DataPoint(GobalVariable.rightCount, GobalVariable.rightMotor);
                LrChart.Series["leftMotor"].Points.Add(leftMotor);
                LrChart.Series["rightMotor"].Points.Add(rightMotor);

                GobalVariable.leftCount++;
                GobalVariable.rightCount++;
            });

            // pid 圖表相關更新
            GobalVariable.MotorToPid();
            pidChart.Invoke((MethodInvoker)delegate
            {
                if (pidChart.Series["leftMotor"].Points.Count > GobalVariable.pidChartResetCount)
                {
                    pidChart.Series["leftMotor"].Points.RemoveAt(0);
                    pidChart.Series["rightMotor"].Points.RemoveAt(0);
                    pidChart.ResetAutoValues();
                }

                DataPoint leftMotor = new DataPoint(GobalVariable.pidLeftCount, GobalVariable.pidLeft);
                DataPoint rightMotor = new DataPoint(GobalVariable.pidRightCount, GobalVariable.pidRight);
                pidChart.Series["leftMotor"].Points.Add(leftMotor);
                pidChart.Series["rightMotor"].Points.Add(rightMotor);

                GobalVariable.pidLeftCount++;
                GobalVariable.pidRightCount++;
            });

            //將數字組成字串送入usb
            string usbString = USB.DoubleToUsbString(GobalVariable.leftMotor, GobalVariable.rightMotor);

            USB.Transmit(usbString);
            this.TransmitID++;            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Thread.Sleep(1);
            label14.Text = this.TransmitID.ToString();
            if (USB.ReceiveID != this.ReceiveID)
            {
                ReceiveID++;
                label13.Text = ReceiveID.ToString();
                foreach(char i in USB.ReceiveContant ?? "Null")
                {
                    temp += i;
                    if (i == '*')
                    {
                        listBox1.Items.Add(temp ?? "null");
                        if (listBox1.Items.Count > 50) listBox1.Items.RemoveAt(0);
                        temp = "";
                    }
                }                              
            }
        }
    }
}
