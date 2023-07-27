// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Details of a Master Target Server. </summary>
    public partial class MasterTargetServer
    {
        /// <summary> Initializes a new instance of MasterTargetServer. </summary>
        internal MasterTargetServer()
        {
            RetentionVolumes = new ChangeTrackingList<SiteRecoveryRetentionVolume>();
            DataStores = new ChangeTrackingList<SiteRecoveryDataStore>();
            ValidationErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
            HealthErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
        }

        /// <summary> Initializes a new instance of MasterTargetServer. </summary>
        /// <param name="id"> The server Id. </param>
        /// <param name="ipAddress"> The IP address of the server. </param>
        /// <param name="name"> The server name. </param>
        /// <param name="osType"> The OS type of the server. </param>
        /// <param name="agentVersion"> The version of the scout component on the server. </param>
        /// <param name="lastHeartbeatReceivedOn"> The last heartbeat received from the server. </param>
        /// <param name="versionStatus"> Version status. </param>
        /// <param name="retentionVolumes"> The retention volumes of Master target Server. </param>
        /// <param name="dataStores"> The list of data stores in the fabric. </param>
        /// <param name="validationErrors"> Validation errors. </param>
        /// <param name="healthErrors"> Health errors. </param>
        /// <param name="diskCount"> Disk count of the master target. </param>
        /// <param name="osVersion"> OS Version of the master target. </param>
        /// <param name="agentExpireOn"> Agent expiry date. </param>
        /// <param name="marsAgentVersion"> MARS agent version. </param>
        /// <param name="marsAgentExpireOn"> MARS agent expiry date. </param>
        /// <param name="agentVersionDetails"> Agent version details. </param>
        /// <param name="marsAgentVersionDetails"> Mars agent version details. </param>
        internal MasterTargetServer(string id, IPAddress ipAddress, string name, string osType, string agentVersion, DateTimeOffset? lastHeartbeatReceivedOn, string versionStatus, IReadOnlyList<SiteRecoveryRetentionVolume> retentionVolumes, IReadOnlyList<SiteRecoveryDataStore> dataStores, IReadOnlyList<SiteRecoveryHealthError> validationErrors, IReadOnlyList<SiteRecoveryHealthError> healthErrors, int? diskCount, string osVersion, DateTimeOffset? agentExpireOn, string marsAgentVersion, DateTimeOffset? marsAgentExpireOn, SiteRecoveryVersionDetails agentVersionDetails, SiteRecoveryVersionDetails marsAgentVersionDetails)
        {
            Id = id;
            IPAddress = ipAddress;
            Name = name;
            OSType = osType;
            AgentVersion = agentVersion;
            LastHeartbeatReceivedOn = lastHeartbeatReceivedOn;
            VersionStatus = versionStatus;
            RetentionVolumes = retentionVolumes;
            DataStores = dataStores;
            ValidationErrors = validationErrors;
            HealthErrors = healthErrors;
            DiskCount = diskCount;
            OSVersion = osVersion;
            AgentExpireOn = agentExpireOn;
            MarsAgentVersion = marsAgentVersion;
            MarsAgentExpireOn = marsAgentExpireOn;
            AgentVersionDetails = agentVersionDetails;
            MarsAgentVersionDetails = marsAgentVersionDetails;
        }

        /// <summary> The server Id. </summary>
        public string Id { get; }
        /// <summary> The IP address of the server. </summary>
        public IPAddress IPAddress { get; }
        /// <summary> The server name. </summary>
        public string Name { get; }
        /// <summary> The OS type of the server. </summary>
        public string OSType { get; }
        /// <summary> The version of the scout component on the server. </summary>
        public string AgentVersion { get; }
        /// <summary> The last heartbeat received from the server. </summary>
        public DateTimeOffset? LastHeartbeatReceivedOn { get; }
        /// <summary> Version status. </summary>
        public string VersionStatus { get; }
        /// <summary> The retention volumes of Master target Server. </summary>
        public IReadOnlyList<SiteRecoveryRetentionVolume> RetentionVolumes { get; }
        /// <summary> The list of data stores in the fabric. </summary>
        public IReadOnlyList<SiteRecoveryDataStore> DataStores { get; }
        /// <summary> Validation errors. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> ValidationErrors { get; }
        /// <summary> Health errors. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> HealthErrors { get; }
        /// <summary> Disk count of the master target. </summary>
        public int? DiskCount { get; }
        /// <summary> OS Version of the master target. </summary>
        public string OSVersion { get; }
        /// <summary> Agent expiry date. </summary>
        public DateTimeOffset? AgentExpireOn { get; }
        /// <summary> MARS agent version. </summary>
        public string MarsAgentVersion { get; }
        /// <summary> MARS agent expiry date. </summary>
        public DateTimeOffset? MarsAgentExpireOn { get; }
        /// <summary> Agent version details. </summary>
        public SiteRecoveryVersionDetails AgentVersionDetails { get; }
        /// <summary> Mars agent version details. </summary>
        public SiteRecoveryVersionDetails MarsAgentVersionDetails { get; }
    }
}
