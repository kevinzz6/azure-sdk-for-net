// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Security.KeyVault.Storage.Models
{
    /// <summary> The secret restore parameters. </summary>
    internal partial class StorageRestoreParameters
    {
        /// <summary> Initializes a new instance of StorageRestoreParameters. </summary>
        /// <param name="storageBundleBackup"> The backup blob associated with a storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="storageBundleBackup"/> is null. </exception>
        public StorageRestoreParameters(byte[] storageBundleBackup)
        {
            Argument.AssertNotNull(storageBundleBackup, nameof(storageBundleBackup));

            StorageBundleBackup = storageBundleBackup;
        }

        /// <summary> The backup blob associated with a storage account. </summary>
        public byte[] StorageBundleBackup { get; }
    }
}
