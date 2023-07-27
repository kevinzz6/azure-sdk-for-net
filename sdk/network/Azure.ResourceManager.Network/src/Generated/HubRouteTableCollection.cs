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
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="HubRouteTableResource" /> and their operations.
    /// Each <see cref="HubRouteTableResource" /> in the collection will belong to the same instance of <see cref="VirtualHubResource" />.
    /// To get a <see cref="HubRouteTableCollection" /> instance call the GetHubRouteTables method from an instance of <see cref="VirtualHubResource" />.
    /// </summary>
    public partial class HubRouteTableCollection : ArmCollection, IEnumerable<HubRouteTableResource>, IAsyncEnumerable<HubRouteTableResource>
    {
        private readonly ClientDiagnostics _hubRouteTableClientDiagnostics;
        private readonly HubRouteTablesRestOperations _hubRouteTableRestClient;

        /// <summary> Initializes a new instance of the <see cref="HubRouteTableCollection"/> class for mocking. </summary>
        protected HubRouteTableCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="HubRouteTableCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal HubRouteTableCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _hubRouteTableClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", HubRouteTableResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(HubRouteTableResource.ResourceType, out string hubRouteTableApiVersion);
            _hubRouteTableRestClient = new HubRouteTablesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, hubRouteTableApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != VirtualHubResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, VirtualHubResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates a RouteTable resource if it doesn't exist else updates the existing RouteTable.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubRouteTables/{routeTableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubRouteTables_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="routeTableName"> The name of the RouteTable. </param>
        /// <param name="data"> Parameters supplied to create or update RouteTable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<HubRouteTableResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string routeTableName, HubRouteTableData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hubRouteTableClientDiagnostics.CreateScope("HubRouteTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _hubRouteTableRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<HubRouteTableResource>(new HubRouteTableOperationSource(Client), _hubRouteTableClientDiagnostics, Pipeline, _hubRouteTableRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates a RouteTable resource if it doesn't exist else updates the existing RouteTable.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubRouteTables/{routeTableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubRouteTables_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="routeTableName"> The name of the RouteTable. </param>
        /// <param name="data"> Parameters supplied to create or update RouteTable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<HubRouteTableResource> CreateOrUpdate(WaitUntil waitUntil, string routeTableName, HubRouteTableData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _hubRouteTableClientDiagnostics.CreateScope("HubRouteTableCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _hubRouteTableRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, data, cancellationToken);
                var operation = new NetworkArmOperation<HubRouteTableResource>(new HubRouteTableOperationSource(Client), _hubRouteTableClientDiagnostics, Pipeline, _hubRouteTableRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the details of a RouteTable.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubRouteTables/{routeTableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubRouteTables_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeTableName"> The name of the RouteTable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public virtual async Task<Response<HubRouteTableResource>> GetAsync(string routeTableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _hubRouteTableClientDiagnostics.CreateScope("HubRouteTableCollection.Get");
            scope.Start();
            try
            {
                var response = await _hubRouteTableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubRouteTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of a RouteTable.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubRouteTables/{routeTableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubRouteTables_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeTableName"> The name of the RouteTable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public virtual Response<HubRouteTableResource> Get(string routeTableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _hubRouteTableClientDiagnostics.CreateScope("HubRouteTableCollection.Get");
            scope.Start();
            try
            {
                var response = _hubRouteTableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new HubRouteTableResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the details of all RouteTables.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubRouteTables</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubRouteTables_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HubRouteTableResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<HubRouteTableResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hubRouteTableRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hubRouteTableRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new HubRouteTableResource(Client, HubRouteTableData.DeserializeHubRouteTableData(e)), _hubRouteTableClientDiagnostics, Pipeline, "HubRouteTableCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Retrieves the details of all RouteTables.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubRouteTables</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubRouteTables_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HubRouteTableResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<HubRouteTableResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _hubRouteTableRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _hubRouteTableRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new HubRouteTableResource(Client, HubRouteTableData.DeserializeHubRouteTableData(e)), _hubRouteTableClientDiagnostics, Pipeline, "HubRouteTableCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubRouteTables/{routeTableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubRouteTables_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeTableName"> The name of the RouteTable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string routeTableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _hubRouteTableClientDiagnostics.CreateScope("HubRouteTableCollection.Exists");
            scope.Start();
            try
            {
                var response = await _hubRouteTableRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/virtualHubs/{virtualHubName}/hubRouteTables/{routeTableName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HubRouteTables_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="routeTableName"> The name of the RouteTable. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="routeTableName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="routeTableName"/> is null. </exception>
        public virtual Response<bool> Exists(string routeTableName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(routeTableName, nameof(routeTableName));

            using var scope = _hubRouteTableClientDiagnostics.CreateScope("HubRouteTableCollection.Exists");
            scope.Start();
            try
            {
                var response = _hubRouteTableRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, routeTableName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<HubRouteTableResource> IEnumerable<HubRouteTableResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<HubRouteTableResource> IAsyncEnumerable<HubRouteTableResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
