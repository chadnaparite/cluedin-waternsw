using System;
using System.Collections.Generic;
using AutoFixture.Xunit2;
using Xunit;

namespace CluedIn.Provider.WaterNSW.Unit.Test.WaterNSWProvider
{
    public static class WebhookManagementEndpoints
    {
        public class FailureCases : WaterNSWProviderTest
        {
            [Theory]
            [InlineData(null)]
            public void NullParameterThrowsArgumentNullException(IEnumerable<string> ids)
            {
                Assert.Throws<ArgumentNullException>(() => Sut.WebhookManagementEndpoints(ids));
            }
        }

        public class PassCases : WaterNSWProviderTest
        {
            [Theory]
            [InlineAutoData]
            public void PublicMethodThrowsNotImplementedException(IEnumerable<string> ids)
            {
                Assert.Throws<NotImplementedException>(() => Sut.WebhookManagementEndpoints(ids));
            }
        }
    }
}
