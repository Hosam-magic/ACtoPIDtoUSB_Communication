using AssettoCorsaSharedMemory;
using PID_Controller;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp4.GolbalVaule
{
    class GobalVariable
    {
        public static bool isRunning = false;

        public static double xMax = 10;
        public static double yMax = 10;
        public static int xyChartResetCount = 10;
        public static int lrChartResetCount = 100;
        public static int pidChartResetCount = 100;

        public static double x = 0;
        public static int xCount = 0;
        public static double y = 0;
        public static int yCount = 0;

        public static double leftMotor = 0;
        public static int leftCount = 0;
        public static double rightMotor = 0;
        public static int rightCount = 0;

        public static double p = 0;
        public static double i = 0;
        public static double d = 0;

        public static double pidLeft = 0;
        public static int pidLeftCount = 0;
        public static double pidRight = 0;
        public static int pidRightCount = 0;

        public static DateTime lastDt = DateTime.Now;

        public static void SaveXyData(double xInput,  double yInput)
        {
            //如果超過最大值就以最大值記錄
            if (xInput > xMax)
            {
                x = xMax;
            }
            if (xInput < -xMax)
            {
                x = -xMax;
            }
            else
            {
                x = xInput;
            }

            if (yInput > yMax)
            {
                y = yMax;
            }
            if (yInput < -yMax)
            {
                y = -yMax;
            }
            else
            {
                y = yInput;
            }
        }

        public static void XyToMotor(double xRatio, double yRatio)
        {
            //不太可能 x y 同時達到設定的 Max，所以馬達最高旋轉幅度除以一個常數
            double motorMax = (xMax  + yMax );

            double newLeftMotor = (x * xRatio - y * yRatio) / motorMax * 100;
            double newRightMotor = (-x * xRatio - y * yRatio) / motorMax * 100;

            if (newLeftMotor > 100)
            {
                newLeftMotor = 100;
            }
            if (newLeftMotor < -100)
            {
                newLeftMotor = -100;
            }

            if (newRightMotor > 100)
            {
                newRightMotor = 100;
            }
            if (newRightMotor < -100)
            {
                newRightMotor = -100;
            }

            leftMotor = newLeftMotor;
            rightMotor = newRightMotor;
        }

        public static void MotorToPid()
        {
            TimeSpan ts = DateTime.Now - lastDt;

            PID pid = new PID(p, i, d, 1, 100, -100);
            
            pidLeft = pid.PID_iterate(leftMotor, pidLeft, ts);
            pidRight = pid.PID_iterate(rightMotor, pidRight, ts);

            lastDt = DateTime.Now;
        }


    }
}
