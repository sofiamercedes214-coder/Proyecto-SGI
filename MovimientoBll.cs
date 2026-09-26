using System;
using System.Collections.Generic;
using System.Data;

namespace Menu_principal
{
    public class MovimientoBll
    {
        private MovimientoDal dal = new MovimientoDal();

        public List<Movimiento> ObtenerMovimientos()
        {
            return dal.Listar();
        }

        public DataTable ObtenerTipos()
        {
            return dal.ConsultarTipos();
        }

        public DataTable ObtenerProveedores()
        {
            return dal.ConsultarProveedores();
        }

        public bool RegistrarMovimiento(Movimiento mov)
        {
            if (string.IsNullOrWhiteSpace(mov.Motivo))
                throw new Exception("El motivo del movimiento es obligatorio.");

            return dal.Insertar(mov);
        }

        public bool ModificarMovimiento(Movimiento mov)
        {
            if (mov.IdMovimiento <= 0)
                throw new Exception("Seleccione un movimiento válido.");

            return dal.Actualizar(mov);
        }

        public bool BorrarMovimiento(int idMovimiento)
        {
            if (idMovimiento <= 0)
                throw new Exception("Seleccione un movimiento válido.");

            return dal.Eliminar(idMovimiento);
        }
    }
}