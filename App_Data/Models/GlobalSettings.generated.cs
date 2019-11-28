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
	/// <summary>Global Settings</summary>
	[PublishedModel("globalSettings")]
	public partial class GlobalSettings : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "globalSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GlobalSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public GlobalSettings(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Accept notification button text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("acceptNotificationButtonText")]
		public string AcceptNotificationButtonText => this.Value<string>("acceptNotificationButtonText");

		///<summary>
		/// Address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("address")]
		public IHtmlString Address => this.Value<IHtmlString>("address");

		///<summary>
		/// After opening body scripts: Anything you enter here will be placed after the opening &lt;body&gt; tag on every page of your website.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("afterOpeningBodyScripts")]
		public string AfterOpeningBodyScripts => this.Value<string>("afterOpeningBodyScripts");

		///<summary>
		/// Before closing body scripts: Anything you enter here will be placed before the closing &lt;/body&gt; tag on every page of your website.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("beforeClosingBodyScripts")]
		public string BeforeClosingBodyScripts => this.Value<string>("beforeClosingBodyScripts");

		///<summary>
		/// Company name
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("companyName")]
		public string CompanyName => this.Value<string>("companyName");

		///<summary>
		/// Default bottom components: Select the default components you would like to appear before the footer of your website.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("defaultBottomComponents")]
		public string DefaultBottomComponents => this.Value<string>("defaultBottomComponents");

		///<summary>
		/// Default Subscriber list ID: Newsletter Signup will only be available if a Subscriber List ID is available. Individual signup forms can have their own Subscriber List ID however the one entered here will be used as the default.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("defaultNewsletterSubscriberListID")]
		public string DefaultNewsletterSubscriberListID => this.Value<string>("defaultNewsletterSubscriberListID");

		///<summary>
		/// Default standard page layout: If 'Wide' is selected sub navigation will be hidden.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("defaultPageLayout")]
		public string DefaultPageLayout => this.Value<string>("defaultPageLayout");

		///<summary>
		/// Default pods: Select the default pods you would like to appear on your website.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("defaultSitewidePods")]
		public string DefaultSitewidePods => this.Value<string>("defaultSitewidePods");

		///<summary>
		/// Default top components: Select the default components you would like to appear at the top of your website.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("defaultTopComponents")]
		public string DefaultTopComponents => this.Value<string>("defaultTopComponents");

		///<summary>
		/// Disable delete: If "Yes" is selected, when a user attempts to delete this node they will be presented with a warning message indicating that this node cannot be deleted.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("disableDelete")]
		public object DisableDelete => this.Value("disableDelete");

		///<summary>
		/// Disqus username: If nothing is entered, blog commenting will be disabled.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("disqusUsername")]
		public string DisqusUsername => this.Value<string>("disqusUsername");

		///<summary>
		/// Email address
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("emailAddress")]
		public string EmailAddress => this.Value<string>("emailAddress");

		///<summary>
		/// Email marketing platform: If nothing is selected Newsletter Signup will not be available.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("emailMarketingPlatform")]
		public object EmailMarketingPlatform => this.Value("emailMarketingPlatform");

		///<summary>
		/// Enable
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("enable")]
		public object Enable => this.Value("enable");

		///<summary>
		/// Favicon and touch icons: This image will be used for your website favicon and device bookmarks. We suggest that you use an image of at least 310x310 pixels.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("faviconAndTouchIcons")]
		public IPublishedContent FaviconAndTouchIcons => this.Value<IPublishedContent>("faviconAndTouchIcons");

		///<summary>
		/// Fixed width: If set to yes, this will add a maximum width to the overall site content.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("fixedWidth")]
		public object FixedWidth => this.Value("fixedWidth");

		///<summary>
		/// Google reCAPTCHA V2 secret key
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("googleReCAPTCHASecretKey")]
		public string GoogleReCaptchasecretKey => this.Value<string>("googleReCAPTCHASecretKey");

		///<summary>
		/// Google reCAPTCHA V2 site key: Google reCAPTCHA V2 will be displayed on Contact Forms and Newsletter Signup Forms if a site key and secret key have been entered here.  {a href="https://www.google.com/recaptcha/" target="_blank"}https://www.google.com/recaptcha/{a/}
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("googleReCAPTCHASiteKey")]
		public string GoogleReCaptchasiteKey => this.Value<string>("googleReCAPTCHASiteKey");

		///<summary>
		/// Header scripts: Anything you enter here will be placed before the closing &lt;/head&gt; tag on every page of your website.  Example usage would be for entering Google Analytics Script code.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("headerScripts")]
		public string HeaderScripts => this.Value<string>("headerScripts");

		///<summary>
		/// Instructions: {div class="panel-heading"}{h3 class="panel-title"}Global Settings{i class="icon sprTree icon-globe-inverted-europe-africa color-orange pull-right"}{/i}{/h3}{/div}{div class="panel-body"}{p}This item controls global settings that relate to your website as a whole.{/p} {p}{strong}DO NOT{/strong} delete this item.{/p}{/div}
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("instructions")]
		public string Instructions => this.Value<string>("instructions");

		///<summary>
		/// API key: If nothing is entered Newsletter Signup will not be available.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("newsletterAPIKey")]
		public string NewsletterApikey => this.Value<string>("newsletterAPIKey");

		///<summary>
		/// Heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("notificationHeading")]
		public string NotificationHeading => this.Value<string>("notificationHeading");

		///<summary>
		/// Secondary heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("notificationSecondaryHeading")]
		public string NotificationSecondaryHeading => this.Value<string>("notificationSecondaryHeading");

		///<summary>
		/// Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("notificationText")]
		public IHtmlString NotificationText => this.Value<IHtmlString>("notificationText");

		///<summary>
		/// Default Open Graph image: The default image used when someone shares a page on social media, such as, Twitter or Facebook.  We suggest that you use an image of at least 1200x630 pixels.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("openGraphDefaultImage")]
		public IPublishedContent OpenGraphDefaultImage => this.Value<IPublishedContent>("openGraphDefaultImage");

		///<summary>
		/// Remember acceptance duration (days): If nothing is entered this will default to 365 days.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("rememberAcceptanceDurationDays")]
		public int RememberAcceptanceDurationDays => this.Value<int>("rememberAcceptanceDurationDays");

		///<summary>
		/// Search results page: If no page is selected the search form will not appear.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("searchResultsPage")]
		public IPublishedContent SearchResultsPage => this.Value<IPublishedContent>("searchResultsPage");

		///<summary>
		/// Telephone number
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("telephoneNumber")]
		public string TelephoneNumber => this.Value<string>("telephoneNumber");

		///<summary>
		/// Twitter site username: Username for the website used in the twitter card footer.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("twitterSiteUsername")]
		public object TwitterSiteUsername => this.Value("twitterSiteUsername");

		///<summary>
		/// Website logo: We suggest that you use an image of at least 240 pixels in height. This is to ensure your logo is ready for both retina and non-retina displays.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("websiteLogo")]
		public IPublishedContent WebsiteLogo => this.Value<IPublishedContent>("websiteLogo");

		///<summary>
		/// Website name: The text entered here will be be added to the default Meta title of your webpages and used for the hidden text behind your website logo.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("websiteName")]
		public string WebsiteName => this.Value<string>("websiteName");
	}
}
