using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Proveedor
    {
        public int id_proveedor {  get; set; }
        public string correo {  get; set; }
        public string telefono { get; set; }
        public bool estado { get; set; }
        public string fecha_registro { get; set; }

    }
}
