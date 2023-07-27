// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Pool change request. </summary>
    public partial class NetAppVolumePoolChangeContent
    {
        /// <summary> Initializes a new instance of NetAppVolumePoolChangeContent. </summary>
        /// <param name="newPoolResourceId"> Resource id of the pool to move volume to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="newPoolResourceId"/> is null. </exception>
        public NetAppVolumePoolChangeContent(ResourceIdentifier newPoolResourceId)
        {
            Argument.AssertNotNull(newPoolResourceId, nameof(newPoolResourceId));

            NewPoolResourceId = newPoolResourceId;
        }

        /// <summary> Resource id of the pool to move volume to. </summary>
        public ResourceIdentifier NewPoolResourceId { get; }
    }
}
