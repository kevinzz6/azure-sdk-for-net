// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> The UnknownBasePolicyRule. </summary>
    internal partial class UnknownBasePolicyRule : DataProtectionBasePolicyRule
    {
        /// <summary> Initializes a new instance of UnknownBasePolicyRule. </summary>
        /// <param name="name"></param>
        /// <param name="objectType"></param>
        internal UnknownBasePolicyRule(string name, string objectType) : base(name, objectType)
        {
            ObjectType = objectType ?? "Unknown";
        }
    }
}
