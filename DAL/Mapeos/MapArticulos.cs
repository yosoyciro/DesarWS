using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapArticulos : ClassMapping<BE.Tablas.Articulos>
    {
        public MapArticulos()
        {
            Id(x => x.ARTICULOSID);
            Property(p => p.CODIGOARTICULO);
            Property(p => p.DESCRIPCION);
            Property(p => p.USAREN04D);
        }
    }
}
