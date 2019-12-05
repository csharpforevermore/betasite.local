using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using System.Collections.Generic;
using Umbraco.Web.Models;

namespace ESO.Models
{
    // public class Link : PublishedContentModel 
    // {
	// 	public Link(IPublishedContent content) : base(content) { }

	// 	public string LiSnkURL => "TODO"; // this.Value<string>("");
	// 	public string LinkTarget => "TODO"; // this.Value<string>("");
	// 	public string LinkTitle => "TODO"; // this.Value<string>("");
    //     public string LinkCaption => "TODO"; // this.Value<string>("");
    //     public string LinkIcon => "TODO"; // this.Value<string>("");
    // }

    public class RelatedLinks : List<RelatedLink> { }

	public class RelatedLink : PublishedContentModel
	{
		public RelatedLink(IPublishedContent content) : base(content){}
	}	

}