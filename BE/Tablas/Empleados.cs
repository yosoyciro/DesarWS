using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class Empleados
    {
        public Empleados()
        {   }
        public virtual int EMPLEADOSID { get; set; }
        public virtual string USUARIO { get; set; }
        public virtual string PASSWORD { get; set; }
    }
}
