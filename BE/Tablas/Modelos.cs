using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class Modelos
    {
        public Modelos()
        { }
        public virtual int MODELOSID { get; set; }
        public virtual string DESCRIPCION { get; set; }
        public virtual int MARCASID { get; set; }
        public virtual int CATEGORIASID { get; set; }
    }
}
