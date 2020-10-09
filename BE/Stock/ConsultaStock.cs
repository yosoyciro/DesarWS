using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Stock
{
    public class ConsultaStock
    {
        public ConsultaStock()
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
        public virtual string Color { get; set; }
        public virtual string TipoCombustible { get; set; }
        public virtual string TipoCaja { get; set; }
        public virtual string Categoria { get; set; }
        public virtual decimal PrecioVenta { get; set; }
        public virtual string Patente { get; set; }
        public virtual int ArticulosId { get; set; }
        public virtual int VehiculosId { get; set; }
        public virtual int EstadosId { get; set; }
        public virtual int SectoresId { get; set; }
        public virtual string Ubicacion { get; set; }
    }
}
