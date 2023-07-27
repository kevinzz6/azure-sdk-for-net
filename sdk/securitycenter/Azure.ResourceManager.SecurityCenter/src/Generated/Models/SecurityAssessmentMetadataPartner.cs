// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> Describes the partner that created the assessment. </summary>
    public partial class SecurityAssessmentMetadataPartner
    {
        /// <summary> Initializes a new instance of SecurityAssessmentMetadataPartner. </summary>
        /// <param name="partnerName"> Name of the company of the partner. </param>
        /// <param name="secret"> Secret to authenticate the partner and verify it created the assessment - write only. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="partnerName"/> or <paramref name="secret"/> is null. </exception>
        public SecurityAssessmentMetadataPartner(string partnerName, string secret)
        {
            Argument.AssertNotNull(partnerName, nameof(partnerName));
            Argument.AssertNotNull(secret, nameof(secret));

            PartnerName = partnerName;
            Secret = secret;
        }

        /// <summary> Initializes a new instance of SecurityAssessmentMetadataPartner. </summary>
        /// <param name="partnerName"> Name of the company of the partner. </param>
        /// <param name="productName"> Name of the product of the partner that created the assessment. </param>
        /// <param name="secret"> Secret to authenticate the partner and verify it created the assessment - write only. </param>
        internal SecurityAssessmentMetadataPartner(string partnerName, string productName, string secret)
        {
            PartnerName = partnerName;
            ProductName = productName;
            Secret = secret;
        }

        /// <summary> Name of the company of the partner. </summary>
        public string PartnerName { get; set; }
        /// <summary> Name of the product of the partner that created the assessment. </summary>
        public string ProductName { get; set; }
        /// <summary> Secret to authenticate the partner and verify it created the assessment - write only. </summary>
        public string Secret { get; set; }
    }
}
