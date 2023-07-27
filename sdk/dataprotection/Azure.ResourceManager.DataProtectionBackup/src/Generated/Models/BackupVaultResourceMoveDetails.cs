// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> ResourceMoveDetails will be returned in response to GetResource call from ARM. </summary>
    public partial class BackupVaultResourceMoveDetails
    {
        /// <summary> Initializes a new instance of BackupVaultResourceMoveDetails. </summary>
        internal BackupVaultResourceMoveDetails()
        {
        }

        /// <summary> Initializes a new instance of BackupVaultResourceMoveDetails. </summary>
        /// <param name="operationId"> CorrelationId of latest ResourceMove operation attempted. </param>
        /// <param name="startOn"> Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format. </param>
        /// <param name="completeOn"> Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format. </param>
        /// <param name="sourceResourcePath"> ARM resource path of source resource. </param>
        /// <param name="targetResourcePath"> ARM resource path of target resource used in latest ResourceMove operation. </param>
        internal BackupVaultResourceMoveDetails(string operationId, DateTimeOffset? startOn, DateTimeOffset? completeOn, string sourceResourcePath, string targetResourcePath)
        {
            OperationId = operationId;
            StartOn = startOn;
            CompleteOn = completeOn;
            SourceResourcePath = sourceResourcePath;
            TargetResourcePath = targetResourcePath;
        }

        /// <summary> CorrelationId of latest ResourceMove operation attempted. </summary>
        public string OperationId { get; }
        /// <summary> Start time in UTC of latest ResourceMove operation attempted. ISO 8601 format. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> Completion time in UTC of latest ResourceMove operation attempted. ISO 8601 format. </summary>
        public DateTimeOffset? CompleteOn { get; }
        /// <summary> ARM resource path of source resource. </summary>
        public string SourceResourcePath { get; }
        /// <summary> ARM resource path of target resource used in latest ResourceMove operation. </summary>
        public string TargetResourcePath { get; }
    }
}
