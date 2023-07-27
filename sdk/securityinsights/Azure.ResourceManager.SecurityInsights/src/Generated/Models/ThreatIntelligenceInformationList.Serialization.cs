// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class ThreatIntelligenceInformationList
    {
        internal static ThreatIntelligenceInformationList DeserializeThreatIntelligenceInformationList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            IReadOnlyList<SecurityInsightsThreatIntelligenceIndicatorBaseData> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    List<SecurityInsightsThreatIntelligenceIndicatorBaseData> array = new List<SecurityInsightsThreatIntelligenceIndicatorBaseData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityInsightsThreatIntelligenceIndicatorBaseData.DeserializeSecurityInsightsThreatIntelligenceIndicatorBaseData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ThreatIntelligenceInformationList(nextLink.Value, value);
        }
    }
}
