// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> IoT Addon. </summary>
    public partial class EdgeIotAddon : DataBoxEdgeRoleAddonData
    {
        /// <summary> Initializes a new instance of EdgeIotAddon. </summary>
        /// <param name="iotDeviceDetails"> IoT device metadata to which appliance needs to be connected. </param>
        /// <param name="iotEdgeDeviceDetails"> IoT edge device to which the IoT Addon needs to be configured. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="iotDeviceDetails"/> or <paramref name="iotEdgeDeviceDetails"/> is null. </exception>
        public EdgeIotAddon(EdgeIotDeviceInfo iotDeviceDetails, EdgeIotDeviceInfo iotEdgeDeviceDetails)
        {
            Argument.AssertNotNull(iotDeviceDetails, nameof(iotDeviceDetails));
            Argument.AssertNotNull(iotEdgeDeviceDetails, nameof(iotEdgeDeviceDetails));

            IotDeviceDetails = iotDeviceDetails;
            IotEdgeDeviceDetails = iotEdgeDeviceDetails;
            Kind = AddonType.IotEdge;
        }

        /// <summary> Initializes a new instance of EdgeIotAddon. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Addon type. </param>
        /// <param name="iotDeviceDetails"> IoT device metadata to which appliance needs to be connected. </param>
        /// <param name="iotEdgeDeviceDetails"> IoT edge device to which the IoT Addon needs to be configured. </param>
        /// <param name="version"> Version of IoT running on the appliance. </param>
        /// <param name="hostPlatform"> Host OS supported by the IoT addon. </param>
        /// <param name="hostPlatformType"> Platform where the runtime is hosted. </param>
        /// <param name="provisioningState"> Addon Provisioning State. </param>
        internal EdgeIotAddon(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AddonType kind, EdgeIotDeviceInfo iotDeviceDetails, EdgeIotDeviceInfo iotEdgeDeviceDetails, string version, DataBoxEdgeOSPlatformType? hostPlatform, HostPlatformType? hostPlatformType, DataBoxEdgeRoleAddonProvisioningState? provisioningState) : base(id, name, resourceType, systemData, kind)
        {
            IotDeviceDetails = iotDeviceDetails;
            IotEdgeDeviceDetails = iotEdgeDeviceDetails;
            Version = version;
            HostPlatform = hostPlatform;
            HostPlatformType = hostPlatformType;
            ProvisioningState = provisioningState;
            Kind = kind;
        }

        /// <summary> IoT device metadata to which appliance needs to be connected. </summary>
        public EdgeIotDeviceInfo IotDeviceDetails { get; set; }
        /// <summary> IoT edge device to which the IoT Addon needs to be configured. </summary>
        public EdgeIotDeviceInfo IotEdgeDeviceDetails { get; set; }
        /// <summary> Version of IoT running on the appliance. </summary>
        public string Version { get; }
        /// <summary> Host OS supported by the IoT addon. </summary>
        public DataBoxEdgeOSPlatformType? HostPlatform { get; }
        /// <summary> Platform where the runtime is hosted. </summary>
        public HostPlatformType? HostPlatformType { get; }
        /// <summary> Addon Provisioning State. </summary>
        public DataBoxEdgeRoleAddonProvisioningState? ProvisioningState { get; }
    }
}
