// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Integration runtime reference type. </summary>
    public partial class IntegrationRuntimeReference
    {
        /// <summary> Initializes a new instance of IntegrationRuntimeReference. </summary>
        /// <param name="type"> Type of integration runtime. </param>
        /// <param name="referenceName"> Reference integration runtime name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="referenceName"/> is null. </exception>
        public IntegrationRuntimeReference(IntegrationRuntimeReferenceType type, string referenceName)
        {
            Argument.AssertNotNull(referenceName, nameof(referenceName));

            Type = type;
            ReferenceName = referenceName;
            Parameters = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of IntegrationRuntimeReference. </summary>
        /// <param name="type"> Type of integration runtime. </param>
        /// <param name="referenceName"> Reference integration runtime name. </param>
        /// <param name="parameters"> Arguments for integration runtime. </param>
        internal IntegrationRuntimeReference(IntegrationRuntimeReferenceType type, string referenceName, IDictionary<string, object> parameters)
        {
            Type = type;
            ReferenceName = referenceName;
            Parameters = parameters;
        }

        /// <summary> Type of integration runtime. </summary>
        public IntegrationRuntimeReferenceType Type { get; set; }
        /// <summary> Reference integration runtime name. </summary>
        public string ReferenceName { get; set; }
        /// <summary> Arguments for integration runtime. </summary>
        public IDictionary<string, object> Parameters { get; }
    }
}
