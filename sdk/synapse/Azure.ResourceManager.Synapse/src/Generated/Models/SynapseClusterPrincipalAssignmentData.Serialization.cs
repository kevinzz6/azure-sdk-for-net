// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    public partial class SynapseClusterPrincipalAssignmentData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(PrincipalId))
            {
                writer.WritePropertyName("principalId"u8);
                writer.WriteStringValue(PrincipalId);
            }
            if (Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToString());
            }
            if (Optional.IsDefined(TenantId))
            {
                writer.WritePropertyName("tenantId"u8);
                writer.WriteStringValue(TenantId.Value);
            }
            if (Optional.IsDefined(PrincipalType))
            {
                writer.WritePropertyName("principalType"u8);
                writer.WriteStringValue(PrincipalType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SynapseClusterPrincipalAssignmentData DeserializeSynapseClusterPrincipalAssignmentData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> principalId = default;
            Optional<SynapseClusterPrincipalRole> role = default;
            Optional<Guid> tenantId = default;
            Optional<SynapsePrincipalType> principalType = default;
            Optional<string> tenantName = default;
            Optional<string> principalName = default;
            Optional<ResourceProvisioningState> provisioningState = default;
            Optional<Guid> aadObjectId = default;
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
                        if (property0.NameEquals("principalId"u8))
                        {
                            principalId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("role"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            role = new SynapseClusterPrincipalRole(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tenantId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            tenantId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("principalType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            principalType = new SynapsePrincipalType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("tenantName"u8))
                        {
                            tenantName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("principalName"u8))
                        {
                            principalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ResourceProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("aadObjectId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aadObjectId = property0.Value.GetGuid();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SynapseClusterPrincipalAssignmentData(id, name, type, systemData.Value, principalId.Value, Optional.ToNullable(role), Optional.ToNullable(tenantId), Optional.ToNullable(principalType), tenantName.Value, principalName.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(aadObjectId));
        }
    }
}
