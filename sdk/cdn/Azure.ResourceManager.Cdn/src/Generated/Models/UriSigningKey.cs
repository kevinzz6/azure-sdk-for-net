// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Url signing key. </summary>
    public partial class UriSigningKey
    {
        /// <summary> Initializes a new instance of UriSigningKey. </summary>
        /// <param name="keyId"> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </param>
        /// <param name="keySourceParameters"> Defines the parameters for using customer key vault for Url Signing Key. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyId"/> or <paramref name="keySourceParameters"/> is null. </exception>
        public UriSigningKey(string keyId, KeyVaultSigningKey keySourceParameters)
        {
            Argument.AssertNotNull(keyId, nameof(keyId));
            Argument.AssertNotNull(keySourceParameters, nameof(keySourceParameters));

            KeyId = keyId;
            KeySourceParameters = keySourceParameters;
        }

        /// <summary> Defines the customer defined key Id. This id will exist in the incoming request to indicate the key used to form the hash. </summary>
        public string KeyId { get; set; }
        /// <summary> Defines the parameters for using customer key vault for Url Signing Key. </summary>
        public KeyVaultSigningKey KeySourceParameters { get; set; }
    }
}
