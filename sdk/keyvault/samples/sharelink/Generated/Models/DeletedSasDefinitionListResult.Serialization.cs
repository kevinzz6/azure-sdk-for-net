// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    internal partial class DeletedSasDefinitionListResult
    {
        internal static DeletedSasDefinitionListResult DeserializeDeletedSasDefinitionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<DeletedSasDefinitionItem>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DeletedSasDefinitionItem> array = new List<DeletedSasDefinitionItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeletedSasDefinitionItem.DeserializeDeletedSasDefinitionItem(item));
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
            return new DeletedSasDefinitionListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}
