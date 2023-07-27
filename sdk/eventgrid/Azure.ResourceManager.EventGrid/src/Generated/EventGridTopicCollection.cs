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

namespace Azure.ResourceManager.EventGrid
{
    /// <summary>
    /// A class representing a collection of <see cref="EventGridTopicResource" /> and their operations.
    /// Each <see cref="EventGridTopicResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="EventGridTopicCollection" /> instance call the GetEventGridTopics method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class EventGridTopicCollection : ArmCollection, IEnumerable<EventGridTopicResource>, IAsyncEnumerable<EventGridTopicResource>
    {
        private readonly ClientDiagnostics _eventGridTopicTopicsClientDiagnostics;
        private readonly TopicsRestOperations _eventGridTopicTopicsRestClient;

        /// <summary> Initializes a new instance of the <see cref="EventGridTopicCollection"/> class for mocking. </summary>
        protected EventGridTopicCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="EventGridTopicCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal EventGridTopicCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _eventGridTopicTopicsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.EventGrid", EventGridTopicResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(EventGridTopicResource.ResourceType, out string eventGridTopicTopicsApiVersion);
            _eventGridTopicTopicsRestClient = new TopicsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, eventGridTopicTopicsApiVersion);
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
        /// Asynchronously creates a new topic with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="topicName"> Name of the topic. </param>
        /// <param name="data"> Topic information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EventGridTopicResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string topicName, EventGridTopicData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventGridTopicTopicsClientDiagnostics.CreateScope("EventGridTopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _eventGridTopicTopicsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, topicName, data, cancellationToken).ConfigureAwait(false);
                var operation = new EventGridArmOperation<EventGridTopicResource>(new EventGridTopicOperationSource(Client), _eventGridTopicTopicsClientDiagnostics, Pipeline, _eventGridTopicTopicsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, topicName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Asynchronously creates a new topic with the specified parameters.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="topicName"> Name of the topic. </param>
        /// <param name="data"> Topic information. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EventGridTopicResource> CreateOrUpdate(WaitUntil waitUntil, string topicName, EventGridTopicData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _eventGridTopicTopicsClientDiagnostics.CreateScope("EventGridTopicCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _eventGridTopicTopicsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, topicName, data, cancellationToken);
                var operation = new EventGridArmOperation<EventGridTopicResource>(new EventGridTopicOperationSource(Client), _eventGridTopicTopicsClientDiagnostics, Pipeline, _eventGridTopicTopicsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, topicName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Get properties of a topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual async Task<Response<EventGridTopicResource>> GetAsync(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _eventGridTopicTopicsClientDiagnostics.CreateScope("EventGridTopicCollection.Get");
            scope.Start();
            try
            {
                var response = await _eventGridTopicTopicsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, topicName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventGridTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get properties of a topic.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual Response<EventGridTopicResource> Get(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _eventGridTopicTopicsClientDiagnostics.CreateScope("EventGridTopicCollection.Get");
            scope.Start();
            try
            {
                var response = _eventGridTopicTopicsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, topicName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EventGridTopicResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List all the topics under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="EventGridTopicResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<EventGridTopicResource> GetAllAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventGridTopicTopicsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventGridTopicTopicsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new EventGridTopicResource(Client, EventGridTopicData.DeserializeEventGridTopicData(e)), _eventGridTopicTopicsClientDiagnostics, Pipeline, "EventGridTopicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List all the topics under a resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="filter"> The query used to filter the search results using OData syntax. Filtering is permitted on the 'name' property only and with limited number of OData operations. These operations are: the 'contains' function as well as the following logical operations: not, and, or, eq (for equal), and ne (for not equal). No arithmetic operations are supported. The following is a valid filter example: $filter=contains(namE, 'PATTERN') and name ne 'PATTERN-1'. The following is not a valid filter example: $filter=location eq 'westus'. </param>
        /// <param name="top"> The number of results to return per page for the list operation. Valid range for top parameter is 1 to 100. If not specified, the default number of results to be returned is 20 items per page. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="EventGridTopicResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<EventGridTopicResource> GetAll(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _eventGridTopicTopicsRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _eventGridTopicTopicsRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, filter, top);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new EventGridTopicResource(Client, EventGridTopicData.DeserializeEventGridTopicData(e)), _eventGridTopicTopicsClientDiagnostics, Pipeline, "EventGridTopicCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _eventGridTopicTopicsClientDiagnostics.CreateScope("EventGridTopicCollection.Exists");
            scope.Start();
            try
            {
                var response = await _eventGridTopicTopicsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, topicName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.EventGrid/topics/{topicName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Topics_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="topicName"> Name of the topic. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="topicName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="topicName"/> is null. </exception>
        public virtual Response<bool> Exists(string topicName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(topicName, nameof(topicName));

            using var scope = _eventGridTopicTopicsClientDiagnostics.CreateScope("EventGridTopicCollection.Exists");
            scope.Start();
            try
            {
                var response = _eventGridTopicTopicsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, topicName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<EventGridTopicResource> IEnumerable<EventGridTopicResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<EventGridTopicResource> IAsyncEnumerable<EventGridTopicResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
