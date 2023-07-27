// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Analysis.Models
{
    internal partial class NewResourceResultSkuEnumeration
    {
        internal static NewResourceResultSkuEnumeration DeserializeNewResourceResultSkuEnumeration(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<AnalysisResourceSku>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AnalysisResourceSku> array = new List<AnalysisResourceSku>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AnalysisResourceSku.DeserializeAnalysisResourceSku(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new NewResourceResultSkuEnumeration(Optional.ToList(value));
        }
    }
}
