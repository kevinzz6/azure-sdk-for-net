// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Chaos.Models
{
    /// <summary> The UnknownFilter. </summary>
    internal partial class UnknownFilter : Filter
    {
        /// <summary> Initializes a new instance of UnknownFilter. </summary>
        /// <param name="filterType"> Enum that discriminates between filter types. Currently only `Simple` type is supported. </param>
        internal UnknownFilter(FilterType filterType) : base(filterType)
        {
            FilterType = filterType;
        }
    }
}
