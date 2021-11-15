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
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicionesIva)).BeginInit();
            this.SuspendLayout();
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
            this.Controls.Add(this.dgvCondicionesIva);
            this.Controls.Add(this.gbData);
            this.Name = "CondicionesIva";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "CondicionesIva";
            this.Text = "Condiciones IVA";
            this.Load += new System.EventHandler(this.CondicionesIva_Load);
            this.Controls.SetChildIndex(this.gbData, 0);
            this.Controls.SetChildIndex(this.dgvCondicionesIva, 0);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCondicionesIva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvCondicionesIva;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.CheckBox chkDiscrimina;
        private System.Windows.Forms.RadioButton rbLetraB;
        private System.Windows.Forms.RadioButton rbLetraA;
    }
}