﻿using System;
using System.Collections.Generic;
using System.Text;
using CluedIn.Core;
using CluedIn.Core.Data;
using CluedIn.RelatedEntities;
using Microsoft.Extensions.Logging;

namespace CluedIn.Provider.WaterNSW.SuggestedSearches
{
    public abstract class BaseRelatedEntitiesProvider : IRelatedEntitiesProvider
    {
        public readonly EntityType EntityType;
        public BaseRelatedEntitiesProvider(EntityType entityType)
        {
            EntityType = entityType;
        }

        public abstract IEnumerable<DataStore.Document.Models.SuggestedSearch> SuggestedSearches(Guid id);
        public List<DataStore.Document.Models.SuggestedSearch> searches = new List<DataStore.Document.Models.SuggestedSearch>();

        public IEnumerable<DataStore.Document.Models.SuggestedSearch> GetRelatedEntitiesSearches(ExecutionContext context, Entity entity)
        {
            if (entity.Type == EntityType)
            {
                var Log = context.Log;
                Log.LogInformation($"[Related Entities] GetRelatedEntitiesSearches({context}, {entity})");

                foreach (var suggestedSearch in SuggestedSearches(entity.Id))
                {
                    try
                    {
                        if (RelatedEntitiesUtility.CypherFluentQueriesCount(suggestedSearch.SearchQuery, suggestedSearch.Tokens, context) > 0)
                            searches.Add(suggestedSearch);
                        else
                            Log.LogInformation($"[Related Entities] No result: {suggestedSearch.SearchQuery}");
                    }
                    catch (Exception ex)
                    {
                        Log.LogCritical(ex, "[Related Entities] Error in executing Suggested Search: " + suggestedSearch.DisplayName);
                    }
                }

                return searches;
            }

            return new DataStore.Document.Models.SuggestedSearch[0];
        }
    }
}
