namespace Mcba.UI
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiMaestros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCondicionesIva = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProvincias = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLocalidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBancos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTiposCuenta = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUnidades = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArchivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemitentes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVehiculos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChoferes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMovimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiStock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLiquidaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGestion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBitacora = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCambioContra = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiMaestros,
            this.tsmiArchivo,
            this.tsmiMovimientos,
            this.tsmiGestion,
            this.tsmiSalir});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // tsmiMaestros
            // 
            this.tsmiMaestros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiCondicionesIva,
            this.tsmiProvincias,
            this.tsmiLocalidades,
            this.tsmiBancos,
            this.tsmiTiposCuenta,
            this.tsmiUnidades});
            this.tsmiMaestros.Name = "tsmiMaestros";
            this.tsmiMaestros.Size = new System.Drawing.Size(67, 20);
            this.tsmiMaestros.Tag = "tsmiMaestros";
            this.tsmiMaestros.Text = "Maestros";
            // 
            // tsmiCondicionesIva
            // 
            this.tsmiCondicionesIva.Name = "tsmiCondicionesIva";
            this.tsmiCondicionesIva.Size = new System.Drawing.Size(207, 22);
            this.tsmiCondicionesIva.Tag = "tsmiCondicionesIva";
            this.tsmiCondicionesIva.Text = "Condiciones de IVA";
            this.tsmiCondicionesIva.Click += new System.EventHandler(this.tsmiCondicionesIva_Click);
            // 
            // tsmiProvincias
            // 
            this.tsmiProvincias.Name = "tsmiProvincias";
            this.tsmiProvincias.Size = new System.Drawing.Size(207, 22);
            this.tsmiProvincias.Tag = "tsmiProvincias";
            this.tsmiProvincias.Text = "Provincias";
            this.tsmiProvincias.Click += new System.EventHandler(this.tsmiProvincias_Click);
            // 
            // tsmiLocalidades
            // 
            this.tsmiLocalidades.Name = "tsmiLocalidades";
            this.tsmiLocalidades.Size = new System.Drawing.Size(207, 22);
            this.tsmiLocalidades.Tag = "tsmiLocalidades";
            this.tsmiLocalidades.Text = "Localidades";
            this.tsmiLocalidades.Click += new System.EventHandler(this.tsmiLocalidades_Click);
            // 
            // tsmiBancos
            // 
            this.tsmiBancos.Name = "tsmiBancos";
            this.tsmiBancos.Size = new System.Drawing.Size(207, 22);
            this.tsmiBancos.Tag = "tsmiBancos";
            this.tsmiBancos.Text = "Bancos";
            this.tsmiBancos.Click += new System.EventHandler(this.tsmiBancos_Click);
            // 
            // tsmiTiposCuenta
            // 
            this.tsmiTiposCuenta.Name = "tsmiTiposCuenta";
            this.tsmiTiposCuenta.Size = new System.Drawing.Size(207, 22);
            this.tsmiTiposCuenta.Tag = "tsmiTiposCuenta";
            this.tsmiTiposCuenta.Text = "Tipos de Cuenta Bancaria";
            this.tsmiTiposCuenta.Click += new System.EventHandler(this.tsmiTiposCuenta_Click);
            // 
            // tsmiUnidades
            // 
            this.tsmiUnidades.Name = "tsmiUnidades";
            this.tsmiUnidades.Size = new System.Drawing.Size(207, 22);
            this.tsmiUnidades.Tag = "tsmiUnidades";
            this.tsmiUnidades.Text = "Unidades";
            this.tsmiUnidades.Click += new System.EventHandler(this.tsmiUnidades_Click);
            // 
            // tsmiArchivo
            // 
            this.tsmiArchivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRemitentes,
            this.tsmiVehiculos,
            this.tsmiChoferes,
            this.tsmiProductos,
            this.tsmiClientes});
            this.tsmiArchivo.Name = "tsmiArchivo";
            this.tsmiArchivo.Size = new System.Drawing.Size(60, 20);
            this.tsmiArchivo.Tag = "tsmiArchivo";
            this.tsmiArchivo.Text = "Archivo";
            // 
            // tsmiRemitentes
            // 
            this.tsmiRemitentes.Name = "tsmiRemitentes";
            this.tsmiRemitentes.Size = new System.Drawing.Size(180, 22);
            this.tsmiRemitentes.Tag = "tsmiRemitentes";
            this.tsmiRemitentes.Text = "Remitentes";
            this.tsmiRemitentes.Click += new System.EventHandler(this.tsmiRemitentes_Click);
            // 
            // tsmiVehiculos
            // 
            this.tsmiVehiculos.Name = "tsmiVehiculos";
            this.tsmiVehiculos.Size = new System.Drawing.Size(180, 22);
            this.tsmiVehiculos.Tag = "tsmiVehiculos";
            this.tsmiVehiculos.Text = "Vehículos";
            this.tsmiVehiculos.Click += new System.EventHandler(this.tsmiVehiculos_Click);
            // 
            // tsmiChoferes
            // 
            this.tsmiChoferes.Name = "tsmiChoferes";
            this.tsmiChoferes.Size = new System.Drawing.Size(180, 22);
            this.tsmiChoferes.Tag = "tsmiChoferes";
            this.tsmiChoferes.Text = "Choferes";
            this.tsmiChoferes.Click += new System.EventHandler(this.tsmiChoferes_Click);
            // 
            // tsmiProductos
            // 
            this.tsmiProductos.Name = "tsmiProductos";
            this.tsmiProductos.Size = new System.Drawing.Size(180, 22);
            this.tsmiProductos.Tag = "tsmiProductos";
            this.tsmiProductos.Text = "Productos";
            this.tsmiProductos.Click += new System.EventHandler(this.tsmiProductos_Click);
            // 
            // tsmiClientes
            // 
            this.tsmiClientes.Name = "tsmiClientes";
            this.tsmiClientes.Size = new System.Drawing.Size(180, 22);
            this.tsmiClientes.Tag = "tsmiClientes";
            this.tsmiClientes.Text = "Clientes";
            this.tsmiClientes.Click += new System.EventHandler(this.tsmiClientes_Click);
            // 
            // tsmiMovimientos
            // 
            this.tsmiMovimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiStock,
            this.tsmiVentas,
            this.tsmiLiquidaciones});
            this.tsmiMovimientos.Name = "tsmiMovimientos";
            this.tsmiMovimientos.Size = new System.Drawing.Size(89, 20);
            this.tsmiMovimientos.Tag = "tsmiMovimientos";
            this.tsmiMovimientos.Text = "Movimientos";
            // 
            // tsmiStock
            // 
            this.tsmiStock.Name = "tsmiStock";
            this.tsmiStock.Size = new System.Drawing.Size(180, 22);
            this.tsmiStock.Tag = "tsmiStock";
            this.tsmiStock.Text = "Stock";
            this.tsmiStock.Click += new System.EventHandler(this.tsmiStock_Click);
            // 
            // tsmiVentas
            // 
            this.tsmiVentas.Name = "tsmiVentas";
            this.tsmiVentas.Size = new System.Drawing.Size(180, 22);
            this.tsmiVentas.Tag = "tsmiVentas";
            this.tsmiVentas.Text = "Ventas";
            this.tsmiVentas.Click += new System.EventHandler(this.tsmiVentas_Click);
            // 
            // tsmiLiquidaciones
            // 
            this.tsmiLiquidaciones.Name = "tsmiLiquidaciones";
            this.tsmiLiquidaciones.Size = new System.Drawing.Size(180, 22);
            this.tsmiLiquidaciones.Tag = "tsmiLiquidaciones";
            this.tsmiLiquidaciones.Text = "Liquidaciones";
            this.tsmiLiquidaciones.Click += new System.EventHandler(this.tsmiLiquidaciones_Click);
            // 
            // tsmiGestion
            // 
            this.tsmiGestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsuarios,
            this.tsmiPermisos,
            this.tsmiBackup,
            this.tsmiBitacora,
            this.tsmiCambioContra});
            this.tsmiGestion.Name = "tsmiGestion";
            this.tsmiGestion.Size = new System.Drawing.Size(59, 20);
            this.tsmiGestion.Tag = "tsmiGestion";
            this.tsmiGestion.Text = "Gestión";
            // 
            // tsmiUsuarios
            // 
            this.tsmiUsuarios.Name = "tsmiUsuarios";
            this.tsmiUsuarios.Size = new System.Drawing.Size(195, 22);
            this.tsmiUsuarios.Tag = "tsmiUsuarios";
            this.tsmiUsuarios.Text = "Usuarios";
            this.tsmiUsuarios.Click += new System.EventHandler(this.tsmiUsuarios_Click);
            // 
            // tsmiPermisos
            // 
            this.tsmiPermisos.Name = "tsmiPermisos";
            this.tsmiPermisos.Size = new System.Drawing.Size(195, 22);
            this.tsmiPermisos.Tag = "tsmiPermisos";
            this.tsmiPermisos.Text = "Permisos";
            this.tsmiPermisos.Click += new System.EventHandler(this.tsmiPermisos_Click);
            // 
            // tsmiBackup
            // 
            this.tsmiBackup.Name = "tsmiBackup";
            this.tsmiBackup.Size = new System.Drawing.Size(195, 22);
            this.tsmiBackup.Tag = "tsmiBackup";
            this.tsmiBackup.Text = "Backup";
            this.tsmiBackup.Click += new System.EventHandler(this.tsmiBackup_Click);
            // 
            // tsmiBitacora
            // 
            this.tsmiBitacora.Name = "tsmiBitacora";
            this.tsmiBitacora.Size = new System.Drawing.Size(195, 22);
            this.tsmiBitacora.Tag = "tsmiBitacora";
            this.tsmiBitacora.Text = "Bitácora";
            this.tsmiBitacora.Click += new System.EventHandler(this.tsmiBitacora_Click);
            // 
            // tsmiCambioContra
            // 
            this.tsmiCambioContra.Name = "tsmiCambioContra";
            this.tsmiCambioContra.Size = new System.Drawing.Size(195, 22);
            this.tsmiCambioContra.Tag = "tsmiCambioContra";
            this.tsmiCambioContra.Text = "Cambio de Contraseña";
            this.tsmiCambioContra.Click += new System.EventHandler(this.tsmiCambioContra_Click);
            // 
            // tsmiSalir
            // 
            this.tsmiSalir.Name = "tsmiSalir";
            this.tsmiSalir.Size = new System.Drawing.Size(41, 20);
            this.tsmiSalir.Tag = "tsmiSalir";
            this.tsmiSalir.Text = "Salir";
            this.tsmiSalir.Click += new System.EventHandler(this.tsmiSalir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Boungiorno SA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiVehiculos;
        private System.Windows.Forms.ToolStripMenuItem tsmiChoferes;
        private System.Windows.Forms.ToolStripMenuItem tsmiMaestros;
        private System.Windows.Forms.ToolStripMenuItem tsmiCondicionesIva;
        private System.Windows.Forms.ToolStripMenuItem tsmiProvincias;
        private System.Windows.Forms.ToolStripMenuItem tsmiLocalidades;
        private System.Windows.Forms.ToolStripMenuItem tsmiBancos;
        private System.Windows.Forms.ToolStripMenuItem tsmiTiposCuenta;
        private System.Windows.Forms.ToolStripMenuItem tsmiUnidades;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemitentes;
        private System.Windows.Forms.ToolStripMenuItem tsmiProductos;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientes;
        private System.Windows.Forms.ToolStripMenuItem tsmiMovimientos;
        private System.Windows.Forms.ToolStripMenuItem tsmiStock;
        private System.Windows.Forms.ToolStripMenuItem tsmiVentas;
        private System.Windows.Forms.ToolStripMenuItem tsmiLiquidaciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiGestion;
        private System.Windows.Forms.ToolStripMenuItem tsmiUsuarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiPermisos;
        private System.Windows.Forms.ToolStripMenuItem tsmiBackup;
        private System.Windows.Forms.ToolStripMenuItem tsmiBitacora;
        private System.Windows.Forms.ToolStripMenuItem tsmiCambioContra;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalir;
    }
}