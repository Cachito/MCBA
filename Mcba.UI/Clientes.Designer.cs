namespace Mcba.UI
{
    partial class Clientes
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
            this.tsClientes = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.cmbProvincia = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cmbPosicion = new System.Windows.Forms.ComboBox();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.gbTelefonos = new System.Windows.Forms.GroupBox();
            this.tsComisiones = new System.Windows.Forms.ToolStrip();
            this.tsbNewTelefono = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteTelefono = new System.Windows.Forms.ToolStripButton();
            this.tsbEditTelefono = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tsClientes.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbTelefonos.SuspendLayout();
            this.tsComisiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsClientes
            // 
            this.tsClientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbNew,
            this.tsbDelete,
            this.tsbEdit,
            this.tsbSave});
            this.tsClientes.Location = new System.Drawing.Point(0, 0);
            this.tsClientes.Name = "tsClientes";
            this.tsClientes.Size = new System.Drawing.Size(810, 25);
            this.tsClientes.TabIndex = 0;
            this.tsClientes.Text = "toolStrip1";
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
            this.tsbDelete.Text = "Eliminar";
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
            this.gbData.Controls.Add(this.cmbProvincia);
            this.gbData.Controls.Add(this.lblProvincia);
            this.gbData.Controls.Add(this.cmbLocalidad);
            this.gbData.Controls.Add(this.lblLocalidad);
            this.gbData.Controls.Add(this.cmbPosicion);
            this.gbData.Controls.Add(this.txtLocalidad);
            this.gbData.Controls.Add(this.lblDomicilio);
            this.gbData.Controls.Add(this.lblCondicion);
            this.gbData.Controls.Add(this.txtCuit);
            this.gbData.Controls.Add(this.lblDni);
            this.gbData.Controls.Add(this.txtApellido);
            this.gbData.Controls.Add(this.lblApellido);
            this.gbData.Controls.Add(this.txtNombre);
            this.gbData.Controls.Add(this.lblNombre);
            this.gbData.Controls.Add(this.txtId);
            this.gbData.Controls.Add(this.lblId);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(789, 140);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            // 
            // cmbProvincia
            // 
            this.cmbProvincia.FormattingEnabled = true;
            this.cmbProvincia.Location = new System.Drawing.Point(613, 44);
            this.cmbProvincia.Name = "cmbProvincia";
            this.cmbProvincia.Size = new System.Drawing.Size(167, 21);
            this.cmbProvincia.TabIndex = 16;
            // 
            // lblProvincia
            // 
            this.lblProvincia.Location = new System.Drawing.Point(538, 44);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(69, 20);
            this.lblProvincia.TabIndex = 15;
            this.lblProvincia.Tag = "lblProvincia";
            this.lblProvincia.Text = "Provincia";
            this.lblProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(613, 75);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(167, 21);
            this.cmbLocalidad.TabIndex = 14;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.Location = new System.Drawing.Point(538, 75);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(69, 20);
            this.lblLocalidad.TabIndex = 13;
            this.lblLocalidad.Tag = "lblLocalidad";
            this.lblLocalidad.Text = "Localidad";
            this.lblLocalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbPosicion
            // 
            this.cmbPosicion.FormattingEnabled = true;
            this.cmbPosicion.Location = new System.Drawing.Point(356, 75);
            this.cmbPosicion.Name = "cmbPosicion";
            this.cmbPosicion.Size = new System.Drawing.Size(168, 21);
            this.cmbPosicion.TabIndex = 12;
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(85, 107);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(695, 20);
            this.txtLocalidad.TabIndex = 11;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.Location = new System.Drawing.Point(6, 106);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(73, 20);
            this.lblDomicilio.TabIndex = 10;
            this.lblDomicilio.Tag = "lblDomicilio";
            this.lblDomicilio.Text = "Domicilio";
            this.lblDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCondicion
            // 
            this.lblCondicion.Location = new System.Drawing.Point(264, 75);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(86, 20);
            this.lblCondicion.TabIndex = 8;
            this.lblCondicion.Tag = "lblCondicion";
            this.lblCondicion.Text = "Condición IVA";
            this.lblCondicion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCuit
            // 
            this.txtCuit.Location = new System.Drawing.Point(356, 44);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(168, 20);
            this.txtCuit.TabIndex = 7;
            // 
            // lblDni
            // 
            this.lblDni.Location = new System.Drawing.Point(264, 44);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(86, 20);
            this.lblDni.TabIndex = 6;
            this.lblDni.Tag = "lblDni";
            this.lblDni.Text = "CUIT/CUIL/DNI";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(85, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(168, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(6, 75);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(73, 20);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Tag = "lblApellido";
            this.lblApellido.Text = "Apellido";
            this.lblApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 44);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(6, 44);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Tag = "lblNombre";
            this.lblNombre.Text = "Nombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(85, 13);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(168, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(6, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Tag = "lblId";
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 174);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(644, 264);
            this.dgvClientes.TabIndex = 2;
            // 
            // gbTelefonos
            // 
            this.gbTelefonos.Controls.Add(this.tsComisiones);
            this.gbTelefonos.Controls.Add(this.dataGridView1);
            this.gbTelefonos.Location = new System.Drawing.Point(662, 174);
            this.gbTelefonos.Name = "gbTelefonos";
            this.gbTelefonos.Size = new System.Drawing.Size(139, 264);
            this.gbTelefonos.TabIndex = 4;
            this.gbTelefonos.TabStop = false;
            this.gbTelefonos.Tag = "gbTelefonos";
            this.gbTelefonos.Text = "Teléfonos";
            // 
            // tsComisiones
            // 
            this.tsComisiones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNewTelefono,
            this.tsbDeleteTelefono,
            this.tsbEditTelefono});
            this.tsComisiones.Location = new System.Drawing.Point(3, 16);
            this.tsComisiones.Name = "tsComisiones";
            this.tsComisiones.Size = new System.Drawing.Size(133, 25);
            this.tsComisiones.TabIndex = 4;
            this.tsComisiones.Text = "toolStrip1";
            // 
            // tsbNewTelefono
            // 
            this.tsbNewTelefono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNewTelefono.Image = global::Mcba.UI.Properties.Resources.iconNew;
            this.tsbNewTelefono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNewTelefono.Name = "tsbNewTelefono";
            this.tsbNewTelefono.Size = new System.Drawing.Size(23, 22);
            this.tsbNewTelefono.Tag = "tsbNewTelefono";
            this.tsbNewTelefono.Text = "Nuevo";
            // 
            // tsbDeleteTelefono
            // 
            this.tsbDeleteTelefono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteTelefono.Image = global::Mcba.UI.Properties.Resources.iconDelete;
            this.tsbDeleteTelefono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteTelefono.Name = "tsbDeleteTelefono";
            this.tsbDeleteTelefono.Size = new System.Drawing.Size(23, 22);
            this.tsbDeleteTelefono.Tag = "tsbDeleteTelefono";
            this.tsbDeleteTelefono.Text = "Eliminar";
            // 
            // tsbEditTelefono
            // 
            this.tsbEditTelefono.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditTelefono.Image = global::Mcba.UI.Properties.Resources.iconEditar;
            this.tsbEditTelefono.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditTelefono.Name = "tsbEditTelefono";
            this.tsbEditTelefono.Size = new System.Drawing.Size(23, 22);
            this.tsbEditTelefono.Tag = "tsbEditTelefono";
            this.tsbEditTelefono.Text = "Editar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(127, 214);
            this.dataGridView1.TabIndex = 3;
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gbTelefonos);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.tsClientes);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Clientes";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            this.tsClientes.ResumeLayout(false);
            this.tsClientes.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbTelefonos.ResumeLayout(false);
            this.gbTelefonos.PerformLayout();
            this.tsComisiones.ResumeLayout(false);
            this.tsComisiones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsClientes;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvClientes;
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
        private System.Windows.Forms.ComboBox cmbPosicion;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.ComboBox cmbProvincia;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.ComboBox cmbLocalidad;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.GroupBox gbTelefonos;
        private System.Windows.Forms.ToolStrip tsComisiones;
        private System.Windows.Forms.ToolStripButton tsbNewTelefono;
        private System.Windows.Forms.ToolStripButton tsbDeleteTelefono;
        private System.Windows.Forms.ToolStripButton tsbEditTelefono;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}