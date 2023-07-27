// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    internal partial class LoadBalancerBackendAddressPoolsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of LoadBalancerBackendAddressPoolsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public LoadBalancerBackendAddressPoolsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-02-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string loadBalancerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/loadBalancers/", false);
            uri.AppendPath(loadBalancerName, true);
            uri.AppendPath("/backendAddressPools", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all the load balancer backed address pools. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LoadBalancerBackendAddressPoolListResult>> ListAsync(string subscriptionId, string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, loadBalancerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LoadBalancerBackendAddressPoolListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LoadBalancerBackendAddressPoolListResult.DeserializeLoadBalancerBackendAddressPoolListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all the load balancer backed address pools. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LoadBalancerBackendAddressPoolListResult> List(string subscriptionId, string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, loadBalancerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LoadBalancerBackendAddressPoolListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LoadBalancerBackendAddressPoolListResult.DeserializeLoadBalancerBackendAddressPoolListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string loadBalancerName, string backendAddressPoolName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/loadBalancers/", false);
            uri.AppendPath(loadBalancerName, true);
            uri.AppendPath("/backendAddressPools/", false);
            uri.AppendPath(backendAddressPoolName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets load balancer backend address pool. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/> or <paramref name="backendAddressPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/> or <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<BackendAddressPoolData>> GetAsync(string subscriptionId, string resourceGroupName, string loadBalancerName, string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, loadBalancerName, backendAddressPoolName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackendAddressPoolData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = BackendAddressPoolData.DeserializeBackendAddressPoolData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BackendAddressPoolData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets load balancer backend address pool. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/> or <paramref name="backendAddressPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/> or <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<BackendAddressPoolData> Get(string subscriptionId, string resourceGroupName, string loadBalancerName, string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, loadBalancerName, backendAddressPoolName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        BackendAddressPoolData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = BackendAddressPoolData.DeserializeBackendAddressPoolData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((BackendAddressPoolData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string subscriptionId, string resourceGroupName, string loadBalancerName, string backendAddressPoolName, BackendAddressPoolData data)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/loadBalancers/", false);
            uri.AppendPath(loadBalancerName, true);
            uri.AppendPath("/backendAddressPools/", false);
            uri.AppendPath(backendAddressPoolName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            request.Headers.Add("Content-Type", "application/json");
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(data);
            request.Content = content;
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Creates or updates a load balancer backend address pool. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="data"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/>, <paramref name="backendAddressPoolName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/> or <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> CreateOrUpdateAsync(string subscriptionId, string resourceGroupName, string loadBalancerName, string backendAddressPoolName, BackendAddressPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, loadBalancerName, backendAddressPoolName, data);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Creates or updates a load balancer backend address pool. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="data"> Parameters supplied to the create or update load balancer backend address pool operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/>, <paramref name="backendAddressPoolName"/> or <paramref name="data"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/> or <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response CreateOrUpdate(string subscriptionId, string resourceGroupName, string loadBalancerName, string backendAddressPoolName, BackendAddressPoolData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));
            Argument.AssertNotNull(data, nameof(data));

            using var message = CreateCreateOrUpdateRequest(subscriptionId, resourceGroupName, loadBalancerName, backendAddressPoolName, data);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 201:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateDeleteRequest(string subscriptionId, string resourceGroupName, string loadBalancerName, string backendAddressPoolName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Network/loadBalancers/", false);
            uri.AppendPath(loadBalancerName, true);
            uri.AppendPath("/backendAddressPools/", false);
            uri.AppendPath(backendAddressPoolName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Deletes the specified load balancer backend address pool. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/> or <paramref name="backendAddressPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/> or <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response> DeleteAsync(string subscriptionId, string resourceGroupName, string loadBalancerName, string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, loadBalancerName, backendAddressPoolName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Deletes the specified load balancer backend address pool. </summary>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="backendAddressPoolName"> The name of the backend address pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/> or <paramref name="backendAddressPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="loadBalancerName"/> or <paramref name="backendAddressPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response Delete(string subscriptionId, string resourceGroupName, string loadBalancerName, string backendAddressPoolName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));
            Argument.AssertNotNullOrEmpty(backendAddressPoolName, nameof(backendAddressPoolName));

            using var message = CreateDeleteRequest(subscriptionId, resourceGroupName, loadBalancerName, backendAddressPoolName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                case 202:
                case 204:
                    return message.Response;
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string loadBalancerName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets all the load balancer backed address pools. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LoadBalancerBackendAddressPoolListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, loadBalancerName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LoadBalancerBackendAddressPoolListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = LoadBalancerBackendAddressPoolListResult.DeserializeLoadBalancerBackendAddressPoolListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets all the load balancer backed address pools. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="loadBalancerName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LoadBalancerBackendAddressPoolListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string loadBalancerName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(loadBalancerName, nameof(loadBalancerName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, loadBalancerName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LoadBalancerBackendAddressPoolListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = LoadBalancerBackendAddressPoolListResult.DeserializeLoadBalancerBackendAddressPoolListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
