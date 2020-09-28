using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Pedidos
{
    public class PersonasConsulta
    {
        public virtual int PERSONASID { get; set; }
        public virtual double NRODOCUMENTO { get; set; }
        public virtual string NOMBRE { get; set; }
        public virtual string DIRECCION1 { get; set; }        
    }
}
