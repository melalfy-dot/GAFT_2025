//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.8.0+a486d5d
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	// Mixin Content Type with alias "pageProperties"
	/// <summary>Page Properties</summary>
	public partial interface IPageProperties : IPublishedContent
	{
		/// <summary>CssClass</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string CssClass { get; }

		/// <summary>Page Icon</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::Umbraco.Cms.Core.Models.MediaWithCrops PageIcon { get; }

		/// <summary>Redirect URL</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> RedirectUrl { get; }

		/// <summary>Show breadcrumb</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		bool ShowBreadcrumb { get; }

		/// <summary>Show Coming Soon</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		bool ShowComingSoon { get; }

		/// <summary>Show in main menu</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		bool ShowInMainMenu { get; }

		/// <summary>Show in site map</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		bool ShowInSiteMap { get; }

		/// <summary>Show Page Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		bool ShowPageTitle { get; }

		/// <summary>Show sharing icons</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		bool ShowSharingIcons { get; }
	}

	/// <summary>Page Properties</summary>
	[PublishedModel("pageProperties")]
	public partial class PageProperties : PublishedContentModel, IPageProperties
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		public new const string ModelTypeAlias = "pageProperties";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<PageProperties, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public PageProperties(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// CssClass
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("cssClass")]
		public virtual string CssClass => GetCssClass(this, _publishedValueFallback);

		/// <summary>Static getter for CssClass</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetCssClass(IPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "cssClass");

		///<summary>
		/// Page Icon
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageIcon")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops PageIcon => GetPageIcon(this, _publishedValueFallback);

		/// <summary>Static getter for Page Icon</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::Umbraco.Cms.Core.Models.MediaWithCrops GetPageIcon(IPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(publishedValueFallback, "pageIcon");

		///<summary>
		/// Redirect URL
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("redirectURL")]
		public virtual global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> RedirectUrl => GetRedirectUrl(this, _publishedValueFallback);

		/// <summary>Static getter for Redirect URL</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link> GetRedirectUrl(IPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<global::System.Collections.Generic.IEnumerable<global::Umbraco.Cms.Core.Models.Link>>(publishedValueFallback, "redirectURL");

		///<summary>
		/// Show breadcrumb
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[ImplementPropertyType("showBreadcrumb")]
		public virtual bool ShowBreadcrumb => GetShowBreadcrumb(this, _publishedValueFallback);

		/// <summary>Static getter for Show breadcrumb</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		public static bool GetShowBreadcrumb(IPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "showBreadcrumb");

		///<summary>
		/// Show Coming Soon
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[ImplementPropertyType("showComingSoon")]
		public virtual bool ShowComingSoon => GetShowComingSoon(this, _publishedValueFallback);

		/// <summary>Static getter for Show Coming Soon</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		public static bool GetShowComingSoon(IPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "showComingSoon");

		///<summary>
		/// Show in main menu
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[ImplementPropertyType("showInMainMenu")]
		public virtual bool ShowInMainMenu => GetShowInMainMenu(this, _publishedValueFallback);

		/// <summary>Static getter for Show in main menu</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		public static bool GetShowInMainMenu(IPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "showInMainMenu");

		///<summary>
		/// Show in site map
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[ImplementPropertyType("showInSiteMap")]
		public virtual bool ShowInSiteMap => GetShowInSiteMap(this, _publishedValueFallback);

		/// <summary>Static getter for Show in site map</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		public static bool GetShowInSiteMap(IPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "showInSiteMap");

		///<summary>
		/// Show Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[ImplementPropertyType("showPageTitle")]
		public virtual bool ShowPageTitle => GetShowPageTitle(this, _publishedValueFallback);

		/// <summary>Static getter for Show Page Title</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		public static bool GetShowPageTitle(IPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "showPageTitle");

		///<summary>
		/// Show sharing icons
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		[ImplementPropertyType("showSharingIcons")]
		public virtual bool ShowSharingIcons => GetShowSharingIcons(this, _publishedValueFallback);

		/// <summary>Static getter for Show sharing icons</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.8.0+a486d5d")]
		public static bool GetShowSharingIcons(IPageProperties that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "showSharingIcons");
	}
}
