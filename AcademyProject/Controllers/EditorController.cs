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
	public class EditorController : Controller
	{
		EditorValidator validationRules = new EditorValidator();
		EditorlukManager et = new EditorlukManager(new EfEditorlukDal());
		Context c = new Context();
		[AllowAnonymous]
		public ActionResult Index()
		{
			var editorList = et.GetAll().OrderByDescending(z => z.EditDate).Where(z => z.Status == true).ToList();
			return View(editorList);
		}
		[AllowAnonymous]
		public ActionResult EditorDetails(int id)
		{
			var idact = et.GetEditorlukByID(id);
			return View(idact);
		}
		public ActionResult AEditorList()
		{
			var bloglist = et.GetAll().OrderByDescending(z => z.EditDate).ToList();
			return View(bloglist);
		}
		[HttpGet]
		public ActionResult ANewEditor()
		{
			return View();
		}
		[HttpPost]
		[ValidateInput(false)]
		public ActionResult ANewEditor(Editorluk b)
		{
			ValidationResult result = validationRules.Validate(b);

			string filename = Path.GetFileName(Request.Files[0].FileName);
			string uzanti = Path.GetExtension(Request.Files[0].FileName);

			Random rand = new Random();
			filename = DateTime.Now.ToShortDateString() + "-" + rand.Next(0, 999999999).ToString() + uzanti;

			string way = "~/Image/Editor/" + filename;
			b.EditImage = "/Image/Editor/" + filename;

			if (Request.Files.Count > 0)
			{
				if (uzanti.ToLower() == ".jpg" || uzanti.ToLower() == ".jpeg" || uzanti.ToLower() == ".png")
				{
					if (result.IsValid)
					{
						Request.Files[0].SaveAs(Server.MapPath(way));
						b.EditDate = DateTime.Parse(DateTime.Now.ToShortDateString());
						b.Status = false;
						et.EditorlukAdd(b);
						return RedirectToAction("AEditorList");
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
		public ActionResult ADeleteEditor(int id)
		{
			var idgal = et.GetByID(id);
			var filename = Request.MapPath("~" + idgal.EditImage);
			if (System.IO.File.Exists(filename))
			{
				System.IO.File.Delete(filename);
			}
			et.EditorlukDelete(idgal);
			return RedirectToAction("AEditorList");
		}
		public ActionResult AEditorDoFalse(int id)
		{
			var idser = et.GetByID(id);
			idser.Status = false;
			et.EditorlukUpdate(idser);
			return RedirectToAction("AEditorList");
		}
		public ActionResult AEditorDoTrue(int id)
		{
			var idser = et.GetByID(id);
			idser.Status = true;
			et.EditorlukUpdate(idser);
			return RedirectToAction("AEditorList");
		}
		[HttpGet]
		public ActionResult AEditorUpdate(int id)
		{
			var idserv = et.GetByID(id);
			return View(idserv);
		}
		[HttpPost, ValidateInput(false)]
		public ActionResult AEditorUpdate(Editorluk b)
		{

			ValidationResult result = validationRules.Validate(b);

			string filename = Path.GetFileName(Request.Files[0].FileName);
			string uzanti = Path.GetExtension(Request.Files[0].FileName);

			Random rand = new Random();
			filename = DateTime.Now.ToShortDateString() + "-" + rand.Next(0, 999999999).ToString() + uzanti;

			string way = "~/Image/Editor/" + filename;
			b.EditImage = "/Image/Editor/" + filename;

			if (Request.Files.Count > 0)
			{
				if (uzanti.ToLower() == ".jpg" || uzanti.ToLower() == ".jpeg" || uzanti.ToLower() == ".png")
				{
					if (result.IsValid)
					{
						Request.Files[0].SaveAs(Server.MapPath(way));
						b.EditDate = DateTime.Parse(DateTime.Now.ToLongTimeString());
						b.Status = false;
						et.EditorlukUpdate(b);
						return RedirectToAction("AEditorList");
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
			if (!System.IO.File.Exists(b.EditImage))
			{
				if (result.IsValid)
				{
					string resim = c.Editorluks.Where(x => x.EditID == b.EditID).Select(z => z.EditImage).FirstOrDefault();
					b.EditImage = resim;
					b.Status = false;
					b.EditDate = DateTime.Parse(DateTime.Now.ToLongTimeString());
					et.EditorlukUpdate(b);
					return RedirectToAction("AEditorList");
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