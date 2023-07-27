// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> A list of trigger runs. </summary>
    public partial class TriggerRunsQueryResponse
    {
        /// <summary> Initializes a new instance of TriggerRunsQueryResponse. </summary>
        /// <param name="value"> List of trigger runs. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal TriggerRunsQueryResponse(IEnumerable<TriggerRun> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of TriggerRunsQueryResponse. </summary>
        /// <param name="value"> List of trigger runs. </param>
        /// <param name="continuationToken"> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </param>
        internal TriggerRunsQueryResponse(IReadOnlyList<TriggerRun> value, string continuationToken)
        {
            Value = value;
            ContinuationToken = continuationToken;
        }

        /// <summary> List of trigger runs. </summary>
        public IReadOnlyList<TriggerRun> Value { get; }
        /// <summary> The continuation token for getting the next page of results, if any remaining results exist, null otherwise. </summary>
        public string ContinuationToken { get; }
    }
}
