using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class ArticulosAsociados
    {
        public ArticulosAsociados()
        { }
        public virtual int ARTICULOSASOCIADOSID { get; set; }
        public virtual int ARTICULOSID { get; set; }
        public virtual int ARTICULOSIDASOCIADO { get; set; }
    }
}
