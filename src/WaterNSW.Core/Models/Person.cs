using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.WaterNSW.Core.Models
{
    public class Person 
    {
        public string CustomerId { get; set; }
        public string DlwcInpaAddressId { get; set; }
        public DateTime CustomerDate { get; set; }
        public string CustomerFlag { get; set; }
        public DateTime Pin { get; set; }
        public string AddressId { get; set; }
        public string InpaId { get; set; }
        public string InpaType { get; set; }
        public string Title { get; set; }
        public string Initials { get; set; }
        public string GivenName { get; set; }
        public string FamilyName { get; set; }
        public string Orders { get; set; }
        public string JobTitle { get; set; }
        public string DateOfBirth { get; set; }
        public int AustralianCompanyNumber { get; set; }
        public int AustralianBusinessNumber { get; set; }
        public int IndustryCode { get; set; }
        public string OrganisationType { get; set; }
        public string InpaIdAlias { get; set; }
        public string Email { get; set; }
        public int RowVersion { get; set; }
        public int RowReplaces { get; set; }
        public DateTime RowCreated { get; set; }
        public DateTime RowExpires { get; set; }
        public string RowDataSource { get; set; }
        public string RowUpdatedBy { get; set; }
        public string OrganisationName { get; set; }
        public string PartDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public string OrgContact { get; set; }
        public string Salutation { get; set; }
        public string MiddleName { get; set; }
        public string Record { get; set; }
        public int DupeGroup { get; set; }
        public string LicenseFlag { get; set; }
        public string LegalName { get; set; }
        public string Deceased { get; set; }
        public DateTime DeceasedDate { get; set; }
        public string CompanyName { get; set; }
        public string CsvNumber { get; set; }

        public string FullName => string.Join(' ', GivenName, MiddleName, FamilyName);
    }
}
