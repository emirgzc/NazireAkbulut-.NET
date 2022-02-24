using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcademyProject.Controllers
{
    public class ContactController : Controller
    {
        ContactManager cm = new ContactManager(new EfContactDal());
		[HttpGet]
		[AllowAnonymous]
		public ActionResult Index()
		{
			var listsett = cm.GetAll();
			return View(listsett);
		}
		[HttpPost]
		[AllowAnonymous]
		public ActionResult Index(Contact c)
		{
			c.ContactDate = DateTime.Parse(DateTime.Now.ToLongTimeString());
			cm.ContactAdd(c);
			return RedirectToAction("Index");
		}
		public ActionResult AContactList()
		{
			var list = cm.GetOrderByDate();
			return View(list);
		}
		public ActionResult AContactDetails(int id)
		{
			var contact = cm.GetByID(id);
			return View(contact);
		}
		public ActionResult AContactDelete(int id)
		{
			var contact = cm.GetByID(id);
			cm.ContactDelete(contact);
			return RedirectToAction("AContactList");
		}
	}
}