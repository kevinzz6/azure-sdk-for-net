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

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary>
    /// A class representing a collection of <see cref="ResourcePoolResource" /> and their operations.
    /// Each <see cref="ResourcePoolResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get a <see cref="ResourcePoolCollection" /> instance call the GetResourcePools method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class ResourcePoolCollection : ArmCollection, IEnumerable<ResourcePoolResource>, IAsyncEnumerable<ResourcePoolResource>
    {
        private readonly ClientDiagnostics _resourcePoolClientDiagnostics;
        private readonly ResourcePoolsRestOperations _resourcePoolRestClient;

        /// <summary> Initializes a new instance of the <see cref="ResourcePoolCollection"/> class for mocking. </summary>
        protected ResourcePoolCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ResourcePoolCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ResourcePoolCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _resourcePoolClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ConnectedVMwarevSphere", ResourcePoolResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourcePoolResource.ResourceType, out string resourcePoolApiVersion);
            _resourcePoolRestClient = new ResourcePoolsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, resourcePoolApiVersion);
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
        /// Create Or Update resourcePool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ResourcePoolResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourcePoolName, ResourcePoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _resourcePoolRestClient.CreateAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ConnectedVMwarevSphereArmOperation<ResourcePoolResource>(new ResourcePoolOperationSource(Client), _resourcePoolClientDiagnostics, Pipeline, _resourcePoolRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Create Or Update resourcePool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Create</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="data"> Request payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ResourcePoolResource> CreateOrUpdate(WaitUntil waitUntil, string resourcePoolName, ResourcePoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _resourcePoolRestClient.Create(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, data, cancellationToken);
                var operation = new ConnectedVMwarevSphereArmOperation<ResourcePoolResource>(new ResourcePoolOperationSource(Client), _resourcePoolClientDiagnostics, Pipeline, _resourcePoolRestClient.CreateCreateRequest(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, data).Request, response, OperationFinalStateVia.AzureAsyncOperation);
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
        /// Implements resourcePool GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual async Task<Response<ResourcePoolResource>> GetAsync(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.Get");
            scope.Start();
            try
            {
                var response = await _resourcePoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourcePoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Implements resourcePool GET method.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual Response<ResourcePoolResource> Get(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.Get");
            scope.Start();
            try
            {
                var response = _resourcePoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ResourcePoolResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of resourcePools in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ResourcePoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ResourcePoolResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourcePoolRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourcePoolRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ResourcePoolResource(Client, ResourcePoolData.DeserializeResourcePoolData(e)), _resourcePoolClientDiagnostics, Pipeline, "ResourcePoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of resourcePools in a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ResourcePoolResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ResourcePoolResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _resourcePoolRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _resourcePoolRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ResourcePoolResource(Client, ResourcePoolData.DeserializeResourcePoolData(e)), _resourcePoolClientDiagnostics, Pipeline, "ResourcePoolCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.Exists");
            scope.Start();
            try
            {
                var response = await _resourcePoolRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ConnectedVMwarevSphere/resourcePools/{resourcePoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ResourcePools_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourcePoolName"> Name of the resourcePool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourcePoolName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourcePoolName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourcePoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(resourcePoolName, nameof(resourcePoolName));

            using var scope = _resourcePoolClientDiagnostics.CreateScope("ResourcePoolCollection.Exists");
            scope.Start();
            try
            {
                var response = _resourcePoolRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, resourcePoolName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ResourcePoolResource> IEnumerable<ResourcePoolResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ResourcePoolResource> IAsyncEnumerable<ResourcePoolResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
