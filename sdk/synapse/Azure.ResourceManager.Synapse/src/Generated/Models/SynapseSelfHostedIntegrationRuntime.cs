// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Self-hosted integration runtime. </summary>
    public partial class SynapseSelfHostedIntegrationRuntime : SynapseIntegrationRuntimeProperties
    {
        /// <summary> Initializes a new instance of SynapseSelfHostedIntegrationRuntime. </summary>
        public SynapseSelfHostedIntegrationRuntime()
        {
            IntegrationRuntimeType = IntegrationRuntimeType.SelfHosted;
        }

        /// <summary> Initializes a new instance of SynapseSelfHostedIntegrationRuntime. </summary>
        /// <param name="integrationRuntimeType"> Type of integration runtime. </param>
        /// <param name="description"> Integration runtime description. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedInfo">
        /// Linked integration runtime type from data factory
        /// Please note <see cref="SynapseLinkedIntegrationRuntimeType"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseLinkedIntegrationRuntimeKeyAuthorization"/> and <see cref="SynapseLinkedIntegrationRuntimeRbacAuthorization"/>.
        /// </param>
        internal SynapseSelfHostedIntegrationRuntime(IntegrationRuntimeType integrationRuntimeType, string description, IDictionary<string, BinaryData> additionalProperties, SynapseLinkedIntegrationRuntimeType linkedInfo) : base(integrationRuntimeType, description, additionalProperties)
        {
            LinkedInfo = linkedInfo;
            IntegrationRuntimeType = integrationRuntimeType;
        }

        /// <summary>
        /// Linked integration runtime type from data factory
        /// Please note <see cref="SynapseLinkedIntegrationRuntimeType"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SynapseLinkedIntegrationRuntimeKeyAuthorization"/> and <see cref="SynapseLinkedIntegrationRuntimeRbacAuthorization"/>.
        /// </summary>
        public SynapseLinkedIntegrationRuntimeType LinkedInfo { get; set; }
    }
}
