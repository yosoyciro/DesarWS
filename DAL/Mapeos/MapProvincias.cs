using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapProvincias : ClassMapping<BE.Tablas.Provincias>
    {
        public MapProvincias()
        {
            Id(x => x.PROVINCIASID);
            Property(p => p.NOMBRE);
            Property(p => p.IDPROVINCIAAFIP);
        }
    }
}
