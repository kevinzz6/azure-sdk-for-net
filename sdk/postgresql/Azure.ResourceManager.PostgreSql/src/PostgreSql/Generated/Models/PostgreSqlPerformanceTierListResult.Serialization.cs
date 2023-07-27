// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.Models
{
    internal partial class PostgreSqlPerformanceTierListResult
    {
        internal static PostgreSqlPerformanceTierListResult DeserializePostgreSqlPerformanceTierListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PostgreSqlPerformanceTierProperties>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlPerformanceTierProperties> array = new List<PostgreSqlPerformanceTierProperties>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlPerformanceTierProperties.DeserializePostgreSqlPerformanceTierProperties(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PostgreSqlPerformanceTierListResult(Optional.ToList(value));
        }
    }
}
