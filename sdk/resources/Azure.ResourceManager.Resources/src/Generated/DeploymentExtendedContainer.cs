// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;

namespace Azure.ResourceManager.Resources
{
    /// <summary> A class representing collection of DeploymentExtended and their operations over a Tenant. </summary>
    public partial class DeploymentExtendedContainer : ResourceContainerBase<TenantResourceIdentifier, DeploymentExtended, DeploymentExtendedData>
    {
        /// <summary> Initializes a new instance of the <see cref="DeploymentExtendedContainer"/> class for mocking. </summary>
        protected DeploymentExtendedContainer()
        {
        }

        /// <summary> Initializes a new instance of DeploymentExtendedContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal DeploymentExtendedContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        /// <summary> Verify that the input resource Id is a valid container for this type. </summary>
        /// <param name="identifier"> The input resource Id to check. </param>
        protected override void ValidateResourceType(ResourceIdentifier identifier)
        {
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private DeploymentsRestOperations _restClient => new DeploymentsRestOperations(_clientDiagnostics, Pipeline, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new TenantResourceIdentifier Id => base.Id as TenantResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceIdentifier.RootResourceIdentifier.ResourceType;

        // Container level operations.

        /// <summary> You can provide the template and parameters directly in the request or link to JSON files. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="parameters"> Additional parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<DeploymentExtended> CreateOrUpdate(string deploymentName, Deployment parameters, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(deploymentName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> You can provide the template and parameters directly in the request or link to JSON files. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="parameters"> Additional parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<DeploymentExtended>> CreateOrUpdateAsync(string deploymentName, Deployment parameters, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(deploymentName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> You can provide the template and parameters directly in the request or link to JSON files. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="parameters"> Additional parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual DeploymentsCreateOrUpdateAtScopeOperation StartCreateOrUpdate(string deploymentName, Deployment parameters, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdateAtScope(Id, deploymentName, parameters, cancellationToken);
                return new DeploymentsCreateOrUpdateAtScopeOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateAtScopeRequest(Id, deploymentName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> You can provide the template and parameters directly in the request or link to JSON files. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="parameters"> Additional parameters supplied to the operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="deploymentName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<DeploymentsCreateOrUpdateAtScopeOperation> StartCreateOrUpdateAsync(string deploymentName, Deployment parameters, CancellationToken cancellationToken = default)
        {
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAtScopeAsync(Id, deploymentName, parameters, cancellationToken).ConfigureAwait(false);
                return new DeploymentsCreateOrUpdateAtScopeOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateAtScopeRequest(Id, deploymentName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<DeploymentExtended> Get(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.Get");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                var response = _restClient.GetAtScope(Id, deploymentName, cancellationToken: cancellationToken);
                return Response.FromValue(new DeploymentExtended(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<DeploymentExtended>> GetAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.Get");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                var response = await _restClient.GetAtScopeAsync(Id, deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new DeploymentExtended(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual DeploymentExtended TryGet(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.TryGet");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                return Get(deploymentName, cancellationToken: cancellationToken).Value;
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<DeploymentExtended> TryGetAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.TryGet");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                return await GetAsync(deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            catch (RequestFailedException e) when (e.Status == 404)
            {
                return null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.DoesExist");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                return TryGet(deploymentName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="deploymentName"> The name of the deployment. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string deploymentName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.DoesExist");
            scope.Start();
            try
            {
                if (deploymentName == null)
                {
                    throw new ArgumentNullException(nameof(deploymentName));
                }

                return await TryGetAsync(deploymentName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get all the deployments at the given scope. </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=provisioningState eq &apos;{state}&apos;. </param>
        /// <param name="top"> The number of results to get. If null is passed, returns all deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DeploymentExtended" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<DeploymentExtended> List(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            Page<DeploymentExtended> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListAtScope(Id, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentExtended(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<DeploymentExtended> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListAtScopeNextPage(nextLink, Id, filter, top, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentExtended(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Get all the deployments at the given scope. </summary>
        /// <param name="filter"> The filter to apply on the operation. For example, you can use $filter=provisioningState eq &apos;{state}&apos;. </param>
        /// <param name="top"> The number of results to get. If null is passed, returns all deployments. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DeploymentExtended" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<DeploymentExtended> ListAsync(string filter = null, int? top = null, CancellationToken cancellationToken = default)
        {
            async Task<Page<DeploymentExtended>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAtScopeAsync(Id, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentExtended(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<DeploymentExtended>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("DeploymentExtendedContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListAtScopeNextPageAsync(nextLink, Id, filter, top, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new DeploymentExtended(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        // Builders.
        // public ArmBuilder<TenantResourceIdentifier, DeploymentExtended, DeploymentExtendedData> Construct() { }
    }
}
