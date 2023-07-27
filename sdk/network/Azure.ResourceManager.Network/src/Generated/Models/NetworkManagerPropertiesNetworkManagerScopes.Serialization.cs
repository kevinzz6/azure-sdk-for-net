// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkManagerPropertiesNetworkManagerScopes : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ManagementGroups))
            {
                writer.WritePropertyName("managementGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ManagementGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Subscriptions))
            {
                writer.WritePropertyName("subscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static NetworkManagerPropertiesNetworkManagerScopes DeserializeNetworkManagerPropertiesNetworkManagerScopes(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> managementGroups = default;
            Optional<IList<string>> subscriptions = default;
            Optional<IReadOnlyList<CrossTenantScopes>> crossTenantScopes = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managementGroups"u8))
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
                    managementGroups = array;
                    continue;
                }
                if (property.NameEquals("subscriptions"u8))
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
                    subscriptions = array;
                    continue;
                }
                if (property.NameEquals("crossTenantScopes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CrossTenantScopes> array = new List<CrossTenantScopes>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.CrossTenantScopes.DeserializeCrossTenantScopes(item));
                    }
                    crossTenantScopes = array;
                    continue;
                }
            }
            return new NetworkManagerPropertiesNetworkManagerScopes(Optional.ToList(managementGroups), Optional.ToList(subscriptions), Optional.ToList(crossTenantScopes));
        }
    }
}
