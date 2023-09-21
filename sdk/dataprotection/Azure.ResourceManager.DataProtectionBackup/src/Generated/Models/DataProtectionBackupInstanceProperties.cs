// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Backup Instance. </summary>
    public partial class DataProtectionBackupInstanceProperties
    {
        /// <summary> Initializes a new instance of DataProtectionBackupInstanceProperties. </summary>
        /// <param name="dataSourceInfo"> Gets or sets the data source information. </param>
        /// <param name="policyInfo"> Gets or sets the policy information. </param>
        /// <param name="objectType"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceInfo"/>, <paramref name="policyInfo"/> or <paramref name="objectType"/> is null. </exception>
        public DataProtectionBackupInstanceProperties(DataSourceInfo dataSourceInfo, BackupInstancePolicyInfo policyInfo, string objectType)
        {
            Argument.AssertNotNull(dataSourceInfo, nameof(dataSourceInfo));
            Argument.AssertNotNull(policyInfo, nameof(policyInfo));
            Argument.AssertNotNull(objectType, nameof(objectType));

            DataSourceInfo = dataSourceInfo;
            PolicyInfo = policyInfo;
            ObjectType = objectType;
        }

        /// <summary> Initializes a new instance of DataProtectionBackupInstanceProperties. </summary>
        /// <param name="friendlyName"> Gets or sets the Backup Instance friendly name. </param>
        /// <param name="dataSourceInfo"> Gets or sets the data source information. </param>
        /// <param name="dataSourceSetInfo"> Gets or sets the data source set information. </param>
        /// <param name="policyInfo"> Gets or sets the policy information. </param>
        /// <param name="protectionStatus"> Specifies the protection status of the resource. </param>
        /// <param name="currentProtectionState"> Specifies the current protection state of the resource. </param>
        /// <param name="protectionErrorDetails"> Specifies the protection error of the resource. </param>
        /// <param name="provisioningState"> Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed. </param>
        /// <param name="dataSourceAuthCredentials">
        /// Credentials to use to authenticate with data source provider.
        /// Please note <see cref="DataProtectionBackupAuthCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecretStoreBasedAuthCredentials"/>.
        /// </param>
        /// <param name="validationType"> Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API will run again. </param>
        /// <param name="identityDetails">
        /// Contains information of the Identity Details for the BI.
        /// If it is null, default will be considered as System Assigned.
        /// </param>
        /// <param name="objectType"></param>
        internal DataProtectionBackupInstanceProperties(string friendlyName, DataSourceInfo dataSourceInfo, DataSourceSetInfo dataSourceSetInfo, BackupInstancePolicyInfo policyInfo, BackupInstanceProtectionStatusDetails protectionStatus, CurrentProtectionState? currentProtectionState, ResponseError protectionErrorDetails, string provisioningState, DataProtectionBackupAuthCredentials dataSourceAuthCredentials, BackupValidationType? validationType, DataProtectionIdentityDetails identityDetails, string objectType)
        {
            FriendlyName = friendlyName;
            DataSourceInfo = dataSourceInfo;
            DataSourceSetInfo = dataSourceSetInfo;
            PolicyInfo = policyInfo;
            ProtectionStatus = protectionStatus;
            CurrentProtectionState = currentProtectionState;
            ProtectionErrorDetails = protectionErrorDetails;
            ProvisioningState = provisioningState;
            DataSourceAuthCredentials = dataSourceAuthCredentials;
            ValidationType = validationType;
            IdentityDetails = identityDetails;
            ObjectType = objectType;
        }

        /// <summary> Gets or sets the Backup Instance friendly name. </summary>
        public string FriendlyName { get; set; }
        /// <summary> Gets or sets the data source information. </summary>
        public DataSourceInfo DataSourceInfo { get; set; }
        /// <summary> Gets or sets the data source set information. </summary>
        public DataSourceSetInfo DataSourceSetInfo { get; set; }
        /// <summary> Gets or sets the policy information. </summary>
        public BackupInstancePolicyInfo PolicyInfo { get; set; }
        /// <summary> Specifies the protection status of the resource. </summary>
        public BackupInstanceProtectionStatusDetails ProtectionStatus { get; }
        /// <summary> Specifies the current protection state of the resource. </summary>
        public CurrentProtectionState? CurrentProtectionState { get; }
        /// <summary> Specifies the protection error of the resource. </summary>
        public ResponseError ProtectionErrorDetails { get; }
        /// <summary> Specifies the provisioning state of the resource i.e. provisioning/updating/Succeeded/Failed. </summary>
        public string ProvisioningState { get; }
        /// <summary>
        /// Credentials to use to authenticate with data source provider.
        /// Please note <see cref="DataProtectionBackupAuthCredentials"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="SecretStoreBasedAuthCredentials"/>.
        /// </summary>
        public DataProtectionBackupAuthCredentials DataSourceAuthCredentials { get; set; }
        /// <summary> Specifies the type of validation. In case of DeepValidation, all validations from /validateForBackup API will run again. </summary>
        public BackupValidationType? ValidationType { get; set; }
        /// <summary>
        /// Contains information of the Identity Details for the BI.
        /// If it is null, default will be considered as System Assigned.
        /// </summary>
        public DataProtectionIdentityDetails IdentityDetails { get; set; }
        /// <summary> Gets or sets the object type. </summary>
        public string ObjectType { get; set; }
    }
}
