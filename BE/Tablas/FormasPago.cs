using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class FormasPago
    {
        public FormasPago()
        { }
        public virtual int FORMASPAGOID { get; set; }
        public virtual string DESCRIPCION { get; set; }
        public virtual byte BAJA { get; set; }
    }
}
