// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Network sibling set query. </summary>
    public partial class QueryNetworkSiblingSetContent
    {
        /// <summary> Initializes a new instance of QueryNetworkSiblingSetContent. </summary>
        /// <param name="networkSiblingSetId"> Network Sibling Set ID for a group of volumes sharing networking resources in a subnet. </param>
        /// <param name="subnetId"> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. Example /subscriptions/subscriptionId/resourceGroups/resourceGroup/providers/Microsoft.Network/virtualNetworks/testVnet/subnets/{mySubnet}. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="networkSiblingSetId"/> or <paramref name="subnetId"/> is null. </exception>
        public QueryNetworkSiblingSetContent(string networkSiblingSetId, ResourceIdentifier subnetId)
        {
            Argument.AssertNotNull(networkSiblingSetId, nameof(networkSiblingSetId));
            Argument.AssertNotNull(subnetId, nameof(subnetId));

            NetworkSiblingSetId = networkSiblingSetId;
            SubnetId = subnetId;
        }

        /// <summary> Network Sibling Set ID for a group of volumes sharing networking resources in a subnet. </summary>
        public string NetworkSiblingSetId { get; }
        /// <summary> The Azure Resource URI for a delegated subnet. Must have the delegation Microsoft.NetApp/volumes. Example /subscriptions/subscriptionId/resourceGroups/resourceGroup/providers/Microsoft.Network/virtualNetworks/testVnet/subnets/{mySubnet}. </summary>
        public ResourceIdentifier SubnetId { get; }
    }
}
