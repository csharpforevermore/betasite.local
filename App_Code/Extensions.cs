using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.Services;
using Umbraco.Web;
using Umbraco.Web.PublishedModels;

using System;
using System.Linq;
using System.Net;
using System.Configuration;
using System.Collections.Generic;


namespace ESO.Extensions
{
    public static class Extensions
    {
        public static IPublishedContent GlobalSettings(this IPublishedContent content)
        {
            return GetNode(content, "ESO.GlobalSettingsNodeId", 1075);
        }

        public static IPublishedContent Navigation(this IPublishedContent content)
        {
            return GetNode(content, "ESO.NavigationNodeId", 1076);
        }

        public static bool HasValue(this string text)
        {
            return !string.IsNullOrEmpty(text);
        }


        public static bool HasValue(this IEnumerable<IPublishedContent> content)
        {
            return (content != null && content.Any());
        }


        private static IPublishedContent GetNode(IPublishedContent currentPage, string keyValue, int defaultValue)
        {
            object obj =  ConfigurationManager.AppSettings[keyValue];
            int id = defaultValue;

            if(obj != null && obj is int){
                id = int.Parse(obj as string);
            } 


            IContentService contentService = Umbraco.Core.Composing.Current.Services.ContentService;
            var node = Umbraco.Web.Composing.Current.UmbracoHelper.Content(id);

            return node;
        }
    }
}