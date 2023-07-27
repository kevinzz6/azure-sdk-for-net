// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> Azure service impacted by the service health event. </summary>
    public partial class ResourceHealthEventImpact
    {
        /// <summary> Initializes a new instance of ResourceHealthEventImpact. </summary>
        internal ResourceHealthEventImpact()
        {
            ImpactedRegions = new ChangeTrackingList<ResourceHealthEventImpactedServiceRegion>();
        }

        /// <summary> Initializes a new instance of ResourceHealthEventImpact. </summary>
        /// <param name="impactedService"> Impacted service name. </param>
        /// <param name="impactedRegions"> List regions impacted by the service health event. </param>
        internal ResourceHealthEventImpact(string impactedService, IReadOnlyList<ResourceHealthEventImpactedServiceRegion> impactedRegions)
        {
            ImpactedService = impactedService;
            ImpactedRegions = impactedRegions;
        }

        /// <summary> Impacted service name. </summary>
        public string ImpactedService { get; }
        /// <summary> List regions impacted by the service health event. </summary>
        public IReadOnlyList<ResourceHealthEventImpactedServiceRegion> ImpactedRegions { get; }
    }
}
