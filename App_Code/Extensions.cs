using Umbraco.Core;
using Umbraco.Web;
using Umbraco.Core.Models.PublishedContent;
using System;


namespace ESO.Extensions
{
    public static class Extensions
    {
        public static IPublishedContent GlobalSettings(this UmbracoHelper umbraco)
        {
            return umbraco.ContentSingleAtXPath("\\globalSettings");
        }

        public static int WordCount(this String str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, 
                             StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }   
}