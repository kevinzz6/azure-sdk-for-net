// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The MetadataPermissionsApplicationsItem. </summary>
    internal partial class MetadataPermissionsApplicationsItem
    {
        /// <summary> Initializes a new instance of MetadataPermissionsApplicationsItem. </summary>
        /// <param name="resourceId"> The resource ID on the permission indication. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        internal MetadataPermissionsApplicationsItem(string resourceId)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            ResourceId = resourceId;
        }

        /// <summary> The resource ID on the permission indication. </summary>
        public string ResourceId { get; }
    }
}
