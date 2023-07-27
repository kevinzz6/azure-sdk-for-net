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
    internal partial class L2NetworkList
    {
        internal static L2NetworkList DeserializeL2NetworkList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<L2NetworkData>> value = default;
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
                    List<L2NetworkData> array = new List<L2NetworkData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(L2NetworkData.DeserializeL2NetworkData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new L2NetworkList(nextLink.Value, Optional.ToList(value));
        }
    }
}
