// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Version related details. </summary>
    public partial class SiteRecoveryVersionDetails
    {
        /// <summary> Initializes a new instance of SiteRecoveryVersionDetails. </summary>
        internal SiteRecoveryVersionDetails()
        {
        }

        /// <summary> Initializes a new instance of SiteRecoveryVersionDetails. </summary>
        /// <param name="version"> The agent version. </param>
        /// <param name="expireOn"> Version expiry date. </param>
        /// <param name="status"> A value indicating whether security update required. </param>
        internal SiteRecoveryVersionDetails(string version, DateTimeOffset? expireOn, SiteRecoveryAgentVersionStatus? status)
        {
            Version = version;
            ExpireOn = expireOn;
            Status = status;
        }

        /// <summary> The agent version. </summary>
        public string Version { get; }
        /// <summary> Version expiry date. </summary>
        public DateTimeOffset? ExpireOn { get; }
        /// <summary> A value indicating whether security update required. </summary>
        public SiteRecoveryAgentVersionStatus? Status { get; }
    }
}
