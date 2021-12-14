using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.WaterNSW.Core;
using CluedIn.Crawling.WaterNSW.Infrastructure.Factories;

namespace CluedIn.Crawling.WaterNSW
{
    public class WaterNSWCrawler : ICrawlerDataGenerator
    {
        private readonly IWaterNSWClientFactory clientFactory;
        public WaterNSWCrawler(IWaterNSWClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is WaterNSWCrawlJobData WaterNSWcrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(WaterNSWcrawlJobData);

            //retrieve data from provider and yield objects
            
        }       
    }
}
