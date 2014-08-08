using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleSite.Helpers
{
    public class GravatarOptions
    {
        public string DefaultImageType { get; set; }
        public string RatingLevel { get; set; }
        public int Size { get; set; }
        public string CssClass { get; set; }

        public class DefaultImage
        {
            public const string Default = "";
            public const string Http404 = "404";
            public const string MysteryMan = "mm";
            public const string Identicon = "identicon";
            public const string MonsterId = "monsterid";
            public const string Wavatar = "wavatar";
            public const string Retro = "retro";
        }

        public class Rating
        {
            public const string G = "g";
            public const string PG = "pg";
            public const string R = "r";
            public const string X = "x";
        }


        internal static GravatarOptions GetDefaults()
        {
            return new GravatarOptions
            {
                DefaultImageType = GravatarOptions.DefaultImage.Retro,
                Size = 150,
                RatingLevel = GravatarOptions.Rating.G
            };
        }
    }
}