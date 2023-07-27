// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> List response for get ShareSynchronization. </summary>
    internal partial class ShareSynchronizationList
    {
        /// <summary> Initializes a new instance of ShareSynchronizationList. </summary>
        /// <param name="value"> Collection of items of type DataTransferObjects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ShareSynchronizationList(IEnumerable<ShareSynchronization> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ShareSynchronizationList. </summary>
        /// <param name="nextLink"> The Url of next result page. </param>
        /// <param name="value"> Collection of items of type DataTransferObjects. </param>
        internal ShareSynchronizationList(string nextLink, IReadOnlyList<ShareSynchronization> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The Url of next result page. </summary>
        public string NextLink { get; }
        /// <summary> Collection of items of type DataTransferObjects. </summary>
        public IReadOnlyList<ShareSynchronization> Value { get; }
    }
}
