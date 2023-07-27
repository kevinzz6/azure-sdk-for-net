// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(PolicyInsightsPolicyStateDeletedEventDataConverter))]
    public partial class PolicyInsightsPolicyStateDeletedEventData
    {
        internal static PolicyInsightsPolicyStateDeletedEventData DeserializePolicyInsightsPolicyStateDeletedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> timestamp = default;
            Optional<string> policyAssignmentId = default;
            Optional<string> policyDefinitionId = default;
            Optional<string> policyDefinitionReferenceId = default;
            Optional<string> complianceState = default;
            Optional<string> subscriptionId = default;
            Optional<string> complianceReasonCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("policyAssignmentId"u8))
                {
                    policyAssignmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionId"u8))
                {
                    policyDefinitionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDefinitionReferenceId"u8))
                {
                    policyDefinitionReferenceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceState"u8))
                {
                    complianceState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("complianceReasonCode"u8))
                {
                    complianceReasonCode = property.Value.GetString();
                    continue;
                }
            }
            return new PolicyInsightsPolicyStateDeletedEventData(Optional.ToNullable(timestamp), policyAssignmentId.Value, policyDefinitionId.Value, policyDefinitionReferenceId.Value, complianceState.Value, subscriptionId.Value, complianceReasonCode.Value);
        }

        internal partial class PolicyInsightsPolicyStateDeletedEventDataConverter : JsonConverter<PolicyInsightsPolicyStateDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, PolicyInsightsPolicyStateDeletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override PolicyInsightsPolicyStateDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePolicyInsightsPolicyStateDeletedEventData(document.RootElement);
            }
        }
    }
}
