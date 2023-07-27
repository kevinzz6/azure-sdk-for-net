// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class ServiceBusNetworkRuleSetData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IsTrustedServiceAccessEnabled))
            {
                writer.WritePropertyName("trustedServiceAccessEnabled"u8);
                writer.WriteBooleanValue(IsTrustedServiceAccessEnabled.Value);
            }
            if (Optional.IsDefined(DefaultAction))
            {
                writer.WritePropertyName("defaultAction"u8);
                writer.WriteStringValue(DefaultAction.Value.ToString());
            }
            if (Optional.IsCollectionDefined(VirtualNetworkRules))
            {
                writer.WritePropertyName("virtualNetworkRules"u8);
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IPRules))
            {
                writer.WritePropertyName("ipRules"u8);
                writer.WriteStartArray();
                foreach (var item in IPRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServiceBusNetworkRuleSetData DeserializeServiceBusNetworkRuleSetData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<bool> trustedServiceAccessEnabled = default;
            Optional<ServiceBusNetworkRuleSetDefaultAction> defaultAction = default;
            Optional<IList<ServiceBusNetworkRuleSetVirtualNetworkRules>> virtualNetworkRules = default;
            Optional<IList<ServiceBusNetworkRuleSetIPRules>> ipRules = default;
            Optional<ServiceBusPublicNetworkAccessFlag> publicNetworkAccess = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("trustedServiceAccessEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            trustedServiceAccessEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultAction"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultAction = new ServiceBusNetworkRuleSetDefaultAction(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("virtualNetworkRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServiceBusNetworkRuleSetVirtualNetworkRules> array = new List<ServiceBusNetworkRuleSetVirtualNetworkRules>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceBusNetworkRuleSetVirtualNetworkRules.DeserializeServiceBusNetworkRuleSetVirtualNetworkRules(item));
                            }
                            virtualNetworkRules = array;
                            continue;
                        }
                        if (property0.NameEquals("ipRules"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ServiceBusNetworkRuleSetIPRules> array = new List<ServiceBusNetworkRuleSetIPRules>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ServiceBusNetworkRuleSetIPRules.DeserializeServiceBusNetworkRuleSetIPRules(item));
                            }
                            ipRules = array;
                            continue;
                        }
                        if (property0.NameEquals("publicNetworkAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            publicNetworkAccess = new ServiceBusPublicNetworkAccessFlag(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServiceBusNetworkRuleSetData(id, name, type, systemData.Value, Optional.ToNullable(trustedServiceAccessEnabled), Optional.ToNullable(defaultAction), Optional.ToList(virtualNetworkRules), Optional.ToList(ipRules), Optional.ToNullable(publicNetworkAccess), Optional.ToNullable(location));
        }
    }
}
