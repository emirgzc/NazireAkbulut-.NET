﻿using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
	public class KitapValidator : AbstractValidator<Kitap>
	{
		public KitapValidator()
		{
			RuleFor(x => x.KitapTitle).MinimumLength(2).WithMessage("En az 2 karakter girişi yapınız");
			RuleFor(x => x.KitapTitle).MaximumLength(300).WithMessage("En fazla 300 karakter girişi yapınız");
		}
	}
}
