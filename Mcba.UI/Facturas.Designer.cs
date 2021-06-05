namespace Mcba.UI
{
    partial class Facturas
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
            this.tsHeader = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.gbDataCliente = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRazónSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.Label();
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPuntoDeVenta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbDataItems = new System.Windows.Forms.GroupBox();
            this.tsItems = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.dgvFacturas = new System.Windows.Forms.DataGridView();
            this.tsHeader.SuspendLayout();
            this.gbDataCliente.SuspendLayout();
            this.gbData.SuspendLayout();
            this.gbDataItems.SuspendLayout();
            this.tsItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // tsHeader
            // 
            this.tsHeader.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbNew,
            this.tsbDelete,
            this.tsbSave,
            this.tsbPrint,
            this.tsbSearch});
            this.tsHeader.Location = new System.Drawing.Point(0, 0);
            this.tsHeader.Name = "tsHeader";
            this.tsHeader.Size = new System.Drawing.Size(750, 25);
            this.tsHeader.TabIndex = 0;
            this.tsHeader.Text = "toolStrip1";
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
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = global::Mcba.UI.Properties.Resources.printerBlack;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbPrint.Text = "toolStripButton1";
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = global::Mcba.UI.Properties.Resources.IconBuscar;
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(23, 22);
            this.tsbSearch.Text = "toolStripButton1";
            // 
            // gbDataCliente
            // 
            this.gbDataCliente.Controls.Add(this.txtTotal);
            this.gbDataCliente.Controls.Add(this.label7);
            this.gbDataCliente.Controls.Add(this.cmbCliente);
            this.gbDataCliente.Controls.Add(this.label4);
            this.gbDataCliente.Controls.Add(this.txtDomicilio);
            this.gbDataCliente.Controls.Add(this.label9);
            this.gbDataCliente.Controls.Add(this.txtCuit);
            this.gbDataCliente.Controls.Add(this.label6);
            this.gbDataCliente.Controls.Add(this.txtRazónSocial);
            this.gbDataCliente.Controls.Add(this.label2);
            this.gbDataCliente.Location = new System.Drawing.Point(12, 81);
            this.gbDataCliente.Name = "gbDataCliente";
            this.gbDataCliente.Size = new System.Drawing.Size(729, 123);
            this.gbDataCliente.TabIndex = 1;
            this.gbDataCliente.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(625, 16);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(90, 20);
            this.txtTotal.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(567, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbCliente
            // 
            this.cmbCliente.FormattingEnabled = true;
            this.cmbCliente.Location = new System.Drawing.Point(85, 16);
            this.cmbCliente.Name = "cmbCliente";
            this.cmbCliente.Size = new System.Drawing.Size(189, 21);
            this.cmbCliente.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Cliente";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(364, 50);
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ReadOnly = true;
            this.txtDomicilio.Size = new System.Drawing.Size(177, 54);
            this.txtDomicilio.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(293, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Domicilio";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(364, 16);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.ReadOnly = true;
            this.txtCuit.Size = new System.Drawing.Size(177, 20);
            this.txtCuit.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(293, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "CUIT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRazónSocial
            // 
            this.txtRazónSocial.Location = new System.Drawing.Point(85, 50);
            this.txtRazónSocial.Multiline = true;
            this.txtRazónSocial.Name = "txtRazónSocial";
            this.txtRazónSocial.ReadOnly = true;
            this.txtRazónSocial.Size = new System.Drawing.Size(189, 53);
            this.txtRazónSocial.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razón Social";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.textBox2);
            this.gbData.Controls.Add(this.label8);
            this.gbData.Controls.Add(this.txtNumero);
            this.gbData.Controls.Add(this.txtFecha);
            this.gbData.Controls.Add(this.txtLetra);
            this.gbData.Controls.Add(this.label5);
            this.gbData.Controls.Add(this.txtPuntoDeVenta);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Location = new System.Drawing.Point(12, 31);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(729, 44);
            this.gbData.TabIndex = 3;
            this.gbData.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(465, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(407, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Fecha";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(312, 16);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.ReadOnly = true;
            this.txtNumero.Size = new System.Drawing.Size(76, 20);
            this.txtNumero.TabIndex = 9;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(254, 16);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(52, 20);
            this.txtFecha.TabIndex = 8;
            this.txtFecha.Text = "Número";
            this.txtFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(193, 16);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.ReadOnly = true;
            this.txtLetra.Size = new System.Drawing.Size(43, 20);
            this.txtLetra.TabIndex = 7;
            this.txtLetra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(147, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Letra";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPuntoDeVenta
            // 
            this.txtPuntoDeVenta.Location = new System.Drawing.Point(85, 16);
            this.txtPuntoDeVenta.Name = "txtPuntoDeVenta";
            this.txtPuntoDeVenta.ReadOnly = true;
            this.txtPuntoDeVenta.Size = new System.Drawing.Size(43, 20);
            this.txtPuntoDeVenta.TabIndex = 5;
            this.txtPuntoDeVenta.Text = "0001";
            this.txtPuntoDeVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pto. de Venta";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbDataItems
            // 
            this.gbDataItems.Controls.Add(this.tsItems);
            this.gbDataItems.Controls.Add(this.dgvFacturas);
            this.gbDataItems.Location = new System.Drawing.Point(12, 210);
            this.gbDataItems.Name = "gbDataItems";
            this.gbDataItems.Size = new System.Drawing.Size(729, 236);
            this.gbDataItems.TabIndex = 4;
            this.gbDataItems.TabStop = false;
            // 
            // tsItems
            // 
            this.tsItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.toolStripButton3,
            this.tsbEdit});
            this.tsItems.Location = new System.Drawing.Point(3, 16);
            this.tsItems.Name = "tsItems";
            this.tsItems.Size = new System.Drawing.Size(723, 25);
            this.tsItems.TabIndex = 4;
            this.tsItems.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::Mcba.UI.Properties.Resources.iconNew;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::Mcba.UI.Properties.Resources.iconDelete;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton1";
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::Mcba.UI.Properties.Resources.iconEditar;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbEdit.Text = "toolStripButton1";
            // 
            // dgvFacturas
            // 
            this.dgvFacturas.AllowUserToAddRows = false;
            this.dgvFacturas.AllowUserToDeleteRows = false;
            this.dgvFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacturas.Location = new System.Drawing.Point(9, 44);
            this.dgvFacturas.Name = "dgvFacturas";
            this.dgvFacturas.Size = new System.Drawing.Size(706, 184);
            this.dgvFacturas.TabIndex = 3;
            // 
            // Facturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gbDataItems);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.gbDataCliente);
            this.Controls.Add(this.tsHeader);
            this.Name = "Facturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.Facturas_Load);
            this.tsHeader.ResumeLayout(false);
            this.tsHeader.PerformLayout();
            this.gbDataCliente.ResumeLayout(false);
            this.gbDataCliente.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.gbDataItems.ResumeLayout(false);
            this.gbDataItems.PerformLayout();
            this.tsItems.ResumeLayout(false);
            this.tsItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsHeader;
        private System.Windows.Forms.GroupBox gbDataCliente;
        private System.Windows.Forms.TextBox txtRazónSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label txtFecha;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPuntoDeVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbDataItems;
        private System.Windows.Forms.DataGridView dgvFacturas;
        private System.Windows.Forms.ToolStrip tsItems;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbPrint;
    }
}