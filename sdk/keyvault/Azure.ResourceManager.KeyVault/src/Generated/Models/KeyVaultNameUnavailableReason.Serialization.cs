// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KeyVault.Models
{
    internal static partial class KeyVaultNameUnavailableReasonExtensions
    {
        public static string ToSerialString(this KeyVaultNameUnavailableReason value) => value switch
        {
            KeyVaultNameUnavailableReason.AccountNameInvalid => "AccountNameInvalid",
            KeyVaultNameUnavailableReason.AlreadyExists => "AlreadyExists",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyVaultNameUnavailableReason value.")
        };

        public static KeyVaultNameUnavailableReason ToKeyVaultNameUnavailableReason(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AccountNameInvalid")) return KeyVaultNameUnavailableReason.AccountNameInvalid;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AlreadyExists")) return KeyVaultNameUnavailableReason.AlreadyExists;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown KeyVaultNameUnavailableReason value.");
        }
    }
}
