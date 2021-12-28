using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.WaterNSW.Core.Constants;

namespace CluedIn.Crawling.WaterNSW.Vocabularies
{
    public class  SMSVocabulary : SimpleVocabulary
    {
        public  SMSVocabulary()
        {
            VocabularyName = "WaterNSW SMS"; 
            KeyPrefix      = "waternsw.sms"; 
            KeySeparator   = ".";
            Grouping       = WaterNSWEntities.SMS; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("WaterNSW SMS Details", group =>
            {
                TransactionId = group.Add(new VocabularyKey("TransactionId", "Transaction ID", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible));
                CustomerId = group.Add(new VocabularyKey("CustomerId", "Customer ID", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible));
                MessageTypeCode = group.Add(new VocabularyKey("MessageTypeCode", "Message type code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey("StartDate", "Start date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CloseDate = group.Add(new VocabularyKey("CloseDate", "Close date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                WaterType = group.Add(new VocabularyKey("WaterType", "Water type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaterSourceCode = group.Add(new VocabularyKey("WaterSourceCode", "Water source code", VocabularyKeyDataType.Identifier, VocabularyKeyVisibility.Visible));
                WmzCode = group.Add(new VocabularyKey("WmzCode", "WMZ code", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                LicenseSubcategoryId = group.Add(new VocabularyKey("LicenseSubcategoryId", "License subcategory ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                License = group.Add(new VocabularyKey("License", "License  ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Message = group.Add(new VocabularyKey("Message", "Message  ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Url = group.Add(new VocabularyKey("Url", "URL", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UrlTitle = group.Add(new VocabularyKey("UrlTitle", "URL title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionStatus = group.Add(new VocabularyKey("TransactionStatus", "Transaction status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionUserId = group.Add(new VocabularyKey("TransactionUserId", "Transaction user ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey("TransactionDate", "Transaction date", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }

        public VocabularyKey TransactionId { get; private set; }
        public VocabularyKey CustomerId { get; private set; }
        public VocabularyKey MessageTypeCode { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey CloseDate { get; private set; }
        public VocabularyKey WaterType { get; private set; }
        public VocabularyKey WaterSourceCode { get; private set; }
        public VocabularyKey WmzCode { get; private set; }
        public VocabularyKey LicenseSubcategoryId { get; private set; }
        public VocabularyKey License { get; private set; }
        public VocabularyKey Message { get; private set; }
        public VocabularyKey Url { get; private set; }
        public VocabularyKey UrlTitle { get; private set; }
        public VocabularyKey TransactionStatus { get; private set; }
        public VocabularyKey TransactionUserId { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
    }
}
