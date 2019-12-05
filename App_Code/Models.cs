using Umbraco.Core;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using System.Collections.Generic;
using Umbraco.Web.Models;

namespace ESO.Models
{
    public class Link
    {
        private string _linkTitle;
        private string _linkUrl;
        private string _linkTarget;
        private string _linkIcon;
        private string _linkCaption;
        private IPublishedContent _internalNode;
        private Link.UrlPickerTypes _linkType;

        public Link()
        {
            this.LinkTitle = string.Empty;
            this.LinkURL = string.Empty;
            this.LinkTarget = string.Empty;
            this.LinkIcon = string.Empty;
            this.LinkCaption = string.Empty;
            this.InternalNode = (IPublishedContent)null;
            this.LinkType = Link.UrlPickerTypes.Url;
        }

        public string LinkTitle
        {
            get
            {
                return this._linkTitle;
            }
            set
            {
                this._linkTitle = value;
            }
        }

        public string LinkURL
        {
            get
            {
                return this._linkUrl;
            }
            set
            {
                this._linkUrl = value;
            }
        }

        public string LinkTarget
        {
            get
            {
                return this._linkTarget;
            }
            set
            {
                this._linkTarget = value;
            }
        }

        public string LinkIcon
        {
            get
            {
                return this._linkIcon;
            }
            set
            {
                this._linkIcon = value;
            }
        }

        public string LinkCaption
        {
            get
            {
                return this._linkCaption;
            }
            set
            {
                this._linkCaption = value;
            }
        }

        public IPublishedContent InternalNode
        {
            get
            {
                return this._internalNode;
            }
            set
            {
                this._internalNode = value;
            }
        }

        public Link.UrlPickerTypes LinkType
        {
            get
            {
                return this._linkType;
            }
            set
            {
                this._linkType = value;
            }
        }

        public enum UrlPickerTypes
        {
            Url,
            Content,
            Media,
        }
    }

    public class RelatedLinks : List<RelatedLink>
    {
    }

    public class RelatedLink : PublishedContentModel
    {
        public RelatedLink(IPublishedContent content) : base(content) { }

        public string Caption { get; set; }
        public string Link { get; set; }
        public bool IsInternal { get; set; }
        public bool NewWindow { get; set; }
    }

    public enum Options
    {
        Layouts_Above,
        Layouts_Boxed,
        ItemsPerRow_4,
        ItemsPerRow_3,
        ItemsPerRow_2,
        ItemsPerRow_1,
        TextAlignment_Left,
        TextAlignment_Center,
        TextAlignment_Right,
        BannerSize_Takeover,
        BannerSize_Medium,
        BannerSize_Short,
        PageLayout_Left,
        PageLayout_Right,
        PageLayout_Center,
        PageLayout_CenterAlt,
        PageLayout_Wide,
        ListingStyle_Grid,
        ListingStyle_Vertical,
        TextPosition_Before,
        TextPosition_After,
        ComponentWidth_Center,
        ComponentWidth_Wide,
        ComponentWidth_Full,
        RepeatableLayout_Tabbed,
        RepeatableLayout_Accordion,
        WindowsOrder_4_Big,
        WindowsOrder_4_Small,
        WindowsOrder_3_Big,
        WindowsOrder_3_Small,
        WindowsOrder_4,
        WindowsOrder_3,
        WindowsOrder_2,
        WindowsOrder_1,
        SplitComponent_Even,
        SplitComponent_7030,
        SplitComponent_3070,
        Newsletter_CM,
        Newsletter_Mailchimp,
        BG_Cover,
        BG_FullWidth,
        BG_Auto,
        BG_Repeat,
        BG_RepeatX,
        BG_RepeatY,
        BG_TopLeft,
        BG_TopCenter,
        BG_TopRight,
        BG_CenterLeft,
        BG_CenterCenter,
        BG_CenterRight,
        BG_BottomLeft,
        BG_BottomCenter,
        BG_BottomRight,
        Sitemap_Always,
        Sitemap_Hourly,
        Sitemap_Daily,
        Sitemap_Weekly,
        Sitemap_Monthly,
        Sitemap_Yearly,
        Sitemap_Never,
        ReusableComponentStyle_Tabbed,
        ReusableComponentStyle_Stacked,
        ImageStyle_Square,
        ImageStyle_Landscape,
        ImageStyle_Portrait,
        ImageStyle_Circle,
        ImageStyle_Wide,
        IconShape_Square,
        IconShape_Circle,
        IconShape_Rounded,
        EMPTY,
    }
}