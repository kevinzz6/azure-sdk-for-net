// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnNatRuleMapping : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AddressSpace))
            {
                writer.WritePropertyName("addressSpace"u8);
                writer.WriteStringValue(AddressSpace);
            }
            if (Optional.IsDefined(PortRange))
            {
                writer.WritePropertyName("portRange"u8);
                writer.WriteStringValue(PortRange);
            }
            writer.WriteEndObject();
        }

        internal static VpnNatRuleMapping DeserializeVpnNatRuleMapping(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> addressSpace = default;
            Optional<string> portRange = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("addressSpace"u8))
                {
                    addressSpace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("portRange"u8))
                {
                    portRange = property.Value.GetString();
                    continue;
                }
            }
            return new VpnNatRuleMapping(addressSpace.Value, portRange.Value);
        }
    }
}
