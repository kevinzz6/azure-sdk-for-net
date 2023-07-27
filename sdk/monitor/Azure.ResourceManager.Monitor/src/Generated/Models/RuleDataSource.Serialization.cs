// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class RuleDataSource : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("odata.type"u8);
            writer.WriteStringValue(OdataType);
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceUri"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(LegacyResourceId))
            {
                writer.WritePropertyName("legacyResourceId"u8);
                writer.WriteStringValue(LegacyResourceId);
            }
            if (Optional.IsDefined(ResourceLocation))
            {
                writer.WritePropertyName("resourceLocation"u8);
                writer.WriteStringValue(ResourceLocation);
            }
            if (Optional.IsDefined(MetricNamespace))
            {
                writer.WritePropertyName("metricNamespace"u8);
                writer.WriteStringValue(MetricNamespace);
            }
            writer.WriteEndObject();
        }

        internal static RuleDataSource DeserializeRuleDataSource(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.Azure.Management.Insights.Models.RuleManagementEventDataSource": return RuleManagementEventDataSource.DeserializeRuleManagementEventDataSource(element);
                    case "Microsoft.Azure.Management.Insights.Models.RuleMetricDataSource": return RuleMetricDataSource.DeserializeRuleMetricDataSource(element);
                }
            }
            return UnknownRuleDataSource.DeserializeUnknownRuleDataSource(element);
        }
    }
}
