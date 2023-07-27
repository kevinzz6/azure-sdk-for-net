// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    public partial class ContainerState
    {
        internal static ContainerState DeserializeContainerState(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> state = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<int> exitCode = default;
            Optional<DateTimeOffset> finishTime = default;
            Optional<string> detailStatus = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    state = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("exitCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    exitCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("finishTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    finishTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("detailStatus"u8))
                {
                    detailStatus = property.Value.GetString();
                    continue;
                }
            }
            return new ContainerState(state.Value, Optional.ToNullable(startTime), Optional.ToNullable(exitCode), Optional.ToNullable(finishTime), detailStatus.Value);
        }
    }
}
