using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu_principal
{
    public partial class ucMovimientos : UserControl
    {
        private int idMovimientoSeleccionado = 0;

        private MovimientoDAL movimientoDAL = new MovimientoDAL();
        public ucMovimientos()
        {
            InitializeComponent();
        }

        private void ucMovimientos_Load(object sender, EventArgs e)
        {
            CargarTabla();
            CargarComboBoxes();
        }
        private void CargarComboBoxes()
        {
            try
            {
                // Cargar ComboBox de Tipo de Movimiento
                cmbTipomov.DataSource = movimientoDAL.ConsultarTipos();
                cmbTipomov.DisplayMember = "Descripcion"; // Muestra 'Entrada', 'Salida', etc.
                cmbTipomov.ValueMember = "IdTipoMovimiento";

                // Cargar ComboBox de Proveedor
                cmbIdProveedor.DataSource = movimientoDAL.ConsultarProveedores();
                cmbIdProveedor.DisplayMember = "Empresa"; // Muestra 'Distribuidora San Martin', etc.
                cmbIdProveedor.ValueMember = "IdProveedor";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar combos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CargarTabla()
        {
            try
            {
                dgvProveedor.DataSource = null;
                dgvProveedor.Columns.Clear();
                dgvProveedor.AutoGenerateColumns = true;
                dgvProveedor.DataSource = movimientoDAL.ConsultarMovimientos();

                // --- Pulido Visual y UX del DataGridView ---
                dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Ajusta las columnas al ancho total
                dgvProveedor.ReadOnly = true;                                            // Bloquea la edición directa en celdas
                dgvProveedor.AllowUserToAddRows = false;                                 // Elimina la fila vacía con el asterisco (*)
                dgvProveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;   // Selecciona la fila completa al hacer clic
                dgvProveedor.MultiSelect = false;                                        // Evita seleccionar múltiples filas a la vez
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al cargar datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            try
            {
                // 1. Validar selección en ComboBoxes
                if (cmbTipomov.SelectedValue == null || cmbIdProveedor.SelectedValue == null)
                {
                    MessageBox.Show("Por favor seleccione un Tipo de Movimiento y un Proveedor.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Crear objeto Movimiento con los datos de los controles
                Movimiento nuevoMovimiento = new Movimiento
                {
                    IdTipoMovimiento = Convert.ToInt32(cmbTipomov.SelectedValue),
                    fecha = dtpMovimiento.Value,           // Ajusta al Name de tu DateTimePicker
                    Motivo = txtDire.Text.Trim(),   // Ajusta al Name de tu TextBox de Motivo
                    Idproveedor = Convert.ToInt32(cmbIdProveedor.SelectedValue)
                };

                // 3. Insertar en SQL Server a través de la DAL
                if (movimientoDAL.Insertar(nuevoMovimiento))
                {
                    MessageBox.Show("¡Movimiento registrado con éxito!", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTabla();   // Refresca la tabla inmediatamente
                    LimpiarCampos(); // Limpia los controles
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            idMovimientoSeleccionado = 0;
            txtDire.Clear();
            dtpMovimiento.Value = DateTime.Now;
            if (cmbTipomov.Items.Count > 0) cmbTipomov.SelectedIndex = 0;
            if (cmbIdProveedor.Items.Count > 0) cmbIdProveedor.SelectedIndex = 0;
        }

        private void dgvProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvProveedor.Rows[e.RowIndex];
                idMovimientoSeleccionado = Convert.ToInt32(fila.Cells["Id"].Value);
                cmbTipomov.Text = fila.Cells["Tipo de movimiento"].Value.ToString();
                dtpMovimiento.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
                cmbIdProveedor.Text = fila.Cells["Id Proveedor"].Value.ToString();
                txtDire.Text = fila.Cells["Motivo"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idMovimientoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un movimiento de la tabla para editar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idTipo = Convert.ToInt32(cmbTipomov.SelectedValue);
                int idProv = Convert.ToInt32(cmbIdProveedor.SelectedValue);
                DateTime fecha = dtpMovimiento.Value;
                string motivo = txtDire.Text.Trim();

                if (movimientoDAL.EditarMovimiento(idMovimientoSeleccionado, idTipo, fecha, motivo, idProv))
                {
                    MessageBox.Show("Movimiento actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarTabla();
                    LimpiarCampos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idMovimientoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un movimiento de la tabla para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar este movimiento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    if (movimientoDAL.EliminarMovimiento(idMovimientoSeleccionado))
                    {
                        MessageBox.Show("Movimiento eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CargarTabla();
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
    }

}
