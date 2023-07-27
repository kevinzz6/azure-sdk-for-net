// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchResourceEncryptionKey : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("keyVaultKeyName"u8);
            writer.WriteStringValue(KeyName);
            writer.WritePropertyName("keyVaultKeyVersion"u8);
            writer.WriteStringValue(KeyVersion);
            writer.WritePropertyName("keyVaultUri"u8);
            writer.WriteStringValue(_vaultUri);
            if (Optional.IsDefined(AccessCredentialsInternal))
            {
                writer.WritePropertyName("accessCredentials"u8);
                writer.WriteObjectValue(AccessCredentialsInternal);
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity"u8);
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
            writer.WriteEndObject();
        }

        internal static SearchResourceEncryptionKey DeserializeSearchResourceEncryptionKey(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string keyVaultKeyName = default;
            string keyVaultKeyVersion = default;
            string keyVaultUri = default;
            Optional<AzureActiveDirectoryApplicationCredentials> accessCredentials = default;
            Optional<SearchIndexerDataIdentity> identity = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("keyVaultKeyName"u8))
                {
                    keyVaultKeyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultKeyVersion"u8))
                {
                    keyVaultKeyVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keyVaultUri"u8))
                {
                    keyVaultUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("accessCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    accessCredentials = AzureActiveDirectoryApplicationCredentials.DeserializeAzureActiveDirectoryApplicationCredentials(property.Value);
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = SearchIndexerDataIdentity.DeserializeSearchIndexerDataIdentity(property.Value);
                    continue;
                }
            }
            return new SearchResourceEncryptionKey(keyVaultKeyName, keyVaultKeyVersion, keyVaultUri, accessCredentials.Value, identity.Value);
        }
    }
}
