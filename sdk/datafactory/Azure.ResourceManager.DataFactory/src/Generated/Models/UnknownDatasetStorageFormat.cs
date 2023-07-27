// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> The UnknownDatasetStorageFormat. </summary>
    internal partial class UnknownDatasetStorageFormat : DatasetStorageFormat
    {
        /// <summary> Initializes a new instance of UnknownDatasetStorageFormat. </summary>
        /// <param name="datasetStorageFormatType"> Type of dataset storage format. </param>
        /// <param name="serializer"> Serializer. Type: string (or Expression with resultType string). </param>
        /// <param name="deserializer"> Deserializer. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownDatasetStorageFormat(string datasetStorageFormatType, DataFactoryElement<string> serializer, DataFactoryElement<string> deserializer, IDictionary<string, BinaryData> additionalProperties) : base(datasetStorageFormatType, serializer, deserializer, additionalProperties)
        {
            DatasetStorageFormatType = datasetStorageFormatType ?? "Unknown";
        }
    }
}
