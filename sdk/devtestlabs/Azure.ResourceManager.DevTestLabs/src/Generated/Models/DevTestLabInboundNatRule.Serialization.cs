// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabInboundNatRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TransportProtocol))
            {
                writer.WritePropertyName("transportProtocol"u8);
                writer.WriteStringValue(TransportProtocol.Value.ToString());
            }
            if (Optional.IsDefined(FrontendPort))
            {
                writer.WritePropertyName("frontendPort"u8);
                writer.WriteNumberValue(FrontendPort.Value);
            }
            if (Optional.IsDefined(BackendPort))
            {
                writer.WritePropertyName("backendPort"u8);
                writer.WriteNumberValue(BackendPort.Value);
            }
            writer.WriteEndObject();
        }

        internal static DevTestLabInboundNatRule DeserializeDevTestLabInboundNatRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DevTestLabTransportProtocol> transportProtocol = default;
            Optional<int> frontendPort = default;
            Optional<int> backendPort = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("transportProtocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    transportProtocol = new DevTestLabTransportProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("frontendPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    frontendPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backendPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backendPort = property.Value.GetInt32();
                    continue;
                }
            }
            return new DevTestLabInboundNatRule(Optional.ToNullable(transportProtocol), Optional.ToNullable(frontendPort), Optional.ToNullable(backendPort));
        }
    }
}
