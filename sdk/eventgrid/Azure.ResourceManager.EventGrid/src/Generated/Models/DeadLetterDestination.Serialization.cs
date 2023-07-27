// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class DeadLetterDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("endpointType"u8);
            writer.WriteStringValue(EndpointType.ToString());
            writer.WriteEndObject();
        }

        internal static DeadLetterDestination DeserializeDeadLetterDestination(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("endpointType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "StorageBlob": return StorageBlobDeadLetterDestination.DeserializeStorageBlobDeadLetterDestination(element);
                }
            }
            return UnknownDeadLetterDestination.DeserializeUnknownDeadLetterDestination(element);
        }
    }
}
