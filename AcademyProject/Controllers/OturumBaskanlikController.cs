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
    public class OturumBaskanlikController : Controller
    {
        OturumBaskanlikManager obm = new OturumBaskanlikManager(new EfOturumBaskanlikDal());
		[AllowAnonymous]
		public PartialViewResult Index()
        {
            var atifList = obm.GetAll();
            return PartialView(atifList);
        }
		public ActionResult AOturBasList()
		{
			var galery = obm.GetAll();
			return View(galery);
		}
		[HttpGet]
		public ActionResult AOturumBaskanlikUpdate(int id)
		{
			var idserv = obm.GetByID(id);
			return View(idserv);
		}
		[HttpPost]
		public ActionResult AOturumBaskanlikUpdate(OturumBaskanlik b)
		{
			string filename = Path.GetFileName(Request.Files[0].FileName);
			string uzanti = Path.GetExtension(Request.Files[0].FileName);

			Random rand = new Random();
			filename = DateTime.Now.ToShortDateString() + "-oturbaskan-" + rand.Next(0, 999999999).ToString() + uzanti;

			string way = "~/File/OturumBaskanlik/" + filename;
			b.File = "/File/OturumBaskanlik/" + filename;

			if (Request.Files.Count > 0)
			{
				if (uzanti.ToLower() == ".pdf")
				{
					Request.Files[0].SaveAs(Server.MapPath(way));
					obm.OturumBaskanlikUpdate(b);
					return RedirectToAction("AOturBasList");
				}

			}
			return View();
		}
	}
}