using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;

namespace DAL.Mapeos
{
    public class MapPersonasWeb : ClassMapping<BE.Pedidos.PersonasWeb>
    {
        public MapPersonasWeb()
        {
            Id(x => x.PersonasWebId, id =>
            {
                id.Generator(
                    Generators.Identity
                    );
            });
            Property(p => p.CODIGODOCUMENTO);
            Property(p => p.NRODOCUMENTO);
            Property(p => p.NOMBRE);
            Property(p => p.DIRECCION1);
            Property(p => p.DIRECCION2);
            Property(p => p.TELEFONO1);
            Property(p => p.TELEFONO2);
            Property(p => p.MAIL);
            Property(p => p.FECHANACIMIENTO);
            Property(p => p.LOCALIDADESID);
            Property(p => p.CODIGOSITUACIONIVA);
            Property(p => p.TIPOSPERSONAID);
            ManyToOne(p => p.Localidad, map =>
            {
                map.Column("LocalidadesId");
                map.Class(typeof(BE.Tablas.Localidades));
                map.Fetch(FetchKind.Join); // or FetchKind.Select
                map.NotNullable(true);
                map.UniqueKey("LocalidadesId");
                map.Lazy(LazyRelation.NoLazy);
            }
            );
        }
    }
}
