using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class detalle_venta
    {
        public int id_detalleVenta {  get; set; }
        public Producto Sproducto { get; set; }
        public float precioVenta { get; set; }
        public int cantidad { get; set; }
        public float Subtotal { get; set; }
        public string fecha_registro { get; set; }

    }
}
