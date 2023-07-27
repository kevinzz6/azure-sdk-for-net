// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Identity.Models
{
    internal partial class TeamsUserExchangeTokenRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("token"u8);
            writer.WriteStringValue(Token);
            writer.WritePropertyName("appId"u8);
            writer.WriteStringValue(AppId);
            writer.WritePropertyName("userId"u8);
            writer.WriteStringValue(UserId);
            writer.WriteEndObject();
        }
    }
}
