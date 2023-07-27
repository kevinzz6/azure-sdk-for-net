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

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing a collection of <see cref="WorkloadClassifierResource" /> and their operations.
    /// Each <see cref="WorkloadClassifierResource" /> in the collection will belong to the same instance of <see cref="WorkloadGroupResource" />.
    /// To get a <see cref="WorkloadClassifierCollection" /> instance call the GetWorkloadClassifiers method from an instance of <see cref="WorkloadGroupResource" />.
    /// </summary>
    public partial class WorkloadClassifierCollection : ArmCollection, IEnumerable<WorkloadClassifierResource>, IAsyncEnumerable<WorkloadClassifierResource>
    {
        private readonly ClientDiagnostics _workloadClassifierClientDiagnostics;
        private readonly WorkloadClassifiersRestOperations _workloadClassifierRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadClassifierCollection"/> class for mocking. </summary>
        protected WorkloadClassifierCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="WorkloadClassifierCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal WorkloadClassifierCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _workloadClassifierClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Sql", WorkloadClassifierResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(WorkloadClassifierResource.ResourceType, out string workloadClassifierApiVersion);
            _workloadClassifierRestClient = new WorkloadClassifiersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, workloadClassifierApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != WorkloadGroupResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, WorkloadGroupResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a workload classifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}/workloadClassifiers/{workloadClassifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadClassifiers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workloadClassifierName"> The name of the workload classifier to create/update. </param>
        /// <param name="data"> The properties of the workload classifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadClassifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadClassifierName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<WorkloadClassifierResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string workloadClassifierName, WorkloadClassifierData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadClassifierName, nameof(workloadClassifierName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadClassifierClientDiagnostics.CreateScope("WorkloadClassifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workloadClassifierRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, workloadClassifierName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SqlArmOperation<WorkloadClassifierResource>(new WorkloadClassifierOperationSource(Client), _workloadClassifierClientDiagnostics, Pipeline, _workloadClassifierRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, workloadClassifierName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates a workload classifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}/workloadClassifiers/{workloadClassifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadClassifiers_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="workloadClassifierName"> The name of the workload classifier to create/update. </param>
        /// <param name="data"> The properties of the workload classifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadClassifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadClassifierName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<WorkloadClassifierResource> CreateOrUpdate(WaitUntil waitUntil, string workloadClassifierName, WorkloadClassifierData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadClassifierName, nameof(workloadClassifierName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _workloadClassifierClientDiagnostics.CreateScope("WorkloadClassifierCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workloadClassifierRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, workloadClassifierName, data, cancellationToken);
                var operation = new SqlArmOperation<WorkloadClassifierResource>(new WorkloadClassifierOperationSource(Client), _workloadClassifierClientDiagnostics, Pipeline, _workloadClassifierRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, workloadClassifierName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets a workload classifier
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}/workloadClassifiers/{workloadClassifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadClassifiers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadClassifierName"> The name of the workload classifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadClassifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadClassifierName"/> is null. </exception>
        public virtual async Task<Response<WorkloadClassifierResource>> GetAsync(string workloadClassifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadClassifierName, nameof(workloadClassifierName));

            using var scope = _workloadClassifierClientDiagnostics.CreateScope("WorkloadClassifierCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadClassifierRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, workloadClassifierName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadClassifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a workload classifier
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}/workloadClassifiers/{workloadClassifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadClassifiers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadClassifierName"> The name of the workload classifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadClassifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadClassifierName"/> is null. </exception>
        public virtual Response<WorkloadClassifierResource> Get(string workloadClassifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadClassifierName, nameof(workloadClassifierName));

            using var scope = _workloadClassifierClientDiagnostics.CreateScope("WorkloadClassifierCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadClassifierRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, workloadClassifierName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadClassifierResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the list of workload classifiers for a workload group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}/workloadClassifiers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadClassifiers_ListByWorkloadGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadClassifierResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadClassifierResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadClassifierRestClient.CreateListByWorkloadGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadClassifierRestClient.CreateListByWorkloadGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new WorkloadClassifierResource(Client, WorkloadClassifierData.DeserializeWorkloadClassifierData(e)), _workloadClassifierClientDiagnostics, Pipeline, "WorkloadClassifierCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets the list of workload classifiers for a workload group
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}/workloadClassifiers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadClassifiers_ListByWorkloadGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadClassifierResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadClassifierResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _workloadClassifierRestClient.CreateListByWorkloadGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _workloadClassifierRestClient.CreateListByWorkloadGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name);
            return PageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new WorkloadClassifierResource(Client, WorkloadClassifierData.DeserializeWorkloadClassifierData(e)), _workloadClassifierClientDiagnostics, Pipeline, "WorkloadClassifierCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}/workloadClassifiers/{workloadClassifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadClassifiers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadClassifierName"> The name of the workload classifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadClassifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadClassifierName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string workloadClassifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadClassifierName, nameof(workloadClassifierName));

            using var scope = _workloadClassifierClientDiagnostics.CreateScope("WorkloadClassifierCollection.Exists");
            scope.Start();
            try
            {
                var response = await _workloadClassifierRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, workloadClassifierName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}/workloadClassifiers/{workloadClassifierName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WorkloadClassifiers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workloadClassifierName"> The name of the workload classifier. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="workloadClassifierName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadClassifierName"/> is null. </exception>
        public virtual Response<bool> Exists(string workloadClassifierName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(workloadClassifierName, nameof(workloadClassifierName));

            using var scope = _workloadClassifierClientDiagnostics.CreateScope("WorkloadClassifierCollection.Exists");
            scope.Start();
            try
            {
                var response = _workloadClassifierRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, workloadClassifierName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<WorkloadClassifierResource> IEnumerable<WorkloadClassifierResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadClassifierResource> IAsyncEnumerable<WorkloadClassifierResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
