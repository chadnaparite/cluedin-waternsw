using Castle.Windsor;
using CluedIn.Core;
using CluedIn.Core.Providers;
using CluedIn.Crawling.WaterNSW.Infrastructure.Factories;
using Moq;

namespace CluedIn.Provider.WaterNSW.Unit.Test.WaterNSWProvider
{
    public abstract class WaterNSWProviderTest
    {
        protected readonly ProviderBase Sut;

        protected Mock<IWaterNSWClientFactory> NameClientFactory;
        protected Mock<IWindsorContainer> Container;

        protected WaterNSWProviderTest()
        {
            Container = new Mock<IWindsorContainer>();
            NameClientFactory = new Mock<IWaterNSWClientFactory>();
            var applicationContext = new ApplicationContext(Container.Object);
            Sut = new WaterNSW.WaterNSWProvider(applicationContext, NameClientFactory.Object);
        }
    }
}
