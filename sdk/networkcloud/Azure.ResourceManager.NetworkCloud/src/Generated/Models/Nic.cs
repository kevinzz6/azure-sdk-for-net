// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.NetworkCloud.Models
{
    /// <summary> Type Deprecated. Will be removed in an upcoming version. Nic represents the network interface card details. </summary>
    public partial class Nic
    {
        /// <summary> Initializes a new instance of Nic. </summary>
        internal Nic()
        {
        }

        /// <summary> Initializes a new instance of Nic. </summary>
        /// <param name="lldpNeighbor"> The information about the device connected to this NIC. </param>
        /// <param name="macAddress"> The MAC address associated with this NIC. </param>
        /// <param name="name"> The name of the NIC/interface. </param>
        internal Nic(LldpNeighbor lldpNeighbor, string macAddress, string name)
        {
            LldpNeighbor = lldpNeighbor;
            MacAddress = macAddress;
            Name = name;
        }

        /// <summary> The information about the device connected to this NIC. </summary>
        public LldpNeighbor LldpNeighbor { get; }
        /// <summary> The MAC address associated with this NIC. </summary>
        public string MacAddress { get; }
        /// <summary> The name of the NIC/interface. </summary>
        public string Name { get; }
    }
}
