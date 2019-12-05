using System;

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

    // public static class UrlHelper
    // {
    //     public static Umbraco.Web.Models.Link GetLinkFromRelatedLink(RelatedLink link){
    //         return new Umbraco.Web.Models.Link(link);
    //     }

    // }
}