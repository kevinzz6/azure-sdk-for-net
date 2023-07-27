// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxManagedIdentity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IdentityType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IdentityType);
            }
            if (Optional.IsDefined(UserAssigned))
            {
                writer.WritePropertyName("userAssigned"u8);
                writer.WriteObjectValue(UserAssigned);
            }
            writer.WriteEndObject();
        }

        internal static DataBoxManagedIdentity DeserializeDataBoxManagedIdentity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> type = default;
            Optional<DataBoxUserAssignedIdentity> userAssigned = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userAssigned"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userAssigned = DataBoxUserAssignedIdentity.DeserializeDataBoxUserAssignedIdentity(property.Value);
                    continue;
                }
            }
            return new DataBoxManagedIdentity(type.Value, userAssigned.Value);
        }
    }
}
