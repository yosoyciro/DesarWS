using NHibernate.Mapping.ByCode.Conformist;


namespace DAL.Mapeos
{
    public class MapDanios : ClassMapping<BE.Stock.Danios>
    {
        public MapDanios()
        {
            Id(x => x.DANIOSID);
            Property(p => p.TIPOSDANIOID);
            Property(p => p.OBSERVACIONES);
        }
    }
}
