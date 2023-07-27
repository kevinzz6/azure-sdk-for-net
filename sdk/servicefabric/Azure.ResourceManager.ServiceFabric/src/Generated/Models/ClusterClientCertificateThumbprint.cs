// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Describes the client certificate details using thumbprint. </summary>
    public partial class ClusterClientCertificateThumbprint
    {
        /// <summary> Initializes a new instance of ClusterClientCertificateThumbprint. </summary>
        /// <param name="isAdmin"> Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster. </param>
        /// <param name="certificateThumbprint"> The thumbprint of the client certificate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certificateThumbprint"/> is null. </exception>
        public ClusterClientCertificateThumbprint(bool isAdmin, BinaryData certificateThumbprint)
        {
            Argument.AssertNotNull(certificateThumbprint, nameof(certificateThumbprint));

            IsAdmin = isAdmin;
            CertificateThumbprint = certificateThumbprint;
        }

        /// <summary> Indicates if the client certificate has admin access to the cluster. Non admin clients can perform only read only operations on the cluster. </summary>
        public bool IsAdmin { get; set; }
        /// <summary>
        /// The thumbprint of the client certificate.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData CertificateThumbprint { get; set; }
    }
}
