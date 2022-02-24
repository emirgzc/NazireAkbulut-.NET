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
	public class KitapController : Controller
	{
		KitapValidator validationRules = new KitapValidator();
		KitapManager ktp = new KitapManager(new EfKitapDal());
		Context c = new Context();
		[AllowAnonymous]
		public ActionResult Index()
		{
			var kitapList = ktp.GetAll().OrderByDescending(z => z.KitapDate).Where(z => z.Status == true).ToList();
			return View(kitapList);
		}
		[AllowAnonymous]
		public ActionResult KitapDetails(int id)
		{
			var idact = ktp.GetKitapByID(id);
			return View(idact);
		}
		public ActionResult AKitapList()
		{
			var bloglist = ktp.GetAll().OrderByDescending(z => z.KitapDate).ToList();
			return View(bloglist);
		}
		[HttpGet]
		public ActionResult ANewKitap()
		{
			return View();
		}
		[HttpPost]
		[ValidateInput(false)]
		public ActionResult ANewKitap(Kitap b)
		{
			ValidationResult result = validationRules.Validate(b);

			string filename = Path.GetFileName(Request.Files[0].FileName);
			string uzanti = Path.GetExtension(Request.Files[0].FileName);

			Random rand = new Random();
			filename = DateTime.Now.ToShortDateString() + "-" + rand.Next(0, 999999999).ToString() + uzanti;

			string way = "~/Image/Kitap/" + filename;
			b.KitapImage = "/Image/Kitap/" + filename;

			if (Request.Files.Count > 0)
			{
				if (uzanti.ToLower() == ".jpg" || uzanti.ToLower() == ".jpeg" || uzanti.ToLower() == ".png")
				{
					if (result.IsValid)
					{
						Request.Files[0].SaveAs(Server.MapPath(way));
						b.KitapDate = DateTime.Parse(DateTime.Now.ToShortDateString());
						b.Status = false;
						ktp.KitapAdd(b);
						return RedirectToAction("AKitapList");
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
		public ActionResult ADeleteKitap(int id)
		{
			var idgal = ktp.GetByID(id);
			var filename = Request.MapPath("~" + idgal.KitapImage);
			if (System.IO.File.Exists(filename))
			{
				System.IO.File.Delete(filename);
			}
			ktp.KitapDelete(idgal);
			return RedirectToAction("AKitapList");
		}
		public ActionResult AKitapDoFalse(int id)
		{
			var idser = ktp.GetByID(id);
			idser.Status = false;
			ktp.KitapUpdate(idser);
			return RedirectToAction("AKitapList");
		}
		public ActionResult AKitapDoTrue(int id)
		{
			var idser = ktp.GetByID(id);
			idser.Status = true;
			ktp.KitapUpdate(idser);
			return RedirectToAction("AKitapList");
		}
		[HttpGet]
		public ActionResult AKitapUpdate(int id)
		{
			var idserv = ktp.GetByID(id);
			return View(idserv);
		}
		[HttpPost, ValidateInput(false)]
		public ActionResult AKitapUpdate(Kitap b)
		{
			ValidationResult result = validationRules.Validate(b);

			string filename = Path.GetFileName(Request.Files[0].FileName);
			string uzanti = Path.GetExtension(Request.Files[0].FileName);

			Random rand = new Random();
			filename = DateTime.Now.ToShortDateString() + "-" + rand.Next(0, 999999999).ToString() + uzanti;

			string way = "~/Image/Kitap/" + filename;
			b.KitapImage = "/Image/Kitap/" + filename;

			if (Request.Files.Count > 0)
			{
				if (uzanti.ToLower() == ".jpg" || uzanti.ToLower() == ".jpeg" || uzanti.ToLower() == ".png")
				{
					if (result.IsValid)
					{
						Request.Files[0].SaveAs(Server.MapPath(way));
						b.KitapDate = DateTime.Parse(DateTime.Now.ToLongTimeString());
						b.Status = false;
						ktp.KitapUpdate(b);
						return RedirectToAction("AKitapList");
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
			if (!System.IO.File.Exists(b.KitapImage))
			{
				if (result.IsValid)
				{
					string resim = c.Kitaps.Where(x => x.KitapID == b.KitapID).Select(z => z.KitapImage).FirstOrDefault();
					b.KitapImage = resim;
					b.Status = false;
					b.KitapDate = DateTime.Parse(DateTime.Now.ToLongTimeString());
					ktp.KitapUpdate(b);
					return RedirectToAction("AKitapList");
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