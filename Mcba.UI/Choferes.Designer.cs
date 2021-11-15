namespace Mcba.UI
{
    partial class Choferes
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
            this.cmbRemitentes = new System.Windows.Forms.ComboBox();
            this.lblRemitente = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvChoferes = new System.Windows.Forms.DataGridView();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).BeginInit();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.cmbRemitentes);
            this.gbData.Controls.Add(this.lblRemitente);
            this.gbData.Controls.Add(this.txtDni);
            this.gbData.Controls.Add(this.lblDni);
            this.gbData.Controls.Add(this.txtApellido);
            this.gbData.Controls.Add(this.lblApellido);
            this.gbData.Controls.Add(this.txtNombre);
            this.gbData.Controls.Add(this.lblNombre);
            this.gbData.Controls.Add(this.txtId);
            this.gbData.Controls.Add(this.lblId);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(541, 108);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            // 
            // cmbRemitentes
            // 
            this.cmbRemitentes.FormattingEnabled = true;
            this.cmbRemitentes.Location = new System.Drawing.Point(357, 77);
            this.cmbRemitentes.Name = "cmbRemitentes";
            this.cmbRemitentes.Size = new System.Drawing.Size(168, 21);
            this.cmbRemitentes.TabIndex = 12;
            // 
            // lblRemitente
            // 
            this.lblRemitente.Location = new System.Drawing.Point(265, 77);
            this.lblRemitente.Name = "lblRemitente";
            this.lblRemitente.Size = new System.Drawing.Size(86, 20);
            this.lblRemitente.TabIndex = 8;
            this.lblRemitente.Tag = "lblRemitente";
            this.lblRemitente.Text = "Remitente";
            this.lblRemitente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(357, 44);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(168, 20);
            this.txtDni.TabIndex = 7;
            // 
            // lblDni
            // 
            this.lblDni.Location = new System.Drawing.Point(265, 44);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(86, 20);
            this.lblDni.TabIndex = 6;
            this.lblDni.Tag = "lblDni";
            this.lblDni.Text = "DNI";
            this.lblDni.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(85, 77);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(168, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // lblApellido
            // 
            this.lblApellido.Location = new System.Drawing.Point(6, 77);
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
            // dgvChoferes
            // 
            this.dgvChoferes.AllowUserToAddRows = false;
            this.dgvChoferes.AllowUserToDeleteRows = false;
            this.dgvChoferes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChoferes.Location = new System.Drawing.Point(12, 142);
            this.dgvChoferes.Name = "dgvChoferes";
            this.dgvChoferes.Size = new System.Drawing.Size(541, 296);
            this.dgvChoferes.TabIndex = 2;
            // 
            // Choferes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.dgvChoferes);
            this.Controls.Add(this.gbData);
            this.Name = "Choferes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Choferes";
            this.Text = "Choferes";
            this.Load += new System.EventHandler(this.Choferes_Load);
            this.Controls.SetChildIndex(this.gbData, 0);
            this.Controls.SetChildIndex(this.dgvChoferes, 0);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChoferes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvChoferes;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbRemitentes;
        private System.Windows.Forms.Label lblRemitente;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
    }
}