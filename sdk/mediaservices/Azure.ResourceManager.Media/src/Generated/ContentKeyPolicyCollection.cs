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

namespace Azure.ResourceManager.Media
{
    /// <summary>
    /// A class representing a collection of <see cref="ContentKeyPolicyResource" /> and their operations.
    /// Each <see cref="ContentKeyPolicyResource" /> in the collection will belong to the same instance of <see cref="MediaServicesAccountResource" />.
    /// To get a <see cref="ContentKeyPolicyCollection" /> instance call the GetContentKeyPolicies method from an instance of <see cref="MediaServicesAccountResource" />.
    /// </summary>
    public partial class ContentKeyPolicyCollection : ArmCollection, IEnumerable<ContentKeyPolicyResource>, IAsyncEnumerable<ContentKeyPolicyResource>
    {
        private readonly ClientDiagnostics _contentKeyPolicyClientDiagnostics;
        private readonly ContentKeyPoliciesRestOperations _contentKeyPolicyRestClient;

        /// <summary> Initializes a new instance of the <see cref="ContentKeyPolicyCollection"/> class for mocking. </summary>
        protected ContentKeyPolicyCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ContentKeyPolicyCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ContentKeyPolicyCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _contentKeyPolicyClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Media", ContentKeyPolicyResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ContentKeyPolicyResource.ResourceType, out string contentKeyPolicyApiVersion);
            _contentKeyPolicyRestClient = new ContentKeyPoliciesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, contentKeyPolicyApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MediaServicesAccountResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MediaServicesAccountResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update a Content Key Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="contentKeyPolicyName"> The Content Key Policy name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentKeyPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentKeyPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ContentKeyPolicyResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string contentKeyPolicyName, ContentKeyPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contentKeyPolicyName, nameof(contentKeyPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _contentKeyPolicyRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contentKeyPolicyName, data, cancellationToken).ConfigureAwait(false);
                var operation = new MediaArmOperation<ContentKeyPolicyResource>(Response.FromValue(new ContentKeyPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Create or update a Content Key Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="contentKeyPolicyName"> The Content Key Policy name. </param>
        /// <param name="data"> The request parameters. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentKeyPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentKeyPolicyName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ContentKeyPolicyResource> CreateOrUpdate(WaitUntil waitUntil, string contentKeyPolicyName, ContentKeyPolicyData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contentKeyPolicyName, nameof(contentKeyPolicyName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _contentKeyPolicyRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contentKeyPolicyName, data, cancellationToken);
                var operation = new MediaArmOperation<ContentKeyPolicyResource>(Response.FromValue(new ContentKeyPolicyResource(Client, response), response.GetRawResponse()));
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
        /// Get the details of a Content Key Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="contentKeyPolicyName"> The Content Key Policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentKeyPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentKeyPolicyName"/> is null. </exception>
        public virtual async Task<Response<ContentKeyPolicyResource>> GetAsync(string contentKeyPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contentKeyPolicyName, nameof(contentKeyPolicyName));

            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = await _contentKeyPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contentKeyPolicyName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContentKeyPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of a Content Key Policy in the Media Services account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="contentKeyPolicyName"> The Content Key Policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentKeyPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentKeyPolicyName"/> is null. </exception>
        public virtual Response<ContentKeyPolicyResource> Get(string contentKeyPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contentKeyPolicyName, nameof(contentKeyPolicyName));

            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyCollection.Get");
            scope.Start();
            try
            {
                var response = _contentKeyPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contentKeyPolicyName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ContentKeyPolicyResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists the Content Key Policies in the account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Restricts the set of items returned. </param>
        /// <param name="top"> Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n. </param>
        /// <param name="orderby"> Specifies the key by which the result collection should be ordered. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContentKeyPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContentKeyPolicyResource> GetAllAsync(string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _contentKeyPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _contentKeyPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContentKeyPolicyResource(Client, ContentKeyPolicyData.DeserializeContentKeyPolicyData(e)), _contentKeyPolicyClientDiagnostics, Pipeline, "ContentKeyPolicyCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists the Content Key Policies in the account
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> Restricts the set of items returned. </param>
        /// <param name="top"> Specifies a non-negative integer n that limits the number of items returned from a collection. The service returns the number of available items up to but not greater than the specified value n. </param>
        /// <param name="orderby"> Specifies the key by which the result collection should be ordered. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContentKeyPolicyResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContentKeyPolicyResource> GetAll(string filter = null, int? top = null, string orderby = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _contentKeyPolicyRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _contentKeyPolicyRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, filter, top, orderby);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContentKeyPolicyResource(Client, ContentKeyPolicyData.DeserializeContentKeyPolicyData(e)), _contentKeyPolicyClientDiagnostics, Pipeline, "ContentKeyPolicyCollection.GetAll", "value", "@odata.nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="contentKeyPolicyName"> The Content Key Policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentKeyPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentKeyPolicyName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string contentKeyPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contentKeyPolicyName, nameof(contentKeyPolicyName));

            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = await _contentKeyPolicyRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contentKeyPolicyName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Media/mediaServices/{accountName}/contentKeyPolicies/{contentKeyPolicyName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ContentKeyPolicies_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="contentKeyPolicyName"> The Content Key Policy name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="contentKeyPolicyName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="contentKeyPolicyName"/> is null. </exception>
        public virtual Response<bool> Exists(string contentKeyPolicyName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(contentKeyPolicyName, nameof(contentKeyPolicyName));

            using var scope = _contentKeyPolicyClientDiagnostics.CreateScope("ContentKeyPolicyCollection.Exists");
            scope.Start();
            try
            {
                var response = _contentKeyPolicyRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, contentKeyPolicyName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ContentKeyPolicyResource> IEnumerable<ContentKeyPolicyResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ContentKeyPolicyResource> IAsyncEnumerable<ContentKeyPolicyResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
