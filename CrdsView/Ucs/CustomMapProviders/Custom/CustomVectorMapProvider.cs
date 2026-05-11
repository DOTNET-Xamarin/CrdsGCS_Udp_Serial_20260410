using System;
using GMap.NET.MapProviders.Custom.Internal;

namespace GMap.NET.MapProviders.Custom
{
    public class CustomVectorMapProvider : CustomMapProviderBase
    {
        public static readonly CustomVectorMapProvider Instance =
            new CustomVectorMapProvider();

        private GMapProvider[] _overlays;

        private CustomVectorMapProvider() : base(7)
        {
        }

        public string ServerUrlCustom = "http://localhost/Coast3857/" +
                                        "{z}/{x}/{y}.png";

        private string ServerUrlFormatString(string strUrl)
        {
            return strUrl.Replace("{x}", "{0}")
            .Replace("{y}", "{1}")
            .Replace("{z}", "{2}");
        }

        public override Guid Id { get; } = new Guid("6ffb297f-f925-4e1f-b15b-5eebea46fc41");

        public override string Name { get; } = nameof(CustomVectorMapProvider);

        public override GMapProvider[] Overlays => _overlays ?? (_overlays = new GMapProvider[] { this });

        protected override string MakeTileImageUrl(GPoint pos, int zoom)
        {

            return String.Format(ServerUrlFormatString(ServerUrlCustom), pos.X, pos.Y, zoom);
        }
    }
}