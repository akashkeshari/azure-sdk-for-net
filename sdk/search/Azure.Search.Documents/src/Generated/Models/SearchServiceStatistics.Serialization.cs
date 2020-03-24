// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    public partial class SearchServiceStatistics
    {
        internal static SearchServiceStatistics DeserializeSearchServiceStatistics(JsonElement element)
        {
            SearchServiceCounters counters = default;
            SearchServiceLimits limits = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("counters"))
                {
                    counters = SearchServiceCounters.DeserializeSearchServiceCounters(property.Value);
                    continue;
                }
                if (property.NameEquals("limits"))
                {
                    limits = SearchServiceLimits.DeserializeSearchServiceLimits(property.Value);
                    continue;
                }
            }
            return new SearchServiceStatistics(counters, limits);
        }
    }
}
