// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.ContainerService.Models
{
    /// <summary> For example, between '2022-12-23' and '2023-01-05'. </summary>
    public partial class ContainerServiceDateSpan
    {
        /// <summary> Initializes a new instance of ContainerServiceDateSpan. </summary>
        /// <param name="start"> The start date of the date span. </param>
        /// <param name="end"> The end date of the date span. </param>
        public ContainerServiceDateSpan(DateTimeOffset start, DateTimeOffset end)
        {
            Start = start;
            End = end;
        }

        /// <summary> The start date of the date span. </summary>
        public DateTimeOffset Start { get; set; }
        /// <summary> The end date of the date span. </summary>
        public DateTimeOffset End { get; set; }
    }
}
