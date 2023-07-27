// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.WebPubSub.Models
{
    internal partial class PrivateLinkResourceList
    {
        internal static PrivateLinkResourceList DeserializePrivateLinkResourceList(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<WebPubSubPrivateLink>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<WebPubSubPrivateLink> array = new List<WebPubSubPrivateLink>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(WebPubSubPrivateLink.DeserializeWebPubSubPrivateLink(item));
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
            return new PrivateLinkResourceList(Optional.ToList(value), nextLink.Value);
        }
    }
}
