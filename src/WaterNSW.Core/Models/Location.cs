using System;
using Newtonsoft.Json;

namespace CluedIn.Crawling.WaterNSW.Core.Models
{
    public class Location 
    {
        public string InpaAddressId { get; set; }
        public string DlwcAddressId { get; set; }
        public string DlwcInpaId { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public string AddressId { get; set; }
        public string UnitType { get; set; }
        public string UnitNumber { get; set; }
        public string UnitSuffix { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string PremisesType { get; set; }
        public string FloorType { get; set; }
        public string FloorNumber { get; set; }
        public string FloorSuffix { get; set; }
        public string BuildingName { get; set; }
        public string LocaitonDescriptor { get; set; }
        public string FirstHouseNumber { get; set; }
        public string FirstHousePrefix { get; set; }
        public string FirstHouseSuffix { get; set; }
        public string SecondHouseNumber { get; set; }
        public string SecondHousePrefix { get; set; }
        public string SecondHourseSuffix { get; set; }
        public string LotType { get; set; }
        public string LotNumber { get; set; }
        public string LotSuffix { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string StreetSuffix { get; set; }
        public string StreetName2 { get; set; }
        public string StreetType2 { get; set; }
        public string StreetSuffix2 { get; set; }
        public string Suburb { get; set; }
        public string County { get; set; }
        public string Parish { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PostalServiceType { get; set; }
        public string PostalServiceIdentifier { get; set; }
        public int PostCode { get; set; }
        public int DeliveryPointId { get; set; }
        public string AsonDescriptor { get; set; }
        public string AddressType { get; set; }
        public int RowVersion { get; set; }
        public int RowReplaces { get; set; }
        public DateTime RowCreated { get; set; }
        public DateTime RowExpires { get; set; }
        public string RowDataSource { get; set; }
        public string RowUpdatedBy { get; set; }
        public string PAddressLine1 { get; set; }
        public string PAddressLine2 { get; set; }
        public string PSuburb { get; set; }
        public string PState { get; set; }
        public string PCountry { get; set; }
        public int PPostCode { get; set; }
        public int PDeliveryPoint { get; set; }
        public string CareOf { get; set; }
        public string PCareOf { get; set; }
    }
}
