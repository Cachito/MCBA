namespace Mcba.UI
{
    partial class Bitacoras
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
            this.tsBitacora = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbFind = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.cmbCriticidad = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.lblHasha = new System.Windows.Forms.Label();
            this.lblCriticidad = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.dgvBitacora = new System.Windows.Forms.DataGridView();
            this.tsBitacora.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).BeginInit();
            this.SuspendLayout();
            // 
            // tsBitacora
            // 
            this.tsBitacora.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbFind,
            this.tsbPrint});
            this.tsBitacora.Location = new System.Drawing.Point(0, 0);
            this.tsBitacora.Name = "tsBitacora";
            this.tsBitacora.Size = new System.Drawing.Size(820, 25);
            this.tsBitacora.TabIndex = 0;
            this.tsBitacora.Text = "toolStrip1";
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
            // tsbFind
            // 
            this.tsbFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFind.Image = global::Mcba.UI.Properties.Resources.IconBuscar;
            this.tsbFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFind.Name = "tsbFind";
            this.tsbFind.Size = new System.Drawing.Size(23, 22);
            this.tsbFind.Tag = "tsbFind";
            this.tsbFind.Text = "Buscar";
            this.tsbFind.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = global::Mcba.UI.Properties.Resources.printerBlack;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbPrint.Tag = "tsbPrint";
            this.tsbPrint.Text = "Imprimir";
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.cmbCriticidad);
            this.gbData.Controls.Add(this.dateTimePicker1);
            this.gbData.Controls.Add(this.dtpDesde);
            this.gbData.Controls.Add(this.cmbUsuarios);
            this.gbData.Controls.Add(this.lblHasha);
            this.gbData.Controls.Add(this.lblCriticidad);
            this.gbData.Controls.Add(this.lblDesde);
            this.gbData.Controls.Add(this.lblUsuario);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(451, 77);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            // 
            // cmbCriticidad
            // 
            this.cmbCriticidad.FormattingEnabled = true;
            this.cmbCriticidad.Location = new System.Drawing.Point(85, 42);
            this.cmbCriticidad.Name = "cmbCriticidad";
            this.cmbCriticidad.Size = new System.Drawing.Size(168, 21);
            this.cmbCriticidad.TabIndex = 15;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(357, 42);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(79, 20);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // dtpDesde
            // 
            this.dtpDesde.CustomFormat = "dd/MM/yyyy";
            this.dtpDesde.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesde.Location = new System.Drawing.Point(357, 13);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(79, 20);
            this.dtpDesde.TabIndex = 13;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(85, 13);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(168, 21);
            this.cmbUsuarios.TabIndex = 12;
            // 
            // lblHasha
            // 
            this.lblHasha.Location = new System.Drawing.Point(265, 44);
            this.lblHasha.Name = "lblHasha";
            this.lblHasha.Size = new System.Drawing.Size(86, 20);
            this.lblHasha.TabIndex = 6;
            this.lblHasha.Tag = "lblHasha";
            this.lblHasha.Text = "Fecha Hasta";
            this.lblHasha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCriticidad
            // 
            this.lblCriticidad.Location = new System.Drawing.Point(6, 44);
            this.lblCriticidad.Name = "lblCriticidad";
            this.lblCriticidad.Size = new System.Drawing.Size(73, 20);
            this.lblCriticidad.TabIndex = 4;
            this.lblCriticidad.Tag = "lblCriticidad";
            this.lblCriticidad.Text = "Criticidad";
            this.lblCriticidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesde
            // 
            this.lblDesde.Location = new System.Drawing.Point(265, 13);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(73, 20);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Tag = "lblDesde";
            this.lblDesde.Text = "Fecha Desde";
            this.lblDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(6, 13);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(73, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Tag = "lblUsuario";
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvBitacora
            // 
            this.dgvBitacora.AllowUserToAddRows = false;
            this.dgvBitacora.AllowUserToDeleteRows = false;
            this.dgvBitacora.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBitacora.Location = new System.Drawing.Point(12, 111);
            this.dgvBitacora.Name = "dgvBitacora";
            this.dgvBitacora.Size = new System.Drawing.Size(796, 353);
            this.dgvBitacora.TabIndex = 2;
            // 
            // Bitacora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 476);
            this.ControlBox = false;
            this.Controls.Add(this.dgvBitacora);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.tsBitacora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Bitacora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Bitacora";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.Bitacora_Load);
            this.tsBitacora.ResumeLayout(false);
            this.tsBitacora.PerformLayout();
            this.gbData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBitacora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsBitacora;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvBitacora;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblCriticidad;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbFind;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label lblHasha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.ComboBox cmbCriticidad;
    }
}