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

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing a collection of <see cref="DataFactoryTriggerResource" /> and their operations.
    /// Each <see cref="DataFactoryTriggerResource" /> in the collection will belong to the same instance of <see cref="DataFactoryResource" />.
    /// To get a <see cref="DataFactoryTriggerCollection" /> instance call the GetDataFactoryTriggers method from an instance of <see cref="DataFactoryResource" />.
    /// </summary>
    public partial class DataFactoryTriggerCollection : ArmCollection, IEnumerable<DataFactoryTriggerResource>, IAsyncEnumerable<DataFactoryTriggerResource>
    {
        private readonly ClientDiagnostics _dataFactoryTriggerTriggersClientDiagnostics;
        private readonly TriggersRestOperations _dataFactoryTriggerTriggersRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataFactoryTriggerCollection"/> class for mocking. </summary>
        protected DataFactoryTriggerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataFactoryTriggerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataFactoryTriggerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataFactoryTriggerTriggersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", DataFactoryTriggerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataFactoryTriggerResource.ResourceType, out string dataFactoryTriggerTriggersApiVersion);
            _dataFactoryTriggerTriggersRestClient = new TriggersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataFactoryTriggerTriggersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != DataFactoryResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, DataFactoryResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="data"> Trigger resource definition. </param>
        /// <param name="ifMatch"> ETag of the trigger entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataFactoryTriggerResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string triggerName, DataFactoryTriggerData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryTriggerTriggersClientDiagnostics.CreateScope("DataFactoryTriggerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataFactoryTriggerTriggersRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, triggerName, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation<DataFactoryTriggerResource>(Response.FromValue(new DataFactoryTriggerResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="data"> Trigger resource definition. </param>
        /// <param name="ifMatch"> ETag of the trigger entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataFactoryTriggerResource> CreateOrUpdate(WaitUntil waitUntil, string triggerName, DataFactoryTriggerData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryTriggerTriggersClientDiagnostics.CreateScope("DataFactoryTriggerCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataFactoryTriggerTriggersRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, triggerName, data, ifMatch, cancellationToken);
                var operation = new DataFactoryArmOperation<DataFactoryTriggerResource>(Response.FromValue(new DataFactoryTriggerResource(Client, response), response.GetRawResponse()));
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
        /// Gets a trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="ifNoneMatch"> ETag of the trigger entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<Response<DataFactoryTriggerResource>> GetAsync(string triggerName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _dataFactoryTriggerTriggersClientDiagnostics.CreateScope("DataFactoryTriggerCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataFactoryTriggerTriggersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, triggerName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a trigger.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="ifNoneMatch"> ETag of the trigger entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual Response<DataFactoryTriggerResource> Get(string triggerName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _dataFactoryTriggerTriggersClientDiagnostics.CreateScope("DataFactoryTriggerCollection.Get");
            scope.Start();
            try
            {
                var response = _dataFactoryTriggerTriggersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, triggerName, ifNoneMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryTriggerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists triggers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/triggers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_ListByFactory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataFactoryTriggerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataFactoryTriggerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryTriggerTriggersRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryTriggerTriggersRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataFactoryTriggerResource(Client, DataFactoryTriggerData.DeserializeDataFactoryTriggerData(e)), _dataFactoryTriggerTriggersClientDiagnostics, Pipeline, "DataFactoryTriggerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists triggers.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/triggers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_ListByFactory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataFactoryTriggerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataFactoryTriggerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryTriggerTriggersRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryTriggerTriggersRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataFactoryTriggerResource(Client, DataFactoryTriggerData.DeserializeDataFactoryTriggerData(e)), _dataFactoryTriggerTriggersClientDiagnostics, Pipeline, "DataFactoryTriggerCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="ifNoneMatch"> ETag of the trigger entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string triggerName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _dataFactoryTriggerTriggersClientDiagnostics.CreateScope("DataFactoryTriggerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataFactoryTriggerTriggersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, triggerName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/triggers/{triggerName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Triggers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="triggerName"> The trigger name. </param>
        /// <param name="ifNoneMatch"> ETag of the trigger entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="triggerName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="triggerName"/> is null. </exception>
        public virtual Response<bool> Exists(string triggerName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(triggerName, nameof(triggerName));

            using var scope = _dataFactoryTriggerTriggersClientDiagnostics.CreateScope("DataFactoryTriggerCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataFactoryTriggerTriggersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, triggerName, ifNoneMatch, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataFactoryTriggerResource> IEnumerable<DataFactoryTriggerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataFactoryTriggerResource> IAsyncEnumerable<DataFactoryTriggerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
