// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.Shares.Models
{
    internal static partial class ShareRootSquashExtensions
    {
        public static string ToSerialString(this ShareRootSquash value) => value switch
        {
            ShareRootSquash.NoRootSquash => "NoRootSquash",
            ShareRootSquash.RootSquash => "RootSquash",
            ShareRootSquash.AllSquash => "AllSquash",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ShareRootSquash value.")
        };

        public static ShareRootSquash ToShareRootSquash(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NoRootSquash")) return ShareRootSquash.NoRootSquash;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "RootSquash")) return ShareRootSquash.RootSquash;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "AllSquash")) return ShareRootSquash.AllSquash;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown ShareRootSquash value.");
        }
    }
}
