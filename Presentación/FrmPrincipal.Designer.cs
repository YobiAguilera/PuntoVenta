namespace Presentación
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.tmTiempo = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestiónDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónDeComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesDeVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmTiempo
            // 
            this.tmTiempo.Enabled = true;
            this.tmTiempo.Tick += new System.EventHandler(this.tmTiempo_Tick);
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(347, 173);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(210, 50);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "5:39:00 p.m.";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblFecha.Location = new System.Drawing.Point(226, 250);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(452, 40);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "sábado, 04 de noviembre de 2023";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PapayaWhip;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónDeProductosToolStripMenuItem,
            this.gestiónDeProveedoresToolStripMenuItem,
            this.gestiónDeClientesToolStripMenuItem,
            this.gestiónDeComprasToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(916, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestiónDeProductosToolStripMenuItem
            // 
            this.gestiónDeProductosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem});
            this.gestiónDeProductosToolStripMenuItem.Image = global::Presentación.Properties.Resources.caja;
            this.gestiónDeProductosToolStripMenuItem.Name = "gestiónDeProductosToolStripMenuItem";
            this.gestiónDeProductosToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.gestiónDeProductosToolStripMenuItem.Text = "Gestión de productos";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::Presentación.Properties.Resources.terminado;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(130, 30);
            this.productosToolStripMenuItem.Text = "Catálogo";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // gestiónDeProveedoresToolStripMenuItem
            // 
            this.gestiónDeProveedoresToolStripMenuItem.Image = global::Presentación.Properties.Resources.proveedor;
            this.gestiónDeProveedoresToolStripMenuItem.Name = "gestiónDeProveedoresToolStripMenuItem";
            this.gestiónDeProveedoresToolStripMenuItem.Size = new System.Drawing.Size(167, 28);
            this.gestiónDeProveedoresToolStripMenuItem.Text = "Gestión de proveedores";
            // 
            // gestiónDeClientesToolStripMenuItem
            // 
            this.gestiónDeClientesToolStripMenuItem.Image = global::Presentación.Properties.Resources.trabajo_en_equipo;
            this.gestiónDeClientesToolStripMenuItem.Name = "gestiónDeClientesToolStripMenuItem";
            this.gestiónDeClientesToolStripMenuItem.Size = new System.Drawing.Size(142, 28);
            this.gestiónDeClientesToolStripMenuItem.Text = "Gestión de clientes";
            // 
            // gestiónDeComprasToolStripMenuItem
            // 
            this.gestiónDeComprasToolStripMenuItem.Image = global::Presentación.Properties.Resources.lista_de_la_compra;
            this.gestiónDeComprasToolStripMenuItem.Name = "gestiónDeComprasToolStripMenuItem";
            this.gestiónDeComprasToolStripMenuItem.Size = new System.Drawing.Size(148, 28);
            this.gestiónDeComprasToolStripMenuItem.Text = "Gestión de compras";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inventarioToolStripMenuItem1});
            this.inventarioToolStripMenuItem.Image = global::Presentación.Properties.Resources.inventario;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(96, 28);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Image = global::Presentación.Properties.Resources.controlar;
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(135, 30);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            this.inventarioToolStripMenuItem1.Click += new System.EventHandler(this.inventarioToolStripMenuItem1_Click);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesDeVentaToolStripMenuItem});
            this.ventasToolStripMenuItem.Image = global::Presentación.Properties.Resources.bienes;
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(77, 28);
            this.ventasToolStripMenuItem.Text = "Ventas";
            // 
            // reportesDeVentaToolStripMenuItem
            // 
            this.reportesDeVentaToolStripMenuItem.Image = global::Presentación.Properties.Resources.analitica;
            this.reportesDeVentaToolStripMenuItem.Name = "reportesDeVentaToolStripMenuItem";
            this.reportesDeVentaToolStripMenuItem.Size = new System.Drawing.Size(188, 30);
            this.reportesDeVentaToolStripMenuItem.Text = "Reportes de venta";
            this.reportesDeVentaToolStripMenuItem.Click += new System.EventHandler(this.reportesDeVentaToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.Image = global::Presentación.Properties.Resources.configuraciones;
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(119, 28);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(916, 454);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Punto de venta- ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmTiempo;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeProveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesDeVentaToolStripMenuItem;
    }
}

