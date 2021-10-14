﻿namespace Mcba.UI
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
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.gbFamilias = new System.Windows.Forms.GroupBox();
            this.btnRemoveFamilia = new System.Windows.Forms.Button();
            this.btnAddFamilia = new System.Windows.Forms.Button();
            this.lblAsignadasF = new System.Windows.Forms.Label();
            this.lblDisponiblesF = new System.Windows.Forms.Label();
            this.dgvFamiliasAsignadas = new System.Windows.Forms.DataGridView();
            this.dgvFamilias = new System.Windows.Forms.DataGridView();
            this.gbPermisos = new System.Windows.Forms.GroupBox();
            this.btnRemovePermiso = new System.Windows.Forms.Button();
            this.btnAddPermiso = new System.Windows.Forms.Button();
            this.lblAsignadasP = new System.Windows.Forms.Label();
            this.lblDisponiblesP = new System.Windows.Forms.Label();
            this.dgvPermisosAsignados = new System.Windows.Forms.DataGridView();
            this.dgvPermisos = new System.Windows.Forms.DataGridView();
            this.tsSeguridad.SuspendLayout();
            this.gbFamilias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliasAsignadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).BeginInit();
            this.gbPermisos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).BeginInit();
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
            // lblUsuario
            // 
            this.lblUsuario.Location = new System.Drawing.Point(12, 27);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(62, 23);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Tag = "lblUsuario";
            this.lblUsuario.Text = "lblUsuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(80, 28);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(268, 21);
            this.cmbUsuarios.TabIndex = 5;
            this.cmbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarios_SelectedIndexChanged);
            // 
            // gbFamilias
            // 
            this.gbFamilias.Controls.Add(this.btnRemoveFamilia);
            this.gbFamilias.Controls.Add(this.btnAddFamilia);
            this.gbFamilias.Controls.Add(this.lblAsignadasF);
            this.gbFamilias.Controls.Add(this.lblDisponiblesF);
            this.gbFamilias.Controls.Add(this.dgvFamiliasAsignadas);
            this.gbFamilias.Controls.Add(this.dgvFamilias);
            this.gbFamilias.Location = new System.Drawing.Point(15, 55);
            this.gbFamilias.Name = "gbFamilias";
            this.gbFamilias.Size = new System.Drawing.Size(714, 239);
            this.gbFamilias.TabIndex = 6;
            this.gbFamilias.TabStop = false;
            this.gbFamilias.Tag = "gbFamilias";
            this.gbFamilias.Text = "gbFamilias";
            // 
            // btnRemoveFamilia
            // 
            this.btnRemoveFamilia.Image = global::Mcba.UI.Properties.Resources.iconArrowRedLeft;
            this.btnRemoveFamilia.Location = new System.Drawing.Point(337, 163);
            this.btnRemoveFamilia.Name = "btnRemoveFamilia";
            this.btnRemoveFamilia.Size = new System.Drawing.Size(40, 40);
            this.btnRemoveFamilia.TabIndex = 9;
            this.btnRemoveFamilia.Tag = "btnRemoveFamilia";
            this.btnRemoveFamilia.UseVisualStyleBackColor = true;
            // 
            // btnAddFamilia
            // 
            this.btnAddFamilia.Image = global::Mcba.UI.Properties.Resources.iconArrowRight;
            this.btnAddFamilia.Location = new System.Drawing.Point(337, 77);
            this.btnAddFamilia.Name = "btnAddFamilia";
            this.btnAddFamilia.Size = new System.Drawing.Size(40, 40);
            this.btnAddFamilia.TabIndex = 8;
            this.btnAddFamilia.Tag = "btnAddFamilia";
            this.btnAddFamilia.UseVisualStyleBackColor = true;
            // 
            // lblAsignadasF
            // 
            this.lblAsignadasF.Location = new System.Drawing.Point(389, 16);
            this.lblAsignadasF.Name = "lblAsignadasF";
            this.lblAsignadasF.Size = new System.Drawing.Size(318, 23);
            this.lblAsignadasF.TabIndex = 7;
            this.lblAsignadasF.Tag = "lblAsignadasF";
            this.lblAsignadasF.Text = "lblAsignadasF";
            this.lblAsignadasF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDisponiblesF
            // 
            this.lblDisponiblesF.Location = new System.Drawing.Point(6, 16);
            this.lblDisponiblesF.Name = "lblDisponiblesF";
            this.lblDisponiblesF.Size = new System.Drawing.Size(316, 23);
            this.lblDisponiblesF.TabIndex = 6;
            this.lblDisponiblesF.Tag = "lblDisponiblesF";
            this.lblDisponiblesF.Text = "lblDisponiblesF";
            this.lblDisponiblesF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvFamiliasAsignadas
            // 
            this.dgvFamiliasAsignadas.AllowUserToAddRows = false;
            this.dgvFamiliasAsignadas.AllowUserToDeleteRows = false;
            this.dgvFamiliasAsignadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFamiliasAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamiliasAsignadas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFamiliasAsignadas.Location = new System.Drawing.Point(392, 42);
            this.dgvFamiliasAsignadas.Name = "dgvFamiliasAsignadas";
            this.dgvFamiliasAsignadas.Size = new System.Drawing.Size(316, 191);
            this.dgvFamiliasAsignadas.TabIndex = 5;
            // 
            // dgvFamilias
            // 
            this.dgvFamilias.AllowUserToAddRows = false;
            this.dgvFamilias.AllowUserToDeleteRows = false;
            this.dgvFamilias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvFamilias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamilias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFamilias.Location = new System.Drawing.Point(6, 42);
            this.dgvFamilias.Name = "dgvFamilias";
            this.dgvFamilias.Size = new System.Drawing.Size(316, 191);
            this.dgvFamilias.TabIndex = 4;
            // 
            // gbPermisos
            // 
            this.gbPermisos.Controls.Add(this.btnRemovePermiso);
            this.gbPermisos.Controls.Add(this.btnAddPermiso);
            this.gbPermisos.Controls.Add(this.lblAsignadasP);
            this.gbPermisos.Controls.Add(this.lblDisponiblesP);
            this.gbPermisos.Controls.Add(this.dgvPermisosAsignados);
            this.gbPermisos.Controls.Add(this.dgvPermisos);
            this.gbPermisos.Location = new System.Drawing.Point(15, 309);
            this.gbPermisos.Name = "gbPermisos";
            this.gbPermisos.Size = new System.Drawing.Size(714, 239);
            this.gbPermisos.TabIndex = 7;
            this.gbPermisos.TabStop = false;
            this.gbPermisos.Tag = "gbPermisos";
            this.gbPermisos.Text = "gbPermisos";
            // 
            // btnRemovePermiso
            // 
            this.btnRemovePermiso.Image = global::Mcba.UI.Properties.Resources.iconArrowRedLeft;
            this.btnRemovePermiso.Location = new System.Drawing.Point(337, 163);
            this.btnRemovePermiso.Name = "btnRemovePermiso";
            this.btnRemovePermiso.Size = new System.Drawing.Size(40, 40);
            this.btnRemovePermiso.TabIndex = 9;
            this.btnRemovePermiso.Tag = "btnRemovePermiso";
            this.btnRemovePermiso.UseVisualStyleBackColor = true;
            // 
            // btnAddPermiso
            // 
            this.btnAddPermiso.Image = global::Mcba.UI.Properties.Resources.iconArrowRight;
            this.btnAddPermiso.Location = new System.Drawing.Point(337, 77);
            this.btnAddPermiso.Name = "btnAddPermiso";
            this.btnAddPermiso.Size = new System.Drawing.Size(40, 40);
            this.btnAddPermiso.TabIndex = 8;
            this.btnAddPermiso.Tag = "btnAddPermiso";
            this.btnAddPermiso.UseVisualStyleBackColor = true;
            // 
            // lblAsignadasP
            // 
            this.lblAsignadasP.Location = new System.Drawing.Point(389, 16);
            this.lblAsignadasP.Name = "lblAsignadasP";
            this.lblAsignadasP.Size = new System.Drawing.Size(318, 23);
            this.lblAsignadasP.TabIndex = 7;
            this.lblAsignadasP.Tag = "lblAsignadasP";
            this.lblAsignadasP.Text = "lblAsignadasP";
            this.lblAsignadasP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.dgvPermisosAsignados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPermisosAsignados.Location = new System.Drawing.Point(392, 42);
            this.dgvPermisosAsignados.Name = "dgvPermisosAsignados";
            this.dgvPermisosAsignados.Size = new System.Drawing.Size(316, 191);
            this.dgvPermisosAsignados.TabIndex = 5;
            // 
            // dgvPermisos
            // 
            this.dgvPermisos.AllowUserToAddRows = false;
            this.dgvPermisos.AllowUserToDeleteRows = false;
            this.dgvPermisos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPermisos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPermisos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPermisos.Location = new System.Drawing.Point(6, 42);
            this.dgvPermisos.Name = "dgvPermisos";
            this.dgvPermisos.Size = new System.Drawing.Size(316, 191);
            this.dgvPermisos.TabIndex = 4;
            // 
            // PermisosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 553);
            this.ControlBox = false;
            this.Controls.Add(this.gbPermisos);
            this.Controls.Add(this.gbFamilias);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.tsSeguridad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PermisosUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Permisos Usuarios";
            this.Load += new System.EventHandler(this.PermisosUsuarios_Load);
            this.tsSeguridad.ResumeLayout(false);
            this.tsSeguridad.PerformLayout();
            this.gbFamilias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamiliasAsignadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamilias)).EndInit();
            this.gbPermisos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPermisos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsSeguridad;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.GroupBox gbFamilias;
        private System.Windows.Forms.Label lblAsignadasF;
        private System.Windows.Forms.Label lblDisponiblesF;
        private System.Windows.Forms.DataGridView dgvFamiliasAsignadas;
        private System.Windows.Forms.DataGridView dgvFamilias;
        private System.Windows.Forms.Button btnRemoveFamilia;
        private System.Windows.Forms.Button btnAddFamilia;
        private System.Windows.Forms.GroupBox gbPermisos;
        private System.Windows.Forms.Button btnRemovePermiso;
        private System.Windows.Forms.Button btnAddPermiso;
        private System.Windows.Forms.Label lblAsignadasP;
        private System.Windows.Forms.Label lblDisponiblesP;
        private System.Windows.Forms.DataGridView dgvPermisosAsignados;
        private System.Windows.Forms.DataGridView dgvPermisos;
    }
}