using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class EditorValidator : AbstractValidator<Editorluk>
	{
		public EditorValidator()
		{
			RuleFor(x => x.EditTitle).MinimumLength(2).WithMessage("En az 2 karakter girişi yapınız");
			RuleFor(x => x.EditTitle).MaximumLength(300).WithMessage("En fazla 300 karakter girişi yapınız");
		}
	}
}
