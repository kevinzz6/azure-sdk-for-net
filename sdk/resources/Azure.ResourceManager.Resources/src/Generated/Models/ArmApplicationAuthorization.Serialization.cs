// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ArmApplicationAuthorization : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("principalId"u8);
            writer.WriteStringValue(PrincipalId);
            writer.WritePropertyName("roleDefinitionId"u8);
            writer.WriteStringValue(RoleDefinitionId);
            writer.WriteEndObject();
        }

        internal static ArmApplicationAuthorization DeserializeArmApplicationAuthorization(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid principalId = default;
            string roleDefinitionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("roleDefinitionId"u8))
                {
                    roleDefinitionId = property.Value.GetString();
                    continue;
                }
            }
            return new ArmApplicationAuthorization(principalId, roleDefinitionId);
        }
    }
}
