// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Time series hierarchy organizes time series instances into a tree. </summary>
    public partial class TimeSeriesHierarchy
    {
        /// <summary> Initializes a new instance of TimeSeriesHierarchy. </summary>
        /// <param name="name"> User-given unique name for the type. It is mutable and not null. </param>
        /// <param name="source"> Definition of how time series hierarchy tree levels are created. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="source"/> is null. </exception>
        public TimeSeriesHierarchy(string name, TimeSeriesHierarchySource source)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(source, nameof(source));

            Name = name;
            Source = source;
        }

        /// <summary> Initializes a new instance of TimeSeriesHierarchy. </summary>
        /// <param name="id"> Case-sensitive unique hierarchy identifier. Can be null while creating hierarchy objects and then server generates the id, not null on get and delete operations. </param>
        /// <param name="name"> User-given unique name for the type. It is mutable and not null. </param>
        /// <param name="source"> Definition of how time series hierarchy tree levels are created. </param>
        internal TimeSeriesHierarchy(string id, string name, TimeSeriesHierarchySource source)
        {
            Id = id;
            Name = name;
            Source = source;
        }

        /// <summary> Case-sensitive unique hierarchy identifier. Can be null while creating hierarchy objects and then server generates the id, not null on get and delete operations. </summary>
        public string Id { get; set; }
        /// <summary> User-given unique name for the type. It is mutable and not null. </summary>
        public string Name { get; set; }
        /// <summary> Definition of how time series hierarchy tree levels are created. </summary>
        public TimeSeriesHierarchySource Source { get; set; }
    }
}
