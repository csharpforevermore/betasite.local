using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;


namespace ESO.Models
{
    public partial class Link : PublishedContentModel 
    {
		public Link(IPublishedContent content)
			: base(content)
		{ }



		public string LinkURL => "TODO"; // this.Value<string>("");
		public string LinkTarget => "TODO"; // this.Value<string>("");
		public string LinkTitle => "TODO"; // this.Value<string>("");
        public string LinkCaption => "TODO"; // this.Value<string>("");
        public string LinkIcon => "TODO"; // this.Value<string>("");
    }

}