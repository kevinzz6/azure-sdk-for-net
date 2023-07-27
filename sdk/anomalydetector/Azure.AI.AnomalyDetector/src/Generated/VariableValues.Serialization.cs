// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.AnomalyDetector
{
    public partial class VariableValues : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("variable"u8);
            writer.WriteStringValue(Variable);
            writer.WritePropertyName("timestamps"u8);
            writer.WriteStartArray();
            foreach (var item in Timestamps)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("values"u8);
            writer.WriteStartArray();
            foreach (var item in Values)
            {
                writer.WriteNumberValue(item);
            }
            writer.WriteEndArray();
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
