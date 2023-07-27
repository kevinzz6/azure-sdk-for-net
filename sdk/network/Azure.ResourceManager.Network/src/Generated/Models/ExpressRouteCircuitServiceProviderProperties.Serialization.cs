// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteCircuitServiceProviderProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceProviderName))
            {
                writer.WritePropertyName("serviceProviderName"u8);
                writer.WriteStringValue(ServiceProviderName);
            }
            if (Optional.IsDefined(PeeringLocation))
            {
                writer.WritePropertyName("peeringLocation"u8);
                writer.WriteStringValue(PeeringLocation);
            }
            if (Optional.IsDefined(BandwidthInMbps))
            {
                writer.WritePropertyName("bandwidthInMbps"u8);
                writer.WriteNumberValue(BandwidthInMbps.Value);
            }
            writer.WriteEndObject();
        }

        internal static ExpressRouteCircuitServiceProviderProperties DeserializeExpressRouteCircuitServiceProviderProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serviceProviderName = default;
            Optional<string> peeringLocation = default;
            Optional<int> bandwidthInMbps = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceProviderName"u8))
                {
                    serviceProviderName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("peeringLocation"u8))
                {
                    peeringLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bandwidthInMbps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    bandwidthInMbps = property.Value.GetInt32();
                    continue;
                }
            }
            return new ExpressRouteCircuitServiceProviderProperties(serviceProviderName.Value, peeringLocation.Value, Optional.ToNullable(bandwidthInMbps));
        }
    }
}
