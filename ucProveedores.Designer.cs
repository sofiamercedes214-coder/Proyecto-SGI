namespace Menu_principal
{
    partial class ucProveedores
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
            lblEstado = new Label();
            txtStock = new TextBox();
            lbltelefono = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            dgvProveedor = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colStockmin = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colUnidademedida = new DataGridViewTextBoxColumn();
            cmbEstado = new ComboBox();
            txtNombres = new TextBox();
            txtDire = new TextBox();
            txtDescripcion = new TextBox();
            lblNombre = new Label();
            lblDire = new Label();
            lblApellidos = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(183, 257);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(64, 22);
            lblEstado.TabIndex = 51;
            lblEstado.Text = "Estado";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(649, 185);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(198, 30);
            txtStock.TabIndex = 50;
            // 
            // lbltelefono
            // 
            lbltelefono.AutoSize = true;
            lbltelefono.Location = new Point(650, 142);
            lbltelefono.Name = "lbltelefono";
            lbltelefono.Size = new Size(85, 22);
            lbltelefono.TabIndex = 49;
            lbltelefono.Text = "Telefono ";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1186, 345);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(213, 40);
            btnEliminar.TabIndex = 48;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Gold;
            btnEditar.Location = new Point(933, 345);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(213, 40);
            btnEditar.TabIndex = 47;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.OliveDrab;
            btnGuardar.Location = new Point(667, 345);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(213, 40);
            btnGuardar.TabIndex = 46;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedor.ColumnHeadersHeight = 29;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { colId, Nombre, colDescripcion, colStockmin, colCantidad, colUnidademedida });
            dgvProveedor.Location = new Point(142, 420);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.Size = new Size(1227, 341);
            dgvProveedor.TabIndex = 45;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
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
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(183, 297);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(180, 30);
            cmbEstado.TabIndex = 44;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(183, 184);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(198, 30);
            txtNombres.TabIndex = 43;
            // 
            // txtDire
            // 
            txtDire.Location = new Point(909, 184);
            txtDire.Name = "txtDire";
            txtDire.Size = new Size(198, 30);
            txtDire.TabIndex = 42;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(437, 184);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(180, 30);
            txtDescripcion.TabIndex = 41;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(183, 141);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(82, 22);
            lblNombre.TabIndex = 40;
            lblNombre.Text = "Nombres";
            // 
            // lblDire
            // 
            lblDire.AutoSize = true;
            lblDire.Location = new Point(909, 141);
            lblDire.Name = "lblDire";
            lblDire.Size = new Size(94, 22);
            lblDire.TabIndex = 39;
            lblDire.Text = "Direccion ";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(437, 141);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(89, 22);
            lblApellidos.TabIndex = 38;
            lblApellidos.Text = "Apellidos";
            // 
            // ucProveedores
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblEstado);
            Controls.Add(txtStock);
            Controls.Add(lbltelefono);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvProveedor);
            Controls.Add(cmbEstado);
            Controls.Add(txtNombres);
            Controls.Add(txtDire);
            Controls.Add(txtDescripcion);
            Controls.Add(lblNombre);
            Controls.Add(lblDire);
            Controls.Add(lblApellidos);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucProveedores";
            Size = new Size(1606, 772);
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstado;
        private TextBox txtStock;
        private Label lbltelefono;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private DataGridView dgvProveedor;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colStockmin;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colUnidademedida;
        private ComboBox cmbEstado;
        private TextBox txtNombres;
        private TextBox txtDire;
        private TextBox txtDescripcion;
        private Label lblNombre;
        private Label lblDire;
        private Label lblApellidos;
    }
}
