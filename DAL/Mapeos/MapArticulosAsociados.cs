using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapArticulosAsociados : ClassMapping<BE.Tablas.ArticulosAsociados>
    {
        public MapArticulosAsociados()
        {
            Id(x => x.ARTICULOSASOCIADOSID);
            Property(p => p.ARTICULOSID);
            Property(p => p.ARTICULOSIDASOCIADO);
        }
    }
}
