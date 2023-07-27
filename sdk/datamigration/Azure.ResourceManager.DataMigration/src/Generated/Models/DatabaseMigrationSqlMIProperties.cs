// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Database Migration Resource properties for SQL Managed Instance. </summary>
    public partial class DatabaseMigrationSqlMIProperties : DatabaseMigrationProperties
    {
        /// <summary> Initializes a new instance of DatabaseMigrationSqlMIProperties. </summary>
        public DatabaseMigrationSqlMIProperties()
        {
            Kind = ResourceType.SqlMI;
        }

        /// <summary> Initializes a new instance of DatabaseMigrationSqlMIProperties. </summary>
        /// <param name="kind"></param>
        /// <param name="scope"> Resource Id of the target resource (SQL VM or SQL Managed Instance). </param>
        /// <param name="provisioningState"> Provisioning State of migration. ProvisioningState as Succeeded implies that validations have been performed and migration has started. </param>
        /// <param name="migrationStatus"> Migration status. </param>
        /// <param name="startedOn"> Database migration start time. </param>
        /// <param name="endedOn"> Database migration end time. </param>
        /// <param name="sourceSqlConnection"> Source SQL Server connection details. </param>
        /// <param name="sourceDatabaseName"> Name of the source database. </param>
        /// <param name="sourceServerName"> Name of the source sql server. </param>
        /// <param name="migrationService"> Resource Id of the Migration Service. </param>
        /// <param name="migrationOperationId"> ID tracking current migration operation. </param>
        /// <param name="migrationFailureError"> Error details in case of migration failure. </param>
        /// <param name="targetDatabaseCollation"> Database collation to be used for the target database. </param>
        /// <param name="provisioningError"> Error message for migration provisioning failure, if any. </param>
        /// <param name="migrationStatusDetails"> Detailed migration status. Not included by default. </param>
        /// <param name="backupConfiguration"> Backup configuration info. </param>
        /// <param name="offlineConfiguration"> Offline configuration. </param>
        internal DatabaseMigrationSqlMIProperties(ResourceType kind, string scope, string provisioningState, string migrationStatus, DateTimeOffset? startedOn, DateTimeOffset? endedOn, SqlConnectionInformation sourceSqlConnection, string sourceDatabaseName, string sourceServerName, string migrationService, string migrationOperationId, ErrorInfo migrationFailureError, string targetDatabaseCollation, string provisioningError, MigrationStatusDetails migrationStatusDetails, BackupConfiguration backupConfiguration, OfflineConfiguration offlineConfiguration) : base(kind, scope, provisioningState, migrationStatus, startedOn, endedOn, sourceSqlConnection, sourceDatabaseName, sourceServerName, migrationService, migrationOperationId, migrationFailureError, targetDatabaseCollation, provisioningError)
        {
            MigrationStatusDetails = migrationStatusDetails;
            BackupConfiguration = backupConfiguration;
            OfflineConfiguration = offlineConfiguration;
            Kind = kind;
        }

        /// <summary> Detailed migration status. Not included by default. </summary>
        public MigrationStatusDetails MigrationStatusDetails { get; }
        /// <summary> Backup configuration info. </summary>
        public BackupConfiguration BackupConfiguration { get; set; }
        /// <summary> Offline configuration. </summary>
        public OfflineConfiguration OfflineConfiguration { get; set; }
    }
}
