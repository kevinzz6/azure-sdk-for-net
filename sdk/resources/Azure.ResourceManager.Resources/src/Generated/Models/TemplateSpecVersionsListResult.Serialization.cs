// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    internal partial class TemplateSpecVersionsListResult
    {
        internal static TemplateSpecVersionsListResult DeserializeTemplateSpecVersionsListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<TemplateSpecVersionData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<TemplateSpecVersionData> array = new List<TemplateSpecVersionData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TemplateSpecVersionData.DeserializeTemplateSpecVersionData(item));
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
            return new TemplateSpecVersionsListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
