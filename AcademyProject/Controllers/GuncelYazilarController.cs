using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcademyProject.Controllers
{

	public class GuncelYazilarController : Controller
	{
		GuncelYazilarValidator validationRules = new GuncelYazilarValidator();
		GuncelYazilarManager atf = new GuncelYazilarManager(new EfGuncelYazilarDal());
		Context c = new Context();
		[AllowAnonymous]
		public PartialViewResult Index()
		{
			var atifList = atf.GetAll().OrderByDescending(z => z.DateYazi).ToList();
			return PartialView(atifList);
		}
		public ActionResult AGuncelYazilarList()
		{
			var galery = atf.GetAll().OrderByDescending(z => z.DateYazi).ToList();
			return View(galery);
		}
		[HttpGet]
		public ActionResult ANewGuncelYazilar()
		{
			return View();
		}
		[HttpPost]
		[ValidateInput(false)]
		public ActionResult ANewGuncelYazilar(GuncelYazilar b)
		{
			ValidationResult result = validationRules.Validate(b);

			string filename = Path.GetFileName(Request.Files[0].FileName);
			string uzanti = Path.GetExtension(Request.Files[0].FileName);

			Random rand = new Random();
			filename = DateTime.Now.ToShortDateString() + "-" + rand.Next(0, 999999999).ToString() + uzanti;

			string way = "~/File/GuncelYazilar/" + filename;
			b.File = "/File/GuncelYazilar/" + filename;

			if (Request.Files.Count > 0)
			{
				if (uzanti.ToLower() == ".pdf")
				{
					if (result.IsValid)
					{
						Request.Files[0].SaveAs(Server.MapPath(way));
						b.DateYazi = DateTime.Parse(DateTime.Now.ToShortDateString());
						atf.GuncelYazilarAdd(b);
						return RedirectToAction("AGuncelYazilarList");
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
				else
				{
					ViewBag.hata = "Dosya uzantısı yükleme için uygun değil. Uygun olan uzantılar : .jpg, .jpeg, .png";
				}
			}
			return View();
		}
		public ActionResult AGuncelYazilarDelete(int id)
		{
			var idgal = atf.GetByID(id);
			var filename = Request.MapPath("~" + idgal.File);
			if (System.IO.File.Exists(filename))
			{
				System.IO.File.Delete(filename);
			}
			atf.GuncelYazilarDelete(idgal);
			return RedirectToAction("AGuncelYazilarList");
		}
		[HttpGet]
		public ActionResult AGuncelYazilarUpdate(int id)
		{
			var idserv = atf.GetByID(id);
			return View(idserv);
		}
		[HttpPost, ValidateInput(false)]
		public ActionResult AGuncelYazilarUpdate(GuncelYazilar b)
		{

			ValidationResult result = validationRules.Validate(b);

			string filename = Path.GetFileName(Request.Files[0].FileName);
			string uzanti = Path.GetExtension(Request.Files[0].FileName);

			Random rand = new Random();
			filename = DateTime.Now.ToShortDateString() + "-GuncelYazilar-" + rand.Next(0, 999999999).ToString() + uzanti;

			string way = "~/File/GuncelYazilar/" + filename;
			b.File = "/File/GuncelYazilar/" + filename;

			if (Request.Files.Count > 0)
			{
				if (uzanti.ToLower() == ".pdf")
				{
					if (result.IsValid)
					{
						Request.Files[0].SaveAs(Server.MapPath(way));
						b.DateYazi = DateTime.Parse(DateTime.Now.ToLongTimeString());
						atf.GuncelYazilarAdd(b);
						return RedirectToAction("AGuncelYazilarList");
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
				else
				{
					ViewBag.hata = "Dosya uzantısı yükleme için uygun değil. Uygun olan uzantılar : .jpg, .jpeg, .png";
				}
			}
			if (!System.IO.File.Exists(b.File))
			{
				if (result.IsValid)
				{
					string resim = c.GuncelYazilars.Where(x => x.YaziID == b.YaziID).Select(z => z.File).FirstOrDefault();
					b.File = resim;
					b.DateYazi = DateTime.Parse(DateTime.Now.ToLongTimeString());
					atf.GuncelYazilarUpdate(b);
					return RedirectToAction("AGuncelYazilarList");
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
			return View();
		}
	}
}