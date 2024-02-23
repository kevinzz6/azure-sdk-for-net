// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceFabric.Models;

namespace Azure.ResourceManager.ServiceFabric
{
    public partial class ServiceFabricServiceData : IUtf8JsonSerializable, IJsonModel<ServiceFabricServiceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceFabricServiceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceFabricServiceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceFabricServiceData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ETag.HasValue)
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
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
            if (PlacementConstraints != null)
            {
                writer.WritePropertyName("placementConstraints"u8);
                writer.WriteStringValue(PlacementConstraints);
            }
            if (!(CorrelationScheme is ChangeTrackingList<ServiceCorrelationDescription> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("correlationScheme"u8);
                writer.WriteStartArray();
                foreach (var item in CorrelationScheme)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ServiceLoadMetrics is ChangeTrackingList<ServiceLoadMetricDescription> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("serviceLoadMetrics"u8);
                writer.WriteStartArray();
                foreach (var item in ServiceLoadMetrics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ServicePlacementPolicies is ChangeTrackingList<ServicePlacementPolicyDescription> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("servicePlacementPolicies"u8);
                writer.WriteStartArray();
                foreach (var item in ServicePlacementPolicies)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (DefaultMoveCost.HasValue)
            {
                writer.WritePropertyName("defaultMoveCost"u8);
                writer.WriteStringValue(DefaultMoveCost.Value.ToString());
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
            }
            if (ServiceKind.HasValue)
            {
                writer.WritePropertyName("serviceKind"u8);
                writer.WriteStringValue(ServiceKind.Value.ToString());
            }
            if (ServiceTypeName != null)
            {
                writer.WritePropertyName("serviceTypeName"u8);
                writer.WriteStringValue(ServiceTypeName);
            }
            if (PartitionDescription != null)
            {
                writer.WritePropertyName("partitionDescription"u8);
                writer.WriteObjectValue(PartitionDescription);
            }
            if (ServicePackageActivationMode.HasValue)
            {
                writer.WritePropertyName("servicePackageActivationMode"u8);
                writer.WriteStringValue(ServicePackageActivationMode.Value.ToString());
            }
            if (ServiceDnsName != null)
            {
                writer.WritePropertyName("serviceDnsName"u8);
                writer.WriteStringValue(ServiceDnsName);
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

        ServiceFabricServiceData IJsonModel<ServiceFabricServiceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricServiceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceFabricServiceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceFabricServiceData(document.RootElement, options);
        }

        internal static ServiceFabricServiceData DeserializeServiceFabricServiceData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ETag> etag = default;
            Optional<IDictionary<string, string>> tags = default;
            AzureLocation location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> placementConstraints = default;
            IList<ServiceCorrelationDescription> correlationScheme = default;
            IList<ServiceLoadMetricDescription> serviceLoadMetrics = default;
            IList<ServicePlacementPolicyDescription> servicePlacementPolicies = default;
            Optional<ApplicationMoveCost> defaultMoveCost = default;
            Optional<string> provisioningState = default;
            Optional<ApplicationServiceKind> serviceKind = default;
            Optional<string> serviceTypeName = default;
            Optional<PartitionSchemeDescription> partitionDescription = default;
            Optional<ArmServicePackageActivationMode> servicePackageActivationMode = default;
            Optional<string> serviceDnsName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("placementConstraints"u8))
                        {
                            placementConstraints = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("correlationScheme"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServiceCorrelationDescription> array = new List<ServiceCorrelationDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceCorrelationDescription.DeserializeServiceCorrelationDescription(item, options));
                            }
                            correlationScheme = array;
                            continue;
                        }
                        if (property0.NameEquals("serviceLoadMetrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServiceLoadMetricDescription> array = new List<ServiceLoadMetricDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceLoadMetricDescription.DeserializeServiceLoadMetricDescription(item, options));
                            }
                            serviceLoadMetrics = array;
                            continue;
                        }
                        if (property0.NameEquals("servicePlacementPolicies"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServicePlacementPolicyDescription> array = new List<ServicePlacementPolicyDescription>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServicePlacementPolicyDescription.DeserializeServicePlacementPolicyDescription(item, options));
                            }
                            servicePlacementPolicies = array;
                            continue;
                        }
                        if (property0.NameEquals("defaultMoveCost"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultMoveCost = new ApplicationMoveCost(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serviceKind"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceKind = new ApplicationServiceKind(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceTypeName"u8))
                        {
                            serviceTypeName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("partitionDescription"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            partitionDescription = PartitionSchemeDescription.DeserializePartitionSchemeDescription(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("servicePackageActivationMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePackageActivationMode = new ArmServicePackageActivationMode(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceDnsName"u8))
                        {
                            serviceDnsName = property0.Value.GetString();
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
            return new ServiceFabricServiceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, placementConstraints.Value, correlationScheme ?? new ChangeTrackingList<ServiceCorrelationDescription>(), serviceLoadMetrics ?? new ChangeTrackingList<ServiceLoadMetricDescription>(), servicePlacementPolicies ?? new ChangeTrackingList<ServicePlacementPolicyDescription>(), Optional.ToNullable(defaultMoveCost), provisioningState.Value, Optional.ToNullable(serviceKind), serviceTypeName.Value, partitionDescription.Value, Optional.ToNullable(servicePackageActivationMode), serviceDnsName.Value, Optional.ToNullable(etag), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceFabricServiceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ServiceFabricServiceData)} does not support '{options.Format}' format.");
            }
        }

        ServiceFabricServiceData IPersistableModel<ServiceFabricServiceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceFabricServiceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceFabricServiceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceFabricServiceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceFabricServiceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
