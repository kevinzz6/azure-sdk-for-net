// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    public partial class ScalingPlanPatch : IUtf8JsonSerializable, IJsonModel<ScalingPlanPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ScalingPlanPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ScalingPlanPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScalingPlanPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (FriendlyName != null)
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (TimeZone != null)
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
            }
            if (ExclusionTag != null)
            {
                writer.WritePropertyName("exclusionTag"u8);
                writer.WriteStringValue(ExclusionTag);
            }
            if (!(Schedules is ChangeTrackingList<ScalingSchedule> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("schedules"u8);
                writer.WriteStartArray();
                foreach (var item in Schedules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(HostPoolReferences is ChangeTrackingList<ScalingHostPoolReference> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("hostPoolReferences"u8);
                writer.WriteStartArray();
                foreach (var item in HostPoolReferences)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ScalingPlanPatch IJsonModel<ScalingPlanPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ScalingPlanPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeScalingPlanPatch(document.RootElement, options);
        }

        internal static ScalingPlanPatch DeserializeScalingPlanPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> description = default;
            Optional<string> friendlyName = default;
            Optional<string> timeZone = default;
            Optional<string> exclusionTag = default;
            IList<ScalingSchedule> schedules = default;
            IList<ScalingHostPoolReference> hostPoolReferences = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("timeZone"u8))
                        {
                            timeZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("exclusionTag"u8))
                        {
                            exclusionTag = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("schedules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ScalingSchedule> array = new List<ScalingSchedule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ScalingSchedule.DeserializeScalingSchedule(item, options));
                            }
                            schedules = array;
                            continue;
                        }
                        if (property0.NameEquals("hostPoolReferences"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ScalingHostPoolReference> array = new List<ScalingHostPoolReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ScalingHostPoolReference.DeserializeScalingHostPoolReference(item, options));
                            }
                            hostPoolReferences = array;
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
            return new ScalingPlanPatch(Optional.ToDictionary(tags), description.Value, friendlyName.Value, timeZone.Value, exclusionTag.Value, schedules ?? new ChangeTrackingList<ScalingSchedule>(), hostPoolReferences ?? new ChangeTrackingList<ScalingHostPoolReference>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ScalingPlanPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ScalingPlanPatch)} does not support '{options.Format}' format.");
            }
        }

        ScalingPlanPatch IPersistableModel<ScalingPlanPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ScalingPlanPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeScalingPlanPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ScalingPlanPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ScalingPlanPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
