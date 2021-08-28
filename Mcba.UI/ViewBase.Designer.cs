namespace Mcba.UI
{
    partial class ViewBase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBase));
            this.toolBar = new Mcba.UI.Controls.McbaToolStrip();
            this.tsbSalir = new Mcba.UI.Controls.McbaToolStripButton();
            this.tsbNew = new Mcba.UI.Controls.McbaToolStripButton();
            this.tsbDelete = new Mcba.UI.Controls.McbaToolStripButton();
            this.tsbEdit = new Mcba.UI.Controls.McbaToolStripButton();
            this.tsbSave = new Mcba.UI.Controls.McbaToolStripButton();
            this.tsbFind = new Mcba.UI.Controls.McbaToolStripButton();
            this.tsbPrint = new Mcba.UI.Controls.McbaToolStripButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbNew,
            this.tsbDelete,
            this.tsbEdit,
            this.tsbSave,
            this.tsbFind,
            this.tsbPrint,
            this.toolStripButton1});
            this.toolBar.Location = new System.Drawing.Point(0, 0);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(613, 25);
            this.toolBar.TabIndex = 1;
            this.toolBar.Text = "toolStrip1";
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
            // 
            // tsbFind
            // 
            this.tsbFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFind.Image = global::Mcba.UI.Properties.Resources.IconBuscar;
            this.tsbFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFind.Name = "tsbFind";
            this.tsbFind.Size = new System.Drawing.Size(23, 22);
            this.tsbFind.Tag = "tsbFind";
            this.tsbFind.Text = "Buscar";
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = global::Mcba.UI.Properties.Resources.printerBlack;
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbPrint.Tag = "tsbPrint";
            this.tsbPrint.Text = "tsbPrintImprimir";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.Location = new System.Drawing.Point(0, 150);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(613, 282);
            this.dataGridView.TabIndex = 3;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // ViewBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 432);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.toolBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ViewBase";
            this.Text = "ViewBase";
            this.toolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected Mcba.UI.Controls.McbaToolStrip toolBar;
        protected Mcba.UI.Controls.McbaToolStripButton tsbSalir;
        protected Mcba.UI.Controls.McbaToolStripButton tsbNew;
        protected Mcba.UI.Controls.McbaToolStripButton tsbDelete;
        protected Mcba.UI.Controls.McbaToolStripButton tsbEdit;
        protected Mcba.UI.Controls.McbaToolStripButton tsbSave;
        protected Mcba.UI.Controls.McbaToolStripButton tsbFind;
        protected Mcba.UI.Controls.McbaToolStripButton tsbPrint;
        protected System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}