
namespace ScreenSaverTest
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.progressBar_test = new System.Windows.Forms.ProgressBar();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.labelTest = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar_test
            // 
            this.progressBar_test.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar_test.Location = new System.Drawing.Point(0, 421);
            this.progressBar_test.Name = "progressBar_test";
            this.progressBar_test.Size = new System.Drawing.Size(800, 29);
            this.progressBar_test.Step = 50;
            this.progressBar_test.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar_test.TabIndex = 0;
            this.progressBar_test.Value = 50;
            // 
            // timerTest
            // 
            this.timerTest.Enabled = true;
            this.timerTest.Interval = 1000;
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
            // 
            // labelTest
            // 
            this.labelTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTest.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.labelTest.Location = new System.Drawing.Point(0, 0);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(800, 421);
            this.labelTest.TabIndex = 1;
            this.labelTest.Text = "Loading";
            this.labelTest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.progressBar_test);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.Text = "Main";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar_test;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.Label labelTest;
        private System.Windows.Forms.Timer timer;
    }
}