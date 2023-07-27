// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class HciClusterNode
    {
        internal static HciClusterNode DeserializeHciClusterNode(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<float> id = default;
            Optional<WindowsServerSubscription> windowsServerSubscription = default;
            Optional<ClusterNodeType> nodeType = default;
            Optional<string> ehcResourceId = default;
            Optional<string> manufacturer = default;
            Optional<string> model = default;
            Optional<string> osName = default;
            Optional<string> osVersion = default;
            Optional<string> osDisplayVersion = default;
            Optional<string> serialNumber = default;
            Optional<float> coreCount = default;
            Optional<float> memoryInGiB = default;
            Optional<DateTimeOffset> lastLicensingTimestamp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("windowsServerSubscription"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsServerSubscription = new WindowsServerSubscription(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("nodeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nodeType = new ClusterNodeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ehcResourceId"u8))
                {
                    ehcResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("manufacturer"u8))
                {
                    manufacturer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("model"u8))
                {
                    model = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osName"u8))
                {
                    osName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osVersion"u8))
                {
                    osVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("osDisplayVersion"u8))
                {
                    osDisplayVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serialNumber"u8))
                {
                    serialNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("coreCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    coreCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("memoryInGiB"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    memoryInGiB = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("lastLicensingTimestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastLicensingTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new HciClusterNode(name.Value, Optional.ToNullable(id), Optional.ToNullable(windowsServerSubscription), Optional.ToNullable(nodeType), ehcResourceId.Value, manufacturer.Value, model.Value, osName.Value, osVersion.Value, osDisplayVersion.Value, serialNumber.Value, Optional.ToNullable(coreCount), Optional.ToNullable(memoryInGiB), Optional.ToNullable(lastLicensingTimestamp));
        }
    }
}
