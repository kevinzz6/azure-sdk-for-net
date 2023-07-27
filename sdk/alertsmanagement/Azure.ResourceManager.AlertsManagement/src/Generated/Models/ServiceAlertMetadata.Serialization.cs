// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertMetadata
    {
        internal static ServiceAlertMetadata DeserializeServiceAlertMetadata(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ServiceAlertMetadataProperties> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    properties = ServiceAlertMetadataProperties.DeserializeServiceAlertMetadataProperties(property.Value);
                    continue;
                }
            }
            return new ServiceAlertMetadata(properties.Value);
        }
    }
}
