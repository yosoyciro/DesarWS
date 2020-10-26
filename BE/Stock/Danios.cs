using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Stock
{
    public class Danios
    {
        public virtual int DANIOSID { get; set; }
        public virtual int TIPOSDANIOID { get; set; }
        public virtual string OBSERVACIONES { get; set; }
        //public virtual List<DaniosFotos> DaniosFotos { get; set; }
    }
}
