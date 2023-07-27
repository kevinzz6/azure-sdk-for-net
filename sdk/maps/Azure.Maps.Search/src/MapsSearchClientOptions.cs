// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Maps.Search
{
    /// <summary> Client options for SearchClient. </summary>
    public partial class MapsSearchClientOptions : ClientOptions
    {
        internal const ServiceVersion LatestVersion = ServiceVersion.V1_0;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "1.0". </summary>
            V1_0 = 1,
        }

        internal string Version { get; }

        /// <summary> The Azure Maps endpoint for requests. </summary>
        public Uri Endpoint { get; set; }

        /// <summary> Initializes new instance of SearchClientOptions. </summary>
        public MapsSearchClientOptions(ServiceVersion version = LatestVersion, Uri endpoint = null)
        {
            Version = version switch
            {
                ServiceVersion.V1_0 => "1.0",
                _ => throw new NotSupportedException()
            };

            Endpoint = endpoint;
        }
    }
}
