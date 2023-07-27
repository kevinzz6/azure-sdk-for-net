// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class PatientInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Sex))
            {
                writer.WritePropertyName("sex"u8);
                writer.WriteStringValue(Sex.Value.ToString());
            }
            if (Optional.IsDefined(BirthDate))
            {
                writer.WritePropertyName("birthDate"u8);
                writer.WriteStringValue(BirthDate.Value, "D");
            }
            if (Optional.IsCollectionDefined(ClinicalInfo))
            {
                writer.WritePropertyName("clinicalInfo"u8);
                writer.WriteStartArray();
                foreach (var item in ClinicalInfo)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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
