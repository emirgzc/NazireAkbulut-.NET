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
	public class GazeteDergiController : Controller
	{
		GazeteDergiValidator validationRules = new GazeteDergiValidator();
		GazeteDergiManager gdm = new GazeteDergiManager(new EfGazeteDergiDal());
		[AllowAnonymous]
		public ActionResult Index()
		{
			var gazeteList = gdm.GetAll();
			return View(gazeteList);
		}
		public ActionResult GazeteDergiList()
		{
			var adlist = gdm.GetAll();
			return View(adlist);
		}
		[HttpGet]
		public ActionResult AAddGazeteDergi()
		{
			return View();
		}
		[HttpPost]
		[ValidateInput(false)]
		public ActionResult AAddGazeteDergi(GazeteDergi a)
		{
			ValidationResult result = validationRules.Validate(a);
			if (result.IsValid)
			{
				a.Status = true;
				gdm.GazeteDergiAdd(a);
				return RedirectToAction("GazeteDergiList");
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
		[HttpGet]
		public ActionResult AGazeteDergiUpdate(int id)
		{
			var idad = gdm.GetByID(id);
			return View(idad);
		}
		[HttpPost]
		[ValidateInput(false)]
		public ActionResult AGazeteDergiUpdate(GazeteDergi a)
		{
			ValidationResult result = validationRules.Validate(a);
			if (result.IsValid)
			{
				a.Status = true;
				gdm.GazeteDergiUpdate(a);
				return RedirectToAction("GazeteDergiList");
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
		public ActionResult AGazeteDergiDelete(int id)
		{
			var idd = gdm.GetByID(id);
			gdm.GazeteDergiDelete(idd);
			return RedirectToAction("GazeteDergiList");
		}
	}
}