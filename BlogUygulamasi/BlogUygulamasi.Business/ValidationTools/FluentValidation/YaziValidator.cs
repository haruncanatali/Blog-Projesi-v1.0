using BlogUygulamasi.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Business.ValidationTools.FluentValidation
{
    public class YaziValidator:AbstractValidator<Yazi>
    {
        public YaziValidator()
        {
            RuleFor(c => c.YaziBaslik).Length(0,100).WithMessage("Yazının başlığı max 100 karakter olmalı.").NotEmpty().WithMessage("Yazı başlığı boş geçilemez.");
            RuleFor(c => c.YaziResimUrl).Length(0,150).WithMessage("Resim bağlantısı max 150 karakter olmalı.").NotEmpty().WithMessage("Resim bağlantısı boş geçilemez.");
            RuleFor(c => c.YaziIcerik).Length(0,20000).WithMessage("İçerik max 20000 karakter olmalı.").NotEmpty().WithMessage("İçerik boş geçilemez.");
            RuleFor(c => c.YaziYazar).Length(0,100).WithMessage("Yazı yazarı max 100 karakter olmalı.").NotEmpty().WithMessage("Yazı yazarı boş geçilemez.");
            RuleFor(c => c.KategoriId).NotEmpty().WithMessage("Kategori seçimi yapılmalıdır.");
            RuleFor(c => c.YaziTarih).NotEmpty().WithMessage("Yazının Tarihi olmalıdır.");
        }

    }
}
