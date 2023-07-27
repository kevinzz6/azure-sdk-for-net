// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppContainers;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal partial class ContainerAppJobsCollection
    {
        internal static ContainerAppJobsCollection DeserializeContainerAppJobsCollection(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ContainerAppJobData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<ContainerAppJobData> array = new List<ContainerAppJobData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContainerAppJobData.DeserializeContainerAppJobData(item));
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
            return new ContainerAppJobsCollection(value, nextLink.Value);
        }
    }
}
