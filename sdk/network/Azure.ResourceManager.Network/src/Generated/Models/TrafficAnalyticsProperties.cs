// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Parameters that define the configuration of traffic analytics. </summary>
    internal partial class TrafficAnalyticsProperties
    {
        /// <summary> Initializes a new instance of TrafficAnalyticsProperties. </summary>
        public TrafficAnalyticsProperties()
        {
        }

        /// <summary> Initializes a new instance of TrafficAnalyticsProperties. </summary>
        /// <param name="trafficAnalyticsConfiguration"> Parameters that define the configuration of traffic analytics. </param>
        internal TrafficAnalyticsProperties(TrafficAnalyticsConfigurationProperties trafficAnalyticsConfiguration)
        {
            TrafficAnalyticsConfiguration = trafficAnalyticsConfiguration;
        }

        /// <summary> Parameters that define the configuration of traffic analytics. </summary>
        public TrafficAnalyticsConfigurationProperties TrafficAnalyticsConfiguration { get; set; }
    }
}
