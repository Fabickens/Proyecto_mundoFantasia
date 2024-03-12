using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Usuario
    {
        public int id_usuario { get; set; }
        public string nombre_completo { get; set; }
        public string documento {  get; set; }
        public string correo { get; set; }
        public bool estado { get; set; }
        public string fecha_registro { get; set; }
    }
}
