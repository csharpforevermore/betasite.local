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
	/// <summary>Navigation</summary>
	[PublishedModel("navigation")]
	public partial class Navigation : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "navigation";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Navigation, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Navigation(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Sitewide call to action link: This link should be used for a main call to action. The link will appear in a prominent position on your website.  The "Caption" field is used for your link text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("ctaLink")]
		public Umbraco.Web.Models.Link CtaLink => this.Value<Umbraco.Web.Models.Link>("ctaLink");

		///<summary>
		/// Disable delete: If "Yes" is selected, when a user attempts to delete this node they will be presented with a warning message indicating that this node cannot be deleted.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("disableDelete")]
		public object DisableDelete => this.Value("disableDelete");

		///<summary>
		/// Display sub pages: If "Yes" is selected, sub pages will be included in the "Main Navigation".
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("displaySubPages")]
		public object DisplaySubPages => this.Value("displaySubPages");

		///<summary>
		/// Footer navigation: Select the links you would like to appear on the "Footer Navigation" of your website.  The "Caption" field is used for your link text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("footerNavigation")]
		public IEnumerable<Umbraco.Web.Models.Link> FooterNavigation => this.Value<IEnumerable<Umbraco.Web.Models.Link>>("footerNavigation");

		///<summary>
		/// Quick links: Select the links you would like to appear on the "Quick links" section of your website.  The "Caption" field is used for your link text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("footerQuickLinks")]
		public IEnumerable<Umbraco.Web.Models.Link> FooterQuickLinks => this.Value<IEnumerable<Umbraco.Web.Models.Link>>("footerQuickLinks");

		///<summary>
		/// Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("footerQuickLinksHeading")]
		public string FooterQuickLinksHeading => this.Value<string>("footerQuickLinksHeading");

		///<summary>
		/// Icon shape: Choose the style that will be applied to your social icon links.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("iconShape")]
		public object IconShape => this.Value("iconShape");

		///<summary>
		/// Instructions: {div class="panel-heading"}{h3 class="panel-title"}Navigation{i class="icon sprTree icon-link color-orange pull-right"}{/i}{/h3}{/div}{div class="panel-body"}{p}This item controls the navigation elements available on your website.{/p} {p}{strong}DO NOT{/strong} delete this item.{/p}{/div}
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("instructions")]
		public string Instructions => this.Value<string>("instructions");

		///<summary>
		/// Logged in members navigation: Select the pages you would like to appear on the "Logged in Members Navigation" of your website.  The "Caption" field is used for your link text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("loggedInMembersNavigation")]
		public IEnumerable<Umbraco.Web.Models.Link> LoggedInMembersNavigation => this.Value<IEnumerable<Umbraco.Web.Models.Link>>("loggedInMembersNavigation");

		///<summary>
		/// Login page
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("loginPage")]
		public IPublishedContent LoginPage => this.Value<IPublishedContent>("loginPage");

		///<summary>
		/// Main navigation: Select the links you would like to appear on the "Main Navigation" of your website.  The "Caption" field is used for your link text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("mainNavigation")]
		public IEnumerable<IPublishedContent> MainNavigation => this.Value<IEnumerable<IPublishedContent>>("mainNavigation");

		///<summary>
		/// Navigation heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("navigationHeading")]
		public string NavigationHeading => this.Value<string>("navigationHeading");

		///<summary>
		/// Secondary navigation: Select the links you would like to appear on the "Secondary Navigation" of your website.  The "Caption" field is used for your link text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("secondaryNavigation")]
		public IEnumerable<Umbraco.Web.Models.Link> SecondaryNavigation => this.Value<IEnumerable<Umbraco.Web.Models.Link>>("secondaryNavigation");

		///<summary>
		/// Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("socialHeading")]
		public string SocialHeading => this.Value<string>("socialHeading");

		///<summary>
		/// Social links
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("socialLinks")]
		public string SocialLinks => this.Value<string>("socialLinks");
	}
}
