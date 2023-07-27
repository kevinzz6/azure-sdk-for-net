// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    internal partial class SynapseWorkspaceListResult
    {
        internal static SynapseWorkspaceListResult DeserializeSynapseWorkspaceListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<SynapseWorkspaceData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseWorkspaceData> array = new List<SynapseWorkspaceData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseWorkspaceData.DeserializeSynapseWorkspaceData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SynapseWorkspaceListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
