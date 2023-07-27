// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class PartnerServerInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            writer.WriteEndObject();
        }

        internal static PartnerServerInfo DeserializePartnerServerInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            Optional<AzureLocation> location = default;
            Optional<FailoverGroupReplicationRole> replicationRole = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationRole"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationRole = new FailoverGroupReplicationRole(property.Value.GetString());
                    continue;
                }
            }
            return new PartnerServerInfo(id, Optional.ToNullable(location), Optional.ToNullable(replicationRole));
        }
    }
}
