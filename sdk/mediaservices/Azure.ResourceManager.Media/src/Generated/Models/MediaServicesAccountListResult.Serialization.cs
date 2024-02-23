// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Media;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class MediaServicesAccountListResult : IUtf8JsonSerializable, IJsonModel<MediaServicesAccountListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MediaServicesAccountListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MediaServicesAccountListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaServicesAccountListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaServicesAccountListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Value is ChangeTrackingList<MediaServicesAccountData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OdataNextLink != null)
            {
                writer.WritePropertyName("@odata.nextLink"u8);
                writer.WriteStringValue(OdataNextLink);
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

        MediaServicesAccountListResult IJsonModel<MediaServicesAccountListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaServicesAccountListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MediaServicesAccountListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMediaServicesAccountListResult(document.RootElement, options);
        }

        internal static MediaServicesAccountListResult DeserializeMediaServicesAccountListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<MediaServicesAccountData> value = default;
            Optional<string> odataNextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MediaServicesAccountData> array = new List<MediaServicesAccountData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaServicesAccountData.DeserializeMediaServicesAccountData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("@odata.nextLink"u8))
                {
                    odataNextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MediaServicesAccountListResult(value ?? new ChangeTrackingList<MediaServicesAccountData>(), odataNextLink.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MediaServicesAccountListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaServicesAccountListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MediaServicesAccountListResult)} does not support '{options.Format}' format.");
            }
        }

        MediaServicesAccountListResult IPersistableModel<MediaServicesAccountListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MediaServicesAccountListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMediaServicesAccountListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MediaServicesAccountListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MediaServicesAccountListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
