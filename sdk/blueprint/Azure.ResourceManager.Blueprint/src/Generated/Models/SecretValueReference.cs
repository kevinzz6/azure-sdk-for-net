// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Blueprint.Models
{
    /// <summary> Reference to a Key Vault secret. </summary>
    public partial class SecretValueReference
    {
        /// <summary> Initializes a new instance of SecretValueReference. </summary>
        /// <param name="keyVault"> Specifies the reference to a given Azure Key Vault. </param>
        /// <param name="secretName"> Name of the secret. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="keyVault"/> or <paramref name="secretName"/> is null. </exception>
        public SecretValueReference(WritableSubResource keyVault, string secretName)
        {
            Argument.AssertNotNull(keyVault, nameof(keyVault));
            Argument.AssertNotNull(secretName, nameof(secretName));

            KeyVault = keyVault;
            SecretName = secretName;
        }

        /// <summary> Initializes a new instance of SecretValueReference. </summary>
        /// <param name="keyVault"> Specifies the reference to a given Azure Key Vault. </param>
        /// <param name="secretName"> Name of the secret. </param>
        /// <param name="secretVersion"> The version of the secret to use. If left blank, the latest version of the secret is used. </param>
        internal SecretValueReference(WritableSubResource keyVault, string secretName, string secretVersion)
        {
            KeyVault = keyVault;
            SecretName = secretName;
            SecretVersion = secretVersion;
        }

        /// <summary> Specifies the reference to a given Azure Key Vault. </summary>
        internal WritableSubResource KeyVault { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier KeyVaultId
        {
            get => KeyVault is null ? default : KeyVault.Id;
            set
            {
                if (KeyVault is null)
                    KeyVault = new WritableSubResource();
                KeyVault.Id = value;
            }
        }

        /// <summary> Name of the secret. </summary>
        public string SecretName { get; set; }
        /// <summary> The version of the secret to use. If left blank, the latest version of the secret is used. </summary>
        public string SecretVersion { get; set; }
    }
}
