using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using ESO.Models;

namespace ESO.ESOControllers
{
    /// <summary>
    /// Not using strongly typed models here so that PureLive mode can be used
    /// </summary>
    public class BaseController : Umbraco.Web.Mvc.RenderMvcController
    {
        public override ActionResult Index(ContentModel model)
        {
            // IPublishedContent homeNode = model.Content.Site();
            IPublishedContent homeNode = Umbraco.ContentAtRoot().FirstOrDefault();

            if (homeNode.IsDocumentType("Homepage"))
            {
                IPublishedContent globalSettings = homeNode.Value<IPublishedContent>("websiteConfigurationNode").Children.Where(x => x.IsDocumentType("GlobalSettings")).First();
                IPublishedContent navigation = homeNode.Value<IPublishedContent>("websiteConfigurationNode").Children.Where(x => x.IsDocumentType("Navigation")).First();

                BaseViewModel customModel = new BaseViewModel(model.Content);
                customModel.GlobalSettings = globalSettings;
                customModel.Navigation = navigation;

                return base.Index(customModel);
            }
            else
                return base.Index(model);
        }
    }
}