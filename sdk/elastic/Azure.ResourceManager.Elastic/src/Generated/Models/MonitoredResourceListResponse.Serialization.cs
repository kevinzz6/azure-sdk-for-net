// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Elastic.Models
{
    internal partial class MonitoredResourceListResponse
    {
        internal static MonitoredResourceListResponse DeserializeMonitoredResourceListResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MonitoredResourceContent>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MonitoredResourceContent> array = new List<MonitoredResourceContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MonitoredResourceContent.DeserializeMonitoredResourceContent(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new MonitoredResourceListResponse(Optional.ToList(value), nextLink.Value);
        }
    }
}
