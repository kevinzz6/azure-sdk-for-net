// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PartnerManagedResourceProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static PartnerManagedResourceProperties DeserializePartnerManagedResourceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<ResourceIdentifier> internalLoadBalancerId = default;
            Optional<ResourceIdentifier> standardLoadBalancerId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("internalLoadBalancerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internalLoadBalancerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("standardLoadBalancerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    standardLoadBalancerId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new PartnerManagedResourceProperties(id.Value, internalLoadBalancerId.Value, standardLoadBalancerId.Value);
        }
    }
}
