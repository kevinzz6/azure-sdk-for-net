// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> A JSONPatch document as defined by RFC 6902. </summary>
    public partial class JsonPatchDocument
    {
        /// <summary> Initializes a new instance of JsonPatchDocument. </summary>
        /// <param name="op"> The operation to be performed. </param>
        /// <param name="path"> A JSON-Pointer. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="path"/> is null. </exception>
        public JsonPatchDocument(JsonPatchOperation op, string path)
        {
            Argument.AssertNotNull(path, nameof(path));

            Op = op;
            Path = path;
        }

        /// <summary> The operation to be performed. </summary>
        public JsonPatchOperation Op { get; }
        /// <summary> A JSON-Pointer. </summary>
        public string Path { get; }
        /// <summary> A value to be used in the operation on the path. </summary>
        public object Value { get; set; }
        /// <summary> Optional field used in copy and move operations. </summary>
        public string From { get; set; }
    }
}
