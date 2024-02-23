// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DeviceUpdate.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DeviceUpdate
{
    public partial class DeviceUpdateInstanceData : IUtf8JsonSerializable, IJsonModel<DeviceUpdateInstanceData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeviceUpdateInstanceData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeviceUpdateInstanceData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateInstanceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceUpdateInstanceData)} does not support '{format}' format.");
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
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && AccountName != null)
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (!(IotHubs is ChangeTrackingList<DeviceUpdateIotHubSettings> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("iotHubs"u8);
                writer.WriteStartArray();
                foreach (var item in IotHubs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (EnableDiagnostics.HasValue)
            {
                writer.WritePropertyName("enableDiagnostics"u8);
                writer.WriteBooleanValue(EnableDiagnostics.Value);
            }
            if (DiagnosticStorageProperties != null)
            {
                writer.WritePropertyName("diagnosticStorageProperties"u8);
                writer.WriteObjectValue(DiagnosticStorageProperties);
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

        DeviceUpdateInstanceData IJsonModel<DeviceUpdateInstanceData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateInstanceData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeviceUpdateInstanceData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeviceUpdateInstanceData(document.RootElement, options);
        }

        internal static DeviceUpdateInstanceData DeserializeDeviceUpdateInstanceData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<DeviceUpdateProvisioningState> provisioningState = default;
            Optional<string> accountName = default;
            IList<DeviceUpdateIotHubSettings> iotHubs = default;
            Optional<bool> enableDiagnostics = default;
            Optional<DiagnosticStorageProperties> diagnosticStorageProperties = default;
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new DeviceUpdateProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("accountName"u8))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("iotHubs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DeviceUpdateIotHubSettings> array = new List<DeviceUpdateIotHubSettings>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeviceUpdateIotHubSettings.DeserializeDeviceUpdateIotHubSettings(item, options));
                            }
                            iotHubs = array;
                            continue;
                        }
                        if (property0.NameEquals("enableDiagnostics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableDiagnostics = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("diagnosticStorageProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            diagnosticStorageProperties = DiagnosticStorageProperties.DeserializeDiagnosticStorageProperties(property0.Value, options);
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
            return new DeviceUpdateInstanceData(id, name, type, systemData.Value, Optional.ToDictionary(tags), location, Optional.ToNullable(provisioningState), accountName.Value, iotHubs ?? new ChangeTrackingList<DeviceUpdateIotHubSettings>(), Optional.ToNullable(enableDiagnostics), diagnosticStorageProperties.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeviceUpdateInstanceData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateInstanceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeviceUpdateInstanceData)} does not support '{options.Format}' format.");
            }
        }

        DeviceUpdateInstanceData IPersistableModel<DeviceUpdateInstanceData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeviceUpdateInstanceData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeviceUpdateInstanceData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeviceUpdateInstanceData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeviceUpdateInstanceData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
