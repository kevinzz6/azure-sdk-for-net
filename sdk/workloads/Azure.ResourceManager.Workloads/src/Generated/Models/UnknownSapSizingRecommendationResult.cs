// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The UnknownSapSizingRecommendationResult. </summary>
    internal partial class UnknownSapSizingRecommendationResult : SapSizingRecommendationResult
    {
        /// <summary> Initializes a new instance of UnknownSapSizingRecommendationResult. </summary>
        /// <param name="deploymentType"> The type of SAP deployment, single server or Three tier. </param>
        internal UnknownSapSizingRecommendationResult(SapDeploymentType deploymentType) : base(deploymentType)
        {
            DeploymentType = deploymentType;
        }
    }
}
