namespace Menu_principal
{
    partial class ucResumendemovimientos
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
            dtpHasta = new DateTimePicker();
            dtpFechadesde = new DateTimePicker();
            lblFechahasta = new Label();
            lblFechadesde = new Label();
            pnlCardMovimientos = new Panel();
            lblCardMovimientos = new Label();
            lblCardMovimientosValue = new Label();
            pnlCardEntradas = new Panel();
            lblCardEntradasvalue = new Label();
            lblCardEntradas = new Label();
            pnlCardSalidas = new Panel();
            lblCardSalidasvalue = new Label();
            lblCardSalidas = new Label();
            dgwresumendestock = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colTipo = new DataGridViewTextBoxColumn();
            colCantidad = new DataGridViewTextBoxColumn();
            coDes = new DataGridViewTextBoxColumn();
            btnImprimir = new Button();
            pnlCardMovimientos.SuspendLayout();
            pnlCardEntradas.SuspendLayout();
            pnlCardSalidas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgwresumendestock).BeginInit();
            SuspendLayout();
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(513, 92);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(197, 30);
            dtpHasta.TabIndex = 65;
            // 
            // dtpFechadesde
            // 
            dtpFechadesde.Location = new Point(191, 92);
            dtpFechadesde.Name = "dtpFechadesde";
            dtpFechadesde.Size = new Size(197, 30);
            dtpFechadesde.TabIndex = 64;
            // 
            // lblFechahasta
            // 
            lblFechahasta.AutoSize = true;
            lblFechahasta.Location = new Point(513, 50);
            lblFechahasta.Name = "lblFechahasta";
            lblFechahasta.Size = new Size(61, 22);
            lblFechahasta.TabIndex = 63;
            lblFechahasta.Text = "Hasta:";
            // 
            // lblFechadesde
            // 
            lblFechadesde.AutoSize = true;
            lblFechadesde.BackColor = Color.White;
            lblFechadesde.Location = new Point(191, 53);
            lblFechadesde.Name = "lblFechadesde";
            lblFechadesde.Size = new Size(114, 22);
            lblFechadesde.TabIndex = 62;
            lblFechadesde.Text = "Fecha desde:";
            // 
            // pnlCardMovimientos
            // 
            pnlCardMovimientos.BackColor = Color.FromArgb(128, 64, 64);
            pnlCardMovimientos.Controls.Add(lblCardMovimientosValue);
            pnlCardMovimientos.Controls.Add(lblCardMovimientos);
            pnlCardMovimientos.Location = new Point(142, 187);
            pnlCardMovimientos.Name = "pnlCardMovimientos";
            pnlCardMovimientos.Size = new Size(289, 168);
            pnlCardMovimientos.TabIndex = 66;
            // 
            // lblCardMovimientos
            // 
            lblCardMovimientos.AutoSize = true;
            lblCardMovimientos.Font = new Font("Times New Roman", 13.8F);
            lblCardMovimientos.ForeColor = SystemColors.ControlLightLight;
            lblCardMovimientos.Location = new Point(82, 23);
            lblCardMovimientos.Name = "lblCardMovimientos";
            lblCardMovimientos.Size = new Size(134, 26);
            lblCardMovimientos.TabIndex = 0;
            lblCardMovimientos.Text = "Movimientos";
            // 
            // lblCardMovimientosValue
            // 
            lblCardMovimientosValue.AutoSize = true;
            lblCardMovimientosValue.Font = new Font("Times New Roman", 13.8F);
            lblCardMovimientosValue.ForeColor = SystemColors.ControlLightLight;
            lblCardMovimientosValue.Location = new Point(142, 92);
            lblCardMovimientosValue.Name = "lblCardMovimientosValue";
            lblCardMovimientosValue.Size = new Size(23, 26);
            lblCardMovimientosValue.TabIndex = 1;
            lblCardMovimientosValue.Text = "0";
            // 
            // pnlCardEntradas
            // 
            pnlCardEntradas.BackColor = Color.OliveDrab;
            pnlCardEntradas.Controls.Add(lblCardEntradasvalue);
            pnlCardEntradas.Controls.Add(lblCardEntradas);
            pnlCardEntradas.Location = new Point(551, 187);
            pnlCardEntradas.Name = "pnlCardEntradas";
            pnlCardEntradas.Size = new Size(289, 168);
            pnlCardEntradas.TabIndex = 67;
            // 
            // lblCardEntradasvalue
            // 
            lblCardEntradasvalue.AutoSize = true;
            lblCardEntradasvalue.Font = new Font("Times New Roman", 13.8F);
            lblCardEntradasvalue.ForeColor = SystemColors.ControlLightLight;
            lblCardEntradasvalue.Location = new Point(126, 98);
            lblCardEntradasvalue.Name = "lblCardEntradasvalue";
            lblCardEntradasvalue.Size = new Size(23, 26);
            lblCardEntradasvalue.TabIndex = 1;
            lblCardEntradasvalue.Text = "0";
            // 
            // lblCardEntradas
            // 
            lblCardEntradas.AutoSize = true;
            lblCardEntradas.Font = new Font("Times New Roman", 13.8F);
            lblCardEntradas.ForeColor = SystemColors.ControlLightLight;
            lblCardEntradas.Location = new Point(92, 33);
            lblCardEntradas.Name = "lblCardEntradas";
            lblCardEntradas.Size = new Size(92, 26);
            lblCardEntradas.TabIndex = 0;
            lblCardEntradas.Text = "Entradas";
            // 
            // pnlCardSalidas
            // 
            pnlCardSalidas.BackColor = Color.Gold;
            pnlCardSalidas.Controls.Add(lblCardSalidasvalue);
            pnlCardSalidas.Controls.Add(lblCardSalidas);
            pnlCardSalidas.Location = new Point(941, 187);
            pnlCardSalidas.Name = "pnlCardSalidas";
            pnlCardSalidas.Size = new Size(289, 168);
            pnlCardSalidas.TabIndex = 68;
            // 
            // lblCardSalidasvalue
            // 
            lblCardSalidasvalue.AutoSize = true;
            lblCardSalidasvalue.Font = new Font("Times New Roman", 13.8F);
            lblCardSalidasvalue.ForeColor = SystemColors.ControlLightLight;
            lblCardSalidasvalue.Location = new Point(142, 92);
            lblCardSalidasvalue.Name = "lblCardSalidasvalue";
            lblCardSalidasvalue.Size = new Size(23, 26);
            lblCardSalidasvalue.TabIndex = 1;
            lblCardSalidasvalue.Text = "0";
            // 
            // lblCardSalidas
            // 
            lblCardSalidas.AutoSize = true;
            lblCardSalidas.Font = new Font("Times New Roman", 13.8F);
            lblCardSalidas.ForeColor = SystemColors.ControlLightLight;
            lblCardSalidas.Location = new Point(82, 23);
            lblCardSalidas.Name = "lblCardSalidas";
            lblCardSalidas.Size = new Size(134, 26);
            lblCardSalidas.TabIndex = 0;
            lblCardSalidas.Text = "Movimientos";
            // 
            // dgwresumendestock
            // 
            dgwresumendestock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgwresumendestock.BorderStyle = BorderStyle.Fixed3D;
            dgwresumendestock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwresumendestock.Columns.AddRange(new DataGridViewColumn[] { colId, colTipo, colCantidad, coDes });
            dgwresumendestock.Cursor = Cursors.Cross;
            dgwresumendestock.Location = new Point(161, 443);
            dgwresumendestock.Name = "dgwresumendestock";
            dgwresumendestock.RowHeadersWidth = 51;
            dgwresumendestock.Size = new Size(1047, 324);
            dgwresumendestock.TabIndex = 69;
            // 
            // colId
            // 
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            // 
            // colTipo
            // 
            colTipo.HeaderText = "Fecha";
            colTipo.MinimumWidth = 6;
            colTipo.Name = "colTipo";
            // 
            // colCantidad
            // 
            colCantidad.HeaderText = "Cantidad";
            colCantidad.MinimumWidth = 6;
            colCantidad.Name = "colCantidad";
            // 
            // coDes
            // 
            coDes.HeaderText = "Descripcion";
            coDes.MinimumWidth = 6;
            coDes.Name = "coDes";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.White;
            btnImprimir.ForeColor = Color.Black;
            btnImprimir.Location = new Point(938, 379);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(292, 47);
            btnImprimir.TabIndex = 70;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            // 
            // ucResumendemovimientos
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            Controls.Add(btnImprimir);
            Controls.Add(dgwresumendestock);
            Controls.Add(pnlCardSalidas);
            Controls.Add(pnlCardEntradas);
            Controls.Add(pnlCardMovimientos);
            Controls.Add(dtpHasta);
            Controls.Add(dtpFechadesde);
            Controls.Add(lblFechahasta);
            Controls.Add(lblFechadesde);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucResumendemovimientos";
            Size = new Size(1352, 780);
            pnlCardMovimientos.ResumeLayout(false);
            pnlCardMovimientos.PerformLayout();
            pnlCardEntradas.ResumeLayout(false);
            pnlCardEntradas.PerformLayout();
            pnlCardSalidas.ResumeLayout(false);
            pnlCardSalidas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgwresumendestock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpHasta;
        private DateTimePicker dtpFechadesde;
        private Label lblFechahasta;
        private Label lblFechadesde;
        private Panel pnlCardMovimientos;
        private Label lblCardMovimientos;
        private Label lblCardMovimientosValue;
        private Panel pnlCardEntradas;
        private Label lblCardEntradasvalue;
        private Label lblCardEntradas;
        private Panel pnlCardSalidas;
        private Label lblCardSalidasvalue;
        private Label lblCardSalidas;
        private DataGridView dgwresumendestock;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colTipo;
        private DataGridViewTextBoxColumn colCantidad;
        private DataGridViewTextBoxColumn coDes;
        private Button btnImprimir;
    }
}
