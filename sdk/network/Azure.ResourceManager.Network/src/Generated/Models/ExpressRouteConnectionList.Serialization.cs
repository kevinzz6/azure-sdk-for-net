// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Network;

namespace Azure.ResourceManager.Network.Models
{
    internal partial class ExpressRouteConnectionList
    {
        internal static ExpressRouteConnectionList DeserializeExpressRouteConnectionList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<ExpressRouteConnectionData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ExpressRouteConnectionData> array = new List<ExpressRouteConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ExpressRouteConnectionData.DeserializeExpressRouteConnectionData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ExpressRouteConnectionList(Optional.ToList(value));
        }
    }
}
