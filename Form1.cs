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
            this.chkShowCurrentRate.CheckedChanged += new EventHandler(chkShowCurrentRate_CheckedChanged);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMoveEvents++;
            double timeInterval;

            if (double.TryParse(txtTimeInterval.Text, out timeInterval) && stopwatch.Elapsed.TotalSeconds - lastReportTime >= timeInterval)
            {
                var currentRate = mouseMoveEvents / (stopwatch.Elapsed.TotalSeconds - lastReportTime);
                totalPollingRate += currentRate;
                pollingRateCount++;
                var averageRate = totalPollingRate / pollingRateCount;

                lblCurrentRate.Text = $"Current Rate: {currentRate:F2} Hz";
                lblAverageRate.Text = $"Average: {averageRate:F2} Hz";

                if (chkShowCurrentRate.Checked)
                {
                    lstPollingRates.Items.Add($" {currentRate:F2} Hz");
                    if (lstPollingRates.Items.Count > 100)
                    {
                        lstPollingRates.Items.RemoveAt(0);
                    }
                    lstPollingRates.SelectedIndex = lstPollingRates.Items.Count - 1;
                    lstPollingRates.ClearSelected();
                }

                lastReportTime = stopwatch.Elapsed.TotalSeconds;
                mouseMoveEvents = 0;
            }

            else if (!double.TryParse(txtTimeInterval.Text, out timeInterval))
            {
                // 可能需要处理无法转换的情况，例如显示错误消息或者设置一个默认值
                timeInterval = 1; // 设置默认值或其他错误处理
            }
        }

        private void chkShowCurrentRate_CheckedChanged(object sender, EventArgs e)
        {
            lstPollingRates.Visible = chkShowCurrentRate.Checked;
        }

        private void lblAverageRate_Click(object sender, EventArgs e)
        {

        }

        private void chkShowCurrentRate_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}
