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

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing a collection of <see cref="NetworkRackSkuResource" /> and their operations.
    /// Each <see cref="NetworkRackSkuResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="NetworkRackSkuCollection" /> instance call the GetNetworkRackSkus method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class NetworkRackSkuCollection : ArmCollection, IEnumerable<NetworkRackSkuResource>, IAsyncEnumerable<NetworkRackSkuResource>
    {
        private readonly ClientDiagnostics _networkRackSkuClientDiagnostics;
        private readonly NetworkRackSkusRestOperations _networkRackSkuRestClient;

        /// <summary> Initializes a new instance of the <see cref="NetworkRackSkuCollection"/> class for mocking. </summary>
        protected NetworkRackSkuCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="NetworkRackSkuCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal NetworkRackSkuCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _networkRackSkuClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ManagedNetworkFabric", NetworkRackSkuResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(NetworkRackSkuResource.ResourceType, out string networkRackSkuApiVersion);
            _networkRackSkuRestClient = new NetworkRackSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, networkRackSkuApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get Network Rack SKU resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkRackSkus/{networkRackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRackSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkRackSkuName"> Name of the Network Rack Sku. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkRackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackSkuName"/> is null. </exception>
        public virtual async Task<Response<NetworkRackSkuResource>> GetAsync(string networkRackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkRackSkuName, nameof(networkRackSkuName));

            using var scope = _networkRackSkuClientDiagnostics.CreateScope("NetworkRackSkuCollection.Get");
            scope.Start();
            try
            {
                var response = await _networkRackSkuRestClient.GetAsync(Id.SubscriptionId, networkRackSkuName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkRackSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get Network Rack SKU resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkRackSkus/{networkRackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRackSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkRackSkuName"> Name of the Network Rack Sku. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkRackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackSkuName"/> is null. </exception>
        public virtual Response<NetworkRackSkuResource> Get(string networkRackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkRackSkuName, nameof(networkRackSkuName));

            using var scope = _networkRackSkuClientDiagnostics.CreateScope("NetworkRackSkuCollection.Get");
            scope.Start();
            try
            {
                var response = _networkRackSkuRestClient.Get(Id.SubscriptionId, networkRackSkuName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new NetworkRackSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all Network Rack SKUs in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkRackSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRackSkus_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="NetworkRackSkuResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<NetworkRackSkuResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkRackSkuRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkRackSkuRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new NetworkRackSkuResource(Client, NetworkRackSkuData.DeserializeNetworkRackSkuData(e)), _networkRackSkuClientDiagnostics, Pipeline, "NetworkRackSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all Network Rack SKUs in the given subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkRackSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRackSkus_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="NetworkRackSkuResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<NetworkRackSkuResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _networkRackSkuRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _networkRackSkuRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new NetworkRackSkuResource(Client, NetworkRackSkuData.DeserializeNetworkRackSkuData(e)), _networkRackSkuClientDiagnostics, Pipeline, "NetworkRackSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkRackSkus/{networkRackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRackSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkRackSkuName"> Name of the Network Rack Sku. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkRackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackSkuName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string networkRackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkRackSkuName, nameof(networkRackSkuName));

            using var scope = _networkRackSkuClientDiagnostics.CreateScope("NetworkRackSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = await _networkRackSkuRestClient.GetAsync(Id.SubscriptionId, networkRackSkuName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ManagedNetworkFabric/networkRackSkus/{networkRackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>NetworkRackSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="networkRackSkuName"> Name of the Network Rack Sku. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="networkRackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="networkRackSkuName"/> is null. </exception>
        public virtual Response<bool> Exists(string networkRackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(networkRackSkuName, nameof(networkRackSkuName));

            using var scope = _networkRackSkuClientDiagnostics.CreateScope("NetworkRackSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = _networkRackSkuRestClient.Get(Id.SubscriptionId, networkRackSkuName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<NetworkRackSkuResource> IEnumerable<NetworkRackSkuResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<NetworkRackSkuResource> IAsyncEnumerable<NetworkRackSkuResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
