// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class ModelPackageContent : IUtf8JsonSerializable, IJsonModel<ModelPackageContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ModelPackageContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ModelPackageContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPackageContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelPackageContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (BaseEnvironmentSource != null)
            {
                if (BaseEnvironmentSource != null)
                {
                    writer.WritePropertyName("baseEnvironmentSource"u8);
                    writer.WriteObjectValue(BaseEnvironmentSource);
                }
                else
                {
                    writer.WriteNull("baseEnvironmentSource");
                }
            }
            if (!(EnvironmentVariables is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                if (EnvironmentVariables != null)
                {
                    writer.WritePropertyName("environmentVariables"u8);
                    writer.WriteStartObject();
                    foreach (var item in EnvironmentVariables)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteStringValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("environmentVariables");
                }
            }
            writer.WritePropertyName("inferencingServer"u8);
            writer.WriteObjectValue(InferencingServer);
            if (!(Inputs is ChangeTrackingList<ModelPackageInput> collection0 && collection0.IsUndefined))
            {
                if (Inputs != null)
                {
                    writer.WritePropertyName("inputs"u8);
                    writer.WriteStartArray();
                    foreach (var item in Inputs)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("inputs");
                }
            }
            if (ModelConfiguration != null)
            {
                if (ModelConfiguration != null)
                {
                    writer.WritePropertyName("modelConfiguration"u8);
                    writer.WriteObjectValue(ModelConfiguration);
                }
                else
                {
                    writer.WriteNull("modelConfiguration");
                }
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection1 && collection1.IsUndefined))
            {
                if (Tags != null)
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
                else
                {
                    writer.WriteNull("tags");
                }
            }
            writer.WritePropertyName("targetEnvironmentId"u8);
            writer.WriteStringValue(TargetEnvironmentId);
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

        ModelPackageContent IJsonModel<ModelPackageContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPackageContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ModelPackageContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeModelPackageContent(document.RootElement, options);
        }

        internal static ModelPackageContent DeserializeModelPackageContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BaseEnvironmentSource> baseEnvironmentSource = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            InferencingServer inferencingServer = default;
            IList<ModelPackageInput> inputs = default;
            Optional<ModelConfiguration> modelConfiguration = default;
            Optional<IDictionary<string, string>> tags = default;
            string targetEnvironmentId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseEnvironmentSource"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        baseEnvironmentSource = null;
                        continue;
                    }
                    baseEnvironmentSource = BaseEnvironmentSource.DeserializeBaseEnvironmentSource(property.Value, options);
                    continue;
                }
                if (property.NameEquals("environmentVariables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        environmentVariables = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("inferencingServer"u8))
                {
                    inferencingServer = InferencingServer.DeserializeInferencingServer(property.Value, options);
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        inputs = null;
                        continue;
                    }
                    List<ModelPackageInput> array = new List<ModelPackageInput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ModelPackageInput.DeserializeModelPackageInput(item, options));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("modelConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelConfiguration = null;
                        continue;
                    }
                    modelConfiguration = ModelConfiguration.DeserializeModelConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
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
                if (property.NameEquals("targetEnvironmentId"u8))
                {
                    targetEnvironmentId = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ModelPackageContent(baseEnvironmentSource.Value, Optional.ToDictionary(environmentVariables), inferencingServer, inputs ?? new ChangeTrackingList<ModelPackageInput>(), modelConfiguration.Value, Optional.ToDictionary(tags), targetEnvironmentId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ModelPackageContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPackageContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ModelPackageContent)} does not support '{options.Format}' format.");
            }
        }

        ModelPackageContent IPersistableModel<ModelPackageContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ModelPackageContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeModelPackageContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ModelPackageContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ModelPackageContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
