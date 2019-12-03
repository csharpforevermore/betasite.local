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
	// Mixin Content Type with alias "reusableContent"
	/// <summary>Reusable Content</summary>
	public partial interface IReusableContent : IPublishedContent
	{
		/// <summary>Bottom components</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string BottomComponents { get; }

		/// <summary>Override default bottom components</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		object OverrideDefaultBottomComponents { get; }

		/// <summary>Override default pods</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		object OverrideDefaultPods { get; }

		/// <summary>Override default top components</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		object OverrideDefaultTopComponents { get; }

		/// <summary>Pods</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string PagePods { get; }

		/// <summary>Top components</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		string TopComponents { get; }
	}

	/// <summary>Reusable Content</summary>
	[PublishedModel("reusableContent")]
	public partial class ReusableContent : PublishedContentModel, IReusableContent
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "reusableContent";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ReusableContent, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ReusableContent(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Bottom components: Select the components you would like to appear on this page. The components selected will only be displayed if "Yes" is selected above.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("bottomComponents")]
		public string BottomComponents => GetBottomComponents(this);

		/// <summary>Static getter for Bottom components</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetBottomComponents(IReusableContent that) => that.Value<string>("bottomComponents");

		///<summary>
		/// Override default bottom components: Select "Yes" to override the default components selected within "Global Settings".
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("overrideDefaultBottomComponents")]
		public object OverrideDefaultBottomComponents => GetOverrideDefaultBottomComponents(this);

		/// <summary>Static getter for Override default bottom components</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static object GetOverrideDefaultBottomComponents(IReusableContent that) => that.Value("overrideDefaultBottomComponents");

		///<summary>
		/// Override default pods: Select "Yes" to override the default pods selected within "Global Settings".
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("overrideDefaultPods")]
		public object OverrideDefaultPods => GetOverrideDefaultPods(this);

		/// <summary>Static getter for Override default pods</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static object GetOverrideDefaultPods(IReusableContent that) => that.Value("overrideDefaultPods");

		///<summary>
		/// Override default top components: Select "Yes" to override the default components selected within "Global Settings".
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("overrideDefaultTopComponents")]
		public object OverrideDefaultTopComponents => GetOverrideDefaultTopComponents(this);

		/// <summary>Static getter for Override default top components</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static object GetOverrideDefaultTopComponents(IReusableContent that) => that.Value("overrideDefaultTopComponents");

		///<summary>
		/// Pods: Select the pods you would like to appear on this page. The pods selected will only be displayed if "Yes" is selected above.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("pagePods")]
		public string PagePods => GetPagePods(this);

		/// <summary>Static getter for Pods</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetPagePods(IReusableContent that) => that.Value<string>("pagePods");

		///<summary>
		/// Top components: Select the components you would like to appear on this page. The components selected will only be displayed if "Yes" is selected above.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("topComponents")]
		public string TopComponents => GetTopComponents(this);

		/// <summary>Static getter for Top components</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static string GetTopComponents(IReusableContent that) => that.Value<string>("topComponents");
	}
}
