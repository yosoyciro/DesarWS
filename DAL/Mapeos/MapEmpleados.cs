using NHibernate.Mapping.ByCode.Conformist;

namespace DAL.Mapeos
{
    public class MapEmpleados : ClassMapping<BE.Tablas.Empleados>
    {
        public MapEmpleados()
        {
            Id(x => x.EMPLEADOSID);
            Property(p => p.USUARIO);
            Property(p => p.PASSWORD);
        }
    }
}
