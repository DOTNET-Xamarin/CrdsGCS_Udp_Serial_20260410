using System;

namespace GMap.NET.MapProviders.Custom.Internal
{
    internal class CustomImageWithoutAnnotationMapProvider : CustomMapProviderBase
    {
        public static readonly CustomImageWithoutAnnotationMapProvider Instance = new CustomImageWithoutAnnotationMapProvider();

        private GMapProvider[] _overlays;

        private CustomImageWithoutAnnotationMapProvider() : base(6)
        {
        }

        public override Guid Id { get; } = new Guid("225ffcfa-4939-4478-9176-f5384621e322");

        public override string Name { get; } = nameof(CustomImageWithoutAnnotationMapProvider);

        public override GMapProvider[] Overlays => _overlays ?? (_overlays = new GMapProvider[] { this });
    }
}