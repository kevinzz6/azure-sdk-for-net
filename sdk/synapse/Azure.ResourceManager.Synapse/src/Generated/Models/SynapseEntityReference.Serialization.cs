// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseEntityReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IntegrationRuntimeEntityReferenceType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(IntegrationRuntimeEntityReferenceType.Value.ToString());
            }
            if (Optional.IsDefined(ReferenceName))
            {
                writer.WritePropertyName("referenceName"u8);
                writer.WriteStringValue(ReferenceName);
            }
            writer.WriteEndObject();
        }

        internal static SynapseEntityReference DeserializeSynapseEntityReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SynapseIntegrationRuntimeEntityReferenceType> type = default;
            Optional<string> referenceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new SynapseIntegrationRuntimeEntityReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"u8))
                {
                    referenceName = property.Value.GetString();
                    continue;
                }
            }
            return new SynapseEntityReference(Optional.ToNullable(type), referenceName.Value);
        }
    }
}
