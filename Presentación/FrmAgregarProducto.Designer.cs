namespace Presentación
{
    partial class FrmAgregarProducto
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
            this.lblCodigoProducto = new System.Windows.Forms.Label();
            this.tbxCodigoProducto = new System.Windows.Forms.TextBox();
            this.tbxDescripcion = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxNombreProducto = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tbxPresentacion = new System.Windows.Forms.TextBox();
            this.lblPresentacion = new System.Windows.Forms.Label();
            this.tbxCostoUnitario = new System.Windows.Forms.TextBox();
            this.lblCostoUnitario = new System.Windows.Forms.Label();
            this.tbxPrecioVenta = new System.Windows.Forms.TextBox();
            this.cbxTipoCargo = new System.Windows.Forms.ComboBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblTipoCargo = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbxCodigoBarra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(296, 370);
            this.btnCancelar.TabIndex = 6;
            // 
            // lblCodigoProducto
            // 
            this.lblCodigoProducto.AutoSize = true;
            this.lblCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoProducto.Location = new System.Drawing.Point(26, 50);
            this.lblCodigoProducto.Name = "lblCodigoProducto";
            this.lblCodigoProducto.Size = new System.Drawing.Size(110, 16);
            this.lblCodigoProducto.TabIndex = 1;
            this.lblCodigoProducto.Text = "Código producto:";
            // 
            // tbxCodigoProducto
            // 
            this.tbxCodigoProducto.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbxCodigoProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigoProducto.Location = new System.Drawing.Point(139, 41);
            this.tbxCodigoProducto.Multiline = true;
            this.tbxCodigoProducto.Name = "tbxCodigoProducto";
            this.tbxCodigoProducto.Size = new System.Drawing.Size(243, 25);
            this.tbxCodigoProducto.TabIndex = 2;
            // 
            // tbxDescripcion
            // 
            this.tbxDescripcion.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbxDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDescripcion.Location = new System.Drawing.Point(139, 156);
            this.tbxDescripcion.Multiline = true;
            this.tbxDescripcion.Name = "tbxDescripcion";
            this.tbxDescripcion.Size = new System.Drawing.Size(243, 25);
            this.tbxDescripcion.TabIndex = 4;
            this.tbxDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxDescripcion_KeyPress);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(79, 125);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 3;
            this.lblNombre.Text = "Nombre:";
            // 
            // tbxNombreProducto
            // 
            this.tbxNombreProducto.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbxNombreProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNombreProducto.Location = new System.Drawing.Point(139, 116);
            this.tbxNombreProducto.Multiline = true;
            this.tbxNombreProducto.Name = "tbxNombreProducto";
            this.tbxNombreProducto.Size = new System.Drawing.Size(243, 25);
            this.tbxNombreProducto.TabIndex = 0;
            this.tbxNombreProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxNombreProducto_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(51, 165);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // tbxPresentacion
            // 
            this.tbxPresentacion.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbxPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPresentacion.Location = new System.Drawing.Point(139, 195);
            this.tbxPresentacion.Multiline = true;
            this.tbxPresentacion.Name = "tbxPresentacion";
            this.tbxPresentacion.Size = new System.Drawing.Size(243, 25);
            this.tbxPresentacion.TabIndex = 8;
            this.tbxPresentacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPresentacion_KeyPress);
            // 
            // lblPresentacion
            // 
            this.lblPresentacion.AutoSize = true;
            this.lblPresentacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPresentacion.Location = new System.Drawing.Point(44, 204);
            this.lblPresentacion.Name = "lblPresentacion";
            this.lblPresentacion.Size = new System.Drawing.Size(89, 16);
            this.lblPresentacion.TabIndex = 7;
            this.lblPresentacion.Text = "Presentación:";
            // 
            // tbxCostoUnitario
            // 
            this.tbxCostoUnitario.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbxCostoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCostoUnitario.Location = new System.Drawing.Point(139, 234);
            this.tbxCostoUnitario.Multiline = true;
            this.tbxCostoUnitario.Name = "tbxCostoUnitario";
            this.tbxCostoUnitario.Size = new System.Drawing.Size(243, 25);
            this.tbxCostoUnitario.TabIndex = 10;
            this.tbxCostoUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxCostoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCostoUnitario_KeyPress);
            this.tbxCostoUnitario.Leave += new System.EventHandler(this.tbxCostoUnitario_Leave);
            // 
            // lblCostoUnitario
            // 
            this.lblCostoUnitario.AutoSize = true;
            this.lblCostoUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostoUnitario.Location = new System.Drawing.Point(42, 243);
            this.lblCostoUnitario.Name = "lblCostoUnitario";
            this.lblCostoUnitario.Size = new System.Drawing.Size(91, 16);
            this.lblCostoUnitario.TabIndex = 9;
            this.lblCostoUnitario.Text = "Costo unitario:";
            // 
            // tbxPrecioVenta
            // 
            this.tbxPrecioVenta.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbxPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrecioVenta.Location = new System.Drawing.Point(139, 273);
            this.tbxPrecioVenta.Multiline = true;
            this.tbxPrecioVenta.Name = "tbxPrecioVenta";
            this.tbxPrecioVenta.Size = new System.Drawing.Size(243, 25);
            this.tbxPrecioVenta.TabIndex = 11;
            this.tbxPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbxPrecioVenta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPrecioVenta_KeyPress);
            this.tbxPrecioVenta.Leave += new System.EventHandler(this.tbxPrecioVenta_Leave);
            // 
            // cbxTipoCargo
            // 
            this.cbxTipoCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipoCargo.FormattingEnabled = true;
            this.cbxTipoCargo.Items.AddRange(new object[] {
            "Exento"});
            this.cbxTipoCargo.Location = new System.Drawing.Point(139, 315);
            this.cbxTipoCargo.Name = "cbxTipoCargo";
            this.cbxTipoCargo.Size = new System.Drawing.Size(243, 21);
            this.cbxTipoCargo.TabIndex = 12;
            this.cbxTipoCargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxTipoCargo_KeyPress);
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.Location = new System.Drawing.Point(48, 282);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(85, 16);
            this.lblPrecioVenta.TabIndex = 13;
            this.lblPrecioVenta.Text = "Precio venta:";
            // 
            // lblTipoCargo
            // 
            this.lblTipoCargo.AutoSize = true;
            this.lblTipoCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCargo.Location = new System.Drawing.Point(38, 320);
            this.lblTipoCargo.Name = "lblTipoCargo";
            this.lblTipoCargo.Size = new System.Drawing.Size(95, 16);
            this.lblTipoCargo.TabIndex = 14;
            this.lblTipoCargo.Text = "Tipo de cargo:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAgregar.BackColor = System.Drawing.Color.Azure;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = global::Presentación.Properties.Resources.Guardar;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(170, 370);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(120, 30);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbxCodigoBarra
            // 
            this.tbxCodigoBarra.BackColor = System.Drawing.Color.PapayaWhip;
            this.tbxCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCodigoBarra.Location = new System.Drawing.Point(139, 81);
            this.tbxCodigoBarra.Multiline = true;
            this.tbxCodigoBarra.Name = "tbxCodigoBarra";
            this.tbxCodigoBarra.Size = new System.Drawing.Size(243, 25);
            this.tbxCodigoBarra.TabIndex = 17;
            this.tbxCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCodigoBarra_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código de barra:";
            // 
            // FrmAgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 412);
            this.Controls.Add(this.tbxCodigoBarra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTipoCargo);
            this.Controls.Add(this.lblPrecioVenta);
            this.Controls.Add(this.cbxTipoCargo);
            this.Controls.Add(this.tbxPrecioVenta);
            this.Controls.Add(this.tbxCostoUnitario);
            this.Controls.Add(this.lblCostoUnitario);
            this.Controls.Add(this.tbxPresentacion);
            this.Controls.Add(this.lblPresentacion);
            this.Controls.Add(this.tbxNombreProducto);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.tbxDescripcion);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.tbxCodigoProducto);
            this.Controls.Add(this.lblCodigoProducto);
            this.MaximizeBox = false;
            this.Name = "FrmAgregarProducto";
            this.Text = "Agregar producto";
            this.Load += new System.EventHandler(this.FrmAgregarProducto_Load);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.lblCodigoProducto, 0);
            this.Controls.SetChildIndex(this.tbxCodigoProducto, 0);
            this.Controls.SetChildIndex(this.lblNombre, 0);
            this.Controls.SetChildIndex(this.tbxDescripcion, 0);
            this.Controls.SetChildIndex(this.lblDescripcion, 0);
            this.Controls.SetChildIndex(this.tbxNombreProducto, 0);
            this.Controls.SetChildIndex(this.lblPresentacion, 0);
            this.Controls.SetChildIndex(this.tbxPresentacion, 0);
            this.Controls.SetChildIndex(this.lblCostoUnitario, 0);
            this.Controls.SetChildIndex(this.tbxCostoUnitario, 0);
            this.Controls.SetChildIndex(this.tbxPrecioVenta, 0);
            this.Controls.SetChildIndex(this.cbxTipoCargo, 0);
            this.Controls.SetChildIndex(this.lblPrecioVenta, 0);
            this.Controls.SetChildIndex(this.lblTipoCargo, 0);
            this.Controls.SetChildIndex(this.btnAgregar, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.tbxCodigoBarra, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodigoProducto;
        public System.Windows.Forms.TextBox tbxCodigoProducto;
        public System.Windows.Forms.TextBox tbxDescripcion;
        private System.Windows.Forms.Label lblNombre;
        public System.Windows.Forms.TextBox tbxNombreProducto;
        private System.Windows.Forms.Label lblDescripcion;
        public System.Windows.Forms.TextBox tbxPresentacion;
        private System.Windows.Forms.Label lblPresentacion;
        public System.Windows.Forms.TextBox tbxCostoUnitario;
        private System.Windows.Forms.Label lblCostoUnitario;
        public System.Windows.Forms.TextBox tbxPrecioVenta;
        private System.Windows.Forms.ComboBox cbxTipoCargo;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Label lblTipoCargo;
        public System.Windows.Forms.Button btnAgregar;
        public System.Windows.Forms.TextBox tbxCodigoBarra;
        private System.Windows.Forms.Label label1;
    }
}