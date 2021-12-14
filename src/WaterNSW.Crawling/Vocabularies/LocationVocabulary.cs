using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;
using CluedIn.Crawling.WaterNSW.Core.Constants;

namespace CluedIn.Crawling.WaterNSW.Vocabularies
{
    public class  LocationVocabulary : SimpleVocabulary
    {
        public  LocationVocabulary()
        {
            VocabularyName = "WaterNSW Location"; 
            KeyPrefix      = "waternsw.location"; 
            KeySeparator   = ".";
            Grouping       = WaterNSWEntities.Location; // TODO: Make sure EntityType is correct.

            //TODO: Make sure that any properties mapped into CluedIn Vocabulary are not in the group.
            AddGroup("WaterNSW Location Details", group =>
            {
                InpaAddressId = group.Add(new VocabularyKey("InpaAddressId", "INPA Address ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DlwcAddressId = group.Add(new VocabularyKey("DlwcAddressId", "DLWC Address ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DlwcInpaId = group.Add(new VocabularyKey("DlwcInpaId", "DLWC INPA ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey("ValidFrom", "Valid from", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey("ValidTo", "Valid to", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                AddressId = group.Add(new VocabularyKey("AddressId", "Address ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitType = group.Add(new VocabularyKey("UnitType", "Unit type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitNumber = group.Add(new VocabularyKey("UnitNumber", "Unit number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitSuffix = group.Add(new VocabularyKey("UnitSuffix", "Unit suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine1 = group.Add(new VocabularyKey("AddressLine1", "Address Line 1", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine2 = group.Add(new VocabularyKey("AddressLine2", "Address line 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine3 = group.Add(new VocabularyKey("AddressLine3", "Address line 3", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine4 = group.Add(new VocabularyKey("AddressLine4", "Address line 4", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PremisesType = group.Add(new VocabularyKey("PremisesType", "Premises type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FloorType = group.Add(new VocabularyKey("FloorType", "Floor type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FloorNumber = group.Add(new VocabularyKey("FloorNumber", "Floor number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FloorSuffix = group.Add(new VocabularyKey("FloorSuffix", "Floor suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuildingName = group.Add(new VocabularyKey("BuildingName", "Building name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocaitonDescriptor = group.Add(new VocabularyKey("LocaitonDescriptor", "Locaiton descriptor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstHouseNumber = group.Add(new VocabularyKey("FirstHouseNumber", "First house number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstHousePrefix = group.Add(new VocabularyKey("FirstHousePrefix", "First house prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstHouseSuffix = group.Add(new VocabularyKey("FirstHouseSuffix", "first house suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondHouseNumber = group.Add(new VocabularyKey("SecondHouseNumber", "Second house number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondHousePrefix = group.Add(new VocabularyKey("SecondHousePrefix", "Second house prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondHourseSuffix = group.Add(new VocabularyKey("SecondHourseSuffix", "Second hourse suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LotType = group.Add(new VocabularyKey("LotType", "Lot type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LotNumber = group.Add(new VocabularyKey("LotNumber", "Lot number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LotSuffix = group.Add(new VocabularyKey("LotSuffix", "Lot suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetName = group.Add(new VocabularyKey("StreetName", "Street Name", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible));
                StreetType = group.Add(new VocabularyKey("StreetType", "Street type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetSuffix = group.Add(new VocabularyKey("StreetSuffix", "Street suffix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetName2 = group.Add(new VocabularyKey("StreetName2", "Street name 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetType2 = group.Add(new VocabularyKey("StreetType2", "Street type 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetSuffix2 = group.Add(new VocabularyKey("StreetSuffix2", "Street suffix 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Suburb = group.Add(new VocabularyKey("Suburb", "Suburb", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey("County", "County", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Parish = group.Add(new VocabularyKey("Parish", "Parish", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey("State", "State", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey("Country", "Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible));
                PostalServiceType = group.Add(new VocabularyKey("PostalServiceType", "Postal service type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalServiceIdentifier = group.Add(new VocabularyKey("PostalServiceIdentifier", "Postal service identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostCode = group.Add(new VocabularyKey("PostCode", "Post Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DeliveryPointId = group.Add(new VocabularyKey("DeliveryPointId", "Delivery Point ID", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                AsonDescriptor = group.Add(new VocabularyKey("AsonDescriptor", "Ason descriptor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressType = group.Add(new VocabularyKey("AddressType", "Address type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowVersion = group.Add(new VocabularyKey("RowVersion", "Row version", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                RowReplaces = group.Add(new VocabularyKey("RowReplaces", "Row replaces", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                RowCreated = group.Add(new VocabularyKey("RowCreated", "Row created", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                RowExpires = group.Add(new VocabularyKey("RowExpires", "Row expires", VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                RowDataSource = group.Add(new VocabularyKey("RowDataSource", "Row data source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowUpdatedBy = group.Add(new VocabularyKey("RowUpdatedBy", "Row updated by", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PAddressLine1 = group.Add(new VocabularyKey("PAddressLine1", "P Address Line 1", VocabularyKeyDataType.GeographyLocation, VocabularyKeyVisibility.Visible));
                PAddressLine2 = group.Add(new VocabularyKey("PAddressLine2", "P Address Line 2", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PSuburb = group.Add(new VocabularyKey("PSuburb", "P Suburb", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PState = group.Add(new VocabularyKey("PState", "P State", VocabularyKeyDataType.GeographyState, VocabularyKeyVisibility.Visible));
                PCountry = group.Add(new VocabularyKey("PCountry", "P Country", VocabularyKeyDataType.GeographyCountry, VocabularyKeyVisibility.Visible));
                PPostCode = group.Add(new VocabularyKey("PPostCode", "P Post code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                PDeliveryPoint = group.Add(new VocabularyKey("PDeliveryPoint", "P Delivery point", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                CareOf = group.Add(new VocabularyKey("CareOf", "Care of", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PCareOf = group.Add(new VocabularyKey("PCareOf", "P Care of", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            //TODO: If the property is already set in the clueproducer, it doesn't have to be here.
             
            //TODO: Don't forget to map all possible properties into already existing CluedIn Vocabularies.
        
        }

        public VocabularyKey DlwcAddressId { get; private set; }
        public VocabularyKey InpaAddressId { get; private set; }
        public VocabularyKey DlwcInpaId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey AddressId { get; private set; }
        public VocabularyKey UnitType { get; private set; }
        public VocabularyKey UnitNumber { get; private set; }
        public VocabularyKey UnitSuffix { get; private set; }
        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressLine3 { get; private set; }
        public VocabularyKey AddressLine4 { get; private set; }
        public VocabularyKey PremisesType { get; private set; }
        public VocabularyKey FloorType { get; private set; }
        public VocabularyKey FloorNumber { get; private set; }
        public VocabularyKey FloorSuffix { get; private set; }
        public VocabularyKey BuildingName { get; private set; }
        public VocabularyKey LocaitonDescriptor { get; private set; }
        public VocabularyKey FirstHouseNumber { get; private set; }
        public VocabularyKey FirstHousePrefix { get; private set; }
        public VocabularyKey FirstHouseSuffix { get; private set; }
        public VocabularyKey SecondHouseNumber { get; private set; }
        public VocabularyKey SecondHousePrefix { get; private set; }
        public VocabularyKey SecondHourseSuffix { get; private set; }
        public VocabularyKey LotType { get; private set; }
        public VocabularyKey LotNumber { get; private set; }
        public VocabularyKey LotSuffix { get; private set; }
        public VocabularyKey StreetName { get; private set; }
        public VocabularyKey StreetType { get; private set; }
        public VocabularyKey StreetSuffix { get; private set; }
        public VocabularyKey StreetName2 { get; private set; }
        public VocabularyKey StreetType2 { get; private set; }
        public VocabularyKey StreetSuffix2 { get; private set; }
        public VocabularyKey Suburb { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey Parish { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey PostalServiceType { get; private set; }
        public VocabularyKey PostalServiceIdentifier { get; private set; }
        public VocabularyKey PostCode { get; private set; }
        public VocabularyKey DeliveryPointId { get; private set; }
        public VocabularyKey AsonDescriptor { get; private set; }
        public VocabularyKey AddressType { get; private set; }
        public VocabularyKey RowVersion { get; private set; }
        public VocabularyKey RowReplaces { get; private set; }
        public VocabularyKey RowCreated { get; private set; }
        public VocabularyKey RowExpires { get; private set; }
        public VocabularyKey RowDataSource { get; private set; }
        public VocabularyKey RowUpdatedBy { get; private set; }
        public VocabularyKey PAddressLine1 { get; private set; }
        public VocabularyKey PAddressLine2 { get; private set; }
        public VocabularyKey PSuburb { get; private set; }
        public VocabularyKey PState { get; private set; }
        public VocabularyKey PCountry { get; private set; }
        public VocabularyKey PPostCode { get; private set; }
        public VocabularyKey PDeliveryPoint { get; private set; }
        public VocabularyKey CareOf { get; private set; }
        public VocabularyKey PCareOf { get; private set; }
    }
}
