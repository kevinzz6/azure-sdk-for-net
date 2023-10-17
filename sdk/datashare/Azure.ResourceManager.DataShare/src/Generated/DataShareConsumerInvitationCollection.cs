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

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing a collection of <see cref="DataShareConsumerInvitationResource" /> and their operations.
    /// Each <see cref="DataShareConsumerInvitationResource" /> in the collection will belong to the same instance of <see cref="TenantResource" />.
    /// To get a <see cref="DataShareConsumerInvitationCollection" /> instance call the GetDataShareConsumerInvitations method from an instance of <see cref="TenantResource" />.
    /// </summary>
    public partial class DataShareConsumerInvitationCollection : ArmCollection, IEnumerable<DataShareConsumerInvitationResource>, IAsyncEnumerable<DataShareConsumerInvitationResource>
    {
        private readonly ClientDiagnostics _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics;
        private readonly ConsumerInvitationsRestOperations _dataShareConsumerInvitationConsumerInvitationsRestClient;

        /// <summary> Initializes a new instance of the <see cref="DataShareConsumerInvitationCollection"/> class for mocking. </summary>
        protected DataShareConsumerInvitationCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="DataShareConsumerInvitationCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal DataShareConsumerInvitationCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.DataShare", DataShareConsumerInvitationResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(DataShareConsumerInvitationResource.ResourceType, out string dataShareConsumerInvitationConsumerInvitationsApiVersion);
            _dataShareConsumerInvitationConsumerInvitationsRestClient = new ConsumerInvitationsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, dataShareConsumerInvitationConsumerInvitationsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Get an invitation
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DataShare/locations/{location}/consumerInvitations/{invitationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerInvitations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="invitationId"> An invitation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<DataShareConsumerInvitationResource>> GetAsync(AzureLocation location, Guid invitationId, CancellationToken cancellationToken = default)
        {
            using var scope = _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics.CreateScope("DataShareConsumerInvitationCollection.Get");
            scope.Start();
            try
            {
                var response = await _dataShareConsumerInvitationConsumerInvitationsRestClient.GetAsync(location, invitationId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareConsumerInvitationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get an invitation
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DataShare/locations/{location}/consumerInvitations/{invitationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerInvitations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="invitationId"> An invitation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<DataShareConsumerInvitationResource> Get(AzureLocation location, Guid invitationId, CancellationToken cancellationToken = default)
        {
            using var scope = _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics.CreateScope("DataShareConsumerInvitationCollection.Get");
            scope.Start();
            try
            {
                var response = _dataShareConsumerInvitationConsumerInvitationsRestClient.Get(location, invitationId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new DataShareConsumerInvitationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists invitations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DataShare/listInvitations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerInvitations_ListInvitations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> The continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="DataShareConsumerInvitationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<DataShareConsumerInvitationResource> GetAllAsync(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareConsumerInvitationConsumerInvitationsRestClient.CreateListInvitationsRequest(skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareConsumerInvitationConsumerInvitationsRestClient.CreateListInvitationsNextPageRequest(nextLink, skipToken);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new DataShareConsumerInvitationResource(Client, DataShareConsumerInvitationData.DeserializeDataShareConsumerInvitationData(e)), _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics, Pipeline, "DataShareConsumerInvitationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists invitations
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DataShare/listInvitations</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerInvitations_ListInvitations</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="skipToken"> The continuation token. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="DataShareConsumerInvitationResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<DataShareConsumerInvitationResource> GetAll(string skipToken = null, CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _dataShareConsumerInvitationConsumerInvitationsRestClient.CreateListInvitationsRequest(skipToken);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _dataShareConsumerInvitationConsumerInvitationsRestClient.CreateListInvitationsNextPageRequest(nextLink, skipToken);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new DataShareConsumerInvitationResource(Client, DataShareConsumerInvitationData.DeserializeDataShareConsumerInvitationData(e)), _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics, Pipeline, "DataShareConsumerInvitationCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.DataShare/locations/{location}/consumerInvitations/{invitationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerInvitations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="invitationId"> An invitation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(AzureLocation location, Guid invitationId, CancellationToken cancellationToken = default)
        {
            using var scope = _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics.CreateScope("DataShareConsumerInvitationCollection.Exists");
            scope.Start();
            try
            {
                var response = await _dataShareConsumerInvitationConsumerInvitationsRestClient.GetAsync(location, invitationId, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.DataShare/locations/{location}/consumerInvitations/{invitationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerInvitations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="invitationId"> An invitation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(AzureLocation location, Guid invitationId, CancellationToken cancellationToken = default)
        {
            using var scope = _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics.CreateScope("DataShareConsumerInvitationCollection.Exists");
            scope.Start();
            try
            {
                var response = _dataShareConsumerInvitationConsumerInvitationsRestClient.Get(location, invitationId, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.DataShare/locations/{location}/consumerInvitations/{invitationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerInvitations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="invitationId"> An invitation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<DataShareConsumerInvitationResource>> GetIfExistsAsync(AzureLocation location, Guid invitationId, CancellationToken cancellationToken = default)
        {
            using var scope = _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics.CreateScope("DataShareConsumerInvitationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _dataShareConsumerInvitationConsumerInvitationsRestClient.GetAsync(location, invitationId, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<DataShareConsumerInvitationResource>(response.GetRawResponse());
                return Response.FromValue(new DataShareConsumerInvitationResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.DataShare/locations/{location}/consumerInvitations/{invitationId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ConsumerInvitations_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="location"> Location of the invitation. </param>
        /// <param name="invitationId"> An invitation id. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<DataShareConsumerInvitationResource> GetIfExists(AzureLocation location, Guid invitationId, CancellationToken cancellationToken = default)
        {
            using var scope = _dataShareConsumerInvitationConsumerInvitationsClientDiagnostics.CreateScope("DataShareConsumerInvitationCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _dataShareConsumerInvitationConsumerInvitationsRestClient.Get(location, invitationId, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<DataShareConsumerInvitationResource>(response.GetRawResponse());
                return Response.FromValue(new DataShareConsumerInvitationResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<DataShareConsumerInvitationResource> IEnumerable<DataShareConsumerInvitationResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<DataShareConsumerInvitationResource> IAsyncEnumerable<DataShareConsumerInvitationResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
