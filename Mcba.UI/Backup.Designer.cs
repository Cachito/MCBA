namespace Mcba.UI
{
    partial class Backup
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
            this.tsBackup = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbProcesar = new System.Windows.Forms.ToolStripButton();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.lblVolumen = new System.Windows.Forms.Label();
            this.lblAvance = new System.Windows.Forms.Label();
            this.btnSelectRuta = new System.Windows.Forms.Button();
            this.txtCarpetaDestino = new System.Windows.Forms.TextBox();
            this.lblDestino = new System.Windows.Forms.Label();
            this.tsBackup.SuspendLayout();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsBackup
            // 
            this.tsBackup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbProcesar});
            this.tsBackup.Location = new System.Drawing.Point(0, 0);
            this.tsBackup.Name = "tsBackup";
            this.tsBackup.Size = new System.Drawing.Size(562, 25);
            this.tsBackup.TabIndex = 0;
            this.tsBackup.Text = "toolStrip1";
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
            // tsbProcesar
            // 
            this.tsbProcesar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbProcesar.Image = global::Mcba.UI.Properties.Resources.iconOrdenProduccion16;
            this.tsbProcesar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbProcesar.Name = "tsbProcesar";
            this.tsbProcesar.Size = new System.Drawing.Size(23, 22);
            this.tsbProcesar.Tag = "tsbProcesar";
            this.tsbProcesar.Text = "Procesar";
            this.tsbProcesar.Click += new System.EventHandler(this.tsbProcesar_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.lblVolumen);
            this.gbData.Controls.Add(this.lblAvance);
            this.gbData.Controls.Add(this.btnSelectRuta);
            this.gbData.Controls.Add(this.txtCarpetaDestino);
            this.gbData.Controls.Add(this.lblDestino);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(542, 90);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            // 
            // lblVolumen
            // 
            this.lblVolumen.Location = new System.Drawing.Point(103, 52);
            this.lblVolumen.Name = "lblVolumen";
            this.lblVolumen.Size = new System.Drawing.Size(397, 20);
            this.lblVolumen.TabIndex = 9;
            this.lblVolumen.Tag = "lblVolumen";
            this.lblVolumen.Text = "Volumen en Proceso";
            this.lblVolumen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAvance
            // 
            this.lblAvance.Location = new System.Drawing.Point(6, 53);
            this.lblAvance.Name = "lblAvance";
            this.lblAvance.Size = new System.Drawing.Size(73, 20);
            this.lblAvance.TabIndex = 7;
            this.lblAvance.Tag = "lblAvance";
            this.lblAvance.Text = "lblAvance";
            this.lblAvance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSelectRuta
            // 
            this.btnSelectRuta.Location = new System.Drawing.Point(506, 16);
            this.btnSelectRuta.Name = "btnSelectRuta";
            this.btnSelectRuta.Size = new System.Drawing.Size(30, 20);
            this.btnSelectRuta.TabIndex = 6;
            this.btnSelectRuta.Text = "...";
            this.btnSelectRuta.UseVisualStyleBackColor = true;
            // 
            // txtCarpetaDestino
            // 
            this.txtCarpetaDestino.Location = new System.Drawing.Point(103, 16);
            this.txtCarpetaDestino.Name = "txtCarpetaDestino";
            this.txtCarpetaDestino.ReadOnly = true;
            this.txtCarpetaDestino.Size = new System.Drawing.Size(397, 20);
            this.txtCarpetaDestino.TabIndex = 5;
            // 
            // lblDestino
            // 
            this.lblDestino.Location = new System.Drawing.Point(6, 16);
            this.lblDestino.Name = "lblDestino";
            this.lblDestino.Size = new System.Drawing.Size(91, 20);
            this.lblDestino.TabIndex = 4;
            this.lblDestino.Tag = "lblDestino";
            this.lblDestino.Text = "Carpeta Destino";
            this.lblDestino.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 127);
            this.ControlBox = false;
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.tsBackup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.Backup_Load);
            this.tsBackup.ResumeLayout(false);
            this.tsBackup.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBackup;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.Label lblDestino;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbProcesar;
        private System.Windows.Forms.Label lblVolumen;
        private System.Windows.Forms.Label lblAvance;
        private System.Windows.Forms.Button btnSelectRuta;
        private System.Windows.Forms.TextBox txtCarpetaDestino;
    }
}