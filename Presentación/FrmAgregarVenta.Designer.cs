namespace Presentación
{
    partial class FrmAgregarVenta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFechaValidez = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxNoFactura = new System.Windows.Forms.TextBox();
            this.lblNoFactura = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbLectorCodigo = new System.Windows.Forms.CheckBox();
            this.btnEliminarProductoAv = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.tbxIdProducto = new System.Windows.Forms.TextBox();
            this.btnBuscarProductoAv = new System.Windows.Forms.Button();
            this.tbxPresentacion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbxIva = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbxDescuento = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxPrecioVenta = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxStockActual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxTipoCargo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxCodigoProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxNombreProducto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxCodigoBarra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvAgregarVenta = new System.Windows.Forms.DataGridView();
            this.Id_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Presentacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Venta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IVA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.tbxMontoTotal = new System.Windows.Forms.TextBox();
            this.lblTotalAPagar = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbxSubTotal = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbxDescuento2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbxIva2 = new System.Windows.Forms.TextBox();
            this.tbxIdVenta = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(742, 506);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox1.Controls.Add(this.tbxIdVenta);
            this.groupBox1.Controls.Add(this.dtpFechaValidez);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtpFechaFactura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbxNoFactura);
            this.groupBox1.Controls.Add(this.lblNoFactura);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información de la factura";
            // 
            // dtpFechaValidez
            // 
            this.dtpFechaValidez.Location = new System.Drawing.Point(546, 42);
            this.dtpFechaValidez.Name = "dtpFechaValidez";
            this.dtpFechaValidez.Size = new System.Drawing.Size(259, 25);
            this.dtpFechaValidez.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(546, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de validez:";
            // 
            // dtpFechaFactura
            // 
            this.dtpFechaFactura.Location = new System.Drawing.Point(300, 42);
            this.dtpFechaFactura.Name = "dtpFechaFactura";
            this.dtpFechaFactura.Size = new System.Drawing.Size(241, 25);
            this.dtpFechaFactura.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(297, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fecha de factura:";
            // 
            // tbxNoFactura
            // 
            this.tbxNoFactura.Location = new System.Drawing.Point(30, 42);
            this.tbxNoFactura.Name = "tbxNoFactura";
            this.tbxNoFactura.ReadOnly = true;
            this.tbxNoFactura.Size = new System.Drawing.Size(264, 25);
            this.tbxNoFactura.TabIndex = 1;
            // 
            // lblNoFactura
            // 
            this.lblNoFactura.AutoSize = true;
            this.lblNoFactura.ForeColor = System.Drawing.Color.Black;
            this.lblNoFactura.Location = new System.Drawing.Point(27, 22);
            this.lblNoFactura.Name = "lblNoFactura";
            this.lblNoFactura.Size = new System.Drawing.Size(78, 17);
            this.lblNoFactura.TabIndex = 0;
            this.lblNoFactura.Text = "No. Factura:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Controls.Add(this.cbLectorCodigo);
            this.groupBox2.Controls.Add(this.btnEliminarProductoAv);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnAgregarProducto);
            this.groupBox2.Controls.Add(this.tbxIdProducto);
            this.groupBox2.Controls.Add(this.btnBuscarProductoAv);
            this.groupBox2.Controls.Add(this.tbxPresentacion);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.tbxIva);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.tbxDescuento);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.tbxPrecioVenta);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tbxCantidad);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbxStockActual);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbxTipoCargo);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.tbxCodigoProducto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbxNombreProducto);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbxCodigoBarra);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Location = new System.Drawing.Point(12, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(851, 183);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle del producto:";
            // 
            // cbLectorCodigo
            // 
            this.cbLectorCodigo.AutoSize = true;
            this.cbLectorCodigo.ForeColor = System.Drawing.Color.Black;
            this.cbLectorCodigo.Location = new System.Drawing.Point(176, 9);
            this.cbLectorCodigo.Name = "cbLectorCodigo";
            this.cbLectorCodigo.Size = new System.Drawing.Size(127, 21);
            this.cbLectorCodigo.TabIndex = 28;
            this.cbLectorCodigo.Text = "Lector de código";
            this.cbLectorCodigo.UseVisualStyleBackColor = true;
            this.cbLectorCodigo.CheckedChanged += new System.EventHandler(this.cbLectorCodigo_CheckedChanged);
            // 
            // btnEliminarProductoAv
            // 
            this.btnEliminarProductoAv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnEliminarProductoAv.BackColor = System.Drawing.Color.Azure;
            this.btnEliminarProductoAv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarProductoAv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarProductoAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProductoAv.Image = global::Presentación.Properties.Resources.Eliminar1;
            this.btnEliminarProductoAv.Location = new System.Drawing.Point(787, 121);
            this.btnEliminarProductoAv.Name = "btnEliminarProductoAv";
            this.btnEliminarProductoAv.Size = new System.Drawing.Size(30, 25);
            this.btnEliminarProductoAv.TabIndex = 27;
            this.btnEliminarProductoAv.UseVisualStyleBackColor = false;
            this.btnEliminarProductoAv.Click += new System.EventHandler(this.btnEliminarProductoAv_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(777, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Eliminar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(777, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "Agregar";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Azure;
            this.btnAgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarProducto.Image = global::Presentación.Properties.Resources.Agregar1;
            this.btnAgregarProducto.Location = new System.Drawing.Point(787, 67);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(30, 25);
            this.btnAgregarProducto.TabIndex = 24;
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // tbxIdProducto
            // 
            this.tbxIdProducto.Location = new System.Drawing.Point(12, 67);
            this.tbxIdProducto.Name = "tbxIdProducto";
            this.tbxIdProducto.ReadOnly = true;
            this.tbxIdProducto.Size = new System.Drawing.Size(13, 25);
            this.tbxIdProducto.TabIndex = 23;
            // 
            // btnBuscarProductoAv
            // 
            this.btnBuscarProductoAv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBuscarProductoAv.BackColor = System.Drawing.Color.Azure;
            this.btnBuscarProductoAv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProductoAv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarProductoAv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductoAv.Image = global::Presentación.Properties.Resources.Buscar;
            this.btnBuscarProductoAv.Location = new System.Drawing.Point(616, 67);
            this.btnBuscarProductoAv.Name = "btnBuscarProductoAv";
            this.btnBuscarProductoAv.Size = new System.Drawing.Size(24, 25);
            this.btnBuscarProductoAv.TabIndex = 22;
            this.btnBuscarProductoAv.UseVisualStyleBackColor = false;
            this.btnBuscarProductoAv.Click += new System.EventHandler(this.btnBuscarProductoAv_Click);
            // 
            // tbxPresentacion
            // 
            this.tbxPresentacion.Location = new System.Drawing.Point(382, 121);
            this.tbxPresentacion.Name = "tbxPresentacion";
            this.tbxPresentacion.ReadOnly = true;
            this.tbxPresentacion.Size = new System.Drawing.Size(152, 25);
            this.tbxPresentacion.TabIndex = 21;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(379, 101);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 17);
            this.label14.TabIndex = 20;
            this.label14.Text = "Presentación:";
            // 
            // tbxIva
            // 
            this.tbxIva.Location = new System.Drawing.Point(669, 121);
            this.tbxIva.Name = "tbxIva";
            this.tbxIva.ReadOnly = true;
            this.tbxIva.Size = new System.Drawing.Size(93, 25);
            this.tbxIva.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(666, 101);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "IVA:";
            // 
            // tbxDescuento
            // 
            this.tbxDescuento.Location = new System.Drawing.Point(541, 121);
            this.tbxDescuento.Name = "tbxDescuento";
            this.tbxDescuento.Size = new System.Drawing.Size(122, 25);
            this.tbxDescuento.TabIndex = 17;
            this.tbxDescuento.Leave += new System.EventHandler(this.tbxDescuento_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(538, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 16;
            this.label12.Text = "Descuento:";
            // 
            // tbxPrecioVenta
            // 
            this.tbxPrecioVenta.Location = new System.Drawing.Point(269, 121);
            this.tbxPrecioVenta.Name = "tbxPrecioVenta";
            this.tbxPrecioVenta.ReadOnly = true;
            this.tbxPrecioVenta.Size = new System.Drawing.Size(107, 25);
            this.tbxPrecioVenta.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(266, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Precio de venta:";
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(31, 121);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(129, 25);
            this.tbxCantidad.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(28, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cantidad:";
            // 
            // tbxStockActual
            // 
            this.tbxStockActual.Location = new System.Drawing.Point(166, 121);
            this.tbxStockActual.Name = "tbxStockActual";
            this.tbxStockActual.ReadOnly = true;
            this.tbxStockActual.Size = new System.Drawing.Size(97, 25);
            this.tbxStockActual.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(163, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Stock actual:";
            // 
            // tbxTipoCargo
            // 
            this.tbxTipoCargo.Location = new System.Drawing.Point(646, 67);
            this.tbxTipoCargo.Name = "tbxTipoCargo";
            this.tbxTipoCargo.ReadOnly = true;
            this.tbxTipoCargo.Size = new System.Drawing.Size(116, 25);
            this.tbxTipoCargo.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(643, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Tipo de cargo:";
            // 
            // tbxCodigoProducto
            // 
            this.tbxCodigoProducto.Location = new System.Drawing.Point(212, 67);
            this.tbxCodigoProducto.Name = "tbxCodigoProducto";
            this.tbxCodigoProducto.ReadOnly = true;
            this.tbxCodigoProducto.Size = new System.Drawing.Size(179, 25);
            this.tbxCodigoProducto.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(209, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Código producto:";
            // 
            // tbxNombreProducto
            // 
            this.tbxNombreProducto.Location = new System.Drawing.Point(397, 67);
            this.tbxNombreProducto.Name = "tbxNombreProducto";
            this.tbxNombreProducto.ReadOnly = true;
            this.tbxNombreProducto.Size = new System.Drawing.Size(213, 25);
            this.tbxNombreProducto.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(394, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre del producto:";
            // 
            // tbxCodigoBarra
            // 
            this.tbxCodigoBarra.Location = new System.Drawing.Point(31, 67);
            this.tbxCodigoBarra.Name = "tbxCodigoBarra";
            this.tbxCodigoBarra.Size = new System.Drawing.Size(175, 25);
            this.tbxCodigoBarra.TabIndex = 1;
            this.tbxCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCodigoBarra_KeyPress);
            this.tbxCodigoBarra.Leave += new System.EventHandler(this.tbxCodigoBarra_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(28, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Código de barra:";
            // 
            // dgvAgregarVenta
            // 
            this.dgvAgregarVenta.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAgregarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAgregarVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Producto,
            this.Nombre_Producto,
            this.Presentacion,
            this.Cantida,
            this.Precio_Venta,
            this.Importe,
            this.Descuento,
            this.IVA,
            this.MontoTotal});
            this.dgvAgregarVenta.Enabled = false;
            this.dgvAgregarVenta.Location = new System.Drawing.Point(12, 290);
            this.dgvAgregarVenta.Name = "dgvAgregarVenta";
            this.dgvAgregarVenta.Size = new System.Drawing.Size(850, 191);
            this.dgvAgregarVenta.TabIndex = 3;
            // 
            // Id_Producto
            // 
            this.Id_Producto.HeaderText = "Id producto";
            this.Id_Producto.Name = "Id_Producto";
            this.Id_Producto.Visible = false;
            // 
            // Nombre_Producto
            // 
            this.Nombre_Producto.HeaderText = "Nombre del producto";
            this.Nombre_Producto.Name = "Nombre_Producto";
            // 
            // Presentacion
            // 
            this.Presentacion.HeaderText = "Presentación";
            this.Presentacion.Name = "Presentacion";
            // 
            // Cantida
            // 
            this.Cantida.HeaderText = "Cantidad";
            this.Cantida.Name = "Cantida";
            // 
            // Precio_Venta
            // 
            this.Precio_Venta.HeaderText = "Precio venta";
            this.Precio_Venta.Name = "Precio_Venta";
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.Name = "Importe";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // IVA
            // 
            this.IVA.HeaderText = "IVA";
            this.IVA.Name = "IVA";
            // 
            // MontoTotal
            // 
            this.MontoTotal.HeaderText = "Total";
            this.MontoTotal.Name = "MontoTotal";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAceptar.BackColor = System.Drawing.Color.Azure;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = global::Presentación.Properties.Resources.icono_01;
            this.btnAceptar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAceptar.Location = new System.Drawing.Point(607, 506);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(120, 30);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // tbxMontoTotal
            // 
            this.tbxMontoTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxMontoTotal.Location = new System.Drawing.Point(399, 516);
            this.tbxMontoTotal.Name = "tbxMontoTotal";
            this.tbxMontoTotal.ReadOnly = true;
            this.tbxMontoTotal.Size = new System.Drawing.Size(122, 20);
            this.tbxMontoTotal.TabIndex = 13;
            // 
            // lblTotalAPagar
            // 
            this.lblTotalAPagar.AutoSize = true;
            this.lblTotalAPagar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAPagar.Location = new System.Drawing.Point(395, 493);
            this.lblTotalAPagar.Name = "lblTotalAPagar";
            this.lblTotalAPagar.Size = new System.Drawing.Size(94, 20);
            this.lblTotalAPagar.TabIndex = 14;
            this.lblTotalAPagar.Text = "Monto total:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(8, 493);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 20);
            this.label15.TabIndex = 16;
            this.label15.Text = "Sub total:";
            // 
            // tbxSubTotal
            // 
            this.tbxSubTotal.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxSubTotal.Location = new System.Drawing.Point(12, 516);
            this.tbxSubTotal.Name = "tbxSubTotal";
            this.tbxSubTotal.ReadOnly = true;
            this.tbxSubTotal.Size = new System.Drawing.Size(122, 20);
            this.tbxSubTotal.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(136, 493);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 20);
            this.label16.TabIndex = 18;
            this.label16.Text = "Descuento:";
            // 
            // tbxDescuento2
            // 
            this.tbxDescuento2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxDescuento2.Location = new System.Drawing.Point(140, 516);
            this.tbxDescuento2.Name = "tbxDescuento2";
            this.tbxDescuento2.ReadOnly = true;
            this.tbxDescuento2.Size = new System.Drawing.Size(122, 20);
            this.tbxDescuento2.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(267, 493);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "IVA:";
            // 
            // tbxIva2
            // 
            this.tbxIva2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tbxIva2.Location = new System.Drawing.Point(271, 516);
            this.tbxIva2.Name = "tbxIva2";
            this.tbxIva2.ReadOnly = true;
            this.tbxIva2.Size = new System.Drawing.Size(122, 20);
            this.tbxIva2.TabIndex = 19;
            // 
            // tbxIdVenta
            // 
            this.tbxIdVenta.Location = new System.Drawing.Point(12, 42);
            this.tbxIdVenta.Name = "tbxIdVenta";
            this.tbxIdVenta.ReadOnly = true;
            this.tbxIdVenta.Size = new System.Drawing.Size(13, 25);
            this.tbxIdVenta.TabIndex = 24;
            // 
            // FrmAgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 548);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbxIva2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tbxDescuento2);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbxSubTotal);
            this.Controls.Add(this.lblTotalAPagar);
            this.Controls.Add(this.tbxMontoTotal);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dgvAgregarVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmAgregarVenta";
            this.Text = "Agregar venta";
            this.Load += new System.EventHandler(this.FrmAgregarVenta_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.dgvAgregarVenta, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.tbxMontoTotal, 0);
            this.Controls.SetChildIndex(this.lblTotalAPagar, 0);
            this.Controls.SetChildIndex(this.tbxSubTotal, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.tbxDescuento2, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.tbxIva2, 0);
            this.Controls.SetChildIndex(this.label17, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAgregarVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxNoFactura;
        private System.Windows.Forms.Label lblNoFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaFactura;
        private System.Windows.Forms.DateTimePicker dtpFechaValidez;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxStockActual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxTipoCargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxCodigoProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxNombreProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxCodigoBarra;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbxDescuento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxPrecioVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxIva;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dgvAgregarVenta;
        public System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblTotalAPagar;
        private System.Windows.Forms.TextBox tbxPresentacion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        public System.Windows.Forms.Button btnBuscarProductoAv;
        private System.Windows.Forms.TextBox tbxIdProducto;
        public System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbxMontoTotal;
        public System.Windows.Forms.TextBox tbxSubTotal;
        public System.Windows.Forms.TextBox tbxDescuento2;
        public System.Windows.Forms.TextBox tbxIva2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Presentacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Venta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn IVA;
        private System.Windows.Forms.DataGridViewTextBoxColumn MontoTotal;
        public System.Windows.Forms.Button btnEliminarProductoAv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbLectorCodigo;
        private System.Windows.Forms.TextBox tbxIdVenta;
    }
}