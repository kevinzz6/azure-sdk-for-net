// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.MySql;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMySqlModelFactory
    {
        /// <summary> Initializes a new instance of MySqlServerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The Azure Active Directory identity of the server. Current supported identity types: SystemAssigned. </param>
        /// <param name="sku"> The SKU (pricing tier) of the server. </param>
        /// <param name="administratorLogin"> The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation). </param>
        /// <param name="version"> Server version. </param>
        /// <param name="sslEnforcement"> Enable ssl enforcement or not when connect to server. </param>
        /// <param name="minimalTlsVersion"> Enforce a minimal Tls version for the server. </param>
        /// <param name="byokEnforcement"> Status showing whether the server data encryption is enabled with customer-managed keys. </param>
        /// <param name="infrastructureEncryption"> Status showing whether the server enabled infrastructure encryption. </param>
        /// <param name="userVisibleState"> A state of a server that is visible to user. </param>
        /// <param name="fullyQualifiedDomainName"> The fully qualified domain name of a server. </param>
        /// <param name="earliestRestoreOn"> Earliest restore point creation time (ISO8601 format). </param>
        /// <param name="storageProfile"> Storage profile of a server. </param>
        /// <param name="replicationRole"> The replication role of the server. </param>
        /// <param name="masterServerId"> The master server id of a replica server. </param>
        /// <param name="replicaCapacity"> The maximum number of replicas that a master server can have. </param>
        /// <param name="publicNetworkAccess"> Whether or not public network access is allowed for this server. Value is optional but if passed in, must be 'Enabled' or 'Disabled'. </param>
        /// <param name="privateEndpointConnections"> List of private endpoint connections on a server. </param>
        /// <returns> A new <see cref="MySql.MySqlServerData"/> instance for mocking. </returns>
        public static MySqlServerData MySqlServerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ManagedServiceIdentity identity = null, MySqlSku sku = null, string administratorLogin = null, MySqlServerVersion? version = null, MySqlSslEnforcementEnum? sslEnforcement = null, MySqlMinimalTlsVersionEnum? minimalTlsVersion = null, string byokEnforcement = null, MySqlInfrastructureEncryption? infrastructureEncryption = null, MySqlServerState? userVisibleState = null, string fullyQualifiedDomainName = null, DateTimeOffset? earliestRestoreOn = null, MySqlStorageProfile storageProfile = null, string replicationRole = null, ResourceIdentifier masterServerId = null, int? replicaCapacity = null, MySqlPublicNetworkAccessEnum? publicNetworkAccess = null, IEnumerable<MySqlServerPrivateEndpointConnection> privateEndpointConnections = null)
        {
            tags ??= new Dictionary<string, string>();
            privateEndpointConnections ??= new List<MySqlServerPrivateEndpointConnection>();

            return new MySqlServerData(id, name, resourceType, systemData, tags, location, identity, sku, administratorLogin, version, sslEnforcement, minimalTlsVersion, byokEnforcement, infrastructureEncryption, userVisibleState, fullyQualifiedDomainName, earliestRestoreOn, storageProfile, replicationRole, masterServerId, replicaCapacity, publicNetworkAccess, privateEndpointConnections?.ToList());
        }

        /// <summary> Initializes a new instance of MySqlServerPrivateEndpointConnection. </summary>
        /// <param name="id"> Resource Id of the private endpoint connection. </param>
        /// <param name="properties"> Private endpoint connection properties. </param>
        /// <returns> A new <see cref="Models.MySqlServerPrivateEndpointConnection"/> instance for mocking. </returns>
        public static MySqlServerPrivateEndpointConnection MySqlServerPrivateEndpointConnection(ResourceIdentifier id = null, MySqlServerPrivateEndpointConnectionProperties properties = null)
        {
            return new MySqlServerPrivateEndpointConnection(id, properties);
        }

        /// <summary> Initializes a new instance of MySqlServerPrivateEndpointConnectionProperties. </summary>
        /// <param name="privateEndpointId"> Private endpoint which the connection belongs to. </param>
        /// <param name="privateLinkServiceConnectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> State of the private endpoint connection. </param>
        /// <returns> A new <see cref="Models.MySqlServerPrivateEndpointConnectionProperties"/> instance for mocking. </returns>
        public static MySqlServerPrivateEndpointConnectionProperties MySqlServerPrivateEndpointConnectionProperties(ResourceIdentifier privateEndpointId = null, MySqlServerPrivateLinkServiceConnectionStateProperty privateLinkServiceConnectionState = null, MySqlPrivateEndpointProvisioningState? provisioningState = null)
        {
            return new MySqlServerPrivateEndpointConnectionProperties(privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null, privateLinkServiceConnectionState, provisioningState);
        }

        /// <summary> Initializes a new instance of MySqlServerPrivateLinkServiceConnectionStateProperty. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> The actions required for private link service connection. </param>
        /// <returns> A new <see cref="Models.MySqlServerPrivateLinkServiceConnectionStateProperty"/> instance for mocking. </returns>
        public static MySqlServerPrivateLinkServiceConnectionStateProperty MySqlServerPrivateLinkServiceConnectionStateProperty(MySqlPrivateLinkServiceConnectionStateStatus status = default, string description = null, MySqlPrivateLinkServiceConnectionStateRequiredAction? actionsRequired = null)
        {
            return new MySqlServerPrivateLinkServiceConnectionStateProperty(status, description, actionsRequired);
        }

        /// <summary> Initializes a new instance of MySqlFirewallRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startIPAddress"> The start IP address of the server firewall rule. Must be IPv4 format. </param>
        /// <param name="endIPAddress"> The end IP address of the server firewall rule. Must be IPv4 format. </param>
        /// <returns> A new <see cref="MySql.MySqlFirewallRuleData"/> instance for mocking. </returns>
        public static MySqlFirewallRuleData MySqlFirewallRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IPAddress startIPAddress = null, IPAddress endIPAddress = null)
        {
            return new MySqlFirewallRuleData(id, name, resourceType, systemData, startIPAddress, endIPAddress);
        }

        /// <summary> Initializes a new instance of MySqlVirtualNetworkRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="virtualNetworkSubnetId"> The ARM resource id of the virtual network subnet. </param>
        /// <param name="ignoreMissingVnetServiceEndpoint"> Create firewall rule before the virtual network has vnet service endpoint enabled. </param>
        /// <param name="state"> Virtual Network Rule State. </param>
        /// <returns> A new <see cref="MySql.MySqlVirtualNetworkRuleData"/> instance for mocking. </returns>
        public static MySqlVirtualNetworkRuleData MySqlVirtualNetworkRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier virtualNetworkSubnetId = null, bool? ignoreMissingVnetServiceEndpoint = null, MySqlVirtualNetworkRuleState? state = null)
        {
            return new MySqlVirtualNetworkRuleData(id, name, resourceType, systemData, virtualNetworkSubnetId, ignoreMissingVnetServiceEndpoint, state);
        }

        /// <summary> Initializes a new instance of MySqlDatabaseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="charset"> The charset of the database. </param>
        /// <param name="collation"> The collation of the database. </param>
        /// <returns> A new <see cref="MySql.MySqlDatabaseData"/> instance for mocking. </returns>
        public static MySqlDatabaseData MySqlDatabaseData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string charset = null, string collation = null)
        {
            return new MySqlDatabaseData(id, name, resourceType, systemData, charset, collation);
        }

        /// <summary> Initializes a new instance of MySqlConfigurationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="value"> Value of the configuration. </param>
        /// <param name="description"> Description of the configuration. </param>
        /// <param name="defaultValue"> Default value of the configuration. </param>
        /// <param name="dataType"> Data type of the configuration. </param>
        /// <param name="allowedValues"> Allowed values of the configuration. </param>
        /// <param name="source"> Source of the configuration. </param>
        /// <returns> A new <see cref="MySql.MySqlConfigurationData"/> instance for mocking. </returns>
        public static MySqlConfigurationData MySqlConfigurationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string value = null, string description = null, string defaultValue = null, string dataType = null, string allowedValues = null, string source = null)
        {
            return new MySqlConfigurationData(id, name, resourceType, systemData, value, description, defaultValue, dataType, allowedValues, source);
        }

        /// <summary> Initializes a new instance of MySqlLogFile. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="sizeInKB"> Size of the log file. </param>
        /// <param name="createdOn"> Creation timestamp of the log file. </param>
        /// <param name="lastModifiedOn"> Last modified timestamp of the log file. </param>
        /// <param name="logFileType"> Type of the log file. </param>
        /// <param name="uri"> The url to download the log file from. </param>
        /// <returns> A new <see cref="Models.MySqlLogFile"/> instance for mocking. </returns>
        public static MySqlLogFile MySqlLogFile(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, long? sizeInKB = null, DateTimeOffset? createdOn = null, DateTimeOffset? lastModifiedOn = null, string logFileType = null, Uri uri = null)
        {
            return new MySqlLogFile(id, name, resourceType, systemData, sizeInKB, createdOn, lastModifiedOn, logFileType, uri);
        }

        /// <summary> Initializes a new instance of MySqlServerAdministratorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="administratorType"> The type of administrator. </param>
        /// <param name="loginAccountName"> The server administrator login account name. </param>
        /// <param name="secureId"> The server administrator Sid (Secure ID). </param>
        /// <param name="tenantId"> The server Active Directory Administrator tenant id. </param>
        /// <returns> A new <see cref="MySql.MySqlServerAdministratorData"/> instance for mocking. </returns>
        public static MySqlServerAdministratorData MySqlServerAdministratorData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, MySqlAdministratorType? administratorType = null, string loginAccountName = null, Guid? secureId = null, Guid? tenantId = null)
        {
            return new MySqlServerAdministratorData(id, name, resourceType, systemData, administratorType, loginAccountName, secureId, tenantId);
        }

        /// <summary> Initializes a new instance of MySqlRecoverableServerResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="lastAvailableBackupOn"> The last available backup date time. </param>
        /// <param name="serviceLevelObjective"> The service level objective. </param>
        /// <param name="edition"> Edition of the performance tier. </param>
        /// <param name="vCores"> vCore associated with the service level objective. </param>
        /// <param name="hardwareGeneration"> Hardware generation associated with the service level objective. </param>
        /// <param name="version"> The MySQL version. </param>
        /// <returns> A new <see cref="Models.MySqlRecoverableServerResourceData"/> instance for mocking. </returns>
        public static MySqlRecoverableServerResourceData MySqlRecoverableServerResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DateTimeOffset? lastAvailableBackupOn = null, string serviceLevelObjective = null, string edition = null, int? vCores = null, string hardwareGeneration = null, string version = null)
        {
            return new MySqlRecoverableServerResourceData(id, name, resourceType, systemData, lastAvailableBackupOn, serviceLevelObjective, edition, vCores, hardwareGeneration, version);
        }

        /// <summary> Initializes a new instance of MySqlPerformanceTier. </summary>
        /// <param name="id"> ID of the performance tier. </param>
        /// <param name="maxBackupRetentionDays"> Maximum Backup retention in days for the performance tier edition. </param>
        /// <param name="minBackupRetentionDays"> Minimum Backup retention in days for the performance tier edition. </param>
        /// <param name="maxStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="minLargeStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="maxLargeStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="minStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="serviceLevelObjectives"> Service level objectives associated with the performance tier. </param>
        /// <returns> A new <see cref="Models.MySqlPerformanceTier"/> instance for mocking. </returns>
        public static MySqlPerformanceTier MySqlPerformanceTier(string id = null, int? maxBackupRetentionDays = null, int? minBackupRetentionDays = null, int? maxStorageInMB = null, int? minLargeStorageInMB = null, int? maxLargeStorageInMB = null, int? minStorageInMB = null, IEnumerable<MySqlPerformanceTierServiceLevelObjectives> serviceLevelObjectives = null)
        {
            serviceLevelObjectives ??= new List<MySqlPerformanceTierServiceLevelObjectives>();

            return new MySqlPerformanceTier(id, maxBackupRetentionDays, minBackupRetentionDays, maxStorageInMB, minLargeStorageInMB, maxLargeStorageInMB, minStorageInMB, serviceLevelObjectives?.ToList());
        }

        /// <summary> Initializes a new instance of MySqlPerformanceTierServiceLevelObjectives. </summary>
        /// <param name="id"> ID for the service level objective. </param>
        /// <param name="edition"> Edition of the performance tier. </param>
        /// <param name="vCores"> vCore associated with the service level objective. </param>
        /// <param name="hardwareGeneration"> Hardware generation associated with the service level objective. </param>
        /// <param name="maxBackupRetentionDays"> Maximum Backup retention in days for the performance tier edition. </param>
        /// <param name="minBackupRetentionDays"> Minimum Backup retention in days for the performance tier edition. </param>
        /// <param name="maxStorageInMB"> Max storage allowed for a server. </param>
        /// <param name="minStorageInMB"> Max storage allowed for a server. </param>
        /// <returns> A new <see cref="Models.MySqlPerformanceTierServiceLevelObjectives"/> instance for mocking. </returns>
        public static MySqlPerformanceTierServiceLevelObjectives MySqlPerformanceTierServiceLevelObjectives(string id = null, string edition = null, int? vCores = null, string hardwareGeneration = null, int? maxBackupRetentionDays = null, int? minBackupRetentionDays = null, int? maxStorageInMB = null, int? minStorageInMB = null)
        {
            return new MySqlPerformanceTierServiceLevelObjectives(id, edition, vCores, hardwareGeneration, maxBackupRetentionDays, minBackupRetentionDays, maxStorageInMB, minStorageInMB);
        }

        /// <summary> Initializes a new instance of MySqlNameAvailabilityResult. </summary>
        /// <param name="message"> Error Message. </param>
        /// <param name="isNameAvailable"> Indicates whether the resource name is available. </param>
        /// <param name="reason"> Reason for name being unavailable. </param>
        /// <returns> A new <see cref="Models.MySqlNameAvailabilityResult"/> instance for mocking. </returns>
        public static MySqlNameAvailabilityResult MySqlNameAvailabilityResult(string message = null, bool? isNameAvailable = null, string reason = null)
        {
            return new MySqlNameAvailabilityResult(message, isNameAvailable, reason);
        }

        /// <summary> Initializes a new instance of MySqlServerSecurityAlertPolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="state"> Specifies the state of the policy, whether it is enabled or disabled. </param>
        /// <param name="disabledAlerts"> Specifies an array of alerts that are disabled. Allowed values are: Sql_Injection, Sql_Injection_Vulnerability, Access_Anomaly. </param>
        /// <param name="emailAddresses"> Specifies an array of e-mail addresses to which the alert is sent. </param>
        /// <param name="sendToEmailAccountAdmins"> Specifies that the alert is sent to the account administrators. </param>
        /// <param name="storageEndpoint"> Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). This blob storage will hold all Threat Detection audit logs. </param>
        /// <param name="storageAccountAccessKey"> Specifies the identifier key of the Threat Detection audit storage account. </param>
        /// <param name="retentionDays"> Specifies the number of days to keep in the Threat Detection audit logs. </param>
        /// <returns> A new <see cref="MySql.MySqlServerSecurityAlertPolicyData"/> instance for mocking. </returns>
        public static MySqlServerSecurityAlertPolicyData MySqlServerSecurityAlertPolicyData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, MySqlServerSecurityAlertPolicyState? state = null, IEnumerable<string> disabledAlerts = null, IEnumerable<string> emailAddresses = null, bool? sendToEmailAccountAdmins = null, string storageEndpoint = null, string storageAccountAccessKey = null, int? retentionDays = null)
        {
            disabledAlerts ??= new List<string>();
            emailAddresses ??= new List<string>();

            return new MySqlServerSecurityAlertPolicyData(id, name, resourceType, systemData, state, disabledAlerts?.ToList(), emailAddresses?.ToList(), sendToEmailAccountAdmins, storageEndpoint, storageAccountAccessKey, retentionDays);
        }

        /// <summary> Initializes a new instance of MySqlQueryTextData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="queryId"> Query identifier unique to the server. </param>
        /// <param name="queryText"> Query text. </param>
        /// <returns> A new <see cref="MySql.MySqlQueryTextData"/> instance for mocking. </returns>
        public static MySqlQueryTextData MySqlQueryTextData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string queryId = null, string queryText = null)
        {
            return new MySqlQueryTextData(id, name, resourceType, systemData, queryId, queryText);
        }

        /// <summary> Initializes a new instance of MySqlQueryStatisticData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="queryId"> Database query identifier. </param>
        /// <param name="startOn"> Observation start time. </param>
        /// <param name="endOn"> Observation end time. </param>
        /// <param name="aggregationFunction"> Aggregation function name. </param>
        /// <param name="databaseNames"> The list of database names. </param>
        /// <param name="queryExecutionCount"> Number of query executions in this time interval. </param>
        /// <param name="metricName"> Metric name. </param>
        /// <param name="metricDisplayName"> Metric display name. </param>
        /// <param name="metricValue"> Metric value. </param>
        /// <param name="metricValueUnit"> Metric value unit. </param>
        /// <returns> A new <see cref="MySql.MySqlQueryStatisticData"/> instance for mocking. </returns>
        public static MySqlQueryStatisticData MySqlQueryStatisticData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string queryId = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, string aggregationFunction = null, IEnumerable<string> databaseNames = null, long? queryExecutionCount = null, string metricName = null, string metricDisplayName = null, double? metricValue = null, string metricValueUnit = null)
        {
            databaseNames ??= new List<string>();

            return new MySqlQueryStatisticData(id, name, resourceType, systemData, queryId, startOn, endOn, aggregationFunction, databaseNames?.ToList(), queryExecutionCount, metricName, metricDisplayName, metricValue, metricValueUnit);
        }

        /// <summary> Initializes a new instance of MySqlWaitStatisticData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startOn"> Observation start time. </param>
        /// <param name="endOn"> Observation end time. </param>
        /// <param name="eventName"> Wait event name. </param>
        /// <param name="eventTypeName"> Wait event type name. </param>
        /// <param name="queryId"> Database query identifier. </param>
        /// <param name="databaseName"> Database Name. </param>
        /// <param name="userId"> Database user identifier. </param>
        /// <param name="count"> Wait event count observed in this time interval. </param>
        /// <param name="totalTimeInMinutes"> Total time of wait in milliseconds in this time interval. </param>
        /// <returns> A new <see cref="MySql.MySqlWaitStatisticData"/> instance for mocking. </returns>
        public static MySqlWaitStatisticData MySqlWaitStatisticData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DateTimeOffset? startOn = null, DateTimeOffset? endOn = null, string eventName = null, string eventTypeName = null, long? queryId = null, string databaseName = null, long? userId = null, long? count = null, double? totalTimeInMinutes = null)
        {
            return new MySqlWaitStatisticData(id, name, resourceType, systemData, startOn, endOn, eventName, eventTypeName, queryId, databaseName, userId, count, totalTimeInMinutes);
        }

        /// <summary> Initializes a new instance of MySqlQueryPerformanceInsightResetDataResult. </summary>
        /// <param name="status"> Indicates result of the operation. </param>
        /// <param name="message"> operation message. </param>
        /// <returns> A new <see cref="Models.MySqlQueryPerformanceInsightResetDataResult"/> instance for mocking. </returns>
        public static MySqlQueryPerformanceInsightResetDataResult MySqlQueryPerformanceInsightResetDataResult(MySqlQueryPerformanceInsightResetDataResultState? status = null, string message = null)
        {
            return new MySqlQueryPerformanceInsightResetDataResult(status, message);
        }

        /// <summary> Initializes a new instance of MySqlAdvisorData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The properties of a recommendation action advisor. </param>
        /// <returns> A new <see cref="MySql.MySqlAdvisorData"/> instance for mocking. </returns>
        public static MySqlAdvisorData MySqlAdvisorData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, BinaryData properties = null)
        {
            return new MySqlAdvisorData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of MySqlRecommendationActionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="advisorName"> Advisor name. </param>
        /// <param name="sessionId"> Recommendation action session identifier. </param>
        /// <param name="actionId"> Recommendation action identifier. </param>
        /// <param name="createdOn"> Recommendation action creation time. </param>
        /// <param name="expireOn"> Recommendation action expiration time. </param>
        /// <param name="reason"> Recommendation action reason. </param>
        /// <param name="recommendationType"> Recommendation action type. </param>
        /// <param name="details"> Recommendation action details. </param>
        /// <returns> A new <see cref="MySql.MySqlRecommendationActionData"/> instance for mocking. </returns>
        public static MySqlRecommendationActionData MySqlRecommendationActionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string advisorName = null, Guid? sessionId = null, int? actionId = null, DateTimeOffset? createdOn = null, DateTimeOffset? expireOn = null, string reason = null, string recommendationType = null, IDictionary<string, string> details = null)
        {
            details ??= new Dictionary<string, string>();

            return new MySqlRecommendationActionData(id, name, resourceType, systemData, advisorName, sessionId, actionId, createdOn, expireOn, reason, recommendationType, details);
        }

        /// <summary> Initializes a new instance of MySqlPrivateEndpointConnectionData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="privateEndpointId"> Private endpoint which the connection belongs to. </param>
        /// <param name="connectionState"> Connection state of the private endpoint connection. </param>
        /// <param name="provisioningState"> State of the private endpoint connection. </param>
        /// <returns> A new <see cref="MySql.MySqlPrivateEndpointConnectionData"/> instance for mocking. </returns>
        public static MySqlPrivateEndpointConnectionData MySqlPrivateEndpointConnectionData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier privateEndpointId = null, MySqlPrivateLinkServiceConnectionStateProperty connectionState = null, string provisioningState = null)
        {
            return new MySqlPrivateEndpointConnectionData(id, name, resourceType, systemData, privateEndpointId != null ? ResourceManagerModelFactory.WritableSubResource(privateEndpointId) : null, connectionState, provisioningState);
        }

        /// <summary> Initializes a new instance of MySqlPrivateLinkServiceConnectionStateProperty. </summary>
        /// <param name="status"> The private link service connection status. </param>
        /// <param name="description"> The private link service connection description. </param>
        /// <param name="actionsRequired"> The actions required for private link service connection. </param>
        /// <returns> A new <see cref="Models.MySqlPrivateLinkServiceConnectionStateProperty"/> instance for mocking. </returns>
        public static MySqlPrivateLinkServiceConnectionStateProperty MySqlPrivateLinkServiceConnectionStateProperty(string status = null, string description = null, string actionsRequired = null)
        {
            return new MySqlPrivateLinkServiceConnectionStateProperty(status, description, actionsRequired);
        }

        /// <summary> Initializes a new instance of MySqlPrivateLinkResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The private link resource group id. </param>
        /// <returns> A new <see cref="MySql.MySqlPrivateLinkResourceData"/> instance for mocking. </returns>
        public static MySqlPrivateLinkResourceData MySqlPrivateLinkResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, MySqlPrivateLinkResourceProperties properties = null)
        {
            return new MySqlPrivateLinkResourceData(id, name, resourceType, systemData, properties);
        }

        /// <summary> Initializes a new instance of MySqlPrivateLinkResourceProperties. </summary>
        /// <param name="groupId"> The private link resource group id. </param>
        /// <param name="requiredMembers"> The private link resource required member names. </param>
        /// <returns> A new <see cref="Models.MySqlPrivateLinkResourceProperties"/> instance for mocking. </returns>
        public static MySqlPrivateLinkResourceProperties MySqlPrivateLinkResourceProperties(string groupId = null, IEnumerable<string> requiredMembers = null)
        {
            requiredMembers ??= new List<string>();

            return new MySqlPrivateLinkResourceProperties(groupId, requiredMembers?.ToList());
        }

        /// <summary> Initializes a new instance of MySqlServerKeyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of encryption protector used to protect the key. </param>
        /// <param name="serverKeyType"> The key type like 'AzureKeyVault'. </param>
        /// <param name="uri"> The URI of the key. </param>
        /// <param name="createdOn"> The key creation date. </param>
        /// <returns> A new <see cref="MySql.MySqlServerKeyData"/> instance for mocking. </returns>
        public static MySqlServerKeyData MySqlServerKeyData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string kind = null, MySqlServerKeyType? serverKeyType = null, Uri uri = null, DateTimeOffset? createdOn = null)
        {
            return new MySqlServerKeyData(id, name, resourceType, systemData, kind, serverKeyType, uri, createdOn);
        }
    }
}
