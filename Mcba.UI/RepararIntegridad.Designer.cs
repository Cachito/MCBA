namespace Mcba.UI
{
    partial class RepararIntegridad
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
            this.tsRepararIntegridad = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.tsRepararIntegridad.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsRepararIntegridad
            // 
            this.tsRepararIntegridad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir});
            this.tsRepararIntegridad.Location = new System.Drawing.Point(0, 0);
            this.tsRepararIntegridad.Name = "tsRepararIntegridad";
            this.tsRepararIntegridad.Size = new System.Drawing.Size(397, 25);
            this.tsRepararIntegridad.TabIndex = 1;
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
            // lblWarning
            // 
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(12, 40);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(373, 76);
            this.lblWarning.TabIndex = 2;
            this.lblWarning.Tag = "lblWarning";
            this.lblWarning.Text = "lblWarning";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOk
            // 
            this.btnOk.Image = global::Mcba.UI.Properties.Resources.RepararIntegridad;
            this.btnOk.Location = new System.Drawing.Point(120, 173);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(157, 70);
            this.btnOk.TabIndex = 3;
            this.btnOk.Tag = "";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // RepararIntegridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 255);
            this.ControlBox = false;
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.tsRepararIntegridad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RepararIntegridad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepararIntegridad";
            this.Load += new System.EventHandler(this.RepararIntegridad_Load);
            this.tsRepararIntegridad.ResumeLayout(false);
            this.tsRepararIntegridad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsRepararIntegridad;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnOk;
    }
}