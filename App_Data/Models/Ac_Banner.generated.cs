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
	/// <summary>Banner</summary>
	[PublishedModel("AC_Banner")]
	public partial class Ac_Banner : PublishedElementModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "AC_Banner";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Ac_Banner, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Ac_Banner(IPublishedElement content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Add color overlay: If “Yes” is selected a semi transparent block of the background color is added over your image.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("addColorOverlay")]
		public bool AddColorOverlay => this.Value<bool>("addColorOverlay");

		///<summary>
		/// Animate
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("animate")]
		public bool Animate => this.Value<bool>("animate");

		///<summary>
		/// Background color: Color selected will dictate the color to be used for any text.  If a background image is used, select the color that works best for the text over the image.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("backgroundColor")]
		public string BackgroundColor => this.Value<string>("backgroundColor");

		///<summary>
		/// Heading: Your heading hierarchy is important for SEO. This will not affect font size.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("bannerHeading")]
		public string BannerHeading => this.Value<string>("bannerHeading");

		///<summary>
		/// Image: Focal point is defined within your "Media" section.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage => this.Value<IPublishedContent>("bannerImage");

		///<summary>
		/// Image alt text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("bannerImageAltText")]
		public string BannerImageAltText => this.Value<string>("bannerImageAltText");

		///<summary>
		/// Link: The "Caption" field will be used for your link text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("bannerLink")]
		public Umbraco.Web.Models.Link BannerLink => this.Value<Umbraco.Web.Models.Link>("bannerLink");

		///<summary>
		/// Secondary heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("bannerSecondaryHeading")]
		public string BannerSecondaryHeading => this.Value<string>("bannerSecondaryHeading");

		///<summary>
		/// Banner style
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("bannerStyle")]
		public Options BannerStyle => this.Value<Options>("bannerStyle");

		///<summary>
		/// Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("bannerText")]
		public IHtmlString BannerText => this.Value<IHtmlString>("bannerText");

		///<summary>
		/// Text alignment
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("bannerTextAlignment")]
		public Options BannerTextAlignment => this.Value<Options>("bannerTextAlignment");

		///<summary>
		/// Button color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("buttonColor")]
		public string ButtonColor => this.Value<string>("buttonColor");

		///<summary>
		/// Content: {div class="panel-body"}{h3}Content{/h3}{/div}
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("content")]
		public string Content => this.Value<string>("content");

		///<summary>
		/// Name: The name you enter is for your reference only and will not appear on the website.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("itemName")]
		public string ItemName => this.Value<string>("itemName");

		///<summary>
		/// Parallax
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("parallax")]
		public bool Parallax => this.Value<bool>("parallax");

		///<summary>
		/// Scroll prompt
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("scrollPrompt")]
		public bool ScrollPrompt => this.Value<bool>("scrollPrompt");

		///<summary>
		/// Settings: {div class="panel-body"}{h3}Settings{/h3}{/div}
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("settings")]
		public string Settings => this.Value<string>("settings");

		///<summary>
		/// Video: MP4 format only. Image above will display until video loads. Small file size recommended for quick downloads.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("video")]
		public IPublishedContent Video => this.Value<IPublishedContent>("video");
	}
}
