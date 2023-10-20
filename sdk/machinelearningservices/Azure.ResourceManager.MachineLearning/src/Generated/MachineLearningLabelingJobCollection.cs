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

namespace Azure.ResourceManager.MachineLearning
{
    /// <summary>
    /// A class representing a collection of <see cref="MachineLearningLabelingJobResource" /> and their operations.
    /// Each <see cref="MachineLearningLabelingJobResource" /> in the collection will belong to the same instance of <see cref="MachineLearningWorkspaceResource" />.
    /// To get a <see cref="MachineLearningLabelingJobCollection" /> instance call the GetMachineLearningLabelingJobs method from an instance of <see cref="MachineLearningWorkspaceResource" />.
    /// </summary>
    public partial class MachineLearningLabelingJobCollection : ArmCollection, IEnumerable<MachineLearningLabelingJobResource>, IAsyncEnumerable<MachineLearningLabelingJobResource>
    {
        private readonly ClientDiagnostics _machineLearningLabelingJobLabelingJobsClientDiagnostics;
        private readonly LabelingJobsRestOperations _machineLearningLabelingJobLabelingJobsRestClient;

        /// <summary> Initializes a new instance of the <see cref="MachineLearningLabelingJobCollection"/> class for mocking. </summary>
        protected MachineLearningLabelingJobCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MachineLearningLabelingJobCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal MachineLearningLabelingJobCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _machineLearningLabelingJobLabelingJobsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.MachineLearning", MachineLearningLabelingJobResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(MachineLearningLabelingJobResource.ResourceType, out string machineLearningLabelingJobLabelingJobsApiVersion);
            _machineLearningLabelingJobLabelingJobsRestClient = new LabelingJobsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, machineLearningLabelingJobLabelingJobsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != MachineLearningWorkspaceResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, MachineLearningWorkspaceResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Creates or updates a labeling job (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> The name and identifier for the LabelingJob. </param>
        /// <param name="data"> LabelingJob definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<MachineLearningLabelingJobResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string id, MachineLearningLabelingJobData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _machineLearningLabelingJobLabelingJobsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, cancellationToken).ConfigureAwait(false);
                var operation = new MachineLearningArmOperation<MachineLearningLabelingJobResource>(new MachineLearningLabelingJobOperationSource(Client), _machineLearningLabelingJobLabelingJobsClientDiagnostics, Pipeline, _machineLearningLabelingJobLabelingJobsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Creates or updates a labeling job (asynchronous).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="id"> The name and identifier for the LabelingJob. </param>
        /// <param name="data"> LabelingJob definition object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<MachineLearningLabelingJobResource> CreateOrUpdate(WaitUntil waitUntil, string id, MachineLearningLabelingJobData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _machineLearningLabelingJobLabelingJobsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data, cancellationToken);
                var operation = new MachineLearningArmOperation<MachineLearningLabelingJobResource>(new MachineLearningLabelingJobOperationSource(Client), _machineLearningLabelingJobLabelingJobsClientDiagnostics, Pipeline, _machineLearningLabelingJobLabelingJobsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, data).Request, response, OperationFinalStateVia.OriginalUri);
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
        /// Gets a labeling job by name/id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The name and identifier for the LabelingJob. </param>
        /// <param name="includeJobInstructions"> Boolean value to indicate whether to include JobInstructions in response. </param>
        /// <param name="includeLabelCategories"> Boolean value to indicate Whether to include LabelCategories in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<MachineLearningLabelingJobResource>> GetAsync(string id, bool? includeJobInstructions = null, bool? includeLabelCategories = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobCollection.Get");
            scope.Start();
            try
            {
                var response = await _machineLearningLabelingJobLabelingJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, includeJobInstructions, includeLabelCategories, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningLabelingJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a labeling job by name/id.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The name and identifier for the LabelingJob. </param>
        /// <param name="includeJobInstructions"> Boolean value to indicate whether to include JobInstructions in response. </param>
        /// <param name="includeLabelCategories"> Boolean value to indicate Whether to include LabelCategories in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<MachineLearningLabelingJobResource> Get(string id, bool? includeJobInstructions = null, bool? includeLabelCategories = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobCollection.Get");
            scope.Start();
            try
            {
                var response = _machineLearningLabelingJobLabelingJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, includeJobInstructions, includeLabelCategories, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new MachineLearningLabelingJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists labeling jobs in the workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="top"> Number of labeling jobs to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="MachineLearningLabelingJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<MachineLearningLabelingJobResource> GetAllAsync(string skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningLabelingJobLabelingJobsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningLabelingJobLabelingJobsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new MachineLearningLabelingJobResource(Client, MachineLearningLabelingJobData.DeserializeMachineLearningLabelingJobData(e)), _machineLearningLabelingJobLabelingJobsClientDiagnostics, Pipeline, "MachineLearningLabelingJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists labeling jobs in the workspace.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="top"> Number of labeling jobs to return. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="MachineLearningLabelingJobResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<MachineLearningLabelingJobResource> GetAll(string skip = null, int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _machineLearningLabelingJobLabelingJobsRestClient.CreateListRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _machineLearningLabelingJobLabelingJobsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, skip, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new MachineLearningLabelingJobResource(Client, MachineLearningLabelingJobData.DeserializeMachineLearningLabelingJobData(e)), _machineLearningLabelingJobLabelingJobsClientDiagnostics, Pipeline, "MachineLearningLabelingJobCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The name and identifier for the LabelingJob. </param>
        /// <param name="includeJobInstructions"> Boolean value to indicate whether to include JobInstructions in response. </param>
        /// <param name="includeLabelCategories"> Boolean value to indicate Whether to include LabelCategories in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string id, bool? includeJobInstructions = null, bool? includeLabelCategories = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobCollection.Exists");
            scope.Start();
            try
            {
                var response = await _machineLearningLabelingJobLabelingJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, includeJobInstructions, includeLabelCategories, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The name and identifier for the LabelingJob. </param>
        /// <param name="includeJobInstructions"> Boolean value to indicate whether to include JobInstructions in response. </param>
        /// <param name="includeLabelCategories"> Boolean value to indicate Whether to include LabelCategories in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual Response<bool> Exists(string id, bool? includeJobInstructions = null, bool? includeLabelCategories = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobCollection.Exists");
            scope.Start();
            try
            {
                var response = _machineLearningLabelingJobLabelingJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, includeJobInstructions, includeLabelCategories, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The name and identifier for the LabelingJob. </param>
        /// <param name="includeJobInstructions"> Boolean value to indicate whether to include JobInstructions in response. </param>
        /// <param name="includeLabelCategories"> Boolean value to indicate Whether to include LabelCategories in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual async Task<NullableResponse<MachineLearningLabelingJobResource>> GetIfExistsAsync(string id, bool? includeJobInstructions = null, bool? includeLabelCategories = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _machineLearningLabelingJobLabelingJobsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, includeJobInstructions, includeLabelCategories, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningLabelingJobResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningLabelingJobResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.MachineLearningServices/workspaces/{workspaceName}/labelingJobs/{id}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>LabelingJobs_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="id"> The name and identifier for the LabelingJob. </param>
        /// <param name="includeJobInstructions"> Boolean value to indicate whether to include JobInstructions in response. </param>
        /// <param name="includeLabelCategories"> Boolean value to indicate Whether to include LabelCategories in response. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="id"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> is null. </exception>
        public virtual NullableResponse<MachineLearningLabelingJobResource> GetIfExists(string id, bool? includeJobInstructions = null, bool? includeLabelCategories = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(id, nameof(id));

            using var scope = _machineLearningLabelingJobLabelingJobsClientDiagnostics.CreateScope("MachineLearningLabelingJobCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _machineLearningLabelingJobLabelingJobsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, id, includeJobInstructions, includeLabelCategories, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<MachineLearningLabelingJobResource>(response.GetRawResponse());
                return Response.FromValue(new MachineLearningLabelingJobResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<MachineLearningLabelingJobResource> IEnumerable<MachineLearningLabelingJobResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<MachineLearningLabelingJobResource> IAsyncEnumerable<MachineLearningLabelingJobResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
