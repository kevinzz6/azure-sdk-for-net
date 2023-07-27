// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.NewRelicObservability.Models
{
    /// <summary> Response of get all plan data Operation. </summary>
    internal partial class NewRelicPlanDataListResult
    {
        /// <summary> Initializes a new instance of NewRelicPlanDataListResult. </summary>
        /// <param name="value"> The PlanDataResource items on this page. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal NewRelicPlanDataListResult(IEnumerable<NewRelicPlanData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of NewRelicPlanDataListResult. </summary>
        /// <param name="value"> The PlanDataResource items on this page. </param>
        /// <param name="nextLink"> The link to the next page of items. </param>
        internal NewRelicPlanDataListResult(IReadOnlyList<NewRelicPlanData> value, Uri nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The PlanDataResource items on this page. </summary>
        public IReadOnlyList<NewRelicPlanData> Value { get; }
        /// <summary> The link to the next page of items. </summary>
        public Uri NextLink { get; }
    }
}
