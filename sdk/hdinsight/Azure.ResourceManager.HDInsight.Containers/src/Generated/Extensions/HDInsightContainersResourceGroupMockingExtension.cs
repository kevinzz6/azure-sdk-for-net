// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.HDInsight.Containers;

namespace Azure.ResourceManager.HDInsight.Containers.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class HDInsightContainersResourceGroupMockingExtension : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="HDInsightContainersResourceGroupMockingExtension"/> class for mocking. </summary>
        protected HDInsightContainersResourceGroupMockingExtension()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HDInsightContainersResourceGroupMockingExtension"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal HDInsightContainersResourceGroupMockingExtension(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of HDInsightClusterPoolResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of HDInsightClusterPoolResources and their operations over a HDInsightClusterPoolResource. </returns>
        public virtual HDInsightClusterPoolCollection GetHDInsightClusterPools()
        {
            return GetCachedClient(Client => new HDInsightClusterPoolCollection(Client, Id));
        }

        /// <summary>
        /// Gets a cluster pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<HDInsightClusterPoolResource>> GetHDInsightClusterPoolAsync(string clusterPoolName, CancellationToken cancellationToken = default)
        {
            return await GetHDInsightClusterPools().GetAsync(clusterPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a cluster pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> is null. </exception>
        [ForwardsClientCalls]
        public virtual Response<HDInsightClusterPoolResource> GetHDInsightClusterPool(string clusterPoolName, CancellationToken cancellationToken = default)
        {
            return GetHDInsightClusterPools().Get(clusterPoolName, cancellationToken);
        }
    }
}
