namespace Mcba.UI
{
    partial class CambioPassword
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
            this.tsCambioPassword = new System.Windows.Forms.ToolStrip();
            this.tsbSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.txtRepiteNueva = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNueva = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tsbRestaurar = new System.Windows.Forms.ToolStripButton();
            this.tsCambioPassword.SuspendLayout();
            this.gbData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsCambioPassword
            // 
            this.tsCambioPassword.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbSalir,
                this.tsbSave,
                this.tsbRestaurar
            });
            this.tsCambioPassword.Location = new System.Drawing.Point(0, 0);
            this.tsCambioPassword.Name = "tsCambioPassword";
            this.tsCambioPassword.Size = new System.Drawing.Size(358, 25);
            this.tsCambioPassword.TabIndex = 0;
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
            // gbData
            // 
            this.gbData.Controls.Add(this.txtRepiteNueva);
            this.gbData.Controls.Add(this.label4);
            this.gbData.Controls.Add(this.txtNueva);
            this.gbData.Controls.Add(this.label3);
            this.gbData.Controls.Add(this.txtActual);
            this.gbData.Controls.Add(this.label2);
            this.gbData.Controls.Add(this.txtUsuario);
            this.gbData.Controls.Add(this.label1);
            this.gbData.Location = new System.Drawing.Point(12, 28);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(335, 157);
            this.gbData.TabIndex = 1;
            this.gbData.TabStop = false;
            // 
            // txtRepiteNueva
            // 
            this.txtRepiteNueva.Location = new System.Drawing.Point(151, 122);
            this.txtRepiteNueva.MaxLength = 12;
            this.txtRepiteNueva.Name = "txtRepiteNueva";
            this.txtRepiteNueva.PasswordChar = '*';
            this.txtRepiteNueva.Size = new System.Drawing.Size(168, 20);
            this.txtRepiteNueva.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Repetir Contraseña Nueva";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNueva
            // 
            this.txtNueva.Location = new System.Drawing.Point(151, 86);
            this.txtNueva.MaxLength = 12;
            this.txtNueva.Name = "txtNueva";
            this.txtNueva.PasswordChar = '*';
            this.txtNueva.Size = new System.Drawing.Size(168, 20);
            this.txtNueva.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña Nueva";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtActual
            // 
            this.txtActual.Location = new System.Drawing.Point(151, 50);
            this.txtActual.MaxLength = 12;
            this.txtActual.Name = "txtActual";
            this.txtActual.PasswordChar = '*';
            this.txtActual.Size = new System.Drawing.Size(168, 20);
            this.txtActual.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña Actual";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(151, 14);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(168, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbRestaurar
            // 
            this.tsbRestaurar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRestaurar.Image = global::Mcba.UI.Properties.Resources.Restore_Password_48;
            this.tsbRestaurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRestaurar.Name = "tsbRestaurar";
            this.tsbRestaurar.Size = new System.Drawing.Size(23, 22);
            this.tsbRestaurar.Text = "Restaurar";
            this.tsbRestaurar.Click += new System.EventHandler(this.tsbRestaurar_Click);
            // 
            // CambioPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 192);
            this.ControlBox = false;
            this.Controls.Add(this.gbData);
            this.Controls.Add(this.tsCambioPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CambioPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CambioPassword";
            this.Load += new System.EventHandler(this.CambioPassword_Load);
            this.tsCambioPassword.ResumeLayout(false);
            this.tsCambioPassword.PerformLayout();
            this.gbData.ResumeLayout(false);
            this.gbData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCambioPassword;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripButton tsbSalir;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.TextBox txtRepiteNueva;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNueva;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripButton tsbRestaurar;
    }
}