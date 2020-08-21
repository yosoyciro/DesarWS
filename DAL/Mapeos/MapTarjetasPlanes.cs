using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;

namespace DAL.Mapeos
{
    public class MapTarjetasPlanes : ClassMapping<BE.Tablas.TarjetasPlanes>
    {
        public MapTarjetasPlanes()
        {
            Id(x => x.TARJETASPLANESID, id =>
            {
                id.Generator(
                    Generators.Identity
                    );
            });
            Property(p => p.DESCRIPCION);
            Property(p => p.ACTIVO);
            Property(p => p.PORCENTAJERECARGO);
        }
    }
}
