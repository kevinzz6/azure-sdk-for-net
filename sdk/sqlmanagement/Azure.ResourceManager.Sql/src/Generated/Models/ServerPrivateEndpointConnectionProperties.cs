// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of a private endpoint connection. </summary>
    public partial class ServerPrivateEndpointConnectionProperties
    {
        /// <summary> Initializes a new instance of ServerPrivateEndpointConnectionProperties. </summary>
        internal ServerPrivateEndpointConnectionProperties()
        {
            GroupIds = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of ServerPrivateEndpointConnectionProperties. </summary>
        /// <param name="privateEndpoint"> Private endpoint which the connection belongs to. </param>
        /// <param name="groupIds"> Group IDs. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> State of the private endpoint connection. </param>
        internal ServerPrivateEndpointConnectionProperties(WritableSubResource privateEndpoint, IReadOnlyList<string> groupIds, SqlPrivateLinkServiceConnectionStateProperty connectionState, SqlPrivateEndpointProvisioningState? provisioningState)
        {
            PrivateEndpoint = privateEndpoint;
            GroupIds = groupIds;
            ConnectionState = connectionState;
            ProvisioningState = provisioningState;
        }

        /// <summary> Private endpoint which the connection belongs to. </summary>
        internal WritableSubResource PrivateEndpoint { get; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier PrivateEndpointId
        {
            get => PrivateEndpoint?.Id;
        }

        /// <summary> Group IDs. </summary>
        public IReadOnlyList<string> GroupIds { get; }
        /// <summary> Connection state of the private endpoint connection. </summary>
        public SqlPrivateLinkServiceConnectionStateProperty ConnectionState { get; }
        /// <summary> State of the private endpoint connection. </summary>
        public SqlPrivateEndpointProvisioningState? ProvisioningState { get; }
    }
}
