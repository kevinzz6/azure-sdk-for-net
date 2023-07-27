// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class InstancesOperationResult
    {
        internal static InstancesOperationResult DeserializeInstancesOperationResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSeriesInstance> instance = default;
            Optional<TimeSeriesOperationError> error = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("instance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instance = TimeSeriesInstance.DeserializeTimeSeriesInstance(property.Value);
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = TimeSeriesOperationError.DeserializeTimeSeriesOperationError(property.Value);
                    continue;
                }
            }
            return new InstancesOperationResult(instance.Value, error.Value);
        }
    }
}
