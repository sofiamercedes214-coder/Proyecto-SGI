using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_principal
{
    public class Movimiento
    {
        public int IdMovimiento { get; set; }
        public int IdTipoMovimiento { get; set; }
        public DateTime fecha { get; set; }
        public string Motivo { get; set; } = String.Empty;
        public int Idproveedor { get; set; }

    }
}
