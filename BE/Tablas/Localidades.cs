using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class Localidades
    {
        public Localidades()
        { }
        public virtual int LOCALIDADESID { get; set; }
        public virtual string NOMBRE { get; set; }
        public virtual int PROVINCIASID { get; set; }
    }
}
