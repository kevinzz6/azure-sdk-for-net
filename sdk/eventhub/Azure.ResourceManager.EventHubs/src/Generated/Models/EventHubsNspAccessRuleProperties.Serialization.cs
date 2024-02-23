// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsNspAccessRuleProperties : IUtf8JsonSerializable, IJsonModel<EventHubsNspAccessRuleProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EventHubsNspAccessRuleProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<EventHubsNspAccessRuleProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsNspAccessRuleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsNspAccessRuleProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Direction.HasValue)
            {
                writer.WritePropertyName("direction"u8);
                writer.WriteStringValue(Direction.Value.ToString());
            }
            if (!(AddressPrefixes is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("addressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Subscriptions is ChangeTrackingList<SubResource> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("subscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    JsonSerializer.Serialize(writer, item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(NetworkSecurityPerimeters is ChangeTrackingList<EventHubsNetworkSecurityPerimeter> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("networkSecurityPerimeters"u8);
                writer.WriteStartArray();
                foreach (var item in NetworkSecurityPerimeters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(FullyQualifiedDomainNames is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("fullyQualifiedDomainNames"u8);
                writer.WriteStartArray();
                foreach (var item in FullyQualifiedDomainNames)
                {
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

        EventHubsNspAccessRuleProperties IJsonModel<EventHubsNspAccessRuleProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsNspAccessRuleProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EventHubsNspAccessRuleProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEventHubsNspAccessRuleProperties(document.RootElement, options);
        }

        internal static EventHubsNspAccessRuleProperties DeserializeEventHubsNspAccessRuleProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EventHubsNspAccessRuleDirection> direction = default;
            IReadOnlyList<string> addressPrefixes = default;
            IReadOnlyList<SubResource> subscriptions = default;
            IReadOnlyList<EventHubsNetworkSecurityPerimeter> networkSecurityPerimeters = default;
            IReadOnlyList<string> fullyQualifiedDomainNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("direction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    direction = new EventHubsNspAccessRuleDirection(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("addressPrefixes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    addressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("subscriptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SubResource> array = new List<SubResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JsonSerializer.Deserialize<SubResource>(item.GetRawText()));
                    }
                    subscriptions = array;
                    continue;
                }
                if (property.NameEquals("networkSecurityPerimeters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<EventHubsNetworkSecurityPerimeter> array = new List<EventHubsNetworkSecurityPerimeter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EventHubsNetworkSecurityPerimeter.DeserializeEventHubsNetworkSecurityPerimeter(item, options));
                    }
                    networkSecurityPerimeters = array;
                    continue;
                }
                if (property.NameEquals("fullyQualifiedDomainNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    fullyQualifiedDomainNames = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new EventHubsNspAccessRuleProperties(Optional.ToNullable(direction), addressPrefixes ?? new ChangeTrackingList<string>(), subscriptions ?? new ChangeTrackingList<SubResource>(), networkSecurityPerimeters ?? new ChangeTrackingList<EventHubsNetworkSecurityPerimeter>(), fullyQualifiedDomainNames ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EventHubsNspAccessRuleProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsNspAccessRuleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EventHubsNspAccessRuleProperties)} does not support '{options.Format}' format.");
            }
        }

        EventHubsNspAccessRuleProperties IPersistableModel<EventHubsNspAccessRuleProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EventHubsNspAccessRuleProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEventHubsNspAccessRuleProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EventHubsNspAccessRuleProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<EventHubsNspAccessRuleProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
