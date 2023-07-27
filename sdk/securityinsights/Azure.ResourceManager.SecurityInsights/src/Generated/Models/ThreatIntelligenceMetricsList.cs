// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> List of all the threat intelligence metric fields (type/threat type/source). </summary>
    internal partial class ThreatIntelligenceMetricsList
    {
        /// <summary> Initializes a new instance of ThreatIntelligenceMetricsList. </summary>
        /// <param name="value"> Array of threat intelligence metric fields (type/threat type/source). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ThreatIntelligenceMetricsList(IEnumerable<ThreatIntelligenceMetrics> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ThreatIntelligenceMetricsList. </summary>
        /// <param name="value"> Array of threat intelligence metric fields (type/threat type/source). </param>
        internal ThreatIntelligenceMetricsList(IReadOnlyList<ThreatIntelligenceMetrics> value)
        {
            Value = value;
        }

        /// <summary> Array of threat intelligence metric fields (type/threat type/source). </summary>
        public IReadOnlyList<ThreatIntelligenceMetrics> Value { get; }
    }
}
