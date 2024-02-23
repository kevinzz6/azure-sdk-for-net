// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class AppServiceWorkerPoolData : IUtf8JsonSerializable, IJsonModel<AppServiceWorkerPoolData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceWorkerPoolData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceWorkerPoolData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceWorkerPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceWorkerPoolData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
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
            if (WorkerSizeId.HasValue)
            {
                writer.WritePropertyName("workerSizeId"u8);
                writer.WriteNumberValue(WorkerSizeId.Value);
            }
            if (ComputeMode.HasValue)
            {
                writer.WritePropertyName("computeMode"u8);
                writer.WriteStringValue(ComputeMode.Value.ToSerialString());
            }
            if (WorkerSize != null)
            {
                writer.WritePropertyName("workerSize"u8);
                writer.WriteStringValue(WorkerSize);
            }
            if (WorkerCount.HasValue)
            {
                writer.WritePropertyName("workerCount"u8);
                writer.WriteNumberValue(WorkerCount.Value);
            }
            if (options.Format != "W" && !(InstanceNames is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("instanceNames"u8);
                writer.WriteStartArray();
                foreach (var item in InstanceNames)
                {
                    writer.WriteStringValue(item);
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

        AppServiceWorkerPoolData IJsonModel<AppServiceWorkerPoolData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceWorkerPoolData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceWorkerPoolData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceWorkerPoolData(document.RootElement, options);
        }

        internal static AppServiceWorkerPoolData DeserializeAppServiceWorkerPoolData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppServiceSkuDescription> sku = default;
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<int> workerSizeId = default;
            Optional<ComputeModeOption> computeMode = default;
            Optional<string> workerSize = default;
            Optional<int> workerCount = default;
            IReadOnlyList<string> instanceNames = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = AppServiceSkuDescription.DeserializeAppServiceSkuDescription(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("workerSizeId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workerSizeId = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("computeMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeMode = property0.Value.GetString().ToComputeModeOption();
                            continue;
                        }
                        if (property0.NameEquals("workerSize"u8))
                        {
                            workerSize = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("workerCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            workerCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("instanceNames"u8))
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
                            instanceNames = array;
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
            return new AppServiceWorkerPoolData(id, name, type, systemData.Value, sku.Value, Optional.ToNullable(workerSizeId), Optional.ToNullable(computeMode), workerSize.Value, Optional.ToNullable(workerCount), instanceNames ?? new ChangeTrackingList<string>(), kind.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceWorkerPoolData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceWorkerPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceWorkerPoolData)} does not support '{options.Format}' format.");
            }
        }

        AppServiceWorkerPoolData IPersistableModel<AppServiceWorkerPoolData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceWorkerPoolData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceWorkerPoolData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceWorkerPoolData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceWorkerPoolData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
