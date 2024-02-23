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
    public partial class SecurityInsightsThreatIntelligenceIndicatorData : IUtf8JsonSerializable, IJsonModel<SecurityInsightsThreatIntelligenceIndicatorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsThreatIntelligenceIndicatorData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsThreatIntelligenceIndicatorData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsThreatIntelligenceIndicatorData)} does not support '{format}' format.");
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
            if (options.Format != "W" && !(AdditionalData is ChangeTrackingDictionary<string, BinaryData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("additionalData"u8);
                writer.WriteStartObject();
                foreach (var item in AdditionalData)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (options.Format != "W" && FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (!(ThreatIntelligenceTags is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("threatIntelligenceTags"u8);
                writer.WriteStartArray();
                foreach (var item in ThreatIntelligenceTags)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (LastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("lastUpdatedTimeUtc"u8);
                writer.WriteStringValue(LastUpdatedOn.Value, "O");
            }
            if (Source != null)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteStringValue(Source);
            }
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(IndicatorTypes is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("indicatorTypes"u8);
                writer.WriteStartArray();
                foreach (var item in IndicatorTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Pattern != null)
            {
                writer.WritePropertyName("pattern"u8);
                writer.WriteStringValue(Pattern);
            }
            if (PatternType != null)
            {
                writer.WritePropertyName("patternType"u8);
                writer.WriteStringValue(PatternType);
            }
            if (PatternVersion != null)
            {
                writer.WritePropertyName("patternVersion"u8);
                writer.WriteStringValue(PatternVersion);
            }
            if (!(KillChainPhases is ChangeTrackingList<ThreatIntelligenceKillChainPhase> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("killChainPhases"u8);
                writer.WriteStartArray();
                foreach (var item in KillChainPhases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ParsedPattern is ChangeTrackingList<ThreatIntelligenceParsedPattern> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("parsedPattern"u8);
                writer.WriteStartArray();
                foreach (var item in ParsedPattern)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ExternalId != null)
            {
                writer.WritePropertyName("externalId"u8);
                writer.WriteStringValue(ExternalId);
            }
            if (CreatedByRef != null)
            {
                writer.WritePropertyName("createdByRef"u8);
                writer.WriteStringValue(CreatedByRef);
            }
            if (IsDefanged.HasValue)
            {
                writer.WritePropertyName("defanged"u8);
                writer.WriteBooleanValue(IsDefanged.Value);
            }
            if (ExternalLastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("externalLastUpdatedTimeUtc"u8);
                writer.WriteStringValue(ExternalLastUpdatedOn.Value, "O");
            }
            if (!(ExternalReferences is ChangeTrackingList<ThreatIntelligenceExternalReference> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("externalReferences"u8);
                writer.WriteStartArray();
                foreach (var item in ExternalReferences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(GranularMarkings is ChangeTrackingList<ThreatIntelligenceGranularMarkingEntity> collection5 && collection5.IsUndefined))
            {
                writer.WritePropertyName("granularMarkings"u8);
                writer.WriteStartArray();
                foreach (var item in GranularMarkings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Labels is ChangeTrackingList<string> collection6 && collection6.IsUndefined))
            {
                writer.WritePropertyName("labels"u8);
                writer.WriteStartArray();
                foreach (var item in Labels)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (IsRevoked.HasValue)
            {
                writer.WritePropertyName("revoked"u8);
                writer.WriteBooleanValue(IsRevoked.Value);
            }
            if (Confidence.HasValue)
            {
                writer.WritePropertyName("confidence"u8);
                writer.WriteNumberValue(Confidence.Value);
            }
            if (!(ObjectMarkingRefs is ChangeTrackingList<string> collection7 && collection7.IsUndefined))
            {
                writer.WritePropertyName("objectMarkingRefs"u8);
                writer.WriteStartArray();
                foreach (var item in ObjectMarkingRefs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Language != null)
            {
                writer.WritePropertyName("language"u8);
                writer.WriteStringValue(Language);
            }
            if (!(ThreatTypes is ChangeTrackingList<string> collection8 && collection8.IsUndefined))
            {
                writer.WritePropertyName("threatTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ThreatTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (ValidFrom.HasValue)
            {
                writer.WritePropertyName("validFrom"u8);
                writer.WriteStringValue(ValidFrom.Value, "O");
            }
            if (ValidUntil.HasValue)
            {
                writer.WritePropertyName("validUntil"u8);
                writer.WriteStringValue(ValidUntil.Value, "O");
            }
            if (CreatedOn.HasValue)
            {
                writer.WritePropertyName("created"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Modified != null)
            {
                writer.WritePropertyName("modified"u8);
                writer.WriteStringValue(Modified);
            }
            if (!(Extensions is ChangeTrackingDictionary<string, BinaryData> collection9 && collection9.IsUndefined))
            {
                writer.WritePropertyName("extensions"u8);
                writer.WriteStartObject();
                foreach (var item in Extensions)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
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

        SecurityInsightsThreatIntelligenceIndicatorData IJsonModel<SecurityInsightsThreatIntelligenceIndicatorData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsThreatIntelligenceIndicatorData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsThreatIntelligenceIndicatorData(document.RootElement, options);
        }

        internal static SecurityInsightsThreatIntelligenceIndicatorData DeserializeSecurityInsightsThreatIntelligenceIndicatorData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ThreatIntelligenceResourceInnerKind kind = default;
            Optional<ETag> etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalData = default;
            Optional<string> friendlyName = default;
            IList<string> threatIntelligenceTags = default;
            Optional<DateTimeOffset> lastUpdatedTimeUtc = default;
            Optional<string> source = default;
            Optional<string> displayName = default;
            Optional<string> description = default;
            IList<string> indicatorTypes = default;
            Optional<string> pattern = default;
            Optional<string> patternType = default;
            Optional<string> patternVersion = default;
            IList<ThreatIntelligenceKillChainPhase> killChainPhases = default;
            IList<ThreatIntelligenceParsedPattern> parsedPattern = default;
            Optional<string> externalId = default;
            Optional<string> createdByRef = default;
            Optional<bool> defanged = default;
            Optional<DateTimeOffset> externalLastUpdatedTimeUtc = default;
            IList<ThreatIntelligenceExternalReference> externalReferences = default;
            IList<ThreatIntelligenceGranularMarkingEntity> granularMarkings = default;
            IList<string> labels = default;
            Optional<bool> revoked = default;
            Optional<int> confidence = default;
            IList<string> objectMarkingRefs = default;
            Optional<string> language = default;
            IList<string> threatTypes = default;
            Optional<DateTimeOffset> validFrom = default;
            Optional<DateTimeOffset> validUntil = default;
            Optional<DateTimeOffset> created = default;
            Optional<string> modified = default;
            Optional<IDictionary<string, BinaryData>> extensions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new ThreatIntelligenceResourceInnerKind(property.Value.GetString());
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
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("threatIntelligenceTags"u8))
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
                            threatIntelligenceTags = array;
                            continue;
                        }
                        if (property0.NameEquals("lastUpdatedTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdatedTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("indicatorTypes"u8))
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
                            indicatorTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("pattern"u8))
                        {
                            pattern = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("patternType"u8))
                        {
                            patternType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("patternVersion"u8))
                        {
                            patternVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("killChainPhases"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ThreatIntelligenceKillChainPhase> array = new List<ThreatIntelligenceKillChainPhase>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ThreatIntelligenceKillChainPhase.DeserializeThreatIntelligenceKillChainPhase(item, options));
                            }
                            killChainPhases = array;
                            continue;
                        }
                        if (property0.NameEquals("parsedPattern"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ThreatIntelligenceParsedPattern> array = new List<ThreatIntelligenceParsedPattern>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ThreatIntelligenceParsedPattern.DeserializeThreatIntelligenceParsedPattern(item, options));
                            }
                            parsedPattern = array;
                            continue;
                        }
                        if (property0.NameEquals("externalId"u8))
                        {
                            externalId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("createdByRef"u8))
                        {
                            createdByRef = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("defanged"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defanged = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("externalLastUpdatedTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            externalLastUpdatedTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("externalReferences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ThreatIntelligenceExternalReference> array = new List<ThreatIntelligenceExternalReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ThreatIntelligenceExternalReference.DeserializeThreatIntelligenceExternalReference(item, options));
                            }
                            externalReferences = array;
                            continue;
                        }
                        if (property0.NameEquals("granularMarkings"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ThreatIntelligenceGranularMarkingEntity> array = new List<ThreatIntelligenceGranularMarkingEntity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ThreatIntelligenceGranularMarkingEntity.DeserializeThreatIntelligenceGranularMarkingEntity(item, options));
                            }
                            granularMarkings = array;
                            continue;
                        }
                        if (property0.NameEquals("labels"u8))
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
                            labels = array;
                            continue;
                        }
                        if (property0.NameEquals("revoked"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            revoked = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("confidence"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            confidence = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("objectMarkingRefs"u8))
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
                            objectMarkingRefs = array;
                            continue;
                        }
                        if (property0.NameEquals("language"u8))
                        {
                            language = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("threatTypes"u8))
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
                            threatTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("validFrom"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validFrom = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("validUntil"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            validUntil = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("created"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            created = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("modified"u8))
                        {
                            modified = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("extensions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            extensions = dictionary;
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
            return new SecurityInsightsThreatIntelligenceIndicatorData(id, name, type, systemData.Value, kind, Optional.ToNullable(etag), serializedAdditionalRawData, Optional.ToDictionary(additionalData), friendlyName.Value, threatIntelligenceTags ?? new ChangeTrackingList<string>(), Optional.ToNullable(lastUpdatedTimeUtc), source.Value, displayName.Value, description.Value, indicatorTypes ?? new ChangeTrackingList<string>(), pattern.Value, patternType.Value, patternVersion.Value, killChainPhases ?? new ChangeTrackingList<ThreatIntelligenceKillChainPhase>(), parsedPattern ?? new ChangeTrackingList<ThreatIntelligenceParsedPattern>(), externalId.Value, createdByRef.Value, Optional.ToNullable(defanged), Optional.ToNullable(externalLastUpdatedTimeUtc), externalReferences ?? new ChangeTrackingList<ThreatIntelligenceExternalReference>(), granularMarkings ?? new ChangeTrackingList<ThreatIntelligenceGranularMarkingEntity>(), labels ?? new ChangeTrackingList<string>(), Optional.ToNullable(revoked), Optional.ToNullable(confidence), objectMarkingRefs ?? new ChangeTrackingList<string>(), language.Value, threatTypes ?? new ChangeTrackingList<string>(), Optional.ToNullable(validFrom), Optional.ToNullable(validUntil), Optional.ToNullable(created), modified.Value, Optional.ToDictionary(extensions));
        }

        BinaryData IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsThreatIntelligenceIndicatorData)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsThreatIntelligenceIndicatorData IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsThreatIntelligenceIndicatorData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsThreatIntelligenceIndicatorData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsThreatIntelligenceIndicatorData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
