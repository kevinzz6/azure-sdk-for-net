// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ApiManagement.Models;

namespace Azure.ResourceManager.ApiManagement
{
    /// <summary>
    /// A Class representing an ApiManagementCertificate along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="ApiManagementCertificateResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetApiManagementCertificateResource method.
    /// Otherwise you can get one from its parent resource <see cref="ApiManagementServiceResource" /> using the GetApiManagementCertificate method.
    /// </summary>
    public partial class ApiManagementCertificateResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="ApiManagementCertificateResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string serviceName, string certificateId)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _apiManagementCertificateCertificateClientDiagnostics;
        private readonly CertificateRestOperations _apiManagementCertificateCertificateRestClient;
        private readonly ApiManagementCertificateData _data;

        /// <summary> Initializes a new instance of the <see cref="ApiManagementCertificateResource"/> class for mocking. </summary>
        protected ApiManagementCertificateResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ApiManagementCertificateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal ApiManagementCertificateResource(ArmClient client, ApiManagementCertificateData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="ApiManagementCertificateResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ApiManagementCertificateResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _apiManagementCertificateCertificateClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.ApiManagement", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string apiManagementCertificateCertificateApiVersion);
            _apiManagementCertificateCertificateRestClient = new CertificateRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, apiManagementCertificateCertificateApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.ApiManagement/service/certificates";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ApiManagementCertificateData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets the details of the certificate specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementCertificateResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateResource.Get");
            scope.Start();
            try
            {
                var response = await _apiManagementCertificateCertificateRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the details of the certificate specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementCertificateResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateResource.Get");
            scope.Start();
            try
            {
                var response = _apiManagementCertificateCertificateRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ApiManagementCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes specific certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateResource.Delete");
            scope.Start();
            try
            {
                var response = await _apiManagementCertificateCertificateRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Deletes specific certificate.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="ifMatch"> ETag of the Entity. ETag should match the current entity state from the header response of the GET request or it should be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, ETag ifMatch, CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateResource.Delete");
            scope.Start();
            try
            {
                var response = _apiManagementCertificateCertificateRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Creates or updates the certificate being used for authentication with the backend.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Create or Update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ApiManagementCertificateResource>> UpdateAsync(WaitUntil waitUntil, ApiManagementCertificateCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateResource.Update");
            scope.Start();
            try
            {
                var response = await _apiManagementCertificateCertificateRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, ifMatch, cancellationToken).ConfigureAwait(false);
                var operation = new ApiManagementArmOperation<ApiManagementCertificateResource>(Response.FromValue(new ApiManagementCertificateResource(Client, response), response.GetRawResponse()));
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
        /// Creates or updates the certificate being used for authentication with the backend.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="content"> Create or Update parameters. </param>
        /// <param name="ifMatch"> ETag of the Entity. Not required when creating an entity, but required when updating an entity. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ApiManagementCertificateResource> Update(WaitUntil waitUntil, ApiManagementCertificateCreateOrUpdateContent content, ETag? ifMatch = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateResource.Update");
            scope.Start();
            try
            {
                var response = _apiManagementCertificateCertificateRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, content, ifMatch, cancellationToken);
                var operation = new ApiManagementArmOperation<ApiManagementCertificateResource>(Response.FromValue(new ApiManagementCertificateResource(Client, response), response.GetRawResponse()));
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
        /// From KeyVault, Refresh the certificate being used for authentication with the backend.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}/refreshSecret</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_RefreshSecret</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ApiManagementCertificateResource>> RefreshSecretAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateResource.RefreshSecret");
            scope.Start();
            try
            {
                var response = await _apiManagementCertificateCertificateRestClient.RefreshSecretAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new ApiManagementCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// From KeyVault, Refresh the certificate being used for authentication with the backend.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}/refreshSecret</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_RefreshSecret</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ApiManagementCertificateResource> RefreshSecret(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateResource.RefreshSecret");
            scope.Start();
            try
            {
                var response = _apiManagementCertificateCertificateRestClient.RefreshSecret(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return Response.FromValue(new ApiManagementCertificateResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the certificate specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> GetEntityTagAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = await _apiManagementCertificateCertificateRestClient.GetEntityTagAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets the entity state (Etag) version of the certificate specified by its identifier.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ApiManagement/service/{serviceName}/certificates/{certificateId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Certificate_GetEntityTag</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> GetEntityTag(CancellationToken cancellationToken = default)
        {
            using var scope = _apiManagementCertificateCertificateClientDiagnostics.CreateScope("ApiManagementCertificateResource.GetEntityTag");
            scope.Start();
            try
            {
                var response = _apiManagementCertificateCertificateRestClient.GetEntityTag(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
