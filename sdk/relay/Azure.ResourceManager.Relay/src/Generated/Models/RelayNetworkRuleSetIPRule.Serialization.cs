// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Relay.Models
{
    public partial class RelayNetworkRuleSetIPRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IPMask))
            {
                writer.WritePropertyName("ipMask"u8);
                writer.WriteStringValue(IPMask);
            }
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteStringValue(Action.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static RelayNetworkRuleSetIPRule DeserializeRelayNetworkRuleSetIPRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ipMask = default;
            Optional<RelayNetworkRuleIPAction> action = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ipMask"u8))
                {
                    ipMask = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("action"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    action = new RelayNetworkRuleIPAction(property.Value.GetString());
                    continue;
                }
            }
            return new RelayNetworkRuleSetIPRule(ipMask.Value, Optional.ToNullable(action));
        }
    }
}
