// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    internal partial class ServiceAlertActionStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IsSuppressed))
            {
                writer.WritePropertyName("isSuppressed"u8);
                writer.WriteBooleanValue(IsSuppressed.Value);
            }
            writer.WriteEndObject();
        }

        internal static ServiceAlertActionStatus DeserializeServiceAlertActionStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isSuppressed = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isSuppressed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isSuppressed = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ServiceAlertActionStatus(Optional.ToNullable(isSuppressed));
        }
    }
}
