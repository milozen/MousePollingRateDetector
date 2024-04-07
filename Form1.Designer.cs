using System.Windows.Forms;

namespace MousePollingRateDetector
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblMoveYourMouse; // 提示用户移动鼠标的标签
        private Label lblCurrentRate; // 显示当前鼠标轮询率的标签
        private Label lblAverageRate; // 显示平均鼠标轮询率的标签

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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Mouse Polling Rate Detector";

            // 创建“移动鼠标”的提示标签
            this.lblMoveYourMouse = new Label();
            this.lblMoveYourMouse.AutoSize = true;
            this.lblMoveYourMouse.Location = new System.Drawing.Point(300, 20);
            this.lblMoveYourMouse.Text = "Move Your Mouse Here";
            this.lblMoveYourMouse.Font = new System.Drawing.Font("Arial", 10);

            // 创建显示当前鼠标轮询率的标签
            this.lblCurrentRate = new Label();
            this.lblCurrentRate.AutoSize = true;
            this.lblCurrentRate.Location = new System.Drawing.Point(500, 20); // 根据实际情况调整位置
            this.lblCurrentRate.Text = "Current Rate: ";
            this.lblCurrentRate.Font = new System.Drawing.Font("Arial", 10);

            // 创建显示平均鼠标轮询率的标签
            this.lblAverageRate = new Label();
            this.lblAverageRate.AutoSize = true;
            this.lblAverageRate.Location = new System.Drawing.Point(500, 50); // 根据实际情况调整位置
            this.lblAverageRate.Text = "Average: ";
            this.lblAverageRate.Font = new System.Drawing.Font("Arial", 10);

            // 将标签添加到窗体控件集合中
            this.Controls.Add(this.lblMoveYourMouse);
            this.Controls.Add(this.lblCurrentRate);
            this.Controls.Add(this.lblAverageRate);
        }

        #endregion
    }
}
