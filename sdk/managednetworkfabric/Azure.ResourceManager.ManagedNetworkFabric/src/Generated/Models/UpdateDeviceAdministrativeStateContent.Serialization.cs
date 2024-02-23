// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class UpdateDeviceAdministrativeStateContent : IUtf8JsonSerializable, IJsonModel<UpdateDeviceAdministrativeStateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateDeviceAdministrativeStateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UpdateDeviceAdministrativeStateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateDeviceAdministrativeStateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateDeviceAdministrativeStateContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (!(ResourceIds is ChangeTrackingList<ResourceIdentifier> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("resourceIds"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceIds)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
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

        UpdateDeviceAdministrativeStateContent IJsonModel<UpdateDeviceAdministrativeStateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateDeviceAdministrativeStateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateDeviceAdministrativeStateContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateDeviceAdministrativeStateContent(document.RootElement, options);
        }

        internal static UpdateDeviceAdministrativeStateContent DeserializeUpdateDeviceAdministrativeStateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NetworkDeviceAdministrativeState> state = default;
            IList<ResourceIdentifier> resourceIds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new NetworkDeviceAdministrativeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceIds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    resourceIds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UpdateDeviceAdministrativeStateContent(resourceIds ?? new ChangeTrackingList<ResourceIdentifier>(), serializedAdditionalRawData, Optional.ToNullable(state));
        }

        BinaryData IPersistableModel<UpdateDeviceAdministrativeStateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateDeviceAdministrativeStateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpdateDeviceAdministrativeStateContent)} does not support '{options.Format}' format.");
            }
        }

        UpdateDeviceAdministrativeStateContent IPersistableModel<UpdateDeviceAdministrativeStateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateDeviceAdministrativeStateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpdateDeviceAdministrativeStateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateDeviceAdministrativeStateContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateDeviceAdministrativeStateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
