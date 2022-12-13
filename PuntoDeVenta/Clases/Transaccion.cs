using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Clases
{
    class Transaccion
    {

        public int TransaccionId { get; set; }
        public DateTime FechaTransaccion { get; set; }
        public String TipoPago { get; set; }
        public List<Producto> CarritoDeProductos { get; set; } = new List<Producto>();

    }
}
