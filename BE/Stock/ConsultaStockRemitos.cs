using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Stock
{
    public class ConsultaStockRemitos
    {
        public ConsultaStockRemitos()
        { }
        public virtual int ArticulosStockId { get; set; }
        public virtual string CodigoBarra { get; set; }
        public virtual string Articulo { get; set; }
        public virtual string Marca { get; set; }
        public virtual string Modelo { get; set; }
        public virtual string Descripcion { get; set; }
        public virtual string Motor { get; set; }
        public virtual string TipoVehiculo { get; set; }
        public virtual int Anio { get; set; }
        public virtual string Patente { get; set; }
        public virtual int ArticulosId { get; set; }
        public virtual int VehiculosId { get; set; }
    }
}
