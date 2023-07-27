// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.ResourceHealth.Models;

namespace Azure.ResourceManager.ResourceHealth
{
    public partial class ResourceHealthEventImpactedResourceData
    {
        internal static ResourceHealthEventImpactedResourceData DeserializeResourceHealthEventImpactedResourceData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<ResourceType> targetResourceType = default;
            Optional<ResourceIdentifier> targetResourceId = default;
            Optional<string> targetRegion = default;
            Optional<IReadOnlyList<ResourceHealthKeyValueItem>> info = default;
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
                        if (property0.NameEquals("targetResourceType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceType = new ResourceType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            targetResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("targetRegion"u8))
                        {
                            targetRegion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("info"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceHealthKeyValueItem> array = new List<ResourceHealthKeyValueItem>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResourceHealthKeyValueItem.DeserializeResourceHealthKeyValueItem(item));
                            }
                            info = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ResourceHealthEventImpactedResourceData(id, name, type, systemData.Value, Optional.ToNullable(targetResourceType), targetResourceId.Value, targetRegion.Value, Optional.ToList(info));
        }
    }
}
