// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureCoreNetworkFunctionTemplate : IUtf8JsonSerializable, IJsonModel<AzureCoreNetworkFunctionTemplate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureCoreNetworkFunctionTemplate>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureCoreNetworkFunctionTemplate>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureCoreNetworkFunctionTemplate)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(NetworkFunctionApplications is ChangeTrackingList<AzureCoreNetworkFunctionApplication> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("networkFunctionApplications"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkFunctionApplications)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("nfviType"u8);
            writer.WriteStringValue(NfviType.ToString());
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

        AzureCoreNetworkFunctionTemplate IJsonModel<AzureCoreNetworkFunctionTemplate>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureCoreNetworkFunctionTemplate)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureCoreNetworkFunctionTemplate(document.RootElement, options);
        }

        internal static AzureCoreNetworkFunctionTemplate DeserializeAzureCoreNetworkFunctionTemplate(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AzureCoreNetworkFunctionApplication> networkFunctionApplications = default;
            VirtualNetworkFunctionNfviType nfviType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkFunctionApplications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureCoreNetworkFunctionApplication> array = new List<AzureCoreNetworkFunctionApplication>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureCoreNetworkFunctionApplication.DeserializeAzureCoreNetworkFunctionApplication(item, options));
                    }
                    networkFunctionApplications = array;
                    continue;
                }
                if (property.NameEquals("nfviType"u8))
                {
                    nfviType = new VirtualNetworkFunctionNfviType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureCoreNetworkFunctionTemplate(nfviType, serializedAdditionalRawData, networkFunctionApplications ?? new ChangeTrackingList<AzureCoreNetworkFunctionApplication>());
        }

        BinaryData IPersistableModel<AzureCoreNetworkFunctionTemplate>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureCoreNetworkFunctionTemplate)} does not support '{options.Format}' format.");
            }
        }

        AzureCoreNetworkFunctionTemplate IPersistableModel<AzureCoreNetworkFunctionTemplate>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCoreNetworkFunctionTemplate>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureCoreNetworkFunctionTemplate(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureCoreNetworkFunctionTemplate)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureCoreNetworkFunctionTemplate>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
