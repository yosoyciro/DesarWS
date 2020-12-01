using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;

namespace DAL.Mapeos
{
    public class MapLocalidades : ClassMapping<BE.Tablas.Localidades>
    {
        public MapLocalidades()
        {
            Id(x => x.LOCALIDADESID, id =>
            {
                id.Generator(
                    Generators.Identity
                    );
            });
            Property(p => p.NOMBRE);
            Property(p => p.PROVINCIASID);
            Property(p => p.CP);
        }
    }
}
