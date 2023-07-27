// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The VirtualNetworksPropertiesVipPoolItem. </summary>
    public partial class VirtualNetworksPropertiesVipPoolItem
    {
        /// <summary> Initializes a new instance of VirtualNetworksPropertiesVipPoolItem. </summary>
        public VirtualNetworksPropertiesVipPoolItem()
        {
        }

        /// <summary> Initializes a new instance of VirtualNetworksPropertiesVipPoolItem. </summary>
        /// <param name="endIP"> Ending IP address for the IP Pool. </param>
        /// <param name="startIP"> Starting IP address for the IP Pool. </param>
        internal VirtualNetworksPropertiesVipPoolItem(string endIP, string startIP)
        {
            EndIP = endIP;
            StartIP = startIP;
        }

        /// <summary> Ending IP address for the IP Pool. </summary>
        public string EndIP { get; set; }
        /// <summary> Starting IP address for the IP Pool. </summary>
        public string StartIP { get; set; }
    }
}
