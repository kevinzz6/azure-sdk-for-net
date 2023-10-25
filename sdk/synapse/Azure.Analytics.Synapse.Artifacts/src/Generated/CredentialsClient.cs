// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Analytics.Synapse.Artifacts.Models;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.Analytics.Synapse.Artifacts
{
    /// <summary> The Credentials service client. </summary>
    public partial class CredentialsClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal CredentialsRestClient RestClient { get; }

        /// <summary> Initializes a new instance of CredentialsClient for mocking. </summary>
        protected CredentialsClient()
        {
        }

        /// <summary> Initializes a new instance of CredentialsClient. </summary>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <param name="credential"> A credential used to authenticate to an Azure Service. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public CredentialsClient(Uri endpoint, TokenCredential credential, ArtifactsClientOptions options = null)
        {
            if (endpoint == null)
            {
                throw new ArgumentNullException(nameof(endpoint));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            options ??= new ArtifactsClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            string[] scopes = { "https://dev.azuresynapse.net/.default" };
            _pipeline = HttpPipelineBuilder.Build(options, new BearerTokenAuthenticationPolicy(credential, scopes));
            RestClient = new CredentialsRestClient(_clientDiagnostics, _pipeline, endpoint);
        }

        /// <summary> Initializes a new instance of CredentialsClient. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="endpoint"> The workspace development endpoint, for example `https://myworkspace.dev.azuresynapse.net`. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clientDiagnostics"/>, <paramref name="pipeline"/> or <paramref name="endpoint"/> is null. </exception>
        internal CredentialsClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Uri endpoint)
        {
            RestClient = new CredentialsRestClient(clientDiagnostics, pipeline, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Lists credentials. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<ManagedIdentityCredentialResource> ListByWorkspaceAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListByWorkspaceRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListByWorkspaceNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, ManagedIdentityCredentialResource.DeserializeManagedIdentityCredentialResource, _clientDiagnostics, _pipeline, "CredentialsClient.ListByWorkspace", "value", "nextLink", cancellationToken);
        }

        /// <summary> Lists credentials. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<ManagedIdentityCredentialResource> ListByWorkspace(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => RestClient.CreateListByWorkspaceRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => RestClient.CreateListByWorkspaceNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, ManagedIdentityCredentialResource.DeserializeManagedIdentityCredentialResource, _clientDiagnostics, _pipeline, "CredentialsClient.ListByWorkspace", "value", "nextLink", cancellationToken);
        }

        /// <summary> Creates or updates a credential. </summary>
        /// <param name="credentialName"> Credential name. </param>
        /// <param name="credential"> Credential resource definition. </param>
        /// <param name="ifMatch"> ETag of the credential entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="credential"/> is null. </exception>
        public virtual async Task<CredentialsCreateOrUpdateOperation> StartCreateOrUpdateAsync(string credentialName, ManagedIdentityCredentialResource credential, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (credentialName == null)
            {
                throw new ArgumentNullException(nameof(credentialName));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            using var scope = _clientDiagnostics.CreateScope("CredentialsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(credentialName, credential, ifMatch, cancellationToken).ConfigureAwait(false);
                return new CredentialsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(credentialName, credential, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a credential. </summary>
        /// <param name="credentialName"> Credential name. </param>
        /// <param name="credential"> Credential resource definition. </param>
        /// <param name="ifMatch"> ETag of the credential entity.  Should only be specified for update, for which it should match existing entity or can be * for unconditional update. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentialName"/> or <paramref name="credential"/> is null. </exception>
        public virtual CredentialsCreateOrUpdateOperation StartCreateOrUpdate(string credentialName, ManagedIdentityCredentialResource credential, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (credentialName == null)
            {
                throw new ArgumentNullException(nameof(credentialName));
            }
            if (credential == null)
            {
                throw new ArgumentNullException(nameof(credential));
            }

            using var scope = _clientDiagnostics.CreateScope("CredentialsClient.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(credentialName, credential, ifMatch, cancellationToken);
                return new CredentialsCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(credentialName, credential, ifMatch).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
