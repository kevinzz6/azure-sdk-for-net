// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Storage.Models;

namespace Azure.ResourceManager.Storage
{
    public partial class EncryptionScopeData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Source))
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source.Value.ToString());
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(KeyVaultProperties))
            {
                writer.WritePropertyName("keyVaultProperties"u8);
                writer.WriteObjectValue(KeyVaultProperties);
            }
            if (Optional.IsDefined(RequireInfrastructureEncryption))
            {
                writer.WritePropertyName("requireInfrastructureEncryption"u8);
                writer.WriteBooleanValue(RequireInfrastructureEncryption.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static EncryptionScopeData DeserializeEncryptionScopeData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<EncryptionScopeSource> source = default;
            Optional<EncryptionScopeState> state = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<EncryptionScopeKeyVaultProperties> keyVaultProperties = default;
            Optional<bool> requireInfrastructureEncryption = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("source"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            source = new EncryptionScopeSource(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new EncryptionScopeState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("keyVaultProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            keyVaultProperties = EncryptionScopeKeyVaultProperties.DeserializeEncryptionScopeKeyVaultProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("requireInfrastructureEncryption"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requireInfrastructureEncryption = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new EncryptionScopeData(id, name, type, systemData.Value, Optional.ToNullable(source), Optional.ToNullable(state), Optional.ToNullable(creationTime), Optional.ToNullable(lastModifiedTime), keyVaultProperties.Value, Optional.ToNullable(requireInfrastructureEncryption));
        }
    }
}
