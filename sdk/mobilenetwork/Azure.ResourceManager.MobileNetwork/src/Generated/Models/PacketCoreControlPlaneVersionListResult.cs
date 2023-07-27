// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.MobileNetwork;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    /// <summary> Response for packet core control plane version API service call. </summary>
    internal partial class PacketCoreControlPlaneVersionListResult
    {
        /// <summary> Initializes a new instance of PacketCoreControlPlaneVersionListResult. </summary>
        internal PacketCoreControlPlaneVersionListResult()
        {
            Value = new ChangeTrackingList<PacketCoreControlPlaneVersionData>();
        }

        /// <summary> Initializes a new instance of PacketCoreControlPlaneVersionListResult. </summary>
        /// <param name="value"> A list of supported packet core control plane versions. </param>
        /// <param name="nextLink"> The URL to get the next set of results. </param>
        internal PacketCoreControlPlaneVersionListResult(IReadOnlyList<PacketCoreControlPlaneVersionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> A list of supported packet core control plane versions. </summary>
        public IReadOnlyList<PacketCoreControlPlaneVersionData> Value { get; }
        /// <summary> The URL to get the next set of results. </summary>
        public string NextLink { get; }
    }
}
