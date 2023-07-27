// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The ETA (estimated time of arrival) for remediation. </summary>
    public partial class RemediationEta
    {
        /// <summary> Initializes a new instance of RemediationEta. </summary>
        /// <param name="eta"> ETA for remediation. </param>
        /// <param name="justification"> Justification for change of Eta. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="justification"/> is null. </exception>
        public RemediationEta(DateTimeOffset eta, string justification)
        {
            Argument.AssertNotNull(justification, nameof(justification));

            Eta = eta;
            Justification = justification;
        }

        /// <summary> ETA for remediation. </summary>
        public DateTimeOffset Eta { get; set; }
        /// <summary> Justification for change of Eta. </summary>
        public string Justification { get; set; }
    }
}
