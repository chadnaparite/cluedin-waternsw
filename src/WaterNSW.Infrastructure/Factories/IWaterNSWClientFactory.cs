using CluedIn.Crawling.WaterNSW.Core;

namespace CluedIn.Crawling.WaterNSW.Infrastructure.Factories
{
    public interface IWaterNSWClientFactory
    {
        WaterNSWClient CreateNew(WaterNSWCrawlJobData WaterNSWCrawlJobData);
    }
}
