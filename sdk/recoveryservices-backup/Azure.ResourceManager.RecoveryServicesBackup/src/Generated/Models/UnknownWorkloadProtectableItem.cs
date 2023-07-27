// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary> The UnknownWorkloadProtectableItem. </summary>
    internal partial class UnknownWorkloadProtectableItem : WorkloadProtectableItem
    {
        /// <summary> Initializes a new instance of UnknownWorkloadProtectableItem. </summary>
        /// <param name="backupManagementType"> Type of backup management to backup an item. </param>
        /// <param name="workloadType"> Type of workload for the backup management. </param>
        /// <param name="protectableItemType"> Type of the backup item. </param>
        /// <param name="friendlyName"> Friendly name of the backup item. </param>
        /// <param name="protectionState"> State of the back up item. </param>
        internal UnknownWorkloadProtectableItem(string backupManagementType, string workloadType, string protectableItemType, string friendlyName, BackupProtectionStatus? protectionState) : base(backupManagementType, workloadType, protectableItemType, friendlyName, protectionState)
        {
            ProtectableItemType = protectableItemType ?? "Unknown";
        }
    }
}
