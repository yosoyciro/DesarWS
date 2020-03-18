using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class VehiculosTipo
    {
        public VehiculosTipo()
        { }
        public virtual int VEHICULOSTIPOID { get; set; }
        public virtual string DESCRIPCION { get; set; }
    }
}
