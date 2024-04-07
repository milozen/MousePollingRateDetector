using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace MousePollingRateDetector
{
    public partial class Form1 : Form
    {
        private Stopwatch stopwatch;
        private int mouseMoveEvents = 0;
        private double lastReportTime = 0;
        private double totalPollingRate = 0;
        private int pollingRateCount = 0;

        public Form1()
        {
            InitializeComponent();
            stopwatch = Stopwatch.StartNew();
            this.MouseMove += Form1_MouseMove;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            // 计数鼠标移动事件
            mouseMoveEvents++;

            // 如果超过了一秒钟
            if (stopwatch.Elapsed.TotalSeconds - lastReportTime >= 1)
            {
                // 计算当前轮询率
                var currentRate = mouseMoveEvents / (stopwatch.Elapsed.TotalSeconds - lastReportTime);
                // 更新总轮询率以计算平均值
                totalPollingRate += currentRate;
                pollingRateCount++;
                var averageRate = totalPollingRate / pollingRateCount;

                // 更新标签以显示当前和平均轮询率
                lblCurrentRate.Text = $"Current Rate: {currentRate:F2} Hz";
                lblAverageRate.Text = $"Average: {averageRate:F2} Hz";

                // 重置计数器和报告时间
                lastReportTime = stopwatch.Elapsed.TotalSeconds;
                mouseMoveEvents = 0;
            }
        }
    }
}
