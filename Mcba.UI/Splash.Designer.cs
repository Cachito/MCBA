namespace Mcba.UI
{
    partial class Splash
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
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.ssSplash = new System.Windows.Forms.StatusStrip();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.ssSplash.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbLogo.Image = global::Mcba.UI.Properties.Resources.Logo2;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(800, 425);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            this.pbLogo.Tag = "pbLogo";
            // 
            // ssSplash
            // 
            this.ssSplash.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsProgress,
            this.tsLabel});
            this.ssSplash.Location = new System.Drawing.Point(0, 428);
            this.ssSplash.Name = "ssSplash";
            this.ssSplash.Size = new System.Drawing.Size(800, 22);
            this.ssSplash.TabIndex = 2;
            this.ssSplash.Text = "statusStrip1";
            // 
            // tsProgress
            // 
            this.tsProgress.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(500, 16);
            this.tsProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            // 
            // tsLabel
            // 
            this.tsLabel.Name = "tsLabel";
            this.tsLabel.Size = new System.Drawing.Size(283, 17);
            this.tsLabel.Spring = true;
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.WorkerSupportsCancellation = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.ssSplash);
            this.Controls.Add(this.pbLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boungiono SA";
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ssSplash.ResumeLayout(false);
            this.ssSplash.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.StatusStrip ssSplash;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.ToolStripStatusLabel tsLabel;
        private System.ComponentModel.BackgroundWorker bgWorker;
    }
}