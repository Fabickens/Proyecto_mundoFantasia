using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Cedula { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public decimal Salario { get; set; }
        public string AreaTrabajo { get; set; }
    }
}
