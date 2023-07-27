// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class AutoMLVertical : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LogVerbosity))
            {
                writer.WritePropertyName("logVerbosity"u8);
                writer.WriteStringValue(LogVerbosity.Value.ToString());
            }
            if (Optional.IsDefined(TargetColumnName))
            {
                if (TargetColumnName != null)
                {
                    writer.WritePropertyName("targetColumnName"u8);
                    writer.WriteStringValue(TargetColumnName);
                }
                else
                {
                    writer.WriteNull("targetColumnName");
                }
            }
            writer.WritePropertyName("taskType"u8);
            writer.WriteStringValue(TaskType.ToString());
            writer.WritePropertyName("trainingData"u8);
            writer.WriteObjectValue(TrainingData);
            writer.WriteEndObject();
        }

        internal static AutoMLVertical DeserializeAutoMLVertical(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("taskType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Classification": return ClassificationTask.DeserializeClassificationTask(element);
                    case "Forecasting": return MachineLearningForecasting.DeserializeMachineLearningForecasting(element);
                    case "ImageClassification": return ImageClassification.DeserializeImageClassification(element);
                    case "ImageClassificationMultilabel": return ImageClassificationMultilabel.DeserializeImageClassificationMultilabel(element);
                    case "ImageInstanceSegmentation": return ImageInstanceSegmentation.DeserializeImageInstanceSegmentation(element);
                    case "ImageObjectDetection": return ImageObjectDetection.DeserializeImageObjectDetection(element);
                    case "Regression": return AutoMLVerticalRegression.DeserializeAutoMLVerticalRegression(element);
                    case "TextClassification": return TextClassification.DeserializeTextClassification(element);
                    case "TextClassificationMultilabel": return TextClassificationMultilabel.DeserializeTextClassificationMultilabel(element);
                    case "TextNER": return TextNer.DeserializeTextNer(element);
                }
            }
            return UnknownAutoMLVertical.DeserializeUnknownAutoMLVertical(element);
        }
    }
}
