// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> Details about the connection between the Batch service and the endpoint. </summary>
    public partial class DevCenterEndpointDetail
    {
        /// <summary> Initializes a new instance of DevCenterEndpointDetail. </summary>
        internal DevCenterEndpointDetail()
        {
        }

        /// <summary> Initializes a new instance of DevCenterEndpointDetail. </summary>
        /// <param name="port"> The port an endpoint is connected to. </param>
        internal DevCenterEndpointDetail(int? port)
        {
            Port = port;
        }

        /// <summary> The port an endpoint is connected to. </summary>
        public int? Port { get; }
    }
}
