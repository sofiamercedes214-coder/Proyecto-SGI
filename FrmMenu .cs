using Menu_principal;

namespace FrmMenuPrincipal
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }
        private void btnMenuProductos_Click(object sender, EventArgs e)
        {
           ucProductos ucp = new ucProductos();
            ucp.Dock = DockStyle.Fill;
            pnlBienvenida.Controls.Clear();
            pnlBienvenida.Controls.Add(ucp);
            pnlBienvenida.Tag = ucp;
            ucp .Show();
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
           ucMovimientos ucm = new ucMovimientos();
            ucm.Dock = DockStyle.Fill;
           pnlBienvenida.Controls.Clear();
            pnlBienvenida.Controls.Add(ucm);
            pnlBienvenida.Tag = ucm;
            ucm.Show();

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo de Reportes");
        }

        private void rdoAyuda_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void pnlTop_Paint(object sender, PaintEventArgs e) 
        {
        }
        private void btnMenuProveedores_Click(object sender, EventArgs e)
        {
            
            ucProveedor uc = new ucProveedor();
            uc.Dock = DockStyle.Fill;
            pnlBienvenida.Controls.Clear();
            pnlBienvenida.Controls.Add(uc);
            pnlBienvenida.Tag = uc;
            uc.Show();
        } 
        private void lblCardProveedores_Click(object sender, EventArgs e) 
        { pnlBienvenida.Controls.Clear(); var uc = new ucProveedor(); uc.Dock = DockStyle.Fill; pnlBienvenida.Controls.Add(uc); }
    }

}



