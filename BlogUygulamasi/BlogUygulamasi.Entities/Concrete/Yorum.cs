using BlogUygulamasi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Entities.Concrete
{
    public class Yorum:IEntity
    {
        public int YorumId { get; set; }
        public string YorumAd { get; set; }
        public string YorumSoyad { get; set; }
        public string YorumMail { get; set; }
        public string YorumIcerik { get; set; }
        public DateTime YorumTarih { get; set; }

        public int YaziId { get; set; } // foreign key

        public virtual Yazi Yazi{ get; set; }
    }
}
