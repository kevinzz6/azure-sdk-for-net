// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.MobileNetwork
{
    /// <summary>
    /// A class representing the Slice data model.
    /// Network slice resource. Must be created in the same location as its parent mobile network.
    /// </summary>
    public partial class SliceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of SliceData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="snssai"> Single-network slice selection assistance information (S-NSSAI). Unique at the scope of a mobile network. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="snssai"/> is null. </exception>
        public SliceData(AzureLocation location, Snssai snssai) : base(location)
        {
            Argument.AssertNotNull(snssai, nameof(snssai));

            Snssai = snssai;
        }

        /// <summary> Initializes a new instance of SliceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> The provisioning state of the network slice resource. </param>
        /// <param name="snssai"> Single-network slice selection assistance information (S-NSSAI). Unique at the scope of a mobile network. </param>
        /// <param name="description"> An optional description for this network slice. </param>
        internal SliceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ProvisioningState? provisioningState, Snssai snssai, string description) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            Snssai = snssai;
            Description = description;
        }

        /// <summary> The provisioning state of the network slice resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> Single-network slice selection assistance information (S-NSSAI). Unique at the scope of a mobile network. </summary>
        public Snssai Snssai { get; set; }
        /// <summary> An optional description for this network slice. </summary>
        public string Description { get; set; }
    }
}
