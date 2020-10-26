using NHibernate.Mapping.ByCode.Conformist;


namespace DAL.Mapeos
{
    public class MapDaniosFotos : ClassMapping<BE.Stock.DaniosFotos>
    {
        public MapDaniosFotos()
        {
            Id(x => x.DANIOSFOTOSID);
            Property(p => p.DANIOSID);
            Property(p => p.SECUENCIA);
            Property(p => p.FOTO);
        }
    }
}
