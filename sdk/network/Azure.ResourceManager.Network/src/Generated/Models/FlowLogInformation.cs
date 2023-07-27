// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Information on the configuration of flow log and traffic analytics (optional) . </summary>
    public partial class FlowLogInformation
    {
        /// <summary> Initializes a new instance of FlowLogInformation. </summary>
        /// <param name="targetResourceId"> The ID of the resource to configure for flow log and traffic analytics (optional) . </param>
        /// <param name="storageId"> ID of the storage account which is used to store the flow log. </param>
        /// <param name="enabled"> Flag to enable/disable flow logging. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceId"/> or <paramref name="storageId"/> is null. </exception>
        public FlowLogInformation(ResourceIdentifier targetResourceId, ResourceIdentifier storageId, bool enabled)
        {
            Argument.AssertNotNull(targetResourceId, nameof(targetResourceId));
            Argument.AssertNotNull(storageId, nameof(storageId));

            TargetResourceId = targetResourceId;
            StorageId = storageId;
            Enabled = enabled;
        }

        /// <summary> Initializes a new instance of FlowLogInformation. </summary>
        /// <param name="targetResourceId"> The ID of the resource to configure for flow log and traffic analytics (optional) . </param>
        /// <param name="flowAnalyticsConfiguration"> Parameters that define the configuration of traffic analytics. </param>
        /// <param name="storageId"> ID of the storage account which is used to store the flow log. </param>
        /// <param name="enabled"> Flag to enable/disable flow logging. </param>
        /// <param name="retentionPolicy"> Parameters that define the retention policy for flow log. </param>
        /// <param name="format"> Parameters that define the flow log format. </param>
        internal FlowLogInformation(ResourceIdentifier targetResourceId, TrafficAnalyticsProperties flowAnalyticsConfiguration, ResourceIdentifier storageId, bool enabled, RetentionPolicyParameters retentionPolicy, FlowLogProperties format)
        {
            TargetResourceId = targetResourceId;
            FlowAnalyticsConfiguration = flowAnalyticsConfiguration;
            StorageId = storageId;
            Enabled = enabled;
            RetentionPolicy = retentionPolicy;
            Format = format;
        }

        /// <summary> The ID of the resource to configure for flow log and traffic analytics (optional) . </summary>
        public ResourceIdentifier TargetResourceId { get; set; }
        /// <summary> Parameters that define the configuration of traffic analytics. </summary>
        internal TrafficAnalyticsProperties FlowAnalyticsConfiguration { get; set; }
        /// <summary> Parameters that define the configuration of traffic analytics. </summary>
        public TrafficAnalyticsConfigurationProperties TrafficAnalyticsConfiguration
        {
            get => FlowAnalyticsConfiguration is null ? default : FlowAnalyticsConfiguration.TrafficAnalyticsConfiguration;
            set
            {
                if (FlowAnalyticsConfiguration is null)
                    FlowAnalyticsConfiguration = new TrafficAnalyticsProperties();
                FlowAnalyticsConfiguration.TrafficAnalyticsConfiguration = value;
            }
        }

        /// <summary> ID of the storage account which is used to store the flow log. </summary>
        public ResourceIdentifier StorageId { get; set; }
        /// <summary> Flag to enable/disable flow logging. </summary>
        public bool Enabled { get; set; }
        /// <summary> Parameters that define the retention policy for flow log. </summary>
        public RetentionPolicyParameters RetentionPolicy { get; set; }
        /// <summary> Parameters that define the flow log format. </summary>
        public FlowLogProperties Format { get; set; }
    }
}
