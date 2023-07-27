// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.NewRelicObservability.Models;

namespace Azure.ResourceManager.NewRelicObservability
{
    /// <summary>
    /// A class representing the NewRelicObservabilityTagRule data model.
    /// A tag rule belonging to NewRelic account
    /// </summary>
    public partial class NewRelicObservabilityTagRuleData : ResourceData
    {
        /// <summary> Initializes a new instance of NewRelicObservabilityTagRuleData. </summary>
        public NewRelicObservabilityTagRuleData()
        {
        }

        /// <summary> Initializes a new instance of NewRelicObservabilityTagRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="provisioningState"> Provisioning State of the resource. </param>
        /// <param name="logRules"> Set of rules for sending logs for the Monitor resource. </param>
        /// <param name="metricRules"> Set of rules for sending metrics for the Monitor resource. </param>
        internal NewRelicObservabilityTagRuleData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, NewRelicProvisioningState? provisioningState, NewRelicObservabilityLogRules logRules, NewRelicObservabilityMetricRules metricRules) : base(id, name, resourceType, systemData)
        {
            ProvisioningState = provisioningState;
            LogRules = logRules;
            MetricRules = metricRules;
        }

        /// <summary> Provisioning State of the resource. </summary>
        public NewRelicProvisioningState? ProvisioningState { get; }
        /// <summary> Set of rules for sending logs for the Monitor resource. </summary>
        public NewRelicObservabilityLogRules LogRules { get; set; }
        /// <summary> Set of rules for sending metrics for the Monitor resource. </summary>
        public NewRelicObservabilityMetricRules MetricRules { get; set; }
    }
}
