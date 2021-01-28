using BlogUygulamasi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Entities.Concrete
{
    public class GununSozu:IEntity
    {
        public int GununSozuId { get; set; }
        public string GununSozuFotoUrl { get; set; }
        public string GununSozuIcerik { get; set; }
        public string GununSozuSahip{ get; set; }
        public DateTime GununSozuTarih { get; set; }
    }
}
