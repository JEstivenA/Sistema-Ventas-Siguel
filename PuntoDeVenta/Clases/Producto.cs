using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PuntoDeVenta.Clases
{
    class Producto
    {
        public int CodigoBarra { get; set; }

        public String Nombre { get; set; }

        public String Proveedor { get; set; }

        public String Descripcion { get; set; }

        public double Precio { get; set; }

        public int Cantidad { get; set; }
    }
}
