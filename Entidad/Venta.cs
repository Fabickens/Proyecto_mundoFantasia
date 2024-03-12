using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Venta
    {
        public int id_venta {  get; set; }
        public Usuario Pusuario { get; set; }
        public string tipoDocumento { get; set; }
        public string numero_documento { get; set; }
        public string nombre_cliente { get; set; }
        public List<detalle_venta> Pdetalle_venta { get; set; }
        public float monto_pago { get; set; }
        public float monto_cambio { get; set; }
        public float total {  get; set; }
        public string fecha_registro { get; set; }
    }
}
