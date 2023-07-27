// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    public partial class UnivariateChangePointDetectionOptions : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("series"u8);
            writer.WriteStartArray();
            foreach (var item in Series)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("granularity"u8);
            writer.WriteStringValue(Granularity.ToString());
            if (Optional.IsDefined(CustomInterval))
            {
                writer.WritePropertyName("customInterval"u8);
                writer.WriteNumberValue(CustomInterval.Value);
            }
            if (Optional.IsDefined(Period))
            {
                writer.WritePropertyName("period"u8);
                writer.WriteNumberValue(Period.Value);
            }
            if (Optional.IsDefined(StableTrendWindow))
            {
                writer.WritePropertyName("stableTrendWindow"u8);
                writer.WriteNumberValue(StableTrendWindow.Value);
            }
            if (Optional.IsDefined(Threshold))
            {
                writer.WritePropertyName("threshold"u8);
                writer.WriteNumberValue(Threshold.Value);
            }
            writer.WriteEndObject();
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
