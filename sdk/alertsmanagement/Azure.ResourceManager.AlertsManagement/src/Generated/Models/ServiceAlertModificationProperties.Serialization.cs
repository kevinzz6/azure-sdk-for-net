// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertModificationProperties : IUtf8JsonSerializable, IJsonModel<ServiceAlertModificationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceAlertModificationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceAlertModificationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertModificationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAlertModificationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && AlertId.HasValue)
            {
                writer.WritePropertyName("alertId"u8);
                writer.WriteStringValue(AlertId.Value);
            }
            if (!(Modifications is ChangeTrackingList<ServiceAlertModificationItemInfo> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("modifications"u8);
                writer.WriteStartArray();
                foreach (var item in Modifications)
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

        ServiceAlertModificationProperties IJsonModel<ServiceAlertModificationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertModificationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceAlertModificationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAlertModificationProperties(document.RootElement, options);
        }

        internal static ServiceAlertModificationProperties DeserializeServiceAlertModificationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> alertId = default;
            IList<ServiceAlertModificationItemInfo> modifications = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("modifications"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ServiceAlertModificationItemInfo> array = new List<ServiceAlertModificationItemInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServiceAlertModificationItemInfo.DeserializeServiceAlertModificationItemInfo(item, options));
                    }
                    modifications = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceAlertModificationProperties(Optional.ToNullable(alertId), modifications ?? new ChangeTrackingList<ServiceAlertModificationItemInfo>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceAlertModificationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertModificationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceAlertModificationProperties)} does not support '{options.Format}' format.");
            }
        }

        ServiceAlertModificationProperties IPersistableModel<ServiceAlertModificationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceAlertModificationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceAlertModificationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceAlertModificationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceAlertModificationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
