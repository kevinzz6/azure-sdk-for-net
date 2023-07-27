// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    internal partial class ClusterMetricsConfigurationList
    {
        internal static ClusterMetricsConfigurationList DeserializeClusterMetricsConfigurationList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<ClusterMetricsConfigurationData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClusterMetricsConfigurationData> array = new List<ClusterMetricsConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClusterMetricsConfigurationData.DeserializeClusterMetricsConfigurationData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ClusterMetricsConfigurationList(nextLink.Value, Optional.ToList(value));
        }
    }
}
