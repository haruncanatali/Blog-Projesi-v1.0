using BlogUygulamasi.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Business.ValidationTools.FluentValidation
{
    public class AdminValidator:AbstractValidator<Admin>
    {
        public AdminValidator()
        {
            RuleFor(c => c.AdminUsername).NotEmpty().WithMessage("Kullanıcı Adı boş geçilemez").Length(0,10).WithMessage("Kullanıcı adı karakter sınırı:10");
            RuleFor(c => c.AdminPassword).NotEmpty().WithMessage("Kullanıcı şifre boş geçilemez").Length(0,7).WithMessage("Şifre karakter sınırı:7");
        }

    }
}
