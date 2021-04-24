namespace Mcba.UI
{
    partial class PermisosUsuarios
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
            this.tsSeguridad = new System.Windows.Forms.ToolStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.gbFamilias = new System.Windows.Forms.GroupBox();
            this.DgvFamiliasAsignadas = new System.Windows.Forms.DataGridView();
            this.dvgFamilias = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.btnAddFamilia = new System.Windows.Forms.Button();
            this.btnRemoveFamilia = new System.Windows.Forms.Button();
            this.gbPatentes = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPatentesAsignadas = new System.Windows.Forms.DataGridView();
            this.dgvPatentes = new System.Windows.Forms.DataGridView();
            this.tsSeguridad.SuspendLayout();
            this.gbFamilias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvFamiliasAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFamilias)).BeginInit();
            this.gbPatentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentesAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentes)).BeginInit();
            this.SuspendLayout();
            // 
            // tsSeguridad
            // 
            this.tsSeguridad.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbSave});
            this.tsSeguridad.Location = new System.Drawing.Point(0, 0);
            this.tsSeguridad.Name = "tsSeguridad";
            this.tsSeguridad.Size = new System.Drawing.Size(734, 25);
            this.tsSeguridad.TabIndex = 0;
            this.tsSeguridad.Text = "toolStrip1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(69, 28);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(268, 21);
            this.cmbUsuarios.TabIndex = 5;
            // 
            // gbFamilias
            // 
            this.gbFamilias.Controls.Add(this.btnRemoveFamilia);
            this.gbFamilias.Controls.Add(this.btnAddFamilia);
            this.gbFamilias.Controls.Add(this.label3);
            this.gbFamilias.Controls.Add(this.label2);
            this.gbFamilias.Controls.Add(this.DgvFamiliasAsignadas);
            this.gbFamilias.Controls.Add(this.dvgFamilias);
            this.gbFamilias.Location = new System.Drawing.Point(15, 55);
            this.gbFamilias.Name = "gbFamilias";
            this.gbFamilias.Size = new System.Drawing.Size(714, 239);
            this.gbFamilias.TabIndex = 6;
            this.gbFamilias.TabStop = false;
            this.gbFamilias.Text = "Familias";
            // 
            // DgvFamiliasAsignadas
            // 
            this.DgvFamiliasAsignadas.AllowUserToAddRows = false;
            this.DgvFamiliasAsignadas.AllowUserToDeleteRows = false;
            this.DgvFamiliasAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvFamiliasAsignadas.Location = new System.Drawing.Point(392, 42);
            this.DgvFamiliasAsignadas.Name = "DgvFamiliasAsignadas";
            this.DgvFamiliasAsignadas.Size = new System.Drawing.Size(316, 191);
            this.DgvFamiliasAsignadas.TabIndex = 5;
            // 
            // dvgFamilias
            // 
            this.dvgFamilias.AllowUserToAddRows = false;
            this.dvgFamilias.AllowUserToDeleteRows = false;
            this.dvgFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFamilias.Location = new System.Drawing.Point(6, 42);
            this.dvgFamilias.Name = "dvgFamilias";
            this.dvgFamilias.Size = new System.Drawing.Size(316, 191);
            this.dvgFamilias.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Disponibles";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(389, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Asignadas";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btnAddFamilia
            // 
            this.btnAddFamilia.Image = global::Mcba.UI.Properties.Resources.iconArrowRight;
            this.btnAddFamilia.Location = new System.Drawing.Point(337, 77);
            this.btnAddFamilia.Name = "btnAddFamilia";
            this.btnAddFamilia.Size = new System.Drawing.Size(40, 40);
            this.btnAddFamilia.TabIndex = 8;
            this.btnAddFamilia.UseVisualStyleBackColor = true;
            // 
            // btnRemoveFamilia
            // 
            this.btnRemoveFamilia.Image = global::Mcba.UI.Properties.Resources.iconArrowRedLeft;
            this.btnRemoveFamilia.Location = new System.Drawing.Point(337, 163);
            this.btnRemoveFamilia.Name = "btnRemoveFamilia";
            this.btnRemoveFamilia.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveFamilia.TabIndex = 9;
            this.btnRemoveFamilia.UseVisualStyleBackColor = true;
            // 
            // gbPatentes
            // 
            this.gbPatentes.Controls.Add(this.button1);
            this.gbPatentes.Controls.Add(this.button2);
            this.gbPatentes.Controls.Add(this.label4);
            this.gbPatentes.Controls.Add(this.label5);
            this.gbPatentes.Controls.Add(this.dgvPatentesAsignadas);
            this.gbPatentes.Controls.Add(this.dgvPatentes);
            this.gbPatentes.Location = new System.Drawing.Point(15, 309);
            this.gbPatentes.Name = "gbPatentes";
            this.gbPatentes.Size = new System.Drawing.Size(714, 239);
            this.gbPatentes.TabIndex = 7;
            this.gbPatentes.TabStop = false;
            this.gbPatentes.Text = "Patentes";
            // 
            // button1
            // 
            this.button1.Image = global::Mcba.UI.Properties.Resources.iconArrowRedLeft;
            this.button1.Location = new System.Drawing.Point(337, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Mcba.UI.Properties.Resources.iconArrowRight;
            this.button2.Location = new System.Drawing.Point(337, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(389, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Asignadas";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Disponibles";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvPatentesAsignadas
            // 
            this.dgvPatentesAsignadas.AllowUserToAddRows = false;
            this.dgvPatentesAsignadas.AllowUserToDeleteRows = false;
            this.dgvPatentesAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatentesAsignadas.Location = new System.Drawing.Point(392, 42);
            this.dgvPatentesAsignadas.Name = "dgvPatentesAsignadas";
            this.dgvPatentesAsignadas.Size = new System.Drawing.Size(316, 191);
            this.dgvPatentesAsignadas.TabIndex = 5;
            // 
            // dgvPatentes
            // 
            this.dgvPatentes.AllowUserToAddRows = false;
            this.dgvPatentes.AllowUserToDeleteRows = false;
            this.dgvPatentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatentes.Location = new System.Drawing.Point(6, 42);
            this.dgvPatentes.Name = "dgvPatentes";
            this.dgvPatentes.Size = new System.Drawing.Size(316, 191);
            this.dgvPatentes.TabIndex = 4;
            // 
            // PermisosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 553);
            this.ControlBox = false;
            this.Controls.Add(this.gbPatentes);
            this.Controls.Add(this.gbFamilias);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tsSeguridad);
            this.Name = "PermisosUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Permisos Usuarios";
            this.Load += new System.EventHandler(this.Seguridad_Load);
            this.tsSeguridad.ResumeLayout(false);
            this.tsSeguridad.PerformLayout();
            this.gbFamilias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvFamiliasAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFamilias)).EndInit();
            this.gbPatentes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentesAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSeguridad;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.GroupBox gbFamilias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DgvFamiliasAsignadas;
        private System.Windows.Forms.DataGridView dvgFamilias;
        private System.Windows.Forms.Button btnRemoveFamilia;
        private System.Windows.Forms.Button btnAddFamilia;
        private System.Windows.Forms.GroupBox gbPatentes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPatentesAsignadas;
        private System.Windows.Forms.DataGridView dgvPatentes;
    }
}