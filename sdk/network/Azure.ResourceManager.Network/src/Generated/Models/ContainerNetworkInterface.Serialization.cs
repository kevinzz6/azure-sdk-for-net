// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ContainerNetworkInterface : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Container))
            {
                writer.WritePropertyName("container");
                JsonSerializer.Serialize(writer, Container);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ContainerNetworkInterface DeserializeContainerNetworkInterface(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<ContainerNetworkInterfaceConfiguration> containerNetworkInterfaceConfiguration = default;
            Optional<WritableSubResource> container = default;
            Optional<IReadOnlyList<ContainerNetworkInterfaceIPConfiguration>> ipConfigurations = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("containerNetworkInterfaceConfiguration"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            containerNetworkInterfaceConfiguration = ContainerNetworkInterfaceConfiguration.DeserializeContainerNetworkInterfaceConfiguration(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("container"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            container = JsonSerializer.Deserialize<WritableSubResource>(property0.Value.ToString());
                            continue;
                        }
                        if (property0.NameEquals("ipConfigurations"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ContainerNetworkInterfaceIPConfiguration> array = new List<ContainerNetworkInterfaceIPConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ContainerNetworkInterfaceIPConfiguration.DeserializeContainerNetworkInterfaceIPConfiguration(item));
                            }
                            ipConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ContainerNetworkInterface(id.Value, name.Value, type.Value, etag.Value, containerNetworkInterfaceConfiguration.Value, container, Optional.ToList(ipConfigurations), Optional.ToNullable(provisioningState));
        }
    }
}
