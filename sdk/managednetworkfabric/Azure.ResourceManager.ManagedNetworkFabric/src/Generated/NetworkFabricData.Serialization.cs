// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    public partial class NetworkFabricData : IUtf8JsonSerializable, IJsonModel<NetworkFabricData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkFabricData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkFabricData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFabricData)} does not support '{format}' format.");
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
            writer.WritePropertyName("location"u8);
            writer.WriteStringValue(Location);
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Annotation != null)
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            writer.WritePropertyName("networkFabricSku"u8);
            writer.WriteStringValue(NetworkFabricSku);
            if (options.Format != "W" && FabricVersion != null)
            {
                writer.WritePropertyName("fabricVersion"u8);
                writer.WriteStringValue(FabricVersion);
            }
            if (options.Format != "W" && !(RouterIds is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("routerIds"u8);
                writer.WriteStartArray();
                foreach (var item in RouterIds)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("networkFabricControllerId"u8);
            writer.WriteStringValue(NetworkFabricControllerId);
            if (RackCount.HasValue)
            {
                writer.WritePropertyName("rackCount"u8);
                writer.WriteNumberValue(RackCount.Value);
            }
            writer.WritePropertyName("serverCountPerRack"u8);
            writer.WriteNumberValue(ServerCountPerRack);
            writer.WritePropertyName("ipv4Prefix"u8);
            writer.WriteStringValue(IPv4Prefix);
            if (IPv6Prefix != null)
            {
                writer.WritePropertyName("ipv6Prefix"u8);
                writer.WriteStringValue(IPv6Prefix);
            }
            writer.WritePropertyName("fabricASN"u8);
            writer.WriteNumberValue(FabricAsn);
            writer.WritePropertyName("terminalServerConfiguration"u8);
            writer.WriteObjectValue(TerminalServerConfiguration);
            writer.WritePropertyName("managementNetworkConfiguration"u8);
            writer.WriteObjectValue(ManagementNetworkConfiguration);
            if (options.Format != "W" && !(Racks is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("racks"u8);
                writer.WriteStartArray();
                foreach (var item in Racks)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(L2IsolationDomains is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("l2IsolationDomains"u8);
                writer.WriteStartArray();
                foreach (var item in L2IsolationDomains)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(L3IsolationDomains is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("l3IsolationDomains"u8);
                writer.WriteStartArray();
                foreach (var item in L3IsolationDomains)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ConfigurationState.HasValue)
            {
                writer.WritePropertyName("configurationState"u8);
                writer.WriteStringValue(ConfigurationState.Value.ToString());
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && AdministrativeState.HasValue)
            {
                writer.WritePropertyName("administrativeState"u8);
                writer.WriteStringValue(AdministrativeState.Value.ToString());
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

        NetworkFabricData IJsonModel<NetworkFabricData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkFabricData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkFabricData(document.RootElement, options);
        }

        internal static NetworkFabricData DeserializeNetworkFabricData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> annotation = default;
            string networkFabricSku = default;
            Optional<string> fabricVersion = default;
            IReadOnlyList<string> routerIds = default;
            ResourceIdentifier networkFabricControllerId = default;
            Optional<int> rackCount = default;
            int serverCountPerRack = default;
            string ipv4Prefix = default;
            Optional<string> ipv6Prefix = default;
            long fabricAsn = default;
            TerminalServerConfiguration terminalServerConfiguration = default;
            ManagementNetworkConfigurationProperties managementNetworkConfiguration = default;
            IReadOnlyList<string> racks = default;
            IReadOnlyList<string> l2IsolationDomains = default;
            IReadOnlyList<string> l3IsolationDomains = default;
            Optional<NetworkFabricConfigurationState> configurationState = default;
            Optional<NetworkFabricProvisioningState> provisioningState = default;
            Optional<NetworkFabricAdministrativeState> administrativeState = default;
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
                if (property.NameEquals("location"u8))
                {
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("annotation"u8))
                        {
                            annotation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkFabricSku"u8))
                        {
                            networkFabricSku = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fabricVersion"u8))
                        {
                            fabricVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("routerIds"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            routerIds = array;
                            continue;
                        }
                        if (property0.NameEquals("networkFabricControllerId"u8))
                        {
                            networkFabricControllerId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("rackCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            rackCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("serverCountPerRack"u8))
                        {
                            serverCountPerRack = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("ipv4Prefix"u8))
                        {
                            ipv4Prefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipv6Prefix"u8))
                        {
                            ipv6Prefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fabricASN"u8))
                        {
                            fabricAsn = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("terminalServerConfiguration"u8))
                        {
                            terminalServerConfiguration = TerminalServerConfiguration.DeserializeTerminalServerConfiguration(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("managementNetworkConfiguration"u8))
                        {
                            managementNetworkConfiguration = ManagementNetworkConfigurationProperties.DeserializeManagementNetworkConfigurationProperties(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("racks"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            racks = array;
                            continue;
                        }
                        if (property0.NameEquals("l2IsolationDomains"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            l2IsolationDomains = array;
                            continue;
                        }
                        if (property0.NameEquals("l3IsolationDomains"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            l3IsolationDomains = array;
                            continue;
                        }
                        if (property0.NameEquals("configurationState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            configurationState = new NetworkFabricConfigurationState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new NetworkFabricProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("administrativeState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            administrativeState = new NetworkFabricAdministrativeState(property0.Value.GetString());
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
            return new NetworkFabricData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, annotation.Value, networkFabricSku, fabricVersion.Value, routerIds ?? new ChangeTrackingList<string>(), networkFabricControllerId, Optional.ToNullable(rackCount), serverCountPerRack, ipv4Prefix, ipv6Prefix.Value, fabricAsn, terminalServerConfiguration, managementNetworkConfiguration, racks ?? new ChangeTrackingList<string>(), l2IsolationDomains ?? new ChangeTrackingList<string>(), l3IsolationDomains ?? new ChangeTrackingList<string>(), Optional.ToNullable(configurationState), Optional.ToNullable(provisioningState), Optional.ToNullable(administrativeState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkFabricData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkFabricData)} does not support '{options.Format}' format.");
            }
        }

        NetworkFabricData IPersistableModel<NetworkFabricData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkFabricData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkFabricData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkFabricData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkFabricData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
