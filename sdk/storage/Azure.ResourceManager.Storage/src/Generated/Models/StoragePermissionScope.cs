// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The StoragePermissionScope. </summary>
    public partial class StoragePermissionScope
    {
        /// <summary> Initializes a new instance of StoragePermissionScope. </summary>
        /// <param name="permissions"> The permissions for the local user. Possible values include: Read (r), Write (w), Delete (d), List (l), and Create (c). </param>
        /// <param name="service"> The service used by the local user, e.g. blob, file. </param>
        /// <param name="resourceName"> The name of resource, normally the container name or the file share name, used by the local user. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="permissions"/>, <paramref name="service"/> or <paramref name="resourceName"/> is null. </exception>
        public StoragePermissionScope(string permissions, string service, string resourceName)
        {
            Argument.AssertNotNull(permissions, nameof(permissions));
            Argument.AssertNotNull(service, nameof(service));
            Argument.AssertNotNull(resourceName, nameof(resourceName));

            Permissions = permissions;
            Service = service;
            ResourceName = resourceName;
        }

        /// <summary> The permissions for the local user. Possible values include: Read (r), Write (w), Delete (d), List (l), and Create (c). </summary>
        public string Permissions { get; set; }
        /// <summary> The service used by the local user, e.g. blob, file. </summary>
        public string Service { get; set; }
        /// <summary> The name of resource, normally the container name or the file share name, used by the local user. </summary>
        public string ResourceName { get; set; }
    }
}
