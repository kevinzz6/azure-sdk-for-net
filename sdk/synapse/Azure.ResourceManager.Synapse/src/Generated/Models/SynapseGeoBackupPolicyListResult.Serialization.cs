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
    internal partial class SynapseGeoBackupPolicyListResult
    {
        internal static SynapseGeoBackupPolicyListResult DeserializeSynapseGeoBackupPolicyListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SynapseGeoBackupPolicyData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SynapseGeoBackupPolicyData> array = new List<SynapseGeoBackupPolicyData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SynapseGeoBackupPolicyData.DeserializeSynapseGeoBackupPolicyData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new SynapseGeoBackupPolicyListResult(Optional.ToList(value));
        }
    }
}
