using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapModelos : ClassMapping<BE.Tablas.Modelos>
    {
        public MapModelos()
        {
            Id(x => x.MODELOSID);
            Property(p => p.DESCRIPCION);
            Property(p => p.MARCASID);
            Property(p => p.CATEGORIASID);
        }
    }
}
