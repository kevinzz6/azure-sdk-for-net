// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The Get Skus operation response. </summary>
    internal partial class AvailableCognitiveServicesSkuResult
    {
        /// <summary> Initializes a new instance of AvailableCognitiveServicesSkuResult. </summary>
        /// <param name="value"> The list of skus available for the subscription. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal AvailableCognitiveServicesSkuResult(IEnumerable<AvailableCognitiveServicesSku> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of AvailableCognitiveServicesSkuResult. </summary>
        /// <param name="value"> The list of skus available for the subscription. </param>
        /// <param name="nextLink"> The uri to fetch the next page of Skus. </param>
        internal AvailableCognitiveServicesSkuResult(IReadOnlyList<AvailableCognitiveServicesSku> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of skus available for the subscription. </summary>
        public IReadOnlyList<AvailableCognitiveServicesSku> Value { get; }
        /// <summary> The uri to fetch the next page of Skus. </summary>
        public string NextLink { get; }
    }
}
