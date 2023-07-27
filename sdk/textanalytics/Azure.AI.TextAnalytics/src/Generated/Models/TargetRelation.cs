// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The TargetRelation. </summary>
    internal partial class TargetRelation
    {
        /// <summary> Initializes a new instance of TargetRelation. </summary>
        /// <param name="relationType"> The type related to the target. </param>
        /// <param name="ref"> The JSON pointer indicating the linked object. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ref"/> is null. </exception>
        public TargetRelation(TargetRelationType relationType, string @ref)
        {
            Argument.AssertNotNull(@ref, nameof(@ref));

            RelationType = relationType;
            Ref = @ref;
        }

        /// <summary> The type related to the target. </summary>
        public TargetRelationType RelationType { get; set; }
        /// <summary> The JSON pointer indicating the linked object. </summary>
        public string Ref { get; set; }
    }
}
