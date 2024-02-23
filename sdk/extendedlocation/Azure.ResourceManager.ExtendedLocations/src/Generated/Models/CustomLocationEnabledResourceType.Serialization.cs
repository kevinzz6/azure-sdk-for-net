// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ExtendedLocations.Models
{
    public partial class CustomLocationEnabledResourceType : IUtf8JsonSerializable, IJsonModel<CustomLocationEnabledResourceType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomLocationEnabledResourceType>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CustomLocationEnabledResourceType>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationEnabledResourceType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomLocationEnabledResourceType)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (ClusterExtensionId != null)
            {
                writer.WritePropertyName("clusterExtensionId"u8);
                writer.WriteStringValue(ClusterExtensionId);
            }
            if (ExtensionType != null)
            {
                writer.WritePropertyName("extensionType"u8);
                writer.WriteStringValue(ExtensionType);
            }
            if (!(TypesMetadata is ChangeTrackingList<CustomLocationEnabledResourceTypeMetadata> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("typesMetadata"u8);
                writer.WriteStartArray();
                foreach (var item in TypesMetadata)
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

        CustomLocationEnabledResourceType IJsonModel<CustomLocationEnabledResourceType>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationEnabledResourceType>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CustomLocationEnabledResourceType)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomLocationEnabledResourceType(document.RootElement, options);
        }

        internal static CustomLocationEnabledResourceType DeserializeCustomLocationEnabledResourceType(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceIdentifier> clusterExtensionId = default;
            Optional<string> extensionType = default;
            IList<CustomLocationEnabledResourceTypeMetadata> typesMetadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("clusterExtensionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterExtensionId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("extensionType"u8))
                        {
                            extensionType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("typesMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CustomLocationEnabledResourceTypeMetadata> array = new List<CustomLocationEnabledResourceTypeMetadata>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(CustomLocationEnabledResourceTypeMetadata.DeserializeCustomLocationEnabledResourceTypeMetadata(item, options));
                            }
                            typesMetadata = array;
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
            return new CustomLocationEnabledResourceType(id, name, type, systemData.Value, clusterExtensionId.Value, extensionType.Value, typesMetadata ?? new ChangeTrackingList<CustomLocationEnabledResourceTypeMetadata>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CustomLocationEnabledResourceType>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationEnabledResourceType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CustomLocationEnabledResourceType)} does not support '{options.Format}' format.");
            }
        }

        CustomLocationEnabledResourceType IPersistableModel<CustomLocationEnabledResourceType>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CustomLocationEnabledResourceType>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCustomLocationEnabledResourceType(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CustomLocationEnabledResourceType)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CustomLocationEnabledResourceType>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
