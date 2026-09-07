namespace Menu_principal
{
    partial class ucProductos
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            txtPrecioU = new TextBox();
            lblProveedorprod = new Label();
            lblPrecioU = new Label();
            dateTimePicker1 = new DateTimePicker();
            txtStock = new TextBox();
            lblStockmin = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            dgvProveedor = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colStockmin = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colUnidademedida = new DataGridViewTextBoxColumn();
            cmbProveedorprod = new ComboBox();
            txtNombreProd = new TextBox();
            txtCantidad = new TextBox();
            txtUnidademedida = new TextBox();
            txtDescripcion = new TextBox();
            lblNombreProd = new Label();
            lblCantidad = new Label();
            lblFechaVencimiento = new Label();
            lblUnidademedida = new Label();
            lblDescripcionpprod = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // txtPrecioU
            // 
            txtPrecioU.Location = new Point(113, 380);
            txtPrecioU.Name = "txtPrecioU";
            txtPrecioU.Size = new Size(198, 30);
            txtPrecioU.TabIndex = 40;
            // 
            // lblProveedorprod
            // 
            lblProveedorprod.AutoSize = true;
            lblProveedorprod.BackColor = Color.White;
            lblProveedorprod.Location = new Point(370, 233);
            lblProveedorprod.Name = "lblProveedorprod";
            lblProveedorprod.Size = new Size(98, 22);
            lblProveedorprod.TabIndex = 39;
            lblProveedorprod.Text = "Proveedor ";
            // 
            // lblPrecioU
            // 
            lblPrecioU.AutoSize = true;
            lblPrecioU.BackColor = Color.White;
            lblPrecioU.Location = new Point(117, 331);
            lblPrecioU.Name = "lblPrecioU";
            lblPrecioU.Size = new Size(142, 22);
            lblPrecioU.TabIndex = 38;
            lblPrecioU.Text = "Precio Unitario  ";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(117, 275);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(197, 30);
            dateTimePicker1.TabIndex = 37;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(579, 171);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(198, 30);
            txtStock.TabIndex = 36;
            // 
            // lblStockmin
            // 
            lblStockmin.AutoSize = true;
            lblStockmin.Location = new Point(580, 128);
            lblStockmin.Name = "lblStockmin";
            lblStockmin.Size = new Size(126, 22);
            lblStockmin.TabIndex = 35;
            lblStockmin.Text = "Stock Minimo ";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1116, 331);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(213, 35);
            btnEliminar.TabIndex = 34;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Gold;
            btnEditar.Location = new Point(863, 331);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(213, 35);
            btnEditar.TabIndex = 33;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.OliveDrab;
            btnGuardar.Location = new Point(597, 331);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(213, 35);
            btnGuardar.TabIndex = 32;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedor.ColumnHeadersHeight = 29;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { Nombre, colDescripcion, colStockmin, colCantidad, colUnidademedida });
            dgvProveedor.Location = new Point(84, 436);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.Size = new Size(1227, 336);
            dgvProveedor.TabIndex = 31;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombres";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Descripcion";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            // 
            // colStockmin
            // 
            colStockmin.HeaderText = "Stock minimo ";
            colStockmin.MinimumWidth = 6;
            colStockmin.Name = "colStockmin";
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            // 
            // colUnidademedida
            // 
            colUnidademedida.HeaderText = "Unidad de medida";
            colUnidademedida.MinimumWidth = 6;
            colUnidademedida.Name = "colUnidademedida";
            // 
            // cmbProveedorprod
            // 
            cmbProveedorprod.FormattingEnabled = true;
            cmbProveedorprod.Location = new Point(370, 278);
            cmbProveedorprod.Name = "cmbProveedorprod";
            cmbProveedorprod.Size = new Size(180, 30);
            cmbProveedorprod.TabIndex = 30;
            // 
            // txtNombreProd
            // 
            txtNombreProd.Location = new Point(113, 170);
            txtNombreProd.Name = "txtNombreProd";
            txtNombreProd.Size = new Size(198, 30);
            txtNombreProd.TabIndex = 29;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(839, 170);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(198, 30);
            txtCantidad.TabIndex = 28;
            // 
            // txtUnidademedida
            // 
            txtUnidademedida.Location = new Point(1069, 171);
            txtUnidademedida.Name = "txtUnidademedida";
            txtUnidademedida.Size = new Size(198, 30);
            txtUnidademedida.TabIndex = 27;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(367, 170);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(180, 30);
            txtDescripcion.TabIndex = 26;
            // 
            // lblNombreProd
            // 
            lblNombreProd.AutoSize = true;
            lblNombreProd.Location = new Point(113, 127);
            lblNombreProd.Name = "lblNombreProd";
            lblNombreProd.Size = new Size(74, 22);
            lblNombreProd.TabIndex = 25;
            lblNombreProd.Text = "Nombre";
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Location = new Point(839, 127);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(86, 22);
            lblCantidad.TabIndex = 24;
            lblCantidad.Text = "Cantidad ";
            // 
            // lblFechaVencimiento
            // 
            lblFechaVencimiento.AutoSize = true;
            lblFechaVencimiento.BackColor = Color.White;
            lblFechaVencimiento.Location = new Point(116, 233);
            lblFechaVencimiento.Name = "lblFechaVencimiento";
            lblFechaVencimiento.Size = new Size(188, 22);
            lblFechaVencimiento.TabIndex = 23;
            lblFechaVencimiento.Text = "Fecha de Vencimiento ";
            // 
            // lblUnidademedida
            // 
            lblUnidademedida.AutoSize = true;
            lblUnidademedida.Location = new Point(1069, 128);
            lblUnidademedida.Name = "lblUnidademedida";
            lblUnidademedida.Size = new Size(154, 22);
            lblUnidademedida.TabIndex = 22;
            lblUnidademedida.Text = "Unidad de medida";
            // 
            // lblDescripcionpprod
            // 
            lblDescripcionpprod.AutoSize = true;
            lblDescripcionpprod.Location = new Point(367, 127);
            lblDescripcionpprod.Name = "lblDescripcionpprod";
            lblDescripcionpprod.Size = new Size(112, 22);
            lblDescripcionpprod.TabIndex = 21;
            lblDescripcionpprod.Text = "Descripcion ";
            // 
            // ucProductos
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtPrecioU);
            Controls.Add(lblProveedorprod);
            Controls.Add(lblPrecioU);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtStock);
            Controls.Add(lblStockmin);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvProveedor);
            Controls.Add(cmbProveedorprod);
            Controls.Add(txtNombreProd);
            Controls.Add(txtCantidad);
            Controls.Add(txtUnidademedida);
            Controls.Add(txtDescripcion);
            Controls.Add(lblNombreProd);
            Controls.Add(lblCantidad);
            Controls.Add(lblFechaVencimiento);
            Controls.Add(lblUnidademedida);
            Controls.Add(lblDescripcionpprod);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucProductos";
            Size = new Size(1396, 801);
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrecioU;
        private Label lblProveedorprod;
        private Label lblPrecioU;
        private DateTimePicker dateTimePicker1;
        private TextBox txtStock;
        private Label lblStockmin;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private DataGridView dgvProveedor;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colStockmin;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colUnidademedida;
        private ComboBox cmbProveedorprod;
        private TextBox txtNombreProd;
        private TextBox txtCantidad;
        private TextBox txtUnidademedida;
        private TextBox txtDescripcion;
        private Label lblNombreProd;
        private Label lblCantidad;
        private Label lblFechaVencimiento;
        private Label lblUnidademedida;
        private Label lblDescripcionpprod;
    }
}
