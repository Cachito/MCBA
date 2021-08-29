namespace Mcba.UI
{
    partial class FacturasBuscar
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
            this.tsFacturasBuscar = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblLetra = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.tsFacturasBuscar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // tsFacturasBuscar
            // 
            this.tsFacturasBuscar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbOk});
            this.tsFacturasBuscar.Location = new System.Drawing.Point(0, 0);
            this.tsFacturasBuscar.Name = "tsFacturasBuscar";
            this.tsFacturasBuscar.Size = new System.Drawing.Size(667, 25);
            this.tsFacturasBuscar.TabIndex = 0;
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
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(310, 46);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(177, 20);
            this.txtFecha.TabIndex = 15;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(258, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(46, 20);
            this.lblFecha.TabIndex = 14;
            this.lblFecha.Tag = "lblFecha";
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(310, 86);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(177, 20);
            this.txtNumero.TabIndex = 13;
            // 
            // lblNumero
            // 
            this.lblNumero.Location = new System.Drawing.Point(258, 86);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(46, 20);
            this.lblNumero.TabIndex = 12;
            this.lblNumero.Tag = "lblNumero";
            this.lblNumero.Text = "Número";
            this.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLetra
            // 
            this.lblLetra.Location = new System.Drawing.Point(9, 86);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(46, 20);
            this.lblLetra.TabIndex = 8;
            this.lblLetra.Tag = "lblLetra";
            this.lblLetra.Text = "Letra";
            this.lblLetra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(61, 86);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(177, 20);
            this.txtLetra.TabIndex = 16;
            // 
            // lblCliente
            // 
            this.lblCliente.Location = new System.Drawing.Point(9, 46);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(46, 20);
            this.lblCliente.TabIndex = 19;
            this.lblCliente.Tag = "lblCliente";
            this.lblCliente.Text = "Cliente";
            this.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(61, 46);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(177, 21);
            this.cmbCliente.TabIndex = 20;
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(12, 124);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(643, 226);
            this.dgvFacturas.TabIndex = 21;
            // 
            // FacturasBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 362);
            this.ControlBox = false;
            this.Controls.Add(this.dgvFacturas);
            this.Controls.Add(this.cmbCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.txtLetra);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblLetra);
            this.Controls.Add(this.tsFacturasBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FacturasBuscar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "FacturasBuscar";
            this.Text = "Buscar Factrua";
            this.Load += new System.EventHandler(this.FacturasBuscar_Load);
            this.tsFacturasBuscar.ResumeLayout(false);
            this.tsFacturasBuscar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsFacturasBuscar;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.DataGridView dgvFacturas;
    }
}