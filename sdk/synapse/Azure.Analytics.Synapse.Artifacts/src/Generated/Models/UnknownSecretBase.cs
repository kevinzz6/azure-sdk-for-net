// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The UnknownSecretBase. </summary>
    internal partial class UnknownSecretBase : SecretBase
    {
        /// <summary> Initializes a new instance of UnknownSecretBase. </summary>
        /// <param name="type"> Type of the secret. </param>
        internal UnknownSecretBase(string type) : base(type)
        {
            Type = type ?? "Unknown";
        }
    }
}
