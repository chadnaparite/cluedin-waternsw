using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.WaterNSW.Vocabularies
{
    public class PersonVocabulary : SimpleVocabulary
    {
        public PersonVocabulary()
        {
            VocabularyName = "WaterNSW Person"; 
            KeyPrefix      = "waternsw.person"; 
            KeySeparator   = ".";
            Grouping       = EntityType.Person; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("WaterNSW Person Details", group =>
            {
                CustomerId = group.Add(new VocabularyKey("CustomerId", "Customer ID", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible));
                DlwcInpaAddressId = group.Add(new VocabularyKey("DlwcInpaAddressId", "DLWC INPA Address ID", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible));
                CustomerDate = group.Add(new VocabularyKey("CustomerDate", "Customer date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CustomerFlag = group.Add(new VocabularyKey("CustomerFlag", "Customer flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Pin = group.Add(new VocabularyKey("Pin", "PIN", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                AddressId = group.Add(new VocabularyKey("AddressId", "Address ID", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible));
                InpaId = group.Add(new VocabularyKey("InpaId", "INPA ID  ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InpaType = group.Add(new VocabularyKey("InpaType", "INPA Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Title = group.Add(new VocabularyKey("Title", "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Initials = group.Add(new VocabularyKey("Initials", "Initials", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GivenName = group.Add(new VocabularyKey("GivenName", "Given name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FamilyName = group.Add(new VocabularyKey("FamilyName", "Family Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Orders = group.Add(new VocabularyKey("Orders", "Orders", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JobTitle = group.Add(new VocabularyKey("JobTitle", "Job Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateOfBirth = group.Add(new VocabularyKey("DateOfBirth", "Date of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AustralianCompanyNumber = group.Add(new VocabularyKey("AustralianCompanyNumber", "Australian Company Number", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                AustralianBusinessNumber = group.Add(new VocabularyKey("AustralianBusinessNumber", "Australian Business Number", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                IndustryCode = group.Add(new VocabularyKey("IndustryCode", "Industry Code", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                OrganisationType = group.Add(new VocabularyKey("OrganisationType", "Organisation type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InpaIdAlias = group.Add(new VocabularyKey("InpaIdAlias", "INPA ID Alias", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Email = group.Add(new VocabularyKey("Email", "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                RowVersion = group.Add(new VocabularyKey("RowVersion", "Row version", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                RowReplaces = group.Add(new VocabularyKey("RowReplaces", "Row replaces", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                RowCreated = group.Add(new VocabularyKey("RowCreated", "Row created", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                RowExpires = group.Add(new VocabularyKey("RowExpires", "Row expires", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                RowDataSource = group.Add(new VocabularyKey("RowDataSource", "Row data source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowUpdatedBy = group.Add(new VocabularyKey("RowUpdatedBy", "Row updated by", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganisationName = group.Add(new VocabularyKey("OrganisationName", "Organisation name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartDescription = group.Add(new VocabularyKey("PartDescription", "Part description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateCreated = group.Add(new VocabularyKey("DateCreated", "Date created", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                OrgContact = group.Add(new VocabularyKey("OrgContact", "Org contact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Salutation = group.Add(new VocabularyKey("Salutation", "Salutation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MiddleName = group.Add(new VocabularyKey("MiddleName", "Middle Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Record = group.Add(new VocabularyKey("Record", "Record ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DupeGroup = group.Add(new VocabularyKey("DupeGroup", "Dupe group", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                LicenseFlag = group.Add(new VocabularyKey("LicenseFlag", "License flag", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalName = group.Add(new VocabularyKey("LegalName", "Legal name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Deceased = group.Add(new VocabularyKey("Deceased", "Deceased", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeceasedDate = group.Add(new VocabularyKey("DeceasedDate", "Deceased date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CompanyName = group.Add(new VocabularyKey("CompanyName", "Company Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CsvNumber = group.Add(new VocabularyKey("CsvNumber", "CSV number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }

        public VocabularyKey CustomerId { get; private set; }
        public VocabularyKey DlwcInpaAddressId { get; private set; }
        public VocabularyKey CustomerDate { get; private set; }
        public VocabularyKey CustomerFlag { get; private set; }
        public VocabularyKey Pin { get; private set; }
        public VocabularyKey AddressId { get; private set; }
        public VocabularyKey InpaId { get; private set; }
        public VocabularyKey InpaType { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Initials { get; private set; }
        public VocabularyKey GivenName { get; private set; }
        public VocabularyKey FamilyName { get; private set; }
        public VocabularyKey Orders { get; private set; }
        public VocabularyKey JobTitle { get; private set; }
        public VocabularyKey DateOfBirth { get; private set; }
        public VocabularyKey AustralianCompanyNumber { get; private set; }
        public VocabularyKey AustralianBusinessNumber { get; private set; }
        public VocabularyKey IndustryCode { get; private set; }
        public VocabularyKey OrganisationType { get; private set; }
        public VocabularyKey InpaIdAlias { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey RowVersion { get; private set; }
        public VocabularyKey RowReplaces { get; private set; }
        public VocabularyKey RowCreated { get; private set; }
        public VocabularyKey RowExpires { get; private set; }
        public VocabularyKey RowDataSource { get; private set; }
        public VocabularyKey RowUpdatedBy { get; private set; }
        public VocabularyKey OrganisationName { get; private set; }
        public VocabularyKey PartDescription { get; private set; }
        public VocabularyKey DateCreated { get; private set; }
        public VocabularyKey OrgContact { get; private set; }
        public VocabularyKey Salutation { get; private set; }
        public VocabularyKey MiddleName { get; private set; }
        public VocabularyKey Record { get; private set; }
        public VocabularyKey DupeGroup { get; private set; }
        public VocabularyKey LicenseFlag { get; private set; }
        public VocabularyKey LegalName { get; private set; }
        public VocabularyKey Deceased { get; private set; }
        public VocabularyKey DeceasedDate { get; private set; }
        public VocabularyKey CompanyName { get; private set; }
        public VocabularyKey CsvNumber { get; private set; }
    }
}
