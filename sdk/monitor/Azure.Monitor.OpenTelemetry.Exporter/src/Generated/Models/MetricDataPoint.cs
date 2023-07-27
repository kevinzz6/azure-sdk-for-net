// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Monitor.OpenTelemetry.Exporter.Models
{
    /// <summary> Metric data single measurement. </summary>
    internal partial class MetricDataPoint
    {
        /// <summary> Initializes a new instance of MetricDataPoint. </summary>
        /// <param name="name"> Name of the metric. </param>
        /// <param name="value"> Single value for measurement. Sum of individual measurements for the aggregation. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public MetricDataPoint(string name, double value)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
            Value = value;
        }

        /// <summary> Namespace of the metric. </summary>
        public string Namespace { get; set; }
        /// <summary> Name of the metric. </summary>
        public string Name { get; }
        /// <summary> Metric type. Single measurement or the aggregated value. </summary>
        public DataPointType? DataPointType { get; set; }
        /// <summary> Single value for measurement. Sum of individual measurements for the aggregation. </summary>
        public double Value { get; }
        /// <summary> Metric weight of the aggregated metric. Should not be set for a measurement. </summary>
        public int? Count { get; set; }
        /// <summary> Minimum value of the aggregated metric. Should not be set for a measurement. </summary>
        public double? Min { get; set; }
        /// <summary> Maximum value of the aggregated metric. Should not be set for a measurement. </summary>
        public double? Max { get; set; }
        /// <summary> Standard deviation of the aggregated metric. Should not be set for a measurement. </summary>
        public double? StdDev { get; set; }
    }
}
