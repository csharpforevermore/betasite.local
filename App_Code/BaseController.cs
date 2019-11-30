using System.Linq;
using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using ESO.Models;

namespace ESO.Controllers
{
    /// <summary>
    /// Not using strongly typed models here so that PureLive mode can be used
    /// </summary>
    public class BaseController : Umbraco.Web.Mvc.RenderMvcController
    {
        // Do some stuff here, then return the base method
        public ActionResult Index(ContentModel model)
        {
            return base.Index(model);
        }
    }
}