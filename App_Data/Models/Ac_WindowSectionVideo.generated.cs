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
	/// <summary>Window Video</summary>
	[PublishedModel("AC_WindowSectionVideo")]
	public partial class Ac_WindowSectionVideo : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "AC_WindowSectionVideo";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Ac_WindowSectionVideo, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Ac_WindowSectionVideo(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Add color overlay
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("addColorOverlay")]
		public object AddColorOverlay => this.Value("addColorOverlay");

		///<summary>
		/// Background color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("backgroundColor")]
		public string BackgroundColor => this.Value<string>("backgroundColor");

		///<summary>
		/// Image: Focal point is defined within your "Media" section.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("backgroundImage")]
		public IPublishedContent BackgroundImage => this.Value<IPublishedContent>("backgroundImage");

		///<summary>
		/// Button color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("buttonColor")]
		public string ButtonColor => this.Value<string>("buttonColor");

		///<summary>
		/// Image alt text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("imageAltText")]
		public string ImageAltText => this.Value<string>("imageAltText");

		///<summary>
		/// Name: The name you enter is for your reference only and will not appear on the website.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("itemName")]
		public string ItemName => this.Value<string>("itemName");

		///<summary>
		/// Light window footer: This text will be displayed below your video within the light window.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("lightWindowFooter")]
		public string LightWindowFooter => this.Value<string>("lightWindowFooter");

		///<summary>
		/// Light window title: This text will be displayed above your video within the light window.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("lightWindowTitle")]
		public string LightWindowTitle => this.Value<string>("lightWindowTitle");

		///<summary>
		/// Video URL: {p}Copy the full URL for your video from the address bar. YouTube or Vimeo only){/p}
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("videoURL")]
		public string VideoUrl => this.Value<string>("videoURL");
	}
}