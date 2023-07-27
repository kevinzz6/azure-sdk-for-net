// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> List of ProtectableContainer resources. </summary>
    internal partial class ProtectableContainerResourceList
    {
        /// <summary> Initializes a new instance of ProtectableContainerResourceList. </summary>
        internal ProtectableContainerResourceList()
        {
            Value = new ChangeTrackingList<ProtectableContainerResource>();
        }

        /// <summary> Initializes a new instance of ProtectableContainerResourceList. </summary>
        /// <param name="value"> List of resources. </param>
        /// <param name="nextLink"> The uri to fetch the next page of resources. </param>
        internal ProtectableContainerResourceList(IReadOnlyList<ProtectableContainerResource> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of resources. </summary>
        public IReadOnlyList<ProtectableContainerResource> Value { get; }
        /// <summary> The uri to fetch the next page of resources. </summary>
        public string NextLink { get; }
    }
}
