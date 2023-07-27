// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Marketplace.Models
{
    /// <summary> Plan notification details. </summary>
    public partial class PlanNotificationDetails
    {
        /// <summary> Initializes a new instance of PlanNotificationDetails. </summary>
        internal PlanNotificationDetails()
        {
        }

        /// <summary> Initializes a new instance of PlanNotificationDetails. </summary>
        /// <param name="planId"> Gets or sets the plan id. </param>
        /// <param name="planDisplayName"> Gets or sets the plan display name. </param>
        internal PlanNotificationDetails(string planId, string planDisplayName)
        {
            PlanId = planId;
            PlanDisplayName = planDisplayName;
        }

        /// <summary> Gets or sets the plan id. </summary>
        public string PlanId { get; }
        /// <summary> Gets or sets the plan display name. </summary>
        public string PlanDisplayName { get; }
    }
}
