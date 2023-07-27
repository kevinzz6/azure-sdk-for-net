// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    public partial class NetAppSubvolumeMetadata
    {
        internal static NetAppSubvolumeMetadata DeserializeNetAppSubvolumeMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> path = default;
            Optional<string> parentPath = default;
            Optional<long> size = default;
            Optional<long> bytesUsed = default;
            Optional<string> permissions = default;
            Optional<DateTimeOffset> creationTimeStamp = default;
            Optional<DateTimeOffset> accessedTimeStamp = default;
            Optional<DateTimeOffset> modifiedTimeStamp = default;
            Optional<DateTimeOffset> changedTimeStamp = default;
            Optional<string> provisioningState = default;
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
                        if (property0.NameEquals("path"u8))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parentPath"u8))
                        {
                            parentPath = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("size"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            size = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("bytesUsed"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bytesUsed = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("permissions"u8))
                        {
                            permissions = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("accessedTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessedTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("modifiedTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            modifiedTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("changedTimeStamp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            changedTimeStamp = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetAppSubvolumeMetadata(id, name, type, systemData.Value, path.Value, parentPath.Value, Optional.ToNullable(size), Optional.ToNullable(bytesUsed), permissions.Value, Optional.ToNullable(creationTimeStamp), Optional.ToNullable(accessedTimeStamp), Optional.ToNullable(modifiedTimeStamp), Optional.ToNullable(changedTimeStamp), provisioningState.Value);
        }
    }
}
