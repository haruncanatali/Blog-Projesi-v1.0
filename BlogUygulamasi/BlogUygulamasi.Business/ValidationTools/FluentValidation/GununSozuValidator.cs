using BlogUygulamasi.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogUygulamasi.Business.ValidationTools.FluentValidation
{
    public class GununSozuValidator:AbstractValidator<GununSozu>
    {
        public GununSozuValidator()
        {
            RuleFor(c => c.GununSozuFotoUrl).NotEmpty().WithMessage("Resim bağlantısı olmalıdır.").Length(0,500).WithMessage("Resim bağlantısının max karakteri 500 olmalıdır");
            RuleFor(c => c.GununSozuIcerik).NotEmpty().WithMessage("İçerik alanı boş geçilemez.").Length(0,250).WithMessage("İçerik alanının max karakteri 250 olmalıdır.");
            RuleFor(c => c.GununSozuSahip).NotEmpty().WithMessage("Günün sözününün söyleyeni boş geçilemez.").Length(0,50).WithMessage("Günün sözünün söyleyeninin adı max 50 karakter olmalıdır.");
            RuleFor(c => c.GununSozuTarih).NotEmpty().WithMessage("Günün sözünün tarihi olmalıdır.");
        }

    }
}
