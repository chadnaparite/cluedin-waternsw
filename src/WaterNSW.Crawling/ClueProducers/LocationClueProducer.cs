using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.WaterNSW.Vocabularies;
using CluedIn.Crawling.WaterNSW.Core.Models;

namespace CluedIn.Crawling.WaterNSW.ClueProducers
{
    public class LocationClueProducer : BaseClueProducer<Location>
    {
        private readonly IClueFactory factory;

        public LocationClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Location input, Guid accountId)
        {
            var locationVocabulary = new LocationVocabulary();
            var clue = factory.Create(locationVocabulary.Grouping, input.DlwcAddressId.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            // if(input.Name != null)
            // {
            //     data.Name = input.Name;
            //     data.DisplayName = input.DisplayName;
            //     data.Description = input.Description;
            // }

            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }

            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[locationVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[locationVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
            // }

            //TODO: Example of PersonReference
            //  if (input.UpdatedBy != null)
            // {
            //     if (input.UpdatedByName != null)
            //     {
            //         var updatedPersonReference = new PersonReference(input.UpdatedByName, new EntityCode(EntityType.Person, WaterNSWConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            //     else
            //     {
            //         var updatedPersonReference = new PersonReference(new EntityCode(EntityType.Person, WaterNSWConstants.CodeOrigin, input.UpdatedBy));
            //         data.LastChangedBy = updatedPersonReference;
            //     }
            // }

            //TODO: Mapping data into general properties metadata bag.
            //TODO: You should make sure as much data is mapped into specific metadata fields, rather than general .properties. bag.
            data.Properties[locationVocabulary.DlwcAddressId] = input.DlwcAddressId.PrintIfAvailable();
            data.Properties[locationVocabulary.InpaAddressId] = input.InpaAddressId.PrintIfAvailable();
            data.Properties[locationVocabulary.DlwcInpaId] = input.DlwcInpaId.PrintIfAvailable();
            data.Properties[locationVocabulary.ValidFrom] = input.ValidFrom.PrintIfAvailable();
            data.Properties[locationVocabulary.ValidTo] = input.ValidTo.PrintIfAvailable();
            data.Properties[locationVocabulary.AddressId] = input.AddressId.PrintIfAvailable();
            data.Properties[locationVocabulary.UnitType] = input.UnitType.PrintIfAvailable();
            data.Properties[locationVocabulary.UnitNumber] = input.UnitNumber.PrintIfAvailable();
            data.Properties[locationVocabulary.UnitSuffix] = input.UnitSuffix.PrintIfAvailable();
            data.Properties[locationVocabulary.AddressLine1] = input.AddressLine1.PrintIfAvailable();
            data.Properties[locationVocabulary.AddressLine2] = input.AddressLine2.PrintIfAvailable();
            data.Properties[locationVocabulary.AddressLine3] = input.AddressLine3.PrintIfAvailable();
            data.Properties[locationVocabulary.AddressLine4] = input.AddressLine4.PrintIfAvailable();
            data.Properties[locationVocabulary.PremisesType] = input.PremisesType.PrintIfAvailable();
            data.Properties[locationVocabulary.FloorType] = input.FloorType.PrintIfAvailable();
            data.Properties[locationVocabulary.FloorNumber] = input.FloorNumber.PrintIfAvailable();
            data.Properties[locationVocabulary.FloorSuffix] = input.FloorSuffix.PrintIfAvailable();
            data.Properties[locationVocabulary.BuildingName] = input.BuildingName.PrintIfAvailable();
            data.Properties[locationVocabulary.LocaitonDescriptor] = input.LocaitonDescriptor.PrintIfAvailable();
            data.Properties[locationVocabulary.FirstHouseNumber] = input.FirstHouseNumber.PrintIfAvailable();
            data.Properties[locationVocabulary.FirstHousePrefix] = input.FirstHousePrefix.PrintIfAvailable();
            data.Properties[locationVocabulary.FirstHouseSuffix] = input.FirstHouseSuffix.PrintIfAvailable();
            data.Properties[locationVocabulary.SecondHouseNumber] = input.SecondHouseNumber.PrintIfAvailable();
            data.Properties[locationVocabulary.SecondHousePrefix] = input.SecondHousePrefix.PrintIfAvailable();
            data.Properties[locationVocabulary.SecondHourseSuffix] = input.SecondHourseSuffix.PrintIfAvailable();
            data.Properties[locationVocabulary.LotType] = input.LotType.PrintIfAvailable();
            data.Properties[locationVocabulary.LotNumber] = input.LotNumber.PrintIfAvailable();
            data.Properties[locationVocabulary.LotSuffix] = input.LotSuffix.PrintIfAvailable();
            data.Properties[locationVocabulary.StreetName] = input.StreetName.PrintIfAvailable();
            data.Properties[locationVocabulary.StreetType] = input.StreetType.PrintIfAvailable();
            data.Properties[locationVocabulary.StreetSuffix] = input.StreetSuffix.PrintIfAvailable();
            data.Properties[locationVocabulary.StreetName2] = input.StreetName2.PrintIfAvailable();
            data.Properties[locationVocabulary.StreetType2] = input.StreetType2.PrintIfAvailable();
            data.Properties[locationVocabulary.StreetSuffix2] = input.StreetSuffix2.PrintIfAvailable();
            data.Properties[locationVocabulary.Suburb] = input.Suburb.PrintIfAvailable();
            data.Properties[locationVocabulary.County] = input.County.PrintIfAvailable();
            data.Properties[locationVocabulary.Parish] = input.Parish.PrintIfAvailable();
            data.Properties[locationVocabulary.State] = input.State.PrintIfAvailable();
            data.Properties[locationVocabulary.Country] = input.Country.PrintIfAvailable();
            data.Properties[locationVocabulary.PostalServiceType] = input.PostalServiceType.PrintIfAvailable();
            data.Properties[locationVocabulary.PostalServiceIdentifier] = input.PostalServiceIdentifier.PrintIfAvailable();
            data.Properties[locationVocabulary.PostCode] = input.PostCode.PrintIfAvailable();
            data.Properties[locationVocabulary.DeliveryPointId] = input.DeliveryPointId.PrintIfAvailable();
            data.Properties[locationVocabulary.AsonDescriptor] = input.AsonDescriptor.PrintIfAvailable();
            data.Properties[locationVocabulary.AddressType] = input.AddressType.PrintIfAvailable();
            data.Properties[locationVocabulary.RowVersion] = input.RowVersion.PrintIfAvailable();
            data.Properties[locationVocabulary.RowReplaces] = input.RowReplaces.PrintIfAvailable();
            data.Properties[locationVocabulary.RowCreated] = input.RowCreated.PrintIfAvailable();
            data.Properties[locationVocabulary.RowExpires] = input.RowExpires.PrintIfAvailable();
            data.Properties[locationVocabulary.RowDataSource] = input.RowDataSource.PrintIfAvailable();
            data.Properties[locationVocabulary.RowUpdatedBy] = input.RowUpdatedBy.PrintIfAvailable();
            data.Properties[locationVocabulary.PAddressLine1] = input.PAddressLine1.PrintIfAvailable();
            data.Properties[locationVocabulary.PAddressLine2] = input.PAddressLine2.PrintIfAvailable();
            data.Properties[locationVocabulary.PSuburb] = input.PSuburb.PrintIfAvailable();
            data.Properties[locationVocabulary.PState] = input.PState.PrintIfAvailable();
            data.Properties[locationVocabulary.PCountry] = input.PCountry.PrintIfAvailable();
            data.Properties[locationVocabulary.PPostCode] = input.PPostCode.PrintIfAvailable();
            data.Properties[locationVocabulary.PDeliveryPoint] = input.PDeliveryPoint.PrintIfAvailable();
            data.Properties[locationVocabulary.CareOf] = input.CareOf.PrintIfAvailable();
            data.Properties[locationVocabulary.PCareOf] = input.PCareOf.PrintIfAvailable();

            return clue;
        }
    }
}
