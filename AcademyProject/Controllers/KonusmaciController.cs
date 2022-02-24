using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcademyProject.Controllers
{
    public class KonusmaciController : Controller
    {
        KonusmaciManager kon = new KonusmaciManager(new EfKonusmaciDal());
		[AllowAnonymous]
		public PartialViewResult Index()
        {
            var atifList = kon.GetAll();
            return PartialView(atifList);
        }
		public ActionResult AKonusmaciList()
		{
			var galery = kon.GetAll();
			return View(galery);
		}
		[HttpGet]
		public ActionResult AKonusmaciUpdate(int id)
		{
			var idserv = kon.GetByID(id);
			return View(idserv);
		}
		[HttpPost]
		public ActionResult AKonusmaciUpdate(Konusmaci b)
		{
			string filename = Path.GetFileName(Request.Files[0].FileName);
			string uzanti = Path.GetExtension(Request.Files[0].FileName);

			Random rand = new Random();
			filename = DateTime.Now.ToShortDateString() + "-konusmaci-" + rand.Next(0, 999999999).ToString() + uzanti;

			string way = "~/File/Konusmaci/" + filename;
			b.File = "/File/Konusmaci/" + filename;

			if (Request.Files.Count > 0)
			{
				if (uzanti.ToLower() == ".pdf")
				{
					Request.Files[0].SaveAs(Server.MapPath(way));
					kon.KonusmaciUpdate(b);
					return RedirectToAction("AKonusmaciList");
				}

			}
			return View();
		}
	}
}