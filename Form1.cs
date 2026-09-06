namespace FrmMenuPrincipal
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de Proveedores");
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de Productos");
        }

        private void btnMovientos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de Movimientos");

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de Reportes");
        }

        private void rdoAyuda_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoAyuda.Checked)
            {
                MessageBox.Show("Sistema de Control de Inventario");
            }
        }
    }
}



