using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapMarcas : ClassMapping<BE.Tablas.Marcas>
    {
        public MapMarcas()
        {
            Id(x => x.MARCASID);
            Property(p => p.DESCRIPCION);
        }
    }
}
