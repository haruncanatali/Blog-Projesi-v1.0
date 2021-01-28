using BlogUygulamasi.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Business.ValidationTools.FluentValidation
{
    public class KategoriValidator:AbstractValidator<Kategori>
    {
        public KategoriValidator()
        {
            RuleFor(c => c.KategoriAd).NotEmpty().WithMessage("Kategori adı alanı boş geçilemez.").Length(0,60).WithMessage("Kategori adı alanı karakter sınırı:60");
            RuleFor(c => c.KategoriAciklama).NotEmpty().WithMessage("Kategori aciklama alani boş geçilemez.").Length(0,2500).WithMessage("Kategori aciklama alanı max karekter sınırı:2500");
        }

    }
}
