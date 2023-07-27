// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary>
    /// The base definition of a secret type.
    /// Please note <see cref="SynapseSecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SynapseSecureString"/>.
    /// </summary>
    public abstract partial class SynapseSecretBase
    {
        /// <summary> Initializes a new instance of SynapseSecretBase. </summary>
        protected SynapseSecretBase()
        {
        }

        /// <summary> Initializes a new instance of SynapseSecretBase. </summary>
        /// <param name="secretBaseType"> Type of the secret. </param>
        internal SynapseSecretBase(string secretBaseType)
        {
            SecretBaseType = secretBaseType;
        }

        /// <summary> Type of the secret. </summary>
        internal string SecretBaseType { get; set; }
    }
}
