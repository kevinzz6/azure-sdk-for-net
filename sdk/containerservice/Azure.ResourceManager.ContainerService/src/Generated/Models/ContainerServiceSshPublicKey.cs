// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> Contains information about SSH certificate public key data. </summary>
    public partial class ContainerServiceSshPublicKey
    {
        /// <summary> Initializes a new instance of ContainerServiceSshPublicKey. </summary>
        /// <param name="keyData"> Certificate public key used to authenticate with VMs through SSH. The certificate must be in PEM format with or without headers. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyData"/> is null. </exception>
        public ContainerServiceSshPublicKey(string keyData)
        {
            Argument.AssertNotNull(keyData, nameof(keyData));

            KeyData = keyData;
        }

        /// <summary> Certificate public key used to authenticate with VMs through SSH. The certificate must be in PEM format with or without headers. </summary>
        public string KeyData { get; set; }
    }
}
