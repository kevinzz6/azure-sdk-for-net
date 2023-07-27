// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Containers.ContainerRegistry
{
    /// <summary> Tag attribute details. </summary>
    internal partial class TagAttributesBase
    {
        /// <summary> Initializes a new instance of TagAttributesBase. </summary>
        /// <param name="name"> Tag name. </param>
        /// <param name="digest"> Tag digest. </param>
        /// <param name="createdOn"> Tag created time. </param>
        /// <param name="lastUpdatedOn"> Tag last update time. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="digest"/> is null. </exception>
        internal TagAttributesBase(string name, string digest, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(digest, nameof(digest));

            Name = name;
            Digest = digest;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
        }

        /// <summary> Initializes a new instance of TagAttributesBase. </summary>
        /// <param name="name"> Tag name. </param>
        /// <param name="digest"> Tag digest. </param>
        /// <param name="createdOn"> Tag created time. </param>
        /// <param name="lastUpdatedOn"> Tag last update time. </param>
        /// <param name="canDelete"> Delete enabled. </param>
        /// <param name="canWrite"> Write enabled. </param>
        /// <param name="canList"> List enabled. </param>
        /// <param name="canRead"> Read enabled. </param>
        internal TagAttributesBase(string name, string digest, DateTimeOffset createdOn, DateTimeOffset lastUpdatedOn, bool? canDelete, bool? canWrite, bool? canList, bool? canRead)
        {
            Name = name;
            Digest = digest;
            CreatedOn = createdOn;
            LastUpdatedOn = lastUpdatedOn;
            CanDelete = canDelete;
            CanWrite = canWrite;
            CanList = canList;
            CanRead = canRead;
        }

        /// <summary> Tag name. </summary>
        public string Name { get; }
        /// <summary> Tag digest. </summary>
        public string Digest { get; }
        /// <summary> Tag created time. </summary>
        public DateTimeOffset CreatedOn { get; }
        /// <summary> Tag last update time. </summary>
        public DateTimeOffset LastUpdatedOn { get; }
        /// <summary> Delete enabled. </summary>
        public bool? CanDelete { get; }
        /// <summary> Write enabled. </summary>
        public bool? CanWrite { get; }
        /// <summary> List enabled. </summary>
        public bool? CanList { get; }
        /// <summary> Read enabled. </summary>
        public bool? CanRead { get; }
    }
}
