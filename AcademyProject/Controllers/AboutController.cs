using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcademyProject.Controllers
{
	public class AboutController : Controller
	{
		AboutValidator validationRules = new AboutValidator();
		AboutManager abm = new AboutManager(new EfAboutDal());
		[AllowAnonymous]
		public ActionResult Index()
		{
			var aboutList = abm.GetAll();
			return View(aboutList);
		}
		public ActionResult AAboutList()
		{
			var aboutlist = abm.GetAll();
			return View(aboutlist);
		}
		[HttpGet]
		public ActionResult AAboutUpdate(int id)
		{
			var aboutid = abm.GetByID(id);
			return View(aboutid);
		}
		[HttpPost]
		[ValidateInput(false)]
		public ActionResult AAboutUpdate(About a)
		{
			ValidationResult result = validationRules.Validate(a);

			if (result.IsValid)
			{
				abm.AboutUpdate(a);
				return RedirectToAction("AAboutList");
			}
			else
			{
				foreach (var item in result.Errors)
				{
					ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
				}
			}
			return View();
		}
	}
}