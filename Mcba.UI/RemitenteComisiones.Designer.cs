namespace Mcba.UI
{
    partial class RemitenteComisiones
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
            this.tsRemitenteComisiones = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.tsRemitenteComisiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsRemitenteComisiones
            // 
            this.tsRemitenteComisiones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbNew});
            this.tsRemitenteComisiones.Location = new System.Drawing.Point(0, 0);
            this.tsRemitenteComisiones.Name = "tsRemitenteComisiones";
            this.tsRemitenteComisiones.Size = new System.Drawing.Size(274, 25);
            this.tsRemitenteComisiones.TabIndex = 0;
            this.tsRemitenteComisiones.Text = "toolStrip1";
            // 
            // tsbSalir
            // 
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = global::Mcba.UI.Properties.Resources.iconOut;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(23, 22);
            this.tsbSalir.Text = "toolStripButton1";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::Mcba.UI.Properties.Resources.tick_sign_32;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 22);
            this.tsbNew.Text = "toolStripButton1";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Remitente";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRemitente
            // 
            this.txtRemitente.Location = new System.Drawing.Point(85, 42);
            this.txtRemitente.Name = "txtRemitente";
            this.txtRemitente.ReadOnly = true;
            this.txtRemitente.Size = new System.Drawing.Size(177, 20);
            this.txtRemitente.TabIndex = 16;
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(85, 124);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(177, 20);
            this.txtComision.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(9, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Comisión";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(9, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Producto";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(85, 83);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(177, 21);
            this.cmbProductos.TabIndex = 22;
            // 
            // RemitenteComisiones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 175);
            this.ControlBox = false;
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRemitente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsRemitenteComisiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RemitenteComisiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Comisiones";
            this.Load += new System.EventHandler(this.RemitenteComisiones_Load);
            this.tsRemitenteComisiones.ResumeLayout(false);
            this.tsRemitenteComisiones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsRemitenteComisiones;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRemitente;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProductos;
    }
}