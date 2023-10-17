// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.Messaging.EventGrid.Models;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class AcsRouterWorkerSelector
    {
        internal static AcsRouterWorkerSelector DeserializeAcsRouterWorkerSelector(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> key = default;
            Optional<AcsRouterLabelOperator> labelOperator = default;
            Optional<object> labelValue = default;
            Optional<float> ttlSeconds = default;
            Optional<AcsRouterWorkerSelectorState> state = default;
            Optional<DateTimeOffset> expirationTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("labelOperator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    labelOperator = new AcsRouterLabelOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("labelValue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    labelValue = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("ttlSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ttlSeconds = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new AcsRouterWorkerSelectorState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expirationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new AcsRouterWorkerSelector(key.Value, Optional.ToNullable(labelOperator), labelValue.Value, Optional.ToNullable(ttlSeconds), Optional.ToNullable(state), Optional.ToNullable(expirationTime));
        }
    }
}
