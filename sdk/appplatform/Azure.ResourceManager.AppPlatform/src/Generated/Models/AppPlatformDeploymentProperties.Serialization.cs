// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformDeploymentProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformDeploymentProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformDeploymentProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformDeploymentProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformDeploymentProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Source != null)
            {
                writer.WritePropertyName("source"u8);
                writer.WriteObjectValue(Source);
            }
            if (DeploymentSettings != null)
            {
                writer.WritePropertyName("deploymentSettings"u8);
                writer.WriteObjectValue(DeploymentSettings);
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (IsActive.HasValue)
            {
                writer.WritePropertyName("active"u8);
                writer.WriteBooleanValue(IsActive.Value);
            }
            if (options.Format != "W" && !(Instances is ChangeTrackingList<AppPlatformDeploymentInstance> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("instances"u8);
                writer.WriteStartArray();
                foreach (var item in Instances)
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

        AppPlatformDeploymentProperties IJsonModel<AppPlatformDeploymentProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformDeploymentProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformDeploymentProperties(document.RootElement, options);
        }

        internal static AppPlatformDeploymentProperties DeserializeAppPlatformDeploymentProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformUserSourceInfo> source = default;
            Optional<AppPlatformDeploymentSettings> deploymentSettings = default;
            Optional<AppPlatformDeploymentProvisioningState> provisioningState = default;
            Optional<AppPlatformDeploymentStatus> status = default;
            Optional<bool> active = default;
            IReadOnlyList<AppPlatformDeploymentInstance> instances = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = AppPlatformUserSourceInfo.DeserializeAppPlatformUserSourceInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("deploymentSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deploymentSettings = AppPlatformDeploymentSettings.DeserializeAppPlatformDeploymentSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformDeploymentProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new AppPlatformDeploymentStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("active"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    active = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("instances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformDeploymentInstance> array = new List<AppPlatformDeploymentInstance>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformDeploymentInstance.DeserializeAppPlatformDeploymentInstance(item, options));
                    }
                    instances = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformDeploymentProperties(source.Value, deploymentSettings.Value, Optional.ToNullable(provisioningState), Optional.ToNullable(status), Optional.ToNullable(active), instances ?? new ChangeTrackingList<AppPlatformDeploymentInstance>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformDeploymentProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformDeploymentProperties)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformDeploymentProperties IPersistableModel<AppPlatformDeploymentProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformDeploymentProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformDeploymentProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformDeploymentProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformDeploymentProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
