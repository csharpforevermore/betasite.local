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
	/// <summary>Blog Month Folder</summary>
	[PublishedModel("blogMonthFolder")]
	public partial class BlogMonthFolder : PublishedContentModel, IDisableDeleteFunction
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "blogMonthFolder";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<BlogMonthFolder, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public BlogMonthFolder(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Instructions: {div class="panel-heading"}{h3 class="panel-title"}Blog Month Folder{i class="icon sprTree icon-calendar-alt color-orange pull-right"}{/i}{/h3}{/div}{div class="panel-body"}{p}This folder is created automatically based on your blog posts.{/p}{p}Below this folder you will find your "Blog Posts".{/p}{p}"Blog Posts" must be added to the "Blog Posts Folder"  above.{/p}{/div}
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("instructions")]
		public string Instructions => this.Value<string>("instructions");

		///<summary>
		/// Disable delete: If "Yes" is selected, when a user attempts to delete this node they will be presented with a warning message indicating that this node cannot be deleted.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("disableDelete")]
		public object DisableDelete => DisableDeleteFunction.GetDisableDelete(this);
	}
}
