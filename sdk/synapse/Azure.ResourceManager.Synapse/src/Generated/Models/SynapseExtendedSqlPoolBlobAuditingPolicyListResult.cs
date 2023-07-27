// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of sql pool extended auditing settings. </summary>
    internal partial class SynapseExtendedSqlPoolBlobAuditingPolicyListResult
    {
        /// <summary> Initializes a new instance of SynapseExtendedSqlPoolBlobAuditingPolicyListResult. </summary>
        internal SynapseExtendedSqlPoolBlobAuditingPolicyListResult()
        {
            Value = new ChangeTrackingList<SynapseExtendedSqlPoolBlobAuditingPolicyData>();
        }

        /// <summary> Initializes a new instance of SynapseExtendedSqlPoolBlobAuditingPolicyListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal SynapseExtendedSqlPoolBlobAuditingPolicyListResult(IReadOnlyList<SynapseExtendedSqlPoolBlobAuditingPolicyData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseExtendedSqlPoolBlobAuditingPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
