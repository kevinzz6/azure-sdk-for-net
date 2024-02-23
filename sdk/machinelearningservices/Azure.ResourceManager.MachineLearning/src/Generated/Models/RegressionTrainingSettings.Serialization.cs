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
    public partial class RegressionTrainingSettings : IUtf8JsonSerializable, IJsonModel<RegressionTrainingSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RegressionTrainingSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RegressionTrainingSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegressionTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegressionTrainingSettings)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(AllowedTrainingAlgorithms is ChangeTrackingList<AutoMLVerticalRegressionModel> collection && collection.IsUndefined))
            {
                if (AllowedTrainingAlgorithms != null)
                {
                    writer.WritePropertyName("allowedTrainingAlgorithms"u8);
                    writer.WriteStartArray();
                    foreach (var item in AllowedTrainingAlgorithms)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("allowedTrainingAlgorithms");
                }
            }
            if (!(BlockedTrainingAlgorithms is ChangeTrackingList<AutoMLVerticalRegressionModel> collection0 && collection0.IsUndefined))
            {
                if (BlockedTrainingAlgorithms != null)
                {
                    writer.WritePropertyName("blockedTrainingAlgorithms"u8);
                    writer.WriteStartArray();
                    foreach (var item in BlockedTrainingAlgorithms)
                    {
                        writer.WriteStringValue(item.ToString());
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("blockedTrainingAlgorithms");
                }
            }
            if (IsDnnTrainingEnabled.HasValue)
            {
                writer.WritePropertyName("enableDnnTraining"u8);
                writer.WriteBooleanValue(IsDnnTrainingEnabled.Value);
            }
            if (IsModelExplainabilityEnabled.HasValue)
            {
                writer.WritePropertyName("enableModelExplainability"u8);
                writer.WriteBooleanValue(IsModelExplainabilityEnabled.Value);
            }
            if (IsOnnxCompatibleModelsEnabled.HasValue)
            {
                writer.WritePropertyName("enableOnnxCompatibleModels"u8);
                writer.WriteBooleanValue(IsOnnxCompatibleModelsEnabled.Value);
            }
            if (IsStackEnsembleEnabled.HasValue)
            {
                writer.WritePropertyName("enableStackEnsemble"u8);
                writer.WriteBooleanValue(IsStackEnsembleEnabled.Value);
            }
            if (IsVoteEnsembleEnabled.HasValue)
            {
                writer.WritePropertyName("enableVoteEnsemble"u8);
                writer.WriteBooleanValue(IsVoteEnsembleEnabled.Value);
            }
            if (EnsembleModelDownloadTimeout.HasValue)
            {
                writer.WritePropertyName("ensembleModelDownloadTimeout"u8);
                writer.WriteStringValue(EnsembleModelDownloadTimeout.Value, "P");
            }
            if (StackEnsembleSettings != null)
            {
                if (StackEnsembleSettings != null)
                {
                    writer.WritePropertyName("stackEnsembleSettings"u8);
                    writer.WriteObjectValue(StackEnsembleSettings);
                }
                else
                {
                    writer.WriteNull("stackEnsembleSettings");
                }
            }
            if (TrainingMode.HasValue)
            {
                writer.WritePropertyName("trainingMode"u8);
                writer.WriteStringValue(TrainingMode.Value.ToString());
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

        RegressionTrainingSettings IJsonModel<RegressionTrainingSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegressionTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RegressionTrainingSettings)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRegressionTrainingSettings(document.RootElement, options);
        }

        internal static RegressionTrainingSettings DeserializeRegressionTrainingSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AutoMLVerticalRegressionModel> allowedTrainingAlgorithms = default;
            IList<AutoMLVerticalRegressionModel> blockedTrainingAlgorithms = default;
            Optional<bool> enableDnnTraining = default;
            Optional<bool> enableModelExplainability = default;
            Optional<bool> enableOnnxCompatibleModels = default;
            Optional<bool> enableStackEnsemble = default;
            Optional<bool> enableVoteEnsemble = default;
            Optional<TimeSpan> ensembleModelDownloadTimeout = default;
            Optional<MachineLearningStackEnsembleSettings> stackEnsembleSettings = default;
            Optional<TrainingMode> trainingMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedTrainingAlgorithms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        allowedTrainingAlgorithms = null;
                        continue;
                    }
                    List<AutoMLVerticalRegressionModel> array = new List<AutoMLVerticalRegressionModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AutoMLVerticalRegressionModel(item.GetString()));
                    }
                    allowedTrainingAlgorithms = array;
                    continue;
                }
                if (property.NameEquals("blockedTrainingAlgorithms"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        blockedTrainingAlgorithms = null;
                        continue;
                    }
                    List<AutoMLVerticalRegressionModel> array = new List<AutoMLVerticalRegressionModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AutoMLVerticalRegressionModel(item.GetString()));
                    }
                    blockedTrainingAlgorithms = array;
                    continue;
                }
                if (property.NameEquals("enableDnnTraining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableDnnTraining = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableModelExplainability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableModelExplainability = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableOnnxCompatibleModels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableOnnxCompatibleModels = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableStackEnsemble"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableStackEnsemble = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enableVoteEnsemble"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableVoteEnsemble = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("ensembleModelDownloadTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ensembleModelDownloadTimeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("stackEnsembleSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        stackEnsembleSettings = null;
                        continue;
                    }
                    stackEnsembleSettings = MachineLearningStackEnsembleSettings.DeserializeMachineLearningStackEnsembleSettings(property.Value, options);
                    continue;
                }
                if (property.NameEquals("trainingMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trainingMode = new TrainingMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RegressionTrainingSettings(Optional.ToNullable(enableDnnTraining), Optional.ToNullable(enableModelExplainability), Optional.ToNullable(enableOnnxCompatibleModels), Optional.ToNullable(enableStackEnsemble), Optional.ToNullable(enableVoteEnsemble), Optional.ToNullable(ensembleModelDownloadTimeout), stackEnsembleSettings.Value, Optional.ToNullable(trainingMode), serializedAdditionalRawData, allowedTrainingAlgorithms ?? new ChangeTrackingList<AutoMLVerticalRegressionModel>(), blockedTrainingAlgorithms ?? new ChangeTrackingList<AutoMLVerticalRegressionModel>());
        }

        BinaryData IPersistableModel<RegressionTrainingSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegressionTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RegressionTrainingSettings)} does not support '{options.Format}' format.");
            }
        }

        RegressionTrainingSettings IPersistableModel<RegressionTrainingSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RegressionTrainingSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRegressionTrainingSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RegressionTrainingSettings)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RegressionTrainingSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
