namespace Menu_principal
{
    partial class ucMovimientos
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
            lblIdProveedor = new Label();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            dgvProveedor = new DataGridView();
            cmbTipomov = new ComboBox();
            txtDire = new TextBox();
            lblTipodemov = new Label();
            lblMotivo = new Label();
            lblFecha = new Label();
            dtpMovimiento = new DateTimePicker();
            cmbIdProveedor = new ComboBox();
            Id = new DataGridViewTextBoxColumn();
            Tipodemov = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Proveedor = new DataGridViewTextBoxColumn();
            Motivo = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // lblIdProveedor
            // 
            lblIdProveedor.AutoSize = true;
            lblIdProveedor.Location = new Point(616, 92);
            lblIdProveedor.Name = "lblIdProveedor";
            lblIdProveedor.Size = new Size(114, 22);
            lblIdProveedor.TabIndex = 49;
            lblIdProveedor.Text = "Id Proveedor";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Location = new Point(1006, 243);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(213, 40);
            btnEliminar.TabIndex = 48;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Gold;
            btnEditar.Location = new Point(753, 243);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(213, 40);
            btnEditar.TabIndex = 47;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.OliveDrab;
            btnGuardar.Location = new Point(506, 243);
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
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { Id, Tipodemov, Fecha, Proveedor, Motivo });
            dgvProveedor.Location = new Point(40, 349);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.Size = new Size(1233, 341);
            dgvProveedor.TabIndex = 45;
            // 
            // cmbTipomov
            // 
            cmbTipomov.FormattingEnabled = true;
            cmbTipomov.Location = new Point(83, 138);
            cmbTipomov.Name = "cmbTipomov";
            cmbTipomov.Size = new Size(180, 30);
            cmbTipomov.TabIndex = 44;
            // 
            // txtDire
            // 
            txtDire.Location = new Point(891, 138);
            txtDire.Name = "txtDire";
            txtDire.Size = new Size(198, 30);
            txtDire.TabIndex = 42;
            // 
            // lblTipodemov
            // 
            lblTipodemov.AutoSize = true;
            lblTipodemov.Location = new Point(83, 94);
            lblTipodemov.Name = "lblTipodemov";
            lblTipodemov.Size = new Size(174, 22);
            lblTipodemov.TabIndex = 40;
            lblTipodemov.Text = "Tipo de movimiento ";
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(891, 95);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(73, 22);
            lblMotivo.TabIndex = 39;
            lblMotivo.Text = "Motivo ";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(331, 92);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(63, 22);
            lblFecha.TabIndex = 38;
            lblFecha.Text = "Fecha:";
         //   lblFecha.Click += this.lblFecha_Click;
            // 
            // dtpMovimiento
            // 
            dtpMovimiento.Location = new Point(331, 138);
            dtpMovimiento.Name = "dtpMovimiento";
            dtpMovimiento.Size = new Size(201, 30);
            dtpMovimiento.TabIndex = 51;
            // 
            // cmbIdProveedor
            // 
            cmbIdProveedor.FormattingEnabled = true;
            cmbIdProveedor.Location = new Point(616, 138);
            cmbIdProveedor.Name = "cmbIdProveedor";
            cmbIdProveedor.Size = new Size(180, 30);
            cmbIdProveedor.TabIndex = 52;
           // cmbIdProveedor.SelectedIndexChanged += this.comboBox1_SelectedIndexChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // Tipodemov
            // 
            Tipodemov.HeaderText = "Tipo de movimiento";
            Tipodemov.MinimumWidth = 6;
            Tipodemov.Name = "Tipodemov";
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            // 
            // Proveedor
            // 
            Proveedor.HeaderText = "Id Proveedor";
            Proveedor.MinimumWidth = 6;
            Proveedor.Name = "Proveedor";
            // 
            // Motivo
            // 
            Motivo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Motivo.HeaderText = "Motivo ";
            Motivo.MinimumWidth = 6;
            Motivo.Name = "Motivo";
            // 
            // Movimientos
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(cmbIdProveedor);
            Controls.Add(dtpMovimiento);
            Controls.Add(lblIdProveedor);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnGuardar);
            Controls.Add(dgvProveedor);
            Controls.Add(cmbTipomov);
            Controls.Add(txtDire);
            Controls.Add(lblTipodemov);
            Controls.Add(lblMotivo);
            Controls.Add(lblFecha);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Movimientos";
            Size = new Size(1371, 731);
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblIdProveedor;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
        private DataGridView dgvProveedor;
        private ComboBox cmbTipomov;
        private TextBox txtDire;
        private Label lblTipodemov;
        private Label lblMotivo;
        private Label lblFecha;
        private DateTimePicker dtpMovimiento;
        private ComboBox cmbIdProveedor;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Tipodemov;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Proveedor;
        private DataGridViewTextBoxColumn Motivo;
    }
}
