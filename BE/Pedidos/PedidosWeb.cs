using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Pedidos
{
    public class PedidosWeb
    {
        public PedidosWeb()
        { }
        public virtual int PEDIDOSWEBID { get; set; }
        public virtual int PERSONASID { get; set; }
        public virtual int FECHAPEDIDO { get; set; }
        public virtual double TOTALPEDIDO { get; set; }
        public virtual int PEDIDOSESTADOID { get; set; }
        public virtual string USUARIO { get; set; }
        public virtual string NOMBRE { get; set; }
        public virtual Decimal PORCDESCUENTO { get; set; }
        public virtual int DESCUENTOSID { get; set; }
        public virtual Decimal IMPORTEDESCUENTO { get; set; }
        public virtual int PEDIDOSORIGENID { get; set; }
        public virtual int PEDIDOSID { get; set; }
        //public virtual System.Guid ROWGUID { get; set; }
        public virtual DateTime? FechaPedidoS { get; set; }
        public virtual string COMENTARIO { get; set; }
        public virtual Pedidos.Personas Persona { get; set; }
        public virtual List<PedidosWebDetalle> PedidosWebDetalle { get; set; }
        public virtual List<PedidosWebFormasPago> PedidosWebFormaPago { get; set; }
        public virtual PedidosWebArchivos PedidosWebArchivos { get; set; }        
    }
}
