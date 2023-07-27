// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class CsmPublishingProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteStringValue(Format.Value.ToString());
            }
            if (Optional.IsDefined(IsIncludeDisasterRecoveryEndpoints))
            {
                writer.WritePropertyName("includeDisasterRecoveryEndpoints"u8);
                writer.WriteBooleanValue(IsIncludeDisasterRecoveryEndpoints.Value);
            }
            writer.WriteEndObject();
        }
    }
}
