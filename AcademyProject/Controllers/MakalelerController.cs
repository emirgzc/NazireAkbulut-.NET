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
	public class MakalelerController : Controller
	{
		MakalelerValidator validationRules = new MakalelerValidator();
		MakaleManager mm = new MakaleManager(new EfMakaleDal());
		[AllowAnonymous]
		public ActionResult Index()
		{
			var makaleList = mm.GetOrderByDate();
			return View(makaleList);
		}
		[AllowAnonymous]
		public PartialViewResult LastMakale()
		{
			var makaleList = mm.GetOrderByDate().Take(3).ToList();
			return PartialView(makaleList);
		}
		public ActionResult MakaleList()
		{
			var adlist = mm.GetOrderByDate();
			return View(adlist);
		}
		[HttpGet]
		public ActionResult AAddMakale()
		{
			return View();
		}
		[HttpPost]
		[ValidateInput(false)]
		public ActionResult AAddMakale(Makale a)
		{
			ValidationResult result = validationRules.Validate(a);
			if (result.IsValid)
			{
				a.MakaleStatus = true;
				a.MakaleDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				mm.MakaleAdd(a);
				return RedirectToAction("MakaleList");
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
		public ActionResult AMakaleUpdate(int id)
		{
			var idad = mm.GetByID(id);
			return View(idad);
		}
		[HttpPost]
		[ValidateInput(false)]
		public ActionResult AMakaleUpdate(Makale a)
		{
			ValidationResult result = validationRules.Validate(a);
			if (result.IsValid)
			{
				a.MakaleStatus = true;
				a.MakaleDate = DateTime.Parse(DateTime.Now.ToShortDateString());
				mm.MakaleUpdate(a);
				return RedirectToAction("MakaleList");
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
		public ActionResult AMakaleDelete(int id)
		{
			var idd = mm.GetByID(id);
			mm.MakaleDelete(idd);
			return RedirectToAction("MakaleList");
		}
	}
}