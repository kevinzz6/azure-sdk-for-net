// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Marketplace.Models
{
    internal partial class SubscriptionsResponse
    {
        internal static SubscriptionsResponse DeserializeSubscriptionsResponse(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<MarketplaceSubscription>> value = default;
            Optional<string> skipToken = default;
            Optional<long> count = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MarketplaceSubscription> array = new List<MarketplaceSubscription>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MarketplaceSubscription.DeserializeMarketplaceSubscription(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("skipToken"u8))
                {
                    skipToken = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetInt64();
                    continue;
                }
            }
            return new SubscriptionsResponse(Optional.ToList(value), skipToken.Value, Optional.ToNullable(count));
        }
    }
}
