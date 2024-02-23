// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsScheduledAlertRule : IUtf8JsonSerializable, IJsonModel<SecurityInsightsScheduledAlertRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsScheduledAlertRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsScheduledAlertRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsScheduledAlertRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsScheduledAlertRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Query != null)
            {
                writer.WritePropertyName("query"u8);
                writer.WriteStringValue(Query);
            }
            if (QueryFrequency.HasValue)
            {
                writer.WritePropertyName("queryFrequency"u8);
                writer.WriteStringValue(QueryFrequency.Value, "P");
            }
            if (QueryPeriod.HasValue)
            {
                writer.WritePropertyName("queryPeriod"u8);
                writer.WriteStringValue(QueryPeriod.Value, "P");
            }
            if (Severity.HasValue)
            {
                writer.WritePropertyName("severity"u8);
                writer.WriteStringValue(Severity.Value.ToString());
            }
            if (TriggerOperator.HasValue)
            {
                writer.WritePropertyName("triggerOperator"u8);
                writer.WriteStringValue(TriggerOperator.Value.ToSerialString());
            }
            if (TriggerThreshold.HasValue)
            {
                writer.WritePropertyName("triggerThreshold"u8);
                writer.WriteNumberValue(TriggerThreshold.Value);
            }
            if (EventGroupingSettings != null)
            {
                writer.WritePropertyName("eventGroupingSettings"u8);
                writer.WriteObjectValue(EventGroupingSettings);
            }
            if (!(CustomDetails is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("customDetails"u8);
                writer.WriteStartObject();
                foreach (var item in CustomDetails)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(EntityMappings is ChangeTrackingList<SecurityInsightsAlertRuleEntityMapping> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("entityMappings"u8);
                writer.WriteStartArray();
                foreach (var item in EntityMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AlertDetailsOverride != null)
            {
                writer.WritePropertyName("alertDetailsOverride"u8);
                writer.WriteObjectValue(AlertDetailsOverride);
            }
            if (AlertRuleTemplateName != null)
            {
                writer.WritePropertyName("alertRuleTemplateName"u8);
                writer.WriteStringValue(AlertRuleTemplateName);
            }
            if (TemplateVersion != null)
            {
                writer.WritePropertyName("templateVersion"u8);
                writer.WriteStringValue(TemplateVersion);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (options.Format != "W" && LastModifiedOn.HasValue)
            {
                writer.WritePropertyName("lastModifiedUtc"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (SuppressionDuration.HasValue)
            {
                writer.WritePropertyName("suppressionDuration"u8);
                writer.WriteStringValue(SuppressionDuration.Value, "P");
            }
            if (IsSuppressionEnabled.HasValue)
            {
                writer.WritePropertyName("suppressionEnabled"u8);
                writer.WriteBooleanValue(IsSuppressionEnabled.Value);
            }
            if (!(Tactics is ChangeTrackingList<SecurityInsightsAttackTactic> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("tactics"u8);
                writer.WriteStartArray();
                foreach (var item in Tactics)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (!(Techniques is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("techniques"u8);
                writer.WriteStartArray();
                foreach (var item in Techniques)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IncidentConfiguration != null)
            {
                writer.WritePropertyName("incidentConfiguration"u8);
                writer.WriteObjectValue(IncidentConfiguration);
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        SecurityInsightsScheduledAlertRule IJsonModel<SecurityInsightsScheduledAlertRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsScheduledAlertRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsScheduledAlertRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsScheduledAlertRule(document.RootElement, options);
        }

        internal static SecurityInsightsScheduledAlertRule DeserializeSecurityInsightsScheduledAlertRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AlertRuleKind kind = default;
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> query = default;
            Optional<TimeSpan> queryFrequency = default;
            Optional<TimeSpan> queryPeriod = default;
            Optional<SecurityInsightsAlertSeverity> severity = default;
            Optional<SecurityInsightsAlertRuleTriggerOperator> triggerOperator = default;
            Optional<int> triggerThreshold = default;
            Optional<EventGroupingSettings> eventGroupingSettings = default;
            Optional<IDictionary<string, string>> customDetails = default;
            IList<SecurityInsightsAlertRuleEntityMapping> entityMappings = default;
            Optional<SecurityInsightsAlertDetailsOverride> alertDetailsOverride = default;
            Optional<string> alertRuleTemplateName = default;
            Optional<string> templateVersion = default;
            Optional<string> description = default;
            Optional<string> displayName = default;
            Optional<bool> enabled = default;
            Optional<DateTimeOffset> lastModifiedUtc = default;
            Optional<TimeSpan> suppressionDuration = default;
            Optional<bool> suppressionEnabled = default;
            IList<SecurityInsightsAttackTactic> tactics = default;
            IList<string> techniques = default;
            Optional<SecurityInsightsIncidentConfiguration> incidentConfiguration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new AlertRuleKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("query"u8))
                        {
                            query = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queryFrequency"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryFrequency = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("queryPeriod"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryPeriod = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("severity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            severity = new SecurityInsightsAlertSeverity(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("triggerOperator"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            triggerOperator = property0.Value.GetString().ToSecurityInsightsAlertRuleTriggerOperator();
                            continue;
                        }
                        if (property0.NameEquals("triggerThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            triggerThreshold = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("eventGroupingSettings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            eventGroupingSettings = EventGroupingSettings.DeserializeEventGroupingSettings(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("customDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            customDetails = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("entityMappings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAlertRuleEntityMapping> array = new List<SecurityInsightsAlertRuleEntityMapping>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(SecurityInsightsAlertRuleEntityMapping.DeserializeSecurityInsightsAlertRuleEntityMapping(item, options));
                            }
                            entityMappings = array;
                            continue;
                        }
                        if (property0.NameEquals("alertDetailsOverride"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alertDetailsOverride = SecurityInsightsAlertDetailsOverride.DeserializeSecurityInsightsAlertDetailsOverride(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("alertRuleTemplateName"u8))
                        {
                            alertRuleTemplateName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("templateVersion"u8))
                        {
                            templateVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("enabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("suppressionDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suppressionDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("suppressionEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            suppressionEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("tactics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<SecurityInsightsAttackTactic> array = new List<SecurityInsightsAttackTactic>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new SecurityInsightsAttackTactic(item.GetString()));
                            }
                            tactics = array;
                            continue;
                        }
                        if (property0.NameEquals("techniques"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            techniques = array;
                            continue;
                        }
                        if (property0.NameEquals("incidentConfiguration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            incidentConfiguration = SecurityInsightsIncidentConfiguration.DeserializeSecurityInsightsIncidentConfiguration(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsScheduledAlertRule(id, name, type, systemData.Value, kind, Optional.ToNullable(etag), serializedAdditionalRawData, query.Value, Optional.ToNullable(queryFrequency), Optional.ToNullable(queryPeriod), Optional.ToNullable(severity), Optional.ToNullable(triggerOperator), Optional.ToNullable(triggerThreshold), eventGroupingSettings.Value, Optional.ToDictionary(customDetails), entityMappings ?? new ChangeTrackingList<SecurityInsightsAlertRuleEntityMapping>(), alertDetailsOverride.Value, alertRuleTemplateName.Value, templateVersion.Value, description.Value, displayName.Value, Optional.ToNullable(enabled), Optional.ToNullable(lastModifiedUtc), Optional.ToNullable(suppressionDuration), Optional.ToNullable(suppressionEnabled), tactics ?? new ChangeTrackingList<SecurityInsightsAttackTactic>(), techniques ?? new ChangeTrackingList<string>(), incidentConfiguration.Value);
        }

        BinaryData IPersistableModel<SecurityInsightsScheduledAlertRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsScheduledAlertRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsScheduledAlertRule)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsScheduledAlertRule IPersistableModel<SecurityInsightsScheduledAlertRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsScheduledAlertRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsScheduledAlertRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsScheduledAlertRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsScheduledAlertRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
