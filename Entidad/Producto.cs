using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        public int id_producto {  get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public Categoria Pcategoria { get; set; }
        public int disponibles { get; set; }
        public float precioCompra {  get; set; }
        public float precioVenta { get; set; }
        public string fecha_registro { get; set; }
    }
}
