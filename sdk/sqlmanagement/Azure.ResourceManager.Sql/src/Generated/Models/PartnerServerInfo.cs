// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Partner server information for the failover group. </summary>
    public partial class PartnerServerInfo
    {
        /// <summary> Initializes a new instance of PartnerServerInfo. </summary>
        /// <param name="id"> Resource identifier of the partner server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public PartnerServerInfo(ResourceIdentifier id)
        {
            Argument.AssertNotNull(id, nameof(id));

            Id = id;
        }

        /// <summary> Initializes a new instance of PartnerServerInfo. </summary>
        /// <param name="id"> Resource identifier of the partner server. </param>
        /// <param name="location"> Geo location of the partner server. </param>
        /// <param name="replicationRole"> Replication role of the partner server. </param>
        internal PartnerServerInfo(ResourceIdentifier id, AzureLocation? location, FailoverGroupReplicationRole? replicationRole)
        {
            Id = id;
            Location = location;
            ReplicationRole = replicationRole;
        }

        /// <summary> Resource identifier of the partner server. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> Geo location of the partner server. </summary>
        public AzureLocation? Location { get; }
        /// <summary> Replication role of the partner server. </summary>
        public FailoverGroupReplicationRole? ReplicationRole { get; }
    }
}
