// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary>
    /// BackupCriteria base class
    /// Please note <see cref="DataProtectionBackupCriteria"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="ScheduleBasedBackupCriteria"/>.
    /// </summary>
    public abstract partial class DataProtectionBackupCriteria
    {
        /// <summary> Initializes a new instance of DataProtectionBackupCriteria. </summary>
        protected DataProtectionBackupCriteria()
        {
        }

        /// <summary> Initializes a new instance of DataProtectionBackupCriteria. </summary>
        /// <param name="objectType"> Type of the specific object - used for deserializing. </param>
        internal DataProtectionBackupCriteria(string objectType)
        {
            ObjectType = objectType;
        }

        /// <summary> Type of the specific object - used for deserializing. </summary>
        internal string ObjectType { get; set; }
    }
}
