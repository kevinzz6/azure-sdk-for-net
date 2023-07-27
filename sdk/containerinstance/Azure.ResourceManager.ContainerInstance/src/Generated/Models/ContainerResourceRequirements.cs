// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ContainerInstance.Models
{
    /// <summary> The resource requirements. </summary>
    public partial class ContainerResourceRequirements
    {
        /// <summary> Initializes a new instance of ContainerResourceRequirements. </summary>
        /// <param name="requests"> The resource requests of this container instance. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="requests"/> is null. </exception>
        public ContainerResourceRequirements(ContainerResourceRequestsContent requests)
        {
            Argument.AssertNotNull(requests, nameof(requests));

            Requests = requests;
        }

        /// <summary> Initializes a new instance of ContainerResourceRequirements. </summary>
        /// <param name="requests"> The resource requests of this container instance. </param>
        /// <param name="limits"> The resource limits of this container instance. </param>
        internal ContainerResourceRequirements(ContainerResourceRequestsContent requests, ContainerResourceLimits limits)
        {
            Requests = requests;
            Limits = limits;
        }

        /// <summary> The resource requests of this container instance. </summary>
        public ContainerResourceRequestsContent Requests { get; set; }
        /// <summary> The resource limits of this container instance. </summary>
        public ContainerResourceLimits Limits { get; set; }
    }
}
