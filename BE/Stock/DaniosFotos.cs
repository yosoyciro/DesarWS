using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE.Stock
{
    public class DaniosFotos
    {
        public virtual int DANIOSFOTOSID { get; set; }
        public virtual int DANIOSID { get; set; }
        public virtual int SECUENCIA { get; set; }
        public virtual Byte[] FOTO { get; set; }
    }
}
