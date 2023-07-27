// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PostgreSql;

namespace Azure.ResourceManager.PostgreSql.Models
{
    internal partial class PostgreSqlServerAdministratorListResult
    {
        internal static PostgreSqlServerAdministratorListResult DeserializePostgreSqlServerAdministratorListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<PostgreSqlServerAdministratorData>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PostgreSqlServerAdministratorData> array = new List<PostgreSqlServerAdministratorData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PostgreSqlServerAdministratorData.DeserializePostgreSqlServerAdministratorData(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new PostgreSqlServerAdministratorListResult(Optional.ToList(value));
        }
    }
}
