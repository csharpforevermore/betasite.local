using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.Services;
using Umbraco.Web;
using Umbraco.Web.PublishedModels;

using System;
using System.Linq;
using System.Net;

namespace ESO.Extensions
{
    public static class Extensions
    {
        public static IPublishedContent GlobalSettings(this IPublishedContent content)
        {
            int id = 1075;
            IContentService contentService = Umbraco.Core.Composing.Current.Services.ContentService;
            var node = Umbraco.Web.Composing.Current.UmbracoHelper.Content(id);

            return node;
        }

        // public static IPublishedContent GlobalSettings(this IPublishedContent node)
        // {
        //     throw new Exception();
        //     return node.AncestorOrSelf().Descendants("globalSettings").FirstOrDefault();
        // }

        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}