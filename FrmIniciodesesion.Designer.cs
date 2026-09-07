namespace Menu_principal
{
    partial class FrmIniciodesesion
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
            lblTituloLogin = new Label();
            lblTL = new Label();
            txtUsuario = new TextBox();
            lblContraseña = new Label();
            txtConstraseña = new TextBox();
            btnInicio = new Button();
            SuspendLayout();
            // 
            // lblTituloLogin
            // 
            lblTituloLogin.AutoSize = true;
            lblTituloLogin.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTituloLogin.ForeColor = SystemColors.ControlLightLight;
            lblTituloLogin.Location = new Point(360, 75);
            lblTituloLogin.Name = "lblTituloLogin";
            lblTituloLogin.Size = new Size(379, 33);
            lblTituloLogin.TabIndex = 1;
            lblTituloLogin.Text = "Sistema de control de inventario ";
            lblTituloLogin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTL
            // 
            lblTL.AutoSize = true;
            lblTL.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTL.ForeColor = Color.White;
            lblTL.Location = new Point(401, 150);
            lblTL.Name = "lblTL";
            lblTL.Size = new Size(109, 33);
            lblTL.TabIndex = 2;
            lblTL.Text = "Usuario ";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(401, 199);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(296, 30);
            txtUsuario.TabIndex = 3;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblContraseña.ForeColor = Color.White;
            lblContraseña.Location = new Point(401, 262);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(140, 33);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña";
            // 
            // txtConstraseña
            // 
            txtConstraseña.Location = new Point(401, 298);
            txtConstraseña.Name = "txtConstraseña";
            txtConstraseña.Size = new Size(296, 30);
            txtConstraseña.TabIndex = 5;
            // 
            // btnInicio
            // 
            btnInicio.BackColor = Color.White;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnInicio.ForeColor = Color.Black;
            btnInicio.Location = new Point(422, 385);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(255, 42);
            btnInicio.TabIndex = 6;
            btnInicio.Text = "Iniciar Sesion ";
            btnInicio.UseVisualStyleBackColor = false;
            // 
            // FrmIniciodesesion
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(1100, 495);
            Controls.Add(btnInicio);
            Controls.Add(txtConstraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(lblTL);
            Controls.Add(lblTituloLogin);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(128, 64, 64);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "FrmIniciodesesion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SGI-Inicio de sesion ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTituloLogin;
        private Label lblTL;
        private TextBox txtUsuario;
        private Label lblContraseña;
        private TextBox txtConstraseña;
        private Button btnInicio;
    }
}