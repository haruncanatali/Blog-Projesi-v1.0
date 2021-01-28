using BlogUygulamasi.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Entities.Concrete
{
    public class Kategori:IEntity
    {
        public int KategoriId { get; set; }
        public string KategoriAd { get; set; }
        public string KategoriAciklama { get; set; }

        public ICollection<Yazi> Yazilar { get; set; }
    }
}
