using System;
using System.Net;
using GMap.NET.Projections;
using System.Diagnostics;

namespace GMap.NET.MapProviders.Custom.Internal
{
    public abstract class CustomMapProviderBase : GMapProvider
    {
        // ReSharper disable StringLiteralTypo
        //private const string ServerUrl = "http://wprd0{l}.is.autonavi.com/appmaptile" +
        //                                 "?x={x}&y={y}&z={z}&style={style}&scl={scl}";
        private const string ServerUrl = "http://localhost/rnc3857/" +
                                        "{z}/{x}/{y}.png";
        // ReSharper restore StringLiteralTypo

        private const string ServerLetters = "1234";

        private readonly int _scl;
        private readonly int _style;

        protected CustomMapProviderBase(int style, int scl = 1, int minZoom = 5, int maxZoom = 16)
        {
            _style = style;
            _scl = scl;
            MinZoom = minZoom;
            MaxZoom = maxZoom;
        }

        //private string ServerUrlFormatString { get; } = ServerUrl
        //    .Replace("{l}", "{0}")
        //    .Replace("{x}", "{1}")
        //    .Replace("{y}", "{2}")
        //    .Replace("{z}", "{3}")
        //    .Replace("{style}", "{4}")
        //    .Replace("{scl}", "{5}");

        private string ServerUrlFormatString { get; } = ServerUrl
            .Replace("{x}", "{0}")
            .Replace("{y}", "{1}")
            .Replace("{z}", "{2}");

        public override PureProjection Projection => MercatorProjection.Instance;

        public override PureImage GetTileImage(GPoint pos, int zoom)
        {
            var url = MakeTileImageUrl(pos, zoom);
            Console.WriteLine(url);
            return GetTileImageUsingHttp(url);
        }

        protected virtual string MakeTileImageUrl(GPoint pos, int zoom)
        {
            var letter = ServerLetters[GetServerNum(pos, ServerLetters.Length)];
            //return String.Format(ServerUrlFormatString, letter, pos.X, pos.Y, zoom, _style, _scl);
            return String.Format(ServerUrlFormatString, pos.X, pos.Y, zoom);
        }
    }
}