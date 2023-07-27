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

namespace Azure.ResourceManager.NetworkCloud
{
    /// <summary>
    /// A class representing a collection of <see cref="RackSkuResource" /> and their operations.
    /// Each <see cref="RackSkuResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="RackSkuCollection" /> instance call the GetRackSkus method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class RackSkuCollection : ArmCollection, IEnumerable<RackSkuResource>, IAsyncEnumerable<RackSkuResource>
    {
        private readonly ClientDiagnostics _rackSkuClientDiagnostics;
        private readonly RackSkusRestOperations _rackSkuRestClient;

        /// <summary> Initializes a new instance of the <see cref="RackSkuCollection"/> class for mocking. </summary>
        protected RackSkuCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="RackSkuCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal RackSkuCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _rackSkuClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.NetworkCloud", RackSkuResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(RackSkuResource.ResourceType, out string rackSkuApiVersion);
            _rackSkuRestClient = new RackSkusRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, rackSkuApiVersion);
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
        /// Get the properties of the provided rack SKU.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus/{rackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackSkuName"> The name of the rack SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackSkuName"/> is null. </exception>
        public virtual async Task<Response<RackSkuResource>> GetAsync(string rackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackSkuName, nameof(rackSkuName));

            using var scope = _rackSkuClientDiagnostics.CreateScope("RackSkuCollection.Get");
            scope.Start();
            try
            {
                var response = await _rackSkuRestClient.GetAsync(Id.SubscriptionId, rackSkuName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RackSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the properties of the provided rack SKU.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus/{rackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackSkuName"> The name of the rack SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackSkuName"/> is null. </exception>
        public virtual Response<RackSkuResource> Get(string rackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackSkuName, nameof(rackSkuName));

            using var scope = _rackSkuClientDiagnostics.CreateScope("RackSkuCollection.Get");
            scope.Start();
            try
            {
                var response = _rackSkuRestClient.Get(Id.SubscriptionId, rackSkuName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new RackSkuResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get a list of rack SKUs in the provided subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="RackSkuResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<RackSkuResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _rackSkuRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _rackSkuRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new RackSkuResource(Client, RackSkuData.DeserializeRackSkuData(e)), _rackSkuClientDiagnostics, Pipeline, "RackSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Get a list of rack SKUs in the provided subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_ListBySubscription</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="RackSkuResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<RackSkuResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _rackSkuRestClient.CreateListBySubscriptionRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _rackSkuRestClient.CreateListBySubscriptionNextPageRequest(nextLink, Id.SubscriptionId);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new RackSkuResource(Client, RackSkuData.DeserializeRackSkuData(e)), _rackSkuClientDiagnostics, Pipeline, "RackSkuCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus/{rackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackSkuName"> The name of the rack SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackSkuName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string rackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackSkuName, nameof(rackSkuName));

            using var scope = _rackSkuClientDiagnostics.CreateScope("RackSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = await _rackSkuRestClient.GetAsync(Id.SubscriptionId, rackSkuName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.NetworkCloud/rackSkus/{rackSkuName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>RackSkus_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="rackSkuName"> The name of the rack SKU. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="rackSkuName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="rackSkuName"/> is null. </exception>
        public virtual Response<bool> Exists(string rackSkuName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(rackSkuName, nameof(rackSkuName));

            using var scope = _rackSkuClientDiagnostics.CreateScope("RackSkuCollection.Exists");
            scope.Start();
            try
            {
                var response = _rackSkuRestClient.Get(Id.SubscriptionId, rackSkuName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<RackSkuResource> IEnumerable<RackSkuResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<RackSkuResource> IAsyncEnumerable<RackSkuResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
