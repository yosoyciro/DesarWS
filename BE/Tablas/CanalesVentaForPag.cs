using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class CanalesVentaForPag
    {
        public CanalesVentaForPag()
        { }
        public virtual int CANALESVENTAFORPAGID { get; set; }
        public virtual int CANALESVENTAID { get; set; }
        public virtual int FORMASPAGOID { get; set; }
    }
}
