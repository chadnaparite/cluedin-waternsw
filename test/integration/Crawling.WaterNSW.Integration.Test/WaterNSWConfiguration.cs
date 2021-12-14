using System.Collections.Generic;
using CluedIn.Crawling.WaterNSW.Core;

namespace CluedIn.Crawling.WaterNSW.Integration.Test
{
  public static class WaterNSWConfiguration
  {
    public static Dictionary<string, object> Create()
    {
      return new Dictionary<string, object>
            {
                { WaterNSWConstants.KeyName.ApiKey, "demo" }
            };
    }
  }
}
