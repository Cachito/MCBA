namespace Mcba.UI
{
    partial class PermisosFamilias
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
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.lblFamilia = new System.Windows.Forms.Label();
            this.cmbFamilias = new System.Windows.Forms.ComboBox();
            this.gbPermisos = new System.Windows.Forms.GroupBox();
            this.btnRemoveFamilia = new System.Windows.Forms.Button();
            this.btnAddFamilia = new System.Windows.Forms.Button();
            this.lblAsignadosP = new System.Windows.Forms.Label();
            this.lblDisponiblesP = new System.Windows.Forms.Label();
            this.dgvPermisosAsignados = new System.Windows.Forms.DataGridView();
            this.IdPa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoPermiso = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.IdPd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombrePd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbUsuarios = new System.Windows.Forms.GroupBox();
            this.btnRemoveUsuario = new System.Windows.Forms.Button();
            this.btnAddUsuario = new System.Windows.Forms.Button();
            this.lblAsignadosU = new System.Windows.Forms.Label();
            this.lblDisponiblesU = new System.Windows.Forms.Label();
            this.dgvUsuariosAsignadas = new System.Windows.Forms.DataGridView();
            this.IdUa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.IdUd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreUd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsSeguridad.SuspendLayout();
            this.gbPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
            this.gbUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
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
            // tsbSalir
            // 
            this.tsbSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSalir.Image = global::Mcba.UI.Properties.Resources.iconOut;
            this.tsbSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSalir.Name = "tsbSalir";
            this.tsbSalir.Size = new System.Drawing.Size(23, 22);
            this.tsbSalir.Tag = "tsbSalir";
            this.tsbSalir.Text = "tsbSalir";
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::Mcba.UI.Properties.Resources.iconSave;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Tag = "tsbSave";
            this.tsbSave.Text = "tsbSave";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // lblFamilia
            // 
            this.lblFamilia.Location = new System.Drawing.Point(12, 27);
            this.lblFamilia.Name = "lblFamilia";
            this.lblFamilia.Size = new System.Drawing.Size(51, 23);
            this.lblFamilia.TabIndex = 4;
            this.lblFamilia.Tag = "lblFamilia";
            this.lblFamilia.Text = "lblFamilia";
            this.lblFamilia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbFamilias
            // 
            this.cmbFamilias.FormattingEnabled = true;
            this.cmbFamilias.Location = new System.Drawing.Point(69, 28);
            this.cmbFamilias.Name = "cmbFamilias";
            this.cmbFamilias.Size = new System.Drawing.Size(268, 21);
            this.cmbFamilias.TabIndex = 5;
            this.cmbFamilias.SelectedIndexChanged += new System.EventHandler(this.cmbFamilias_SelectedIndexChanged);
            // 
            // gbPermisos
            // 
            this.gbPermisos.Controls.Add(this.btnRemoveFamilia);
            this.gbPermisos.Controls.Add(this.btnAddFamilia);
            this.gbPermisos.Controls.Add(this.lblAsignadosP);
            this.gbPermisos.Controls.Add(this.lblDisponiblesP);
            this.gbPermisos.Controls.Add(this.dgvPermisosAsignados);
            this.gbPermisos.Controls.Add(this.dgvPermisos);
            this.gbPermisos.Location = new System.Drawing.Point(15, 309);
            this.gbPermisos.Name = "gbPermisos";
            this.gbPermisos.Size = new System.Drawing.Size(714, 239);
            this.gbPermisos.TabIndex = 6;
            this.gbPermisos.TabStop = false;
            this.gbPermisos.Tag = "gbPermisos";
            this.gbPermisos.Text = "gbPermisos";
            // 
            // btnRemoveFamilia
            // 
            this.btnRemoveFamilia.Image = global::Mcba.UI.Properties.Resources.iconArrowRedLeft;
            this.btnRemoveFamilia.Location = new System.Drawing.Point(337, 163);
            this.btnRemoveFamilia.Name = "btnRemoveFamilia";
            this.btnRemoveFamilia.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveFamilia.TabIndex = 9;
            this.btnRemoveFamilia.UseVisualStyleBackColor = true;
            this.btnRemoveFamilia.Click += new System.EventHandler(this.btnRemovePermiso_Click);
            // 
            // btnAddFamilia
            // 
            this.btnAddFamilia.Image = global::Mcba.UI.Properties.Resources.iconArrowRight;
            this.btnAddFamilia.Location = new System.Drawing.Point(337, 77);
            this.btnAddFamilia.Name = "btnAddFamilia";
            this.btnAddFamilia.Size = new System.Drawing.Size(40, 40);
            this.btnAddFamilia.TabIndex = 8;
            this.btnAddFamilia.UseVisualStyleBackColor = true;
            this.btnAddFamilia.Click += new System.EventHandler(this.btnAddPermiso_Click);
            // 
            // lblAsignadosP
            // 
            this.lblAsignadosP.Location = new System.Drawing.Point(392, 16);
            this.lblAsignadosP.Name = "lblAsignadosP";
            this.lblAsignadosP.Size = new System.Drawing.Size(315, 23);
            this.lblAsignadosP.TabIndex = 7;
            this.lblAsignadosP.Tag = "lblAsignadosP";
            this.lblAsignadosP.Text = "lblAsignadosP";
            this.lblAsignadosP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisponiblesP
            // 
            this.lblDisponiblesP.Location = new System.Drawing.Point(6, 16);
            this.lblDisponiblesP.Name = "lblDisponiblesP";
            this.lblDisponiblesP.Size = new System.Drawing.Size(316, 23);
            this.lblDisponiblesP.TabIndex = 6;
            this.lblDisponiblesP.Tag = "lblDisponiblesP";
            this.lblDisponiblesP.Text = "lblDisponiblesP";
            this.lblDisponiblesP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvPermisosAsignados
            // 
            this.dgvPermisosAsignados.AllowUserToAddRows = false;
            this.dgvPermisosAsignados.AllowUserToDeleteRows = false;
            this.dgvPermisosAsignados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPermisosAsignados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisosAsignados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPa,
            this.NombrePa,
            this.TipoPermiso});
            this.dgvPermisosAsignados.Location = new System.Drawing.Point(392, 42);
            this.dgvPermisosAsignados.Name = "dgvPermisosAsignados";
            this.dgvPermisosAsignados.RowHeadersVisible = false;
            this.dgvPermisosAsignados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermisosAsignados.Size = new System.Drawing.Size(316, 191);
            this.dgvPermisosAsignados.TabIndex = 5;
            this.dgvPermisosAsignados.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPermisosAsignados_CellValueChanged);
            this.dgvPermisosAsignados.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvPermisosAsignados_CurrentCellDirtyStateChanged);
            this.dgvPermisosAsignados.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvPermisosAsignados_DataError);
            // 
            // IdPa
            // 
            this.IdPa.HeaderText = "Id";
            this.IdPa.Name = "IdPa";
            this.IdPa.ReadOnly = true;
            this.IdPa.Width = 41;
            // 
            // NombrePa
            // 
            this.NombrePa.HeaderText = "Nombre";
            this.NombrePa.Name = "NombrePa";
            this.NombrePa.ReadOnly = true;
            this.NombrePa.Width = 69;
            // 
            // TipoPermiso
            // 
            this.TipoPermiso.DataPropertyName = "Id";
            this.TipoPermiso.HeaderText = "Tipo de Permiso";
            this.TipoPermiso.Name = "TipoPermiso";
            this.TipoPermiso.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TipoPermiso.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TipoPermiso.Width = 99;
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPd,
            this.NombrePd});
            this.dgvPermisos.Location = new System.Drawing.Point(6, 42);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.RowHeadersVisible = false;
            this.dgvPermisos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPermisos.Size = new System.Drawing.Size(316, 191);
            this.dgvPermisos.TabIndex = 4;
            // 
            // IdPd
            // 
            this.IdPd.HeaderText = "Id";
            this.IdPd.Name = "IdPd";
            this.IdPd.ReadOnly = true;
            this.IdPd.Width = 41;
            // 
            // NombrePd
            // 
            this.NombrePd.HeaderText = "Nombre";
            this.NombrePd.Name = "NombrePd";
            this.NombrePd.ReadOnly = true;
            this.NombrePd.Width = 69;
            // 
            // gbUsuarios
            // 
            this.gbUsuarios.Controls.Add(this.btnRemoveUsuario);
            this.gbUsuarios.Controls.Add(this.btnAddUsuario);
            this.gbUsuarios.Controls.Add(this.lblAsignadosU);
            this.gbUsuarios.Controls.Add(this.lblDisponiblesU);
            this.gbUsuarios.Controls.Add(this.dgvUsuariosAsignadas);
            this.gbUsuarios.Controls.Add(this.dgvUsuarios);
            this.gbUsuarios.Location = new System.Drawing.Point(15, 55);
            this.gbUsuarios.Name = "gbUsuarios";
            this.gbUsuarios.Size = new System.Drawing.Size(714, 239);
            this.gbUsuarios.TabIndex = 7;
            this.gbUsuarios.TabStop = false;
            this.gbUsuarios.Tag = "gbUsuarios";
            this.gbUsuarios.Text = "gbUsuarios";
            // 
            // btnRemoveUsuario
            // 
            this.btnRemoveUsuario.Image = global::Mcba.UI.Properties.Resources.iconArrowRedLeft;
            this.btnRemoveUsuario.Location = new System.Drawing.Point(337, 163);
            this.btnRemoveUsuario.Name = "btnRemoveUsuario";
            this.btnRemoveUsuario.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveUsuario.TabIndex = 9;
            this.btnRemoveUsuario.Tag = "btnRemoveUsuario";
            this.btnRemoveUsuario.UseVisualStyleBackColor = true;
            this.btnRemoveUsuario.Click += new System.EventHandler(this.btnRemoveUsuario_Click);
            // 
            // btnAddUsuario
            // 
            this.btnAddUsuario.Image = global::Mcba.UI.Properties.Resources.iconArrowRight;
            this.btnAddUsuario.Location = new System.Drawing.Point(337, 77);
            this.btnAddUsuario.Name = "btnAddUsuario";
            this.btnAddUsuario.Size = new System.Drawing.Size(40, 40);
            this.btnAddUsuario.TabIndex = 8;
            this.btnAddUsuario.Tag = "btnAddUsuario";
            this.btnAddUsuario.UseVisualStyleBackColor = true;
            this.btnAddUsuario.Click += new System.EventHandler(this.btnAddUsuario_Click);
            // 
            // lblAsignadosU
            // 
            this.lblAsignadosU.Location = new System.Drawing.Point(392, 16);
            this.lblAsignadosU.Name = "lblAsignadosU";
            this.lblAsignadosU.Size = new System.Drawing.Size(315, 23);
            this.lblAsignadosU.TabIndex = 7;
            this.lblAsignadosU.Tag = "lblAsignadosU";
            this.lblAsignadosU.Text = "lblAsignadosU";
            this.lblAsignadosU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisponiblesU
            // 
            this.lblDisponiblesU.Location = new System.Drawing.Point(6, 16);
            this.lblDisponiblesU.Name = "lblDisponiblesU";
            this.lblDisponiblesU.Size = new System.Drawing.Size(316, 23);
            this.lblDisponiblesU.TabIndex = 6;
            this.lblDisponiblesU.Tag = "lblDisponiblesU";
            this.lblDisponiblesU.Text = "lblDisponiblesU";
            this.lblDisponiblesU.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvUsuariosAsignadas
            // 
            this.dgvUsuariosAsignadas.AllowUserToAddRows = false;
            this.dgvUsuariosAsignadas.AllowUserToDeleteRows = false;
            this.dgvUsuariosAsignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuariosAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuariosAsignadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUa,
            this.NombreUa});
            this.dgvUsuariosAsignadas.Location = new System.Drawing.Point(392, 42);
            this.dgvUsuariosAsignadas.Name = "dgvUsuariosAsignadas";
            this.dgvUsuariosAsignadas.RowHeadersVisible = false;
            this.dgvUsuariosAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuariosAsignadas.Size = new System.Drawing.Size(316, 191);
            this.dgvUsuariosAsignadas.TabIndex = 5;
            // 
            // IdUa
            // 
            this.IdUa.HeaderText = "Id";
            this.IdUa.Name = "IdUa";
            this.IdUa.ReadOnly = true;
            this.IdUa.Width = 41;
            // 
            // NombreUa
            // 
            this.NombreUa.HeaderText = "Nombre";
            this.NombreUa.Name = "NombreUa";
            this.NombreUa.ReadOnly = true;
            this.NombreUa.Width = 69;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdUd,
            this.NombreUd});
            this.dgvUsuarios.Location = new System.Drawing.Point(6, 42);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(316, 191);
            this.dgvUsuarios.TabIndex = 4;
            // 
            // IdUd
            // 
            this.IdUd.HeaderText = "Id";
            this.IdUd.Name = "IdUd";
            this.IdUd.ReadOnly = true;
            this.IdUd.Width = 41;
            // 
            // NombreUd
            // 
            this.NombreUd.HeaderText = "Nombre";
            this.NombreUd.Name = "NombreUd";
            this.NombreUd.ReadOnly = true;
            this.NombreUd.Width = 69;
            // 
            // PermisosFamilias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 553);
            this.ControlBox = false;
            this.Controls.Add(this.gbUsuarios);
            this.Controls.Add(this.gbPermisos);
            this.Controls.Add(this.cmbFamilias);
            this.Controls.Add(this.lblFamilia);
            this.Controls.Add(this.tsSeguridad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PermisosFamilias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Permisos Familias";
            this.Load += new System.EventHandler(this.PermisosFamilias_Load);
            this.tsSeguridad.ResumeLayout(false);
            this.tsSeguridad.PerformLayout();
            this.gbPermisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.gbUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSeguridad;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.Label lblFamilia;
        private System.Windows.Forms.ComboBox cmbFamilias;
        private System.Windows.Forms.GroupBox gbPermisos;
        private System.Windows.Forms.Label lblAsignadosP;
        private System.Windows.Forms.Label lblDisponiblesP;
        private System.Windows.Forms.DataGridView dgvPermisosAsignados;
        private System.Windows.Forms.DataGridView dgvPermisos;
        private System.Windows.Forms.Button btnRemoveFamilia;
        private System.Windows.Forms.Button btnAddFamilia;
        private System.Windows.Forms.GroupBox gbUsuarios;
        private System.Windows.Forms.Button btnRemoveUsuario;
        private System.Windows.Forms.Button btnAddUsuario;
        private System.Windows.Forms.Label lblAsignadosU;
        private System.Windows.Forms.Label lblDisponiblesU;
        private System.Windows.Forms.DataGridView dgvUsuariosAsignadas;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPd;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePd;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombrePa;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoPermiso;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdUa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreUa;
    }
}