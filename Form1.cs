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
            // ��������ƶ��¼�
            mouseMoveEvents++;

            // ���������һ����
            if (stopwatch.Elapsed.TotalSeconds - lastReportTime >= 1)
            {
                // ���㵱ǰ��ѯ��
                var currentRate = mouseMoveEvents / (stopwatch.Elapsed.TotalSeconds - lastReportTime);
                // ��������ѯ���Լ���ƽ��ֵ
                totalPollingRate += currentRate;
                pollingRateCount++;
                var averageRate = totalPollingRate / pollingRateCount;

                // ���±�ǩ����ʾ��ǰ��ƽ����ѯ��
                lblCurrentRate.Text = $"Current Rate: {currentRate:F2} Hz";
                lblAverageRate.Text = $"Average: {averageRate:F2} Hz";

                // ���ü������ͱ���ʱ��
                lastReportTime = stopwatch.Elapsed.TotalSeconds;
                mouseMoveEvents = 0;
            }
        }
    }
}
