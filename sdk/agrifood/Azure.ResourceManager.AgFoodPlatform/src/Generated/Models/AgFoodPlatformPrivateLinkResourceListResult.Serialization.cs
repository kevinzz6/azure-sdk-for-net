// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AgFoodPlatform;

namespace Azure.ResourceManager.AgFoodPlatform.Models
{
    internal partial class AgFoodPlatformPrivateLinkResourceListResult
    {
        internal static AgFoodPlatformPrivateLinkResourceListResult DeserializeAgFoodPlatformPrivateLinkResourceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AgFoodPlatformPrivateLinkResourceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AgFoodPlatformPrivateLinkResourceData> array = new List<AgFoodPlatformPrivateLinkResourceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AgFoodPlatformPrivateLinkResourceData.DeserializeAgFoodPlatformPrivateLinkResourceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new AgFoodPlatformPrivateLinkResourceListResult(Optional.ToList(value));
        }
    }
}
