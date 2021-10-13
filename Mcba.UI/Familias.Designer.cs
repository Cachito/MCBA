namespace Mcba.UI
{
    partial class Familias
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
            this.components = new System.ComponentModel.Container();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dgvFamilias = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.chkActivo);
            this.gbData.Controls.Add(this.txtNombre);
            this.gbData.Controls.Add(this.lblId);
            this.gbData.Controls.Add(this.txtId);
            this.gbData.Controls.Add(this.lblNombre);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(280, 108);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            // 
            // chkActivo
            // 
            this.chkActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActivo.Location = new System.Drawing.Point(6, 83);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(95, 20);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.Tag = "chkActivo";
            this.chkActivo.Text = "chkActivo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(85, 48);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(168, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblId
            // 
            this.lblId.Location = new System.Drawing.Point(6, 13);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(73, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Tag = "lblId";
            this.lblId.Text = "lblId";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(6, 48);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(73, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Tag = "lblNombre";
            this.lblNombre.Text = "lblNombre";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvFamilias
            // 
            this.dgvFamilias.AllowUserToAddRows = false;
            this.dgvFamilias.AllowUserToDeleteRows = false;
            this.dgvFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFamilias.Location = new System.Drawing.Point(10, 142);
            this.dgvFamilias.Name = "dgvFamilias";
            this.dgvFamilias.Size = new System.Drawing.Size(282, 202);
            this.dgvFamilias.TabIndex = 2;
            this.dgvFamilias.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamilias_CellClick);
            this.dgvFamilias.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvFamilias_DataBindingComplete);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Familias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 353);
            this.Controls.Add(this.dgvFamilias);
            this.Controls.Add(this.gbData);
            this.Name = "Familias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Tag = "Familias";
            this.Text = "Familias";
            this.Load += new System.EventHandler(this.Familias_Load);
            this.Controls.SetChildIndex(this.gbData, 0);
            this.Controls.SetChildIndex(this.dgvFamilias, 0);
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.DataGridView dgvFamilias;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox chkActivo;
    }
}