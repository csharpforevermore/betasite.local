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
	/// <summary>Video</summary>
	[PublishedModel("SC_GalleryVideo")]
	public partial class Sc_GalleryVideo : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const string ModelTypeAlias = "SC_GalleryVideo";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Sc_GalleryVideo, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Sc_GalleryVideo(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Disable light window
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("disableLightWindow")]
		public bool DisableLightWindow => this.Value<bool>("disableLightWindow");

		///<summary>
		/// Image: Focal point is defined within your "Media" section.  This image is optional. If you do not upload an image, a thumbnail image will be automatically generated for you from the associated video.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("galleryThumbnailImage")]
		public IPublishedContent GalleryThumbnailImage => this.Value<IPublishedContent>("galleryThumbnailImage");

		///<summary>
		/// Video: Copy the full URL for your video from the address bar. (YouTube or Vimeo only)
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("galleryVideo")]
		public string GalleryVideo => this.Value<string>("galleryVideo");

		///<summary>
		/// Name: The name you enter is for your reference only and will not appear on the website.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("itemName")]
		public string ItemName => this.Value<string>("itemName");

		///<summary>
		/// Light window footer: This text will be displayed below your image within the light window.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("lightWindowFooter")]
		public string LightWindowFooter => this.Value<string>("lightWindowFooter");

		///<summary>
		/// Light window title: This text will be displayed above your image within the light window.
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("lightWindowTitle")]
		public string LightWindowTitle => this.Value<string>("lightWindowTitle");

		///<summary>
		/// Image alt text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("thumbnailImageAltText")]
		public string ThumbnailImageAltText => this.Value<string>("thumbnailImageAltText");

		///<summary>
		/// Video caption
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.1.0")]
		[ImplementPropertyType("videoCaption")]
		public string VideoCaption => this.Value<string>("videoCaption");
	}
}
