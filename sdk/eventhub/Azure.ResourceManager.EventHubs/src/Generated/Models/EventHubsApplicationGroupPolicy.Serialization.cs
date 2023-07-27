// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EventHubsApplicationGroupPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ApplicationGroupPolicyType.ToString());
            writer.WriteEndObject();
        }

        internal static EventHubsApplicationGroupPolicy DeserializeEventHubsApplicationGroupPolicy(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "ThrottlingPolicy": return EventHubsThrottlingPolicy.DeserializeEventHubsThrottlingPolicy(element);
                }
            }
            return UnknownEventHubsApplicationGroupPolicy.DeserializeUnknownEventHubsApplicationGroupPolicy(element);
        }
    }
}
