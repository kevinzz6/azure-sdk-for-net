// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> Defines a service unit. </summary>
    public partial class ServiceUnit : ServiceUnitProperties
    {
        /// <summary> Initializes a new instance of ServiceUnit. </summary>
        /// <param name="targetResourceGroup"> The Azure Resource Group to which the resources in the service unit belong to or should be deployed to. </param>
        /// <param name="deploymentMode"> Describes the type of ARM deployment to be performed on the resource. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="targetResourceGroup"/> is null. </exception>
        internal ServiceUnit(string targetResourceGroup, DeploymentMode deploymentMode) : base(targetResourceGroup, deploymentMode)
        {
            Argument.AssertNotNull(targetResourceGroup, nameof(targetResourceGroup));

            Steps = new ChangeTrackingList<RolloutStep>();
        }

        /// <summary> Initializes a new instance of ServiceUnit. </summary>
        /// <param name="targetResourceGroup"> The Azure Resource Group to which the resources in the service unit belong to or should be deployed to. </param>
        /// <param name="deploymentMode"> Describes the type of ARM deployment to be performed on the resource. </param>
        /// <param name="artifacts"> The artifacts for the service unit. </param>
        /// <param name="name"> Name of the service unit. </param>
        /// <param name="steps"> Detailed step information, if present. </param>
        internal ServiceUnit(string targetResourceGroup, DeploymentMode deploymentMode, ServiceUnitArtifacts artifacts, string name, IReadOnlyList<RolloutStep> steps) : base(targetResourceGroup, deploymentMode, artifacts)
        {
            Name = name;
            Steps = steps;
        }

        /// <summary> Name of the service unit. </summary>
        public string Name { get; }
        /// <summary> Detailed step information, if present. </summary>
        public IReadOnlyList<RolloutStep> Steps { get; }
    }
}
