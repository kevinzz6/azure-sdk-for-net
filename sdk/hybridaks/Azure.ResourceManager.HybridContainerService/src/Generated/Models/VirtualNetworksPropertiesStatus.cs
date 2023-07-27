// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> HybridAKSNetworkStatus defines the observed state of HybridAKSNetwork. </summary>
    internal partial class VirtualNetworksPropertiesStatus
    {
        /// <summary> Initializes a new instance of VirtualNetworksPropertiesStatus. </summary>
        internal VirtualNetworksPropertiesStatus()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworksPropertiesStatus. </summary>
        /// <param name="provisioningStatus"> Contains Provisioning errors. </param>
        internal VirtualNetworksPropertiesStatus(VirtualNetworksPropertiesStatusProvisioningStatus provisioningStatus)
        {
            ProvisioningStatus = provisioningStatus;
        }

        /// <summary> Contains Provisioning errors. </summary>
        public VirtualNetworksPropertiesStatusProvisioningStatus ProvisioningStatus { get; }
    }
}
