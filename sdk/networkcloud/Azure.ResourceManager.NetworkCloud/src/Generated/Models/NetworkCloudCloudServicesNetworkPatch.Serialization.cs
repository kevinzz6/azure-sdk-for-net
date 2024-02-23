// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkCloudCloudServicesNetworkPatch : IUtf8JsonSerializable, IJsonModel<NetworkCloudCloudServicesNetworkPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudCloudServicesNetworkPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkCloudCloudServicesNetworkPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudCloudServicesNetworkPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudCloudServicesNetworkPatch)} does not support '{format}' format.");
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
            if (!(AdditionalEgressEndpoints is ChangeTrackingList<EgressEndpoint> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("additionalEgressEndpoints"u8);
                writer.WriteStartArray();
                foreach (var item in AdditionalEgressEndpoints)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (EnableDefaultEgressEndpoints.HasValue)
            {
                writer.WritePropertyName("enableDefaultEgressEndpoints"u8);
                writer.WriteStringValue(EnableDefaultEgressEndpoints.Value.ToString());
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

        NetworkCloudCloudServicesNetworkPatch IJsonModel<NetworkCloudCloudServicesNetworkPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudCloudServicesNetworkPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudCloudServicesNetworkPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudCloudServicesNetworkPatch(document.RootElement, options);
        }

        internal static NetworkCloudCloudServicesNetworkPatch DeserializeNetworkCloudCloudServicesNetworkPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            IList<EgressEndpoint> additionalEgressEndpoints = default;
            Optional<CloudServicesNetworkEnableDefaultEgressEndpoint> enableDefaultEgressEndpoints = default;
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
                        if (property0.NameEquals("additionalEgressEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<EgressEndpoint> array = new List<EgressEndpoint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(EgressEndpoint.DeserializeEgressEndpoint(item, options));
                            }
                            additionalEgressEndpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("enableDefaultEgressEndpoints"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDefaultEgressEndpoints = new CloudServicesNetworkEnableDefaultEgressEndpoint(property0.Value.GetString());
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
            return new NetworkCloudCloudServicesNetworkPatch(Optional.ToDictionary(tags), additionalEgressEndpoints ?? new ChangeTrackingList<EgressEndpoint>(), Optional.ToNullable(enableDefaultEgressEndpoints), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudCloudServicesNetworkPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudCloudServicesNetworkPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudCloudServicesNetworkPatch)} does not support '{options.Format}' format.");
            }
        }

        NetworkCloudCloudServicesNetworkPatch IPersistableModel<NetworkCloudCloudServicesNetworkPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudCloudServicesNetworkPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkCloudCloudServicesNetworkPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudCloudServicesNetworkPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudCloudServicesNetworkPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
