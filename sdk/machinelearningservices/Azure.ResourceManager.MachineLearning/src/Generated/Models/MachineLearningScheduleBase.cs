// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningScheduleBase. </summary>
    public partial class MachineLearningScheduleBase
    {
        /// <summary> Initializes a new instance of MachineLearningScheduleBase. </summary>
        internal MachineLearningScheduleBase()
        {
        }

        /// <summary> Initializes a new instance of MachineLearningScheduleBase. </summary>
        /// <param name="id"> A system assigned id for the schedule. </param>
        /// <param name="provisioningStatus"> The current deployment state of schedule. </param>
        /// <param name="status"> Is the schedule enabled or disabled?. </param>
        internal MachineLearningScheduleBase(string id, MachineLearningScheduleProvisioningState? provisioningStatus, MachineLearningScheduleStatus? status)
        {
            Id = id;
            ProvisioningStatus = provisioningStatus;
            Status = status;
        }

        /// <summary> A system assigned id for the schedule. </summary>
        public string Id { get; }
        /// <summary> The current deployment state of schedule. </summary>
        public MachineLearningScheduleProvisioningState? ProvisioningStatus { get; }
        /// <summary> Is the schedule enabled or disabled?. </summary>
        public MachineLearningScheduleStatus? Status { get; }
    }
}
