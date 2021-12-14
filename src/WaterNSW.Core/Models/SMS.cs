using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.WaterNSW.Core.Models
{
    public class SMS 
    {
        public int TransactionId { get; set; }
        public string CustomerId { get; set; }
        public string MessageTypeCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string WaterType { get; set; }
        public string WaterSourceCode { get; set; }
        public int WmzCode { get; set; }
        public string LicenseSubcategoryId { get; set; }
        public string License { get; set; }
        public string Message { get; set; }
        public string Url { get; set; }
        public string UrlTitle { get; set; }
        public string TransactionStatus { get; set; }
        public string TransactionUserId { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
