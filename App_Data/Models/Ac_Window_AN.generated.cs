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
	/// <summary>Windows</summary>
	[PublishedModel("AC_Window_AN")]
	public partial class Ac_Window_AN : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "AC_Window_AN";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Ac_Window_AN, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Ac_Window_AN(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Animate
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("animate")]
		public bool Animate => this.Value<bool>("animate");

		///<summary>
		/// Background color: Color selected will dictate the color to be used for any text. If a background image is used, select the color that works best for the text over the image.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("backgroundColor")]
		public string BackgroundColor => this.Value<string>("backgroundColor");

		///<summary>
		/// Background image: No recommended image size. To cover the full area of the component use a large image. Use a small image to repeat.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("backgroundImage")]
		public IPublishedContent BackgroundImage => this.Value<IPublishedContent>("backgroundImage");

		///<summary>
		/// Background image options
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("backgroundImageOptions")]
		public Newtonsoft.Json.Linq.JToken BackgroundImageOptions => this.Value<Newtonsoft.Json.Linq.JToken>("backgroundImageOptions");

		///<summary>
		/// Button color
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("buttonColor")]
		public string ButtonColor => this.Value<string>("buttonColor");

		///<summary>
		/// Fixed width: If set to yes, this will constrain your 'Window Section' to a maximum width.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("fixedWidth")]
		public bool FixedWidth => this.Value<bool>("fixedWidth");

		///<summary>
		/// Image order
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("imageOrder")]
		public Options ImageOrder => this.Value<Options>("imageOrder");

		///<summary>
		/// Instructions: {div class="panel-heading"}{h3 class="panel-title"}Windows{i class="icon sprTree icon-windows color-orange pull-right"}{/i}{/h3}{/div}{div class="panel-body"}{p}The node name you enter above is for your reference only and will not appear on the website.{/p}{/div}
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("instructions")]
		public string Instructions => this.Value<string>("instructions");
	}
}
