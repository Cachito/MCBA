namespace Mcba.UI
{
    partial class CondicionesIva
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
            this.tsCondicionesIva = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.chkDiscrimina = new System.Windows.Forms.CheckBox();
            this.rbLetraB = new System.Windows.Forms.RadioButton();
            this.rbLetraA = new System.Windows.Forms.RadioButton();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblLetra = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvCondicionesIva = new System.Windows.Forms.DataGridView();
            this.tsCondicionesIva.SuspendLayout();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicionesIva)).BeginInit();
            this.SuspendLayout();
            // 
            // tsCondicionesIva
            // 
            this.tsCondicionesIva.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbNew,
            this.tsbDelete,
            this.tsbEdit,
            this.tsbSave});
            this.tsCondicionesIva.Location = new System.Drawing.Point(0, 0);
            this.tsCondicionesIva.Name = "tsCondicionesIva";
            this.tsCondicionesIva.Size = new System.Drawing.Size(564, 25);
            this.tsCondicionesIva.TabIndex = 0;
            this.tsCondicionesIva.Text = "toolStrip1";
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
            this.gbData.Controls.Add(this.chkDiscrimina);
            this.gbData.Controls.Add(this.rbLetraB);
            this.gbData.Controls.Add(this.rbLetraA);
            this.gbData.Controls.Add(this.txtPorcentaje);
            this.gbData.Controls.Add(this.lblPorcentaje);
            this.gbData.Controls.Add(this.lblLetra);
            this.gbData.Controls.Add(this.txtDescripcion);
            this.gbData.Controls.Add(this.lblDescripcion);
            this.gbData.Controls.Add(this.txtId);
            this.gbData.Controls.Add(this.lblId);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(541, 108);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            // 
            // chkDiscrimina
            // 
            this.chkDiscrimina.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkDiscrimina.Location = new System.Drawing.Point(265, 79);
            this.chkDiscrimina.Name = "chkDiscrimina";
            this.chkDiscrimina.Size = new System.Drawing.Size(140, 24);
            this.chkDiscrimina.TabIndex = 15;
            this.chkDiscrimina.Tag = "chkDiscrimina";
            this.chkDiscrimina.Text = "Discrimina IVA";
            this.chkDiscrimina.UseVisualStyleBackColor = true;
            // 
            // rbLetraB
            // 
            this.rbLetraB.AutoSize = true;
            this.rbLetraB.Location = new System.Drawing.Point(184, 79);
            this.rbLetraB.Name = "rbLetraB";
            this.rbLetraB.Size = new System.Drawing.Size(32, 17);
            this.rbLetraB.TabIndex = 14;
            this.rbLetraB.TabStop = true;
            this.rbLetraB.Text = "B";
            this.rbLetraB.UseVisualStyleBackColor = true;
            // 
            // rbLetraA
            // 
            this.rbLetraA.AutoSize = true;
            this.rbLetraA.Location = new System.Drawing.Point(121, 79);
            this.rbLetraA.Name = "rbLetraA";
            this.rbLetraA.Size = new System.Drawing.Size(32, 17);
            this.rbLetraA.TabIndex = 13;
            this.rbLetraA.TabStop = true;
            this.rbLetraA.Text = "A";
            this.rbLetraA.UseVisualStyleBackColor = true;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(357, 45);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(168, 20);
            this.txtPorcentaje.TabIndex = 7;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.Location = new System.Drawing.Point(265, 45);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(86, 20);
            this.lblPorcentaje.TabIndex = 6;
            this.lblPorcentaje.Tag = "lblPorcentaje";
            this.lblPorcentaje.Text = "Porcentaje";
            this.lblPorcentaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLetra
            // 
            this.lblLetra.Location = new System.Drawing.Point(6, 77);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(109, 20);
            this.lblLetra.TabIndex = 4;
            this.lblLetra.Tag = "lblLetra";
            this.lblLetra.Text = "Letra Factura";
            this.lblLetra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(85, 45);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(168, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(6, 45);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(73, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Tag = "lblDescripcion";
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // dgvCondicionesIva
            // 
            this.dgvCondicionesIva.AllowUserToAddRows = false;
            this.dgvCondicionesIva.AllowUserToDeleteRows = false;
            this.dgvCondicionesIva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCondicionesIva.Location = new System.Drawing.Point(12, 142);
            this.dgvCondicionesIva.Name = "dgvCondicionesIva";
            this.dgvCondicionesIva.Size = new System.Drawing.Size(541, 296);
            this.dgvCondicionesIva.TabIndex = 2;
            // 
            // CondicionesIva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.ControlBox = false;
            this.Controls.Add(this.dgvCondicionesIva);
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.tsCondicionesIva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CondicionesIva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "CondicionesIva";
            this.Text = "Condiciones IVA";
            this.Load += new System.EventHandler(this.CondicionesIva_Load);
            this.tsCondicionesIva.ResumeLayout(false);
            this.tsCondicionesIva.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicionesIva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCondicionesIva;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvCondicionesIva;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.CheckBox chkDiscrimina;
        private System.Windows.Forms.RadioButton rbLetraB;
        private System.Windows.Forms.RadioButton rbLetraA;
    }
}