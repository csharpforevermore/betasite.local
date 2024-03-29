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
	// Mixin Content Type with alias "componentIntroOutro"
	/// <summary>Component Intro/Outro</summary>
	public partial interface IComponentIntroOutro : IPublishedContent
	{
		/// <summary>Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string IntroductionHeading { get; }

		/// <summary>Links</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		IEnumerable<Umbraco.Web.Models.Link> IntroductionLinks { get; }

		/// <summary>Secondary heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string IntroductionSecondaryHeading { get; }

		/// <summary>Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		IHtmlString IntroductionText { get; }

		/// <summary>Text alignment</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		Options IntroductionTextAlignment { get; }

		/// <summary>Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		Newtonsoft.Json.Linq.JToken OutroHeading { get; }

		/// <summary>Links</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		IEnumerable<Umbraco.Web.Models.Link> OutroLinks { get; }

		/// <summary>Secondary heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string OutroSecondaryHeading { get; }

		/// <summary>Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		IHtmlString OutroText { get; }

		/// <summary>Text alignment</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		Options OutroTextAlignment { get; }
	}

	/// <summary>Component Intro/Outro</summary>
	[PublishedModel("componentIntroOutro")]
	public partial class ComponentIntroOutro : PublishedContentModel, IComponentIntroOutro
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "componentIntroOutro";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ComponentIntroOutro, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ComponentIntroOutro(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Heading: Your heading hierarchy is important for SEO. This will not affect font size.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("introductionHeading")]
		public string IntroductionHeading => GetIntroductionHeading(this);

		/// <summary>Static getter for Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetIntroductionHeading(IComponentIntroOutro that) => that.Value<string>("introductionHeading");

		///<summary>
		/// Links: The "Caption" field will be used for your link text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("introductionLinks")]
		public IEnumerable<Umbraco.Web.Models.Link> IntroductionLinks => GetIntroductionLinks(this);

		/// <summary>Static getter for Links</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IEnumerable<Umbraco.Web.Models.Link> GetIntroductionLinks(IComponentIntroOutro that) => that.Value<IEnumerable<Umbraco.Web.Models.Link>>("introductionLinks");

		///<summary>
		/// Secondary heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("introductionSecondaryHeading")]
		public string IntroductionSecondaryHeading => GetIntroductionSecondaryHeading(this);

		/// <summary>Static getter for Secondary heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetIntroductionSecondaryHeading(IComponentIntroOutro that) => that.Value<string>("introductionSecondaryHeading");

		///<summary>
		/// Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("introductionText")]
		public IHtmlString IntroductionText => GetIntroductionText(this);

		/// <summary>Static getter for Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IHtmlString GetIntroductionText(IComponentIntroOutro that) => that.Value<IHtmlString>("introductionText");

		///<summary>
		/// Text alignment
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("introductionTextAlignment")]
		public Options IntroductionTextAlignment => GetIntroductionTextAlignment(this);

		/// <summary>Static getter for Text alignment</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static Options GetIntroductionTextAlignment(IComponentIntroOutro that) => that.Value<Options>("introductionTextAlignment");

		///<summary>
		/// Heading: Your heading hierarchy is important for SEO. This will not affect font size.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("outroHeading")]
		public Newtonsoft.Json.Linq.JToken OutroHeading => GetOutroHeading(this);

		/// <summary>Static getter for Heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static Newtonsoft.Json.Linq.JToken GetOutroHeading(IComponentIntroOutro that) => that.Value<Newtonsoft.Json.Linq.JToken>("outroHeading");

		///<summary>
		/// Links: The "Caption" field will be used for your link text.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("outroLinks")]
		public IEnumerable<Umbraco.Web.Models.Link> OutroLinks => GetOutroLinks(this);

		/// <summary>Static getter for Links</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IEnumerable<Umbraco.Web.Models.Link> GetOutroLinks(IComponentIntroOutro that) => that.Value<IEnumerable<Umbraco.Web.Models.Link>>("outroLinks");

		///<summary>
		/// Secondary heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("outroSecondaryHeading")]
		public string OutroSecondaryHeading => GetOutroSecondaryHeading(this);

		/// <summary>Static getter for Secondary heading</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetOutroSecondaryHeading(IComponentIntroOutro that) => that.Value<string>("outroSecondaryHeading");

		///<summary>
		/// Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("outroText")]
		public IHtmlString OutroText => GetOutroText(this);

		/// <summary>Static getter for Text</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IHtmlString GetOutroText(IComponentIntroOutro that) => that.Value<IHtmlString>("outroText");

		///<summary>
		/// Text alignment
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("outroTextAlignment")]
		public Options OutroTextAlignment => GetOutroTextAlignment(this);

		/// <summary>Static getter for Text alignment</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static Options GetOutroTextAlignment(IComponentIntroOutro that) => that.Value<Options>("outroTextAlignment");
	}
}
