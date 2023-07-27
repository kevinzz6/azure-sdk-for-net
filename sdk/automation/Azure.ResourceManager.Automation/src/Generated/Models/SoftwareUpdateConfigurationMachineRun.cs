// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Software update configuration machine run model. </summary>
    public partial class SoftwareUpdateConfigurationMachineRun
    {
        /// <summary> Initializes a new instance of SoftwareUpdateConfigurationMachineRun. </summary>
        internal SoftwareUpdateConfigurationMachineRun()
        {
        }

        /// <summary> Initializes a new instance of SoftwareUpdateConfigurationMachineRun. </summary>
        /// <param name="name"> Name of the software update configuration machine run. </param>
        /// <param name="id"> Resource Id of the software update configuration machine run. </param>
        /// <param name="targetComputerId"> name of the updated computer. </param>
        /// <param name="targetComputerType"> type of the updated computer. </param>
        /// <param name="softwareUpdateConfiguration"> software update configuration triggered this run. </param>
        /// <param name="status"> Status of the software update configuration machine run. </param>
        /// <param name="osType"> Operating system target of the software update configuration triggered this run. </param>
        /// <param name="correlationId"> correlation id of the software update configuration machine run. </param>
        /// <param name="sourceComputerId"> source computer id of the software update configuration machine run. </param>
        /// <param name="startOn"> Start time of the software update configuration machine run. </param>
        /// <param name="endOn"> End time of the software update configuration machine run. </param>
        /// <param name="configuredDuration"> configured duration for the software update configuration run. </param>
        /// <param name="job"> Job associated with the software update configuration machine run. </param>
        /// <param name="createdOn"> Creation time of the resource, which only appears in the response. </param>
        /// <param name="createdBy"> createdBy property, which only appears in the response. </param>
        /// <param name="lastModifiedOn"> Last time resource was modified, which only appears in the response. </param>
        /// <param name="lastModifiedBy"> lastModifiedBy property, which only appears in the response. </param>
        /// <param name="error"> Details of provisioning error. </param>
        internal SoftwareUpdateConfigurationMachineRun(string name, ResourceIdentifier id, ResourceIdentifier targetComputerId, string targetComputerType, SoftwareUpdateConfigurationNavigation softwareUpdateConfiguration, string status, string osType, Guid? correlationId, Guid? sourceComputerId, DateTimeOffset? startOn, DateTimeOffset? endOn, TimeSpan? configuredDuration, JobNavigation job, DateTimeOffset? createdOn, string createdBy, DateTimeOffset? lastModifiedOn, string lastModifiedBy, AutomationResponseError error)
        {
            Name = name;
            Id = id;
            TargetComputerId = targetComputerId;
            TargetComputerType = targetComputerType;
            SoftwareUpdateConfiguration = softwareUpdateConfiguration;
            Status = status;
            OSType = osType;
            CorrelationId = correlationId;
            SourceComputerId = sourceComputerId;
            StartOn = startOn;
            EndOn = endOn;
            ConfiguredDuration = configuredDuration;
            Job = job;
            CreatedOn = createdOn;
            CreatedBy = createdBy;
            LastModifiedOn = lastModifiedOn;
            LastModifiedBy = lastModifiedBy;
            Error = error;
        }

        /// <summary> Name of the software update configuration machine run. </summary>
        public string Name { get; }
        /// <summary> Resource Id of the software update configuration machine run. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> name of the updated computer. </summary>
        public ResourceIdentifier TargetComputerId { get; }
        /// <summary> type of the updated computer. </summary>
        public string TargetComputerType { get; }
        /// <summary> software update configuration triggered this run. </summary>
        internal SoftwareUpdateConfigurationNavigation SoftwareUpdateConfiguration { get; }
        /// <summary> Name of the software update configuration triggered the software update configuration run. </summary>
        public string SoftwareUpdateName
        {
            get => SoftwareUpdateConfiguration?.Name;
        }

        /// <summary> Status of the software update configuration machine run. </summary>
        public string Status { get; }
        /// <summary> Operating system target of the software update configuration triggered this run. </summary>
        public string OSType { get; }
        /// <summary> correlation id of the software update configuration machine run. </summary>
        public Guid? CorrelationId { get; }
        /// <summary> source computer id of the software update configuration machine run. </summary>
        public Guid? SourceComputerId { get; }
        /// <summary> Start time of the software update configuration machine run. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> End time of the software update configuration machine run. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> configured duration for the software update configuration run. </summary>
        public TimeSpan? ConfiguredDuration { get; }
        /// <summary> Job associated with the software update configuration machine run. </summary>
        internal JobNavigation Job { get; }
        /// <summary> Id of the job associated with the software update configuration run. </summary>
        public Guid? JobId
        {
            get => Job?.Id;
        }

        /// <summary> Creation time of the resource, which only appears in the response. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> createdBy property, which only appears in the response. </summary>
        public string CreatedBy { get; }
        /// <summary> Last time resource was modified, which only appears in the response. </summary>
        public DateTimeOffset? LastModifiedOn { get; }
        /// <summary> lastModifiedBy property, which only appears in the response. </summary>
        public string LastModifiedBy { get; }
        /// <summary> Details of provisioning error. </summary>
        public AutomationResponseError Error { get; }
    }
}
