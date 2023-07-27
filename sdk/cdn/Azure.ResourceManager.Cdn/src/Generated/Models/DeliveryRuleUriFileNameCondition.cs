// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the UrlFileName condition for the delivery rule. </summary>
    public partial class DeliveryRuleUriFileNameCondition : DeliveryRuleCondition
    {
        /// <summary> Initializes a new instance of DeliveryRuleUriFileNameCondition. </summary>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public DeliveryRuleUriFileNameCondition(UriFileNameMatchCondition properties)
        {
            Argument.AssertNotNull(properties, nameof(properties));

            Properties = properties;
            Name = MatchVariable.UriFileName;
        }

        /// <summary> Initializes a new instance of DeliveryRuleUriFileNameCondition. </summary>
        /// <param name="name"> The name of the condition for the delivery rule. </param>
        /// <param name="properties"> Defines the parameters for the condition. </param>
        internal DeliveryRuleUriFileNameCondition(MatchVariable name, UriFileNameMatchCondition properties) : base(name)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Defines the parameters for the condition. </summary>
        public UriFileNameMatchCondition Properties { get; set; }
    }
}
