// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> Log analytics configuration. </summary>
    public partial class ContainerAppLogAnalyticsConfiguration
    {
        /// <summary> Initializes a new instance of ContainerAppLogAnalyticsConfiguration. </summary>
        public ContainerAppLogAnalyticsConfiguration()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppLogAnalyticsConfiguration. </summary>
        /// <param name="customerId"> Log analytics customer id. </param>
        /// <param name="sharedKey"> Log analytics customer key. </param>
        internal ContainerAppLogAnalyticsConfiguration(string customerId, string sharedKey)
        {
            CustomerId = customerId;
            SharedKey = sharedKey;
        }

        /// <summary> Log analytics customer id. </summary>
        public string CustomerId { get; set; }
        /// <summary> Log analytics customer key. </summary>
        public string SharedKey { get; set; }
    }
}
