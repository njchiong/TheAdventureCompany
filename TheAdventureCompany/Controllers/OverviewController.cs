using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore.Links;
using Sitecore.Mvc.Presentation;
using Sitecore.Web.UI.WebControls;
using TheAdventureCompany.Models;

namespace TheAdventureCompany.Controllers
{
    public class OverviewController : Controller
    {
        // GET: Overview
        public ActionResult Index()
        {
            var model = new OverviewList();
            model.AddRange(RenderingContext.Current.ContextItem.GetChildren(Sitecore.Collections.ChildListOptions.SkipSorting)
                .OrderBy(i => i.Created)
                .Select(i => new OverviewItem()
                {
                    URL = LinkManager.GetItemUrl(i),
                    ContentHeading = new HtmlString(FieldRenderer.Render(i, "contentheading")),
                    EventImage = new HtmlString(FieldRenderer.Render(i, "decorationbanner", "mw=500&mh=333"))
                })
                
            );

        
            return View(model);
        }
    }
}