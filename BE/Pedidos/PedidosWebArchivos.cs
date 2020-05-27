using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Pedidos
{
    public class PedidosWebArchivos
    {
        public PedidosWebArchivos()
        { }
        public virtual int PEDIDOSWEBARCHIVOSID { get; set; }
        public virtual int PEDIDOSWEBID { get; set; }
        public virtual string TIPO { get; set; }
        public virtual string NOMBREARCHIVO { get; set; }
        public virtual Byte[] ARCHIVO { get; set; }
    }
}
