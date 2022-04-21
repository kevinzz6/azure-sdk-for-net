// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Vpn Connection packet capture parameters supplied to stop packet capture on gateway connection. </summary>
    public partial class VpnConnectionPacketCaptureStopContent
    {
        /// <summary> Initializes a new instance of VpnConnectionPacketCaptureStopContent. </summary>
        public VpnConnectionPacketCaptureStopContent()
        {
            LinkConnectionNames = new ChangeTrackingList<string>();
        }

        /// <summary> SAS url for packet capture on vpn connection. </summary>
        public Uri SasUri { get; set; }
        /// <summary> List of site link connection names. </summary>
        public IList<string> LinkConnectionNames { get; }
    }
}
