// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    public partial class GroupConnectivityInformation : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(CustomerVisibleFqdns))
            {
                writer.WritePropertyName("customerVisibleFqdns"u8);
                writer.WriteStartArray();
                foreach (var item in CustomerVisibleFqdns)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RedirectMapId))
            {
                writer.WritePropertyName("redirectMapId"u8);
                writer.WriteStringValue(RedirectMapId);
            }
            if (Optional.IsDefined(PrivateLinkServiceArmRegion))
            {
                writer.WritePropertyName("privateLinkServiceArmRegion"u8);
                writer.WriteStringValue(PrivateLinkServiceArmRegion);
            }
            writer.WriteEndObject();
        }

        internal static GroupConnectivityInformation DeserializeGroupConnectivityInformation(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> groupId = default;
            Optional<string> memberName = default;
            Optional<IList<string>> customerVisibleFqdns = default;
            Optional<string> internalFqdn = default;
            Optional<string> redirectMapId = default;
            Optional<string> privateLinkServiceArmRegion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupId"u8))
                {
                    groupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("memberName"u8))
                {
                    memberName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("customerVisibleFqdns"u8))
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
                    customerVisibleFqdns = array;
                    continue;
                }
                if (property.NameEquals("internalFqdn"u8))
                {
                    internalFqdn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("redirectMapId"u8))
                {
                    redirectMapId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("privateLinkServiceArmRegion"u8))
                {
                    privateLinkServiceArmRegion = property.Value.GetString();
                    continue;
                }
            }
            return new GroupConnectivityInformation(groupId.Value, memberName.Value, Optional.ToList(customerVisibleFqdns), internalFqdn.Value, redirectMapId.Value, privateLinkServiceArmRegion.Value);
        }
    }
}
