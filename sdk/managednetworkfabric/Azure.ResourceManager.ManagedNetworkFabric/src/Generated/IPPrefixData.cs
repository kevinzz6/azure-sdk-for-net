// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the IPPrefix data model.
    /// The IPPrefix resource definition.
    /// </summary>
    public partial class IPPrefixData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of IPPrefixData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="ipPrefixRules"> IpPrefix contains the list of IP PrefixRules objects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ipPrefixRules"/> is null. </exception>
        public IPPrefixData(AzureLocation location, IEnumerable<IPPrefixPropertiesIPPrefixRulesItem> ipPrefixRules) : base(location)
        {
            Argument.AssertNotNull(ipPrefixRules, nameof(ipPrefixRules));

            IPPrefixRules = ipPrefixRules.ToList();
        }

        /// <summary> Initializes a new instance of IPPrefixData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="ipPrefixRules"> IpPrefix contains the list of IP PrefixRules objects. </param>
        /// <param name="provisioningState"> Gets the provisioning state of the resource. </param>
        internal IPPrefixData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, IList<IPPrefixPropertiesIPPrefixRulesItem> ipPrefixRules, ProvisioningState? provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            IPPrefixRules = ipPrefixRules;
            ProvisioningState = provisioningState;
        }

        /// <summary> Switch configuration description. </summary>
        public string Annotation { get; set; }
        /// <summary> IpPrefix contains the list of IP PrefixRules objects. </summary>
        public IList<IPPrefixPropertiesIPPrefixRulesItem> IPPrefixRules { get; }
        /// <summary> Gets the provisioning state of the resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
    }
}
