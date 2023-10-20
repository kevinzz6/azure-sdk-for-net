// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing a collection of <see cref="SynapseSqlPoolResource" /> and their operations.
    /// Each <see cref="SynapseSqlPoolResource" /> in the collection will belong to the same instance of <see cref="SynapseWorkspaceResource" />.
    /// To get a <see cref="SynapseSqlPoolCollection" /> instance call the GetSynapseSqlPools method from an instance of <see cref="SynapseWorkspaceResource" />.
    /// </summary>
    public partial class SynapseSqlPoolCollection : ArmCollection, IEnumerable<SynapseSqlPoolResource>, IAsyncEnumerable<SynapseSqlPoolResource>
    {
        private readonly ClientDiagnostics _synapseSqlPoolSqlPoolsClientDiagnostics;
        private readonly SqlPoolsRestOperations _synapseSqlPoolSqlPoolsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SynapseSqlPoolCollection"/> class for mocking. </summary>
        protected SynapseSqlPoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SynapseSqlPoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SynapseSqlPoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _synapseSqlPoolSqlPoolsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Synapse", SynapseSqlPoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SynapseSqlPoolResource.ResourceType, out string synapseSqlPoolSqlPoolsApiVersion);
            _synapseSqlPoolSqlPoolsRestClient = new SqlPoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, synapseSqlPoolSqlPoolsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SynapseWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SynapseWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create a SQL pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPools_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="data"> The SQL pool to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SynapseSqlPoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string sqlPoolName, SynapseSqlPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseSqlPoolSqlPoolsClientDiagnostics.CreateScope("SynapseSqlPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolSqlPoolsRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sqlPoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SynapseArmOperation<SynapseSqlPoolResource>(new SynapseSqlPoolOperationSource(Client), _synapseSqlPoolSqlPoolsClientDiagnostics, Pipeline, _synapseSqlPoolSqlPoolsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sqlPoolName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create a SQL pool
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPools_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="data"> The SQL pool to create. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlPoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SynapseSqlPoolResource> CreateOrUpdate(WaitUntil waitUntil, string sqlPoolName, SynapseSqlPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _synapseSqlPoolSqlPoolsClientDiagnostics.CreateScope("SynapseSqlPoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolSqlPoolsRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sqlPoolName, data, cancellationToken);
                var operation = new SynapseArmOperation<SynapseSqlPoolResource>(new SynapseSqlPoolOperationSource(Client), _synapseSqlPoolSqlPoolsClientDiagnostics, Pipeline, _synapseSqlPoolSqlPoolsRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sqlPoolName, data).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get SQL pool properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlPoolName"/> is null. </exception>
        public virtual async Task<Response<SynapseSqlPoolResource>> GetAsync(string sqlPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));

            using var scope = _synapseSqlPoolSqlPoolsClientDiagnostics.CreateScope("SynapseSqlPoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolSqlPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sqlPoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get SQL pool properties
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlPoolName"/> is null. </exception>
        public virtual Response<SynapseSqlPoolResource> Get(string sqlPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));

            using var scope = _synapseSqlPoolSqlPoolsClientDiagnostics.CreateScope("SynapseSqlPoolCollection.Get");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolSqlPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sqlPoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all SQL pools
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPools_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SynapseSqlPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SynapseSqlPoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseSqlPoolSqlPoolsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseSqlPoolSqlPoolsRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SynapseSqlPoolResource(Client, SynapseSqlPoolData.DeserializeSynapseSqlPoolData(e)), _synapseSqlPoolSqlPoolsClientDiagnostics, Pipeline, "SynapseSqlPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all SQL pools
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPools_ListByWorkspace</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SynapseSqlPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SynapseSqlPoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _synapseSqlPoolSqlPoolsRestClient.CreateListByWorkspaceRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _synapseSqlPoolSqlPoolsRestClient.CreateListByWorkspaceNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SynapseSqlPoolResource(Client, SynapseSqlPoolData.DeserializeSynapseSqlPoolData(e)), _synapseSqlPoolSqlPoolsClientDiagnostics, Pipeline, "SynapseSqlPoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlPoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string sqlPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));

            using var scope = _synapseSqlPoolSqlPoolsClientDiagnostics.CreateScope("SynapseSqlPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolSqlPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sqlPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlPoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string sqlPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));

            using var scope = _synapseSqlPoolSqlPoolsClientDiagnostics.CreateScope("SynapseSqlPoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolSqlPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sqlPoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlPoolName"/> is null. </exception>
        public virtual async Task<NullableResponse<SynapseSqlPoolResource>> GetIfExistsAsync(string sqlPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));

            using var scope = _synapseSqlPoolSqlPoolsClientDiagnostics.CreateScope("SynapseSqlPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _synapseSqlPoolSqlPoolsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sqlPoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<SynapseSqlPoolResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Synapse/workspaces/{workspaceName}/sqlPools/{sqlPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>SqlPools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="sqlPoolName"> SQL pool name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="sqlPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="sqlPoolName"/> is null. </exception>
        public virtual NullableResponse<SynapseSqlPoolResource> GetIfExists(string sqlPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(sqlPoolName, nameof(sqlPoolName));

            using var scope = _synapseSqlPoolSqlPoolsClientDiagnostics.CreateScope("SynapseSqlPoolCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _synapseSqlPoolSqlPoolsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, sqlPoolName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<SynapseSqlPoolResource>(response.GetRawResponse());
                return Response.FromValue(new SynapseSqlPoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SynapseSqlPoolResource> IEnumerable<SynapseSqlPoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SynapseSqlPoolResource> IAsyncEnumerable<SynapseSqlPoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
