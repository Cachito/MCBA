namespace Mcba.UI
{
    partial class Liquidacion
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
            this.gbPrecios = new System.Windows.Forms.GroupBox();
            this.rbPrecioPlaza = new System.Windows.Forms.RadioButton();
            this.rbPrecioPromedio = new System.Windows.Forms.RadioButton();
            this.txtPrecioPlaza = new System.Windows.Forms.TextBox();
            this.txtPrecioPromedio = new System.Windows.Forms.TextBox();
            this.gbComisiones = new System.Windows.Forms.GroupBox();
            this.rbComisionRemitente = new System.Windows.Forms.RadioButton();
            this.rbComisionProducto = new System.Windows.Forms.RadioButton();
            this.txtComiaionRemitente = new System.Windows.Forms.TextBox();
            this.txtComisionProducto = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblAPagar = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblComision = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblTotalVentas = new System.Windows.Forms.Label();
            this.txtActaDecomiso = new System.Windows.Forms.TextBox();
            this.lblActa = new System.Windows.Forms.Label();
            this.txtCantidadDecomiso = new System.Windows.Forms.TextBox();
            this.lblDecomiso = new System.Windows.Forms.Label();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.lblVenta = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.cmbRemitentes = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.dgvLiquidacion = new System.Windows.Forms.DataGridView();
            this.gbData.SuspendLayout();
            this.gbPrecios.SuspendLayout();
            this.gbComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiquidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.gbPrecios);
            this.gbData.Controls.Add(this.gbComisiones);
            this.gbData.Controls.Add(this.textBox3);
            this.gbData.Controls.Add(this.lblAPagar);
            this.gbData.Controls.Add(this.textBox2);
            this.gbData.Controls.Add(this.lblComision);
            this.gbData.Controls.Add(this.textBox1);
            this.gbData.Controls.Add(this.lblTotalVentas);
            this.gbData.Controls.Add(this.txtActaDecomiso);
            this.gbData.Controls.Add(this.lblActa);
            this.gbData.Controls.Add(this.txtCantidadDecomiso);
            this.gbData.Controls.Add(this.lblDecomiso);
            this.gbData.Controls.Add(this.txtCantidadVenta);
            this.gbData.Controls.Add(this.lblVenta);
            this.gbData.Controls.Add(this.txtProducto);
            this.gbData.Controls.Add(this.txtGuia);
            this.gbData.Controls.Add(this.cmbRemitentes);
            this.gbData.Controls.Add(this.lblFecha);
            this.gbData.Controls.Add(this.lblLote);
            this.gbData.Controls.Add(this.cmbUnidad);
            this.gbData.Controls.Add(this.lblProducto);
            this.gbData.Controls.Add(this.lblRemitente);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(708, 240);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            // 
            // gbPrecios
            // 
            this.gbPrecios.Controls.Add(this.rbPrecioPlaza);
            this.gbPrecios.Controls.Add(this.rbPrecioPromedio);
            this.gbPrecios.Controls.Add(this.txtPrecioPlaza);
            this.gbPrecios.Controls.Add(this.txtPrecioPromedio);
            this.gbPrecios.Location = new System.Drawing.Point(514, 55);
            this.gbPrecios.Name = "gbPrecios";
            this.gbPrecios.Size = new System.Drawing.Size(181, 85);
            this.gbPrecios.TabIndex = 48;
            this.gbPrecios.TabStop = false;
            this.gbPrecios.Tag = "gbPrecios";
            this.gbPrecios.Text = "Precio";
            // 
            // rbPrecioPlaza
            // 
            this.rbPrecioPlaza.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPrecioPlaza.Location = new System.Drawing.Point(21, 52);
            this.rbPrecioPlaza.Name = "rbPrecioPlaza";
            this.rbPrecioPlaza.Size = new System.Drawing.Size(76, 17);
            this.rbPrecioPlaza.TabIndex = 50;
            this.rbPrecioPlaza.TabStop = true;
            this.rbPrecioPlaza.Tag = "rbPrecioPlaza";
            this.rbPrecioPlaza.Text = "Plaza";
            this.rbPrecioPlaza.UseVisualStyleBackColor = true;
            // 
            // rbPrecioPromedio
            // 
            this.rbPrecioPromedio.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbPrecioPromedio.Location = new System.Drawing.Point(21, 19);
            this.rbPrecioPromedio.Name = "rbPrecioPromedio";
            this.rbPrecioPromedio.Size = new System.Drawing.Size(76, 17);
            this.rbPrecioPromedio.TabIndex = 49;
            this.rbPrecioPromedio.TabStop = true;
            this.rbPrecioPromedio.Tag = "rbPrecioPromedio";
            this.rbPrecioPromedio.Text = "Promedio";
            this.rbPrecioPromedio.UseVisualStyleBackColor = true;
            // 
            // txtPrecioPlaza
            // 
            this.txtPrecioPlaza.Location = new System.Drawing.Point(109, 52);
            this.txtPrecioPlaza.Name = "txtPrecioPlaza";
            this.txtPrecioPlaza.Size = new System.Drawing.Size(62, 20);
            this.txtPrecioPlaza.TabIndex = 48;
            // 
            // txtPrecioPromedio
            // 
            this.txtPrecioPromedio.Location = new System.Drawing.Point(109, 16);
            this.txtPrecioPromedio.Name = "txtPrecioPromedio";
            this.txtPrecioPromedio.ReadOnly = true;
            this.txtPrecioPromedio.Size = new System.Drawing.Size(62, 20);
            this.txtPrecioPromedio.TabIndex = 47;
            // 
            // gbComisiones
            // 
            this.gbComisiones.Controls.Add(this.rbComisionRemitente);
            this.gbComisiones.Controls.Add(this.rbComisionProducto);
            this.gbComisiones.Controls.Add(this.txtComiaionRemitente);
            this.gbComisiones.Controls.Add(this.txtComisionProducto);
            this.gbComisiones.Location = new System.Drawing.Point(255, 55);
            this.gbComisiones.Name = "gbComisiones";
            this.gbComisiones.Size = new System.Drawing.Size(202, 85);
            this.gbComisiones.TabIndex = 47;
            this.gbComisiones.TabStop = false;
            this.gbComisiones.Tag = "gbComisiones";
            this.gbComisiones.Text = "Comisión";
            // 
            // rbComisionRemitente
            // 
            this.rbComisionRemitente.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbComisionRemitente.Location = new System.Drawing.Point(21, 52);
            this.rbComisionRemitente.Name = "rbComisionRemitente";
            this.rbComisionRemitente.Size = new System.Drawing.Size(77, 17);
            this.rbComisionRemitente.TabIndex = 50;
            this.rbComisionRemitente.TabStop = true;
            this.rbComisionRemitente.Tag = "rbComisionRemitente";
            this.rbComisionRemitente.Text = "Remitente";
            this.rbComisionRemitente.UseVisualStyleBackColor = true;
            // 
            // rbComisionProducto
            // 
            this.rbComisionProducto.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rbComisionProducto.Location = new System.Drawing.Point(21, 19);
            this.rbComisionProducto.Name = "rbComisionProducto";
            this.rbComisionProducto.Size = new System.Drawing.Size(77, 17);
            this.rbComisionProducto.TabIndex = 49;
            this.rbComisionProducto.TabStop = true;
            this.rbComisionProducto.Tag = "rbComisionProducto";
            this.rbComisionProducto.Text = "Producto";
            this.rbComisionProducto.UseVisualStyleBackColor = true;
            // 
            // txtComiaionRemitente
            // 
            this.txtComiaionRemitente.Location = new System.Drawing.Point(109, 52);
            this.txtComiaionRemitente.Name = "txtComiaionRemitente";
            this.txtComiaionRemitente.ReadOnly = true;
            this.txtComiaionRemitente.Size = new System.Drawing.Size(83, 20);
            this.txtComiaionRemitente.TabIndex = 48;
            // 
            // txtComisionProducto
            // 
            this.txtComisionProducto.Location = new System.Drawing.Point(109, 16);
            this.txtComisionProducto.Name = "txtComisionProducto";
            this.txtComisionProducto.ReadOnly = true;
            this.txtComisionProducto.Size = new System.Drawing.Size(83, 20);
            this.txtComisionProducto.TabIndex = 47;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(604, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(91, 20);
            this.textBox3.TabIndex = 44;
            // 
            // lblAPagar
            // 
            this.lblAPagar.Location = new System.Drawing.Point(514, 202);
            this.lblAPagar.Name = "lblAPagar";
            this.lblAPagar.Size = new System.Drawing.Size(83, 20);
            this.lblAPagar.TabIndex = 43;
            this.lblAPagar.Tag = "lblAPagar";
            this.lblAPagar.Text = "A Pagar";
            this.lblAPagar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 42;
            // 
            // lblComision
            // 
            this.lblComision.Location = new System.Drawing.Point(255, 201);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(83, 20);
            this.lblComision.TabIndex = 41;
            this.lblComision.Tag = "lblComision";
            this.lblComision.Text = "Total Comisión";
            this.lblComision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 40;
            // 
            // lblTotalVentas
            // 
            this.lblTotalVentas.Location = new System.Drawing.Point(6, 202);
            this.lblTotalVentas.Name = "lblTotalVentas";
            this.lblTotalVentas.Size = new System.Drawing.Size(71, 20);
            this.lblTotalVentas.TabIndex = 39;
            this.lblTotalVentas.Tag = "lblTotalVentas";
            this.lblTotalVentas.Text = "Total Ventas";
            this.lblTotalVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtActaDecomiso
            // 
            this.txtActaDecomiso.Location = new System.Drawing.Point(604, 162);
            this.txtActaDecomiso.Name = "txtActaDecomiso";
            this.txtActaDecomiso.Size = new System.Drawing.Size(91, 20);
            this.txtActaDecomiso.TabIndex = 38;
            // 
            // lblActa
            // 
            this.lblActa.Location = new System.Drawing.Point(514, 162);
            this.lblActa.Name = "lblActa";
            this.lblActa.Size = new System.Drawing.Size(83, 20);
            this.lblActa.TabIndex = 37;
            this.lblActa.Tag = "lblActa";
            this.lblActa.Text = "Acta Decomiso";
            this.lblActa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCantidadDecomiso
            // 
            this.txtCantidadDecomiso.Location = new System.Drawing.Point(344, 161);
            this.txtCantidadDecomiso.Name = "txtCantidadDecomiso";
            this.txtCantidadDecomiso.Size = new System.Drawing.Size(113, 20);
            this.txtCantidadDecomiso.TabIndex = 36;
            // 
            // lblDecomiso
            // 
            this.lblDecomiso.Location = new System.Drawing.Point(255, 161);
            this.lblDecomiso.Name = "lblDecomiso";
            this.lblDecomiso.Size = new System.Drawing.Size(83, 20);
            this.lblDecomiso.TabIndex = 35;
            this.lblDecomiso.Tag = "lblDecomiso";
            this.lblDecomiso.Text = "Decomiso";
            this.lblDecomiso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(83, 161);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.ReadOnly = true;
            this.txtCantidadVenta.Size = new System.Drawing.Size(159, 20);
            this.txtCantidadVenta.TabIndex = 34;
            // 
            // lblVenta
            // 
            this.lblVenta.Location = new System.Drawing.Point(6, 161);
            this.lblVenta.Name = "lblVenta";
            this.lblVenta.Size = new System.Drawing.Size(61, 20);
            this.lblVenta.TabIndex = 33;
            this.lblVenta.Tag = "lblVenta";
            this.lblVenta.Text = "Venta";
            this.lblVenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtProducto
            // 
            this.txtProducto.AcceptsReturn = true;
            this.txtProducto.Location = new System.Drawing.Point(83, 54);
            this.txtProducto.Multiline = true;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(159, 86);
            this.txtProducto.TabIndex = 29;
            // 
            // txtGuia
            // 
            this.txtGuia.AcceptsReturn = true;
            this.txtGuia.Location = new System.Drawing.Point(604, 16);
            this.txtGuia.Name = "txtGuia";
            this.txtGuia.Size = new System.Drawing.Size(91, 20);
            this.txtGuia.TabIndex = 26;
            // 
            // cmbRemitentes
            // 
            this.cmbRemitentes.FormattingEnabled = true;
            this.cmbRemitentes.Location = new System.Drawing.Point(83, 16);
            this.cmbRemitentes.Name = "cmbRemitentes";
            this.cmbRemitentes.Size = new System.Drawing.Size(159, 21);
            this.cmbRemitentes.TabIndex = 23;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(514, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(83, 20);
            this.lblFecha.TabIndex = 15;
            this.lblFecha.Tag = "lblFecha";
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLote
            // 
            this.lblLote.Location = new System.Drawing.Point(255, 16);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(83, 20);
            this.lblLote.TabIndex = 13;
            this.lblLote.Tag = "lblLote";
            this.lblLote.Text = "Lote";
            this.lblLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Location = new System.Drawing.Point(344, 16);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(113, 21);
            this.cmbUnidad.TabIndex = 12;
            // 
            // lblProducto
            // 
            this.lblProducto.Location = new System.Drawing.Point(6, 54);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(61, 20);
            this.lblProducto.TabIndex = 4;
            this.lblProducto.Tag = "lblProducto";
            this.lblProducto.Text = "Producto";
            this.lblProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRemitente
            // 
            this.lblRemitente.Location = new System.Drawing.Point(6, 16);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(61, 20);
            this.lblRemitente.TabIndex = 2;
            this.lblRemitente.Tag = "lblRemitente";
            this.lblRemitente.Text = "Remitente";
            this.lblRemitente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvLiquidacion
            // 
            this.dgvLiquidacion.AllowUserToAddRows = false;
            this.dgvLiquidacion.AllowUserToDeleteRows = false;
            this.dgvLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLiquidacion.Location = new System.Drawing.Point(12, 290);
            this.dgvLiquidacion.Name = "dgvLiquidacion";
            this.dgvLiquidacion.Size = new System.Drawing.Size(708, 379);
            this.dgvLiquidacion.TabIndex = 2;
            // 
            // Liquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 681);
            this.Controls.Add(this.dgvLiquidacion);
            this.Controls.Add(this.gbData);
            this.Name = "Liquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Liquidacion";
            this.Text = "Liquidacion";
            this.Load += new System.EventHandler(this.Liquidacion_Load);
            this.Controls.SetChildIndex(this.gbData, 0);
            this.Controls.SetChildIndex(this.dgvLiquidacion, 0);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbPrecios.ResumeLayout(false);
            this.gbPrecios.PerformLayout();
            this.gbComisiones.ResumeLayout(false);
            this.gbComisiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiquidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvLiquidacion;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.ComboBox cmbRemitentes;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.GroupBox gbPrecios;
        private System.Windows.Forms.RadioButton rbPrecioPlaza;
        private System.Windows.Forms.RadioButton rbPrecioPromedio;
        private System.Windows.Forms.TextBox txtPrecioPlaza;
        private System.Windows.Forms.TextBox txtPrecioPromedio;
        private System.Windows.Forms.GroupBox gbComisiones;
        private System.Windows.Forms.RadioButton rbComisionRemitente;
        private System.Windows.Forms.RadioButton rbComisionProducto;
        private System.Windows.Forms.TextBox txtComiaionRemitente;
        private System.Windows.Forms.TextBox txtComisionProducto;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblAPagar;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblTotalVentas;
        private System.Windows.Forms.TextBox txtActaDecomiso;
        private System.Windows.Forms.Label lblActa;
        private System.Windows.Forms.TextBox txtCantidadDecomiso;
        private System.Windows.Forms.Label lblDecomiso;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.Label lblVenta;
    }
}