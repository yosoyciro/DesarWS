using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapFormasPago : ClassMapping<BE.Tablas.FormasPago>
    {
        public MapFormasPago()
        {
            Id(x => x.FORMASPAGOID);
            Property(p => p.DESCRIPCION);
            Property(p => p.BAJA);
        }
    }
}
