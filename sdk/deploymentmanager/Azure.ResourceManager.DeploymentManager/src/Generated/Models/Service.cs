// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> Defines a service. </summary>
    public partial class Service : ServiceProperties
    {
        /// <summary> Initializes a new instance of Service. </summary>
        /// <param name="targetLocation"> The Azure location to which the resources in the service belong to or should be deployed to. </param>
        /// <param name="targetSubscriptionId"> The subscription to which the resources in the service belong to or should be deployed to. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetLocation"/> or <paramref name="targetSubscriptionId"/> is null. </exception>
        internal Service(string targetLocation, string targetSubscriptionId) : base(targetLocation, targetSubscriptionId)
        {
            Argument.AssertNotNull(targetLocation, nameof(targetLocation));
            Argument.AssertNotNull(targetSubscriptionId, nameof(targetSubscriptionId));

            ServiceUnits = new ChangeTrackingList<ServiceUnit>();
        }

        /// <summary> Initializes a new instance of Service. </summary>
        /// <param name="targetLocation"> The Azure location to which the resources in the service belong to or should be deployed to. </param>
        /// <param name="targetSubscriptionId"> The subscription to which the resources in the service belong to or should be deployed to. </param>
        /// <param name="name"> Name of the service. </param>
        /// <param name="serviceUnits"> The detailed information about the units that make up the service. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetLocation"/> or <paramref name="targetSubscriptionId"/> is null. </exception>
        internal Service(string targetLocation, string targetSubscriptionId, string name, IReadOnlyList<ServiceUnit> serviceUnits) : base(targetLocation, targetSubscriptionId)
        {
            Argument.AssertNotNull(targetLocation, nameof(targetLocation));
            Argument.AssertNotNull(targetSubscriptionId, nameof(targetSubscriptionId));

            Name = name;
            ServiceUnits = serviceUnits;
        }

        /// <summary> Name of the service. </summary>
        public string Name { get; }
        /// <summary> The detailed information about the units that make up the service. </summary>
        public IReadOnlyList<ServiceUnit> ServiceUnits { get; }
    }
}
