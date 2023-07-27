// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerCapabilityProperties
    {
        internal static MySqlFlexibleServerCapabilityProperties DeserializeMySqlFlexibleServerCapabilityProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> zone = default;
            Optional<IReadOnlyList<string>> supportedHAMode = default;
            Optional<IReadOnlyList<string>> supportedGeoBackupRegions = default;
            Optional<IReadOnlyList<MySqlFlexibleServerEditionCapability>> supportedFlexibleServerEditions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("zone"u8))
                {
                    zone = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedHAMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedHAMode = array;
                    continue;
                }
                if (property.NameEquals("supportedGeoBackupRegions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    supportedGeoBackupRegions = array;
                    continue;
                }
                if (property.NameEquals("supportedFlexibleServerEditions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MySqlFlexibleServerEditionCapability> array = new List<MySqlFlexibleServerEditionCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MySqlFlexibleServerEditionCapability.DeserializeMySqlFlexibleServerEditionCapability(item));
                    }
                    supportedFlexibleServerEditions = array;
                    continue;
                }
            }
            return new MySqlFlexibleServerCapabilityProperties(zone.Value, Optional.ToList(supportedHAMode), Optional.ToList(supportedGeoBackupRegions), Optional.ToList(supportedFlexibleServerEditions));
        }
    }
}
