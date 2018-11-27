using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheAdventureCompany.Controllers
{
    public class SubscribeFormController : Controller
    {
        // GET: SubscribeForm
        public ActionResult Index(string email)
        {
            return View();
        }
    }
}