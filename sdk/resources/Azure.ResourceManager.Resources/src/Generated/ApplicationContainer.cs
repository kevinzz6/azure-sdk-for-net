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
    /// <summary> A class representing collection of Application and their operations over a ResourceGroup. </summary>
    public partial class ApplicationContainer : ResourceContainerBase<ResourceGroupResourceIdentifier, Application, ApplicationData>
    {
        /// <summary> Initializes a new instance of the <see cref="ApplicationContainer"/> class for mocking. </summary>
        protected ApplicationContainer()
        {
        }

        /// <summary> Initializes a new instance of ApplicationContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ApplicationContainer(OperationsBase parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
        }

        private readonly ClientDiagnostics _clientDiagnostics;

        /// <summary> Represents the REST operations. </summary>
        private ApplicationsRestOperations _restClient => new ApplicationsRestOperations(_clientDiagnostics, Pipeline, Id.SubscriptionId, BaseUri);

        /// <summary> Typed Resource Identifier for the container. </summary>
        public new ResourceGroupResourceIdentifier Id => base.Id as ResourceGroupResourceIdentifier;

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ResourceGroupOperations.ResourceType;

        // Container level operations.

        /// <summary> Creates a new managed application. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual Response<Application> CreateOrUpdate(string applicationName, ApplicationData parameters, CancellationToken cancellationToken = default)
        {
            if (applicationName == null)
            {
                throw new ArgumentNullException(nameof(applicationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = StartCreateOrUpdate(applicationName, parameters, cancellationToken);
                return operation.WaitForCompletion(cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new managed application. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<Response<Application>> CreateOrUpdateAsync(string applicationName, ApplicationData parameters, CancellationToken cancellationToken = default)
        {
            if (applicationName == null)
            {
                throw new ArgumentNullException(nameof(applicationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var operation = await StartCreateOrUpdateAsync(applicationName, parameters, cancellationToken).ConfigureAwait(false);
                return await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new managed application. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual ApplicationsCreateOrUpdateOperation StartCreateOrUpdate(string applicationName, ApplicationData parameters, CancellationToken cancellationToken = default)
        {
            if (applicationName == null)
            {
                throw new ArgumentNullException(nameof(applicationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, applicationName, parameters, cancellationToken);
                return new ApplicationsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, applicationName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates a new managed application. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="parameters"> Parameters supplied to the create or update a managed application. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="applicationName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<ApplicationsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string applicationName, ApplicationData parameters, CancellationToken cancellationToken = default)
        {
            if (applicationName == null)
            {
                throw new ArgumentNullException(nameof(applicationName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, applicationName, parameters, cancellationToken).ConfigureAwait(false);
                return new ApplicationsCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, applicationName, parameters).Request, response);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<Application> Get(string applicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.Get");
            scope.Start();
            try
            {
                if (applicationName == null)
                {
                    throw new ArgumentNullException(nameof(applicationName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, applicationName, cancellationToken: cancellationToken);
                return Response.FromValue(new Application(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<Application>> GetAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.Get");
            scope.Start();
            try
            {
                if (applicationName == null)
                {
                    throw new ArgumentNullException(nameof(applicationName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, applicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(new Application(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Application TryGet(string applicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.TryGet");
            scope.Start();
            try
            {
                if (applicationName == null)
                {
                    throw new ArgumentNullException(nameof(applicationName));
                }

                return Get(applicationName, cancellationToken: cancellationToken).Value;
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
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Application> TryGetAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.TryGet");
            scope.Start();
            try
            {
                if (applicationName == null)
                {
                    throw new ArgumentNullException(nameof(applicationName));
                }

                return await GetAsync(applicationName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual bool DoesExist(string applicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.DoesExist");
            scope.Start();
            try
            {
                if (applicationName == null)
                {
                    throw new ArgumentNullException(nameof(applicationName));
                }

                return TryGet(applicationName, cancellationToken: cancellationToken) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="applicationName"> The name of the managed application. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<bool> DoesExistAsync(string applicationName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.DoesExist");
            scope.Start();
            try
            {
                if (applicationName == null)
                {
                    throw new ArgumentNullException(nameof(applicationName));
                }

                return await TryGetAsync(applicationName, cancellationToken: cancellationToken).ConfigureAwait(false) != null;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the applications within a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="Application" /> that may take multiple service requests to iterate over. </returns>
        public Pageable<Application> List(CancellationToken cancellationToken = default)
        {
            Page<Application> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroup(Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Application(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<Application> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.List");
                scope.Start();
                try
                {
                    var response = _restClient.ListByResourceGroupNextPage(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new Application(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the applications within a resource group. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="Application" /> that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<Application> ListAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<Application>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupAsync(Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Application(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<Application>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.List");
                scope.Start();
                try
                {
                    var response = await _restClient.ListByResourceGroupNextPageAsync(nextLink, Id.ResourceGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new Application(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="Application" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public Pageable<Core.GenericResourceExpanded> ListAsGenericResource(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ApplicationOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContext(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="Application" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public AsyncPageable<Core.GenericResourceExpanded> ListAsGenericResourceAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ApplicationContainer.ListAsGenericResource");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(ApplicationOperations.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.ListAtContextAsync(Parent as ResourceGroupOperations, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceGroupResourceIdentifier, Application, ApplicationData> Construct() { }
    }
}
