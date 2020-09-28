using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;

namespace DAL.Mapeos
{
    public class MapPersonasConsulta : ClassMapping<BE.Pedidos.Personas>
    {
        public MapPersonasConsulta()
        {
            Id(x => x.PERSONASID, id =>
            {
                id.Generator(
                    Generators.Identity
                    );
            });
            Property(p => p.NRODOCUMENTO);
            Property(p => p.NOMBRE);
            Property(p => p.DIRECCION1);
        }
    }
}
