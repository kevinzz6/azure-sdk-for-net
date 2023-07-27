// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Models
{
    /// <summary> The raw concatenated strings that were sent to the semantic enrichment process. </summary>
    public partial class QueryResultDocumentRerankerInput
    {
        /// <summary> Initializes a new instance of QueryResultDocumentRerankerInput. </summary>
        internal QueryResultDocumentRerankerInput()
        {
        }

        /// <summary> Initializes a new instance of QueryResultDocumentRerankerInput. </summary>
        /// <param name="title"> The raw string for the title field that was used for semantic enrichment. </param>
        /// <param name="content"> The raw concatenated strings for the content fields that were used for semantic enrichment. </param>
        /// <param name="keywords"> The raw concatenated strings for the keyword fields that were used for semantic enrichment. </param>
        internal QueryResultDocumentRerankerInput(string title, string content, string keywords)
        {
            Title = title;
            Content = content;
            Keywords = keywords;
        }

        /// <summary> The raw string for the title field that was used for semantic enrichment. </summary>
        public string Title { get; }
        /// <summary> The raw concatenated strings for the content fields that were used for semantic enrichment. </summary>
        public string Content { get; }
        /// <summary> The raw concatenated strings for the keyword fields that were used for semantic enrichment. </summary>
        public string Keywords { get; }
    }
}
