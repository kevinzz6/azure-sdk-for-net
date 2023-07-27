// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes the source of connection monitor. </summary>
    public partial class ConnectionMonitorSource
    {
        /// <summary> Initializes a new instance of ConnectionMonitorSource. </summary>
        /// <param name="resourceId"> The ID of the resource used as the source by connection monitor. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public ConnectionMonitorSource(ResourceIdentifier resourceId)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            ResourceId = resourceId;
        }

        /// <summary> Initializes a new instance of ConnectionMonitorSource. </summary>
        /// <param name="resourceId"> The ID of the resource used as the source by connection monitor. </param>
        /// <param name="port"> The source port used by connection monitor. </param>
        internal ConnectionMonitorSource(ResourceIdentifier resourceId, int? port)
        {
            ResourceId = resourceId;
            Port = port;
        }

        /// <summary> The ID of the resource used as the source by connection monitor. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The source port used by connection monitor. </summary>
        public int? Port { get; set; }
    }
}
