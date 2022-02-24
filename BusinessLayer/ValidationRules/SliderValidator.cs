using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SliderValidator : AbstractValidator<Slider>
    {
        public SliderValidator()
        {
            RuleFor(x => x.SliderTitle).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");
            RuleFor(x => x.SliderTitle).MinimumLength(5).WithMessage("En az 5 karakter girişi yapınız");
            RuleFor(x => x.SliderTitle).MaximumLength(300).WithMessage("En fazla 300 karakter girişi yapınız");

            RuleFor(x => x.SliderDesc).NotEmpty().WithMessage("Bu Alan Boş Bırakılamaz");
            RuleFor(x => x.SliderDesc).MinimumLength(10).WithMessage("En az 10 karakter girişi yapınız");
            RuleFor(x => x.SliderDesc).MaximumLength(750).WithMessage("En fazla 750 karakter girişi yapınız");
        }
    }
}
