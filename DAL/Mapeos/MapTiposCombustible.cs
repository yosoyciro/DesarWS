using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapTiposCombustible : ClassMapping<BE.Tablas.TiposCombustible>
    {
        public MapTiposCombustible()
        {
            Id(x => x.TIPOSCOMBUSTIBLEID);
            Property(p => p.DESCRIPCION);
        }
    }
}
