// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LoadTesting.Models
{
    public partial class LoadTestingOutboundEnvironmentEndpoint : IUtf8JsonSerializable, IJsonModel<LoadTestingOutboundEnvironmentEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadTestingOutboundEnvironmentEndpoint>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LoadTestingOutboundEnvironmentEndpoint>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestingOutboundEnvironmentEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadTestingOutboundEnvironmentEndpoint)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Category != null)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category);
            }
            if (options.Format != "W" && !(Endpoints is ChangeTrackingList<LoadTestingEndpointDependency> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("endpoints"u8);
                writer.WriteStartArray();
                foreach (var item in Endpoints)
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

        LoadTestingOutboundEnvironmentEndpoint IJsonModel<LoadTestingOutboundEnvironmentEndpoint>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestingOutboundEnvironmentEndpoint>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadTestingOutboundEnvironmentEndpoint)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadTestingOutboundEnvironmentEndpoint(document.RootElement, options);
        }

        internal static LoadTestingOutboundEnvironmentEndpoint DeserializeLoadTestingOutboundEnvironmentEndpoint(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> category = default;
            IReadOnlyList<LoadTestingEndpointDependency> endpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("category"u8))
                {
                    category = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<LoadTestingEndpointDependency> array = new List<LoadTestingEndpointDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LoadTestingEndpointDependency.DeserializeLoadTestingEndpointDependency(item, options));
                    }
                    endpoints = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LoadTestingOutboundEnvironmentEndpoint(category.Value, endpoints ?? new ChangeTrackingList<LoadTestingEndpointDependency>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LoadTestingOutboundEnvironmentEndpoint>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestingOutboundEnvironmentEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LoadTestingOutboundEnvironmentEndpoint)} does not support '{options.Format}' format.");
            }
        }

        LoadTestingOutboundEnvironmentEndpoint IPersistableModel<LoadTestingOutboundEnvironmentEndpoint>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadTestingOutboundEnvironmentEndpoint>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLoadTestingOutboundEnvironmentEndpoint(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoadTestingOutboundEnvironmentEndpoint)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoadTestingOutboundEnvironmentEndpoint>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
