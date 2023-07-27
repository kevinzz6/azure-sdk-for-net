// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementLoggerPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(LoggerType))
            {
                writer.WritePropertyName("loggerType"u8);
                writer.WriteStringValue(LoggerType.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(Credentials))
            {
                writer.WritePropertyName("credentials"u8);
                writer.WriteStartObject();
                foreach (var item in Credentials)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(IsBuffered))
            {
                writer.WritePropertyName("isBuffered"u8);
                writer.WriteBooleanValue(IsBuffered.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
