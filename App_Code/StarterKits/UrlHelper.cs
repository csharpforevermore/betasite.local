using System.Web;
using System.Linq;
using Umbraco.Web;
using Umbraco.Core.Models.PublishedContent;

public static class UrlHelper
{
    // Methods
    public static Link GetLinkFromRelatedLink(RelatedLink link, UmbracoHelper umbraco)
    {
        Link link2 = new Link();
        if (!ProductLicense.Instance.IsValid() && !HttpContext.Current.Request.IsLocal)
        {
            link2.LinkURL = "LICENSE ERROR";
            link2.LinkCaption = "LICENSE ERROR";
        }
        else if (link != null)
        {
            link2.LinkURL = link.Link;
            link2.LinkCaption = link.Caption;
            if (link.NewWindow)
            {
                link2.LinkTitle = umbraco.GetDictionaryValue("TODO");
                link2.LinkTarget = "TODO";
                link2.LinkIcon = umbraco.GetDictionaryValue("TODO");
            }
            if (!link.IsInternal)
            {
                link2.LinkType = !link.Link.StartsWith("TODO IS NOT MEDIA") ? Link.UrlPickerTypes.Url : Link.UrlPickerTypes.Media;
                link2.InternalNode = null;
            }
            else
            {
                IPublishedContent content = umbraco.Content(link.Id);
                if (content != null)
                {
                    link2.InternalNode = content;
                    link2.LinkType = Link.UrlPickerTypes.Content;
                }
                if ((content != null) && (content.ContentType.Alias.IndexOf("Folder") != -1))
                {
                    string str = "/" + content.Id.ToString();
                    link2.LinkURL = content.Parent.Parent.Url + str;
                }
                if (content == null)
                {
                    link2 = null;
                }
            }
        }
        return link2;
    }

    public static Link GetLinkFromRelatedLinks(RelatedLinks links, UmbracoHelper umbraco)
    {
        Link link = new Link();
        if (!ProductLicense.Instance.IsValid() && !HttpContext.Current.Request.IsLocal)
        {
            link.LinkURL = "";
            link.LinkCaption = "";
        }
        else if (links == null || links.Any())
        {
            link = null;
        }
        else
        {
            RelatedLink link2 = links.FirstOrDefault<RelatedLink>();
            link.LinkURL = link2.Link;
            link.LinkCaption = link2.Caption;
            if (link2.NewWindow)
            {
                link.LinkTitle = umbraco.GetDictionaryValue("TODO DICTIONARY LINK TITLE VALUE");
                link.LinkTarget = "_blank";
                link.LinkIcon = umbraco.GetDictionaryValue("TODO DICTIONARY LINK ICON VALUE");
            }
            if (!link2.IsInternal)
            {
                link.LinkType = !link2.Link.StartsWith("TODO IS NOT MEDIA") ? Link.UrlPickerTypes.Url : Link.UrlPickerTypes.Media;
                link.InternalNode = null;
            }
            else
            {
                IPublishedContent content = umbraco.Content(link2.Id);
                if (content != null)
                {
                    link.InternalNode = content;
                    link.LinkType = Link.UrlPickerTypes.Content;
                }
                if ((content != null) && (content.ContentType.Alias.IndexOf("TODO DOC TYPE ALIAS") != -1))
                {
                    string str = "TODO " + content.Id.ToString();
                    link.LinkURL = content.Parent.Parent.Url + str;
                }
                if (content == null)
                {
                    link = null;
                }
            }
        }
        return link;
    }
}