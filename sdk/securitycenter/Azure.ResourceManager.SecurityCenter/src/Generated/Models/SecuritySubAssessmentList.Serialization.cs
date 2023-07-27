// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    internal partial class SecuritySubAssessmentList
    {
        internal static SecuritySubAssessmentList DeserializeSecuritySubAssessmentList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<SecuritySubAssessmentData>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecuritySubAssessmentData> array = new List<SecuritySubAssessmentData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecuritySubAssessmentData.DeserializeSecuritySubAssessmentData(item));
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
            return new SecuritySubAssessmentList(Optional.ToList(value), nextLink.Value);
        }
    }
}
