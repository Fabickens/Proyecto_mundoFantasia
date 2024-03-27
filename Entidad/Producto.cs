using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set;}
        public decimal Precio { get; set; }
        public string Categoria { get; set; }
        public int Stock { get; set; }
        public string Proveedor { get; set; }
    }
}
