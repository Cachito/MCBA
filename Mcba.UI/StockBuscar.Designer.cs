
namespace Mcba.UI
{
    partial class StockBuscar
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
            this.lblRemitente = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.tsFacturasBuscar = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.tsFacturasBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRemitente
            // 
            this.lblRemitente.Location = new System.Drawing.Point(30, 55);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(70, 23);
            this.lblRemitente.TabIndex = 0;
            this.lblRemitente.Tag = "lblRemitente";
            this.lblRemitente.Text = "Remitente";
            this.lblRemitente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(106, 57);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(106, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 3;
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(30, 92);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(70, 23);
            this.lblProducto.TabIndex = 2;
            this.lblProducto.Tag = "lblProducto";
            this.lblProducto.Text = "Producto";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsFacturasBuscar
            // 
            this.tsFacturasBuscar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbOk});
            this.tsFacturasBuscar.Location = new System.Drawing.Point(0, 0);
            this.tsFacturasBuscar.Name = "tsFacturasBuscar";
            this.tsFacturasBuscar.Size = new System.Drawing.Size(257, 25);
            this.tsFacturasBuscar.TabIndex = 6;
            this.tsFacturasBuscar.Text = "toolStrip1";
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
            // 
            // StockBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 182);
            this.ControlBox = false;
            this.Controls.Add(this.tsFacturasBuscar);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblRemitente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "StockBuscar";
            this.Tag = "StockBuscar";
            this.Text = "Filtros Stock";
            this.Load += new System.EventHandler(this.StockBuscar_Load);
            this.tsFacturasBuscar.ResumeLayout(false);
            this.tsFacturasBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ToolStrip tsFacturasBuscar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbOk;
    }
}