using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using BE.Tablas;

namespace DAL.Mapeos
{
    public class MapTarjetasEmisor : ClassMapping<BE.Tablas.TarjetasEmisor>
    {
        public MapTarjetasEmisor()
        {

            Id(x => x.TARJETASEMISORID, id =>
            {
                id.Generator(
                    Generators.Identity
                    );
            });
            Property(p => p.DESCRIPCION);
            Property(p => p.ESBANCO);
        }
    }
}
