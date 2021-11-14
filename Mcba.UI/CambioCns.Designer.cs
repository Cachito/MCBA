namespace Mcba.UI
{
    partial class CambioCns
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
            this.tsCambioCns = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.lblBase = new System.Windows.Forms.Label();
            this.tsCambioCns.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCambioCns
            // 
            this.tsCambioCns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbOk});
            this.tsCambioCns.Location = new System.Drawing.Point(0, 0);
            this.tsCambioCns.Name = "tsCambioCns";
            this.tsCambioCns.Size = new System.Drawing.Size(603, 25);
            this.tsCambioCns.TabIndex = 1;
            // 
            // tsbSalir
            // 
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = global::Mcba.UI.Properties.Resources.iconOut;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(23, 22);
            this.tsbSalir.Tag = "tsbSalir";
            this.tsbSalir.Text = "Salir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // tsbOk
            // 
            this.tsbOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOk.Image = global::Mcba.UI.Properties.Resources.tick_sign_32;
            this.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOk.Name = "tsbOk";
            this.tsbOk.Size = new System.Drawing.Size(23, 22);
            this.tsbOk.Tag = "tsbOk";
            this.tsbOk.Text = "Ok";
            this.tsbOk.Click += new System.EventHandler(this.tsbOk_Click);
            // 
            // lblServer
            // 
            this.lblServer.Location = new System.Drawing.Point(23, 40);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(94, 23);
            this.lblServer.TabIndex = 2;
            this.lblServer.Tag = "lblServer";
            this.lblServer.Text = "lblServer";
            this.lblServer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(123, 43);
            this.txtServer.MaxLength = 255;
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(471, 20);
            this.txtServer.TabIndex = 3;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(123, 69);
            this.txtBase.MaxLength = 255;
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(471, 20);
            this.txtBase.TabIndex = 5;
            // 
            // lblBase
            // 
            this.lblBase.Location = new System.Drawing.Point(23, 66);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(94, 23);
            this.lblBase.TabIndex = 4;
            this.lblBase.Tag = "lblBase";
            this.lblBase.Text = "lblBase";
            this.lblBase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CambioCns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 102);
            this.ControlBox = false;
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.lblBase);
            this.Controls.Add(this.txtServer);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.tsCambioCns);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CambioCns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "CambioCns";
            this.Text = "CambioCns";
            this.Load += new System.EventHandler(this.CambioCns_Load);
            this.tsCambioCns.ResumeLayout(false);
            this.tsCambioCns.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCambioCns;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Label lblBase;
    }
}