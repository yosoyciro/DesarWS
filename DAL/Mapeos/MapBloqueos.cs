using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapBloqueos : ClassMapping<BE.Pedidos.Bloqueos>
    {
        public MapBloqueos()
        {
            Id(x => x.BLOQUEOSID);
            Property(p => p.DESCRIPCION);
        }
    }
}
