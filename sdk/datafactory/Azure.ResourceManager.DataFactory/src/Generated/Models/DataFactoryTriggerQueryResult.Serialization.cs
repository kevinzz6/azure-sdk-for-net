// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    internal partial class DataFactoryTriggerQueryResult
    {
        internal static DataFactoryTriggerQueryResult DeserializeDataFactoryTriggerQueryResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataFactoryTriggerData> value = default;
            Optional<string> continuationToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<DataFactoryTriggerData> array = new List<DataFactoryTriggerData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryTriggerData.DeserializeDataFactoryTriggerData(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("continuationToken"u8))
                {
                    continuationToken = property.Value.GetString();
                    continue;
                }
            }
            return new DataFactoryTriggerQueryResult(value, continuationToken.Value);
        }
    }
}
