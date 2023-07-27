// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of Azure Spring Apps SKU and a possible link for next set. </summary>
    internal partial class ResourceSkuList
    {
        /// <summary> Initializes a new instance of ResourceSkuList. </summary>
        internal ResourceSkuList()
        {
            Value = new ChangeTrackingList<AvailableAppPlatformSku>();
        }

        /// <summary> Initializes a new instance of ResourceSkuList. </summary>
        /// <param name="value"> Collection of resource SKU. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        internal ResourceSkuList(IReadOnlyList<AvailableAppPlatformSku> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of resource SKU. </summary>
        public IReadOnlyList<AvailableAppPlatformSku> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
