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
            if (stopwatch.Elapsed.TotalSeconds - lastReportTime >= 1)
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
        }

        private void chkShowCurrentRate_CheckedChanged(object sender, EventArgs e)
        {
            lstPollingRates.Visible = chkShowCurrentRate.Checked;
        }

        private void lblAverageRate_Click(object sender, EventArgs e)
        {

        }
    }
}
