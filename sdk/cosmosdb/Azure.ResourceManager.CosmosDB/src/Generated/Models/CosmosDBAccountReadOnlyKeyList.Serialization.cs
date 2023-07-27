// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBAccountReadOnlyKeyList
    {
        internal static CosmosDBAccountReadOnlyKeyList DeserializeCosmosDBAccountReadOnlyKeyList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> primaryReadonlyMasterKey = default;
            Optional<string> secondaryReadonlyMasterKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryReadonlyMasterKey"u8))
                {
                    primaryReadonlyMasterKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryReadonlyMasterKey"u8))
                {
                    secondaryReadonlyMasterKey = property.Value.GetString();
                    continue;
                }
            }
            return new CosmosDBAccountReadOnlyKeyList(primaryReadonlyMasterKey.Value, secondaryReadonlyMasterKey.Value);
        }
    }
}
