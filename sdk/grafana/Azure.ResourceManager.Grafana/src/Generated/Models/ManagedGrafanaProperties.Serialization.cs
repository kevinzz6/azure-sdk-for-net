// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Grafana;

namespace Azure.ResourceManager.Grafana.Models
{
    public partial class ManagedGrafanaProperties : IUtf8JsonSerializable, IJsonModel<ManagedGrafanaProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedGrafanaProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedGrafanaProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedGrafanaProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedGrafanaProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && GrafanaVersion != null)
            {
                writer.WritePropertyName("grafanaVersion"u8);
                writer.WriteStringValue(GrafanaVersion);
            }
            if (options.Format != "W" && Endpoint != null)
            {
                writer.WritePropertyName("endpoint"u8);
                writer.WriteStringValue(Endpoint);
            }
            if (PublicNetworkAccess.HasValue)
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (ZoneRedundancy.HasValue)
            {
                writer.WritePropertyName("zoneRedundancy"u8);
                writer.WriteStringValue(ZoneRedundancy.Value.ToString());
            }
            if (ApiKey.HasValue)
            {
                writer.WritePropertyName("apiKey"u8);
                writer.WriteStringValue(ApiKey.Value.ToString());
            }
            if (DeterministicOutboundIP.HasValue)
            {
                writer.WritePropertyName("deterministicOutboundIP"u8);
                writer.WriteStringValue(DeterministicOutboundIP.Value.ToString());
            }
            if (options.Format != "W" && !(OutboundIPs is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("outboundIPs"u8);
                writer.WriteStartArray();
                foreach (var item in OutboundIPs)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && !(PrivateEndpointConnections is ChangeTrackingList<GrafanaPrivateEndpointConnectionData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (AutoGeneratedDomainNameLabelScope.HasValue)
            {
                writer.WritePropertyName("autoGeneratedDomainNameLabelScope"u8);
                writer.WriteStringValue(AutoGeneratedDomainNameLabelScope.Value.ToString());
            }
            if (GrafanaIntegrations != null)
            {
                writer.WritePropertyName("grafanaIntegrations"u8);
                writer.WriteObjectValue(GrafanaIntegrations);
            }
            if (EnterpriseConfigurations != null)
            {
                writer.WritePropertyName("enterpriseConfigurations"u8);
                writer.WriteObjectValue(EnterpriseConfigurations);
            }
            if (GrafanaConfigurations != null)
            {
                writer.WritePropertyName("grafanaConfigurations"u8);
                writer.WriteObjectValue(GrafanaConfigurations);
            }
            if (!(GrafanaPlugins is ChangeTrackingDictionary<string, GrafanaPlugin> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("grafanaPlugins"u8);
                writer.WriteStartObject();
                foreach (var item in GrafanaPlugins)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (GrafanaMajorVersion != null)
            {
                writer.WritePropertyName("grafanaMajorVersion"u8);
                writer.WriteStringValue(GrafanaMajorVersion);
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

        ManagedGrafanaProperties IJsonModel<ManagedGrafanaProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedGrafanaProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedGrafanaProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedGrafanaProperties(document.RootElement, options);
        }

        internal static ManagedGrafanaProperties DeserializeManagedGrafanaProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<GrafanaProvisioningState> provisioningState = default;
            Optional<string> grafanaVersion = default;
            Optional<string> endpoint = default;
            Optional<GrafanaPublicNetworkAccess> publicNetworkAccess = default;
            Optional<GrafanaZoneRedundancy> zoneRedundancy = default;
            Optional<GrafanaApiKey> apiKey = default;
            Optional<DeterministicOutboundIP> deterministicOutboundIP = default;
            IReadOnlyList<string> outboundIPs = default;
            IReadOnlyList<GrafanaPrivateEndpointConnectionData> privateEndpointConnections = default;
            Optional<AutoGeneratedDomainNameLabelScope> autoGeneratedDomainNameLabelScope = default;
            Optional<GrafanaIntegrations> grafanaIntegrations = default;
            Optional<EnterpriseConfigurations> enterpriseConfigurations = default;
            Optional<GrafanaConfigurations> grafanaConfigurations = default;
            Optional<IDictionary<string, GrafanaPlugin>> grafanaPlugins = default;
            Optional<string> grafanaMajorVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new GrafanaProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("grafanaVersion"u8))
                {
                    grafanaVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new GrafanaPublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zoneRedundancy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    zoneRedundancy = new GrafanaZoneRedundancy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("apiKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    apiKey = new GrafanaApiKey(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deterministicOutboundIP"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deterministicOutboundIP = new DeterministicOutboundIP(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("outboundIPs"u8))
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
                    outboundIPs = array;
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<GrafanaPrivateEndpointConnectionData> array = new List<GrafanaPrivateEndpointConnectionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GrafanaPrivateEndpointConnectionData.DeserializeGrafanaPrivateEndpointConnectionData(item, options));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("autoGeneratedDomainNameLabelScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    autoGeneratedDomainNameLabelScope = new AutoGeneratedDomainNameLabelScope(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("grafanaIntegrations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    grafanaIntegrations = GrafanaIntegrations.DeserializeGrafanaIntegrations(property.Value, options);
                    continue;
                }
                if (property.NameEquals("enterpriseConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enterpriseConfigurations = EnterpriseConfigurations.DeserializeEnterpriseConfigurations(property.Value, options);
                    continue;
                }
                if (property.NameEquals("grafanaConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    grafanaConfigurations = GrafanaConfigurations.DeserializeGrafanaConfigurations(property.Value, options);
                    continue;
                }
                if (property.NameEquals("grafanaPlugins"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, GrafanaPlugin> dictionary = new Dictionary<string, GrafanaPlugin>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, GrafanaPlugin.DeserializeGrafanaPlugin(property0.Value, options));
                    }
                    grafanaPlugins = dictionary;
                    continue;
                }
                if (property.NameEquals("grafanaMajorVersion"u8))
                {
                    grafanaMajorVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedGrafanaProperties(Optional.ToNullable(provisioningState), grafanaVersion.Value, endpoint.Value, Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(zoneRedundancy), Optional.ToNullable(apiKey), Optional.ToNullable(deterministicOutboundIP), outboundIPs ?? new ChangeTrackingList<string>(), privateEndpointConnections ?? new ChangeTrackingList<GrafanaPrivateEndpointConnectionData>(), Optional.ToNullable(autoGeneratedDomainNameLabelScope), grafanaIntegrations.Value, enterpriseConfigurations.Value, grafanaConfigurations.Value, Optional.ToDictionary(grafanaPlugins), grafanaMajorVersion.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedGrafanaProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedGrafanaProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedGrafanaProperties)} does not support '{options.Format}' format.");
            }
        }

        ManagedGrafanaProperties IPersistableModel<ManagedGrafanaProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedGrafanaProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedGrafanaProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedGrafanaProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedGrafanaProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
