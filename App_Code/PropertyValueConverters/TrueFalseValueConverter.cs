using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web;
using System;


public class TrueFalseValueConverter : Umbraco.Core.PropertyEditors.PropertyValueConverterBase
{
    public override bool IsConverter(IPublishedPropertyType propertyType) => propertyType.EditorAlias.Equals("ESO.TrueFalse", StringComparison.InvariantCultureIgnoreCase);

    public virtual object ConvertDataToSource(PublishedPropertyType propertyType, object source, bool preview)
    {
          var attemptConvertInt = source.TryConvertTo<bool>();
            if (attemptConvertInt.Success)
            {
                return attemptConvertInt.Result;
            }

            return null;
    }

    public virtual object ConvertSourceToXPath(
      PublishedPropertyType propertyType,
      object source,
      bool preview)
    {
        if (!(bool)source)
            return (object) source.ToString();
        return (object) false;
    }
}