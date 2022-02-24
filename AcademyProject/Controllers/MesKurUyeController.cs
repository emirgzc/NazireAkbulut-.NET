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
	public class MesKurUyeController : Controller
	{
		MesKurUyeValidator validationRules = new MesKurUyeValidator();
		MesKurUyeManager mm = new MesKurUyeManager(new EfMesKurUyeDal());
		[AllowAnonymous]
		public ActionResult Index()
		{
			var meskurlist = mm.GetAll();
			return View(meskurlist);
		}
		public ActionResult MesKurUyeList()
		{
			var adlist = mm.GetAll();
			return View(adlist);
		}
		[HttpGet]
		public ActionResult AAddMesKurUye()
		{
			return View();
		}
		[HttpPost]
		[ValidateInput(false)]
		public ActionResult AAddMesKurUye(MesKurUye a)
		{
			ValidationResult result = validationRules.Validate(a);

			if (result.IsValid)
			{
				a.Status = true;
				mm.MeskurUyeAdd(a);
				return RedirectToAction("MesKurUyeList");
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
		public ActionResult AMesKurUyeUpdate(int id)
		{
			var idad = mm.GetByID(id);
			return View(idad);
		}
		[HttpPost]
		[ValidateInput(false)]
		public ActionResult AMesKurUyeUpdate(MesKurUye a)
		{
			ValidationResult result = validationRules.Validate(a);

			if (result.IsValid)
			{
				a.Status = true;
				mm.MeskurUyeUpdate(a);
				return RedirectToAction("MesKurUyeList");
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
		public ActionResult AMesKurUyeDelete(int id)
		{
			var idd = mm.GetByID(id);
			mm.MeskurUyeDelete(idd);
			return RedirectToAction("MesKurUyeList");
		}
	}
}