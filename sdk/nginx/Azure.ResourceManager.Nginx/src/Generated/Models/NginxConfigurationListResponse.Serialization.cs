// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Nginx;

namespace Azure.ResourceManager.Nginx.Models
{
    internal partial class NginxConfigurationListResponse
    {
        internal static NginxConfigurationListResponse DeserializeNginxConfigurationListResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<NginxConfigurationData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NginxConfigurationData> array = new List<NginxConfigurationData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NginxConfigurationData.DeserializeNginxConfigurationData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new NginxConfigurationListResponse(Optional.ToList(value), nextLink.Value);
        }
    }
}
