using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapLocalidades : ClassMapping<BE.Tablas.Localidades>
    {
        public MapLocalidades()
        {
            Id(x => x.LOCALIDADESID);
            Property(p => p.NOMBRE);
            Property(p => p.PROVINCIASID);
        }
    }
}
