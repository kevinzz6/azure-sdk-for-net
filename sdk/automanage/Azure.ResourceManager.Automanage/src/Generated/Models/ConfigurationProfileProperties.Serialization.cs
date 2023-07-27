// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automanage.Models
{
    internal partial class ConfigurationProfileProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Configuration))
            {
                writer.WritePropertyName("configuration"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Configuration);
#else
                JsonSerializer.Serialize(writer, JsonDocument.Parse(Configuration.ToString()).RootElement);
#endif
            }
            writer.WriteEndObject();
        }

        internal static ConfigurationProfileProperties DeserializeConfigurationProfileProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BinaryData> configuration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configuration = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
            }
            return new ConfigurationProfileProperties(configuration.Value);
        }
    }
}
