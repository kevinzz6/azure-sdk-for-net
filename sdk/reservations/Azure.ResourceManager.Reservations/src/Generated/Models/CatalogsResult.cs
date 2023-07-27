// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> The list of catalogs and pagination information. </summary>
    internal partial class CatalogsResult
    {
        /// <summary> Initializes a new instance of CatalogsResult. </summary>
        internal CatalogsResult()
        {
            Value = new ChangeTrackingList<ReservationCatalog>();
        }

        /// <summary> Initializes a new instance of CatalogsResult. </summary>
        /// <param name="value"> The list of catalogs. </param>
        /// <param name="nextLink"> The link (url) to the next page of results. </param>
        /// <param name="totalItems"> The total amount of catalog items. </param>
        internal CatalogsResult(IReadOnlyList<ReservationCatalog> value, string nextLink, long? totalItems)
        {
            Value = value;
            NextLink = nextLink;
            TotalItems = totalItems;
        }

        /// <summary> The list of catalogs. </summary>
        public IReadOnlyList<ReservationCatalog> Value { get; }
        /// <summary> The link (url) to the next page of results. </summary>
        public string NextLink { get; }
        /// <summary> The total amount of catalog items. </summary>
        public long? TotalItems { get; }
    }
}
