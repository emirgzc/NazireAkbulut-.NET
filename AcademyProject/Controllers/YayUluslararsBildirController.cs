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
    public class YayUluslararsBildirController : Controller
    {
        YayUluslararsBildirManager yub = new YayUluslararsBildirManager(new EfYayUluslararsBildirDal());
		[AllowAnonymous]
		public PartialViewResult Index()
        {
            var atifList = yub.GetAll();
            return PartialView(atifList);
        }
		public ActionResult AYayUluslararsBildirList()
		{
			var galery = yub.GetAll();
			return View(galery);
		}
		[HttpGet]
		public ActionResult AYayUluslararsBildirUpdate(int id)
		{
			var idserv = yub.GetByID(id);
			return View(idserv);
		}
		[HttpPost]
		public ActionResult AYayUluslararsBildirUpdate(YayUluslararsBildir b)
		{
			string filename = Path.GetFileName(Request.Files[0].FileName);
			string uzanti = Path.GetExtension(Request.Files[0].FileName);

			Random rand = new Random();
			filename = DateTime.Now.ToShortDateString() + "-YayUluslararsBildir-" + rand.Next(0, 999999999).ToString() + uzanti;

			string way = "~/File/YayUluslararsBildir/" + filename;
			b.File = "/File/YayUluslararsBildir/" + filename;

			if (Request.Files.Count > 0)
			{
				if (uzanti.ToLower() == ".pdf")
				{
					Request.Files[0].SaveAs(Server.MapPath(way));
					yub.YayUluslararsBildirUpdate(b);
					return RedirectToAction("AYayUluslararsBildirList");
				}

			}
			return View();
		}
	}
}