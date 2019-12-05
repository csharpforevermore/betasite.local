using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using System.Collections.Generic;
using Umbraco.Web.Models;

namespace ESO.Models
{
   
    public class RelatedLinks : List<RelatedLink>
    {
    }

    public class RelatedLink : PublishedContentModel
    {
        public RelatedLink(IPublishedContent content) : base(content) { }

        public string Caption { get; set; } = "";
        public string Link { get; set; } = "";
        public bool IsInternal { get; set; }
        public bool NewWindow { get; set; }
    }

    
}