// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBasePolicyRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
            writer.WriteEndObject();
        }

        internal static DataProtectionBasePolicyRule DeserializeDataProtectionBasePolicyRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureBackupRule": return DataProtectionBackupRule.DeserializeDataProtectionBackupRule(element);
                    case "AzureRetentionRule": return DataProtectionRetentionRule.DeserializeDataProtectionRetentionRule(element);
                }
            }
            return UnknownBasePolicyRule.DeserializeUnknownBasePolicyRule(element);
        }
    }
}
