// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Maps.Search;

namespace Azure.Maps.Search.Models
{
    public partial class ReverseSearchAddressItem
    {
        internal static ReverseSearchAddressItem DeserializeReverseSearchAddressItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MapsAddress> address = default;
            Optional<string> position = default;
            Optional<IReadOnlyList<RoadKind>> roadUse = default;
            Optional<MapsSearchMatchType> matchType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("address"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    address = MapsAddress.DeserializeMapsAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("position"u8))
                {
                    position = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("roadUse"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoadKind> array = new List<RoadKind>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new RoadKind(item.GetString()));
                    }
                    roadUse = array;
                    continue;
                }
                if (property.NameEquals("matchType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    matchType = new MapsSearchMatchType(property.Value.GetString());
                    continue;
                }
            }
            return new ReverseSearchAddressItem(address.Value, position.Value, Optional.ToList(roadUse), Optional.ToNullable(matchType));
        }
    }
}
