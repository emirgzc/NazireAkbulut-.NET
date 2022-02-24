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
    public class SemKonBilDanKurUyeController : Controller
    {
        SemKonBilDanKurUyeManager sm = new SemKonBilDanKurUyeManager(new EfSemKonBilDanKurUyeDal());
		[AllowAnonymous]
		public PartialViewResult Index()
        {
            var semList = sm.GetAll();
            return PartialView(semList);
        }
		[AllowAnonymous]
		public ActionResult YukLisDokJuri()
        {
            return View();
        }
		public ActionResult ASemKonBilDanKurUyeList()
		{
			var galery = sm.GetAll();
			return View(galery);
		}
		[HttpGet]
		public ActionResult ASemKonBilDanKurUyeUpdate(int id)
		{
			var idserv = sm.GetByID(id);
			return View(idserv);
		}
		[HttpPost]
		public ActionResult ASemKonBilDanKurUyeUpdate(SemKonBilDanKurUye b)
		{
			string filename = Path.GetFileName(Request.Files[0].FileName);
			string uzanti = Path.GetExtension(Request.Files[0].FileName);

			Random rand = new Random();
			filename = DateTime.Now.ToShortDateString() + "-SemKonBilDanKurUye-" + rand.Next(0, 999999999).ToString() + uzanti;

			string way = "~/File/SemKonBilDanKurUye/" + filename;
			b.File = "/File/SemKonBilDanKurUye/" + filename;

			if (Request.Files.Count > 0)
			{
				if (uzanti.ToLower() == ".pdf")
				{
					Request.Files[0].SaveAs(Server.MapPath(way));
					sm.SemKonBilDanKurUyeUpdate(b);
					return RedirectToAction("ASemKonBilDanKurUyeList");
				}

			}
			return View();
		}
	}
}