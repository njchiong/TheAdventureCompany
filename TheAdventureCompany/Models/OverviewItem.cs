using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheAdventureCompany.Models
{
    public class OverviewItem
    {
        public HtmlString ContentHeading { get; set; }
        public HtmlString EventImage { get; set; }
        public string URL { get; set; }

        public OverviewItem()
        {
                
        }
    }


}