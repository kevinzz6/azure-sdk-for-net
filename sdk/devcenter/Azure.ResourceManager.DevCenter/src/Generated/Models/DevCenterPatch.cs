// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> The devcenter resource for partial updates. Properties not provided in the update request will not be changed. </summary>
    public partial class DevCenterPatch : DevCenterTrackedResourceUpdate
    {
        /// <summary> Initializes a new instance of DevCenterPatch. </summary>
        public DevCenterPatch()
        {
        }

        /// <summary> Managed identity properties. </summary>
        public ManagedServiceIdentity Identity { get; set; }
    }
}
