using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("En az 5 karakter girişi yapınız");
            RuleFor(x => x.Title).MaximumLength(250).WithMessage("En az 250 karakter girişi yapınız");

            RuleFor(x => x.Desc).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");
            RuleFor(x => x.Desc).MinimumLength(5).WithMessage("En az 5 karakter girişi yapınız");
        }
    }
}
