// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary>
    /// Gets or sets the resource settings.
    /// Please note <see cref="MoverResourceSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MoverAvailabilitySetResourceSettings"/>, <see cref="DiskEncryptionSetResourceSettings"/>, <see cref="VirtualMachineResourceSettings"/>, <see cref="KeyVaultResourceSettings"/>, <see cref="LoadBalancerResourceSettings"/>, <see cref="NetworkInterfaceResourceSettings"/>, <see cref="NetworkSecurityGroupResourceSettings"/>, <see cref="PublicIPAddressResourceSettings"/>, <see cref="MoverVirtualNetworkResourceSettings"/>, <see cref="SqlServerResourceSettings"/>, <see cref="SqlDatabaseResourceSettings"/>, <see cref="SqlElasticPoolResourceSettings"/> and <see cref="ResourceGroupResourceSettings"/>.
    /// </summary>
    public abstract partial class MoverResourceSettings
    {
        /// <summary> Initializes a new instance of MoverResourceSettings. </summary>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceName"/> is null. </exception>
        protected MoverResourceSettings(string targetResourceName)
        {
            Argument.AssertNotNull(targetResourceName, nameof(targetResourceName));

            TargetResourceName = targetResourceName;
        }

        /// <summary> Initializes a new instance of MoverResourceSettings. </summary>
        /// <param name="resourceType"> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </param>
        /// <param name="targetResourceName"> Gets or sets the target Resource name. </param>
        internal MoverResourceSettings(string resourceType, string targetResourceName)
        {
            ResourceType = resourceType;
            TargetResourceName = targetResourceName;
        }

        /// <summary> The resource type. For example, the value can be Microsoft.Compute/virtualMachines. </summary>
        internal string ResourceType { get; set; }
        /// <summary> Gets or sets the target Resource name. </summary>
        public string TargetResourceName { get; set; }
    }
}
