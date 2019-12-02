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
	/// <summary>Newsletter Form</summary>
	[PublishedModel("newsletterForm")]
	public partial class NewsletterForm : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "newsletterForm";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<NewsletterForm, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public NewsletterForm(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Button text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("newsletterButtonText")]
		public string NewsletterButtonText => this.Value<string>("newsletterButtonText");

		///<summary>
		/// Heading: Your heading hierarchy is important for SEO. This will not affect font size.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("newsletterHeading")]
		public Newtonsoft.Json.Linq.JToken NewsletterHeading => this.Value<Newtonsoft.Json.Linq.JToken>("newsletterHeading");

		///<summary>
		/// Introduction
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("newsletterIntroduction")]
		public IHtmlString NewsletterIntroduction => this.Value<IHtmlString>("newsletterIntroduction");

		///<summary>
		/// Secondary heading
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("newsletterSecondaryHeading")]
		public string NewsletterSecondaryHeading => this.Value<string>("newsletterSecondaryHeading");

		///<summary>
		/// Submission message
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("newsletterSubmissionMessage")]
		public IHtmlString NewsletterSubmissionMessage => this.Value<IHtmlString>("newsletterSubmissionMessage");

		///<summary>
		/// Subscriber list ID: Newsletter Signup will only be available if a Subscriber List ID is available. Use this field to override the default Subscriber List ID in "Global Settings" if present.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("newsletterSubscriberListID")]
		public string NewsletterSubscriberListID => this.Value<string>("newsletterSubscriberListID");
	}
}