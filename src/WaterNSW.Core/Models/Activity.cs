using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.WaterNSW.Core.Models
{
    public class Activity 
    {
        public string TransactionId { get; set; }
        public string Id { get; set; }
        public DateTime DateReceived { get; set; }
        public string DaReference { get; set; }
        public int ReferringAgencyNaid { get; set; }
        public string ReferringAgencyName { get; set; }
        public string ReferringAgencyContact { get; set; }
        public int LicenceLocationCode { get; set; }
        public string IdasDevelopmentType { get; set; }
        public string NotificationPeriodType { get; set; }
        public int NotifcationPeriodDays { get; set; }
        public string SubmissionEndDate { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime ReceiptedOn { get; set; }
        public string ReceiptedBy { get; set; }
        public string DocumentsReceived { get; set; }
        public string ReceiptNumber { get; set; }
        public string FileLocation { get; set; }
        public string FileNumber { get; set; }
        public string AssessedBy { get; set; }
        public DateTime AssessmentDate { get; set; }
        public string Recommendation { get; set; }
        public string AssignedDeterminingOfficer { get; set; }
        public string DeterminedBy { get; set; }
        public DateTime DeterminationDate { get; set; }
        public string Determination { get; set; }
        public string AssignedNotificationOfficer { get; set; }
        public string NotifiedBy { get; set; }
        public DateTime NotificationDate { get; set; }
        public string CaDetermination { get; set; }
        public DateTime CaDeterminationReceiveDate { get; set; }
        public string CaDeterminationEnteredBy { get; set; }
        public DateTime CaDeterminationEnteredOn { get; set; }
        public string PreWithdrawalStatus {get; set;}
        public string GtaId { get; set; }
        public string TransactionType { get; set; }
        public string LastGtaIssued { get; set; }
        public DateTime CouncilLetterDated { get; set; }
        public string NewGtaRequired { get; set; }
        public string CouncilEmail { get; set; }
        public string ReferralRequired { get; set; }
        public string ReferralNumber { get; set; }
        public DateTime DateReferred { get; set; }
        public DateTime ReferralDateReceived { get; set; }
        public string ReferralDescription { get; set; }
        public string ClosedWithoutWamsResponse { get; set; }
    }
}
