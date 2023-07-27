// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class AdditionalCapabilities : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(UltraSsdEnabled))
            {
                writer.WritePropertyName("ultraSSDEnabled"u8);
                writer.WriteBooleanValue(UltraSsdEnabled.Value);
            }
            if (Optional.IsDefined(HibernationEnabled))
            {
                writer.WritePropertyName("hibernationEnabled"u8);
                writer.WriteBooleanValue(HibernationEnabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static AdditionalCapabilities DeserializeAdditionalCapabilities(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> ultraSsdEnabled = default;
            Optional<bool> hibernationEnabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ultraSSDEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ultraSsdEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("hibernationEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hibernationEnabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new AdditionalCapabilities(Optional.ToNullable(ultraSsdEnabled), Optional.ToNullable(hibernationEnabled));
        }
    }
}
