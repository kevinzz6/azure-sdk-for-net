// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Purview.Models
{
    public partial class PurviewAccountEndpoint
    {
        internal static PurviewAccountEndpoint DeserializePurviewAccountEndpoint(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> catalog = default;
            Optional<string> guardian = default;
            Optional<string> scan = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("catalog"u8))
                {
                    catalog = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("guardian"u8))
                {
                    guardian = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scan"u8))
                {
                    scan = property.Value.GetString();
                    continue;
                }
            }
            return new PurviewAccountEndpoint(catalog.Value, guardian.Value, scan.Value);
        }
    }
}
