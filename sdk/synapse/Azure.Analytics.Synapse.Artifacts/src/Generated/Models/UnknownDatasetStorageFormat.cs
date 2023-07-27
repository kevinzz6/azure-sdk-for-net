// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The UnknownDatasetStorageFormat. </summary>
    internal partial class UnknownDatasetStorageFormat : DatasetStorageFormat
    {
        /// <summary> Initializes a new instance of UnknownDatasetStorageFormat. </summary>
        /// <param name="type"> Type of dataset storage format. </param>
        /// <param name="serializer"> Serializer. Type: string (or Expression with resultType string). </param>
        /// <param name="deserializer"> Deserializer. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownDatasetStorageFormat(string type, object serializer, object deserializer, IDictionary<string, object> additionalProperties) : base(type, serializer, deserializer, additionalProperties)
        {
            Type = type ?? "Unknown";
        }
    }
}
