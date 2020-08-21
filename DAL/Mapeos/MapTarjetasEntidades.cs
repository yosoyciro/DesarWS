using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;


namespace DAL.Mapeos
{
    public class MapTarjetasEntidades : ClassMapping<BE.Tablas.TarjetasEntidades>
    {
        public MapTarjetasEntidades()
        {
            Id(x => x.TARJETASENTIDADESID, id =>
            {
                id.Generator(
                    Generators.Identity
                    );
            });
            Property(p => p.DESCRIPCION);
            Property(p => p.ESCREDITO);
        }

    }
}
