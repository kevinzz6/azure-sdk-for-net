// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary>
    /// The base definition of the custom setup.
    /// Please note <see cref="SynapseCustomSetupBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="SynapseCmdkeySetup"/>, <see cref="SynapseComponentSetup"/> and <see cref="SynapseEnvironmentVariableSetup"/>.
    /// </summary>
    public abstract partial class SynapseCustomSetupBase
    {
        /// <summary> Initializes a new instance of SynapseCustomSetupBase. </summary>
        protected SynapseCustomSetupBase()
        {
        }

        /// <summary> Initializes a new instance of SynapseCustomSetupBase. </summary>
        /// <param name="customSetupBaseType"> The type of custom setup. </param>
        internal SynapseCustomSetupBase(string customSetupBaseType)
        {
            CustomSetupBaseType = customSetupBaseType;
        }

        /// <summary> The type of custom setup. </summary>
        internal string CustomSetupBaseType { get; set; }
    }
}
