using NHibernate.Mapping.ByCode.Conformist;


namespace DAL.Mapeos
{
    public class MapDaniosSecuencias : ClassMapping<BE.Stock.DaniosSecuencias>
    {
        public MapDaniosSecuencias()
        {
            Table("DaniosFotos");
            Id(x => x.DANIOSFOTOSID);
            Property(p => p.DANIOSID);
            Property(p => p.SECUENCIA);
        }

    }
}
