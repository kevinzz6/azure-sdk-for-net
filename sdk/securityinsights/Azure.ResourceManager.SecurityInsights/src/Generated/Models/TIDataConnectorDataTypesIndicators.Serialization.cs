// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    internal partial class TIDataConnectorDataTypesIndicators : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static TIDataConnectorDataTypesIndicators DeserializeTIDataConnectorDataTypesIndicators(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SecurityInsightsDataTypeConnectionState> state = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SecurityInsightsDataTypeConnectionState(property.Value.GetString());
                    continue;
                }
            }
            return new TIDataConnectorDataTypesIndicators(Optional.ToNullable(state));
        }
    }
}
