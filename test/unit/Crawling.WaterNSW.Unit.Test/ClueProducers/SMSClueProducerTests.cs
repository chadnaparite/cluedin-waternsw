using AutoFixture.Xunit2;
using System;
using Xunit;
using CluedIn.Core.Data;
using CluedIn.Crawling;
using CluedIn.Crawling.WaterNSW.ClueProducers;
using CluedIn.Crawling.WaterNSW.Core.Models;
using CluedIn.Crawling.WaterNSW.Core.Constants;

namespace Crawling.WaterNSW.Unit.Test.ClueProducers
{
    public class SMSClueProducerTests : BaseClueProducerTest<SMS>
    {
        protected override BaseClueProducer<SMS> Sut =>
            new SMSClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => WaterNSWEntities.SMS;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(SMS sms)
        {
            var clue = Sut.MakeClue(sms, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
