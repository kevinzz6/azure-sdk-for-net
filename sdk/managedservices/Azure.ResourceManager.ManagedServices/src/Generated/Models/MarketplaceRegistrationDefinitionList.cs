// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ManagedServices;

namespace Azure.ResourceManager.ManagedServices.Models
{
    /// <summary> The list of marketplace registration definitions. </summary>
    internal partial class MarketplaceRegistrationDefinitionList
    {
        /// <summary> Initializes a new instance of MarketplaceRegistrationDefinitionList. </summary>
        internal MarketplaceRegistrationDefinitionList()
        {
            Value = new ChangeTrackingList<ManagedServicesMarketplaceRegistrationData>();
        }

        /// <summary> Initializes a new instance of MarketplaceRegistrationDefinitionList. </summary>
        /// <param name="value"> The list of marketplace registration definitions. </param>
        /// <param name="nextLink"> The link to the next page of marketplace registration definitions. </param>
        internal MarketplaceRegistrationDefinitionList(IReadOnlyList<ManagedServicesMarketplaceRegistrationData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of marketplace registration definitions. </summary>
        public IReadOnlyList<ManagedServicesMarketplaceRegistrationData> Value { get; }
        /// <summary> The link to the next page of marketplace registration definitions. </summary>
        public string NextLink { get; }
    }
}
