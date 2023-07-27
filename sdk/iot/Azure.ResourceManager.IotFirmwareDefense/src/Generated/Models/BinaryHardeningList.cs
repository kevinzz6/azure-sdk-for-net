// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> List result for binary hardening. </summary>
    internal partial class BinaryHardeningList
    {
        /// <summary> Initializes a new instance of BinaryHardeningList. </summary>
        internal BinaryHardeningList()
        {
            Value = new ChangeTrackingList<BinaryHardening>();
        }

        /// <summary> Initializes a new instance of BinaryHardeningList. </summary>
        /// <param name="value"> The list of binary hardening results. </param>
        /// <param name="nextLink"> The uri to fetch the next page of asset. </param>
        internal BinaryHardeningList(IReadOnlyList<BinaryHardening> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of binary hardening results. </summary>
        public IReadOnlyList<BinaryHardening> Value { get; }
        /// <summary> The uri to fetch the next page of asset. </summary>
        public string NextLink { get; }
    }
}
