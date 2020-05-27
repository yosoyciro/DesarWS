using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Tablas
{
    public class Vehiculos
    {
        public Vehiculos()
        { }
        public virtual int VEHICULOSID { get; set; }
        public virtual string DESCRIPCION { get; set; }
        public virtual int MARCASID { get; set; }
        public virtual int MODELOSID { get; set; }
        public virtual int ANIO { get; set; }
        public virtual byte PUERTAS { get; set; }
        public virtual string PATENTE { get; set; }
        public virtual string CHASIS { get; set; }
        public virtual string MOTOR { get; set; }
        public virtual string PROPIETARIO { get; set; }
        public virtual int COLORESID { get; set; }
        public virtual int FORMULARIO04DID { get; set; }
        public virtual int FECHAPEDIDO04D { get; set; }
        public virtual int FECHAINGRESOUNIDAD { get; set; }
        public virtual int FECHADESPIECE { get; set; }
        public virtual int COMPANIASID { get; set; }
        public virtual double COSTORECUPERO { get; set; }
        public virtual int FECHAPAGORECUPERO { get; set; }
        public virtual int NUMEROCERTIFICADOBAJA { get; set; }
        public virtual string OBSERVACIONES { get; set; }
        public virtual int MARCASCHASISID { get; set; }
        public virtual int MARCASMOTORESID { get; set; }
        public virtual string TIPOCOMBUSTIBLE { get; set; }
        public virtual int VEHICULOSTIPOID { get; set; }
        public virtual byte IMPRESO { get; set; }
        public virtual int LIBROSID { get; set; }
        public virtual int DEPOSITOSID { get; set; }
        public virtual string NROSINIESTRO { get; set; }
        public virtual int EMPLEADOSID { get; set; }
        public virtual byte PARACOMPACTAR { get; set; }
        public virtual int FECHACOMPACTACION { get; set; }
        public virtual int VEHICULOSCOMPACTADOSID { get; set; }
        public virtual int FACTURARECUPERO { get; set; }
        public virtual int CATEGORIASID { get; set; }
        public virtual string TIPOTRANSMISION { get; set; }
        public virtual int TIPOSCOMBUSTIBLEID { get; set; }
        public virtual int FECHABAJADNRPA { get; set; }
    }
}
