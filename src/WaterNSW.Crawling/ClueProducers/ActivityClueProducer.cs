using System;
using CluedIn.Core.Data;
using CluedIn.Crawling.Factories;
using CluedIn.Crawling.Helpers;
using CluedIn.Crawling.WaterNSW.Vocabularies;
using CluedIn.Crawling.WaterNSW.Core.Models;
using CluedIn.Crawling.WaterNSW.Core.Constants;

namespace CluedIn.Crawling.WaterNSW.ClueProducers
{
    public class ActivityClueProducer : BaseClueProducer<Activity>
    {
        private readonly IClueFactory factory;

        public ActivityClueProducer(IClueFactory factory)
        {
            this.factory = factory;
        }

        protected override Clue MakeClueImpl(Activity input, Guid accountId)
        {
            if (string.IsNullOrEmpty(input.TransactionId))
                return null;

            var activityVocabulary = new ActivityVocabulary();
            var clue = factory.Create(activityVocabulary.Grouping, input.TransactionId.ToString(), accountId);
            var data = clue.Data.EntityData;

            data.Name = input.TransactionId;
            data.DisplayName = input.TransactionId;
            data.Description = input.TransactionId;

            if (input.TransactionType != null)
                data.Description = input.TransactionType;

            factory.CreateOutgoingEntityReference(clue, WaterNSWEntities.SMS, EntityEdgeType.OwnedBy, input.TransactionId, input.TransactionId);

            // TODO: Example of Updated, Modified date being parsed through DateTimeOffset.
            // DateTimeOffset date;
            // if (DateTimeOffset.TryParse(input.CreatedAt, out date) && input.CreatedAt != null){
            //     data.CreatedDate = date;
            // }

            //TODO: Examples of edge creation
            // if (input.MobilePhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.MobilePhone, input.MobilePhone);
            //     data.Properties[activityVocabulary.MobilePhone] = input.MobilePhone.PrintIfAvailable();
            // }

            // if (input.WorkPhone != null)
            // {
            //     factory.CreateIncomingEntityReference(clue, EntityType.PhoneNumber, EntityEdgeType.Parent, input.WorkPhone, input.WorkPhone);
            //     data.Properties[activityVocabulary.WorkPhone] = input.WorkPhone.PrintIfAvailable();
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

            data.Properties[activityVocabulary.TransactionId] = input.TransactionId.PrintIfAvailable();
            data.Properties[activityVocabulary.Id] = input.Id.PrintIfAvailable();
            data.Properties[activityVocabulary.DateReceived] = input.DateReceived.PrintIfAvailable();
            data.Properties[activityVocabulary.DaReference] = input.DaReference.PrintIfAvailable();
            data.Properties[activityVocabulary.ReferringAgencyNaid] = input.ReferringAgencyNaid.PrintIfAvailable();
            data.Properties[activityVocabulary.ReferringAgencyName] = input.ReferringAgencyName.PrintIfAvailable();
            data.Properties[activityVocabulary.ReferringAgencyContact] = input.ReferringAgencyContact.PrintIfAvailable();
            data.Properties[activityVocabulary.LicenceLocationCode] = input.LicenceLocationCode.PrintIfAvailable();
            data.Properties[activityVocabulary.IdasDevelopmentType] = input.IdasDevelopmentType.PrintIfAvailable();
            data.Properties[activityVocabulary.NotificationPeriodType] = input.NotificationPeriodType.PrintIfAvailable();
            data.Properties[activityVocabulary.NotifcationPeriodDays] = input.NotifcationPeriodDays.PrintIfAvailable();
            data.Properties[activityVocabulary.SubmissionEndDate] = input.SubmissionEndDate.PrintIfAvailable();
            data.Properties[activityVocabulary.AmountPaid] = input.AmountPaid.PrintIfAvailable();
            data.Properties[activityVocabulary.ReceiptedOn] = input.ReceiptedOn.PrintIfAvailable();
            data.Properties[activityVocabulary.ReceiptedBy] = input.ReceiptedBy.PrintIfAvailable();
            data.Properties[activityVocabulary.DocumentsReceived] = input.DocumentsReceived.PrintIfAvailable();
            data.Properties[activityVocabulary.ReceiptNumber] = input.ReceiptNumber.PrintIfAvailable();
            data.Properties[activityVocabulary.FileLocation] = input.FileLocation.PrintIfAvailable();
            data.Properties[activityVocabulary.FileNumber] = input.FileNumber.PrintIfAvailable();
            data.Properties[activityVocabulary.AssessedBy] = input.AssessedBy.PrintIfAvailable();
            data.Properties[activityVocabulary.AssessmentDate] = input.AssessmentDate.PrintIfAvailable();
            data.Properties[activityVocabulary.Recommendation] = input.Recommendation.PrintIfAvailable();
            data.Properties[activityVocabulary.AssignedDeterminingOfficer] = input.AssignedDeterminingOfficer.PrintIfAvailable();
            data.Properties[activityVocabulary.DeterminedBy] = input.DeterminedBy.PrintIfAvailable();
            data.Properties[activityVocabulary.DeterminationDate] = input.DeterminationDate.PrintIfAvailable();
            data.Properties[activityVocabulary.Determination] = input.Determination.PrintIfAvailable();
            data.Properties[activityVocabulary.AssignedNotificationOfficer] = input.AssignedNotificationOfficer.PrintIfAvailable();
            data.Properties[activityVocabulary.NotifiedBy] = input.NotifiedBy.PrintIfAvailable();
            data.Properties[activityVocabulary.NotificationDate] = input.NotificationDate.PrintIfAvailable();
            data.Properties[activityVocabulary.CaDetermination] = input.CaDetermination.PrintIfAvailable();
            data.Properties[activityVocabulary.CaDeterminationReceiveDate] = input.CaDeterminationReceiveDate.PrintIfAvailable();
            data.Properties[activityVocabulary.CaDeterminationEnteredBy] = input.CaDeterminationEnteredBy.PrintIfAvailable();
            data.Properties[activityVocabulary.CaDeterminationEnteredOn] = input.CaDeterminationEnteredOn.PrintIfAvailable();
            data.Properties[activityVocabulary.PreWithdrawalStatus] = input.PreWithdrawalStatus.PrintIfAvailable();
            data.Properties[activityVocabulary.GtaId] = input.GtaId.PrintIfAvailable();
            data.Properties[activityVocabulary.TransactionType] = input.TransactionType.PrintIfAvailable();
            data.Properties[activityVocabulary.LastGtaIssued] = input.LastGtaIssued.PrintIfAvailable();
            data.Properties[activityVocabulary.CouncilLetterDated] = input.CouncilLetterDated.PrintIfAvailable();
            data.Properties[activityVocabulary.NewGtaRequired] = input.NewGtaRequired.PrintIfAvailable();
            data.Properties[activityVocabulary.CouncilEmail] = input.CouncilEmail.PrintIfAvailable();
            data.Properties[activityVocabulary.ReferralRequired] = input.ReferralRequired.PrintIfAvailable();
            data.Properties[activityVocabulary.ReferralNumber] = input.ReferralNumber.PrintIfAvailable();
            data.Properties[activityVocabulary.DateReferred] = input.DateReferred.PrintIfAvailable();
            data.Properties[activityVocabulary.ReferralDateReceived] = input.ReferralDateReceived.PrintIfAvailable();
            data.Properties[activityVocabulary.ReferralDescription] = input.ReferralDescription.PrintIfAvailable();
            data.Properties[activityVocabulary.ClosedWithoutWamsResponse] = input.ClosedWithoutWamsResponse.PrintIfAvailable();

            return clue;
        }
    }
}
