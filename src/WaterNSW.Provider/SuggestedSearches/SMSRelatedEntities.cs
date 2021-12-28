using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.Crawling.WaterNSW.Core.Constants;
using CluedIn.DataStore.Document.Models;
using CluedIn.RelatedEntities;

namespace CluedIn.Provider.WaterNSW.SuggestedSearches
{
    public class SMSRelatedEntities : BaseRelatedEntitiesProvider
    {
        public SMSRelatedEntities() : base(WaterNSWEntities.SMS)
        {
        }

        public override IEnumerable<SuggestedSearch> SuggestedSearches(Guid id)
        {
            return new List<SuggestedSearch>
            {
                new SuggestedSearch
                {
                    DisplayName = "Suggested Searches",
                    SearchQuery = "{{RELATIONSHIP}} for {{ENTITY}}",
                    Tokens = string.Format("{0},{1}", EntityEdgeType.OwnedBy, id.ToString()),
                    Type = "List"
                },
                new SuggestedSearch
                {
                    DisplayName = "Activity",
                    SearchQuery = "{{RELATIONSHIP}} for {{ENTITY}} of types {{TYPE}}",
                    Tokens = string.Format("{0},{1},{2}", EntityEdgeType.OwnedBy, id.ToString(), WaterNSWEntities.Activity),
                    Type = "List"
                },
                new SuggestedSearch
                {
                    DisplayName = "Related Person",
                    SearchQuery = "{{RELATIONSHIP}} for {{ENTITY}} of types {{TYPE}}",
                    Tokens = string.Format("{0},{1},{2}", EntityEdgeType.OwnedBy, id.ToString(), EntityType.Person),
                    Type = "List"
                },
            };
        }
    }
}
