// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabNotificationChannelNotifyContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EventName))
            {
                writer.WritePropertyName("eventName"u8);
                writer.WriteStringValue(EventName.Value.ToString());
            }
            if (Optional.IsDefined(JsonPayload))
            {
                writer.WritePropertyName("jsonPayload"u8);
                writer.WriteStringValue(JsonPayload);
            }
            writer.WriteEndObject();
        }
    }
}
