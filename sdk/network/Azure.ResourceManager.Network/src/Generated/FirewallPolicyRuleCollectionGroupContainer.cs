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
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of FirewallPolicyRuleCollectionGroup and their operations over a FirewallPolicy. </summary>
    public partial class FirewallPolicyRuleCollectionGroupContainer : ArmContainer
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly FirewallPolicyRuleCollectionGroupsRestOperations _restClient;

        /// <summary> Initializes a new instance of the <see cref="FirewallPolicyRuleCollectionGroupContainer"/> class for mocking. </summary>
        protected FirewallPolicyRuleCollectionGroupContainer()
        {
        }

        /// <summary> Initializes a new instance of FirewallPolicyRuleCollectionGroupContainer class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal FirewallPolicyRuleCollectionGroupContainer(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _restClient = new FirewallPolicyRuleCollectionGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, Id.SubscriptionId, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => FirewallPolicy.ResourceType;

        // Container level operations.

        /// <summary> Creates or updates the specified FirewallPolicyRuleCollectionGroup. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="parameters"> Parameters supplied to the create or update FirewallPolicyRuleCollectionGroup operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation CreateOrUpdate(string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ruleCollectionGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleCollectionGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _restClient.CreateOrUpdate(Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, parameters, cancellationToken);
                var operation = new FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, parameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates the specified FirewallPolicyRuleCollectionGroup. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="parameters"> Parameters supplied to the create or update FirewallPolicyRuleCollectionGroup operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ruleCollectionGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation> CreateOrUpdateAsync(string ruleCollectionGroupName, FirewallPolicyRuleCollectionGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (ruleCollectionGroupName == null)
            {
                throw new ArgumentNullException(nameof(ruleCollectionGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _restClient.CreateOrUpdateAsync(Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new FirewallPolicyRuleCollectionGroupCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _restClient.CreateCreateOrUpdateRequest(Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, parameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<FirewallPolicyRuleCollectionGroup> Get(string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.Get");
            scope.Start();
            try
            {
                if (ruleCollectionGroupName == null)
                {
                    throw new ArgumentNullException(nameof(ruleCollectionGroupName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new FirewallPolicyRuleCollectionGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets details for this resource from the service. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<FirewallPolicyRuleCollectionGroup>> GetAsync(string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.Get");
            scope.Start();
            try
            {
                if (ruleCollectionGroupName == null)
                {
                    throw new ArgumentNullException(nameof(ruleCollectionGroupName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new FirewallPolicyRuleCollectionGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<FirewallPolicyRuleCollectionGroup> GetIfExists(string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.GetIfExists");
            scope.Start();
            try
            {
                if (ruleCollectionGroupName == null)
                {
                    throw new ArgumentNullException(nameof(ruleCollectionGroupName));
                }

                var response = _restClient.Get(Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<FirewallPolicyRuleCollectionGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new FirewallPolicyRuleCollectionGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<FirewallPolicyRuleCollectionGroup>> GetIfExistsAsync(string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.GetIfExists");
            scope.Start();
            try
            {
                if (ruleCollectionGroupName == null)
                {
                    throw new ArgumentNullException(nameof(ruleCollectionGroupName));
                }

                var response = await _restClient.GetAsync(Id.ResourceGroupName, Id.Name, ruleCollectionGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<FirewallPolicyRuleCollectionGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new FirewallPolicyRuleCollectionGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public virtual Response<bool> CheckIfExists(string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (ruleCollectionGroupName == null)
                {
                    throw new ArgumentNullException(nameof(ruleCollectionGroupName));
                }

                var response = GetIfExists(ruleCollectionGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="ruleCollectionGroupName"> The name of the FirewallPolicyRuleCollectionGroup. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        public async virtual Task<Response<bool>> CheckIfExistsAsync(string ruleCollectionGroupName, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.CheckIfExists");
            scope.Start();
            try
            {
                if (ruleCollectionGroupName == null)
                {
                    throw new ArgumentNullException(nameof(ruleCollectionGroupName));
                }

                var response = await GetIfExistsAsync(ruleCollectionGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="FirewallPolicyRuleCollectionGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<FirewallPolicyRuleCollectionGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<FirewallPolicyRuleCollectionGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAll(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallPolicyRuleCollectionGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<FirewallPolicyRuleCollectionGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = _restClient.GetAllNextPage(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallPolicyRuleCollectionGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Lists all FirewallPolicyRuleCollectionGroups in a FirewallPolicy resource. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="FirewallPolicyRuleCollectionGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<FirewallPolicyRuleCollectionGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<FirewallPolicyRuleCollectionGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllAsync(Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallPolicyRuleCollectionGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<FirewallPolicyRuleCollectionGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.GetAll");
                scope.Start();
                try
                {
                    var response = await _restClient.GetAllNextPageAsync(nextLink, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new FirewallPolicyRuleCollectionGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Filters the list of <see cref="FirewallPolicyRuleCollectionGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<GenericResource> GetAllAsGenericResources(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(FirewallPolicyRuleCollectionGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContext(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Filters the list of <see cref="FirewallPolicyRuleCollectionGroup" /> for this resource group represented as generic resources. </summary>
        /// <param name="nameFilter"> The filter used in this operation. </param>
        /// <param name="expand"> Comma-separated list of additional properties to be included in the response. Valid values include `createdTime`, `changedTime` and `provisioningState`. </param>
        /// <param name="top"> The number of results to return. </param>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> An async collection of resource that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<GenericResource> GetAllAsGenericResourcesAsync(string nameFilter, string expand = null, int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("FirewallPolicyRuleCollectionGroupContainer.GetAllAsGenericResources");
            scope.Start();
            try
            {
                var filters = new ResourceFilterCollection(FirewallPolicyRuleCollectionGroup.ResourceType);
                filters.SubstringFilter = nameFilter;
                return ResourceListOperations.GetAtContextAsync(Parent as ResourceGroup, filters, expand, top, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        // Builders.
        // public ArmBuilder<ResourceIdentifier, FirewallPolicyRuleCollectionGroup, FirewallPolicyRuleCollectionGroupData> Construct() { }
    }
}
