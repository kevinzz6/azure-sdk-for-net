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

namespace Azure.ResourceManager.DataFactory
{
    /// <summary>
    /// A class representing a collection of <see cref="DataFactoryManagedIdentityCredentialResource" /> and their operations.
    /// Each <see cref="DataFactoryManagedIdentityCredentialResource" /> in the collection will belong to the same instance of <see cref="DataFactoryResource" />.
    /// To get a <see cref="DataFactoryManagedIdentityCredentialCollection" /> instance call the GetDataFactoryManagedIdentityCredentials method from an instance of <see cref="DataFactoryResource" />.
    /// </summary>
    public partial class DataFactoryManagedIdentityCredentialCollection : ArmCollection, IEnumerable<DataFactoryManagedIdentityCredentialResource>, IAsyncEnumerable<DataFactoryManagedIdentityCredentialResource>
    {
        private readonly ClientDiagnostics _dataFactoryManagedIdentityCredentialCredentialOperationsClientDiagnostics;
        private readonly CredentialRestOperations _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataFactoryManagedIdentityCredentialCollection"/> class for mocking. </summary>
        protected DataFactoryManagedIdentityCredentialCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataFactoryManagedIdentityCredentialCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataFactoryManagedIdentityCredentialCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataFactoryManagedIdentityCredentialCredentialOperationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataFactory", DataFactoryManagedIdentityCredentialResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataFactoryManagedIdentityCredentialResource.ResourceType, out string dataFactoryManagedIdentityCredentialCredentialOperationsApiVersion);
            _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient = new CredentialRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataFactoryManagedIdentityCredentialCredentialOperationsApiVersion);
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
        /// Creates or updates a credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CredentialOperations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="credentialName"> Credential name. </param>
        /// <param name="data"> Credential resource definition. </param>
        /// <param name="ifMatch"> ETag of the credential entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<DataFactoryManagedIdentityCredentialResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string credentialName, DataFactoryManagedIdentityCredentialData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryManagedIdentityCredentialCredentialOperationsClientDiagnostics.CreateScope("DataFactoryManagedIdentityCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, data, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new DataFactoryArmOperation<DataFactoryManagedIdentityCredentialResource>(Response.FromValue(new DataFactoryManagedIdentityCredentialResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates a credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CredentialOperations_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="credentialName"> Credential name. </param>
        /// <param name="data"> Credential resource definition. </param>
        /// <param name="ifMatch"> ETag of the credential entity. Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<DataFactoryManagedIdentityCredentialResource> CreateOrUpdate(WaitUntil waitUntil, string credentialName, DataFactoryManagedIdentityCredentialData data, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _dataFactoryManagedIdentityCredentialCredentialOperationsClientDiagnostics.CreateScope("DataFactoryManagedIdentityCredentialCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, data, ifMatch, cancellationToken);
                var operation = new DataFactoryArmOperation<DataFactoryManagedIdentityCredentialResource>(Response.FromValue(new DataFactoryManagedIdentityCredentialResource(Client, response), response.GetRawResponse()));
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
        /// Gets a credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CredentialOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> Credential name. </param>
        /// <param name="ifNoneMatch"> ETag of the credential entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual async Task<Response<DataFactoryManagedIdentityCredentialResource>> GetAsync(string credentialName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _dataFactoryManagedIdentityCredentialCredentialOperationsClientDiagnostics.CreateScope("DataFactoryManagedIdentityCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, ifNoneMatch, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryManagedIdentityCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a credential.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CredentialOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> Credential name. </param>
        /// <param name="ifNoneMatch"> ETag of the credential entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<DataFactoryManagedIdentityCredentialResource> Get(string credentialName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _dataFactoryManagedIdentityCredentialCredentialOperationsClientDiagnostics.CreateScope("DataFactoryManagedIdentityCredentialCollection.Get");
            scope.Start();
            try
            {
                var response = _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, ifNoneMatch, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataFactoryManagedIdentityCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List credentials.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/credentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CredentialOperations_ListByFactory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataFactoryManagedIdentityCredentialResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataFactoryManagedIdentityCredentialResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataFactoryManagedIdentityCredentialResource(Client, DataFactoryManagedIdentityCredentialData.DeserializeDataFactoryManagedIdentityCredentialData(e)), _dataFactoryManagedIdentityCredentialCredentialOperationsClientDiagnostics, Pipeline, "DataFactoryManagedIdentityCredentialCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List credentials.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/credentials</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CredentialOperations_ListByFactory</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataFactoryManagedIdentityCredentialResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataFactoryManagedIdentityCredentialResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient.CreateListByFactoryRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient.CreateListByFactoryNextPageRequest(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataFactoryManagedIdentityCredentialResource(Client, DataFactoryManagedIdentityCredentialData.DeserializeDataFactoryManagedIdentityCredentialData(e)), _dataFactoryManagedIdentityCredentialCredentialOperationsClientDiagnostics, Pipeline, "DataFactoryManagedIdentityCredentialCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CredentialOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> Credential name. </param>
        /// <param name="ifNoneMatch"> ETag of the credential entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string credentialName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _dataFactoryManagedIdentityCredentialCredentialOperationsClientDiagnostics.CreateScope("DataFactoryManagedIdentityCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CredentialOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> Credential name. </param>
        /// <param name="ifNoneMatch"> ETag of the credential entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual Response<bool> Exists(string credentialName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _dataFactoryManagedIdentityCredentialCredentialOperationsClientDiagnostics.CreateScope("DataFactoryManagedIdentityCredentialCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, ifNoneMatch, cancellationToken: cancellationToken);
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CredentialOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> Credential name. </param>
        /// <param name="ifNoneMatch"> ETag of the credential entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual async Task<NullableResponse<DataFactoryManagedIdentityCredentialResource>> GetIfExistsAsync(string credentialName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _dataFactoryManagedIdentityCredentialCredentialOperationsClientDiagnostics.CreateScope("DataFactoryManagedIdentityCredentialCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, ifNoneMatch, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataFactoryManagedIdentityCredentialResource>(response.GetRawResponse());
                return Response.FromValue(new DataFactoryManagedIdentityCredentialResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DataFactory/factories/{factoryName}/credentials/{credentialName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>CredentialOperations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="credentialName"> Credential name. </param>
        /// <param name="ifNoneMatch"> ETag of the credential entity. Should only be specified for get. If the ETag matches the existing entity tag, or if * was provided, then no content will be returned. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="credentialName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> is null. </exception>
        public virtual NullableResponse<DataFactoryManagedIdentityCredentialResource> GetIfExists(string credentialName, string ifNoneMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(credentialName, nameof(credentialName));

            using var scope = _dataFactoryManagedIdentityCredentialCredentialOperationsClientDiagnostics.CreateScope("DataFactoryManagedIdentityCredentialCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataFactoryManagedIdentityCredentialCredentialOperationsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, credentialName, ifNoneMatch, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataFactoryManagedIdentityCredentialResource>(response.GetRawResponse());
                return Response.FromValue(new DataFactoryManagedIdentityCredentialResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataFactoryManagedIdentityCredentialResource> IEnumerable<DataFactoryManagedIdentityCredentialResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataFactoryManagedIdentityCredentialResource> IAsyncEnumerable<DataFactoryManagedIdentityCredentialResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
