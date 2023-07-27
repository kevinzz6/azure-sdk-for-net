// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class ServiceBusRuleData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Action))
            {
                writer.WritePropertyName("action"u8);
                writer.WriteObjectValue(Action);
            }
            if (Optional.IsDefined(FilterType))
            {
                writer.WritePropertyName("filterType"u8);
                writer.WriteStringValue(FilterType.Value.ToSerialString());
            }
            if (Optional.IsDefined(SqlFilter))
            {
                writer.WritePropertyName("sqlFilter"u8);
                writer.WriteObjectValue(SqlFilter);
            }
            if (Optional.IsDefined(CorrelationFilter))
            {
                writer.WritePropertyName("correlationFilter"u8);
                writer.WriteObjectValue(CorrelationFilter);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ServiceBusRuleData DeserializeServiceBusRuleData(JsonElement element)
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
            Optional<ServiceBusFilterAction> action = default;
            Optional<ServiceBusFilterType> filterType = default;
            Optional<ServiceBusSqlFilter> sqlFilter = default;
            Optional<ServiceBusCorrelationFilter> correlationFilter = default;
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
                        if (property0.NameEquals("action"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            action = ServiceBusFilterAction.DeserializeServiceBusFilterAction(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("filterType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            filterType = property0.Value.GetString().ToServiceBusFilterType();
                            continue;
                        }
                        if (property0.NameEquals("sqlFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sqlFilter = ServiceBusSqlFilter.DeserializeServiceBusSqlFilter(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("correlationFilter"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            correlationFilter = ServiceBusCorrelationFilter.DeserializeServiceBusCorrelationFilter(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ServiceBusRuleData(id, name, type, systemData.Value, action.Value, Optional.ToNullable(filterType), sqlFilter.Value, correlationFilter.Value, Optional.ToNullable(location));
        }
    }
}
