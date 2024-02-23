// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFlowDebugPackageDebugSettings : IUtf8JsonSerializable, IJsonModel<DataFlowDebugPackageDebugSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFlowDebugPackageDebugSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFlowDebugPackageDebugSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlowDebugPackageDebugSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFlowDebugPackageDebugSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(SourceSettings is ChangeTrackingList<DataFlowSourceSetting> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("sourceSettings"u8);
                writer.WriteStartArray();
                foreach (var item in SourceSettings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Parameters is ChangeTrackingDictionary<string, BinaryData> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndObject();
            }
            if (DatasetParameters != null)
            {
                writer.WritePropertyName("datasetParameters"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(DatasetParameters);
#else
                using (JsonDocument document = JsonDocument.Parse(DatasetParameters))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        DataFlowDebugPackageDebugSettings IJsonModel<DataFlowDebugPackageDebugSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlowDebugPackageDebugSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFlowDebugPackageDebugSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFlowDebugPackageDebugSettings(document.RootElement, options);
        }

        internal static DataFlowDebugPackageDebugSettings DeserializeDataFlowDebugPackageDebugSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<DataFlowSourceSetting> sourceSettings = default;
            Optional<IDictionary<string, BinaryData>> parameters = default;
            Optional<BinaryData> datasetParameters = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFlowSourceSetting> array = new List<DataFlowSourceSetting>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFlowSourceSetting.DeserializeDataFlowSourceSetting(item, options));
                    }
                    sourceSettings = array;
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("datasetParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datasetParameters = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataFlowDebugPackageDebugSettings(sourceSettings ?? new ChangeTrackingList<DataFlowSourceSetting>(), Optional.ToDictionary(parameters), datasetParameters.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataFlowDebugPackageDebugSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlowDebugPackageDebugSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFlowDebugPackageDebugSettings)} does not support '{options.Format}' format.");
            }
        }

        DataFlowDebugPackageDebugSettings IPersistableModel<DataFlowDebugPackageDebugSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFlowDebugPackageDebugSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFlowDebugPackageDebugSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFlowDebugPackageDebugSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFlowDebugPackageDebugSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
