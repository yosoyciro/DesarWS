using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapCanalesVentaForPag : ClassMapping<BE.Tablas.CanalesVentaForPag>
    {
        public MapCanalesVentaForPag()
        {
            Id(x => x.CANALESVENTAFORPAGID);
            Property(p => p.CANALESVENTAID);
            Property(p => p.FORMASPAGOID);
        }
    }
}
