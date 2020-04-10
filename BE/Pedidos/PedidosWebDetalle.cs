using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Pedidos
{
    public class PedidosWebDetalle
    {
        public PedidosWebDetalle()
        { }
        public virtual int PEDIDOSWEBDETALLEID { get; set; }
        public virtual int PEDIDOSWEBID { get; set; }
        public virtual double CANTIDAD { get; set; }
        public virtual int ARTICULOSSTOCKID { get; set; }
        public virtual double UNITARIO { get; set; }
        public virtual double TOTAL { get; set; }
        public virtual string OBSERVACIONES { get; set; }
        public virtual double UNITARIOORIGINAL { get; set; }
        public virtual double IMPORTEDESCUENTO { get; set; }
        //public virtual System.Guid ROWGUID { get; set; }
    }
}
