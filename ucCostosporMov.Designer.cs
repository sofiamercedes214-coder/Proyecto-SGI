namespace Menu_principal
{
    partial class ucCostosporMov
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
            dtpFechadesde = new DateTimePicker();
            lblFechahasta = new Label();
            btnConsultar = new Button();
            dgvProveedor = new DataGridView();
            cmbTipodemov = new ComboBox();
            lblFiltro = new Label();
            lblProveedorR = new Label();
            lblFechadesde = new Label();
            lblDescripcionpprod = new Label();
            dtpHasta = new DateTimePicker();
            cmbProveedorR = new ComboBox();
            Nombre = new DataGridViewTextBoxColumn();
            colDescripcion = new DataGridViewTextBoxColumn();
            colStockmin = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            colUnidademedida = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).BeginInit();
            SuspendLayout();
            // 
            // dtpFechadesde
            // 
            dtpFechadesde.Location = new Point(281, 121);
            dtpFechadesde.Name = "dtpFechadesde";
            dtpFechadesde.Size = new Size(197, 30);
            dtpFechadesde.TabIndex = 57;
            // 
            // lblFechahasta
            // 
            lblFechahasta.AutoSize = true;
            lblFechahasta.Location = new Point(537, 82);
            lblFechahasta.Name = "lblFechahasta";
            lblFechahasta.Size = new Size(61, 22);
            lblFechahasta.TabIndex = 55;
            lblFechahasta.Text = "Hasta:";
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.OliveDrab;
            btnConsultar.Location = new Point(70, 220);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(213, 35);
            btnConsultar.TabIndex = 52;
            btnConsultar.Text = "Consultar datos";
            btnConsultar.UseVisualStyleBackColor = false;
            // 
            // dgvProveedor
            // 
            dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProveedor.ColumnHeadersHeight = 29;
            dgvProveedor.Columns.AddRange(new DataGridViewColumn[] { Nombre, colDescripcion, colStockmin, colCantidad, colUnidademedida });
            dgvProveedor.Location = new Point(46, 296);
            dgvProveedor.Name = "dgvProveedor";
            dgvProveedor.RowHeadersWidth = 51;
            dgvProveedor.Size = new Size(1227, 336);
            dgvProveedor.TabIndex = 51;
            // 
            // cmbTipodemov
            // 
            cmbTipodemov.FormattingEnabled = true;
            cmbTipodemov.Location = new Point(74, 124);
            cmbTipodemov.Name = "cmbTipodemov";
            cmbTipodemov.Size = new Size(180, 30);
            cmbTipodemov.TabIndex = 50;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(70, 34);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(153, 22);
            lblFiltro.TabIndex = 45;
            lblFiltro.Text = "Filtro de Consulta";
            // 
            // lblProveedorR
            // 
            lblProveedorR.AutoSize = true;
            lblProveedorR.Location = new Point(796, 81);
            lblProveedorR.Name = "lblProveedorR";
            lblProveedorR.Size = new Size(93, 22);
            lblProveedorR.TabIndex = 44;
            lblProveedorR.Text = "Proveedor";
            // 
            // lblFechadesde
            // 
            lblFechadesde.AutoSize = true;
            lblFechadesde.BackColor = Color.White;
            lblFechadesde.Location = new Point(281, 82);
            lblFechadesde.Name = "lblFechadesde";
            lblFechadesde.Size = new Size(114, 22);
            lblFechadesde.TabIndex = 43;
            lblFechadesde.Text = "Fecha desde:";
            lblFechadesde.Click += lblFechaVencimiento_Click;
            // 
            // lblDescripcionpprod
            // 
            lblDescripcionpprod.AutoSize = true;
            lblDescripcionpprod.Location = new Point(70, 81);
            lblDescripcionpprod.Name = "lblDescripcionpprod";
            lblDescripcionpprod.Size = new Size(174, 22);
            lblDescripcionpprod.TabIndex = 41;
            lblDescripcionpprod.Text = "Tipo de movimiento ";
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(537, 124);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(197, 30);
            dtpHasta.TabIndex = 61;
            // 
            // cmbProveedorR
            // 
            cmbProveedorR.FormattingEnabled = true;
            cmbProveedorR.Location = new Point(800, 121);
            cmbProveedorR.Name = "cmbProveedorR";
            cmbProveedorR.Size = new Size(180, 30);
            cmbProveedorR.TabIndex = 62;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Tipo de mov ";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // colDescripcion
            // 
            colDescripcion.HeaderText = "Fecha";
            colDescripcion.MinimumWidth = 6;
            colDescripcion.Name = "colDescripcion";
            // 
            // colStockmin
            // 
            colStockmin.HeaderText = "Cantidad";
            colStockmin.MinimumWidth = 6;
            colStockmin.Name = "colStockmin";
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Costo Unitario";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            // 
            // colUnidademedida
            // 
            colUnidademedida.HeaderText = "Costo total";
            colUnidademedida.MinimumWidth = 6;
            colUnidademedida.Name = "colUnidademedida";
            // 
            // ucCostosporMov
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(cmbProveedorR);
            Controls.Add(dtpHasta);
            Controls.Add(dtpFechadesde);
            Controls.Add(lblFechahasta);
            Controls.Add(btnConsultar);
            Controls.Add(dgvProveedor);
            Controls.Add(cmbTipodemov);
            Controls.Add(lblFiltro);
            Controls.Add(lblProveedorR);
            Controls.Add(lblFechadesde);
            Controls.Add(lblDescripcionpprod);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucCostosporMov";
            Size = new Size(1774, 878);
            ((System.ComponentModel.ISupportInitialize)dgvProveedor).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpFechadesde;
        private Label lblFechahasta;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnConsultar;
        private DataGridView dgvProveedor;
        private ComboBox cmbTipodemov;
        private TextBox txtCantidad;
        private Label lblFiltro;
        private Label lblProveedorR;
        private Label lblFechadesde;
        private Label lblDescripcionpprod;
        private DateTimePicker dtpHasta;
        private ComboBox cmbProveedorR;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn colDescripcion;
        private DataGridViewTextBoxColumn colStockmin;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn colUnidademedida;
    }
}
