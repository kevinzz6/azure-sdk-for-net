// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataBox.Models
{
    internal static partial class DataBoxAccessProtocolExtensions
    {
        public static string ToSerialString(this DataBoxAccessProtocol value) => value switch
        {
            DataBoxAccessProtocol.Smb => "SMB",
            DataBoxAccessProtocol.Nfs => "NFS",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataBoxAccessProtocol value.")
        };

        public static DataBoxAccessProtocol ToDataBoxAccessProtocol(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "SMB")) return DataBoxAccessProtocol.Smb;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NFS")) return DataBoxAccessProtocol.Nfs;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown DataBoxAccessProtocol value.");
        }
    }
}
