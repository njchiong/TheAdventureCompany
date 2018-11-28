using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TheAdventureCompany.Controllers
{
    public class CommentsFormController : Controller
    {
        // GET: CommentsForm
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string comment, string email)
        {
            return View("Confirmation");
        }
    }
}