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
	public class AtiflarController : Controller
	{
		AtiflarManager atf = new AtiflarManager(new EfAtiflarDal());
		[AllowAnonymous]
		public PartialViewResult Index()
		{
			var atifList = atf.GetAll();
			return PartialView(atifList);
		}
		public ActionResult AAtifList()
		{
			var galery = atf.GetAll();
			return View(galery);
		}
		[HttpGet]
		public ActionResult AAtiflarUpdate(int id)
		{
			var idserv = atf.GetByID(id);
			return View(idserv);
		}
		[HttpPost]
		public ActionResult AAtiflarUpdate(Atiflar b)
		{
			string filename = Path.GetFileName(Request.Files[0].FileName);
			string uzanti = Path.GetExtension(Request.Files[0].FileName);

			Random rand = new Random();
			filename = DateTime.Now.ToShortDateString() + "-atif-" + rand.Next(0, 999999999).ToString() + uzanti;

			string way = "~/File/Atif/" + filename;
			b.File = "/File/Atif/" + filename;

			if (Request.Files.Count > 0)
			{
				if (uzanti.ToLower() == ".pdf")
				{
					Request.Files[0].SaveAs(Server.MapPath(way));
					atf.AtiflarUpdate(b);
					return RedirectToAction("AAtifList");
				}
				
			}
			return View();
		}
	}
}