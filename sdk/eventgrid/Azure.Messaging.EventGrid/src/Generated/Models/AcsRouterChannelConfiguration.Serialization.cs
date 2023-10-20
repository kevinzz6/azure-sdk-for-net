// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsRouterChannelConfiguration
    {
        internal static AcsRouterChannelConfiguration DeserializeAcsRouterChannelConfiguration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> channelId = default;
            Optional<int> capacityCostPerJob = default;
            Optional<int> maxNumberOfJobs = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacityCostPerJob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacityCostPerJob = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxNumberOfJobs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxNumberOfJobs = property.Value.GetInt32();
                    continue;
                }
            }
            return new AcsRouterChannelConfiguration(channelId.Value, Optional.ToNullable(capacityCostPerJob), Optional.ToNullable(maxNumberOfJobs));
        }
    }
}
