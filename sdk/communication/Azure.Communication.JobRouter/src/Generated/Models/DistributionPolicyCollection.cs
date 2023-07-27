// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> A paged collection of distribution policies. </summary>
    internal partial class DistributionPolicyCollection
    {
        /// <summary> Initializes a new instance of DistributionPolicyCollection. </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal DistributionPolicyCollection(IEnumerable<DistributionPolicyItem> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of DistributionPolicyCollection. </summary>
        /// <param name="value"></param>
        /// <param name="nextLink"></param>
        internal DistributionPolicyCollection(IReadOnlyList<DistributionPolicyItem> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Gets the value. </summary>
        public IReadOnlyList<DistributionPolicyItem> Value { get; }
        /// <summary> Gets the next link. </summary>
        public string NextLink { get; }
    }
}
