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
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.txtRemitente = new System.Windows.Forms.TextBox();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.lblComision = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.tsRemitenteComisiones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsRemitenteComisiones
            // 
            this.tsRemitenteComisiones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbOk});
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
            this.tsbOk.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // lblRemitente
            // 
            this.lblRemitente.Location = new System.Drawing.Point(9, 42);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(70, 20);
            this.lblRemitente.TabIndex = 8;
            this.lblRemitente.Tag = "lblRemitente";
            this.lblRemitente.Text = "Remitente";
            this.lblRemitente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lblComision
            // 
            this.lblComision.Location = new System.Drawing.Point(9, 124);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(70, 20);
            this.lblComision.TabIndex = 19;
            this.lblComision.Tag = "lblComision";
            this.lblComision.Text = "Comisión";
            this.lblComision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(9, 83);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(70, 20);
            this.lblProducto.TabIndex = 21;
            this.lblProducto.Tag = "lblProducto";
            this.lblProducto.Text = "Producto";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.lblComision);
            this.Controls.Add(this.txtRemitente);
            this.Controls.Add(this.lblRemitente);
            this.Controls.Add(this.tsRemitenteComisiones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RemitenteComisiones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "RemitenteComisiones";
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
        private System.Windows.Forms.ToolStripButton tsbOk;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.TextBox txtRemitente;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProductos;
    }
}