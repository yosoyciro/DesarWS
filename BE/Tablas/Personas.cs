using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class Personas
    {
        public Personas()
        { }
        public virtual int PERSONASID { get; set; }
        public virtual string NOMBRE { get; set; }
        public virtual string DIRECCION1 { get; set; }
        public virtual string DIRECCION2 { get; set; }
        public virtual string TELEFONO1 { get; set; }
        public virtual string TELEFONO2 { get; set; }
        public virtual string MAIL { get; set; }
        public virtual string CUIT { get; set; }
        public virtual int FECHANACIMIENTO { get; set; }
        public virtual int LOCALIDADESID { get; set; }
        public virtual int SITUACIONIVAID { get; set; }
        public virtual int TIPOSDOCUMENTOID { get; set; }
        public virtual string OBSERVACIONES { get; set; }
        public virtual string TIPOPERSONA { get; set; }
        public virtual double NRODOCUMENTO { get; set; }
        public virtual int TIPOSPERSONAID { get; set; }
        public virtual byte TIENECTACTE { get; set; }
        public virtual string ESTADOCTACTE { get; set; }
        public virtual int DIASVENCIMIENTOFACTURA { get; set; }
        public virtual Decimal DESCUENTO { get; set; }
        public virtual int BLOQUEOSID { get; set; }
        public virtual string SEXO { get; set; }
    }
}
