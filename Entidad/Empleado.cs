using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Empleado
    {
        public int id_empleado { get; set; }
        public string nombre_completo { get; set; }
        public string cedula {  get; set; }
        public string correo { get; set; }
        public bool estado { get; set; }
        public string fecha_registro { get; set; }
        public string rol {  get; set; }
        public decimal salario { get; set; }
        public string horario { get; set; }
    }
}
