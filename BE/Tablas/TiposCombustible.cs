using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class TiposCombustible
    {
        public TiposCombustible()
        { }
        public virtual int TIPOSCOMBUSTIBLEID { get; set; }
        public virtual string DESCRIPCION { get; set; }
    }
}
