using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Pedidos
{
    public class PedidosWebTarjetasCupones
    {
        public virtual int PEDIDOSWEBTARJETASCUPONESID { get; set; }
        public virtual int TARJETASENTIDADESID { get; set; }
        public virtual int PEDIDOSWEBFORMASPAGOID { get; set; }
        public virtual int NROCUPON { get; set; }
        public virtual Int16 NROTARJETA { get; set; }
        public virtual double IMPORTE { get; set; }
        public virtual int BANCOSID { get; set; }
        public virtual int TARJETASPLANESEMISORID { get; set; }
        public virtual int TARJETASPLANESID { get; set; }
    }
}
