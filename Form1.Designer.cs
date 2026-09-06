namespace FrmMenuPrincipal
{
    partial class FrmMenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlMenu = new Panel();
            rdoAyuda = new RadioButton();
            rdoReportes = new RadioButton();
            rdoProductos = new RadioButton();
            rdoMovientos = new RadioButton();
            rdoProveedores = new RadioButton();
            pnlContenido = new Panel();
            lblTituloProductos = new Label();
            lblTituloReportes = new Label();
            lblTituloMovimientos = new Label();
            lblTituloProveedores = new Label();
            btnProductos = new Button();
            btnReportes = new Button();
            btnMovientos = new Button();
            btnProveedores = new Button();
            lblSeleccion = new Label();
            lblBienvenido = new Label();
            pnlMenu.SuspendLayout();
            pnlContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.Controls.Add(rdoAyuda);
            pnlMenu.Controls.Add(rdoReportes);
            pnlMenu.Controls.Add(rdoProductos);
            pnlMenu.Controls.Add(rdoMovientos);
            pnlMenu.Controls.Add(rdoProveedores);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(3, 4, 3, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(149, 615);
            pnlMenu.TabIndex = 0;
            // 
            // rdoAyuda
            // 
            rdoAyuda.AutoSize = true;
            rdoAyuda.Location = new Point(14, 555);
            rdoAyuda.Margin = new Padding(3, 4, 3, 4);
            rdoAyuda.Name = "rdoAyuda";
            rdoAyuda.Size = new Size(72, 24);
            rdoAyuda.TabIndex = 5;
            rdoAyuda.TabStop = true;
            rdoAyuda.Text = "Ayuda";
            rdoAyuda.UseVisualStyleBackColor = true;
            rdoAyuda.CheckedChanged += rdoAyuda_CheckedChanged;
            // 
            // rdoReportes
            // 
            rdoReportes.AutoSize = true;
            rdoReportes.Location = new Point(23, 329);
            rdoReportes.Margin = new Padding(3, 4, 3, 4);
            rdoReportes.Name = "rdoReportes";
            rdoReportes.Size = new Size(89, 24);
            rdoReportes.TabIndex = 4;
            rdoReportes.TabStop = true;
            rdoReportes.Text = "Reportes";
            rdoReportes.UseVisualStyleBackColor = true;
            // 
            // rdoProductos
            // 
            rdoProductos.AutoSize = true;
            rdoProductos.Location = new Point(14, 40);
            rdoProductos.Margin = new Padding(3, 4, 3, 4);
            rdoProductos.Name = "rdoProductos";
            rdoProductos.Size = new Size(96, 24);
            rdoProductos.TabIndex = 1;
            rdoProductos.TabStop = true;
            rdoProductos.Text = "Productos";
            rdoProductos.UseVisualStyleBackColor = true;
            // 
            // rdoMovientos
            // 
            rdoMovientos.AutoSize = true;
            rdoMovientos.Location = new Point(14, 223);
            rdoMovientos.Margin = new Padding(3, 4, 3, 4);
            rdoMovientos.Name = "rdoMovientos";
            rdoMovientos.Size = new Size(116, 24);
            rdoMovientos.TabIndex = 3;
            rdoMovientos.TabStop = true;
            rdoMovientos.Text = "Movimientos";
            rdoMovientos.UseVisualStyleBackColor = true;
            // 
            // rdoProveedores
            // 
            rdoProveedores.AutoSize = true;
            rdoProveedores.Location = new Point(14, 124);
            rdoProveedores.Margin = new Padding(3, 4, 3, 4);
            rdoProveedores.Name = "rdoProveedores";
            rdoProveedores.Size = new Size(112, 24);
            rdoProveedores.TabIndex = 2;
            rdoProveedores.TabStop = true;
            rdoProveedores.Text = "Proveedores";
            rdoProveedores.UseVisualStyleBackColor = true;
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(lblTituloProductos);
            pnlContenido.Controls.Add(lblTituloReportes);
            pnlContenido.Controls.Add(lblTituloMovimientos);
            pnlContenido.Controls.Add(lblTituloProveedores);
            pnlContenido.Controls.Add(btnProductos);
            pnlContenido.Controls.Add(btnReportes);
            pnlContenido.Controls.Add(btnMovientos);
            pnlContenido.Controls.Add(btnProveedores);
            pnlContenido.Controls.Add(lblSeleccion);
            pnlContenido.Controls.Add(lblBienvenido);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(149, 0);
            pnlContenido.Margin = new Padding(3, 4, 3, 4);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(861, 615);
            pnlContenido.TabIndex = 1;
            // 
            // lblTituloProductos
            // 
            lblTituloProductos.AutoSize = true;
            lblTituloProductos.Location = new Point(685, 399);
            lblTituloProductos.MinimumSize = new Size(2, 3);
            lblTituloProductos.Name = "lblTituloProductos";
            lblTituloProductos.Size = new Size(139, 40);
            lblTituloProductos.TabIndex = 8;
            lblTituloProductos.Text = "Registrar productos\r\ny categorias \r\n";
            lblTituloProductos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloReportes
            // 
            lblTituloReportes.AutoSize = true;
            lblTituloReportes.Location = new Point(470, 387);
            lblTituloReportes.MinimumSize = new Size(2, 3);
            lblTituloReportes.Name = "lblTituloReportes";
            lblTituloReportes.Size = new Size(148, 60);
            lblTituloReportes.TabIndex = 7;
            lblTituloReportes.Text = "Genere reportes\r\nresumenes y \r\nconsulte informacion\r\n";
            lblTituloReportes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloMovimientos
            // 
            lblTituloMovimientos.Anchor = AnchorStyles.None;
            lblTituloMovimientos.AutoSize = true;
            lblTituloMovimientos.Location = new Point(248, 389);
            lblTituloMovimientos.MinimumSize = new Size(2, 3);
            lblTituloMovimientos.Name = "lblTituloMovimientos";
            lblTituloMovimientos.Size = new Size(172, 40);
            lblTituloMovimientos.TabIndex = 6;
            lblTituloMovimientos.Text = "Registre las salidas\r\n y entradas de inventario";
            lblTituloMovimientos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloProveedores
            // 
            lblTituloProveedores.AutoSize = true;
            lblTituloProveedores.Location = new Point(49, 379);
            lblTituloProveedores.MinimumSize = new Size(2, 3);
            lblTituloProveedores.Name = "lblTituloProveedores";
            lblTituloProveedores.Size = new Size(149, 60);
            lblTituloProveedores.TabIndex = 2;
            lblTituloProveedores.Text = "Gestionar y registrar\nla información de los\nproveedores.";
            lblTituloProveedores.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(660, 249);
            btnProductos.Margin = new Padding(3, 4, 3, 4);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(189, 213);
            btnProductos.TabIndex = 5;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(461, 249);
            btnReportes.Margin = new Padding(3, 4, 3, 4);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(167, 213);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnMovientos
            // 
            btnMovientos.Location = new Point(248, 249);
            btnMovientos.Margin = new Padding(3, 4, 3, 4);
            btnMovientos.Name = "btnMovientos";
            btnMovientos.Size = new Size(176, 213);
            btnMovientos.TabIndex = 3;
            btnMovientos.Text = "Movientos";
            btnMovientos.UseVisualStyleBackColor = true;
            btnMovientos.Click += btnMovientos_Click;
            // 
            // btnProveedores
            // 
            btnProveedores.Location = new Point(37, 249);
            btnProveedores.Margin = new Padding(3, 4, 3, 4);
            btnProveedores.Name = "btnProveedores";
            btnProveedores.Size = new Size(174, 213);
            btnProveedores.TabIndex = 2;
            btnProveedores.Text = "Proveedores";
            btnProveedores.UseVisualStyleBackColor = true;
            btnProveedores.Click += btnProveedores_Click;
            // 
            // lblSeleccion
            // 
            lblSeleccion.AutoSize = true;
            lblSeleccion.Location = new Point(37, 92);
            lblSeleccion.Name = "lblSeleccion";
            lblSeleccion.Size = new Size(224, 20);
            lblSeleccion.TabIndex = 1;
            lblSeleccion.Text = "Seleccione una opción del menú";
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Segoe UI Light", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(19, 24);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(165, 41);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido!";
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 615);
            Controls.Add(pnlContenido);
            Controls.Add(pnlMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGI-Menu Principal";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            pnlContenido.ResumeLayout(false);
            pnlContenido.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private RadioButton rdoAyuda;
        private RadioButton rdoReportes;
        private RadioButton rdoProductos;
        private RadioButton rdoMovientos;
        private RadioButton rdoProveedores;
        private Panel pnlContenido;
        private Label lblBienvenido;
        private Button btnProveedores;
        private Label lblSeleccion;
        private Button btnReportes;
        private Button btnMovientos;
        private Button btnProductos;
        private Label lblTituloProveedores;
        private Label lblTituloProductos;
        private Label lblTituloReportes;
        private Label lblTituloMovimientos;
    }
}
