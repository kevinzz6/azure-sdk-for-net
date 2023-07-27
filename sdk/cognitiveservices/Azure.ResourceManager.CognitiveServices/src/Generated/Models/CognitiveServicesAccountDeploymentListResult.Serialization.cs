// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.CognitiveServices;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    internal partial class CognitiveServicesAccountDeploymentListResult
    {
        internal static CognitiveServicesAccountDeploymentListResult DeserializeCognitiveServicesAccountDeploymentListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nextLink = default;
            Optional<IReadOnlyList<CognitiveServicesAccountDeploymentData>> value = default;
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
                    List<CognitiveServicesAccountDeploymentData> array = new List<CognitiveServicesAccountDeploymentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CognitiveServicesAccountDeploymentData.DeserializeCognitiveServicesAccountDeploymentData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CognitiveServicesAccountDeploymentListResult(nextLink.Value, Optional.ToList(value));
        }
    }
}
