// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> ListResource. </summary>
    internal partial class DppResourceList
    {
        /// <summary> Initializes a new instance of DppResourceList. </summary>
        internal DppResourceList()
        {
        }

        /// <summary> Initializes a new instance of DppResourceList. </summary>
        /// <param name="nextLink"> The uri to fetch the next page of resources. Call ListNext() fetches next page of resources. </param>
        internal DppResourceList(string nextLink)
        {
            NextLink = nextLink;
        }

        /// <summary> The uri to fetch the next page of resources. Call ListNext() fetches next page of resources. </summary>
        public string NextLink { get; }
    }
}
