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
	/// <summary>Links</summary>
	[PublishedModel("SC_Links_AN")]
	public partial class Sc_Links_AN : PublishedContentModel, IAdvancedPageSettings, IComponentIntroOutro, ICustomComponentClassesComponent
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "SC_Links_AN";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Sc_Links_AN, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Sc_Links_AN(IPublishedContent content)
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
		/// Group Links: The 'Caption' field will be used for your link text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("groupLinks")]
		public IEnumerable<Umbraco.Web.Models.Link> GroupLinks => this.Value<IEnumerable<Umbraco.Web.Models.Link>>("groupLinks");

		///<summary>
		/// Instructions: {div class="panel-heading"}{h3 class="panel-title"}Links{i class="icon sprTree icon-link color-orange pull-right"}{/i}{/h3}{/div}{div class="panel-body"}{p}The node name you enter above is for your reference only and will not appear on the website.{/p}{/div}
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("instructions")]
		public string Instructions => this.Value<string>("instructions");

		///<summary>
		/// Instructions: {div class="panel-body"}{p}These settings only apply if this component has been added to the "Homepage" or an "Advanced Page / Advanced Page Blog Post".{/p}{/div}
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("apsInstructions")]
		public string ApsInstructions => AdvancedPageSettings.GetApsInstructions(this);

		///<summary>
		/// Background Colour: Color selected will dictate the color to be used for any text.  If a background image is used, select the color that works best for the text over the image.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("backgroundColour")]
		public string BackgroundColour => AdvancedPageSettings.GetBackgroundColour(this);

		///<summary>
		/// Background image: No recommended image size. To cover the full area of the component use a large image. Use a small image to repeat.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("backgroundImage")]
		public IPublishedContent BackgroundImage => AdvancedPageSettings.GetBackgroundImage(this);

		///<summary>
		/// Background image options
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("backgroundImageOptions")]
		public Newtonsoft.Json.Linq.JToken BackgroundImageOptions => AdvancedPageSettings.GetBackgroundImageOptions(this);

		///<summary>
		/// Button color: Selects the colour of the button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("buttonColor")]
		public string ButtonColor => AdvancedPageSettings.GetButtonColor(this);

		///<summary>
		/// Component width
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("width")]
		public Options Width => AdvancedPageSettings.GetWidth(this);

		///<summary>
		/// Heading: Your heading hierarchy is important for SEO. This will not affect font size.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("introductionHeading")]
		public string IntroductionHeading => ComponentIntroOutro.GetIntroductionHeading(this);

		///<summary>
		/// Links: The "Caption" field will be used for your link text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("introductionLinks")]
		public IEnumerable<Umbraco.Web.Models.Link> IntroductionLinks => ComponentIntroOutro.GetIntroductionLinks(this);

		///<summary>
		/// Secondary heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("introductionSecondaryHeading")]
		public string IntroductionSecondaryHeading => ComponentIntroOutro.GetIntroductionSecondaryHeading(this);

		///<summary>
		/// Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("introductionText")]
		public IHtmlString IntroductionText => ComponentIntroOutro.GetIntroductionText(this);

		///<summary>
		/// Text alignment
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("introductionTextAlignment")]
		public Options IntroductionTextAlignment => ComponentIntroOutro.GetIntroductionTextAlignment(this);

		///<summary>
		/// Heading: Your heading hierarchy is important for SEO. This will not affect font size.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("outroHeading")]
		public Newtonsoft.Json.Linq.JToken OutroHeading => ComponentIntroOutro.GetOutroHeading(this);

		///<summary>
		/// Links: The "Caption" field will be used for your link text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("outroLinks")]
		public IEnumerable<Umbraco.Web.Models.Link> OutroLinks => ComponentIntroOutro.GetOutroLinks(this);

		///<summary>
		/// Secondary heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("outroSecondaryHeading")]
		public string OutroSecondaryHeading => ComponentIntroOutro.GetOutroSecondaryHeading(this);

		///<summary>
		/// Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("outroText")]
		public IHtmlString OutroText => ComponentIntroOutro.GetOutroText(this);

		///<summary>
		/// Text alignment
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("outroTextAlignment")]
		public Options OutroTextAlignment => ComponentIntroOutro.GetOutroTextAlignment(this);

		///<summary>
		/// Custom component classes: Add your own touch with specific classes. Leave a space between each class e.g. custom-class another-class
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("customComponentClasses")]
		public string CustomComponentClasses => CustomComponentClassesComponent.GetCustomComponentClasses(this);
	}
}
