using Umbraco.Core.Models;
using Umbraco.Web.Models;
using Umbraco.Core.Models.PublishedContent;

namespace ESO.Models
{
    /// <summary>
    /// Not using strongly typed models here so that PureLive mode can be used
    /// </summary>
    public class BaseViewModel : ContentModel
    {
        //Standard Model Pass Through
        public BaseViewModel(IPublishedContent content) : base(content) { }

        public IPublishedContent GlobalSettings { get; set; }

        public IPublishedContent Navigation { get; set; }
    }
}