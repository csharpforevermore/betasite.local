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
	// Mixin Content Type with alias "pageGenericProperties"
	/// <summary>Page Generic Properties</summary>
	public partial interface IPageGenericProperties : IPublishedContent
	{
		/// <summary>Custom body classes</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string CustomBodyClasses { get; }

		/// <summary>Hide website footer section</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		bool HideWebsiteFooterSection { get; }

		/// <summary>Hide website header section</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		bool HideWebsiteHeaderSection { get; }
	}

	/// <summary>Page Generic Properties</summary>
	[PublishedModel("pageGenericProperties")]
	public partial class PageGenericProperties : PublishedContentModel, IPageGenericProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "pageGenericProperties";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<PageGenericProperties, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public PageGenericProperties(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Custom body classes: Override the default styles of this page by adding page specific classes. Leave a space between each class e.g. custom-class another-class
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("customBodyClasses")]
		public string CustomBodyClasses => GetCustomBodyClasses(this);

		/// <summary>Static getter for Custom body classes</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetCustomBodyClasses(IPageGenericProperties that) => that.Value<string>("customBodyClasses");

		///<summary>
		/// Hide website footer section: Remove the global footer content at the end of this page. For example, contact information and navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideWebsiteFooterSection")]
		public bool HideWebsiteFooterSection => GetHideWebsiteFooterSection(this);

		/// <summary>Static getter for Hide website footer section</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static bool GetHideWebsiteFooterSection(IPageGenericProperties that) => that.Value<bool>("hideWebsiteFooterSection");

		///<summary>
		/// Hide website header section: Remove the global header content at the start of this page. For example, logo and navigation.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("hideWebsiteHeaderSection")]
		public bool HideWebsiteHeaderSection => GetHideWebsiteHeaderSection(this);

		/// <summary>Static getter for Hide website header section</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static bool GetHideWebsiteHeaderSection(IPageGenericProperties that) => that.Value<bool>("hideWebsiteHeaderSection");
	}
}
