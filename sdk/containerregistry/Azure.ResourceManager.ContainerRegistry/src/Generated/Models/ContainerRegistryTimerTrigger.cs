// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The properties of a timer trigger. </summary>
    public partial class ContainerRegistryTimerTrigger
    {
        /// <summary> Initializes a new instance of ContainerRegistryTimerTrigger. </summary>
        /// <param name="schedule"> The CRON expression for the task schedule. </param>
        /// <param name="name"> The name of the trigger. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="schedule"/> or <paramref name="name"/> is null. </exception>
        public ContainerRegistryTimerTrigger(string schedule, string name)
        {
            Argument.AssertNotNull(schedule, nameof(schedule));
            Argument.AssertNotNull(name, nameof(name));

            Schedule = schedule;
            Name = name;
        }

        /// <summary> Initializes a new instance of ContainerRegistryTimerTrigger. </summary>
        /// <param name="schedule"> The CRON expression for the task schedule. </param>
        /// <param name="status"> The current status of trigger. </param>
        /// <param name="name"> The name of the trigger. </param>
        internal ContainerRegistryTimerTrigger(string schedule, ContainerRegistryTriggerStatus? status, string name)
        {
            Schedule = schedule;
            Status = status;
            Name = name;
        }

        /// <summary> The CRON expression for the task schedule. </summary>
        public string Schedule { get; set; }
        /// <summary> The current status of trigger. </summary>
        public ContainerRegistryTriggerStatus? Status { get; set; }
        /// <summary> The name of the trigger. </summary>
        public string Name { get; set; }
    }
}
