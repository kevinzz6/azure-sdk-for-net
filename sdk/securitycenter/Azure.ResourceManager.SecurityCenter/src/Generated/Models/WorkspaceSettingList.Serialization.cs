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
    internal partial class WorkspaceSettingList
    {
        internal static WorkspaceSettingList DeserializeWorkspaceSettingList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SecurityWorkspaceSettingData> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SecurityWorkspaceSettingData> array = new List<SecurityWorkspaceSettingData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SecurityWorkspaceSettingData.DeserializeSecurityWorkspaceSettingData(item));
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
            return new WorkspaceSettingList(value, nextLink.Value);
        }
    }
}
