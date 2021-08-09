using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Stock
{
    public class Legajos
    {
        public Legajos() 
        {
            LegajoImagenes = new List<LegajoImagen>();
        }
        public virtual string Patente { get; set; }
        public virtual List<LegajoImagen> LegajoImagenes { get; set; }
    }
}
