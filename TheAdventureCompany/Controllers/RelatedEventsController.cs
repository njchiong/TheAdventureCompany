using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Data.Fields;
using Sitecore.Links;
using Sitecore.Mvc.Presentation;
using Sitecore.Mvc.Extensions;
using TheAdventureCompany.Models;

namespace TheAdventureCompany.Controllers
{
    public class RelatedEventsController : Controller
    {
        // GET: RelatedEvents
        public ActionResult Index()
        {
            var item = RenderingContext.Current.ContextItem;
            MultilistField relatedEvents = item.Fields["RelatedEvents"];
            var events = relatedEvents.GetItems()
                .Select(i => new NavigationItem()
                {
                    Title = i.DisplayName,
                    URL = LinkManager.GetItemUrl(i)
                });

            return View(events);
        }
    }
}