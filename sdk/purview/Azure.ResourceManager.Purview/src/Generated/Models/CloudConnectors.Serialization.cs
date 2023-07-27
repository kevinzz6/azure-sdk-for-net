// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Purview.Models
{
    internal partial class CloudConnectors : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WriteEndObject();
        }

        internal static CloudConnectors DeserializeCloudConnectors(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> awsExternalId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("awsExternalId"u8))
                {
                    awsExternalId = property.Value.GetString();
                    continue;
                }
            }
            return new CloudConnectors(awsExternalId.Value);
        }
    }
}
