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

        public override Guid Id { get; } = new Guid("fff6547a-904a-45cd-89a5-0c8d10c43f6b");

        public override string Name { get; } = nameof(CustomImageMapProvider);

        public override GMapProvider[] Overlays =>
            _overlays ?? (_overlays = new GMapProvider[] { CustomImageWithoutAnnotationMapProvider.Instance, this });
    }
}