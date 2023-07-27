// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ServiceNetworking.Models
{
    /// <summary> The type used for update operations of the Frontend. </summary>
    public partial class FrontendPatch
    {
        /// <summary> Initializes a new instance of FrontendPatch. </summary>
        public FrontendPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
