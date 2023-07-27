// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Describes an error condition for the Azure Cognitive Search API. </summary>
    internal partial class SearchServiceError
    {
        /// <summary> Initializes a new instance of SearchServiceError. </summary>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="message"/> is null. </exception>
        internal SearchServiceError(string message)
        {
            Argument.AssertNotNull(message, nameof(message));

            Message = message;
            Details = new ChangeTrackingList<SearchServiceError>();
        }

        /// <summary> Initializes a new instance of SearchServiceError. </summary>
        /// <param name="code"> One of a server-defined set of error codes. </param>
        /// <param name="message"> A human-readable representation of the error. </param>
        /// <param name="details"> An array of details about specific errors that led to this reported error. </param>
        internal SearchServiceError(string code, string message, IReadOnlyList<SearchServiceError> details)
        {
            Code = code;
            Message = message;
            Details = details;
        }

        /// <summary> One of a server-defined set of error codes. </summary>
        public string Code { get; }
        /// <summary> A human-readable representation of the error. </summary>
        public string Message { get; }
        /// <summary> An array of details about specific errors that led to this reported error. </summary>
        public IReadOnlyList<SearchServiceError> Details { get; }
    }
}
