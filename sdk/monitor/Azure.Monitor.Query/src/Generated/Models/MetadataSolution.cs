// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Monitor.Query.Models
{
    /// <summary> Solutions can group tables and functions that are associated with a certain Azure Log Analytics offering. </summary>
    internal partial class MetadataSolution
    {
        /// <summary> Initializes a new instance of MetadataSolution. </summary>
        /// <param name="id"> The ID of the Log Analytics solution. </param>
        /// <param name="name"> The name of the Log Analytics solution. </param>
        /// <param name="related"> The related metadata items for the Log Analytics solution. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/>, <paramref name="name"/> or <paramref name="related"/> is null. </exception>
        internal MetadataSolution(string id, string name, MetadataSolutionRelated related)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(related, nameof(related));

            Id = id;
            Name = name;
            Related = related;
        }

        /// <summary> The ID of the Log Analytics solution. </summary>
        public string Id { get; }
        /// <summary> The name of the Log Analytics solution. </summary>
        public string Name { get; }
        /// <summary> The display name of the Log Analytics solution. </summary>
        public string DisplayName { get; }
        /// <summary> The description of the Log Analytics solution. </summary>
        public string Description { get; }
        /// <summary> The tags that are associated with the Log Analytics solution. </summary>
        public object Tags { get; }
        /// <summary> The properties of the Log Analytics solution. </summary>
        public object Properties { get; }
        /// <summary> The related metadata items for the Log Analytics solution. </summary>
        public MetadataSolutionRelated Related { get; }
    }
}
