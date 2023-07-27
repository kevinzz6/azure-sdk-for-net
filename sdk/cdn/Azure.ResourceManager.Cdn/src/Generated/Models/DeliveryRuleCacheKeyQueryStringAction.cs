// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the cache-key query string action for the delivery rule. </summary>
    public partial class DeliveryRuleCacheKeyQueryStringAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of DeliveryRuleCacheKeyQueryStringAction. </summary>
        /// <param name="properties"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleCacheKeyQueryStringAction(CacheKeyQueryStringActionProperties properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Name = DeliveryRuleActionType.CacheKeyQueryString;
        }

        /// <summary> Initializes a new instance of DeliveryRuleCacheKeyQueryStringAction. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="properties"> Defines the parameters for the action. </param>
        internal DeliveryRuleCacheKeyQueryStringAction(DeliveryRuleActionType name, CacheKeyQueryStringActionProperties properties) : base(name)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Defines the parameters for the action. </summary>
        public CacheKeyQueryStringActionProperties Properties { get; set; }
    }
}
