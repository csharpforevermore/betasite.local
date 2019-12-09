using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;
using Umbraco.Web;
using System;
using ESO.Models;

public class OptionsConverter : PropertyValueConverterBase
{
    public override bool IsConverter(IPublishedPropertyType propertyType) => propertyType.EditorAlias.Equals("ESO.Options", StringComparison.InvariantCultureIgnoreCase);


    public virtual object ConvertDataToSource(
      PublishedPropertyType propertyType,
      object source,
      bool preview)
    {
        return (object)Options.EMPTY;

        //if (source == null) return (object)Options.EMPTY;
        //   if (!ProductLicense.Instance.IsValid() && !HttpContext.Current.Request.IsLocal)
        //   return (object) USNEnums.Options.EMPTY;
        string str = source.ToString();
        throw new Exception(str);

        return (object)Options.EMPTY;

        //   switch (source.ToString())
        //   {
        //     case 1:
        //       if (str == "ComponentWidth_Full")
        //         return (object) USNEnums.Options.ComponentWidth_Full;
        //       break;
        //     case 355762502:
        //       if (str == "Sitemap_Monthly")
        //         return (object) USNEnums.Options.Sitemap_Monthly;
        //       break;
        //     case 392471844:
        //       if (str == \u0005\u2000.\u0002(1222207655))
        //         return (object) USNEnums.Options.BannerSize_Medium;
        //       break;
        //     case 457693294:
        //       if (str == \u0005\u2000.\u0002(1222208371))
        //         return (object) USNEnums.Options.TextAlignment_Right;
        //       break;
        //     case 470633231:
        //       if (str == \u0005\u2000.\u0002(1222209072))
        //         return (object) USNEnums.Options.SplitComponent_3070;
        //       break;
        //     case 566831747:
        //       if (str == \u0005\u2000.\u0002(1222209134))
        //         return (object) USNEnums.Options.Newsletter_Mailchimp;
        //       break;
        //     case 567405648:
        //       if (str == \u0005\u2000.\u0002(1222209183))
        //         return (object) USNEnums.Options.WindowsOrder_3_Small;
        //       break;
        //     case 577054363:
        //       if (str == \u0005\u2000.\u0002(1222207695))
        //         return (object) USNEnums.Options.BannerSize_Short;
        //       break;
        //     case 600573108:
        //       if (str == \u0005\u2000.\u0002(1222209419))
        //         return (object) USNEnums.Options.Sitemap_Always;
        //       break;
        //     case 761464303:
        //       if (str == \u0005\u2000.\u0002(1222209364))
        //         return (object) USNEnums.Options.ImageStyle_Square;
        //       break;
        //     case 850376350:
        //       if (str == \u0005\u2000.\u0002(1222209481))
        //         return (object) USNEnums.Options.Sitemap_Weekly;
        //       break;
        //     case 960565352:
        //       if (str == \u0005\u2000.\u0002(1222207912))
        //         return (object) USNEnums.Options.TextPosition_After;
        //       break;
        //     case 977407939:
        //       if (str == \u0005\u2000.\u0002(1222207586))
        //         return (object) USNEnums.Options.ListingStyle_Vertical;
        //       break;
        //     case 982307065:
        //       if (str == \u0005\u2000.\u0002(1222208511))
        //         return (object) USNEnums.Options.ItemsPerRow_4;
        //       break;
        //     case 999084684:
        //       if (str == \u0005\u2000.\u0002(1222208259))
        //         return (object) USNEnums.Options.ItemsPerRow_3;
        //       break;
        //     case 1015862303:
        //       if (str == \u0005\u2000.\u0002(1222208279))
        //         return (object) USNEnums.Options.ItemsPerRow_2;
        //       break;
        //     case 1032639922:
        //       if (str == \u0005\u2000.\u0002(1222208315))
        //         return (object) USNEnums.Options.ItemsPerRow_1;
        //       break;
        //     case 1081736975:
        //       if (str == \u0005\u2000.\u0002(1222209036))
        //         return (object) USNEnums.Options.SplitComponent_Even;
        //       break;
        //     case 1090291405:
        //       if (str == \u0005\u2000.\u0002(1222207860))
        //         return (object) USNEnums.Options.WindowsOrder_3_Big;
        //       break;
        //     case 1166393705:
        //       if (str == \u0005\u2000.\u0002(1222207578))
        //         return (object) USNEnums.Options.ListingStyle_Grid;
        //       break;
        //     case 1529946747:
        //       if (str == \u0005\u2000.\u0002(1222207747))
        //         return (object) USNEnums.Options.RepeatableLayout_Tabbed;
        //       break;
        //     case 1593890847:
        //       if (str == \u0005\u2000.\u0002(1222208715))
        //         return (object) USNEnums.Options.ImageStyle_Wide;
        //       break;
        //     case 1737378548:
        //       if (str == \u0005\u2000.\u0002(1222208675))
        //         return (object) USNEnums.Options.ImageStyle_Circle;
        //       break;
        //     case 1922006572:
        //       if (str == \u0005\u2000.\u0002(1222207491))
        //         return (object) USNEnums.Options.PageLayout_Center;
        //       break;
        //     case 1935838213:
        //       if (str == \u0005\u2000.\u0002(1222209404))
        //         return (object) USNEnums.Options.ImageStyle_Landscape;
        //       break;
        //     case 2165778173:
        //       if (str == \u0005\u2000.\u0002(1222208342))
        //         return (object) USNEnums.Options.TextAlignment_Center;
        //       break;
        //     case 2216044591:
        //       if (str == \u0005\u2000.\u0002(1222209046))
        //         return (object) USNEnums.Options.SplitComponent_7030;
        //       break;
        //     case 2247753581:
        //       if (str == \u0005\u2000.\u0002(1222207738))
        //         return (object) USNEnums.Options.PageLayout_Right;
        //       break;
        //     case 2348992729:
        //       if (str == \u0005\u2000.\u0002(1222209289))
        //         return (object) USNEnums.Options.Sitemap_Never;
        //       break;
        //     case 2418311601:
        //       if (str == \u0005\u2000.\u0002(1222207851))
        //         return (object) USNEnums.Options.WindowsOrder_4_Small;
        //       break;
        //     case 2451062555:
        //       if (str == \u0005\u2000.\u0002(1222209506))
        //         return (object) USNEnums.Options.Sitemap_Yearly;
        //       break;
        //     case 2549916029:
        //       if (str == \u0005\u2000.\u0002(1222208721))
        //         return (object) USNEnums.Options.IconShape_Square;
        //       break;
        //     case 2574743122:
        //       if (str == \u0005\u2000.\u0002(1222209329))
        //         return (object) USNEnums.Options.ReusableComponentStyle_Stacked;
        //       break;
        //     case 2888580067:
        //       if (str == \u0005\u2000.\u0002(1222208665))
        //         return (object) USNEnums.Options.ImageStyle_Portrait;
        //       break;
        //     case 2963180854:
        //       if (str == \u0005\u2000.\u0002(1222207967))
        //         return (object) USNEnums.Options.ComponentWidth_Wide;
        //       break;
        //     case 3036423216:
        //       if (str == \u0005\u2000.\u0002(1222209438))
        //         return (object) USNEnums.Options.Sitemap_Hourly;
        //       break;
        //     case 3071774361:
        //       if (str == \u0005\u2000.\u0002(1222207777))
        //         return (object) USNEnums.Options.RepeatableLayout_Accordion;
        //       break;
        //     case 3128734066:
        //       if (str == \u0005\u2000.\u0002(1222207540))
        //         return (object) USNEnums.Options.PageLayout_Wide;
        //       break;
        //     case 3168591432:
        //       if (str == \u0005\u2000.\u0002(1222207923))
        //         return (object) USNEnums.Options.ComponentWidth_Center;
        //       break;
        //     case 3251376301:
        //       if (str == \u0005\u2000.\u0002(1222207886))
        //         return (object) USNEnums.Options.TextPosition_Before;
        //       break;
        //     case 3348918075:
        //       if (str == \u0005\u2000.\u0002(1222209114))
        //         return (object) USNEnums.Options.Newsletter_CM;
        //       break;
        //     case 3364196210:
        //       if (str == \u0005\u2000.\u0002(1222207645))
        //         return (object) USNEnums.Options.BannerSize_Takeover;
        //       break;
        //     case 3371582825:
        //       if (str == \u0005\u2000.\u0002(1222209208))
        //         return (object) USNEnums.Options.WindowsOrder_4;
        //       break;
        //     case 3388360444:
        //       if (str == \u0005\u2000.\u0002(1222209231))
        //         return (object) USNEnums.Options.WindowsOrder_3;
        //       break;
        //     case 3405138063:
        //       if (str == \u0005\u2000.\u0002(1222209234))
        //         return (object) USNEnums.Options.WindowsOrder_2;
        //       break;
        //     case 3421915682:
        //       if (str == \u0005\u2000.\u0002(1222209273))
        //         return (object) USNEnums.Options.WindowsOrder_1;
        //       break;
        //     case 3478579925:
        //       if (str == \u0005\u2000.\u0002(1222208335))
        //         return (object) USNEnums.Options.TextAlignment_Left;
        //       break;
        //     case 3522828934:
        //       if (str == \u0005\u2000.\u0002(1222208455))
        //         return (object) USNEnums.Options.Layouts_Above;
        //       break;
        //     case 3572435191:
        //       if (str == \u0005\u2000.\u0002(1222208527))
        //         return (object) USNEnums.Options.IconShape_Rounded;
        //       break;
        //     case 3794995567:
        //       if (str == \u0005\u2000.\u0002(1222208491))
        //         return (object) USNEnums.Options.Layouts_Boxed;
        //       break;
        //     case 3857590663:
        //       if (str == \u0005\u2000.\u0002(1222209309))
        //         return (object) USNEnums.Options.ReusableComponentStyle_Tabbed;
        //       break;
        //     case 3948013572:
        //       if (str == \u0005\u2000.\u0002(1222207808))
        //         return (object) USNEnums.Options.WindowsOrder_4_Big;
        //       break;
        //     case 3998639055:
        //       if (str == \u0005\u2000.\u0002(1222207531))
        //         return (object) USNEnums.Options.PageLayout_CenterAlt;
        //       break;
        //     case 4063986840:
        //       if (str == \u0005\u2000.\u0002(1222207700))
        //         return (object) USNEnums.Options.PageLayout_Left;
        //       break;
        //     case 4167443150:
        //       if (str == \u0005\u2000.\u0002(1222209445))
        //         return (object) USNEnums.Options.Sitemap_Daily;
        //       break;
        //     case 4229017430:
        //       if (str == \u0005\u2000.\u0002(1222208742))
        //         return (object) USNEnums.Options.IconShape_Circle;
        //       break;
        //   }
        //return (object)Options.EMPTY;
    }

     public override Type GetPropertyValueType(IPublishedPropertyType propertyType) => typeof(Options);

    public virtual object ConvertSourceToXPath(
      PublishedPropertyType propertyType,
      object source,
      bool preview)
    {
        if (!(bool)source)
            return (object) source.ToString();
        return (object) Options.EMPTY;
    }
}