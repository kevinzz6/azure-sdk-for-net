// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Properties of a managed Cassandra cluster. </summary>
    public partial class CassandraClusterProperties
    {
        /// <summary> Initializes a new instance of CassandraClusterProperties. </summary>
        public CassandraClusterProperties()
        {
            ClientCertificates = new ChangeTrackingList<CassandraCertificate>();
            ExternalGossipCertificates = new ChangeTrackingList<CassandraCertificate>();
            GossipCertificates = new ChangeTrackingList<CassandraCertificate>();
            ExternalSeedNodes = new ChangeTrackingList<CassandraDataCenterSeedNode>();
            SeedNodes = new ChangeTrackingList<CassandraDataCenterSeedNode>();
        }

        /// <summary> Initializes a new instance of CassandraClusterProperties. </summary>
        /// <param name="provisioningState"> The status of the resource at the time the operation was called. </param>
        /// <param name="restoreFromBackupId"> To create an empty cluster, omit this field or set it to null. To restore a backup into a new cluster, set this field to the resource id of the backup. </param>
        /// <param name="delegatedManagementSubnetId"> Resource id of a subnet that this cluster's management service should have its network interface attached to. The subnet must be routable to all subnets that will be delegated to data centers. The resource id must be of the form '/subscriptions/&lt;subscription id&gt;/resourceGroups/&lt;resource group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual network&gt;/subnets/&lt;subnet&gt;'. </param>
        /// <param name="cassandraVersion"> Which version of Cassandra should this cluster converge to running (e.g., 3.11). When updated, the cluster may take some time to migrate to the new version. </param>
        /// <param name="clusterNameOverride"> If you need to set the clusterName property in cassandra.yaml to something besides the resource name of the cluster, set the value to use on this property. </param>
        /// <param name="authenticationMethod"> Which authentication method Cassandra should use to authenticate clients. 'None' turns off authentication, so should not be used except in emergencies. 'Cassandra' is the default password based authentication. The default is 'Cassandra'. 'Ldap' is in preview. </param>
        /// <param name="initialCassandraAdminPassword"> Initial password for clients connecting as admin to the cluster. Should be changed after cluster creation. Returns null on GET. This field only applies when the authenticationMethod field is 'Cassandra'. </param>
        /// <param name="prometheusEndpoint"> Hostname or IP address where the Prometheus endpoint containing data about the managed Cassandra nodes can be reached. </param>
        /// <param name="isRepairEnabled"> Should automatic repairs run on this cluster? If omitted, this is true, and should stay true unless you are running a hybrid cluster where you are already doing your own repairs. </param>
        /// <param name="clientCertificates"> List of TLS certificates used to authorize clients connecting to the cluster. All connections are TLS encrypted whether clientCertificates is set or not, but if clientCertificates is set, the managed Cassandra cluster will reject all connections not bearing a TLS client certificate that can be validated from one or more of the public certificates in this property. </param>
        /// <param name="externalGossipCertificates"> List of TLS certificates used to authorize gossip from unmanaged data centers. The TLS certificates of all nodes in unmanaged data centers must be verifiable using one of the certificates provided in this property. </param>
        /// <param name="gossipCertificates"> List of TLS certificates that unmanaged nodes must trust for gossip with managed nodes. All managed nodes will present TLS client certificates that are verifiable using one of the certificates provided in this property. </param>
        /// <param name="externalSeedNodes"> List of IP addresses of seed nodes in unmanaged data centers. These will be added to the seed node lists of all managed nodes. </param>
        /// <param name="seedNodes"> List of IP addresses of seed nodes in the managed data centers. These should be added to the seed node lists of all unmanaged nodes. </param>
        /// <param name="hoursBetweenBackups"> Number of hours to wait between taking a backup of the cluster. To disable backups, set this property to 0. </param>
        /// <param name="isDeallocated"> Whether the cluster and associated data centers has been deallocated. </param>
        /// <param name="isCassandraAuditLoggingEnabled"> Whether Cassandra audit logging is enabled. </param>
        internal CassandraClusterProperties(CassandraProvisioningState? provisioningState, string restoreFromBackupId, ResourceIdentifier delegatedManagementSubnetId, string cassandraVersion, string clusterNameOverride, CassandraAuthenticationMethod? authenticationMethod, string initialCassandraAdminPassword, CassandraDataCenterSeedNode prometheusEndpoint, bool? isRepairEnabled, IList<CassandraCertificate> clientCertificates, IList<CassandraCertificate> externalGossipCertificates, IReadOnlyList<CassandraCertificate> gossipCertificates, IList<CassandraDataCenterSeedNode> externalSeedNodes, IReadOnlyList<CassandraDataCenterSeedNode> seedNodes, int? hoursBetweenBackups, bool? isDeallocated, bool? isCassandraAuditLoggingEnabled)
        {
            ProvisioningState = provisioningState;
            RestoreFromBackupId = restoreFromBackupId;
            DelegatedManagementSubnetId = delegatedManagementSubnetId;
            CassandraVersion = cassandraVersion;
            ClusterNameOverride = clusterNameOverride;
            AuthenticationMethod = authenticationMethod;
            InitialCassandraAdminPassword = initialCassandraAdminPassword;
            PrometheusEndpoint = prometheusEndpoint;
            IsRepairEnabled = isRepairEnabled;
            ClientCertificates = clientCertificates;
            ExternalGossipCertificates = externalGossipCertificates;
            GossipCertificates = gossipCertificates;
            ExternalSeedNodes = externalSeedNodes;
            SeedNodes = seedNodes;
            HoursBetweenBackups = hoursBetweenBackups;
            IsDeallocated = isDeallocated;
            IsCassandraAuditLoggingEnabled = isCassandraAuditLoggingEnabled;
        }

        /// <summary> The status of the resource at the time the operation was called. </summary>
        public CassandraProvisioningState? ProvisioningState { get; set; }
        /// <summary> To create an empty cluster, omit this field or set it to null. To restore a backup into a new cluster, set this field to the resource id of the backup. </summary>
        public string RestoreFromBackupId { get; set; }
        /// <summary> Resource id of a subnet that this cluster's management service should have its network interface attached to. The subnet must be routable to all subnets that will be delegated to data centers. The resource id must be of the form '/subscriptions/&lt;subscription id&gt;/resourceGroups/&lt;resource group&gt;/providers/Microsoft.Network/virtualNetworks/&lt;virtual network&gt;/subnets/&lt;subnet&gt;'. </summary>
        public ResourceIdentifier DelegatedManagementSubnetId { get; set; }
        /// <summary> Which version of Cassandra should this cluster converge to running (e.g., 3.11). When updated, the cluster may take some time to migrate to the new version. </summary>
        public string CassandraVersion { get; set; }
        /// <summary> If you need to set the clusterName property in cassandra.yaml to something besides the resource name of the cluster, set the value to use on this property. </summary>
        public string ClusterNameOverride { get; set; }
        /// <summary> Which authentication method Cassandra should use to authenticate clients. 'None' turns off authentication, so should not be used except in emergencies. 'Cassandra' is the default password based authentication. The default is 'Cassandra'. 'Ldap' is in preview. </summary>
        public CassandraAuthenticationMethod? AuthenticationMethod { get; set; }
        /// <summary> Initial password for clients connecting as admin to the cluster. Should be changed after cluster creation. Returns null on GET. This field only applies when the authenticationMethod field is 'Cassandra'. </summary>
        public string InitialCassandraAdminPassword { get; set; }
        /// <summary> Hostname or IP address where the Prometheus endpoint containing data about the managed Cassandra nodes can be reached. </summary>
        internal CassandraDataCenterSeedNode PrometheusEndpoint { get; set; }
        /// <summary> IP address of this seed node. </summary>
        public string PrometheusEndpointIPAddress
        {
            get => PrometheusEndpoint is null ? default : PrometheusEndpoint.IPAddress;
            set
            {
                if (PrometheusEndpoint is null)
                    PrometheusEndpoint = new CassandraDataCenterSeedNode();
                PrometheusEndpoint.IPAddress = value;
            }
        }

        /// <summary> Should automatic repairs run on this cluster? If omitted, this is true, and should stay true unless you are running a hybrid cluster where you are already doing your own repairs. </summary>
        public bool? IsRepairEnabled { get; set; }
        /// <summary> List of TLS certificates used to authorize clients connecting to the cluster. All connections are TLS encrypted whether clientCertificates is set or not, but if clientCertificates is set, the managed Cassandra cluster will reject all connections not bearing a TLS client certificate that can be validated from one or more of the public certificates in this property. </summary>
        public IList<CassandraCertificate> ClientCertificates { get; }
        /// <summary> List of TLS certificates used to authorize gossip from unmanaged data centers. The TLS certificates of all nodes in unmanaged data centers must be verifiable using one of the certificates provided in this property. </summary>
        public IList<CassandraCertificate> ExternalGossipCertificates { get; }
        /// <summary> List of TLS certificates that unmanaged nodes must trust for gossip with managed nodes. All managed nodes will present TLS client certificates that are verifiable using one of the certificates provided in this property. </summary>
        public IReadOnlyList<CassandraCertificate> GossipCertificates { get; }
        /// <summary> List of IP addresses of seed nodes in unmanaged data centers. These will be added to the seed node lists of all managed nodes. </summary>
        public IList<CassandraDataCenterSeedNode> ExternalSeedNodes { get; }
        /// <summary> List of IP addresses of seed nodes in the managed data centers. These should be added to the seed node lists of all unmanaged nodes. </summary>
        public IReadOnlyList<CassandraDataCenterSeedNode> SeedNodes { get; }
        /// <summary> Number of hours to wait between taking a backup of the cluster. To disable backups, set this property to 0. </summary>
        public int? HoursBetweenBackups { get; set; }
        /// <summary> Whether the cluster and associated data centers has been deallocated. </summary>
        public bool? IsDeallocated { get; set; }
        /// <summary> Whether Cassandra audit logging is enabled. </summary>
        public bool? IsCassandraAuditLoggingEnabled { get; set; }
    }
}
