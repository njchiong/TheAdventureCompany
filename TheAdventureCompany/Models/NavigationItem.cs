using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheAdventureCompany.Models
{
    public class NavigationItem
    {
        public string  Title { get; set; }
        public string  URL { get; set; }
        public bool  Active { get; set; }
    }
}