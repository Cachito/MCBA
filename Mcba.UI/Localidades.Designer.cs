namespace Mcba.UI
{
    partial class Localidades
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvLocalidades = new System.Windows.Forms.DataGridView();
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).BeginInit();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.comboBox1);
            this.gbData.Controls.Add(this.lblProvincia);
            this.gbData.Controls.Add(this.txtDescripcion);
            this.gbData.Controls.Add(this.lblDescripcion);
            this.gbData.Controls.Add(this.txtId);
            this.gbData.Controls.Add(this.lblId);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(280, 113);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 79);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // lblProvincia
            // 
            this.lblProvincia.Location = new System.Drawing.Point(6, 79);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(73, 20);
            this.lblProvincia.TabIndex = 4;
            this.lblProvincia.Tag = "lblProvincia";
            this.lblProvincia.Text = "Provincia";
            this.lblProvincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(85, 46);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(168, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(6, 46);
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
            // dgvLocalidades
            // 
            this.dgvLocalidades.AllowUserToAddRows = false;
            this.dgvLocalidades.AllowUserToDeleteRows = false;
            this.dgvLocalidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalidades.Location = new System.Drawing.Point(10, 147);
            this.dgvLocalidades.Name = "dgvLocalidades";
            this.dgvLocalidades.Size = new System.Drawing.Size(282, 237);
            this.dgvLocalidades.TabIndex = 2;
            // 
            // Localidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 391);
            this.Controls.Add(this.dgvLocalidades);
            this.Controls.Add(this.gbData);
            this.Name = "Localidades";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Localidades";
            this.Text = "Localidades";
            this.Load += new System.EventHandler(this.Localidades_Load);
            this.Controls.SetChildIndex(this.gbData, 0);
            this.Controls.SetChildIndex(this.dgvLocalidades, 0);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvLocalidades;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblProvincia;
    }
}