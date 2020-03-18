using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapVehiculosTipo : ClassMapping<BE.Tablas.VehiculosTipo>
    {
        public MapVehiculosTipo()
        {
            Id(x => x.VEHICULOSTIPOID);
            Property(p => p.DESCRIPCION);
        }
    }
}
