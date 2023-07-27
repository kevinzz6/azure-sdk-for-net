// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridContainerService.Models
{
    public partial class AgentPoolProvisioningStatusStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ErrorMessage))
            {
                writer.WritePropertyName("errorMessage"u8);
                writer.WriteStringValue(ErrorMessage);
            }
            if (Optional.IsDefined(ProvisioningStatus))
            {
                writer.WritePropertyName("provisioningStatus"u8);
                writer.WriteObjectValue(ProvisioningStatus);
            }
            if (Optional.IsDefined(ReadyReplicas))
            {
                writer.WritePropertyName("readyReplicas"u8);
                writer.WriteNumberValue(ReadyReplicas.Value);
            }
            if (Optional.IsDefined(Replicas))
            {
                writer.WritePropertyName("replicas"u8);
                writer.WriteNumberValue(Replicas.Value);
            }
            writer.WriteEndObject();
        }

        internal static AgentPoolProvisioningStatusStatus DeserializeAgentPoolProvisioningStatusStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> errorMessage = default;
            Optional<AgentPoolProvisioningStatusStatusProvisioningStatus> provisioningStatus = default;
            Optional<int> readyReplicas = default;
            Optional<int> replicas = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errorMessage"u8))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningStatus = AgentPoolProvisioningStatusStatusProvisioningStatus.DeserializeAgentPoolProvisioningStatusStatusProvisioningStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("readyReplicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readyReplicas = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("replicas"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicas = property.Value.GetInt32();
                    continue;
                }
            }
            return new AgentPoolProvisioningStatusStatus(errorMessage.Value, provisioningStatus.Value, Optional.ToNullable(readyReplicas), Optional.ToNullable(replicas));
        }
    }
}
