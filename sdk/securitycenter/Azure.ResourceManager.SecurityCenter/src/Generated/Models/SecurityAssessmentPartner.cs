// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Data regarding 3rd party partner integration. </summary>
    public partial class SecurityAssessmentPartner
    {
        /// <summary> Initializes a new instance of SecurityAssessmentPartner. </summary>
        /// <param name="partnerName"> Name of the company of the partner. </param>
        /// <param name="secret"> secret to authenticate the partner - write only. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerName"/> or <paramref name="secret"/> is null. </exception>
        public SecurityAssessmentPartner(string partnerName, string secret)
        {
            Argument.AssertNotNull(partnerName, nameof(partnerName));
            Argument.AssertNotNull(secret, nameof(secret));

            PartnerName = partnerName;
            Secret = secret;
        }

        /// <summary> Name of the company of the partner. </summary>
        public string PartnerName { get; set; }
        /// <summary> secret to authenticate the partner - write only. </summary>
        public string Secret { get; set; }
    }
}
