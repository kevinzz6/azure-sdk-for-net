// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class PeriodFeedbackValue : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("periodType"u8);
            writer.WriteStringValue(PeriodType.ToString());
            writer.WritePropertyName("periodValue"u8);
            writer.WriteNumberValue(PeriodValue);
            writer.WriteEndObject();
        }

        internal static PeriodFeedbackValue DeserializePeriodFeedbackValue(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MetricPeriodType periodType = default;
            int periodValue = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("periodType"u8))
                {
                    periodType = new MetricPeriodType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("periodValue"u8))
                {
                    periodValue = property.Value.GetInt32();
                    continue;
                }
            }
            return new PeriodFeedbackValue(periodType, periodValue);
        }
    }
}
