namespace Mcba.UI
{
    partial class Productos
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
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblIva = new System.Windows.Forms.Label();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.lblComision = new System.Windows.Forms.Label();
            this.txtVariedad = new System.Windows.Forms.TextBox();
            this.lblVariedad = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.txtIva);
            this.gbData.Controls.Add(this.lblIva);
            this.gbData.Controls.Add(this.txtComision);
            this.gbData.Controls.Add(this.lblComision);
            this.gbData.Controls.Add(this.txtVariedad);
            this.gbData.Controls.Add(this.lblVariedad);
            this.gbData.Controls.Add(this.txtDescripcion);
            this.gbData.Controls.Add(this.lblDescripcion);
            this.gbData.Controls.Add(this.txtId);
            this.gbData.Controls.Add(this.lblId);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(611, 108);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(419, 76);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(177, 20);
            this.txtIva.TabIndex = 9;
            // 
            // lblIva
            // 
            this.lblIva.Location = new System.Drawing.Point(304, 76);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(100, 20);
            this.lblIva.TabIndex = 8;
            this.lblIva.Tag = "lblIva";
            this.lblIva.Text = "IVA (%)";
            this.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(419, 43);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(177, 20);
            this.txtComision.TabIndex = 7;
            // 
            // lblComision
            // 
            this.lblComision.Location = new System.Drawing.Point(304, 43);
            this.lblComision.Name = "lblComision";
            this.lblComision.Size = new System.Drawing.Size(100, 20);
            this.lblComision.TabIndex = 6;
            this.lblComision.Tag = "lblComision";
            this.lblComision.Text = "Comisión (%)";
            this.lblComision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtVariedad
            // 
            this.txtVariedad.Location = new System.Drawing.Point(121, 77);
            this.txtVariedad.Name = "txtVariedad";
            this.txtVariedad.Size = new System.Drawing.Size(177, 20);
            this.txtVariedad.TabIndex = 5;
            // 
            // lblVariedad
            // 
            this.lblVariedad.Location = new System.Drawing.Point(6, 77);
            this.lblVariedad.Name = "lblVariedad";
            this.lblVariedad.Size = new System.Drawing.Size(100, 20);
            this.lblVariedad.TabIndex = 4;
            this.lblVariedad.Tag = "lblVariedad";
            this.lblVariedad.Text = "Variedad";
            this.lblVariedad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(121, 44);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(177, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(6, 44);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(100, 20);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Tag = "lblDescripcion";
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(121, 13);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(177, 20);
            this.txtId.TabIndex = 1;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(6, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(100, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Tag = "lblId";
            this.lblId.Text = "Id";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 142);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(611, 296);
            this.dgvProductos.TabIndex = 2;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 450);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.gbData);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.Controls.SetChildIndex(this.gbData, 0);
            this.Controls.SetChildIndex(this.dgvProductos, 0);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblVariedad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtVariedad;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label lblComision;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblIva;
    }
}