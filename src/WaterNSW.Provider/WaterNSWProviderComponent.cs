using Castle.MicroKernel.Registration;

using CluedIn.Core;
using CluedIn.Core.Providers;
// 
using CluedIn.Crawling.WaterNSW.Core;
using CluedIn.Crawling.WaterNSW.Infrastructure.Installers;
// 
using ComponentHost;
using CluedIn.Core.Server;
using Microsoft.Extensions.Logging;
using CluedIn.Provider.WaterNSW.Installers;

namespace CluedIn.Provider.WaterNSW
{
    [Component(WaterNSWConstants.ProviderName, "Providers", ComponentType.Service, ServerComponents.ProviderWebApi, Components.Server, Components.DataStores, Isolation = ComponentIsolation.NotIsolated)]
    public sealed class WaterNSWProviderComponent : ServiceApplicationComponent<IBusServer>
    {
        public WaterNSWProviderComponent(ComponentInfo componentInfo)
            : base(componentInfo)
        {
            // Dev. Note: Potential for compiler warning here ... CA2214: Do not call overridable methods in constructors
            //   this class has been sealed to prevent the CA2214 waring being raised by the compiler
            Container.Register(Component.For<WaterNSWProviderComponent>().Instance(this));
        }

        public override void Start()
        {
            Log.LogInformation("[WaterNSW] Begin CluedIn.Provider.WaterNSW.Start");

            Container.Install(new InstallComponents());
            Container.Install(new WaterNSWRelatedEntitiesInstaller());

            State = ServiceState.Started;

            Log.LogInformation("[WaterNSW] End CluedIn.Provider.WaterNSW.Start");
        }

        public override void Stop()
        {
            if (State == ServiceState.Stopped)
                return;

            State = ServiceState.Stopped;
        }
    }
}
