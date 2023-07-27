// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    internal partial class MetricDefinitionListResult
    {
        internal static MetricDefinitionListResult DeserializeMetricDefinitionListResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<SqlMetricDefinition> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<SqlMetricDefinition> array = new List<SqlMetricDefinition>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlMetricDefinition.DeserializeSqlMetricDefinition(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new MetricDefinitionListResult(value);
        }
    }
}
