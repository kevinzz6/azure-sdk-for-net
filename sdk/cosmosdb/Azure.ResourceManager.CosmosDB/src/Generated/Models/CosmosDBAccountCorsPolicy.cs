// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CORS policy for the Cosmos DB database account. </summary>
    public partial class CosmosDBAccountCorsPolicy
    {
        /// <summary> Initializes a new instance of CosmosDBAccountCorsPolicy. </summary>
        /// <param name="allowedOrigins"> The origin domains that are permitted to make a request against the service via CORS. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allowedOrigins"/> is null. </exception>
        public CosmosDBAccountCorsPolicy(string allowedOrigins)
        {
            Argument.AssertNotNull(allowedOrigins, nameof(allowedOrigins));

            AllowedOrigins = allowedOrigins;
        }

        /// <summary> Initializes a new instance of CosmosDBAccountCorsPolicy. </summary>
        /// <param name="allowedOrigins"> The origin domains that are permitted to make a request against the service via CORS. </param>
        /// <param name="allowedMethods"> The methods (HTTP request verbs) that the origin domain may use for a CORS request. </param>
        /// <param name="allowedHeaders"> The request headers that the origin domain may specify on the CORS request. </param>
        /// <param name="exposedHeaders"> The response headers that may be sent in the response to the CORS request and exposed by the browser to the request issuer. </param>
        /// <param name="maxAgeInSeconds"> The maximum amount time that a browser should cache the preflight OPTIONS request. </param>
        internal CosmosDBAccountCorsPolicy(string allowedOrigins, string allowedMethods, string allowedHeaders, string exposedHeaders, long? maxAgeInSeconds)
        {
            AllowedOrigins = allowedOrigins;
            AllowedMethods = allowedMethods;
            AllowedHeaders = allowedHeaders;
            ExposedHeaders = exposedHeaders;
            MaxAgeInSeconds = maxAgeInSeconds;
        }

        /// <summary> The origin domains that are permitted to make a request against the service via CORS. </summary>
        public string AllowedOrigins { get; set; }
        /// <summary> The methods (HTTP request verbs) that the origin domain may use for a CORS request. </summary>
        public string AllowedMethods { get; set; }
        /// <summary> The request headers that the origin domain may specify on the CORS request. </summary>
        public string AllowedHeaders { get; set; }
        /// <summary> The response headers that may be sent in the response to the CORS request and exposed by the browser to the request issuer. </summary>
        public string ExposedHeaders { get; set; }
        /// <summary> The maximum amount time that a browser should cache the preflight OPTIONS request. </summary>
        public long? MaxAgeInSeconds { get; set; }
    }
}
