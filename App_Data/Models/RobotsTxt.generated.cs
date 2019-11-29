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
	/// <summary>Robots TXT</summary>
	[PublishedModel("robotsTXT")]
	public partial class RobotsTxt : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "robotsTXT";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<RobotsTxt, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public RobotsTxt(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Instructions: {div class="panel-heading"}{h3 class="panel-title"}Robots TXT{i class="icon umb-tree-icon sprTree icon-document-dashed-line color-blue pull-right"}{/i}{/h3}{/div}{div class="panel-body"}{p}This page controls your websites robots.txt file.{/p}{p}Make sure you have the following rewrite rule included in web.config. Text in bold should match your page link.{/p}{pre}&lt;rewrite&gt;       &nbsp;&nbsp;&lt;rules&gt;         &nbsp;&nbsp;&nbsp;&nbsp;&lt;rule name="Robots TXT" stopProcessing="true"&gt;           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;match url="robots.txt" /&gt;           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&lt;action type="Rewrite" url="{strong}robots-txt{/strong}" /&gt;         &nbsp;&nbsp;&nbsp;&nbsp;&lt;/rule&gt;       &nbsp;&nbsp;&lt;/rules&gt;     &lt;/rewrite&gt;{/pre}{p}{a href="https://www.iis.net/downloads/microsoft/url-rewrite" target="_blank" title="Link will open in a new window/tab"}IIS URL Rewrite module{/a} must be installed on your webserver to use this feature.{/p}{/div}
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("instructions")]
		public string Instructions => this.Value<string>("instructions");
	}
}