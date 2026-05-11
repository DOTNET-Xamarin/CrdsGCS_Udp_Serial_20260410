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

        public override Guid Id { get; } = new Guid("6ffb297f-f925-4e1f-b15b-5eebea46fc41");

        public override string Name { get; } = nameof(CustomVectorMapProvider);

        public override GMapProvider[] Overlays => _overlays ?? (_overlays = new GMapProvider[] { this });
    }
}