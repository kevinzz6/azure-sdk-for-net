// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class StreamingEndpointSkuInfoListResult
    {
        internal static StreamingEndpointSkuInfoListResult DeserializeStreamingEndpointSkuInfoListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<StreamingEndpointSkuInfo>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<StreamingEndpointSkuInfo> array = new List<StreamingEndpointSkuInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(StreamingEndpointSkuInfo.DeserializeStreamingEndpointSkuInfo(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new StreamingEndpointSkuInfoListResult(Optional.ToList(value));
        }
    }
}
