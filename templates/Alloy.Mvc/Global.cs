using EPiServer.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Alloy.Mvc
{
    public class Global
    {
        public const string LoginPath = "/util/login";

        /// <summary>
        /// Group names for content types and properties
        /// </summary>
        [GroupDefinitions()]
        public static class GroupNames
        {
            [Display(Name = "Contact", Order = 1)]
            public const string Contact = "Contact";

            [Display(Name = "Default", Order = 2)]
            public const string Default = "Default";

            [Display(Name = "Metadata", Order = 3)]
            public const string MetaData = "Metadata";

            [Display(Name = "News", Order = 4)]
            public const string News = "News";

            [Display(Name = "Products", Order = 5)]
            public const string Products = "Products";

            [Display(Name = "SiteSettings", Order = 6)]
            public const string SiteSettings = "SiteSettings";

            [Display(Name = "Specialized", Order = 7)]
            public const string Specialized = "Specialized";
        }

        /// <summary>
        /// Tags to use for the main widths used in the Bootstrap HTML framework
        /// </summary>
        public static class ContentAreaTags
        {
            public const string FullWidth = "span12";
            public const string TwoThirdsWidth = "span8";
            public const string HalfWidth = "span6";
            public const string OneThirdWidth = "span4";
            public const string NoRenderer = "norenderer";
        }

        /// <summary>
        /// Main widths used in the Bootstrap HTML framework
        /// </summary>
        public static class ContentAreaWidths
        {
            public const int FullWidth = 12;
            public const int TwoThirdsWidth = 8;
            public const int HalfWidth = 6;
            public const int OneThirdWidth = 4;
        }

        public static readonly Dictionary<string, int> ContentAreaTagWidths = new()
        {
            { ContentAreaTags.FullWidth, ContentAreaWidths.FullWidth },
            { ContentAreaTags.TwoThirdsWidth, ContentAreaWidths.TwoThirdsWidth },
            { ContentAreaTags.HalfWidth, ContentAreaWidths.HalfWidth },
            { ContentAreaTags.OneThirdWidth, ContentAreaWidths.OneThirdWidth }
        };

        /// <summary>
        /// Names used for UIHint attributes to map specific rendering controls to page properties
        /// </summary>
        public static class SiteUIHints
        {
            public const string Contact = "contact";
            public const string Strings = "StringList";
            public const string StringsCollection = "StringsCollection";
        }

        /// <summary>
        /// Virtual path to folder with static graphics, such as "/gfx/"
        /// </summary>
        public const string StaticGraphicsFolderPath = "/gfx/";
    }
}
