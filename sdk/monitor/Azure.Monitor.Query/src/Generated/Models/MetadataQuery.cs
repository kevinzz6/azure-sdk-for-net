// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Queries are stored pieces of KQL, along with a list of relevant metadata items. </summary>
    internal partial class MetadataQuery
    {
        /// <summary> Initializes a new instance of MetadataQuery. </summary>
        /// <param name="id"> The ID of the query. </param>
        /// <param name="body"> The KQL body of the query. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="body"/> is null. </exception>
        internal MetadataQuery(string id, string body)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(body, nameof(body));

            Id = id;
            Body = body;
            Labels = new ChangeTrackingList<string>();
        }

        /// <summary> The ID of the query. </summary>
        public string Id { get; }
        /// <summary> The display name of the query. </summary>
        public string DisplayName { get; }
        /// <summary> The description of the query. </summary>
        public string Description { get; }
        /// <summary> The KQL body of the query. </summary>
        public string Body { get; }
        /// <summary> The user defined labels associated with the query. </summary>
        public IReadOnlyList<string> Labels { get; }
        /// <summary> The tags associated with the query. </summary>
        public object Tags { get; }
        /// <summary> The properties of the query. </summary>
        public object Properties { get; }
        /// <summary> The related metadata items for the query. </summary>
        public MetadataQueryRelated Related { get; }
    }
}
