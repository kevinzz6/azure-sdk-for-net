// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> The UnknownSimilarity. </summary>
    internal partial class UnknownSimilarity : SimilarityAlgorithm
    {
        /// <summary> Initializes a new instance of UnknownSimilarity. </summary>
        /// <param name="oDataType"></param>
        internal UnknownSimilarity(string oDataType) : base(oDataType)
        {
            ODataType = oDataType ?? "Unknown";
        }
    }
}
