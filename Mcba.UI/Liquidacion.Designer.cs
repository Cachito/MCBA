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
            this.tsSock = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtGuia = new System.Windows.Forms.TextBox();
            this.cmbRemitentes = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbUnidad = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLiquidacion = new System.Windows.Forms.DataGridView();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.txtCantidadVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidadDecomiso = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtActaDecomiso = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.gbComisiones = new System.Windows.Forms.GroupBox();
            this.rbComisionRemitente = new System.Windows.Forms.RadioButton();
            this.rbComisionProducto = new System.Windows.Forms.RadioButton();
            this.txtComiaionRemitente = new System.Windows.Forms.TextBox();
            this.txtComisionProducto = new System.Windows.Forms.TextBox();
            this.gbPrecios = new System.Windows.Forms.GroupBox();
            this.rbPrecioPlaza = new System.Windows.Forms.RadioButton();
            this.rbPrecioPromedio = new System.Windows.Forms.RadioButton();
            this.txtPrecioPlaza = new System.Windows.Forms.TextBox();
            this.txtPrecioPromedio = new System.Windows.Forms.TextBox();
            this.tsbBuscar = new System.Windows.Forms.ToolStripButton();
            this.tsSock.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiquidacion)).BeginInit();
            this.gbComisiones.SuspendLayout();
            this.gbPrecios.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsSock
            // 
            this.tsSock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbNew,
            this.tsbDelete,
            this.tsbEdit,
            this.tsbSave,
            this.tsbPrint,
            this.tsbBuscar});
            this.tsSock.Location = new System.Drawing.Point(0, 0);
            this.tsSock.Name = "tsSock";
            this.tsSock.Size = new System.Drawing.Size(729, 25);
            this.tsSock.TabIndex = 0;
            this.tsSock.Text = "toolStrip1";
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
            this.tsbNew.Image = global::Mcba.UI.Properties.Resources.iconNew;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 22);
            this.tsbNew.Text = "toolStripButton1";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::Mcba.UI.Properties.Resources.iconDelete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Text = "toolStripButton1";
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::Mcba.UI.Properties.Resources.iconEditar;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbEdit.Text = "toolStripButton1";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::Mcba.UI.Properties.Resources.iconSave;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "toolStripButton1";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.gbPrecios);
            this.gbData.Controls.Add(this.gbComisiones);
            this.gbData.Controls.Add(this.textBox3);
            this.gbData.Controls.Add(this.label14);
            this.gbData.Controls.Add(this.textBox2);
            this.gbData.Controls.Add(this.label13);
            this.gbData.Controls.Add(this.textBox1);
            this.gbData.Controls.Add(this.label12);
            this.gbData.Controls.Add(this.txtActaDecomiso);
            this.gbData.Controls.Add(this.label11);
            this.gbData.Controls.Add(this.txtCantidadDecomiso);
            this.gbData.Controls.Add(this.label10);
            this.gbData.Controls.Add(this.txtCantidadVenta);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Controls.Add(this.txtProducto);
            this.gbData.Controls.Add(this.txtGuia);
            this.gbData.Controls.Add(this.cmbRemitentes);
            this.gbData.Controls.Add(this.label8);
            this.gbData.Controls.Add(this.label7);
            this.gbData.Controls.Add(this.cmbUnidad);
            this.gbData.Controls.Add(this.label3);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(708, 240);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
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
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(514, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Fecha";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(255, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Lote";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbUnidad
            // 
            this.cmbUnidad.FormattingEnabled = true;
            this.cmbUnidad.Location = new System.Drawing.Point(344, 16);
            this.cmbUnidad.Name = "cmbUnidad";
            this.cmbUnidad.Size = new System.Drawing.Size(113, 21);
            this.cmbUnidad.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Producto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Remitente";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = global::Mcba.UI.Properties.Resources.iconPrinter;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbPrint.Text = "toolStripButton1";
            // 
            // txtCantidadVenta
            // 
            this.txtCantidadVenta.Location = new System.Drawing.Point(83, 161);
            this.txtCantidadVenta.Name = "txtCantidadVenta";
            this.txtCantidadVenta.ReadOnly = true;
            this.txtCantidadVenta.Size = new System.Drawing.Size(159, 20);
            this.txtCantidadVenta.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCantidadDecomiso
            // 
            this.txtCantidadDecomiso.Location = new System.Drawing.Point(344, 161);
            this.txtCantidadDecomiso.Name = "txtCantidadDecomiso";
            this.txtCantidadDecomiso.Size = new System.Drawing.Size(113, 20);
            this.txtCantidadDecomiso.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(255, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "Decomiso";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtActaDecomiso
            // 
            this.txtActaDecomiso.Location = new System.Drawing.Point(604, 162);
            this.txtActaDecomiso.Name = "txtActaDecomiso";
            this.txtActaDecomiso.Size = new System.Drawing.Size(91, 20);
            this.txtActaDecomiso.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(514, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 37;
            this.label11.Text = "Acta Decomiso";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 202);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(159, 20);
            this.textBox1.TabIndex = 40;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 39;
            this.label12.Text = "Total Ventas";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(344, 201);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(113, 20);
            this.textBox2.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(255, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 41;
            this.label13.Text = "Total Comisión";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(604, 202);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(91, 20);
            this.textBox3.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(514, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 20);
            this.label14.TabIndex = 43;
            this.label14.Text = "A Pagar";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // tsbBuscar
            // 
            this.tsbBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBuscar.Image = global::Mcba.UI.Properties.Resources.IconBuscar;
            this.tsbBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBuscar.Name = "tsbBuscar";
            this.tsbBuscar.Size = new System.Drawing.Size(23, 22);
            this.tsbBuscar.Text = "toolStripButton1";
            // 
            // Liquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 681);
            this.ControlBox = false;
            this.Controls.Add(this.dgvLiquidacion);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.tsSock);
            this.Name = "Liquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Liquidacion";
            this.Load += new System.EventHandler(this.Liquidacion_Load);
            this.tsSock.ResumeLayout(false);
            this.tsSock.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLiquidacion)).EndInit();
            this.gbComisiones.ResumeLayout(false);
            this.gbComisiones.PerformLayout();
            this.gbPrecios.ResumeLayout(false);
            this.gbPrecios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSock;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvLiquidacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ComboBox cmbUnidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbRemitentes;
        private System.Windows.Forms.TextBox txtGuia;
        private System.Windows.Forms.ToolStripButton tsbPrint;
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
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtActaDecomiso;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidadDecomiso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCantidadVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton tsbBuscar;
    }
}