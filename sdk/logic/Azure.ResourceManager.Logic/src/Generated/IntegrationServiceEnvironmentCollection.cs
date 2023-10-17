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
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Logic
{
    /// <summary>
    /// A class representing a collection of <see cref="IntegrationServiceEnvironmentResource" /> and their operations.
    /// Each <see cref="IntegrationServiceEnvironmentResource" /> in the collection will belong to the same instance of <see cref="ResourceGroupResource" />.
    /// To get an <see cref="IntegrationServiceEnvironmentCollection" /> instance call the GetIntegrationServiceEnvironments method from an instance of <see cref="ResourceGroupResource" />.
    /// </summary>
    public partial class IntegrationServiceEnvironmentCollection : ArmCollection, IEnumerable<IntegrationServiceEnvironmentResource>, IAsyncEnumerable<IntegrationServiceEnvironmentResource>
    {
        private readonly ClientDiagnostics _integrationServiceEnvironmentClientDiagnostics;
        private readonly IntegrationServiceEnvironmentsRestOperations _integrationServiceEnvironmentRestClient;

        /// <summary> Initializes a new instance of the <see cref="IntegrationServiceEnvironmentCollection"/> class for mocking. </summary>
        protected IntegrationServiceEnvironmentCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="IntegrationServiceEnvironmentCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal IntegrationServiceEnvironmentCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _integrationServiceEnvironmentClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Logic", IntegrationServiceEnvironmentResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(IntegrationServiceEnvironmentResource.ResourceType, out string integrationServiceEnvironmentApiVersion);
            _integrationServiceEnvironmentRestClient = new IntegrationServiceEnvironmentsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, integrationServiceEnvironmentApiVersion);
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
        /// Creates or updates an integration service environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="data"> The integration service environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationServiceEnvironmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<IntegrationServiceEnvironmentResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string integrationServiceEnvironmentName, IntegrationServiceEnvironmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationServiceEnvironmentName, nameof(integrationServiceEnvironmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _integrationServiceEnvironmentClientDiagnostics.CreateScope("IntegrationServiceEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _integrationServiceEnvironmentRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, integrationServiceEnvironmentName, data, cancellationToken).ConfigureAwait(false);
                var operation = new LogicArmOperation<IntegrationServiceEnvironmentResource>(new IntegrationServiceEnvironmentOperationSource(Client), _integrationServiceEnvironmentClientDiagnostics, Pipeline, _integrationServiceEnvironmentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, integrationServiceEnvironmentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Creates or updates an integration service environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="data"> The integration service environment. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationServiceEnvironmentName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<IntegrationServiceEnvironmentResource> CreateOrUpdate(WaitUntil waitUntil, string integrationServiceEnvironmentName, IntegrationServiceEnvironmentData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationServiceEnvironmentName, nameof(integrationServiceEnvironmentName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _integrationServiceEnvironmentClientDiagnostics.CreateScope("IntegrationServiceEnvironmentCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _integrationServiceEnvironmentRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, integrationServiceEnvironmentName, data, cancellationToken);
                var operation = new LogicArmOperation<IntegrationServiceEnvironmentResource>(new IntegrationServiceEnvironmentOperationSource(Client), _integrationServiceEnvironmentClientDiagnostics, Pipeline, _integrationServiceEnvironmentRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, integrationServiceEnvironmentName, data).Request, response, OperationFinalStateVia.Location);
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
        /// Gets an integration service environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        public virtual async Task<Response<IntegrationServiceEnvironmentResource>> GetAsync(string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationServiceEnvironmentName, nameof(integrationServiceEnvironmentName));

            using var scope = _integrationServiceEnvironmentClientDiagnostics.CreateScope("IntegrationServiceEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = await _integrationServiceEnvironmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, integrationServiceEnvironmentName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationServiceEnvironmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets an integration service environment.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        public virtual Response<IntegrationServiceEnvironmentResource> Get(string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationServiceEnvironmentName, nameof(integrationServiceEnvironmentName));

            using var scope = _integrationServiceEnvironmentClientDiagnostics.CreateScope("IntegrationServiceEnvironmentCollection.Get");
            scope.Start();
            try
            {
                var response = _integrationServiceEnvironmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, integrationServiceEnvironmentName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new IntegrationServiceEnvironmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of integration service environments by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="IntegrationServiceEnvironmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<IntegrationServiceEnvironmentResource> GetAllAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _integrationServiceEnvironmentRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _integrationServiceEnvironmentRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new IntegrationServiceEnvironmentResource(Client, IntegrationServiceEnvironmentData.DeserializeIntegrationServiceEnvironmentData(e)), _integrationServiceEnvironmentClientDiagnostics, Pipeline, "IntegrationServiceEnvironmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of integration service environments by resource group.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_ListByResourceGroup</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="IntegrationServiceEnvironmentResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<IntegrationServiceEnvironmentResource> GetAll(int? top = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _integrationServiceEnvironmentRestClient.CreateListByResourceGroupRequest(Id.SubscriptionId, Id.ResourceGroupName, top);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _integrationServiceEnvironmentRestClient.CreateListByResourceGroupNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, top);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new IntegrationServiceEnvironmentResource(Client, IntegrationServiceEnvironmentData.DeserializeIntegrationServiceEnvironmentData(e)), _integrationServiceEnvironmentClientDiagnostics, Pipeline, "IntegrationServiceEnvironmentCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationServiceEnvironmentName, nameof(integrationServiceEnvironmentName));

            using var scope = _integrationServiceEnvironmentClientDiagnostics.CreateScope("IntegrationServiceEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = await _integrationServiceEnvironmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, integrationServiceEnvironmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        public virtual Response<bool> Exists(string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationServiceEnvironmentName, nameof(integrationServiceEnvironmentName));

            using var scope = _integrationServiceEnvironmentClientDiagnostics.CreateScope("IntegrationServiceEnvironmentCollection.Exists");
            scope.Start();
            try
            {
                var response = _integrationServiceEnvironmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, integrationServiceEnvironmentName, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        public virtual async Task<NullableResponse<IntegrationServiceEnvironmentResource>> GetIfExistsAsync(string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationServiceEnvironmentName, nameof(integrationServiceEnvironmentName));

            using var scope = _integrationServiceEnvironmentClientDiagnostics.CreateScope("IntegrationServiceEnvironmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _integrationServiceEnvironmentRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, integrationServiceEnvironmentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<IntegrationServiceEnvironmentResource>(response.GetRawResponse());
                return Response.FromValue(new IntegrationServiceEnvironmentResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Logic/integrationServiceEnvironments/{integrationServiceEnvironmentName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>IntegrationServiceEnvironments_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="integrationServiceEnvironmentName"> The integration service environment name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="integrationServiceEnvironmentName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="integrationServiceEnvironmentName"/> is null. </exception>
        public virtual NullableResponse<IntegrationServiceEnvironmentResource> GetIfExists(string integrationServiceEnvironmentName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(integrationServiceEnvironmentName, nameof(integrationServiceEnvironmentName));

            using var scope = _integrationServiceEnvironmentClientDiagnostics.CreateScope("IntegrationServiceEnvironmentCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _integrationServiceEnvironmentRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, integrationServiceEnvironmentName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<IntegrationServiceEnvironmentResource>(response.GetRawResponse());
                return Response.FromValue(new IntegrationServiceEnvironmentResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<IntegrationServiceEnvironmentResource> IEnumerable<IntegrationServiceEnvironmentResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<IntegrationServiceEnvironmentResource> IAsyncEnumerable<IntegrationServiceEnvironmentResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
