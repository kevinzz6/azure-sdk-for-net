// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class QosPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(FiveQi))
            {
                writer.WritePropertyName("5qi"u8);
                writer.WriteNumberValue(FiveQi.Value);
            }
            if (Optional.IsDefined(AllocationAndRetentionPriorityLevel))
            {
                writer.WritePropertyName("allocationAndRetentionPriorityLevel"u8);
                writer.WriteNumberValue(AllocationAndRetentionPriorityLevel.Value);
            }
            if (Optional.IsDefined(PreemptionCapability))
            {
                writer.WritePropertyName("preemptionCapability"u8);
                writer.WriteStringValue(PreemptionCapability.Value.ToString());
            }
            if (Optional.IsDefined(PreemptionVulnerability))
            {
                writer.WritePropertyName("preemptionVulnerability"u8);
                writer.WriteStringValue(PreemptionVulnerability.Value.ToString());
            }
            writer.WritePropertyName("maximumBitRate"u8);
            writer.WriteObjectValue(MaximumBitRate);
            writer.WriteEndObject();
        }

        internal static QosPolicy DeserializeQosPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> _5qi = default;
            Optional<int> allocationAndRetentionPriorityLevel = default;
            Optional<PreemptionCapability> preemptionCapability = default;
            Optional<PreemptionVulnerability> preemptionVulnerability = default;
            Ambr maximumBitRate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("5qi"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    _5qi = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allocationAndRetentionPriorityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    allocationAndRetentionPriorityLevel = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("preemptionCapability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preemptionCapability = new PreemptionCapability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("preemptionVulnerability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preemptionVulnerability = new PreemptionVulnerability(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maximumBitRate"u8))
                {
                    maximumBitRate = Ambr.DeserializeAmbr(property.Value);
                    continue;
                }
            }
            return new QosPolicy(Optional.ToNullable(_5qi), Optional.ToNullable(allocationAndRetentionPriorityLevel), Optional.ToNullable(preemptionCapability), Optional.ToNullable(preemptionVulnerability), maximumBitRate);
        }
    }
}
