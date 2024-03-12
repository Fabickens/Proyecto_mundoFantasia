using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class detalle_compra
    {
        public int id_detalle {  get; set; }
        public Producto Sproduto { get; set; }
        public float precioCompra { get; set; }
        public float precioVenta { get; set; }
        public int cantidad { get; set; }
        public float total { get; set; }
        public string fecha_registro { get; set; }
    }
}
 