//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.1.0
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>Homepage</summary>
	[PublishedModel("homepage")]
	public partial class Homepage : PublishedContentModel, IDisableDeleteFunction, IPageGenericProperties, IPageNavigationSettings, IReusableContent, IScripts, ISEO
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "homepage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Homepage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Homepage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Instructions: {div class="panel-heading"}{h3 class="panel-title"}Homepage{i class="icon umb-tree-icon sprTree icon-home pull-right"}{/i}{/h3}{/div}{div class="panel-body"}{p}To add content to this page you are required to add components to the "Components" folder directly below this page.{/p}{p}By adding new components you will be able to organise the layout and content of this page.{/p}{/div}
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("instructions")]
		public string Instructions => this.Value<string>("instructions");

		///<summary>
		/// Sitemap link text: Node name will be used by default if nothing is entered.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("sitemapLinkText")]
		public string SitemapLinkText => this.Value<string>("sitemapLinkText");

		///<summary>
		/// Disable delete: If "Yes" is selected, when a user attempts to delete this node they will be presented with a warning message indicating that this node cannot be deleted.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("disableDelete")]
		public bool DisableDelete => DisableDeleteFunction.GetDisableDelete(this);

		///<summary>
		/// Custom body classes: Override the default styles of this page by adding page specific classes. Leave a space between each class e.g. custom-class another-class
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("customBodyClasses")]
		public string CustomBodyClasses => PageGenericProperties.GetCustomBodyClasses(this);

		///<summary>
		/// Hide website footer section: Remove the global footer content at the end of this page. For example, contact information and navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideWebsiteFooterSection")]
		public bool HideWebsiteFooterSection => PageGenericProperties.GetHideWebsiteFooterSection(this);

		///<summary>
		/// Hide website header section: Remove the global header content at the start of this page. For example, logo and navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideWebsiteHeaderSection")]
		public bool HideWebsiteHeaderSection => PageGenericProperties.GetHideWebsiteHeaderSection(this);

		///<summary>
		/// Breadcrumb link text: Node name will be used by default if nothing is entered.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("breadcrumbLinkText")]
		public string BreadcrumbLinkText => PageNavigationSettings.GetBreadcrumbLinkText(this);

		///<summary>
		/// Hide breadcrumb
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideBreadcrumb")]
		public bool HideBreadcrumb => PageNavigationSettings.GetHideBreadcrumb(this);

		///<summary>
		/// Hide from all navigation: Prevents this page from being shown in most menus
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide => PageNavigationSettings.GetUmbracoNaviHide(this);

		///<summary>
		/// Bottom components: Select the components you would like to appear on this page. The components selected will only be displayed if "Yes" is selected above.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("bottomComponents")]
		public string BottomComponents => ReusableContent.GetBottomComponents(this);

		///<summary>
		/// Override default bottom components: Select "Yes" to override the default components selected within "Global Settings".
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("overrideDefaultBottomComponents")]
		public bool OverrideDefaultBottomComponents => ReusableContent.GetOverrideDefaultBottomComponents(this);

		///<summary>
		/// Override default pods: Select "Yes" to override the default pods selected within "Global Settings".
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("overrideDefaultPods")]
		public bool OverrideDefaultPods => ReusableContent.GetOverrideDefaultPods(this);

		///<summary>
		/// Override default top components: Select "Yes" to override the default components selected within "Global Settings".
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("overrideDefaultTopComponents")]
		public bool OverrideDefaultTopComponents => ReusableContent.GetOverrideDefaultTopComponents(this);

		///<summary>
		/// Pods: Select the pods you would like to appear on this page. The pods selected will only be displayed if "Yes" is selected above.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pagePods")]
		public string PagePods => ReusableContent.GetPagePods(this);

		///<summary>
		/// Top components: Select the components you would like to appear on this page. The components selected will only be displayed if "Yes" is selected above.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("topComponents")]
		public IEnumerable<IPublishedContent> TopComponents => ReusableContent.GetTopComponents(this);

		///<summary>
		/// After opening body scripts
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pageAfterOpeningBodyScripts")]
		public string PageAfterOpeningBodyScripts => Scripts.GetPageAfterOpeningBodyScripts(this);

		///<summary>
		/// Before closing body scripts: Anything you enter here will be placed before the closing &lt;/body&gt; tag on this page of your website.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pageBeforeClosingBodyScripts")]
		public string PageBeforeClosingBodyScripts => Scripts.GetPageBeforeClosingBodyScripts(this);

		///<summary>
		/// Header scripts: Anything you enter here will be placed before the closing &lt;/head&gt; tag on this page of your website.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pageHeaderScripts")]
		public string PageHeaderScripts => Scripts.GetPageHeaderScripts(this);

		///<summary>
		/// Hide from search engines: This will add a noindex meta tag to your page and exclude this page from your sitemap.xml
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideFromSearchEngines")]
		public bool HideFromSearchEngines => SEO.GetHideFromSearchEngines(this);

		///<summary>
		/// Meta description: This is shown in search engines, when the page is shared via social media and in your sites own search results. Try to keep this below 155 characters.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => SEO.GetMetaDescription(this);

		///<summary>
		/// Open Graph image: The image used when someone shares the page on social media, such as, Twitter or Facebook.  We suggest that you use an image of at least 1200x630 pixels.  If nothing is uploaded here the "Default Open Graph image" from your "Global Settings" will be used.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("openGraphImage")]
		public IPublishedContent OpenGraphImage => SEO.GetOpenGraphImage(this);

		///<summary>
		/// Web page title: This is shown in search engines, web browsers and when the page is shared via social media. If left empty the default page title will be used.  The default page title will be a combination of the current page node name and the website name defined in "Global Settings".
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pageTitle")]
		public string PageTitle => SEO.GetPageTitle(this);

		///<summary>
		/// Sitemap XML change frequency
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("sitemapXMLChangeFrequency")]
		public object SitemapXmlchangeFrequency => SEO.GetSitemapXmlchangeFrequency(this);

		///<summary>
		/// Sitemap XML priority
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("sitemapXMLPriority")]
		public decimal SitemapXmlpriority => SEO.GetSitemapXmlpriority(this);

		///<summary>
		/// Twitter creator username: Username for the content creator/author used in the twitter card.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("twitterCreatorUsername")]
		public object TwitterCreatorUsername => SEO.GetTwitterCreatorUsername(this);

		///<summary>
		/// Alternative URL: Use this field to provide multiple URLs for a content node.  For example if you were to enter "examplepage1,examplepage2/this-is-a-test", this would resolve the following URLs to the same page.  /examplepage1/ /examplepage2/this-is-a-test/  Please note that the values you use must be lowercase, not use a leading slash and not use a file extension.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("umbracoUrlAlias")]
		public string UmbracoUrlAlias => SEO.GetUmbracoUrlAlias(this);
	}
}
