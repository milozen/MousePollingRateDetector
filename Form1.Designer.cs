using System.Drawing;
using System.Windows.Forms;

namespace MousePollingRateDetector
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMoveYourMouse; // 提示用户移动鼠标的标签
        private Label lblCurrentRate; // 显示当前鼠标轮询率的标签
        private Label lblAverageRate; // 显示平均鼠标轮询率的标签
        private CheckBox chkShowCurrentRate; // 控制是否显示当前鼠标轮询率的勾选框
        private ListBox lstPollingRates; // 用于显示最近的100个鼠标轮询率
        private Label lblTimeIntervalDescription; // 用于描述时间间隔输入框的标签
        private TextBox txtTimeInterval; // 用户输入时间间隔的文本框


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
            lblMoveYourMouse = new Label();
            lblCurrentRate = new Label();
            lblAverageRate = new Label();
            chkShowCurrentRate = new CheckBox();
            lstPollingRates = new ListBox();
            lblTimeIntervalDescription = new Label();
            txtTimeInterval = new TextBox();
            SuspendLayout();
            // 
            // lblMoveYourMouse
            // 
            lblMoveYourMouse.AutoSize = true;
            lblMoveYourMouse.Font = new Font("Arial", 10F);
            lblMoveYourMouse.Location = new Point(368, 39);
            lblMoveYourMouse.Name = "lblMoveYourMouse";
            lblMoveYourMouse.Size = new Size(154, 16);
            lblMoveYourMouse.TabIndex = 0;
            lblMoveYourMouse.Text = "Move Your Mouse Here";
            // 
            // lblCurrentRate
            // 
            lblCurrentRate.AutoSize = true;
            lblCurrentRate.Font = new Font("Arial", 10F);
            lblCurrentRate.Location = new Point(82, 109);
            lblCurrentRate.Name = "lblCurrentRate";
            lblCurrentRate.Size = new Size(97, 16);
            lblCurrentRate.TabIndex = 1;
            lblCurrentRate.Text = "Current Rate: ";
            // 
            // lblAverageRate
            // 
            lblAverageRate.AutoSize = true;
            lblAverageRate.Font = new Font("Arial", 10F);
            lblAverageRate.Location = new Point(82, 512);
            lblAverageRate.Name = "lblAverageRate";
            lblAverageRate.Size = new Size(68, 16);
            lblAverageRate.TabIndex = 2;
            lblAverageRate.Text = "Average: ";
            lblAverageRate.Click += lblAverageRate_Click;
            // 
            // chkShowCurrentRate
            // 
            chkShowCurrentRate.AutoSize = true;
            chkShowCurrentRate.Location = new Point(82, 142);
            chkShowCurrentRate.Name = "chkShowCurrentRate";
            chkShowCurrentRate.Size = new Size(58, 21);
            chkShowCurrentRate.TabIndex = 3;
            chkShowCurrentRate.Text = "Show";
            chkShowCurrentRate.UseVisualStyleBackColor = true;
            chkShowCurrentRate.CheckedChanged += chkShowCurrentRate_CheckedChanged_1;
            // 
            // lstPollingRates
            // 
            lstPollingRates.Font = new Font("Arial", 10F);
            lstPollingRates.Location = new Point(82, 169);
            lstPollingRates.Name = "lstPollingRates";
            lstPollingRates.Size = new Size(160, 340);
            lstPollingRates.TabIndex = 4;
            lstPollingRates.Visible = false;
            // 
            // lblTimeIntervalDescription
            // 
            lblTimeIntervalDescription.AutoSize = true;
            lblTimeIntervalDescription.Font = new Font("Arial", 10F);
            lblTimeIntervalDescription.Location = new Point(82, 78);
            lblTimeIntervalDescription.Name = "lblTimeIntervalDescription";
            lblTimeIntervalDescription.Size = new Size(198, 16);
            lblTimeIntervalDescription.TabIndex = 5;
            lblTimeIntervalDescription.Text = "Set Update Interval (seconds):";
            // 
            // txtTimeInterval
            // 
            txtTimeInterval.Font = new Font("Arial", 10F);
            txtTimeInterval.Location = new Point(286, 75);
            txtTimeInterval.Name = "txtTimeInterval";
            txtTimeInterval.Size = new Size(85, 23);
            txtTimeInterval.TabIndex = 6;
            txtTimeInterval.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(937, 563);
            Controls.Add(lblMoveYourMouse);
            Controls.Add(lblCurrentRate);
            Controls.Add(lblAverageRate);
            Controls.Add(chkShowCurrentRate);
            Controls.Add(lstPollingRates);
            Controls.Add(lblTimeIntervalDescription);
            Controls.Add(txtTimeInterval);
            Name = "Form1";
            Text = "Mouse Polling Rate Detector";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
