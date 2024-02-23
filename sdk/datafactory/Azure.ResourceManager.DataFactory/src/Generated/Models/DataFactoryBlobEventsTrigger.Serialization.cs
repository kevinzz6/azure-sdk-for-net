// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryBlobEventsTrigger : IUtf8JsonSerializable, IJsonModel<DataFactoryBlobEventsTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryBlobEventsTrigger>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryBlobEventsTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryBlobEventsTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryBlobEventsTrigger)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Pipelines is ChangeTrackingList<TriggerPipelineReference> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("pipelines"u8);
                writer.WriteStartArray();
                foreach (var item in Pipelines)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(TriggerType);
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && RuntimeState.HasValue)
            {
                writer.WritePropertyName("runtimeState"u8);
                writer.WriteStringValue(RuntimeState.Value.ToString());
            }
            if (!(Annotations is ChangeTrackingList<BinaryData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (BlobPathBeginsWith != null)
            {
                writer.WritePropertyName("blobPathBeginsWith"u8);
                writer.WriteStringValue(BlobPathBeginsWith);
            }
            if (BlobPathEndsWith != null)
            {
                writer.WritePropertyName("blobPathEndsWith"u8);
                writer.WriteStringValue(BlobPathEndsWith);
            }
            if (IgnoreEmptyBlobs.HasValue)
            {
                writer.WritePropertyName("ignoreEmptyBlobs"u8);
                writer.WriteBooleanValue(IgnoreEmptyBlobs.Value);
            }
            writer.WritePropertyName("events"u8);
            writer.WriteStartArray();
            foreach (var item in Events)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("scope"u8);
            writer.WriteStringValue(Scope);
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DataFactoryBlobEventsTrigger IJsonModel<DataFactoryBlobEventsTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryBlobEventsTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryBlobEventsTrigger)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryBlobEventsTrigger(document.RootElement, options);
        }

        internal static DataFactoryBlobEventsTrigger DeserializeDataFactoryBlobEventsTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<TriggerPipelineReference> pipelines = default;
            string type = default;
            Optional<string> description = default;
            Optional<DataFactoryTriggerRuntimeState> runtimeState = default;
            IList<BinaryData> annotations = default;
            Optional<string> blobPathBeginsWith = default;
            Optional<string> blobPathEndsWith = default;
            Optional<bool> ignoreEmptyBlobs = default;
            IList<DataFactoryBlobEventType> events = default;
            string scope = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelines"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TriggerPipelineReference> array = new List<TriggerPipelineReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TriggerPipelineReference.DeserializeTriggerPipelineReference(item, options));
                    }
                    pipelines = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runtimeState = new DataFactoryTriggerRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("blobPathBeginsWith"u8))
                        {
                            blobPathBeginsWith = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("blobPathEndsWith"u8))
                        {
                            blobPathEndsWith = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ignoreEmptyBlobs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            ignoreEmptyBlobs = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("events"u8))
                        {
                            List<DataFactoryBlobEventType> array = new List<DataFactoryBlobEventType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new DataFactoryBlobEventType(item.GetString()));
                            }
                            events = array;
                            continue;
                        }
                        if (property0.NameEquals("scope"u8))
                        {
                            scope = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryBlobEventsTrigger(type, description.Value, Optional.ToNullable(runtimeState), annotations ?? new ChangeTrackingList<BinaryData>(), additionalProperties, pipelines ?? new ChangeTrackingList<TriggerPipelineReference>(), blobPathBeginsWith.Value, blobPathEndsWith.Value, Optional.ToNullable(ignoreEmptyBlobs), events, scope);
        }

        BinaryData IPersistableModel<DataFactoryBlobEventsTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryBlobEventsTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryBlobEventsTrigger)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryBlobEventsTrigger IPersistableModel<DataFactoryBlobEventsTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryBlobEventsTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryBlobEventsTrigger(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryBlobEventsTrigger)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryBlobEventsTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
