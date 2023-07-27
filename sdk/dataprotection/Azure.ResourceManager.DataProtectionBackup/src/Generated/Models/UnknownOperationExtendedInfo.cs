// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> The UnknownOperationExtendedInfo. </summary>
    internal partial class UnknownOperationExtendedInfo : DataProtectionOperationExtendedInfo
    {
        /// <summary> Initializes a new instance of UnknownOperationExtendedInfo. </summary>
        /// <param name="objectType"> This property will be used as the discriminator for deciding the specific types in the polymorphic chain of types. </param>
        internal UnknownOperationExtendedInfo(string objectType) : base(objectType)
        {
            ObjectType = objectType ?? "Unknown";
        }
    }
}
