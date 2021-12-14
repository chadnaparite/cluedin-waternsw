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
    public class ActivityClueProducerTests : BaseClueProducerTest<Activity>
    {
        protected override BaseClueProducer<Activity> Sut =>
            new ActivityClueProducer(_clueFactory.Object);

        protected override EntityType ExpectedEntityType => WaterNSWEntities.Activity;

        [Theory]
        [InlineAutoData]
        public void ClueHasEdgeToFolder(Activity activity)
        {
            var clue = Sut.MakeClue(activity, Guid.NewGuid());
            _clueFactory.Verify(
                //TODO verify some methods were called
                );
        }

        //TODO add other tests
    }
}
