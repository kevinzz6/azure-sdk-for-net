// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing the HubIPConfiguration data model.
    /// IpConfigurations.
    /// </summary>
    public partial class HubIPConfigurationData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of HubIPConfigurationData. </summary>
        public HubIPConfigurationData()
        {
        }

        /// <summary> Initializes a new instance of HubIPConfigurationData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="privateIPAddress"> The private IP address of the IP configuration. </param>
        /// <param name="privateIPAllocationMethod"> The private IP address allocation method. </param>
        /// <param name="subnet"> The reference to the subnet resource. </param>
        /// <param name="publicIPAddress"> The reference to the public IP resource. </param>
        /// <param name="provisioningState"> The provisioning state of the IP configuration resource. </param>
        internal HubIPConfigurationData(ResourceIdentifier id, string name, ResourceType? resourceType, ETag? etag, string privateIPAddress, NetworkIPAllocationMethod? privateIPAllocationMethod, SubnetData subnet, PublicIPAddressData publicIPAddress, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            ETag = etag;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            Subnet = subnet;
            PublicIPAddress = publicIPAddress;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public ETag? ETag { get; }
        /// <summary> The private IP address of the IP configuration. </summary>
        public string PrivateIPAddress { get; set; }
        /// <summary> The private IP address allocation method. </summary>
        public NetworkIPAllocationMethod? PrivateIPAllocationMethod { get; set; }
        /// <summary> The reference to the subnet resource. </summary>
        public SubnetData Subnet { get; set; }
        /// <summary> The reference to the public IP resource. </summary>
        public PublicIPAddressData PublicIPAddress { get; set; }
        /// <summary> The provisioning state of the IP configuration resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
