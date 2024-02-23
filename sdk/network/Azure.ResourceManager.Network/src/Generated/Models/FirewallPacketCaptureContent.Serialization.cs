// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class FirewallPacketCaptureContent : IUtf8JsonSerializable, IJsonModel<FirewallPacketCaptureContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FirewallPacketCaptureContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FirewallPacketCaptureContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPacketCaptureContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPacketCaptureContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (DurationInSeconds.HasValue)
            {
                writer.WritePropertyName("durationInSeconds"u8);
                writer.WriteNumberValue(DurationInSeconds.Value);
            }
            if (NumberOfPacketsToCapture.HasValue)
            {
                writer.WritePropertyName("numberOfPacketsToCapture"u8);
                writer.WriteNumberValue(NumberOfPacketsToCapture.Value);
            }
            if (SasUri != null)
            {
                writer.WritePropertyName("sasUrl"u8);
                writer.WriteStringValue(SasUri.AbsoluteUri);
            }
            if (FileName != null)
            {
                writer.WritePropertyName("fileName"u8);
                writer.WriteStringValue(FileName);
            }
            if (Protocol.HasValue)
            {
                writer.WritePropertyName("protocol"u8);
                writer.WriteStringValue(Protocol.Value.ToString());
            }
            if (!(Flags is ChangeTrackingList<AzureFirewallPacketCaptureFlags> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("flags"u8);
                writer.WriteStartArray();
                foreach (var item in Flags)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Filters is ChangeTrackingList<AzureFirewallPacketCaptureRule> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("filters"u8);
                writer.WriteStartArray();
                foreach (var item in Filters)
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

        FirewallPacketCaptureContent IJsonModel<FirewallPacketCaptureContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPacketCaptureContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FirewallPacketCaptureContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFirewallPacketCaptureContent(document.RootElement, options);
        }

        internal static FirewallPacketCaptureContent DeserializeFirewallPacketCaptureContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<int> durationInSeconds = default;
            Optional<int> numberOfPacketsToCapture = default;
            Optional<Uri> sasUrl = default;
            Optional<string> fileName = default;
            Optional<AzureFirewallNetworkRuleProtocol> protocol = default;
            IList<AzureFirewallPacketCaptureFlags> flags = default;
            IList<AzureFirewallPacketCaptureRule> filters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
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
                        if (property0.NameEquals("durationInSeconds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            durationInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("numberOfPacketsToCapture"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfPacketsToCapture = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("sasUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sasUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("fileName"u8))
                        {
                            fileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("protocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            protocol = new AzureFirewallNetworkRuleProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("flags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureFirewallPacketCaptureFlags> array = new List<AzureFirewallPacketCaptureFlags>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallPacketCaptureFlags.DeserializeAzureFirewallPacketCaptureFlags(item, options));
                            }
                            flags = array;
                            continue;
                        }
                        if (property0.NameEquals("filters"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AzureFirewallPacketCaptureRule> array = new List<AzureFirewallPacketCaptureRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AzureFirewallPacketCaptureRule.DeserializeAzureFirewallPacketCaptureRule(item, options));
                            }
                            filters = array;
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
            return new FirewallPacketCaptureContent(id.Value, serializedAdditionalRawData, Optional.ToNullable(durationInSeconds), Optional.ToNullable(numberOfPacketsToCapture), sasUrl.Value, fileName.Value, Optional.ToNullable(protocol), flags ?? new ChangeTrackingList<AzureFirewallPacketCaptureFlags>(), filters ?? new ChangeTrackingList<AzureFirewallPacketCaptureRule>());
        }

        BinaryData IPersistableModel<FirewallPacketCaptureContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPacketCaptureContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FirewallPacketCaptureContent)} does not support '{options.Format}' format.");
            }
        }

        FirewallPacketCaptureContent IPersistableModel<FirewallPacketCaptureContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FirewallPacketCaptureContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFirewallPacketCaptureContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FirewallPacketCaptureContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FirewallPacketCaptureContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
