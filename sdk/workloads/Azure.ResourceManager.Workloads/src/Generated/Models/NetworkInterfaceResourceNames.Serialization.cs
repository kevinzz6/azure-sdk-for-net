// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class NetworkInterfaceResourceNames : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkInterfaceName))
            {
                writer.WritePropertyName("networkInterfaceName"u8);
                writer.WriteStringValue(NetworkInterfaceName);
            }
            writer.WriteEndObject();
        }

        internal static NetworkInterfaceResourceNames DeserializeNetworkInterfaceResourceNames(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> networkInterfaceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkInterfaceName"u8))
                {
                    networkInterfaceName = property.Value.GetString();
                    continue;
                }
            }
            return new NetworkInterfaceResourceNames(networkInterfaceName.Value);
        }
    }
}
