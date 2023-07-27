// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class IPCommunityIdList : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(IPCommunityIds))
            {
                writer.WritePropertyName("ipCommunityIds"u8);
                writer.WriteStartArray();
                foreach (var item in IPCommunityIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static IPCommunityIdList DeserializeIPCommunityIdList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> ipCommunityIds = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipCommunityIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ipCommunityIds = array;
                    continue;
                }
            }
            return new IPCommunityIdList(Optional.ToList(ipCommunityIds));
        }
    }
}
