using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.WaterNSW;
using CluedIn.Crawling.WaterNSW.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.WaterNSW.Unit.Test
{
    public class WaterNSWCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public WaterNSWCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<IWaterNSWClientFactory>();

            _sut = new WaterNSWCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
