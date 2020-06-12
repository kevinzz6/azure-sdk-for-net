// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Resources;

namespace Azure.Management.Resources
{
    /// <summary> Resources service management client. </summary>
    public class ResourcesManagementClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        private readonly string _subscriptionId;
        private readonly Uri _endpoint;

        /// <summary> Initializes a new instance of ResourcesManagementClient for mocking. </summary>
        protected ResourcesManagementClient()
        {
        }

        /// <summary> Initializes a new instance of ResourcesManagementClient. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        public ResourcesManagementClient(string subscriptionId, TokenCredential tokenCredential, ResourcesManagementClientOptions options = null) : this(subscriptionId, null, tokenCredential, options)
        {
        }
        /// <summary> Initializes a new instance of ResourcesManagementClient. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="tokenCredential"> The OAuth token for making client requests. </param>
        /// <param name="options"> The options for configuring the client. </param>
        /// <exception cref="ArgumentNullException"> This occurs when one of the required arguments is null. </exception>
        public ResourcesManagementClient(string subscriptionId, Uri endpoint, TokenCredential tokenCredential, ResourcesManagementClientOptions options = null)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            endpoint ??= new Uri("https://management.azure.com");

            options ??= new ResourcesManagementClientOptions();
            _clientDiagnostics = new ClientDiagnostics(options);
            _pipeline = ManagementPipelineBuilder.Build(tokenCredential, endpoint, options);
            _subscriptionId = subscriptionId;
            _endpoint = endpoint;
        }

        /// <summary> Returns an instance of DeploymentsOperations. </summary>
        public virtual DeploymentsOperations Deployments => new DeploymentsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of ProvidersOperations. </summary>
        public virtual ProvidersOperations Providers => new ProvidersOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of ResourcesOperations. </summary>
        public virtual ResourcesOperations Resources => new ResourcesOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of ResourceGroupsOperations. </summary>
        public virtual ResourceGroupsOperations ResourceGroups => new ResourceGroupsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of TagsOperations. </summary>
        public virtual TagsOperations Tags => new TagsOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);

        /// <summary> Returns an instance of DeploymentOperations. </summary>
        public virtual DeploymentOperations Deployment => new DeploymentOperations(_clientDiagnostics, _pipeline, _subscriptionId, _endpoint);
    }
}
