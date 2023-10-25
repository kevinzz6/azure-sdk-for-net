// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Managed identity credential. </summary>
    public partial class ManagedIdentityCredential : Credential
    {
        /// <summary> Initializes a new instance of ManagedIdentityCredential. </summary>
        public ManagedIdentityCredential()
        {
            Type = "ManagedIdentity";
        }

        /// <summary> Initializes a new instance of ManagedIdentityCredential. </summary>
        /// <param name="type"> Type of credential. </param>
        /// <param name="description"> Credential description. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Credential. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="resourceId"> The resource id of user assigned managed identity. </param>
        internal ManagedIdentityCredential(string type, string description, IList<object> annotations, IDictionary<string, object> additionalProperties, string resourceId) : base(type, description, annotations, additionalProperties)
        {
            ResourceId = resourceId;
            Type = type ?? "ManagedIdentity";
        }

        /// <summary> The resource id of user assigned managed identity. </summary>
        public string ResourceId { get; set; }
    }
}
