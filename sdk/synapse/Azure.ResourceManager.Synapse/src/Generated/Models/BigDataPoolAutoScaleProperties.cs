// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Auto-scaling properties of a Big Data pool powered by Apache Spark. </summary>
    public partial class BigDataPoolAutoScaleProperties
    {
        /// <summary> Initializes a new instance of BigDataPoolAutoScaleProperties. </summary>
        public BigDataPoolAutoScaleProperties()
        {
        }

        /// <summary> Initializes a new instance of BigDataPoolAutoScaleProperties. </summary>
        /// <param name="minNodeCount"> The minimum number of nodes the Big Data pool can support. </param>
        /// <param name="isEnabled"> Whether automatic scaling is enabled for the Big Data pool. </param>
        /// <param name="maxNodeCount"> The maximum number of nodes the Big Data pool can support. </param>
        internal BigDataPoolAutoScaleProperties(int? minNodeCount, bool? isEnabled, int? maxNodeCount)
        {
            MinNodeCount = minNodeCount;
            IsEnabled = isEnabled;
            MaxNodeCount = maxNodeCount;
        }

        /// <summary> The minimum number of nodes the Big Data pool can support. </summary>
        public int? MinNodeCount { get; set; }
        /// <summary> Whether automatic scaling is enabled for the Big Data pool. </summary>
        public bool? IsEnabled { get; set; }
        /// <summary> The maximum number of nodes the Big Data pool can support. </summary>
        public int? MaxNodeCount { get; set; }
    }
}
