// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.HybridData.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HybridData
{
    public partial class HybridDataServiceData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("state"u8);
            writer.WriteStringValue(State.ToSerialString());
            if (Optional.IsCollectionDefined(SupportedDataSinkTypes))
            {
                writer.WritePropertyName("supportedDataSinkTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedDataSinkTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(SupportedDataSourceTypes))
            {
                writer.WritePropertyName("supportedDataSourceTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedDataSourceTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static HybridDataServiceData DeserializeHybridDataServiceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            HybridDataState state = default;
            Optional<IList<string>> supportedDataSinkTypes = default;
            Optional<IList<string>> supportedDataSourceTypes = default;
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString().ToHybridDataState();
                            continue;
                        }
                        if (property0.NameEquals("supportedDataSinkTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            supportedDataSinkTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("supportedDataSourceTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            supportedDataSourceTypes = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new HybridDataServiceData(id, name, type, systemData.Value, state, Optional.ToList(supportedDataSinkTypes), Optional.ToList(supportedDataSourceTypes));
        }
    }
}
