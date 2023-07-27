// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The upload certificate request. </summary>
    public partial class UploadCertificateContent
    {
        /// <summary> Initializes a new instance of UploadCertificateContent. </summary>
        /// <param name="certificate"> The base64 encoded certificate raw data. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificate"/> is null. </exception>
        public UploadCertificateContent(string certificate)
        {
            Argument.AssertNotNull(certificate, nameof(certificate));

            Certificate = certificate;
        }

        /// <summary> The authentication type. </summary>
        public DataBoxEdgeAuthenticationType? AuthenticationType { get; set; }
        /// <summary> The base64 encoded certificate raw data. </summary>
        public string Certificate { get; }
    }
}
