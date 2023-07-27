// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Communication.Identity;
using Azure.Core;

namespace Azure.Communication.Identity.Models
{
    /// <summary> The CommunicationIdentityAccessTokenRequest. </summary>
    internal partial class CommunicationIdentityAccessTokenRequest
    {
        /// <summary> Initializes a new instance of CommunicationIdentityAccessTokenRequest. </summary>
        /// <param name="scopes"> List of scopes attached to the token. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="scopes"/> is null. </exception>
        public CommunicationIdentityAccessTokenRequest(IEnumerable<CommunicationTokenScope> scopes)
        {
            Argument.AssertNotNull(scopes, nameof(scopes));

            Scopes = scopes.ToList();
        }

        /// <summary> List of scopes attached to the token. </summary>
        public IList<CommunicationTokenScope> Scopes { get; }
        /// <summary> Optional custom validity period of the token within [60,1440] minutes range. If not provided, the default value of 1440 minutes (24 hours) will be used. </summary>
        public int? ExpiresInMinutes { get; set; }
    }
}
