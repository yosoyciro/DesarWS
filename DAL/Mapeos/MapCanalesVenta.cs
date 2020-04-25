using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapCanalesVenta : ClassMapping<BE.Tablas.CanalesVenta>
    {
        public MapCanalesVenta()
        {
            Id(x => x.CANALESVENTAID);
            Property(p => p.DESCRIPCION);            
        }
    }
}
