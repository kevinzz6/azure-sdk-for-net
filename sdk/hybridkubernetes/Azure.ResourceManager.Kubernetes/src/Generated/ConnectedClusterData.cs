// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Kubernetes.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Kubernetes
{
    /// <summary>
    /// A class representing the ConnectedCluster data model.
    /// Represents a connected cluster.
    /// </summary>
    public partial class ConnectedClusterData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ConnectedClusterData. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the connected cluster. Current supported identity types: None, SystemAssigned. </param>
        /// <param name="agentPublicKeyCertificate"> Base64 encoded public certificate used by the agent to do the initial handshake to the backend services in Azure. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identity"/> or <paramref name="agentPublicKeyCertificate"/> is null. </exception>
        public ConnectedClusterData(AzureLocation location, ManagedServiceIdentity identity, string agentPublicKeyCertificate) : base(location)
        {
            Argument.AssertNotNull(identity, nameof(identity));
            Argument.AssertNotNull(agentPublicKeyCertificate, nameof(agentPublicKeyCertificate));

            Identity = identity;
            AgentPublicKeyCertificate = agentPublicKeyCertificate;
        }

        /// <summary> Initializes a new instance of ConnectedClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> The identity of the connected cluster. Current supported identity types: None, SystemAssigned. </param>
        /// <param name="agentPublicKeyCertificate"> Base64 encoded public certificate used by the agent to do the initial handshake to the backend services in Azure. </param>
        /// <param name="kubernetesVersion"> The Kubernetes version of the connected cluster resource. </param>
        /// <param name="totalNodeCount"> Number of nodes present in the connected cluster resource. </param>
        /// <param name="totalCoreCount"> Number of CPU cores present in the connected cluster resource. </param>
        /// <param name="agentVersion"> Version of the agent running on the connected cluster resource. </param>
        /// <param name="provisioningState"> Provisioning state of the connected cluster resource. </param>
        /// <param name="distribution"> The Kubernetes distribution running on this connected cluster. </param>
        /// <param name="infrastructure"> The infrastructure on which the Kubernetes cluster represented by this connected cluster is running on. </param>
        /// <param name="offering"> Connected cluster offering. </param>
        /// <param name="managedIdentityCertificateExpirationOn"> Expiration time of the managed identity certificate. </param>
        /// <param name="lastConnectivityOn"> Time representing the last instance when heart beat was received from the cluster. </param>
        /// <param name="connectivityStatus"> Represents the connectivity status of the connected cluster. </param>
        /// <param name="privateLinkState"> Property which describes the state of private link on a connected cluster resource. </param>
        /// <param name="privateLinkScopeResourceId"> The resource id of the private link scope this connected cluster is assigned to, if any. </param>
        internal ConnectedClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, string agentPublicKeyCertificate, string kubernetesVersion, int? totalNodeCount, int? totalCoreCount, string agentVersion, ProvisioningState? provisioningState, string distribution, string infrastructure, string offering, DateTimeOffset? managedIdentityCertificateExpirationOn, DateTimeOffset? lastConnectivityOn, ConnectivityStatus? connectivityStatus, PrivateLinkState? privateLinkState, string privateLinkScopeResourceId) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            AgentPublicKeyCertificate = agentPublicKeyCertificate;
            KubernetesVersion = kubernetesVersion;
            TotalNodeCount = totalNodeCount;
            TotalCoreCount = totalCoreCount;
            AgentVersion = agentVersion;
            ProvisioningState = provisioningState;
            Distribution = distribution;
            Infrastructure = infrastructure;
            Offering = offering;
            ManagedIdentityCertificateExpirationOn = managedIdentityCertificateExpirationOn;
            LastConnectivityOn = lastConnectivityOn;
            ConnectivityStatus = connectivityStatus;
            PrivateLinkState = privateLinkState;
            PrivateLinkScopeResourceId = privateLinkScopeResourceId;
        }

        /// <summary> The identity of the connected cluster. Current supported identity types: None, SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Base64 encoded public certificate used by the agent to do the initial handshake to the backend services in Azure. </summary>
        public string AgentPublicKeyCertificate { get; set; }
        /// <summary> The Kubernetes version of the connected cluster resource. </summary>
        public string KubernetesVersion { get; }
        /// <summary> Number of nodes present in the connected cluster resource. </summary>
        public int? TotalNodeCount { get; }
        /// <summary> Number of CPU cores present in the connected cluster resource. </summary>
        public int? TotalCoreCount { get; }
        /// <summary> Version of the agent running on the connected cluster resource. </summary>
        public string AgentVersion { get; }
        /// <summary> Provisioning state of the connected cluster resource. </summary>
        public ProvisioningState? ProvisioningState { get; set; }
        /// <summary> The Kubernetes distribution running on this connected cluster. </summary>
        public string Distribution { get; set; }
        /// <summary> The infrastructure on which the Kubernetes cluster represented by this connected cluster is running on. </summary>
        public string Infrastructure { get; set; }
        /// <summary> Connected cluster offering. </summary>
        public string Offering { get; }
        /// <summary> Expiration time of the managed identity certificate. </summary>
        public DateTimeOffset? ManagedIdentityCertificateExpirationOn { get; }
        /// <summary> Time representing the last instance when heart beat was received from the cluster. </summary>
        public DateTimeOffset? LastConnectivityOn { get; }
        /// <summary> Represents the connectivity status of the connected cluster. </summary>
        public ConnectivityStatus? ConnectivityStatus { get; }
        /// <summary> Property which describes the state of private link on a connected cluster resource. </summary>
        public PrivateLinkState? PrivateLinkState { get; set; }
        /// <summary> The resource id of the private link scope this connected cluster is assigned to, if any. </summary>
        public string PrivateLinkScopeResourceId { get; set; }
    }
}
