// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class ResourceMetricAvailability
    {
        internal static ResourceMetricAvailability DeserializeResourceMetricAvailability(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> timeGrain = default;
            Optional<string> retention = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeGrain"u8))
                {
                    timeGrain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("retention"u8))
                {
                    retention = property.Value.GetString();
                    continue;
                }
            }
            return new ResourceMetricAvailability(timeGrain.Value, retention.Value);
        }
    }
}
