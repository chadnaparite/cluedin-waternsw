using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.WaterNSW.Vocabularies;
using CluedIn.Crawling.WaterNSW.Core.Models;
using CluedIn.Crawling.WaterNSW.Core.Constants;

namespace CluedIn.Crawling.WaterNSW.ClueProducers
{
    public class SMSClueProducer : BaseClueProducer<SMS>
    {
        private readonly IClueFactory factory;

        public SMSClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(SMS input, Guid accountId)
        {
            var smsVocabulary = new SMSVocabulary();
            var clue = factory.Create(smsVocabulary.Grouping, input.TransactionId.ToString(), accountId);
            var data = clue.Data.EntityData;

            // TODO: Uncomment or delete as appropriate for the different properties
            if (input.MessageTypeCode != null)
            {
                data.Name = input.MessageTypeCode;
                data.DisplayName = input.MessageTypeCode;
                data.Description = input.MessageTypeCode;
            }

            factory.CreateIncomingEntityReference(clue, WaterNSWEntities.Activity, EntityEdgeType.OwnedBy, input.TransactionId, input.TransactionId.ToString());

            if (input.CustomerId != null)
                factory.CreateIncomingEntityReference(clue, EntityType.Person, EntityEdgeType.OwnedBy, input.CustomerId, input.CustomerId);

            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }

            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[smsVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[smsVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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
            data.Properties[smsVocabulary.TransactionId] = input.TransactionId.PrintIfAvailable();
            data.Properties[smsVocabulary.CustomerId] = input.CustomerId.PrintIfAvailable();
            data.Properties[smsVocabulary.MessageTypeCode] = input.MessageTypeCode.PrintIfAvailable();
            data.Properties[smsVocabulary.StartDate] = input.StartDate.PrintIfAvailable();
            data.Properties[smsVocabulary.CloseDate] = input.CloseDate.PrintIfAvailable();
            data.Properties[smsVocabulary.WaterType] = input.WaterType.PrintIfAvailable();
            data.Properties[smsVocabulary.WaterSourceCode] = input.WaterSourceCode.PrintIfAvailable();
            data.Properties[smsVocabulary.WmzCode] = input.WmzCode.PrintIfAvailable();
            data.Properties[smsVocabulary.LicenseSubcategoryId] = input.LicenseSubcategoryId.PrintIfAvailable();
            data.Properties[smsVocabulary.License] = input.License.PrintIfAvailable();
            data.Properties[smsVocabulary.Message] = input.Message.PrintIfAvailable();
            data.Properties[smsVocabulary.Url] = input.Url.PrintIfAvailable();
            data.Properties[smsVocabulary.UrlTitle] = input.UrlTitle.PrintIfAvailable();
            data.Properties[smsVocabulary.TransactionStatus] = input.TransactionStatus.PrintIfAvailable();
            data.Properties[smsVocabulary.TransactionUserId] = input.TransactionUserId.PrintIfAvailable();
            data.Properties[smsVocabulary.TransactionDate] = input.TransactionDate.PrintIfAvailable();

            return clue;
        }
    }
}
