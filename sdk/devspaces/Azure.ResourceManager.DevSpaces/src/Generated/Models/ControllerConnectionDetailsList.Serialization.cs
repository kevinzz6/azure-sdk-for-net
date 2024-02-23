// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevSpaces.Models
{
    public partial class ControllerConnectionDetailsList : IUtf8JsonSerializable, IJsonModel<ControllerConnectionDetailsList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ControllerConnectionDetailsList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ControllerConnectionDetailsList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControllerConnectionDetailsList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ControllerConnectionDetailsList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(ConnectionDetailsList is ChangeTrackingList<ControllerConnectionDetails> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("connectionDetailsList"u8);
                writer.WriteStartArray();
                foreach (var item in ConnectionDetailsList)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        ControllerConnectionDetailsList IJsonModel<ControllerConnectionDetailsList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControllerConnectionDetailsList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ControllerConnectionDetailsList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeControllerConnectionDetailsList(document.RootElement, options);
        }

        internal static ControllerConnectionDetailsList DeserializeControllerConnectionDetailsList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ControllerConnectionDetails> connectionDetailsList = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectionDetailsList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ControllerConnectionDetails> array = new List<ControllerConnectionDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ControllerConnectionDetails.DeserializeControllerConnectionDetails(item, options));
                    }
                    connectionDetailsList = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ControllerConnectionDetailsList(connectionDetailsList ?? new ChangeTrackingList<ControllerConnectionDetails>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ControllerConnectionDetailsList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControllerConnectionDetailsList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ControllerConnectionDetailsList)} does not support '{options.Format}' format.");
            }
        }

        ControllerConnectionDetailsList IPersistableModel<ControllerConnectionDetailsList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ControllerConnectionDetailsList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeControllerConnectionDetailsList(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ControllerConnectionDetailsList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ControllerConnectionDetailsList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
