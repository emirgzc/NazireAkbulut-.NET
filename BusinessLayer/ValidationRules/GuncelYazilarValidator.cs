using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class GuncelYazilarValidator : AbstractValidator<GuncelYazilar>
    {
        public GuncelYazilarValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("En az 5 karakter girişi yapınız");
            RuleFor(x => x.Title).MaximumLength(300).WithMessage("En fazla 300 karakter girişi yapınız");
        }
    }

}
