// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.OperationalInsights.Models
{
    public partial class OperationalInsightsWorkspaceSharedKeys
    {
        internal static OperationalInsightsWorkspaceSharedKeys DeserializeOperationalInsightsWorkspaceSharedKeys(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primarySharedKey = default;
            Optional<string> secondarySharedKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primarySharedKey"u8))
                {
                    primarySharedKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondarySharedKey"u8))
                {
                    secondarySharedKey = property.Value.GetString();
                    continue;
                }
            }
            return new OperationalInsightsWorkspaceSharedKeys(primarySharedKey.Value, secondarySharedKey.Value);
        }
    }
}
