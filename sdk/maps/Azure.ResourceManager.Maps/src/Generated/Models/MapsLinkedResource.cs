// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    /// <summary> Linked resource is reference to a resource deployed in an Azure subscription, add the linked resource `uniqueName` value as an optional parameter for operations on Azure Maps Geospatial REST APIs. </summary>
    public partial class MapsLinkedResource
    {
        /// <summary> Initializes a new instance of MapsLinkedResource. </summary>
        /// <param name="uniqueName"> A provided name which uniquely identifies the linked resource. </param>
        /// <param name="id"> ARM resource id in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/accounts/{storageName}'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uniqueName"/> or <paramref name="id"/> is null. </exception>
        public MapsLinkedResource(string uniqueName, string id)
        {
            Argument.AssertNotNull(uniqueName, nameof(uniqueName));
            Argument.AssertNotNull(id, nameof(id));

            UniqueName = uniqueName;
            Id = id;
        }

        /// <summary> A provided name which uniquely identifies the linked resource. </summary>
        public string UniqueName { get; set; }
        /// <summary> ARM resource id in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Storage/accounts/{storageName}'. </summary>
        public string Id { get; set; }
    }
}
