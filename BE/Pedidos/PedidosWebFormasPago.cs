using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Pedidos
{
    public class PedidosWebFormasPago
    {
        public PedidosWebFormasPago()
        { }
        public virtual int PEDIDOSWEBFORMASPAGOID { get; set; }
        public virtual int PEDIDOSWEBID { get; set; }
        public virtual int FORMASPAGOID { get; set; }
        public virtual Decimal IMPORTE { get; set; }
    }
}
