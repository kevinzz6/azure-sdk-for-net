// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class UnknownAdditionalData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("assessedResourceType"u8);
            writer.WriteStringValue(AssessedResourceType.ToString());
            writer.WriteEndObject();
        }

        internal static UnknownAdditionalData DeserializeUnknownAdditionalData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AssessedResourceType assessedResourceType = "Unknown";
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assessedResourceType"u8))
                {
                    assessedResourceType = new AssessedResourceType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownAdditionalData(assessedResourceType);
        }
    }
}
