// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class AuthenticationDetailsProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
            writer.WriteEndObject();
        }

        internal static AuthenticationDetailsProperties DeserializeAuthenticationDetailsProperties(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("authenticationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "awsAssumeRole": return AwsAssumeRoleAuthenticationDetailsProperties.DeserializeAwsAssumeRoleAuthenticationDetailsProperties(element);
                    case "awsCreds": return AwsCredsAuthenticationDetailsProperties.DeserializeAwsCredsAuthenticationDetailsProperties(element);
                    case "gcpCredentials": return GcpCredentialsDetailsProperties.DeserializeGcpCredentialsDetailsProperties(element);
                }
            }
            return UnknownAuthenticationDetailsProperties.DeserializeUnknownAuthenticationDetailsProperties(element);
        }
    }
}
