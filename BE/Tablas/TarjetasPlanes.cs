using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class TarjetasPlanes
    {
        public virtual int TARJETASPLANESID { get; set; }
        public virtual string DESCRIPCION { get; set; }
        public virtual byte ACTIVO { get; set; }
        public virtual Decimal PORCENTAJERECARGO { get; set; }
    }
}
