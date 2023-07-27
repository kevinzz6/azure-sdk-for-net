// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> Groups the settings used for formatting the response if the response should be Arrow formatted. </summary>
    internal partial class ArrowTextConfigurationInternal
    {
        /// <summary> Initializes a new instance of ArrowTextConfigurationInternal. </summary>
        /// <param name="schema"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="schema"/> is null. </exception>
        public ArrowTextConfigurationInternal(IEnumerable<ArrowFieldInternal> schema)
        {
            Argument.AssertNotNull(schema, nameof(schema));

            Schema = schema.ToList();
        }

        /// <summary> Gets the schema. </summary>
        public IList<ArrowFieldInternal> Schema { get; }
    }
}
