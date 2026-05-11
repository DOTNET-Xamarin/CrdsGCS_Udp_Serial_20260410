using System;
using GMap.NET.MapProviders.Custom.Internal;

namespace GMap.NET.MapProviders.Custom
{
    public class CustomImageMapProvider : CustomMapProviderBase
    {
        public static readonly CustomImageMapProvider Instance =
            new CustomImageMapProvider();

        private GMapProvider[] _overlays;

        private CustomImageMapProvider() : base(8)
        {
        }

        public string ServerUrlCustom = "http://localhost/RNC3857/" +
                                        "{z}/{x}/{y}.png";

        private string ServerUrlFormatString(string strUrl)
        {
            return strUrl.Replace("{x}", "{0}")
            .Replace("{y}", "{1}")
            .Replace("{z}", "{2}");
        }

        public override Guid Id { get; } = new Guid("fff6547a-904a-45cd-89a5-0c8d10c43f6b");

        public override string Name { get; } = nameof(CustomImageMapProvider);

        public override GMapProvider[] Overlays =>
            _overlays ?? (_overlays = new GMapProvider[] { CustomImageWithoutAnnotationMapProvider.Instance, this });

        protected override string MakeTileImageUrl(GPoint pos, int zoom)
        {
            
            return String.Format(ServerUrlFormatString(ServerUrlCustom), pos.X, pos.Y, zoom);
        }
    }
}