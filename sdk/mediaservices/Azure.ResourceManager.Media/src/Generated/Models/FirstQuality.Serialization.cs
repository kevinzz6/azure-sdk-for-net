// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    internal partial class FirstQuality : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("bitrate"u8);
            writer.WriteNumberValue(Bitrate);
            writer.WriteEndObject();
        }

        internal static FirstQuality DeserializeFirstQuality(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int bitrate = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("bitrate"u8))
                {
                    bitrate = property.Value.GetInt32();
                    continue;
                }
            }
            return new FirstQuality(bitrate);
        }
    }
}
