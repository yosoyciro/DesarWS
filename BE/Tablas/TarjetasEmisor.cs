using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class TarjetasEmisor
    {
        public virtual int TARJETASEMISORID { get; set; }
        public virtual string DESCRIPCION { get; set; }
        public virtual byte ESBANCO { get; set; }
    }
}
