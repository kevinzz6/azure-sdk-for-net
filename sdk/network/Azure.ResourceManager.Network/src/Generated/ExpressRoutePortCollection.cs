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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary>
    /// A class representing a collection of <see cref="ExpressRoutePortResource" /> and their operations.
    /// Each <see cref="ExpressRoutePortResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="ExpressRoutePortCollection" /> instance call the GetExpressRoutePorts method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ExpressRoutePortCollection : ArmCollection, IEnumerable<ExpressRoutePortResource>, IAsyncEnumerable<ExpressRoutePortResource>
    {
        private readonly ClientDiagnostics _expressRoutePortClientDiagnostics;
        private readonly ExpressRoutePortsRestOperations _expressRoutePortRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortCollection"/> class for mocking. </summary>
        protected ExpressRoutePortCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ExpressRoutePortCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ExpressRoutePortCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _expressRoutePortClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Network", ExpressRoutePortResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ExpressRoutePortResource.ResourceType, out string expressRoutePortApiVersion);
            _expressRoutePortRestClient = new ExpressRoutePortsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, expressRoutePortApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates the specified ExpressRoutePort resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts/{expressRoutePortName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePorts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="data"> Parameters supplied to the create ExpressRoutePort operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ExpressRoutePortResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string expressRoutePortName, ExpressRoutePortData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRoutePortRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, data, cancellationToken).ConfigureAwait(false);
                var operation = new NetworkArmOperation<ExpressRoutePortResource>(new ExpressRoutePortOperationSource(Client), _expressRoutePortClientDiagnostics, Pipeline, _expressRoutePortRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Creates or updates the specified ExpressRoutePort resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts/{expressRoutePortName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePorts_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="expressRoutePortName"> The name of the ExpressRoutePort resource. </param>
        /// <param name="data"> Parameters supplied to the create ExpressRoutePort operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ExpressRoutePortResource> CreateOrUpdate(WaitUntil waitUntil, string expressRoutePortName, ExpressRoutePortData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRoutePortRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, data, cancellationToken);
                var operation = new NetworkArmOperation<ExpressRoutePortResource>(new ExpressRoutePortOperationSource(Client), _expressRoutePortClientDiagnostics, Pipeline, _expressRoutePortRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Retrieves the requested ExpressRoutePort resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts/{expressRoutePortName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePorts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expressRoutePortName"> The name of ExpressRoutePort. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> is null. </exception>
        public virtual async Task<Response<ExpressRoutePortResource>> GetAsync(string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRoutePortRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Retrieves the requested ExpressRoutePort resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts/{expressRoutePortName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePorts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expressRoutePortName"> The name of ExpressRoutePort. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> is null. </exception>
        public virtual Response<ExpressRoutePortResource> Get(string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRoutePortRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRoutePortResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the ExpressRoutePort resources in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePorts_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRoutePortResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRoutePortResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRoutePortRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRoutePortRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ExpressRoutePortResource(Client, ExpressRoutePortData.DeserializeExpressRoutePortData(e)), _expressRoutePortClientDiagnostics, Pipeline, "ExpressRoutePortCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the ExpressRoutePort resources in the specified resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePorts_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRoutePortResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRoutePortResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _expressRoutePortRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _expressRoutePortRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ExpressRoutePortResource(Client, ExpressRoutePortData.DeserializeExpressRoutePortData(e)), _expressRoutePortClientDiagnostics, Pipeline, "ExpressRoutePortCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts/{expressRoutePortName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePorts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expressRoutePortName"> The name of ExpressRoutePort. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.Exists");
            scope.Start();
            try
            {
                var response = await _expressRoutePortRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Network/ExpressRoutePorts/{expressRoutePortName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ExpressRoutePorts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="expressRoutePortName"> The name of ExpressRoutePort. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="expressRoutePortName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="expressRoutePortName"/> is null. </exception>
        public virtual Response<bool> Exists(string expressRoutePortName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(expressRoutePortName, nameof(expressRoutePortName));

            using var scope = _expressRoutePortClientDiagnostics.CreateScope("ExpressRoutePortCollection.Exists");
            scope.Start();
            try
            {
                var response = _expressRoutePortRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, expressRoutePortName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ExpressRoutePortResource> IEnumerable<ExpressRoutePortResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRoutePortResource> IAsyncEnumerable<ExpressRoutePortResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
