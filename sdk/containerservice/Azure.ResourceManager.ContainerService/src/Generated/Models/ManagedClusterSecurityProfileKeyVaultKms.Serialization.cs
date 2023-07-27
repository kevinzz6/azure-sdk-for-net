// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterSecurityProfileKeyVaultKms : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (Optional.IsDefined(KeyId))
            {
                writer.WritePropertyName("keyId"u8);
                writer.WriteStringValue(KeyId);
            }
            if (Optional.IsDefined(KeyVaultNetworkAccess))
            {
                writer.WritePropertyName("keyVaultNetworkAccess"u8);
                writer.WriteStringValue(KeyVaultNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultResourceId))
            {
                writer.WritePropertyName("keyVaultResourceId"u8);
                writer.WriteStringValue(KeyVaultResourceId);
            }
            writer.WriteEndObject();
        }

        internal static ManagedClusterSecurityProfileKeyVaultKms DeserializeManagedClusterSecurityProfileKeyVaultKms(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<string> keyId = default;
            Optional<ManagedClusterKeyVaultNetworkAccessType> keyVaultNetworkAccess = default;
            Optional<ResourceIdentifier> keyVaultResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("keyId"u8))
                {
                    keyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultNetworkAccess = new ManagedClusterKeyVaultNetworkAccessType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("keyVaultResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    keyVaultResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new ManagedClusterSecurityProfileKeyVaultKms(Optional.ToNullable(enabled), keyId.Value, Optional.ToNullable(keyVaultNetworkAccess), keyVaultResourceId.Value);
        }
    }
}
