// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    public partial class SynapseSensitivityLabelUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Op))
            {
                writer.WritePropertyName("op"u8);
                writer.WriteStringValue(Op.Value.ToSerialString());
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteStringValue(Schema);
            }
            if (Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table"u8);
                writer.WriteStringValue(Table);
            }
            if (Optional.IsDefined(Column))
            {
                writer.WritePropertyName("column"u8);
                writer.WriteStringValue(Column);
            }
            if (Optional.IsDefined(SensitivityLabel))
            {
                writer.WritePropertyName("sensitivityLabel"u8);
                writer.WriteObjectValue(SensitivityLabel);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SynapseSensitivityLabelUpdate DeserializeSynapseSensitivityLabelUpdate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SynapseSensitivityLabelUpdateKind> op = default;
            Optional<string> schema = default;
            Optional<string> table = default;
            Optional<string> column = default;
            Optional<SynapseSensitivityLabelData> sensitivityLabel = default;
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
                        if (property0.NameEquals("op"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            op = property0.Value.GetString().ToSynapseSensitivityLabelUpdateKind();
                            continue;
                        }
                        if (property0.NameEquals("schema"u8))
                        {
                            schema = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("table"u8))
                        {
                            table = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("column"u8))
                        {
                            column = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sensitivityLabel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sensitivityLabel = SynapseSensitivityLabelData.DeserializeSynapseSensitivityLabelData(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SynapseSensitivityLabelUpdate(id, name, type, systemData.Value, Optional.ToNullable(op), schema.Value, table.Value, column.Value, sensitivityLabel.Value);
        }
    }
}
