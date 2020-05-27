using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode;
using NHibernate;
using System;


namespace DAL.Mapeos
{
    public class MapPedidosWebArchivos : ClassMapping<BE.Pedidos.PedidosWebArchivos>
    {
        public MapPedidosWebArchivos()
        {
            Id(x => x.PEDIDOSWEBARCHIVOSID, id =>
            {
                id.Generator(
                    Generators.Identity
                    );
            });
            Property(p => p.PEDIDOSWEBID);
            Property(p => p.TIPO);
            Property(p => p.NOMBREARCHIVO);
            Property(p => p.ARCHIVO, map =>
            {
                map.Type(NHibernateUtil.BinaryBlob);
                map.Length(Int32.MaxValue);
            });
        }
    }
}
