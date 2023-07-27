// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the LongTermRetentionPolicy data model.
    /// A long term retention policy.
    /// </summary>
    public partial class LongTermRetentionPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of LongTermRetentionPolicyData. </summary>
        public LongTermRetentionPolicyData()
        {
        }

        /// <summary> Initializes a new instance of LongTermRetentionPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="weeklyRetention"> The weekly retention policy for an LTR backup in an ISO 8601 format. </param>
        /// <param name="monthlyRetention"> The monthly retention policy for an LTR backup in an ISO 8601 format. </param>
        /// <param name="yearlyRetention"> The yearly retention policy for an LTR backup in an ISO 8601 format. </param>
        /// <param name="weekOfYear"> The week of year to take the yearly backup in an ISO 8601 format. </param>
        internal LongTermRetentionPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string weeklyRetention, string monthlyRetention, string yearlyRetention, int? weekOfYear) : base(id, name, resourceType, systemData)
        {
            WeeklyRetention = weeklyRetention;
            MonthlyRetention = monthlyRetention;
            YearlyRetention = yearlyRetention;
            WeekOfYear = weekOfYear;
        }

        /// <summary> The weekly retention policy for an LTR backup in an ISO 8601 format. </summary>
        public string WeeklyRetention { get; set; }
        /// <summary> The monthly retention policy for an LTR backup in an ISO 8601 format. </summary>
        public string MonthlyRetention { get; set; }
        /// <summary> The yearly retention policy for an LTR backup in an ISO 8601 format. </summary>
        public string YearlyRetention { get; set; }
        /// <summary> The week of year to take the yearly backup in an ISO 8601 format. </summary>
        public int? WeekOfYear { get; set; }
    }
}
