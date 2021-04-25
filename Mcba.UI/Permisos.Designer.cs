namespace Mcba.UI
{
    partial class Permisos
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
            this.tsPermisos = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.lblObjeto = new System.Windows.Forms.Label();
            this.cmbFamilias = new System.Windows.Forms.ComboBox();
            this.gbSecundaria = new System.Windows.Forms.GroupBox();
            this.btnRemoveFamilia = new System.Windows.Forms.Button();
            this.btnAddFamilia = new System.Windows.Forms.Button();
            this.lblSecundariaAsignadas = new System.Windows.Forms.Label();
            this.lblSecundaria = new System.Windows.Forms.Label();
            this.DgvSecundariaAsignadas = new System.Windows.Forms.DataGridView();
            this.dvgSecundaria = new System.Windows.Forms.DataGridView();
            this.gbPrincipal = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPrincipalAsignadas = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.dgvPrincipalAsignadas = new System.Windows.Forms.DataGridView();
            this.dgvPrincpial = new System.Windows.Forms.DataGridView();
            this.tsPermisos.SuspendLayout();
            this.gbSecundaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSecundariaAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSecundaria)).BeginInit();
            this.gbPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipalAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincpial)).BeginInit();
            this.SuspendLayout();
            // 
            // tsPermisos
            // 
            this.tsPermisos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbSave});
            this.tsPermisos.Location = new System.Drawing.Point(0, 0);
            this.tsPermisos.Name = "tsPermisos";
            this.tsPermisos.Size = new System.Drawing.Size(734, 25);
            this.tsPermisos.TabIndex = 0;
            this.tsPermisos.Text = "toolStrip1";
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
            // lblObjeto
            // 
            this.lblObjeto.Location = new System.Drawing.Point(12, 27);
            this.lblObjeto.Name = "lblObjeto";
            this.lblObjeto.Size = new System.Drawing.Size(51, 23);
            this.lblObjeto.TabIndex = 4;
            this.lblObjeto.Text = "Familia";
            this.lblObjeto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFamilias
            // 
            this.cmbFamilias.FormattingEnabled = true;
            this.cmbFamilias.Location = new System.Drawing.Point(69, 28);
            this.cmbFamilias.Name = "cmbFamilias";
            this.cmbFamilias.Size = new System.Drawing.Size(268, 21);
            this.cmbFamilias.TabIndex = 5;
            // 
            // gbSecundaria
            // 
            this.gbSecundaria.Controls.Add(this.btnRemoveFamilia);
            this.gbSecundaria.Controls.Add(this.btnAddFamilia);
            this.gbSecundaria.Controls.Add(this.lblSecundariaAsignadas);
            this.gbSecundaria.Controls.Add(this.lblSecundaria);
            this.gbSecundaria.Controls.Add(this.DgvSecundariaAsignadas);
            this.gbSecundaria.Controls.Add(this.dvgSecundaria);
            this.gbSecundaria.Location = new System.Drawing.Point(15, 309);
            this.gbSecundaria.Name = "gbSecundaria";
            this.gbSecundaria.Size = new System.Drawing.Size(714, 239);
            this.gbSecundaria.TabIndex = 6;
            this.gbSecundaria.TabStop = false;
            this.gbSecundaria.Text = "Secundaria";
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
            // btnAddFamilia
            // 
            this.btnAddFamilia.Image = global::Mcba.UI.Properties.Resources.iconArrowRight;
            this.btnAddFamilia.Location = new System.Drawing.Point(337, 77);
            this.btnAddFamilia.Name = "btnAddFamilia";
            this.btnAddFamilia.Size = new System.Drawing.Size(40, 40);
            this.btnAddFamilia.TabIndex = 8;
            this.btnAddFamilia.UseVisualStyleBackColor = true;
            // 
            // lblSecundariaAsignadas
            // 
            this.lblSecundariaAsignadas.Location = new System.Drawing.Point(389, 16);
            this.lblSecundariaAsignadas.Name = "lblSecundariaAsignadas";
            this.lblSecundariaAsignadas.Size = new System.Drawing.Size(70, 23);
            this.lblSecundariaAsignadas.TabIndex = 7;
            this.lblSecundariaAsignadas.Text = "Asignadas";
            this.lblSecundariaAsignadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSecundaria
            // 
            this.lblSecundaria.Location = new System.Drawing.Point(6, 16);
            this.lblSecundaria.Name = "lblSecundaria";
            this.lblSecundaria.Size = new System.Drawing.Size(70, 23);
            this.lblSecundaria.TabIndex = 6;
            this.lblSecundaria.Text = "Disponibles";
            this.lblSecundaria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DgvSecundariaAsignadas
            // 
            this.DgvSecundariaAsignadas.AllowUserToAddRows = false;
            this.DgvSecundariaAsignadas.AllowUserToDeleteRows = false;
            this.DgvSecundariaAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSecundariaAsignadas.Location = new System.Drawing.Point(392, 42);
            this.DgvSecundariaAsignadas.Name = "DgvSecundariaAsignadas";
            this.DgvSecundariaAsignadas.Size = new System.Drawing.Size(316, 191);
            this.DgvSecundariaAsignadas.TabIndex = 5;
            // 
            // dvgSecundaria
            // 
            this.dvgSecundaria.AllowUserToAddRows = false;
            this.dvgSecundaria.AllowUserToDeleteRows = false;
            this.dvgSecundaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgSecundaria.Location = new System.Drawing.Point(6, 42);
            this.dvgSecundaria.Name = "dvgSecundaria";
            this.dvgSecundaria.Size = new System.Drawing.Size(316, 191);
            this.dvgSecundaria.TabIndex = 4;
            // 
            // gbPrincipal
            // 
            this.gbPrincipal.Controls.Add(this.button1);
            this.gbPrincipal.Controls.Add(this.button2);
            this.gbPrincipal.Controls.Add(this.lblPrincipalAsignadas);
            this.gbPrincipal.Controls.Add(this.lblPrincipal);
            this.gbPrincipal.Controls.Add(this.dgvPrincipalAsignadas);
            this.gbPrincipal.Controls.Add(this.dgvPrincpial);
            this.gbPrincipal.Location = new System.Drawing.Point(15, 55);
            this.gbPrincipal.Name = "gbPrincipal";
            this.gbPrincipal.Size = new System.Drawing.Size(714, 239);
            this.gbPrincipal.TabIndex = 7;
            this.gbPrincipal.TabStop = false;
            this.gbPrincipal.Text = "Principal";
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
            // lblPrincipalAsignadas
            // 
            this.lblPrincipalAsignadas.Location = new System.Drawing.Point(389, 16);
            this.lblPrincipalAsignadas.Name = "lblPrincipalAsignadas";
            this.lblPrincipalAsignadas.Size = new System.Drawing.Size(70, 23);
            this.lblPrincipalAsignadas.TabIndex = 7;
            this.lblPrincipalAsignadas.Text = "Asignadas";
            this.lblPrincipalAsignadas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.Location = new System.Drawing.Point(6, 16);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(70, 23);
            this.lblPrincipal.TabIndex = 6;
            this.lblPrincipal.Text = "Disponibles";
            this.lblPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvPrincipalAsignadas
            // 
            this.dgvPrincipalAsignadas.AllowUserToAddRows = false;
            this.dgvPrincipalAsignadas.AllowUserToDeleteRows = false;
            this.dgvPrincipalAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincipalAsignadas.Location = new System.Drawing.Point(392, 42);
            this.dgvPrincipalAsignadas.Name = "dgvPrincipalAsignadas";
            this.dgvPrincipalAsignadas.Size = new System.Drawing.Size(316, 191);
            this.dgvPrincipalAsignadas.TabIndex = 5;
            // 
            // dgvPrincpial
            // 
            this.dgvPrincpial.AllowUserToAddRows = false;
            this.dgvPrincpial.AllowUserToDeleteRows = false;
            this.dgvPrincpial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrincpial.Location = new System.Drawing.Point(6, 42);
            this.dgvPrincpial.Name = "dgvPrincpial";
            this.dgvPrincpial.Size = new System.Drawing.Size(316, 191);
            this.dgvPrincpial.TabIndex = 4;
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 553);
            this.ControlBox = false;
            this.Controls.Add(this.gbPrincipal);
            this.Controls.Add(this.gbSecundaria);
            this.Controls.Add(this.cmbFamilias);
            this.Controls.Add(this.lblObjeto);
            this.Controls.Add(this.tsPermisos);
            this.Name = "Permisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Permisos Base";
            this.Load += new System.EventHandler(this.Permisos_Load);
            this.tsPermisos.ResumeLayout(false);
            this.tsPermisos.PerformLayout();
            this.gbSecundaria.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvSecundariaAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgSecundaria)).EndInit();
            this.gbPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincipalAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrincpial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsPermisos;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.Label lblObjeto;
        private System.Windows.Forms.ComboBox cmbFamilias;
        private System.Windows.Forms.GroupBox gbSecundaria;
        private System.Windows.Forms.Label lblSecundariaAsignadas;
        private System.Windows.Forms.Label lblSecundaria;
        private System.Windows.Forms.DataGridView DgvSecundariaAsignadas;
        private System.Windows.Forms.DataGridView dvgSecundaria;
        private System.Windows.Forms.Button btnRemoveFamilia;
        private System.Windows.Forms.Button btnAddFamilia;
        private System.Windows.Forms.GroupBox gbPrincipal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPrincipalAsignadas;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.DataGridView dgvPrincipalAsignadas;
        private System.Windows.Forms.DataGridView dgvPrincpial;
    }
}