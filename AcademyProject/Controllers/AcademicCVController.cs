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
    
    public class AcademicCVController : Controller
    {
        AkacemikCVManager ac = new AkacemikCVManager(new EfAkacemikCVDal());
		[AllowAnonymous]
		public PartialViewResult Index()
        {
            var aclist = ac.GetAll();
            return PartialView(aclist);
        }
		public ActionResult AAcademicCVList()
		{
			var galery = ac.GetAll();
			return View(galery);
		}
		[HttpGet]
		public ActionResult AAcademicCVUpdate(int id)
		{
			var idserv = ac.GetByID(id);
			return View(idserv);
		}
		[HttpPost]
		public ActionResult AAcademicCVUpdate(AkacemikCV b)
		{
			string filename = Path.GetFileName(Request.Files[0].FileName);
			string uzanti = Path.GetExtension(Request.Files[0].FileName);

			Random rand = new Random();
			filename = DateTime.Now.ToShortDateString() + "-AkacemikCV-" + rand.Next(0, 999999999).ToString() + uzanti;

			string way = "~/File/AkacemikCV/" + filename;
			b.File = "/File/AkacemikCV/" + filename;

			if (Request.Files.Count > 0)
			{
				if (uzanti.ToLower() == ".pdf")
				{
					Request.Files[0].SaveAs(Server.MapPath(way));
					ac.AkacemikCVUpdate(b);
					return RedirectToAction("AAcademicCVList");
				}

			}
			return View();
		}
	}
}