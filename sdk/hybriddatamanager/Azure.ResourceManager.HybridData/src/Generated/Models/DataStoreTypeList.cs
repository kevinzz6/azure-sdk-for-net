// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HybridData;

namespace Azure.ResourceManager.HybridData.Models
{
    /// <summary> Data Store Type Collection. </summary>
    internal partial class DataStoreTypeList
    {
        /// <summary> Initializes a new instance of DataStoreTypeList. </summary>
        internal DataStoreTypeList()
        {
            Value = new ChangeTrackingList<HybridDataStoreTypeData>();
        }

        /// <summary> Initializes a new instance of DataStoreTypeList. </summary>
        /// <param name="value"> List of DataStoreType. </param>
        /// <param name="nextLink"> Link for the next set of data store types. </param>
        internal DataStoreTypeList(IReadOnlyList<HybridDataStoreTypeData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> List of DataStoreType. </summary>
        public IReadOnlyList<HybridDataStoreTypeData> Value { get; }
        /// <summary> Link for the next set of data store types. </summary>
        public string NextLink { get; }
    }
}
