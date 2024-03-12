using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Compra
    {
        public int id_compra { get; set; }
        public Usuario Pusuario { get; set; }
        public Proveedor Sproveedor { get; set; }
        public string tipoDocumento { get; set; }
        public string numero_Documento { get; set; }
        public float total {  get; set; }
        public List<detalle_compra> PdetalleCompra {  get; set; }
        public string fecha_registro {  get; set; }

    }
}
