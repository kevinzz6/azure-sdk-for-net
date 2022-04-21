// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure storage specific job.
    /// </summary>
    public partial class AzureStorageJob : Job
    {
        /// <summary>
        /// Initializes a new instance of the AzureStorageJob class.
        /// </summary>
        public AzureStorageJob()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureStorageJob class.
        /// </summary>
        /// <param name="entityFriendlyName">Friendly name of the entity on
        /// which the current job is executing.</param>
        /// <param name="backupManagementType">Backup management type to
        /// execute the current job. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql',
        /// 'AzureStorage', 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="operation">The operation name.</param>
        /// <param name="status">Job status.</param>
        /// <param name="startTime">The start time.</param>
        /// <param name="endTime">The end time.</param>
        /// <param name="activityId">ActivityId of job.</param>
        /// <param name="duration">Time elapsed during the execution of this
        /// job.</param>
        /// <param name="actionsInfo">Gets or sets the state/actions applicable
        /// on this job like cancel/retry.</param>
        /// <param name="errorDetails">Error details on execution of this
        /// job.</param>
        /// <param name="storageAccountName">Specifies friendly name of the
        /// storage account.</param>
        /// <param name="storageAccountVersion">Specifies whether the Storage
        /// account is a Classic or an Azure Resource Manager Storage
        /// account.</param>
        /// <param name="extendedInfo">Additional information about the
        /// job.</param>
        public AzureStorageJob(string entityFriendlyName = default(string), string backupManagementType = default(string), string operation = default(string), string status = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), string activityId = default(string), System.TimeSpan? duration = default(System.TimeSpan?), IList<JobSupportedAction?> actionsInfo = default(IList<JobSupportedAction?>), IList<AzureStorageErrorInfo> errorDetails = default(IList<AzureStorageErrorInfo>), string storageAccountName = default(string), string storageAccountVersion = default(string), AzureStorageJobExtendedInfo extendedInfo = default(AzureStorageJobExtendedInfo))
            : base(entityFriendlyName, backupManagementType, operation, status, startTime, endTime, activityId)
        {
            Duration = duration;
            ActionsInfo = actionsInfo;
            ErrorDetails = errorDetails;
            StorageAccountName = storageAccountName;
            StorageAccountVersion = storageAccountVersion;
            ExtendedInfo = extendedInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time elapsed during the execution of this job.
        /// </summary>
        [JsonProperty(PropertyName = "duration")]
        public System.TimeSpan? Duration { get; set; }

        /// <summary>
        /// Gets or sets the state/actions applicable on this job like
        /// cancel/retry.
        /// </summary>
        [JsonProperty(PropertyName = "actionsInfo")]
        public IList<JobSupportedAction?> ActionsInfo { get; set; }

        /// <summary>
        /// Gets or sets error details on execution of this job.
        /// </summary>
        [JsonProperty(PropertyName = "errorDetails")]
        public IList<AzureStorageErrorInfo> ErrorDetails { get; set; }

        /// <summary>
        /// Gets or sets specifies friendly name of the storage account.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountName")]
        public string StorageAccountName { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the Storage account is a Classic or
        /// an Azure Resource Manager Storage account.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountVersion")]
        public string StorageAccountVersion { get; set; }

        /// <summary>
        /// Gets or sets additional information about the job.
        /// </summary>
        [JsonProperty(PropertyName = "extendedInfo")]
        public AzureStorageJobExtendedInfo ExtendedInfo { get; set; }

    }
}
