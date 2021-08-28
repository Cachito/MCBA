namespace Mcba.UI
{
    partial class FacturasItems
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
            this.tsFacturasItems = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbOk = new System.Windows.Forms.ToolStripButton();
            this.txtComision = new System.Windows.Forms.TextBox();
            this.lblUnitario = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblLote = new System.Windows.Forms.Label();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.tsFacturasItems.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsFacturasItems
            // 
            this.tsFacturasItems.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSalir,
            this.tsbOk});
            this.tsFacturasItems.Location = new System.Drawing.Point(0, 0);
            this.tsFacturasItems.Name = "tsFacturasItems";
            this.tsFacturasItems.Size = new System.Drawing.Size(274, 25);
            this.tsFacturasItems.TabIndex = 0;
            this.tsFacturasItems.Text = "toolStrip1";
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
            this.tsbSalir.Click += new System.EventHandler(this.tsbSalir_Click);
            // 
            // tsbOk
            // 
            this.tsbOk.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOk.Image = global::Mcba.UI.Properties.Resources.tick_sign_32;
            this.tsbOk.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOk.Name = "tsbOk";
            this.tsbOk.Size = new System.Drawing.Size(23, 22);
            this.tsbOk.Tag = "tsbOk";
            this.tsbOk.Text = "Ok";
            this.tsbOk.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // txtComision
            // 
            this.txtComision.Location = new System.Drawing.Point(85, 216);
            this.txtComision.Name = "txtComision";
            this.txtComision.Size = new System.Drawing.Size(177, 20);
            this.txtComision.TabIndex = 15;
            // 
            // lblUnitario
            // 
            this.lblUnitario.Location = new System.Drawing.Point(9, 216);
            this.lblUnitario.Name = "lblUnitario";
            this.lblUnitario.Size = new System.Drawing.Size(70, 20);
            this.lblUnitario.TabIndex = 14;
            this.lblUnitario.Tag = "lblUnitario";
            this.lblUnitario.Text = "Unitario";
            this.lblUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(85, 182);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(177, 20);
            this.txtCantidad.TabIndex = 13;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Location = new System.Drawing.Point(9, 182);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(70, 20);
            this.lblCantidad.TabIndex = 12;
            this.lblCantidad.Tag = "lblCantidad";
            this.lblCantidad.Text = "Cantidad";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Location = new System.Drawing.Point(85, 76);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.ReadOnly = true;
            this.txtDescripcion.Size = new System.Drawing.Size(177, 57);
            this.txtDescripcion.TabIndex = 11;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.Location = new System.Drawing.Point(9, 76);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(70, 20);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Tag = "lblDescripcion";
            this.lblDescripcion.Text = "Descripción";
            this.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLote
            // 
            this.lblLote.Location = new System.Drawing.Point(9, 42);
            this.lblLote.Name = "lblLote";
            this.lblLote.Size = new System.Drawing.Size(70, 20);
            this.lblLote.TabIndex = 8;
            this.lblLote.Tag = "lblLote";
            this.lblLote.Text = "Lote";
            this.lblLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(85, 42);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(177, 20);
            this.txtLote.TabIndex = 16;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(85, 250);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(177, 20);
            this.txtTotal.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(9, 250);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 20);
            this.lblTotal.TabIndex = 17;
            this.lblTotal.Tag = "lblTotal";
            this.lblTotal.Text = "Total";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Enabled = false;
            this.txtUnidad.Location = new System.Drawing.Point(85, 148);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.ReadOnly = true;
            this.txtUnidad.Size = new System.Drawing.Size(177, 20);
            this.txtUnidad.TabIndex = 20;
            // 
            // lblUnidad
            // 
            this.lblUnidad.Location = new System.Drawing.Point(9, 148);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(70, 20);
            this.lblUnidad.TabIndex = 19;
            this.lblUnidad.Tag = "lblUnidad";
            this.lblUnidad.Text = "Unidad";
            this.lblUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FacturasItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 282);
            this.ControlBox = false;
            this.Controls.Add(this.txtUnidad);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtLote);
            this.Controls.Add(this.txtComision);
            this.Controls.Add(this.lblUnitario);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblLote);
            this.Controls.Add(this.tsFacturasItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FacturasItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ítem";
            this.Load += new System.EventHandler(this.FacturasItems_Load);
            this.tsFacturasItems.ResumeLayout(false);
            this.tsFacturasItems.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsFacturasItems;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbOk;
        private System.Windows.Forms.TextBox txtComision;
        private System.Windows.Forms.Label lblUnitario;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblLote;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.Label lblUnidad;
    }
}