using CluedIn.Core;
using CluedIn.Crawling.WaterNSW.Core;

using ComponentHost;

namespace CluedIn.Crawling.WaterNSW
{
    [Component(WaterNSWConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class WaterNSWCrawlerComponent : CrawlerComponentBase
    {
        public WaterNSWCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

