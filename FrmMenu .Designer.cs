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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuPrincipal));
            pnlTop = new Panel();
            pnlMenu = new Panel();
            btnStock = new Button();
            btnResumendemov = new Button();
            btnCostopormov = new Button();
            button2 = new Button();
            btnAyuda = new Button();
            btnMenuProductos = new Button();
            btnMovimientos = new Button();
            btnMenuProveedores = new Button();
            pnlBienvenida = new Panel();
            label1 = new Label();
            lblBienvenida = new Label();
            pnlCardMovimientos = new Panel();
            pictureBox4 = new PictureBox();
            lblCardMovimientosDesc = new Label();
            lblCardMovimientos = new Label();
            pnlCardReportes = new Panel();
            pictureBox6 = new PictureBox();
            lblCardReportesDesc = new Label();
            lblCardReportes = new Label();
            pnlCardProductos = new Panel();
            pictureBox2 = new PictureBox();
            lblCardProductosDesc = new Label();
            lblCardProductos = new Label();
            pnlCardProveedores = new Panel();
            pictureBox1 = new PictureBox();
            lblCardProveedoresDesc = new Label();
            lblCardProveedores = new Label();
            pnlContenido = new Panel();
            pnlMenu.SuspendLayout();
            pnlBienvenida.SuspendLayout();
            pnlCardMovimientos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnlCardReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            pnlCardProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            pnlCardProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlContenido.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTop
            // 
            pnlTop.BackColor = Color.FromArgb(128, 64, 64);
            pnlTop.Dock = DockStyle.Top;
            pnlTop.Location = new Point(203, 0);
            pnlTop.Margin = new Padding(4, 3, 4, 3);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(1244, 74);
            pnlTop.TabIndex = 0;
            pnlTop.Paint += pnlTop_Paint;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(128, 64, 64);
            pnlMenu.Controls.Add(btnStock);
            pnlMenu.Controls.Add(btnResumendemov);
            pnlMenu.Controls.Add(btnCostopormov);
            pnlMenu.Controls.Add(button2);
            pnlMenu.Controls.Add(btnAyuda);
            pnlMenu.Controls.Add(btnMenuProductos);
            pnlMenu.Controls.Add(btnMovimientos);
            pnlMenu.Controls.Add(btnMenuProveedores);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 0);
            pnlMenu.Margin = new Padding(4, 3, 4, 3);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(203, 747);
            pnlMenu.TabIndex = 1;
            // 
            // btnStock
            // 
            btnStock.BackColor = Color.FromArgb(128, 64, 64);
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatStyle = FlatStyle.Flat;
            btnStock.Font = new Font("Times New Roman", 13.8F);
            btnStock.ForeColor = SystemColors.ControlLightLight;
            btnStock.Location = new Point(3, 381);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(204, 52);
            btnStock.TabIndex = 12;
            btnStock.Text = " •  Stock";
            btnStock.UseVisualStyleBackColor = false;
            // 
            // btnResumendemov
            // 
            btnResumendemov.BackColor = Color.FromArgb(128, 64, 64);
            btnResumendemov.FlatAppearance.BorderSize = 0;
            btnResumendemov.FlatStyle = FlatStyle.Flat;
            btnResumendemov.Font = new Font("Times New Roman", 13.8F);
            btnResumendemov.ForeColor = SystemColors.ControlLightLight;
            btnResumendemov.Location = new Point(27, 442);
            btnResumendemov.Name = "btnResumendemov";
            btnResumendemov.Size = new Size(204, 52);
            btnResumendemov.TabIndex = 11;
            btnResumendemov.Text = "• movimiento";
            btnResumendemov.UseVisualStyleBackColor = false;
            // 
            // btnCostopormov
            // 
            btnCostopormov.BackColor = Color.FromArgb(128, 64, 64);
            btnCostopormov.FlatAppearance.BorderSize = 0;
            btnCostopormov.FlatStyle = FlatStyle.Flat;
            btnCostopormov.Font = new Font("Times New Roman", 13.8F);
            btnCostopormov.ForeColor = SystemColors.ControlLightLight;
            btnCostopormov.Location = new Point(27, 323);
            btnCostopormov.Name = "btnCostopormov";
            btnCostopormov.Size = new Size(204, 52);
            btnCostopormov.TabIndex = 9;
            btnCostopormov.Text = "• Costo mov";
            btnCostopormov.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 64, 64);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Times New Roman", 13.8F);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(-4, 269);
            button2.Name = "button2";
            button2.Size = new Size(204, 52);
            button2.TabIndex = 8;
            button2.Text = "• Reportes";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnAyuda
            // 
            btnAyuda.BackColor = Color.FromArgb(128, 64, 64);
            btnAyuda.FlatAppearance.BorderSize = 0;
            btnAyuda.FlatStyle = FlatStyle.Flat;
            btnAyuda.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAyuda.ForeColor = SystemColors.ControlLightLight;
            btnAyuda.Location = new Point(-7, 601);
            btnAyuda.Name = "btnAyuda";
            btnAyuda.Size = new Size(204, 52);
            btnAyuda.TabIndex = 7;
            btnAyuda.Text = "• Ayuda";
            btnAyuda.UseVisualStyleBackColor = false;
            // 
            // btnMenuProductos
            // 
            btnMenuProductos.BackColor = Color.FromArgb(128, 64, 64);
            btnMenuProductos.FlatAppearance.BorderSize = 0;
            btnMenuProductos.FlatStyle = FlatStyle.Flat;
            btnMenuProductos.Font = new Font("Times New Roman", 13.8F);
            btnMenuProductos.ForeColor = SystemColors.ControlLightLight;
            btnMenuProductos.Location = new Point(-4, 153);
            btnMenuProductos.Name = "btnMenuProductos";
            btnMenuProductos.Size = new Size(204, 52);
            btnMenuProductos.TabIndex = 6;
            btnMenuProductos.Text = "• Productos";
            btnMenuProductos.UseVisualStyleBackColor = false;
            btnMenuProductos.Click += btnMenuProductos_Click;
            // 
            // btnMovimientos
            // 
            btnMovimientos.BackColor = Color.FromArgb(128, 64, 64);
            btnMovimientos.FlatAppearance.BorderSize = 0;
            btnMovimientos.FlatStyle = FlatStyle.Flat;
            btnMovimientos.Font = new Font("Times New Roman", 13.8F);
            btnMovimientos.ForeColor = SystemColors.ControlLightLight;
            btnMovimientos.Location = new Point(0, 211);
            btnMovimientos.Name = "btnMovimientos";
            btnMovimientos.Size = new Size(204, 52);
            btnMovimientos.TabIndex = 5;
            btnMovimientos.Text = "• Movimientos";
            btnMovimientos.UseVisualStyleBackColor = false;
            btnMovimientos.Click += btnMovimientos_Click;
            // 
            // btnMenuProveedores
            // 
            btnMenuProveedores.BackColor = Color.FromArgb(128, 64, 64);
            btnMenuProveedores.FlatAppearance.BorderSize = 0;
            btnMenuProveedores.FlatStyle = FlatStyle.Flat;
            btnMenuProveedores.Font = new Font("Times New Roman", 13.8F);
            btnMenuProveedores.ForeColor = SystemColors.ControlLightLight;
            btnMenuProveedores.Location = new Point(0, 95);
            btnMenuProveedores.Name = "btnMenuProveedores";
            btnMenuProveedores.Size = new Size(204, 52);
            btnMenuProveedores.TabIndex = 3;
            btnMenuProveedores.Text = " •  Proveedores";
            btnMenuProveedores.UseVisualStyleBackColor = false;
            btnMenuProveedores.Click += btnMenuProveedores_Click;
            // 
            // pnlBienvenida
            // 
            pnlBienvenida.Controls.Add(label1);
            pnlBienvenida.Controls.Add(lblBienvenida);
            pnlBienvenida.Controls.Add(pnlCardMovimientos);
            pnlBienvenida.Controls.Add(pnlCardReportes);
            pnlBienvenida.Controls.Add(pnlCardProductos);
            pnlBienvenida.Controls.Add(pnlCardProveedores);
            pnlBienvenida.Dock = DockStyle.Fill;
            pnlBienvenida.Location = new Point(203, 0);
            pnlBienvenida.Name = "pnlBienvenida";
            pnlBienvenida.Size = new Size(1244, 747);
            pnlBienvenida.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(83, 251);
            label1.Name = "label1";
            label1.Size = new Size(428, 36);
            label1.TabIndex = 8;
            label1.Text = "Seleccione una opcion del menu ";
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(69, 166);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(476, 39);
            lblBienvenida.TabIndex = 7;
            lblBienvenida.Text = "Bienvenido al SGI-Asados Jehova";
            // 
            // pnlCardMovimientos
            // 
            pnlCardMovimientos.Controls.Add(pictureBox4);
            pnlCardMovimientos.Controls.Add(lblCardMovimientosDesc);
            pnlCardMovimientos.Controls.Add(lblCardMovimientos);
            pnlCardMovimientos.Font = new Font("Times New Roman", 13.8F);
            pnlCardMovimientos.Location = new Point(682, 398);
            pnlCardMovimientos.Name = "pnlCardMovimientos";
            pnlCardMovimientos.Size = new Size(239, 316);
            pnlCardMovimientos.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(34, 57);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(171, 140);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // lblCardMovimientosDesc
            // 
            lblCardMovimientosDesc.Location = new Point(30, 216);
            lblCardMovimientosDesc.Name = "lblCardMovimientosDesc";
            lblCardMovimientosDesc.Size = new Size(175, 77);
            lblCardMovimientosDesc.TabIndex = 1;
            lblCardMovimientosDesc.Text = "Registre las entradas y salidas del inventario";
            // 
            // lblCardMovimientos
            // 
            lblCardMovimientos.AutoSize = true;
            lblCardMovimientos.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardMovimientos.Location = new Point(47, 29);
            lblCardMovimientos.Name = "lblCardMovimientos";
            lblCardMovimientos.Size = new Size(140, 25);
            lblCardMovimientos.TabIndex = 0;
            lblCardMovimientos.Text = "Movimientos";
            // 
            // pnlCardReportes
            // 
            pnlCardReportes.Controls.Add(pictureBox6);
            pnlCardReportes.Controls.Add(lblCardReportesDesc);
            pnlCardReportes.Controls.Add(lblCardReportes);
            pnlCardReportes.Font = new Font("Times New Roman", 13.8F);
            pnlCardReportes.Location = new Point(961, 398);
            pnlCardReportes.Name = "pnlCardReportes";
            pnlCardReportes.Size = new Size(237, 316);
            pnlCardReportes.TabIndex = 5;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(33, 60);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(186, 124);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // lblCardReportesDesc
            // 
            lblCardReportesDesc.Location = new Point(33, 212);
            lblCardReportesDesc.Name = "lblCardReportesDesc";
            lblCardReportesDesc.Size = new Size(175, 77);
            lblCardReportesDesc.TabIndex = 1;
            lblCardReportesDesc.Text = "Genere reportes, resumenes y consulte informacion ";
            // 
            // lblCardReportes
            // 
            lblCardReportes.AutoSize = true;
            lblCardReportes.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardReportes.Location = new Point(68, 27);
            lblCardReportes.Name = "lblCardReportes";
            lblCardReportes.Size = new Size(103, 25);
            lblCardReportes.TabIndex = 0;
            lblCardReportes.Text = "Reportes";
            // 
            // pnlCardProductos
            // 
            pnlCardProductos.Controls.Add(pictureBox2);
            pnlCardProductos.Controls.Add(lblCardProductosDesc);
            pnlCardProductos.Controls.Add(lblCardProductos);
            pnlCardProductos.Font = new Font("Times New Roman", 13.8F);
            pnlCardProductos.Location = new Point(386, 398);
            pnlCardProductos.Name = "pnlCardProductos";
            pnlCardProductos.Size = new Size(247, 319);
            pnlCardProductos.TabIndex = 5;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Menu_principal.Properties.Resources.Productos;
            pictureBox2.Location = new Point(17, 55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(209, 152);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // lblCardProductosDesc
            // 
            lblCardProductosDesc.Location = new Point(17, 225);
            lblCardProductosDesc.Name = "lblCardProductosDesc";
            lblCardProductosDesc.Size = new Size(209, 64);
            lblCardProductosDesc.TabIndex = 1;
            lblCardProductosDesc.Text = "Registrar productos y sus categorias";
            // 
            // lblCardProductos
            // 
            lblCardProductos.AutoSize = true;
            lblCardProductos.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardProductos.Location = new Point(75, 27);
            lblCardProductos.Name = "lblCardProductos";
            lblCardProductos.Size = new Size(115, 25);
            lblCardProductos.TabIndex = 0;
            lblCardProductos.Text = "Productos";
            // 
            // pnlCardProveedores
            // 
            pnlCardProveedores.Controls.Add(pictureBox1);
            pnlCardProveedores.Controls.Add(lblCardProveedoresDesc);
            pnlCardProveedores.Controls.Add(lblCardProveedores);
            pnlCardProveedores.Font = new Font("Times New Roman", 13.8F);
            pnlCardProveedores.Location = new Point(83, 398);
            pnlCardProveedores.Name = "pnlCardProveedores";
            pnlCardProveedores.Size = new Size(251, 322);
            pnlCardProveedores.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(187, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblCardProveedoresDesc
            // 
            lblCardProveedoresDesc.Location = new Point(21, 216);
            lblCardProveedoresDesc.Name = "lblCardProveedoresDesc";
            lblCardProveedoresDesc.Size = new Size(226, 87);
            lblCardProveedoresDesc.TabIndex = 1;
            lblCardProveedoresDesc.Text = "Gestionar y registrar la informacion de los proveedores";
            // 
            // lblCardProveedores
            // 
            lblCardProveedores.AutoSize = true;
            lblCardProveedores.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCardProveedores.Location = new Point(45, 29);
            lblCardProveedores.Name = "lblCardProveedores";
            lblCardProveedores.Size = new Size(137, 25);
            lblCardProveedores.TabIndex = 0;
            lblCardProveedores.Text = "Proveedores";
            lblCardProveedores.Click += lblCardProveedores_Click;
            // 
            // pnlContenido
            // 
            pnlContenido.Controls.Add(pnlTop);
            pnlContenido.Controls.Add(pnlBienvenida);
            pnlContenido.Controls.Add(pnlMenu);
            pnlContenido.Dock = DockStyle.Fill;
            pnlContenido.Location = new Point(0, 0);
            pnlContenido.Margin = new Padding(4, 5, 4, 5);
            pnlContenido.Name = "pnlContenido";
            pnlContenido.Size = new Size(1447, 747);
            pnlContenido.TabIndex = 1;
            // 
            // FrmMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1447, 747);
            Controls.Add(pnlContenido);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "FrmMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGI-Menu Principal";
            WindowState = FormWindowState.Maximized;
            Load += FrmMenuPrincipal_Load;
            pnlMenu.ResumeLayout(false);
            pnlBienvenida.ResumeLayout(false);
            pnlBienvenida.PerformLayout();
            pnlCardMovimientos.ResumeLayout(false);
            pnlCardMovimientos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnlCardReportes.ResumeLayout(false);
            pnlCardReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            pnlCardProductos.ResumeLayout(false);
            pnlCardProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            pnlCardProveedores.ResumeLayout(false);
            pnlCardProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlContenido.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTop;
        private Panel pnlMenu;
        private Button btnAyuda;
        private Button btnMenuProductos;
        private Button btnMovimientos;
        private Button button1;
        private Button btnMenuProveedores;
        private Panel pnlBienvenida;
        private Panel pnlCardProveedores;
        private Label lblCardProveedoresDesc;
        private Label lblCardProveedores;
        private Panel pnlContenido;
        private Label lblBienvenida;
        private Panel pnlCardMovimientos;
        private Label lblCardMovimientosDesc;
        private Label lblCardMovimientos;
        private Panel pnlCardReportes;
        private Label lblCardReportesDesc;
        private Label lblCardReportes;
        private Panel pnlCardProductos;
        private PictureBox pictureBox2;
        private Label lblCardProductosDesc;
        private Label lblCardProductos;
        private Label label1;
        private Button button4;
        private Button btnCostopormov;
        private Button button2;
        private Button btnResumendemov;
        private Button btnStock;
        private PictureBox pictureBox1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox6;
    }
}
