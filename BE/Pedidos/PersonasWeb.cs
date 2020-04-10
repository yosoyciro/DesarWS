using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Pedidos
{
    public class PersonasWeb
    {
        public PersonasWeb()
        { }
        public virtual int PersonasWebId { get; set; }
        public virtual int CODIGODOCUMENTO { get; set; }
        public virtual double NRODOCUMENTO { get; set; }
        public virtual string NOMBRE { get; set; }
        public virtual string DIRECCION1 { get; set; }
        public virtual string DIRECCION2 { get; set; }
        public virtual string TELEFONO1 { get; set; }
        public virtual string TELEFONO2 { get; set; }
        public virtual string MAIL { get; set; }
        public virtual DateTime FECHANACIMIENTO { get; set; }
        public virtual int LOCALIDADESID { get; set; }
        public virtual int CODIGOSITUACIONIVA { get; set; }
        public virtual int TIPOSPERSONAID { get; set; }
        public virtual Tablas.Localidades Localidad { get; set; }
    }
}
