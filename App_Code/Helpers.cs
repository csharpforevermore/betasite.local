using System;
using System.Web;

namespace ESO.Models
{
    public static class Helper
    {

        public static string GetTypeName(this Type t)
        {
            if (!t.IsGenericType) return t.Name;
            if (t.IsNested && t.DeclaringType.IsGenericType) throw new NotImplementedException();
            string txt = t.Name.Substring(0, t.Name.IndexOf('`')) + "<";
            int cnt = 0;
            foreach (Type arg in t.GetGenericArguments())
            {
                if (cnt > 0) txt += ", ";
                txt += GetTypeName(arg);
                cnt++;
            }

            return txt + ">";
        }
    }

   public static class UrlHelper
  {
    public static Link GetLinkFromRelatedLink(RelatedLink link)
    {
      Link usnLink = new Link();
      if (HttpContext.Current.Request.IsLocal)
      {
        if (link != null)
        {
          usnLink.LinkURL = ((RelatedLinkBase) link).get_Link();
          usnLink.LinkCaption = ((RelatedLinkBase) link).get_Caption();
          if (((RelatedLinkBase) link).get_NewWindow())
          {
            usnLink.LinkTitle = u0005u2000.u0002(1222205532) + library.GetDictionaryItem(u0005u2000.u0002(1222205549)) + u0005u2000.u0002(1222205834);
            usnLink.LinkTarget = u0005u2000.u0002(1222205829);
            usnLink.LinkIcon = library.GetDictionaryItem(u0005u2000.u0002(1222205867));
          }
          if (((RelatedLinkBase) link).get_IsInternal())
          {
            IPublishedContent ipublishedContent = new UmbracoHelper(UmbracoContext.get_Current()).TypedContent((object) link.get_Id());
            if (ipublishedContent != null)
            {
              usnLink.InternalNode = ipublishedContent;
              usnLink.LinkType = Link.UrlPickerTypes.Content;
            }
            if (ipublishedContent != null && ipublishedContent.get_DocumentTypeAlias().IndexOf(u0005u2000.u0002(1222205877)) != -1)
            {
              IPublishedContent parent = ipublishedContent.get_Parent().get_Parent();
              string str = u0005u2000.u0002(1222205903) + ipublishedContent.get_Id().ToString();
              usnLink.LinkURL = parent.get_Url() + str;
            }
            if (ipublishedContent == null)
              usnLink = (Link) null;
          }
          else
          {
            usnLink.LinkType = !((RelatedLinkBase) link).get_Link().StartsWith(u0005u2000.u0002(1222205915)) ? Link.UrlPickerTypes.Url : Link.UrlPickerTypes.Media;
            usnLink.InternalNode = (IPublishedContent) null;
          }
        }
      }
      else
      {
        usnLink.LinkURL = u0005u2000.u0002(1222205929);
        usnLink.LinkCaption = u0005u2000.u0002(1222205921);
      }
      return usnLink;
    }

    public static Link GetLinkFromRelatedLinks(RelatedLinks links)
    {
      Link usnLink = new Link();
      if (ProductLicense.Instance.IsValid() || HttpContext.Current.Request.IsLocal)
      {
        if (links != null && ((IEnumerable<RelatedLink>) links).FirstOrDefault<RelatedLink>() != null)
        {
          RelatedLink relatedLink = ((IEnumerable<RelatedLink>) links).FirstOrDefault<RelatedLink>();
          usnLink.LinkURL = ((RelatedLinkBase) relatedLink).get_Link();
          usnLink.LinkCaption = ((RelatedLinkBase) relatedLink).get_Caption();
          if (((RelatedLinkBase) relatedLink).get_NewWindow())
          {
            usnLink.LinkTitle = u0005u2000.u0002(1222205532) + library.GetDictionaryItem(u0005u2000.u0002(1222205549)) + u0005u2000.u0002(1222205834);
            usnLink.LinkTarget = u0005u2000.u0002(1222205829);
            usnLink.LinkIcon = library.GetDictionaryItem(u0005u2000.u0002(1222205867));
          }
          if (((RelatedLinkBase) relatedLink).get_IsInternal())
          {
            IPublishedContent ipublishedContent = new UmbracoHelper(UmbracoContext.get_Current()).TypedContent((object) relatedLink.get_Id());
            if (ipublishedContent != null)
            {
              usnLink.InternalNode = ipublishedContent;
              usnLink.LinkType = Link.UrlPickerTypes.Content;
            }
            if (ipublishedContent != null && ipublishedContent.get_DocumentTypeAlias().IndexOf(u0005u2000.u0002(1222205877)) != -1)
            {
              IPublishedContent parent = ipublishedContent.get_Parent().get_Parent();
              string str = u0005u2000.u0002(1222205903) + ipublishedContent.get_Id().ToString();
              usnLink.LinkURL = parent.get_Url() + str;
            }
            if (ipublishedContent == null)
              usnLink = (Link) null;
          }
          else
          {
            usnLink.LinkType = !((RelatedLinkBase) relatedLink).get_Link().StartsWith(u0005u2000.u0002(1222205915)) ? Link.UrlPickerTypes.Url : Link.UrlPickerTypes.Media;
            usnLink.InternalNode = (IPublishedContent) null;
          }
        }
        else
          usnLink = (Link) null;
      }
      else
      {
        usnLink.LinkURL = u0005u2000.u0002(1222205929);
        usnLink.LinkCaption = u0005u2000.u0002(1222205921);
      }
      return usnLink;
    }
  }
}