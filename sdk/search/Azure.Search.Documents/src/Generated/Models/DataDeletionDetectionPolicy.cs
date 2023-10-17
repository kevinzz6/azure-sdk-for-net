// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary>
    /// Base type for data deletion detection policies.
    /// Please note <see cref="DataDeletionDetectionPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="NativeBlobSoftDeleteDeletionDetectionPolicy"/> and <see cref="SoftDeleteColumnDeletionDetectionPolicy"/>.
    /// </summary>
    public partial class DataDeletionDetectionPolicy
    {
        /// <summary> Initializes a new instance of DataDeletionDetectionPolicy. </summary>
        /// <param name="oDataType"> Identifies the concrete type of the data deletion detection policy. </param>
        internal DataDeletionDetectionPolicy(string oDataType)
        {
            ODataType = oDataType;
        }

        /// <summary> Identifies the concrete type of the data deletion detection policy. </summary>
        internal string ODataType { get; set; }
    }
}
