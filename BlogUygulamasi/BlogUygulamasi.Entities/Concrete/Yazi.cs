using BlogUygulamasi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Entities.Concrete
{
    public class Yazi:IEntity
    {
        public int YaziId { get; set; }
        public string YaziBaslik { get; set; }
        public string YaziResimUrl { get; set; }
        public string YaziIcerik { get; set; }
        public string YaziYazar { get; set; }
        public DateTime YaziTarih { get; set;}

        public int KategoriId { get; set;} // foreign key

        public virtual Kategori Kategori { get; set; }
        public virtual ICollection<Yorum> Yorumlar{ get; set; }
    }
}
