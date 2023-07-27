// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class KeyVaultNameAvailabilityResult
    {
        internal static KeyVaultNameAvailabilityResult DeserializeKeyVaultNameAvailabilityResult(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> nameAvailable = default;
            Optional<KeyVaultNameUnavailableReason> reason = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reason = property.Value.GetString().ToKeyVaultNameUnavailableReason();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new KeyVaultNameAvailabilityResult(Optional.ToNullable(nameAvailable), Optional.ToNullable(reason), message.Value);
        }
    }
}
