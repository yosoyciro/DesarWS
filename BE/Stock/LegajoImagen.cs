using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Stock
{
    public class LegajoImagen
    {
        public LegajoImagen() { }
        public virtual string NombreArchivo { get; set; }
        public virtual byte[] Imagen { get; set; }
    }
}
