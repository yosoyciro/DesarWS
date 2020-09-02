using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;

namespace DAL.Mapeos
{
    public class MapTarjetasPlanesEmisor : ClassMapping<BE.Tablas.TarjetasPlanesEmisor>
    {
        public MapTarjetasPlanesEmisor()
        {
            Id(x => x.TARJETASPLANESEMISORID, id =>
            {
                id.Generator(
                    Generators.Identity
                    );
            });
            Property(p => p.TARJETASPLANESID);
            Property(p => p.TARJETASENTIDADESID);
            Property(p => p.TARJETASEMISORID);
        }
    }
}
