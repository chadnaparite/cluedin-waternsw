using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.WaterNSW.Core.Constants;

namespace CluedIn.Crawling.WaterNSW.Vocabularies
{
    public class  ActivityVocabulary : SimpleVocabulary
    {
        public  ActivityVocabulary()
        {
            VocabularyName = "WaterNSW Activity"; 
            KeyPrefix      = "waternsw.activity"; 
            KeySeparator   = ".";
            Grouping       = WaterNSWEntities.Activity; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("WaterNSW Activity Details", group =>
            {
                TransactionId = group.Add(new VocabularyKey("TransactionId", "Transaction ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Id = group.Add(new VocabularyKey("Id", "ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateReceived = group.Add(new VocabularyKey("DateReceived", "Date received", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                DaReference = group.Add(new VocabularyKey("DaReference", "DA reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferringAgencyNaid = group.Add(new VocabularyKey("ReferringAgencyNaid", "Referring agency naid", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ReferringAgencyName = group.Add(new VocabularyKey("ReferringAgencyName", "Referring agency name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferringAgencyContact = group.Add(new VocabularyKey("ReferringAgencyContact", "Referring agency contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LicenceLocationCode = group.Add(new VocabularyKey("LicenceLocationCode", "Licence location code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                IdasDevelopmentType = group.Add(new VocabularyKey("IdasDevelopmentType", "IDAS development type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotificationPeriodType = group.Add(new VocabularyKey("NotificationPeriodType", "Notification period type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotifcationPeriodDays = group.Add(new VocabularyKey("NotifcationPeriodDays", "Notifcation period days", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                SubmissionEndDate = group.Add(new VocabularyKey("SubmissionEndDate", "Submission end date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountPaid = group.Add(new VocabularyKey("AmountPaid", "Amount paid", VocabularyKeyDataType.Money, VocabularyKeyVisibility.Visible));
                ReceiptedOn = group.Add(new VocabularyKey("ReceiptedOn", "Receipted on", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ReceiptedBy = group.Add(new VocabularyKey("ReceiptedBy", "Receipted by", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentsReceived = group.Add(new VocabularyKey("DocumentsReceived", "Documents received", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptNumber = group.Add(new VocabularyKey("ReceiptNumber", "Receipt number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileLocation = group.Add(new VocabularyKey("FileLocation", "File location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileNumber = group.Add(new VocabularyKey("FileNumber", "File Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssessedBy = group.Add(new VocabularyKey("AssessedBy", "Assessed by", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssessmentDate = group.Add(new VocabularyKey("AssessmentDate", "Assessment date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Recommendation = group.Add(new VocabularyKey("Recommendation", "Recommendation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssignedDeterminingOfficer = group.Add(new VocabularyKey("AssignedDeterminingOfficer", "Assigned determining officer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeterminedBy = group.Add(new VocabularyKey("DeterminedBy", "Determined by", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeterminationDate = group.Add(new VocabularyKey("DeterminationDate", "Determination date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Determination = group.Add(new VocabularyKey("Determination", "Determination", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssignedNotificationOfficer = group.Add(new VocabularyKey("AssignedNotificationOfficer", "Assigned notification officer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotifiedBy = group.Add(new VocabularyKey("NotifiedBy", "Notified by", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NotificationDate = group.Add(new VocabularyKey("NotificationDate", "Notification date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CaDetermination = group.Add(new VocabularyKey("CaDetermination", "CA determination", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CaDeterminationReceiveDate = group.Add(new VocabularyKey("CaDeterminationReceiveDate", "CA determination receive date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CaDeterminationEnteredBy = group.Add(new VocabularyKey("CaDeterminationEnteredBy", "CA determination entered by", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CaDeterminationEnteredOn = group.Add(new VocabularyKey("CaDeterminationEnteredOn", "CA determination entered on", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                PreWithdrawalStatus = group.Add(new VocabularyKey("PreWithdrawalStatus", "Pre-withdrawal status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GtaId = group.Add(new VocabularyKey("GtaId", "GTA ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey("TransactionType", "Transaction type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastGtaIssued = group.Add(new VocabularyKey("LastGtaIssued", "Last GTA issued", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CouncilLetterDated = group.Add(new VocabularyKey("CouncilLetterDated", "Council letter dated", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                NewGtaRequired = group.Add(new VocabularyKey("NewGtaRequired", "New GTA required", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CouncilEmail = group.Add(new VocabularyKey("CouncilEmail", "Council email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                ReferralRequired = group.Add(new VocabularyKey("ReferralRequired", "Referral required", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferralNumber = group.Add(new VocabularyKey("ReferralNumber", "Referral number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateReferred = group.Add(new VocabularyKey("DateReferred", "Date referred", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ReferralDateReceived = group.Add(new VocabularyKey("ReferralDateReceived", "Referral date received", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ReferralDescription = group.Add(new VocabularyKey("ReferralDescription", "Referral description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClosedWithoutWamsResponse = group.Add(new VocabularyKey("ClosedWithoutWamsResponse", "Closed without WAMS response", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }

        public VocabularyKey TransactionId { get; private set; }
        public VocabularyKey Id { get; private set; }
        public VocabularyKey DateReceived { get; private set; }
        public VocabularyKey DaReference { get; private set; }
        public VocabularyKey ReferringAgencyNaid { get; private set; }
        public VocabularyKey ReferringAgencyName { get; private set; }
        public VocabularyKey ReferringAgencyContact { get; private set; }
        public VocabularyKey LicenceLocationCode { get; private set; }
        public VocabularyKey IdasDevelopmentType { get; private set; }
        public VocabularyKey NotificationPeriodType { get; private set; }
        public VocabularyKey NotifcationPeriodDays { get; private set; }
        public VocabularyKey SubmissionEndDate { get; private set; }
        public VocabularyKey AmountPaid { get; private set; }
        public VocabularyKey ReceiptedOn { get; private set; }
        public VocabularyKey ReceiptedBy { get; private set; }
        public VocabularyKey DocumentsReceived { get; private set; }
        public VocabularyKey ReceiptNumber { get; private set; }
        public VocabularyKey FileLocation { get; private set; }
        public VocabularyKey FileNumber { get; private set; }
        public VocabularyKey AssessedBy { get; private set; }
        public VocabularyKey AssessmentDate { get; private set; }
        public VocabularyKey Recommendation { get; private set; }
        public VocabularyKey AssignedDeterminingOfficer { get; private set; }
        public VocabularyKey DeterminedBy { get; private set; }
        public VocabularyKey DeterminationDate { get; private set; }
        public VocabularyKey Determination { get; private set; }
        public VocabularyKey AssignedNotificationOfficer { get; private set; }
        public VocabularyKey NotifiedBy { get; private set; }
        public VocabularyKey NotificationDate { get; private set; }
        public VocabularyKey CaDetermination { get; private set; }
        public VocabularyKey CaDeterminationReceiveDate { get; private set; }
        public VocabularyKey CaDeterminationEnteredBy { get; private set; }
        public VocabularyKey CaDeterminationEnteredOn { get; private set; }
        public VocabularyKey PreWithdrawalStatus { get; private set; }
        public VocabularyKey GtaId { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey LastGtaIssued { get; private set; }
        public VocabularyKey CouncilLetterDated { get; private set; }
        public VocabularyKey NewGtaRequired { get; private set; }
        public VocabularyKey CouncilEmail { get; private set; }
        public VocabularyKey ReferralRequired { get; private set; }
        public VocabularyKey ReferralNumber { get; private set; }
        public VocabularyKey DateReferred { get; private set; }
        public VocabularyKey ReferralDateReceived { get; private set; }
        public VocabularyKey ReferralDescription { get; private set; }
        public VocabularyKey ClosedWithoutWamsResponse { get; private set; }
    }
}
