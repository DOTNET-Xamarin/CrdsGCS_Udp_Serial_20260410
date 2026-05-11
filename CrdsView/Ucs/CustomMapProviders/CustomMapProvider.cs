using GMap.NET.MapProviders.Custom;

namespace GMap.NET.MapProviders
{
    public static class CustomMapProviders
    {
        public static CustomVectorMapProvider VectorMap => CustomVectorMapProvider.Instance;
        public static CustomImageMapProvider ImageMap => CustomImageMapProvider.Instance;
    }
}