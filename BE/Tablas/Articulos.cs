using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class Articulos
    {
        public Articulos()
        { }
        public virtual int ARTICULOSID { get; set; }
        public virtual int CODIGOARTICULO { get; set; }
        public virtual string DESCRIPCION { get; set; }       
        public virtual byte USAREN04D { get; set; }
        public virtual string DESCRIPCIONABREVIADA { get; set; }
    }
}
