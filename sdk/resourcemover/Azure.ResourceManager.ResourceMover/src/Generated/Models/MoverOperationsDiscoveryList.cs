// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Collection of ClientDiscovery details. </summary>
    internal partial class MoverOperationsDiscoveryList
    {
        /// <summary> Initializes a new instance of MoverOperationsDiscoveryList. </summary>
        internal MoverOperationsDiscoveryList()
        {
            Value = new ChangeTrackingList<MoverOperationsDiscovery>();
        }

        /// <summary> Initializes a new instance of MoverOperationsDiscoveryList. </summary>
        /// <param name="value"> Gets or sets the ClientDiscovery details. </param>
        /// <param name="nextLink"> Gets or sets the value of next link. </param>
        internal MoverOperationsDiscoveryList(IReadOnlyList<MoverOperationsDiscovery> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets or sets the ClientDiscovery details. </summary>
        public IReadOnlyList<MoverOperationsDiscovery> Value { get; }
        /// <summary> Gets or sets the value of next link. </summary>
        public string NextLink { get; }
    }
}
