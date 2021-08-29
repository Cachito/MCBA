namespace Mcba.UI
{
    partial class Remitentes
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
            this.tsRemitentes = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.cmbProvincias = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.cmbPosicion = new System.Windows.Forms.ComboBox();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.cmbTipoCuenta = new System.Windows.Forms.ComboBox();
            this.lblTipoCuenta = new System.Windows.Forms.Label();
            this.cmbBancos = new System.Windows.Forms.ComboBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.lblBanco = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvRemitentes = new System.Windows.Forms.DataGridView();
            this.gbComisiones = new System.Windows.Forms.GroupBox();
            this.tsComisiones = new System.Windows.Forms.ToolStrip();
            this.tsbNewComision = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteComision = new System.Windows.Forms.ToolStripButton();
            this.tsbEditComision = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsRemitentes.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemitentes)).BeginInit();
            this.gbComisiones.SuspendLayout();
            this.tsComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsRemitentes
            // 
            this.tsRemitentes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbNew,
            this.tsbDelete,
            this.tsbEdit,
            this.tsbSave});
            this.tsRemitentes.Location = new System.Drawing.Point(0, 0);
            this.tsRemitentes.Name = "tsRemitentes";
            this.tsRemitentes.Size = new System.Drawing.Size(802, 25);
            this.tsRemitentes.TabIndex = 0;
            this.tsRemitentes.Text = "toolStrip1";
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
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::Mcba.UI.Properties.Resources.iconNew;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 22);
            this.tsbNew.Tag = "tsbNew";
            this.tsbNew.Text = "Nuevo";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = global::Mcba.UI.Properties.Resources.iconDelete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(23, 22);
            this.tsbDelete.Tag = "tsbDelete";
            this.tsbDelete.Text = "Elimiar";
            // 
            // tsbEdit
            // 
            this.tsbEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEdit.Image = global::Mcba.UI.Properties.Resources.iconEditar;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(23, 22);
            this.tsbEdit.Tag = "tsbEdit";
            this.tsbEdit.Text = "Editar";
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::Mcba.UI.Properties.Resources.iconSave;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Tag = "tsbSave";
            this.tsbSave.Text = "Guardar";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.cmbProvincias);
            this.gbData.Controls.Add(this.lblProvincia);
            this.gbData.Controls.Add(this.cmbLocalidad);
            this.gbData.Controls.Add(this.lblLocalidad);
            this.gbData.Controls.Add(this.txtDomicilio);
            this.gbData.Controls.Add(this.lblDomicilio);
            this.gbData.Controls.Add(this.cmbPosicion);
            this.gbData.Controls.Add(this.lblCondicion);
            this.gbData.Controls.Add(this.cmbTipoCuenta);
            this.gbData.Controls.Add(this.lblTipoCuenta);
            this.gbData.Controls.Add(this.cmbBancos);
            this.gbData.Controls.Add(this.txtLocalidad);
            this.gbData.Controls.Add(this.lblCuenta);
            this.gbData.Controls.Add(this.lblBanco);
            this.gbData.Controls.Add(this.txtCuit);
            this.gbData.Controls.Add(this.lblCuit);
            this.gbData.Controls.Add(this.txtApellido);
            this.gbData.Controls.Add(this.lblApellido);
            this.gbData.Controls.Add(this.txtNombre);
            this.gbData.Controls.Add(this.lblNombre);
            this.gbData.Controls.Add(this.txtId);
            this.gbData.Controls.Add(this.lblId);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(789, 175);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            // 
            // cmbProvincias
            // 
            this.cmbProvincias.FormattingEnabled = true;
            this.cmbProvincias.Location = new System.Drawing.Point(357, 145);
            this.cmbProvincias.Name = "cmbProvincias";
            this.cmbProvincias.Size = new System.Drawing.Size(167, 21);
            this.cmbProvincias.TabIndex = 22;
            // 
            // lblProvincia
            // 
            this.lblProvincia.Location = new System.Drawing.Point(264, 145);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(86, 20);
            this.lblProvincia.TabIndex = 21;
            this.lblProvincia.Tag = "lblProvincia";
            this.lblProvincia.Text = "Provincia";
            this.lblProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(616, 145);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(167, 21);
            this.cmbLocalidad.TabIndex = 20;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.Location = new System.Drawing.Point(536, 145);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(73, 20);
            this.lblLocalidad.TabIndex = 19;
            this.lblLocalidad.Tag = "lblLocalidad";
            this.lblLocalidad.Text = "Localidad";
            this.lblLocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(615, 46);
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(168, 86);
            this.txtDomicilio.TabIndex = 18;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Location = new System.Drawing.Point(536, 46);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(73, 20);
            this.lblDomicilio.TabIndex = 17;
            this.lblDomicilio.Tag = "lblDomicilio";
            this.lblDomicilio.Text = "Domicilio";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPosicion
            // 
            this.cmbPosicion.FormattingEnabled = true;
            this.cmbPosicion.Location = new System.Drawing.Point(101, 145);
            this.cmbPosicion.Name = "cmbPosicion";
            this.cmbPosicion.Size = new System.Drawing.Size(152, 21);
            this.cmbPosicion.TabIndex = 16;
            // 
            // lblCondicion
            // 
            this.lblCondicion.Location = new System.Drawing.Point(6, 145);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(89, 20);
            this.lblCondicion.TabIndex = 15;
            this.lblCondicion.Tag = "lblCondicion";
            this.lblCondicion.Text = "Condición de IVA";
            this.lblCondicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbTipoCuenta
            // 
            this.cmbTipoCuenta.FormattingEnabled = true;
            this.cmbTipoCuenta.Location = new System.Drawing.Point(357, 112);
            this.cmbTipoCuenta.Name = "cmbTipoCuenta";
            this.cmbTipoCuenta.Size = new System.Drawing.Size(167, 21);
            this.cmbTipoCuenta.TabIndex = 14;
            // 
            // lblTipoCuenta
            // 
            this.lblTipoCuenta.Location = new System.Drawing.Point(264, 112);
            this.lblTipoCuenta.Name = "lblTipoCuenta";
            this.lblTipoCuenta.Size = new System.Drawing.Size(86, 20);
            this.lblTipoCuenta.TabIndex = 13;
            this.lblTipoCuenta.Tag = "lblTipoCuenta";
            this.lblTipoCuenta.Text = "Tipo de Cuenta";
            this.lblTipoCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbBancos
            // 
            this.cmbBancos.FormattingEnabled = true;
            this.cmbBancos.Location = new System.Drawing.Point(356, 46);
            this.cmbBancos.Name = "cmbBancos";
            this.cmbBancos.Size = new System.Drawing.Size(168, 21);
            this.cmbBancos.TabIndex = 12;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(356, 78);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(168, 20);
            this.txtLocalidad.TabIndex = 11;
            // 
            // lblCuenta
            // 
            this.lblCuenta.Location = new System.Drawing.Point(264, 78);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(86, 20);
            this.lblCuenta.TabIndex = 10;
            this.lblCuenta.Tag = "lblCuenta";
            this.lblCuenta.Text = "Cuenta Banco";
            this.lblCuenta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBanco
            // 
            this.lblBanco.Location = new System.Drawing.Point(264, 46);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(86, 20);
            this.lblBanco.TabIndex = 8;
            this.lblBanco.Tag = "lblBanco";
            this.lblBanco.Text = "Banco";
            this.lblBanco.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(100, 112);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(153, 20);
            this.txtCuit.TabIndex = 7;
            // 
            // lblCuit
            // 
            this.lblCuit.Location = new System.Drawing.Point(6, 112);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(89, 20);
            this.lblCuit.TabIndex = 6;
            this.lblCuit.Tag = "lblCuit";
            this.lblCuit.Text = "CUIT";
            this.lblCuit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(100, 79);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(153, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(6, 79);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(89, 20);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Tag = "lblApellido";
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(100, 46);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(153, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(6, 46);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(89, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Tag = "lblNombre";
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(100, 13);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(153, 20);
            this.txtId.TabIndex = 0;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(6, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(89, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Tag = "lblId";
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvRemitentes
            // 
            this.dgvRemitentes.AllowUserToAddRows = false;
            this.dgvRemitentes.AllowUserToDeleteRows = false;
            this.dgvRemitentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRemitentes.Location = new System.Drawing.Point(12, 209);
            this.dgvRemitentes.Name = "dgvRemitentes";
            this.dgvRemitentes.Size = new System.Drawing.Size(524, 229);
            this.dgvRemitentes.TabIndex = 2;
            // 
            // gbComisiones
            // 
            this.gbComisiones.Controls.Add(this.tsComisiones);
            this.gbComisiones.Controls.Add(this.dataGridView1);
            this.gbComisiones.Location = new System.Drawing.Point(551, 209);
            this.gbComisiones.Name = "gbComisiones";
            this.gbComisiones.Size = new System.Drawing.Size(244, 229);
            this.gbComisiones.TabIndex = 3;
            this.gbComisiones.TabStop = false;
            this.gbComisiones.Tag = "gbComisiones";
            this.gbComisiones.Text = "Comisiones";
            // 
            // tsComisiones
            // 
            this.tsComisiones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewComision,
            this.tsbDeleteComision,
            this.tsbEditComision});
            this.tsComisiones.Location = new System.Drawing.Point(3, 16);
            this.tsComisiones.Name = "tsComisiones";
            this.tsComisiones.Size = new System.Drawing.Size(238, 25);
            this.tsComisiones.TabIndex = 4;
            this.tsComisiones.Text = "toolStrip1";
            // 
            // tsbNewComision
            // 
            this.tsbNewComision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewComision.Image = global::Mcba.UI.Properties.Resources.iconNew;
            this.tsbNewComision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewComision.Name = "tsbNewComision";
            this.tsbNewComision.Size = new System.Drawing.Size(23, 22);
            this.tsbNewComision.Tag = "tsbNewComision";
            this.tsbNewComision.Text = "Nueva";
            // 
            // tsbDeleteComision
            // 
            this.tsbDeleteComision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteComision.Image = global::Mcba.UI.Properties.Resources.iconDelete;
            this.tsbDeleteComision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteComision.Name = "tsbDeleteComision";
            this.tsbDeleteComision.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteComision.Tag = "tsbDeleteComision";
            this.tsbDeleteComision.Text = "Eliminar";
            // 
            // tsbEditComision
            // 
            this.tsbEditComision.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditComision.Image = global::Mcba.UI.Properties.Resources.iconEditar;
            this.tsbEditComision.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditComision.Name = "tsbEditComision";
            this.tsbEditComision.Size = new System.Drawing.Size(23, 22);
            this.tsbEditComision.Tag = "tsbEditComision";
            this.tsbEditComision.Text = "Editar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(232, 179);
            this.dataGridView1.TabIndex = 3;
            // 
            // Remitentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 443);
            this.ControlBox = false;
            this.Controls.Add(this.gbComisiones);
            this.Controls.Add(this.dgvRemitentes);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.tsRemitentes);
            this.Name = "Remitentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Remitentes";
            this.Text = "Remitentes";
            this.Load += new System.EventHandler(this.Remitentes_Load);
            this.tsRemitentes.ResumeLayout(false);
            this.tsRemitentes.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRemitentes)).EndInit();
            this.gbComisiones.ResumeLayout(false);
            this.gbComisiones.PerformLayout();
            this.tsComisiones.ResumeLayout(false);
            this.tsComisiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsRemitentes;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvRemitentes;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbBancos;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.ComboBox cmbPosicion;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.ComboBox cmbTipoCuenta;
        private System.Windows.Forms.Label lblTipoCuenta;
        private System.Windows.Forms.ComboBox cmbProvincias;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.GroupBox gbComisiones;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip tsComisiones;
        private System.Windows.Forms.ToolStripButton tsbNewComision;
        private System.Windows.Forms.ToolStripButton tsbDeleteComision;
        private System.Windows.Forms.ToolStripButton tsbEditComision;
    }
}