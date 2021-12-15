using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.WaterNSW.Vocabularies;
using CluedIn.Crawling.WaterNSW.Core.Models;
using CluedIn.Crawling.WaterNSW.Core.Constants;

namespace CluedIn.Crawling.WaterNSW.ClueProducers
{
    public class PersonClueProducer : BaseClueProducer<Person>
    {
        private readonly IClueFactory factory;

        public PersonClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Person input, Guid accountId)
        {
            var personVocabulary = new PersonVocabulary();
            var clue = factory.Create(personVocabulary.Grouping, input.CustomerId.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.FullName != null)
            {
                data.Name = input.FullName;
                data.DisplayName = input.FullName;
                data.Description = input.FullName;
            }

            if (input.DlwcInpaAddressId != null)
                factory.CreateIncomingEntityReference(clue, WaterNSWEntities.Location, EntityEdgeType.OwnedBy, input.DlwcInpaAddressId, input.DlwcInpaAddressId);
            
            if (input.AddressId != null)
                factory.CreateIncomingEntityReference(clue, WaterNSWEntities.Location, EntityEdgeType.OwnedBy, input.AddressId, input.AddressId);
            
            if (input.InpaId != null)
                factory.CreateIncomingEntityReference(clue, WaterNSWEntities.Location, EntityEdgeType.OwnedBy, input.InpaId, input.InpaId);

            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }

            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[personVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[personVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[personVocabulary.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[personVocabulary.DlwcInpaAddressId] = input.DlwcInpaAddressId.PrintIfAvailable();
            data.Properties[personVocabulary.CustomerDate] = input.CustomerDate.PrintIfAvailable();
            data.Properties[personVocabulary.CustomerFlag] = input.CustomerFlag.PrintIfAvailable();
            data.Properties[personVocabulary.Pin] = input.Pin.PrintIfAvailable();
            data.Properties[personVocabulary.AddressId] = input.AddressId.PrintIfAvailable();
            data.Properties[personVocabulary.InpaId] = input.InpaId.PrintIfAvailable();
            data.Properties[personVocabulary.InpaType] = input.InpaType.PrintIfAvailable();
            data.Properties[personVocabulary.Title] = input.Title.PrintIfAvailable();
            data.Properties[personVocabulary.Initials] = input.Initials.PrintIfAvailable();
            data.Properties[personVocabulary.GivenName] = input.GivenName.PrintIfAvailable();
            data.Properties[personVocabulary.FamilyName] = input.FamilyName.PrintIfAvailable();
            data.Properties[personVocabulary.Orders] = input.Orders.PrintIfAvailable();
            data.Properties[personVocabulary.JobTitle] = input.JobTitle.PrintIfAvailable();
            data.Properties[personVocabulary.DateOfBirth] = input.DateOfBirth.PrintIfAvailable();
            data.Properties[personVocabulary.AustralianCompanyNumber] = input.AustralianCompanyNumber.PrintIfAvailable();
            data.Properties[personVocabulary.AustralianBusinessNumber] = input.AustralianBusinessNumber.PrintIfAvailable();
            data.Properties[personVocabulary.IndustryCode] = input.IndustryCode.PrintIfAvailable();
            data.Properties[personVocabulary.OrganisationType] = input.OrganisationType.PrintIfAvailable();
            data.Properties[personVocabulary.InpaIdAlias] = input.InpaIdAlias.PrintIfAvailable();
            data.Properties[personVocabulary.Email] = input.Email.PrintIfAvailable();
            data.Properties[personVocabulary.RowVersion] = input.RowVersion.PrintIfAvailable();
            data.Properties[personVocabulary.RowReplaces] = input.RowReplaces.PrintIfAvailable();
            data.Properties[personVocabulary.RowCreated] = input.RowCreated.PrintIfAvailable();
            data.Properties[personVocabulary.RowExpires] = input.RowExpires.PrintIfAvailable();
            data.Properties[personVocabulary.RowDataSource] = input.RowDataSource.PrintIfAvailable();
            data.Properties[personVocabulary.RowUpdatedBy] = input.RowUpdatedBy.PrintIfAvailable();
            data.Properties[personVocabulary.OrganisationName] = input.OrganisationName.PrintIfAvailable();
            data.Properties[personVocabulary.PartDescription] = input.PartDescription.PrintIfAvailable();
            data.Properties[personVocabulary.DateCreated] = input.DateCreated.PrintIfAvailable();
            data.Properties[personVocabulary.OrgContact] = input.OrgContact.PrintIfAvailable();
            data.Properties[personVocabulary.Salutation] = input.Salutation.PrintIfAvailable();
            data.Properties[personVocabulary.MiddleName] = input.MiddleName.PrintIfAvailable();
            data.Properties[personVocabulary.Record] = input.Record.PrintIfAvailable();
            data.Properties[personVocabulary.DupeGroup] = input.DupeGroup.PrintIfAvailable();
            data.Properties[personVocabulary.LicenseFlag] = input.LicenseFlag.PrintIfAvailable();
            data.Properties[personVocabulary.LegalName] = input.LegalName.PrintIfAvailable();
            data.Properties[personVocabulary.Deceased] = input.Deceased.PrintIfAvailable();
            data.Properties[personVocabulary.DeceasedDate] = input.DeceasedDate.PrintIfAvailable();
            data.Properties[personVocabulary.CompanyName] = input.CompanyName.PrintIfAvailable();
            data.Properties[personVocabulary.CsvNumber] = input.CsvNumber.PrintIfAvailable();

            return clue;
        }
    }
}
