namespace Mcba.UI
{
    partial class Stock
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
            this.gbData = new System.Windows.Forms.GroupBox();
            this.cmbChoferes = new System.Windows.Forms.ComboBox();
            this.lblChofer = new System.Windows.Forms.Label();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.cmbRemitentes = new System.Windows.Forms.ComboBox();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.lblGuia = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblOrigen = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.lblLote = new System.Windows.Forms.Label();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.cmbChoferes);
            this.gbData.Controls.Add(this.lblChofer);
            this.gbData.Controls.Add(this.txtGuia);
            this.gbData.Controls.Add(this.txtFecha);
            this.gbData.Controls.Add(this.cmbProducto);
            this.gbData.Controls.Add(this.cmbRemitentes);
            this.gbData.Controls.Add(this.cmbProvincias);
            this.gbData.Controls.Add(this.lblGuia);
            this.gbData.Controls.Add(this.lblFecha);
            this.gbData.Controls.Add(this.cmbUnidad);
            this.gbData.Controls.Add(this.txtCantidad);
            this.gbData.Controls.Add(this.lblCantidad);
            this.gbData.Controls.Add(this.lblUnidad);
            this.gbData.Controls.Add(this.lblOrigen);
            this.gbData.Controls.Add(this.lblProducto);
            this.gbData.Controls.Add(this.lblRemitente);
            this.gbData.Controls.Add(this.txtLote);
            this.gbData.Controls.Add(this.lblLote);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(789, 144);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            // 
            // cmbChoferes
            // 
            this.cmbChoferes.FormattingEnabled = true;
            this.cmbChoferes.Location = new System.Drawing.Point(605, 79);
            this.cmbChoferes.Name = "cmbChoferes";
            this.cmbChoferes.Size = new System.Drawing.Size(167, 21);
            this.cmbChoferes.TabIndex = 28;
            // 
            // lblChofer
            // 
            this.lblChofer.Location = new System.Drawing.Point(513, 79);
            this.lblChofer.Name = "lblChofer";
            this.lblChofer.Size = new System.Drawing.Size(85, 20);
            this.lblChofer.TabIndex = 27;
            this.lblChofer.Tag = "lblChofer";
            this.lblChofer.Text = "Chofer";
            this.lblChofer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtGuia
            // 
            this.txtGuia.AcceptsReturn = true;
            this.txtGuia.Location = new System.Drawing.Point(604, 46);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(168, 20);
            this.txtGuia.TabIndex = 26;
            // 
            // txtFecha
            // 
            this.txtFecha.AcceptsReturn = true;
            this.txtFecha.Location = new System.Drawing.Point(323, 46);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(168, 20);
            this.txtFecha.TabIndex = 25;
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(73, 79);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(168, 21);
            this.cmbProducto.TabIndex = 24;
            // 
            // cmbRemitentes
            // 
            this.cmbRemitentes.FormattingEnabled = true;
            this.cmbRemitentes.Location = new System.Drawing.Point(73, 46);
            this.cmbRemitentes.Name = "cmbRemitentes";
            this.cmbRemitentes.Size = new System.Drawing.Size(168, 21);
            this.cmbRemitentes.TabIndex = 23;
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(74, 112);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(167, 21);
            this.cmbProvincias.TabIndex = 22;
            // 
            // lblGuia
            // 
            this.lblGuia.Location = new System.Drawing.Point(513, 46);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(85, 20);
            this.lblGuia.TabIndex = 15;
            this.lblGuia.Tag = "lblGuia";
            this.lblGuia.Text = "Guía de Transp.";
            this.lblGuia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(255, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(61, 20);
            this.lblFecha.TabIndex = 13;
            this.lblFecha.Tag = "lblFecha";
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Location = new System.Drawing.Point(323, 79);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(168, 21);
            this.cmbUnidad.TabIndex = 12;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(323, 112);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(168, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(255, 112);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(61, 20);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Tag = "lblCantidad";
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUnidad
            // 
            this.lblUnidad.Location = new System.Drawing.Point(255, 79);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(61, 20);
            this.lblUnidad.TabIndex = 8;
            this.lblUnidad.Tag = "lblUnidad";
            this.lblUnidad.Text = "Unidad";
            this.lblUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOrigen
            // 
            this.lblOrigen.Location = new System.Drawing.Point(6, 112);
            this.lblOrigen.Name = "lblOrigen";
            this.lblOrigen.Size = new System.Drawing.Size(61, 20);
            this.lblOrigen.TabIndex = 6;
            this.lblOrigen.Tag = "lblOrigen";
            this.lblOrigen.Text = "Origen";
            this.lblOrigen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(6, 79);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(61, 20);
            this.lblProducto.TabIndex = 4;
            this.lblProducto.Tag = "lblProducto";
            this.lblProducto.Text = "Producto";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemitente
            // 
            this.lblRemitente.Location = new System.Drawing.Point(6, 46);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(61, 20);
            this.lblRemitente.TabIndex = 2;
            this.lblRemitente.Tag = "lblRemitente";
            this.lblRemitente.Text = "Remitente";
            this.lblRemitente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(73, 13);
            this.txtLote.Name = "txtLote";
            this.txtLote.ReadOnly = true;
            this.txtLote.Size = new System.Drawing.Size(168, 20);
            this.txtLote.TabIndex = 1;
            // 
            // lblLote
            // 
            this.lblLote.Location = new System.Drawing.Point(6, 13);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(61, 20);
            this.lblLote.TabIndex = 0;
            this.lblLote.Tag = "lblLote";
            this.lblLote.Text = "Lote";
            this.lblLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(12, 178);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.Size = new System.Drawing.Size(789, 260);
            this.dgvStock.TabIndex = 2;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.dgvStock);
            this.Controls.Add(this.gbData);
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Stock";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.Controls.SetChildIndex(this.gbData, 0);
            this.Controls.SetChildIndex(this.dgvStock, 0);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblOrigen;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.ComboBox cmbRemitentes;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.ComboBox cmbChoferes;
        private System.Windows.Forms.Label lblChofer;
    }
}