// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.IotHub.Models
{
    public partial class RoutingEndpoints : IUtf8JsonSerializable, IJsonModel<RoutingEndpoints>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoutingEndpoints>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RoutingEndpoints>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingEndpoints)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(ServiceBusQueues is ChangeTrackingList<RoutingServiceBusQueueEndpointProperties> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("serviceBusQueues"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceBusQueues)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ServiceBusTopics is ChangeTrackingList<RoutingServiceBusTopicEndpointProperties> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("serviceBusTopics"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceBusTopics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(EventHubs is ChangeTrackingList<RoutingEventHubProperties> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("eventHubs"u8);
                writer.WriteStartArray();
                foreach (var item in EventHubs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(StorageContainers is ChangeTrackingList<RoutingStorageContainerProperties> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("storageContainers"u8);
                writer.WriteStartArray();
                foreach (var item in StorageContainers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(CosmosDBSqlContainers is ChangeTrackingList<RoutingCosmosDBSqlApiProperties> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("cosmosDBSqlContainers"u8);
                writer.WriteStartArray();
                foreach (var item in CosmosDBSqlContainers)
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

        RoutingEndpoints IJsonModel<RoutingEndpoints>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingEndpoints>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RoutingEndpoints)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoutingEndpoints(document.RootElement, options);
        }

        internal static RoutingEndpoints DeserializeRoutingEndpoints(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<RoutingServiceBusQueueEndpointProperties> serviceBusQueues = default;
            IList<RoutingServiceBusTopicEndpointProperties> serviceBusTopics = default;
            IList<RoutingEventHubProperties> eventHubs = default;
            IList<RoutingStorageContainerProperties> storageContainers = default;
            IList<RoutingCosmosDBSqlApiProperties> cosmosDBSqlContainers = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceBusQueues"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingServiceBusQueueEndpointProperties> array = new List<RoutingServiceBusQueueEndpointProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingServiceBusQueueEndpointProperties.DeserializeRoutingServiceBusQueueEndpointProperties(item, options));
                    }
                    serviceBusQueues = array;
                    continue;
                }
                if (property.NameEquals("serviceBusTopics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingServiceBusTopicEndpointProperties> array = new List<RoutingServiceBusTopicEndpointProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingServiceBusTopicEndpointProperties.DeserializeRoutingServiceBusTopicEndpointProperties(item, options));
                    }
                    serviceBusTopics = array;
                    continue;
                }
                if (property.NameEquals("eventHubs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingEventHubProperties> array = new List<RoutingEventHubProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingEventHubProperties.DeserializeRoutingEventHubProperties(item, options));
                    }
                    eventHubs = array;
                    continue;
                }
                if (property.NameEquals("storageContainers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingStorageContainerProperties> array = new List<RoutingStorageContainerProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingStorageContainerProperties.DeserializeRoutingStorageContainerProperties(item, options));
                    }
                    storageContainers = array;
                    continue;
                }
                if (property.NameEquals("cosmosDBSqlContainers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RoutingCosmosDBSqlApiProperties> array = new List<RoutingCosmosDBSqlApiProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RoutingCosmosDBSqlApiProperties.DeserializeRoutingCosmosDBSqlApiProperties(item, options));
                    }
                    cosmosDBSqlContainers = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RoutingEndpoints(serviceBusQueues ?? new ChangeTrackingList<RoutingServiceBusQueueEndpointProperties>(), serviceBusTopics ?? new ChangeTrackingList<RoutingServiceBusTopicEndpointProperties>(), eventHubs ?? new ChangeTrackingList<RoutingEventHubProperties>(), storageContainers ?? new ChangeTrackingList<RoutingStorageContainerProperties>(), cosmosDBSqlContainers ?? new ChangeTrackingList<RoutingCosmosDBSqlApiProperties>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoutingEndpoints>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RoutingEndpoints)} does not support '{options.Format}' format.");
            }
        }

        RoutingEndpoints IPersistableModel<RoutingEndpoints>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RoutingEndpoints>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRoutingEndpoints(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RoutingEndpoints)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RoutingEndpoints>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
