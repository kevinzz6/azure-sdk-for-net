// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// Base class common to RestoreTargetInfo and RestoreFilesTargetInfo
    /// Please note <see cref="RestoreTargetInfoBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ItemLevelRestoreTargetInfo"/>, <see cref="RestoreFilesTargetInfo"/> and <see cref="RestoreTargetInfo"/>.
    /// </summary>
    public abstract partial class RestoreTargetInfoBase
    {
        /// <summary> Initializes a new instance of RestoreTargetInfoBase. </summary>
        /// <param name="recoverySetting"> Recovery Option. </param>
        protected RestoreTargetInfoBase(RecoverySetting recoverySetting)
        {
            RecoverySetting = recoverySetting;
        }

        /// <summary> Type of Datasource object, used to initialize the right inherited type. </summary>
        internal string ObjectType { get; set; }
        /// <summary> Recovery Option. </summary>
        public RecoverySetting RecoverySetting { get; }
        /// <summary> Target Restore region. </summary>
        public AzureLocation? RestoreLocation { get; set; }
    }
}
