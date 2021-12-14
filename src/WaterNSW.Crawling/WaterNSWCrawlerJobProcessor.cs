using CluedIn.Crawling.WaterNSW.Core;

namespace CluedIn.Crawling.WaterNSW
{
    public class WaterNSWCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<WaterNSWCrawlJobData>
    {
        public WaterNSWCrawlerJobProcessor(WaterNSWCrawlerComponent component) : base(component)
        {
        }
    }
}
