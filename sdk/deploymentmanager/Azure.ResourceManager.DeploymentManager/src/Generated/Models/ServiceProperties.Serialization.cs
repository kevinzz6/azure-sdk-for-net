// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    public partial class ServiceProperties
    {
        internal static ServiceProperties DeserializeServiceProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string targetLocation = default;
            string targetSubscriptionId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("targetLocation"u8))
                {
                    targetLocation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetSubscriptionId"u8))
                {
                    targetSubscriptionId = property.Value.GetString();
                    continue;
                }
            }
            return new ServiceProperties(targetLocation, targetSubscriptionId);
        }
    }
}
