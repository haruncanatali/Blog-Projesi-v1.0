using BlogUygulamasi.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Business.ValidationTools.FluentValidation
{
    public class YorumValidator:AbstractValidator<Yorum>
    {
        public YorumValidator()
        {
            RuleFor(c => c.YorumAd).Length(0,100).WithMessage("Adınız 100 karakterden fazla olmamalı.").NotEmpty().WithMessage("Lütfen adınızı giriniz");
            RuleFor(c => c.YorumSoyad).Length(0,100).WithMessage("Soyadınız 100 karakterden fazla olmamalı.").NotEmpty().WithMessage("Lütfen soyadınızı giriniz");
            RuleFor(c => c.YorumMail).Length(0,100).WithMessage("Mailiniz 100 karakterden fazla olmamalı.").NotEmpty().WithMessage("Lütfen mailinizi giriniz");
            RuleFor(c => c.YorumIcerik).Length(0,1500).WithMessage("İçerik alanı 1500 karakterden fazla olmamalı.").NotEmpty().WithMessage("Lütfen yorum içeriğini giriniz");
            RuleFor(c => c.YorumTarih).NotEmpty().WithMessage("Sistem yorum tarihini alamıyor! Daha sonra tekrar yorum yapmayı deneyiniz!!!!!");
            RuleFor(c => c.YaziId).NotEmpty().WithMessage("Sistemsel hata var! lütfen daha sonra yorum yapmayı deneyiniz!!!!!");
        }
    }

}
