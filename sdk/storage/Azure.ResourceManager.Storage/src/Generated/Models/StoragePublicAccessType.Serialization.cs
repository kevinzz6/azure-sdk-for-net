// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    internal static partial class StoragePublicAccessTypeExtensions
    {
        public static string ToSerialString(this StoragePublicAccessType value) => value switch
        {
            StoragePublicAccessType.None => "None",
            StoragePublicAccessType.Container => "Container",
            StoragePublicAccessType.Blob => "Blob",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StoragePublicAccessType value.")
        };

        public static StoragePublicAccessType ToStoragePublicAccessType(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "None")) return StoragePublicAccessType.None;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Container")) return StoragePublicAccessType.Container;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Blob")) return StoragePublicAccessType.Blob;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown StoragePublicAccessType value.");
        }
    }
}
