using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class MakalelerValidator : AbstractValidator<Makale>
    {
        public MakalelerValidator()
        {
            RuleFor(x => x.MakaleTitle).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");
            RuleFor(x => x.MakaleTitle).MinimumLength(5).WithMessage("En az 5 karakter girişi yapınız");
            RuleFor(x => x.MakaleTitle).MaximumLength(300).WithMessage("En fazla 300 karakter girişi yapınız");
        }
    }
}
